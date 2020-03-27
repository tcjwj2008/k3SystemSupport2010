﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using YXK3FZ.DataClass;
using YXK3FZ.ComClass;


namespace YXK3FZ.RYGYL
{
    public partial class frm_yunrui_Item_Insert : Form
    {
        DataBase db = new DataBase();
        DataSet ds = null;
        CommonUse commUse = new CommonUse();
        DataBase k3db = null;

        string ZtRyconstring = string.Empty; //获取K3账套连接字符串
        public frm_yunrui_Item_Insert()
        {
            InitializeComponent();
            ds = db.GetDataSet("SELECT Fdbstr  FROM dbo.YXZTLIST WHERE ID=2", "con");
            DataRow dr = ds.Tables[0].Rows[0];
            ZtRyconstring = dr["Fdbstr"].ToString(); //获取K3账套连接字符串
            k3db = new DataBase(ZtRyconstring);
        }

        private void frm_yunrui_Item_Insert_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            string FNumber = "";
            FNumber = textBox1.Text.Trim();
            if (FNumber == "")
            {
                MessageBox.Show("请输入物料编码");
                return;
            }
            string sql = "SELECT  * FROM dbo.t_ICItem WHERE FNumber ='" + FNumber + "'";           
            DataTable FNameNew = DataBase.ExecuteDataTable(ZtRyconstring, sql, CommandType.Text);
            //    k3db.GetDataReader(sql).ToString();
            if (FNameNew.Rows.Count == 0)
            {
                MessageBox.Show("该物料在K3不存在");
                return;
            }

            sql = "exec yunrui_item_insert_csp '" + FNumber + "'";
            int Execdata = 0;
            Execdata = k3db.ExecDataBySql(sql);
            if (Execdata == 0)
            {
                MessageBox.Show("同步失败");
                return;
            }
            MessageBox.Show("同步成功");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
