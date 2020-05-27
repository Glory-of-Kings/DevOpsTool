using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.lbxTables.Items.AddRange(new string[] {
            "box_enter_record", "box_out_record", "box_bill"});
            SetMapTableIndex();
        }
        /// <summary>
        /// 设置归档表对应的表名称
        /// </summary>
        public void SetMapTableIndex()
        {
            foreach (var index in this.lbxTables.Items)
            {
                this.lbxMapTables.Items.Add(index.ToString() + "_" + DateTime.Now.Year.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxSource.Text) || string.IsNullOrEmpty(tbxPort.Text)
                || string.IsNullOrEmpty(tbxUserName.Text) || string.IsNullOrEmpty(tbxPassword.Text)
                || string.IsNullOrEmpty(tbxDataName.Text))
            {
                MessageBox.Show("数据库信息不能为空！");
                return;
            }
            string conn = string.Format("Data Source={0};port={1};User ID={2};Password={3};Initial Catalog={4};", tbxSource.Text,
                            tbxPort.Text, tbxUserName.Text, tbxPassword.Text, tbxDataName.Text);
            MySqlHelp.ConnectionStr = string.Format(@"{0}Persist Security Info=True; Max Pool Size=2000; Min Pool Size = 30; Connection Lifetime=30;
                Connection Timeout=30; Pooling=true;charset=utf8", conn);
            if (MySqlHelp.TestConn(MySqlHelp.ConnectionStr))
            {
                MessageBox.Show("数据库连接成功");
            }
            else
            {
                MessageBox.Show("数据库连接失败，请检查数据库配置");
            }
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tbxAddTable.Text))
            {
                MessageBox.Show("请填写需要增加的表名称！");
                return;
            }
            this.lbxTables.Items.Add(this.tbxAddTable.Text);
            this.lbxMapTables.Items.Add(this.tbxAddTable.Text + "_" + DateTime.Now.Year.ToString());
        }

        private void btnConstrast_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.lbxTables.Items.Count; i++)
            {
                ConstrastTable(this.lbxTables.Items[i].ToString(), this.lbxMapTables.Items[i].ToString());
            }
        }

        public void ConstrastTable(string tableName, string mapTableName)
        {
            //1.获取两表的特征值
            List<TableCharacter> listTablechar = GetTableCharacters(tableName);
            List<TableCharacter> listMapTablechar = GetTableCharacters(mapTableName);
            if (listTablechar.Count <= 0)
            {
                this.rtbResult.Text += string.Format("不存在表{0}\n", tableName);
                return;
            }
            if (listMapTablechar.Count <= 0)
            {
                this.rtbResult.Text += string.Format("不存在表{0}\n", mapTableName);
                return;
            }
            if (listMapTablechar.Count <= listTablechar.Count)
            {
                string str = "";
                foreach (TableCharacter index in listTablechar)
                {
                    if (!containsInList(index, listMapTablechar))
                    {
                        str += string.Format("{0}和{1}字段{2}不一致", tableName, mapTableName, index.Field);
                    }
                }
                if (str == "")
                {
                    str += string.Format("{0}和{1}两表一致", tableName, mapTableName);
                }
                this.rtbResult.Text += str + "\n";
            }
            if (listMapTablechar.Count >= listTablechar.Count)
            {
                string str = "";
                foreach (var index in listMapTablechar)
                {
                    if (!containsInList(index, listTablechar))
                    {
                        str += string.Format("表{0}存在字段{1}而表{2}不存在", mapTableName, index.Field, tableName);
                    }
                }
                this.rtbResult.Text += str + "\n";
            }


        }
        /// <summary>
        /// 判断表字段集合中是否存在某字段
        /// </summary>
        /// <param name="index"></param>
        /// <param name="list"></param>
        /// <returns></returns>
        public bool containsInList(TableCharacter index, List<TableCharacter> list)
        {
            bool contains = false;
            foreach (var temp in list)
            {
                if (temp.Field == index.Field)
                {
                    contains = true;
                    break;
                }
            }
            return contains;
        }
        /// <summary>
        /// 获取表的字段和属性值
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public List<TableCharacter> GetTableCharacters(string tableName)
        {
            List<TableCharacter> lstTableChar = new List<TableCharacter>();
            string sql = string.Format("desc {0}", tableName);
            DataTable dt = MySqlHelp.ExecuteSql(MySqlHelp.ConnectionStr, sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    TableCharacter temp = new TableCharacter();
                    temp.Field = dr["Field"].ToString();
                    temp.Type = dr["Type"].ToString();
                    lstTableChar.Add(temp);
                }
            }
            return lstTableChar;
        }

        private void btnModifyArchiveTab_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.lbxTables.Items.Count; i++)
            {
                ModifyTable(this.lbxTables.Items[i].ToString(), this.lbxMapTables.Items[i].ToString());
            }
        }

        public void ModifyTable(string tableName, string mapTableName)
        {
            //1.获取两表的特征值
            List<TableCharacter> listTablechar = GetTableCharacters(tableName);
            List<TableCharacter> listMapTablechar = GetTableCharacters(mapTableName);

            if (listMapTablechar.Count <= 0)
            {
                string sql = string.Format("create table {0} like {1};", mapTableName, tableName);
                MySqlHelp.ExecuteNonQuery(MySqlHelp.ConnectionStr, sql, null);
                this.rtbResult.Text += string.Format("表{0}创建成功\n", mapTableName);
                return;
            }
            if (listMapTablechar.Count <= listTablechar.Count)
            {
                string str = "";
                string sql = "";
                foreach (var index in listTablechar)
                {
                    if (!containsInList(index, listMapTablechar))
                    {
                        //归档表不存在该字段时，则新增字段
                        if (!ContainCol(mapTableName, index.Field))
                        {
                            sql += string.Format("alter table {0} add {1} {2} ;", mapTableName, index.Field, index.Type);
                            str += string.Format("增加字段{0}", index.Field);
                        }
                    }
                }
                MySqlHelp.ExecuteNonQuery(MySqlHelp.ConnectionStr, sql, null);
                this.rtbResult.Text += str + "\n";
            }
            //if (listMapTablechar.Count >= listTablechar.Count)
            //{
            //    string str = "";
            //    foreach (var index in listMapTablechar)
            //    {
            //        if (!listTablechar.Contains(index))
            //        {
            //            str += string.Format("表{0}存在字段{1}而表{2}不存在", mapTableName, index.Field, tableName);
            //        }
            //    }
            //    this.lbxResult.Items.Add(str);
            //}

        }

        public bool ContainCol(string tableName, string colName)
        {
            bool containCol = false;
            string sql = string.Format("select count(*) from information_schema.columns where table_name = '{0}' and column_name = '{1}'", tableName, colName);
            DataTable dt = MySqlHelp.ExecuteSql(MySqlHelp.ConnectionStr, sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["count(*)"].ToString() == "1")
                {
                    containCol = true;
                }
            }
            return containCol;
        }

    }
}
