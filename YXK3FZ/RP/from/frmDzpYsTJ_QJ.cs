using System;
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
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.IO;   //特別引用流 System.IO
using System.Data.OleDb;
using System.Runtime.InteropServices;
using System.Collections;

namespace YXK3FZ.RP.from
{
    public partial class frmDzpYsTJ_QJ : Form
    {
        DataBase db = new DataBase();
        DataBase k3db = null;
        DataTable dt = new DataTable();
        DataSet ds = null;
        CommonUse commUse = new CommonUse();
        string year;
        string month;
        string year1;
        string month1;
        string fcur;

        public frmDzpYsTJ_QJ()
        {
            InitializeComponent();
        }

        private int _DB_ID = 4; //修改CZQ 2015-09-16
        public int DB_ID
        {
            get { return _DB_ID; }
            set { _DB_ID = value; }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

            if (this.txtYear.Text == "" || this.txtMonth.Text == "")
            {
                MessageBox.Show("请输入查询开始年份和期间！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;

            }

            if (this.txtYear1.Text == "" || this.txtMonth1.Text == "")
            {
                MessageBox.Show("请输入查询结束年份和期间！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;

            }


     

            try { int.Parse(this.txtYear.Text.Trim()); int.Parse(this.txtMonth.Text.Trim()); }
            catch
            {
                MessageBox.Show("输入非数字！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            try { int.Parse(this.txtYear1.Text.Trim()); int.Parse(this.txtMonth1.Text.Trim()); }
            catch
            {
                MessageBox.Show("输入非数字！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }



            if (int.Parse(this.txtYear1.Text) * 12 + int.Parse(this.txtMonth1.Text) < int.Parse(this.txtYear.Text) * 12 + int.Parse(this.txtMonth.Text))
            {
                MessageBox.Show("开始期间必须大于结束期间！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;

            }





            year = this.txtYear.Text.Trim(); ;
            month = this.txtMonth.Text.Trim();
            year1 = this.txtYear1.Text.Trim();
            month1 = this.txtMonth1.Text.Trim();


            try
            {
                fcur = this.txtFcur.Text.Trim();
            }
            catch
            {
                fcur = "";
            }

    //@year_begin VARCHAR(10) ,   
    //@month_begin VARCHAR(10) ,   
    //@year_end VARCHAR(10) ,   --年月份
    //@month_end VARCHAR(10) ,  --年月份    
    //@fcur VARCHAR(100) ,
    //@isALL INT ,
    //@pq VARCHAR(100)


            WaitFormService.CreateWaitForm();
            WaitFormService.SetWaitFormCaption(" 正在查询，请稍候......");
            SqlParameter param1 = new SqlParameter("@year_begin", SqlDbType.VarChar);
            param1.Value = this.txtYear.Text.Trim();
            SqlParameter param2 = new SqlParameter("@month_begin", SqlDbType.VarChar);
            param2.Value = this.txtMonth.Text.Trim();

            SqlParameter param3 = new SqlParameter("@year_end", SqlDbType.VarChar);
            param3.Value = this.txtYear1.Text.Trim();
            SqlParameter param4 = new SqlParameter("@month_end", SqlDbType.VarChar);
            param4.Value = this.txtMonth1.Text.Trim();

            SqlParameter param5 = new SqlParameter("@fcur", SqlDbType.VarChar);
            param5.Value = fcur;
            SqlParameter param6 = new SqlParameter("@isALL", SqlDbType.Int);
            if (this.radioButton1.Checked == true)//
            {
                param6.Value = 1;
            }
            else
            {
                param6.Value = 0;
            }
            //片区
            SqlParameter param7 = new SqlParameter("@pq", SqlDbType.VarChar);
            param7.Value = this.txtPq.Text.Trim();

            //创建泛型
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(param1);
            parameters.Add(param2);
            parameters.Add(param3);
            parameters.Add(param4);
            parameters.Add(param5);
            parameters.Add(param6);
            parameters.Add(param7);
            //把泛型中的元素复制到数组中
            SqlParameter[] inputParameters = parameters.ToArray();
            try
            {

                //if (DB_ID == 4 && Convert.ToInt32(year) == 2018 && Convert.ToInt32(month) == 1)
                //{
                //    dt = k3db.GetDataTable("sp_DzpYsTJ_ts201801", inputParameters);
                //}
                //else
                {

                    dt = k3db.GetDataTable("sp_DzpYsTJ_qiu", inputParameters);
                }

                this.dataGridView1.DataSource = dt;
                this.dataGridView1.Columns[0].Visible = false;
                WaitFormService.CloseWaitForm();
            }
            catch (Exception ex)
            {
                WaitFormService.CloseWaitForm();
                MessageBox.Show("查询失败!" + ex.ToString(), "软件提示");
                return;


            }


        }

        private void frmDzpYsTJ_QJ_Load(object sender, EventArgs e)
        {
            commUse.CortrolButtonEnabled(btnSelect, this);
      
            //get con
            if (DB_ID == 4) //修改CZQ 2015-09-16
            {
                ds = db.GetDataSet("SELECT Fdbstr    FROM dbo.YXZTLIST WHERE ID=4", "con");
            }
            else if (DB_ID == 7)
            {
                ds = db.GetDataSet("SELECT Fdbstr    FROM dbo.YXZTLIST WHERE ID=7", "con");
            }
            else if (DB_ID == 17)
            {
                ds = db.GetDataSet("SELECT Fdbstr    FROM dbo.YXZTLIST WHERE ID=17", "con");
            }
            else if (DB_ID == 2)
            {
                ds = db.GetDataSet("SELECT Fdbstr    FROM dbo.YXZTLIST WHERE ID=2", "con");
            }
            string dzpcon = ds.Tables[0].Rows[0]["Fdbstr"].ToString();
            k3db = new DataBase(dzpcon);
            this.txtYear.Text = DateTime.Now.Year.ToString();
            this.txtMonth.Text = DateTime.Now.Month.ToString();
            this.radioButton1.Checked = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
