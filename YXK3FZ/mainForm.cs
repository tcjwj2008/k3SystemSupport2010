using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


//插入内部空间文件
using YXK3FZ.DataClass;
using YXK3FZ.Properties;
using YXK3FZ.ComClass;
using YXK3FZ.SY;
using YXK3FZ.CC;
using YXK3FZ.CW;
using YXK3FZ.SO;
using YXK3FZ.RYGYL;
using YXK3FZ.RP.from;
using System.Threading;
using System.Reflection;
using YXK3FZ.RP.rpt;


namespace YXK3FZ
{
    public partial class mainForm : SMes.Controls.ExtendForm.BaseForm
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            this.dataGridViewEx1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            this.dataGridViewEx1.RowTemplate.Height = 40;
            this.dataGridViewEx2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            this.dataGridViewEx2.RowTemplate.Height = 40;
            this.dataGridViewEx3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            this.dataGridViewEx3.RowTemplate.Height = 40;
            this.dataGridViewEx4.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            this.dataGridViewEx4.RowTemplate.Height = 40;
            this.dataGridViewEx5.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            this.dataGridViewEx5.RowTemplate.Height = 40;
            this.dataGridViewEx6.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            this.dataGridViewEx6.RowTemplate.Height = 40;
            this.dataGridViewEx7.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            this.dataGridViewEx7.RowTemplate.Height = 40;
            //this.dataGridViewEx1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            //this.dataGridViewEx1.RowTemplate.Height = 40;
        }

        private void kryptonColorButton1_DoubleClick(object sender, EventArgs e)
        {
          
				//string BGDate = Convert.ToDateTime(dateTimePicker1.Text).ToString("yyyy-MM-dd");
				//string EndDate = Convert.ToDateTime(dateTimePicker2.Text).ToString("yyyy-MM-dd");
				try
				{
					DataTable cb = SqlHelperERP.ExecuteDataTable(@"select * from smes_functionName", CommandType.Text);
					this.dataGridViewEx1.DataSource = cb;					
				}
				catch (Exception err)
				{				
					MessageBox.Show("操作失败！" + err.ToString());

				}

        }


        //关于打开窗体的方法
        private void execFunction(string sFormClass)
        {

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == sFormClass)
                {
                    f.Activate();
                    return;
                }
            }
            ((Form)Activator.CreateInstance(System.Reflection.Assembly.GetExecutingAssembly().GetType(@"YXK3FZ.RYGL.frmXSBase"))).Show();
                      
        }

        private void kryptonColorButton1_Click(object sender, EventArgs e)
        {
				try
				{
					DataTable cb = SqlHelperERP.ExecuteDataTable(@"select functionid as 功能编码,functionname 功能名称,usenum 使用次数 from yx_functionName where orgid=1 and                                                                                                                                                                   functiongroup=1001", CommandType.Text);
					this.dataGridViewEx1.DataSource = cb;					
				}
				catch (Exception err)
				{				
					MessageBox.Show("操作失败！" + err.ToString());

				}
        }

        private void dataGridViewEx1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {     

                string exePath = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.Rows[e.RowIndex].Cells[1].Value);            
                try
                {
                        if (exePath == null)
                            return;                     


                        if (exePath == "肉业食品经营表")
                        {

                            foreach (Form f in Application.OpenForms)
                            {
                                if (f.Name == "frmRSjy")
                                {
                                    f.Activate();
                                    return;
                                }
                            }

                            frmRSjy frmRSjy = new frmRSjy();
                            frmRSjy.Show();  
                        }
                        else if (exePath == "肉业食品经营表New")
                        {

                            foreach (Form f in Application.OpenForms)
                            {
                                if (f.Name == "frmNewRSjy")
                                {
                                    f.Activate();
                                    return;
                                }
                            }
                            frmNewRSjy frmNewRSjy = new frmNewRSjy();
                            frmNewRSjy.Show();  
                        }

                        else if (exePath == "白条收款表-按客户编码排序")
                        {

                            foreach (Form f in Application.OpenForms)
                            {
                                if (f.Name == "frmBTpfsk_Orderby")
                                {
                                    f.Activate();
                                    return;
                                }
                            }
                            frmBTpfsk_Orderby frmBTpfsk_Orderby = new frmBTpfsk_Orderby();
                            frmBTpfsk_Orderby.Show();
                        }
                        else if (exePath == "白条收款表")
                        {

                            foreach (Form f in Application.OpenForms)
                            {
                                if (f.Name == "frmBTpfsk")
                                {
                                    f.Activate();
                                    return;
                                }
                            }
                            frmBTpfsk frmBTpfsk = new frmBTpfsk();
                            frmBTpfsk.Show();
                        }


                        else if (exePath == "白条收款明细表")
                        {

                            foreach (Form f in Application.OpenForms)
                            {
                                if (f.Name == "frmBTpfskdz")
                                {
                                    f.Activate();
                                    return;
                                }
                            }
                            frmBTpfskdz frmBTpfskdz = new frmBTpfskdz();
                            frmBTpfskdz.Show();
                        }

                        else if (exePath == "日成本外购明细")
                        {

                          //  MessageBox.Show("无权限!");
                            return;
                        }

                        else if (exePath == "内业应收统计表")
                        {

                            foreach (Form f in Application.OpenForms)
                            {
                                if (f.Name == "frmDzpYsTJ")
                                {
                                    f.Activate();
                                    return;
                                }
                            }
                            frmDzpYsTJ frmDzpYsTJ = new frmDzpYsTJ();
                            frmDzpYsTJ.DB_ID = 2;  //传递数据库表所在连接字符串
                            frmDzpYsTJ.Show();
                        }

                        else if (exePath == "肉业应收明细-对账")
                        {

                            foreach (Form f in Application.OpenForms)
                            {
                                if (f.Name == "frmDzpYsmx")
                                {
                                    f.Activate();
                                    return;
                                }
                            }
                            frmDzpYsmx frmDzpYsmx = new frmDzpYsmx();
                            frmDzpYsmx.DB_ID = 2;//传递数据库表所在连接字符串
                            frmDzpYsmx.Show();
                        }

                        else if (exePath == "肉业成本-门店收入明细")
                        {
                          //  MessageBox.Show("无权限!");
                            return;
                        }




                        else if (exePath == "肉业-食品调拨单价调整")
                        {

                            foreach (Form f in Application.OpenForms)
                            {
                                if (f.Name == "frmPriceMage")
                                {
                                    f.Activate();
                                    return;
                                }
                            }

                            frmPriceMager frmPriceMage = new frmPriceMager();
                            frmPriceMage.Show();
                        }
                        else if (exePath == "肉业帐套—导入销售出库")
                        {

                            foreach (Form f in Application.OpenForms)
                            {
                                if (f.Name == "frmXSBase")
                                {
                                    f.Activate();
                                    return;
                                }
                            }
                            YXK3FZ.RYGL.frmXSBase frm = new YXK3FZ.RYGL.frmXSBase();
                            frm.Show();
                        }




                        else if (exePath == "系数设置")
                        {
                           
                            foreach (Form f in Application.OpenForms)
                            {
                                if (f.Name == "frm_ry_in_icstock_xs")
                                {
                                    f.Activate();
                                    return;
                                }
                            }
                            frm_ry_in_icstock_xs frm_ry_in_icstock_xs = new frm_ry_in_icstock_xs();
                            frm_ry_in_icstock_xs.Show();
                        }
                        else if (exePath == "成本查询")
                        {
                          
                            foreach (Form f in Application.OpenForms)
                            {
                                if (f.Name == "frmCostQueryForm")
                                {
                                    f.Activate();
                                    return;
                                }
                            }
                            YXK3FZ.RYGL.frmCostQueryForm frm = new YXK3FZ.RYGL.frmCostQueryForm();
                            frm.Show();

                         
                        }
                        else if (exePath == "每天数据录入")
                        {
                           
                            foreach (Form f in Application.OpenForms)
                            {
                                if (f.Name == "frmRYGLDayBase")
                                {
                                    f.Activate();
                                    return;
                                }
                            }
                            YXK3FZ.RYGL.frmRYGLDayBase frm = new YXK3FZ.RYGL.frmRYGLDayBase();
                            frm.Show();

                          
                        }
                        else if (exePath == "每月数据录入")
                        {
                          
                            foreach (Form f in Application.OpenForms)
                            {
                                if (f.Name == "frmRYGLMonthBase")
                                {
                                    f.Activate();
                                    return;
                                }
                            }
                            YXK3FZ.RYGL.frmRYGLMonthBase frm = new YXK3FZ.RYGL.frmRYGLMonthBase();
                            frm.Show();

                           
                        }
						           
                        else if (exePath == "数据汇总查询")
						            {

							         

							            foreach (Form f in Application.OpenForms)
							            {
								            if (f.Name == "frmQuery")
								            {
									            f.Activate();
									            return;
								            }
							            }
							            YXK3FZ.RYGL.frmQuery frm = new YXK3FZ.RYGL.frmQuery();
							            frm.Show();


							        

						            }
						else if (exePath == "肉业公司日成本分析")
						            {

							          

							            foreach (Form f in Application.OpenForms)
							            {
								            if (f.Name == "frmRYDayPrice")
								            {
									            f.Activate();
									            return;
								            }
							            }
							            YXK3FZ.RYGL.frmRYDayPrice frm = new YXK3FZ.RYGL.frmRYDayPrice();
							            frm.Show();							        

						            }


                        else if (exePath == "修改客户代码")
                        {
                          
                            foreach (Form f in Application.OpenForms)
                            {
                                if (f.Name == "frm_yunrui_customer")
                                {
                                    f.Activate();
                                    return;
                                }
                            }
                            YXK3FZ.RYGYL.frm_yunrui_customer frm_yunrui_customer = new frm_yunrui_customer();
                            frm_yunrui_customer.Show();    
                    

                        }

                        else if (exePath == "修改物料代码")
                        {

                            foreach (Form f in Application.OpenForms)
                            {
                                if (f.Name == "frm_yunrui_Item")
                                {
                                    f.Activate();
                                    return;
                                }
                            }
                            YXK3FZ.RYGYL.frm_yunrui_Item frm_yunrui_item = new frm_yunrui_Item();
                            frm_yunrui_item.Show();

                        }

                        else if (exePath == "客户导入云睿")
                        {

                            foreach (Form f in Application.OpenForms)
                            {
                                if (f.Name == "frm_yunrui_Organization_Insert")
                                {
                                    f.Activate();
                                    return;
                                }
                            }
                            YXK3FZ.RYGYL.frm_yunrui_Organization_Insert frm_yunrui_item = new frm_yunrui_Organization_Insert();
                            frm_yunrui_item.Show();

                        }

                        else if (exePath == "物料导入云睿")
                        {

                            foreach (Form f in Application.OpenForms)
                            {
                                if (f.Name == "frm_yunrui_Item_Insert")
                                {
                                    f.Activate();
                                    return;
                                }
                            }
                            YXK3FZ.RYGYL.frm_yunrui_Item_Insert frm_yunrui_item = new frm_yunrui_Item_Insert();
                            frm_yunrui_item.Show();

                        }
           
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }  
					

            }
        }

        private void kryptonColorButton6_Click(object sender, EventArgs e)
        {
            try{
       		DataTable cb = SqlHelperERP.ExecuteDataTable(@"select functioncode as 功能编码,functionname 功能名称 ,classname from yx_functionName where orgid=1 and                                                                                                                                                                   functiongroup=1001", CommandType.Text);
					this.dataGridViewEx1.DataSource = cb;					
				}
				catch (Exception err)
				{				
					MessageBox.Show("操作失败！" + err.ToString());

				}
        }

        private void kryptonColorButton22_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable cb = SqlHelperERP.ExecuteDataTable(@"select functioncode as 功能编码,functionname 功能名称  from yx_functionName where orgid=1 and                                                                                                                                                                   functiongroup=1002", CommandType.Text);
                this.dataGridViewEx1.DataSource = cb;
            }
            catch (Exception err)
            {
                MessageBox.Show("操作失败！" + err.ToString());

            }
        }

        private void kryptonColorButton10_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable cb = SqlHelperERP.ExecuteDataTable(@"select functioncode as 功能编码,functionname 功能名称  from yx_functionName where orgid=4 and                                                                                                                                                                   functiongroup=1002", CommandType.Text);
                this.dataGridViewEx4.DataSource = cb;
            }
            catch (Exception err)
            {
                MessageBox.Show("操作失败！" + err.ToString());

            }
        }

        private void kryptonColorButton29_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable cb = SqlHelperERP.ExecuteDataTable(@"select functioncode as 功能编码,functionname 功能名称  from yx_functionName where orgid=4 and                                                                                                                                                                   functiongroup=1003", CommandType.Text);
                this.dataGridViewEx4.DataSource = cb;
            }
            catch (Exception err)
            {
                MessageBox.Show("操作失败！" + err.ToString());

            }
        }

        private void kryptonColorButton11_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable cb = SqlHelperERP.ExecuteDataTable(@"select functioncode as 功能编码,functionname 功能名称  from yx_functionName where orgid=4 and                                                                                                                                                                   functiongroup=1001", CommandType.Text);
                this.dataGridViewEx4.DataSource = cb;
            }
            catch (Exception err)
            {
                MessageBox.Show("操作失败！" + err.ToString());

            }
        }

        private void dataGridViewEx4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string exePath = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx4.Rows[e.RowIndex].Cells[1].Value);
            try
            {
                if (exePath == null)
                    return;
                if (exePath == "基础数据录入")
                {
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmYZBase")
                        {
                            f.Activate();
                            return;
                        }
                    }

                    YZGL.frmYZBase frmOrder = new YXK3FZ.YZGL.frmYZBase();
                    frmOrder.Show();
                }
                else if (exePath == "[01新增] 生产部--车间--加工日历")
                {
                    #region 生产部--车间--加工日历
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmYZOrder01")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    YZGL.frmYZOrder01 frmOrder = new YXK3FZ.YZGL.frmYZOrder01("ADD", null);
                    frmOrder.Show();

                    #endregion
                }
                else if (exePath == "[01维护] 生产部--车间--加工日历")
                {
                    #region 生产部--车间--加工日历维护
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmYZOrderList01")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    YZGL.frmYZOrderList01 frmYZOrderList01 = new YXK3FZ.YZGL.frmYZOrderList01();
                    frmYZOrderList01.Show();

                    #endregion
                }

                else if (exePath == "[02新增] 生产部--锅炉科--锅炉车间--加工日历")
                {
                    #region 生产部--锅炉科--锅炉车间--加工日历
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmYZOrder02")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    YZGL.frmYZOrder02 frmOrder02 = new YXK3FZ.YZGL.frmYZOrder02("ADD", null);
                    frmOrder02.Show();

                    #endregion
                }
                else if (exePath == "[02维护] 生产部--锅炉科--锅炉车间--加工日历")
                {
                    #region 生产部--锅炉科--锅炉车间--加工日历维护
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmYZOrderList02")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    YZGL.frmYZOrderList02 frmYZOrderList02 = new YXK3FZ.YZGL.frmYZOrderList02();
                    frmYZOrderList02.Show();

                    #endregion
                }

                else if (exePath == "[03新增] 生产部--锅炉科--环保--加工日历")
                {
                    #region 生产部--锅炉科--环保--加工日历序时簿
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmYZOrder03")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    YZGL.frmYZOrder03 frmOrder03 = new YXK3FZ.YZGL.frmYZOrder03("ADD", null);
                    frmOrder03.Show();

                    #endregion
                }
                else if (exePath == "[03维护] 生产部--锅炉科--环保--加工日历")
                {
                    #region 生产部--锅炉科--环保--加工日历序时簿维护
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmYZOrderList03")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    YZGL.frmYZOrderList03 frmYZOrderList03 = new YXK3FZ.YZGL.frmYZOrderList03();
                    frmYZOrderList03.Show();

                    #endregion
                }

                else if (exePath == "[04新增] 生产部--公用工程--水务科--加工日历(1)")
                {
                    #region 生产部--公用工程--水务科--加工日历(1)
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmYZOrder04")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    YZGL.frmYZOrder04 frmOrder04 = new YXK3FZ.YZGL.frmYZOrder04("ADD", null);
                    frmOrder04.Show();

                    #endregion
                }
                else if (exePath == "[04维护] 生产部--公用工程--水务科--加工日历(1)")
                {
                    #region 生产部--公用工程--水务科--加工日历(1)序时簿维护
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmYZOrderList04")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    YZGL.frmYZOrderList04 frmYZOrderList04 = new YXK3FZ.YZGL.frmYZOrderList04();
                    frmYZOrderList04.Show();

                    #endregion
                }


                else if (exePath == "[05新增] 生产部--公用工程--水务科--加工日历(2)")
                {
                    #region 生产部--公用工程--水务科--加工日历(2)
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmYZOrder05")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    YZGL.frmYZOrder05 frmOrder05 = new YXK3FZ.YZGL.frmYZOrder05("ADD", null);
                    frmOrder05.Show();

                    #endregion
                }
                else if (exePath == "[05维护] 生产部--公用工程--水务科--加工日历(2)")
                {
                    #region 生产部--公用工程--水务科--加工日历(2)序时簿维护
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmYZOrderList05")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    YZGL.frmYZOrderList05 frmYZOrderList05 = new YXK3FZ.YZGL.frmYZOrderList05();
                    frmYZOrderList05.Show();

                    #endregion
                }


                else if (exePath == "[06新增] 生产部--公用工程--配电科--加工日历(1)")
                {
                    #region 生产部--公用工程--配电科--加工日历(1)
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmYZOrder06")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    YZGL.frmYZOrder06 frmOrder06 = new YXK3FZ.YZGL.frmYZOrder06("ADD", null);
                    frmOrder06.Show();

                    #endregion
                }
                else if (exePath == "[06维护] 生产部--公用工程--配电科--加工日历(1)")
                {
                    #region 生产部--公用工程--配电科--加工日历(1)序时簿维护
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmYZOrderList06")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    YZGL.frmYZOrderList06 frmYZOrderList06 = new YXK3FZ.YZGL.frmYZOrderList06();
                    frmYZOrderList06.Show();

                    #endregion
                }


                else if (exePath == "[07新增] 生产部--公用工程--配电科--加工日历(2)")
                {
                    #region 生产部--公用工程--配电科--加工日历(2)
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmYZOrder07")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    YZGL.frmYZOrder07 frmOrder07 = new YXK3FZ.YZGL.frmYZOrder07("ADD", null);
                    frmOrder07.Show();

                    #endregion
                }
                else if (exePath == "[07维护] 生产部--公用工程--配电科--加工日历(2)")
                {
                    #region 生产部--公用工程--配电科--加工日历(2)序时簿维护
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmYZOrderList07")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    YZGL.frmYZOrderList07 frmYZOrderList07 = new YXK3FZ.YZGL.frmYZOrderList07();
                    frmYZOrderList07.Show();

                    #endregion
                }

                else if (exePath == "[08新增] 生产部--公用工程--机修科--加工日历")
                {
                    #region 生产部--公用工程--机修科--加工日历
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmYZOrder08")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    YZGL.frmYZOrder08 frmOrder08 = new YXK3FZ.YZGL.frmYZOrder08("ADD", null);
                    frmOrder08.Show();

                    #endregion
                }
                else if (exePath == "[08维护] 生产部--公用工程--机修科--加工日历")
                {
                    #region 生产部--公用工程--机修科--加工日历序时簿维护
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmYZOrderList08")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    YZGL.frmYZOrderList08 frmYZOrderList08 = new YXK3FZ.YZGL.frmYZOrderList08();
                    frmYZOrderList08.Show();

                    #endregion
                }

                else if (exePath == "[09新增] 生产部--仓储--筒仓科--加工日历")
                {
                    #region 生产部--仓储--筒仓科--加工日历
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmYZOrder09")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    YZGL.frmYZOrder09 frmOrder09 = new YXK3FZ.YZGL.frmYZOrder09("ADD", null);
                    frmOrder09.Show();

                    #endregion
                }
                else if (exePath == "[09维护] 生产部--仓储--筒仓科--加工日历")
                {
                    #region 生产部--仓储--筒仓科--加工日历序时簿维护
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmYZOrderList09")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    YZGL.frmYZOrderList09 frmYZOrderList09 = new YXK3FZ.YZGL.frmYZOrderList09();
                    frmYZOrderList09.Show();

                    #endregion
                }


                else if (exePath == "[10新增] 生产部--仓储--油库科--加工日历")
                {
                    #region 生产部--仓储--油库科--加工日历
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmYZOrder10")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    YZGL.frmYZOrder10 frmOrder10 = new YXK3FZ.YZGL.frmYZOrder10("ADD", null);
                    frmOrder10.Show();

                    #endregion
                }
                else if (exePath == "[10维护] 生产部--仓储--油库科--加工日历")
                {
                    #region 生产部--仓储--油库科--加工日历序时簿维护
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmYZOrderList10")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    YZGL.frmYZOrderList10 frmYZOrderList10 = new YXK3FZ.YZGL.frmYZOrderList10();
                    frmYZOrderList10.Show();

                    #endregion
                }


                else if (exePath == "[11新增] 生产部--仓储--粕库科--加工日历")
                {
                    #region 生产部--仓储--粕库科--加工日历
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmYZOrder11")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    YZGL.frmYZOrder11 frmOrder11 = new YXK3FZ.YZGL.frmYZOrder11("ADD", null);
                    frmOrder11.Show();

                    #endregion
                }
                else if (exePath == "[11维护] 生产部--仓储--粕库科--加工日历")
                {
                    #region 生产部--仓储--粕库科--加工日历序时簿维护
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmYZOrderList11")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    YZGL.frmYZOrderList11 frmYZOrderList11 = new YXK3FZ.YZGL.frmYZOrderList11();
                    frmYZOrderList11.Show();

                    #endregion
                }

                else if (exePath == "[12新增] 品管部--质量--加工日历")
                {
                    #region 品管部--质量--加工日历
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmYZOrder12")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    YZGL.frmYZOrder12 frmOrder12 = new YXK3FZ.YZGL.frmYZOrder12("ADD", null);
                    frmOrder12.Show();

                    #endregion
                }
                else if (exePath == "[12维护] 品管部--质量--加工日历")
                {
                    #region 品管部--质量--加工日历序时簿维护
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmYZOrderList12")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    YZGL.frmYZOrderList12 frmYZOrderList12 = new YXK3FZ.YZGL.frmYZOrderList12();
                    frmYZOrderList12.Show();

                    #endregion
                }

                else if (exePath == "[13新增] 管理部--安全科--加工日历")
                {
                    #region 管理部--安全科--加工日历
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmYZOrder13")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    YZGL.frmYZOrder13 frmOrder13 = new YXK3FZ.YZGL.frmYZOrder13("ADD", null);
                    frmOrder13.Show();

                    #endregion
                }
                else if (exePath == "[13维护] 管理部--安全科--加工日历")
                {
                    #region 管理部--安全科--加工日历序时簿维护
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmYZOrderList13")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    YZGL.frmYZOrderList13 frmYZOrderList13 = new YXK3FZ.YZGL.frmYZOrderList13();
                    frmYZOrderList13.Show();

                    #endregion
                }

                if (exePath == "参数指标设定")
                {
                    #region 参数指标设定

                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmYZParameterSet")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    YZGL.frmYZParameterSet frmYZParameterSet = new YXK3FZ.YZGL.frmYZParameterSet();
                    frmYZParameterSet.Show();


                    #endregion
                }
                else if (exePath == "每月计划列表")
                {
                    #region 每月计划列表

                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmYZPerMonthProject")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    YZGL.frmYZPerMonthProject frmYZPerMonthProject = new YXK3FZ.YZGL.frmYZPerMonthProject();
                    frmYZPerMonthProject.Show();


                    #endregion
                }
                else if (exePath == "数据查询列表")
                {
                    #region 数据查询列表
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmFImportDataList")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    YZGL.frmFImportDataList frmFImportDataList = new YXK3FZ.YZGL.frmFImportDataList();
                    frmFImportDataList.Show();

                    #endregion
                }
                //银祥油脂生产系统年度查询
                else if (exePath == "生产系统年度查询")
                {
                    #region 生产系统年度查询

                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmYZYearSelect")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    YZGL.frmYZYearSelect frmYZYearSelect = new YXK3FZ.YZGL.frmYZYearSelect();
                    frmYZYearSelect.Show();


                    #endregion
                }
                else if (exePath == "项目维护")
                {
                    #region 项目维护
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmYZProject")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    YXK3FZ.YZGL.frmYZProject frmYZProject = new YXK3FZ.YZGL.frmYZProject();
                    frmYZProject.Show();

                    #endregion
                }
                else if (exePath == "部门年度自填数据")
                {
                    #region 部门年度自填数据
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmYZDepartYearData")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    YXK3FZ.YZGL.frmYZDepartYearData frmYZDepartYearData = new YXK3FZ.YZGL.frmYZDepartYearData();
                    frmYZDepartYearData.Show();

                    #endregion
                }
                else if (exePath == "船次自填数据")
                {
                    #region 船次自填数据
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmYZBoatYearData")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    YXK3FZ.YZGL.frmYZBoatYearData frmYZBoatYearData = new YXK3FZ.YZGL.frmYZBoatYearData();
                    frmYZBoatYearData.Show();

                    #endregion
                }
                else if (exePath == "油脂绩效考核查询")
                {
                    #region 油脂绩效考核查询
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmYZJXKHSelect")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    YXK3FZ.YZGL.frmYZJXKHSelect frmYZJXKHSelect = new YXK3FZ.YZGL.frmYZJXKHSelect();
                    frmYZJXKHSelect.Show();

                    #endregion
                }
                else if (exePath == "水电部门自填数据")
                {
                    #region 水电部门自填数据
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmYZWaterElecData")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    YXK3FZ.YZGL.frmYZWaterElecData frmYZWaterElecData = new YXK3FZ.YZGL.frmYZWaterElecData();
                    frmYZWaterElecData.Show();

                    #endregion
                }
                else if (exePath == "年度绩效考核成本指标数据(按分项)")
                {
                    #region 年度绩效考核成本指标数据(按分项)
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "YZ_FYearData")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    YXK3FZ.YZGL.YZ_FYearData YZ_FYearData = new YXK3FZ.YZGL.YZ_FYearData();
                    YZ_FYearData.Show();

                    #endregion
                }
                else if (exePath == "年度绩效考核成本指标数据(按部门)")
                {
                    #region 年度绩效考核成本指标数据(按部门)
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "YZ_FYearDataByDept")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    YXK3FZ.YZGL.YZ_FYearDataByDept YZ_FYearDataByDept = new YXK3FZ.YZGL.YZ_FYearDataByDept();
                    YZ_FYearDataByDept.Show();

                    #endregion
                }
                else if (exePath == "船次绩效考核成本指标(按分项)查询")
                {
                    #region 船次绩效考核成本指标(按分项)查询
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "YZ_FBoatJXKH_ByProjet")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    YXK3FZ.YZGL.YZ_FBoatJXKH_ByProjet YZ_FBoatJXKH_ByProjet = new YXK3FZ.YZGL.YZ_FBoatJXKH_ByProjet();
                    YZ_FBoatJXKH_ByProjet.Show();

                    #endregion
                }
                else if (exePath == "船次绩效考核成本指标(按部门)查询")
                {
                    #region 船次绩效考核成本指标(按部门)查询
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "YZ_FBoatJXKH_ByDepart")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    YXK3FZ.YZGL.YZ_FBoatJXKH_ByDepart YZ_FBoatJXKH_ByDepart = new YXK3FZ.YZGL.YZ_FBoatJXKH_ByDepart();
                    YZ_FBoatJXKH_ByDepart.Show();

                    #endregion
                }


                else if (exePath== "CWGL-YZ-06-油脂开具增值税专用(普通)发票申请")
                {
                    #region CWGL-YZ-06-油脂开具增值税专用(普通)发票申请
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmOA_YZ01")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    YXK3FZ.OA.frmOA_YZ01 frmOA_YZ01 = new YXK3FZ.OA.frmOA_YZ01();
                    frmOA_YZ01.Show();

                    #endregion
                }
                else if (exePath== "副合同编号相关数据录入")
                {
                    #region 副合同编号相关数据录入
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmOA_YZ02")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    YXK3FZ.OA.frmOA_YZ02 frmOA_YZ02 = new YXK3FZ.OA.frmOA_YZ02();
                    frmOA_YZ02.Show();

                    #endregion
                }
                else if (exePath== "销售合同执行明细报表查询")
                {
                    #region 副合同编号相关数据录入
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmOA_YZ03")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    YXK3FZ.OA.frmOA_YZ03 frmOA_YZ03 = new YXK3FZ.OA.frmOA_YZ03();
                    frmOA_YZ03.Show();

                    #endregion
                }


            }
            catch (Exception err)
            {
                MessageBox.Show("操作失败！" + err.ToString());

            }
        }

        private void kryptonColorButton14_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable cb = SqlHelperERP.ExecuteDataTable(@"select functioncode as 功能编码,functionname 功能名称  from yx_functionName where orgid=5                                                                   and                                                                                                                                                                   functiongroup=1001", CommandType.Text);
                this.dataGridViewEx5.DataSource = cb;
            }
            catch (Exception err)
            {
                MessageBox.Show("操作失败！" + err.ToString());

            }
        }

        private void dataGridViewEx5_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            
            string exePath = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx5.Rows[e.RowIndex].Cells[1].Value);
            try
            {
                if (exePath == null)
                    return;

                if (exePath == "筐具出入库订单__新增")
                {
                    #region 筐具出入库订单__新增
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmDZPOrder")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    DZPGL.frmDZPOrder frmOrder = new YXK3FZ.DZPGL.frmDZPOrder("D", "ADD", null);
                    frmOrder.Show();

                    #endregion
                }
                else if (exePath == "筐具出入库订单__维护")
                {
                    #region 筐具出入库订单__维护
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmDZPOrderList")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    DZPGL.frmDZPOrderList frmOrderList = new YXK3FZ.DZPGL.frmDZPOrderList("D");
                    frmOrderList.Show();

                    #endregion
                }
                else if (exePath == "筐具出入库订单__报表")
                {
                    #region 筐具出入库订单__报表
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frm_DZPKJ_orderMary")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    DZPGL.frm_DZPKJ_orderMary frmorderMary = new YXK3FZ.DZPGL.frm_DZPKJ_orderMary();
                    frmorderMary.Show();

                    #endregion
                }


                else if (exePath == "豆制品—导入销售出库")
                {
             
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frm_dzp_icstock_csck")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    frm_dzp_icstock_csck ffrm_dzp_icstock_csck = new frm_dzp_icstock_csck();
                    ffrm_dzp_icstock_csck.Show();
 
                }


                else if (exePath == "豆制品应收统计表-按期间查询")
                {

                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmDzpYsTJ_QJ")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    frmDzpYsTJ_QJ frmDzpYsTJ_QJ = new frmDzpYsTJ_QJ();
                    frmDzpYsTJ_QJ.Show();

                }
                else if (exePath == "豆制品—导入收款单")
                {
               
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frm_dzp_receipt")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    frm_dzp_receipt ffrm_dzp_receipt = new frm_dzp_receipt();
                    ffrm_dzp_receipt.Show();

              
                }


                else if (exePath == "豆制品—导入其他收款单")
                {

                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frm_dzp_receipt_other")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    frm_dzp_receipt_other ffrm_dzp_receipt_other = new frm_dzp_receipt_other();
                    ffrm_dzp_receipt_other.Show();

                }

                else if (exePath == "豆制品应收统计表_test")
                {

                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmDzpYsTJ_test")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    frmDzpYsTJ_test frmDzpYsTJ = new frmDzpYsTJ_test();
                    frmDzpYsTJ.DB_ID = 4;  //传递数据库表所在连接字符串
                    frmDzpYsTJ.Show();
                }

                else if (exePath == "豆制品应收统计表")
                {

                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmDzpYsTJ")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    frmDzpYsTJ frmDzpYsTJ = new frmDzpYsTJ();
                    frmDzpYsTJ.DB_ID = 4;  //传递数据库表所在连接字符串
                    frmDzpYsTJ.Show();
                }
                else if (exePath == "豆制品应收统计表Demo1")
                {

                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmDzpYsTJ")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    frmDzpYsTJ frmDzpYsTJ = new frmDzpYsTJ();
                    frmDzpYsTJ.DB_ID = 7;  //传递数据库表所在连接字符串
                    frmDzpYsTJ.Text += "Demo1";
                    frmDzpYsTJ.Show();
                }


                else if (exePath == "豆制品应收统计表-历史")
                {

                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmDzpYsTJ")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    frmDzpYsTJ frmDzpYsTJ = new frmDzpYsTJ();
                    frmDzpYsTJ.DB_ID = 17;  //传递数据库表所在连接字符串
                    frmDzpYsTJ.Text += "历史";
                    frmDzpYsTJ.Show();
                }




                else if (exePath == "豆制品应收明细-对账")
                {

                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmDzpYsmx")
                        {
                            f.Activate();
                            return;
                        }
                    }

                    frmDzpYsmx frmDzpYsmx = new frmDzpYsmx();
                    frmDzpYsmx.DB_ID = 4;//传递数据库表所在连接字符串
                    frmDzpYsmx.Show();
                }


                else if (exePath == "豆制品应收明细-对账Demo1")
                {

                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmDzpYsmx")
                        {
                            f.Activate();
                            return;
                        }
                    }

                    frmDzpYsmx frmDzpYsmx = new frmDzpYsmx();
                    frmDzpYsmx.DB_ID = 7;//传递数据库表所在连接字符串
                    frmDzpYsmx.Text += "Demo1";
                    frmDzpYsmx.Show();
                }


                else if (exePath == "豆制品应收明细对账-历史")
                {

                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmDzpYsmx")
                        {
                            f.Activate();
                            return;
                        }
                    }

                    frmDzpYsmx frmDzpYsmx = new frmDzpYsmx();
                    frmDzpYsmx.DB_ID = 17;//传递数据库表所在连接字符串
                    frmDzpYsmx.Text += "历史";
                    frmDzpYsmx.Show();
                }

            }
            catch (Exception err)
            {
                MessageBox.Show("操作失败！" + err.ToString());

            }
        }

        private void kryptonColorButton16_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable cb = SqlHelperERP.ExecuteDataTable(@"select functioncode as 功能编码,functionname 功能名称  from yx_functionName where orgid=7                                                                  and                                                                                                                                                                   functiongroup=1001", CommandType.Text);
                this.dataGridViewEx6.DataSource = cb;
            }
            catch (Exception err)
            {
                MessageBox.Show("操作失败！" + err.ToString());

            }
        }

        private void dataGridViewEx6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewEx6_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string exePath = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx6.Rows[e.RowIndex].Cells[1].Value);
            try
            {
                if (exePath == null)
                    return;



                if (exePath == "权限管理")
                {               

                    if (PropertyClass.IsAdmin == "1")
                    {

                        foreach (Form f in Application.OpenForms)
                        {
                            if (f.Name == "FormAssignRight")
                            {
                                f.Activate();
                                return;
                            }
                        }

                        FormAssignRight FormAssignRight = new FormAssignRight();
                        FormAssignRight.Show();

                    }
                    else
                    {
                        MessageBox.Show("需管理员权限！", "软件提示");
                        return;
                    }

                 
                }
                else if (exePath == "用户管理")
                {
                    #region 用户管理

                    if (PropertyClass.IsAdmin == "1")
                    {

                        foreach (Form f in Application.OpenForms)
                        {
                            if (f.Name == "frmOperator")
                            {
                                f.Activate();
                                return;
                            }
                        }

                        OperatorForm frmOperator = new OperatorForm();
                        frmOperator.Show();
                    }
                    else
                    {
                        MessageBox.Show("需管理员权限！", "软件提示");
                        return;
                    }
            

                    #endregion
                }
                else if (exePath == "修改密码")
                {
                     
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmPwd")
                        {
                            f.Activate();
                            return;
                        }
                    }

                    frmPwd frmPwd = new frmPwd();
                    frmPwd.Show();  

                  
                }
                else if (exePath == "账套日志管理")
                {
                    
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmWordNote")
                        {
                            f.Activate();
                            return;
                        }
                    }

                    frmWordNote frmWordNote = new frmWordNote();
                    frmWordNote.Show();

                    
                }

                else if (exePath == "发票反钩稽")
                {

                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmSaleConvert")
                        {
                            f.Activate();
                            return;
                        }
                    }

                    frmSaleConvert frmSaleConvert = new frmSaleConvert();
                    frmSaleConvert.Show();


                }
            }
            catch (Exception err)
            {
                MessageBox.Show("操作失败！" + err.ToString());

            }
        }

        private void kryptonColorButton12_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable cb = SqlHelperERP.ExecuteDataTable(@"select functioncode as 功能编码,functionname 功能名称  from yx_functionName where orgid=4                                                                  and                                                                                                                                                                   functiongroup=1004", CommandType.Text);
                this.dataGridViewEx4.DataSource = cb;
            }
            catch (Exception err)
            {
                MessageBox.Show("操作失败！" + err.ToString());

            }
        }

        private void kryptonColorButton20_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable cb = SqlHelperERP.ExecuteDataTable(@"select functioncode as 功能编码,functionname 功能名称  from yx_functionName where orgid=6                                                                  and                                                                                                                                                                         functiongroup=1001", CommandType.Text);
                this.dataGridViewEx7.DataSource = cb;
            }
            catch (Exception err)
            {
                MessageBox.Show("操作失败！" + err.ToString());

            }
        }

        private void dataGridViewEx7_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string exePath = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx7.Rows[e.RowIndex].Cells[1].Value);
            try
            {
                if (exePath == null)
                    return;


          

            if (exePath== "基础数据录入")
            {
                #region 基础数据录入
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Name == "frmYXSLHLBBase")
                    {
                        f.Activate();
                        return;
                    }
                }
                YXSLHLB.frmYXSLHLBBase frmYXSLHLBBase = new YXK3FZ.YXSLHLB.frmYXSLHLBBase();
                frmYXSLHLBBase.Show();

                #endregion
            }
            }
            catch (Exception err)
            {
                MessageBox.Show("操作失败！" + err.ToString());

            }
        }

        private void kryptonColorButton5_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable cb = SqlHelperERP.ExecuteDataTable(@"select functioncode as 功能编码,functionname 功能名称  from yx_functionName where orgid=1 and                                                                                                                                                                   functiongroup=1003", CommandType.Text);
                this.dataGridViewEx1.DataSource = cb;
            }
            catch (Exception err)
            {
                MessageBox.Show("操作失败！" + err.ToString());

            }
        }

        private void kryptonColorButton4_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable cb = SqlHelperERP.ExecuteDataTable(@"select functioncode as 功能编码,functionname 功能名称  from yx_functionName where orgid=1 and                                                                                                                                                                   functiongroup=1004", CommandType.Text);
                this.dataGridViewEx1.DataSource = cb;
            }
            catch (Exception err)
            {
                MessageBox.Show("操作失败！" + err.ToString());

            }
        }

        private void kryptonColorButton24_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable cb = SqlHelperERP.ExecuteDataTable(@"select functioncode as 功能编码,functionname 功能名称  from yx_functionName where orgid=3 and                                                                                                                                                                            functiongroup=1001", CommandType.Text);
                this.dataGridViewEx3.DataSource = cb;
            }
            catch (Exception err)
            {
                MessageBox.Show("操作失败！" + err.ToString());

            }
        }

        private void kryptonColorButton23_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable cb = SqlHelperERP.ExecuteDataTable(@"select functioncode as 功能编码,functionname 功能名称  from yx_functionName where orgid=2 and                                                                                                                                                                   functiongroup=1001", CommandType.Text);
                this.dataGridViewEx2.DataSource = cb;
            }
            catch (Exception err)
            {
                MessageBox.Show("操作失败！" + err.ToString());

            }
        }

        private void kryptonColorButton3_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable cb = SqlHelperERP.ExecuteDataTable(@"select functioncode as 功能编码,functionname 功能名称  from yx_functionName where orgid=2 and                                                                                                                                                                   functiongroup=1002", CommandType.Text);
                this.dataGridViewEx2.DataSource = cb;
            }
            catch (Exception err)
            {
                MessageBox.Show("操作失败！" + err.ToString());

            }
        }

        private void dataGridViewEx3_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string exePath = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx3.Rows[e.RowIndex].Cells[1].Value);
            try
            {
                if (exePath == null)
                    return;



                if (exePath == "肉制品—导入外购入库")
                {               

                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frm_rzp_icstock_wg")
                        {
                            f.Activate();
                            return;
                        }
                    }

                    frm_rzp_icstock_wg frm_rzp_icstock_wg = new frm_rzp_icstock_wg();
                    frm_rzp_icstock_wg.Show();              

                }           

         
            }
            catch (Exception err)
            {
                MessageBox.Show("操作失败！" + err.ToString());

            }
        }

        private void dataGridViewEx2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string exePath = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx2.Rows[e.RowIndex].Cells[1].Value);
            try
            {
                if (exePath == null)
                    return;



                if (exePath == "食品帐套—导入销售出库")
                {

                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frm_sp_in_icstock_xs")
                        {
                            f.Activate();
                            return;
                        }
                    }

                    frm_sp_in_icstock_xs frm_sp_in_icstock_xs = new frm_sp_in_icstock_xs();
                    frm_sp_in_icstock_xs.Show();

                }


                else if (exePath == "肉业食品经营表")
                {

                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmRSjy")
                        {
                            f.Activate();
                            return;
                        }
                    }

                    frmRSjy frmRSjy = new frmRSjy();
                    frmRSjy.Show();
                }
                else if (exePath == "肉业食品经营表New")
                {

                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmNewRSjy")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    frmNewRSjy frmNewRSjy = new frmNewRSjy();
                    frmNewRSjy.Show();
                }

                else if (exePath == "食品应收帐款表")
                {

                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmSPyszk")
                        {
                            f.Activate();
                            return;
                        }
                    }

                    frmSPyszk frmSPyszk = new frmSPyszk();
                    frmSPyszk.Show();


                }
                else if (exePath == "食品直营店（旧）")
                {

                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmSpZyd")
                        {
                            f.Activate();
                            return;
                        }
                    }

                    frmSpZyd frmSpZyd = new frmSpZyd();

                    frmSpZyd.Show();


                }
                else if (exePath == "食品直营店报表(新）")
                {
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "frmSpZydNew")
                        {
                            f.Activate();
                            return;
                        }
                    }
                    frmSpZydNew frmSpZydnew = new frmSpZydNew();

                    frmSpZydnew.Show();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("操作失败！" + err.ToString());

            }
        }

        private void kryptonColorButton26_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable cb = SqlHelperERP.ExecuteDataTable(@"select functioncode as 功能编码,functionname 功能名称  from yx_functionName where orgid=5 and                                                                                                                                                                   functiongroup=1002", CommandType.Text);
                this.dataGridViewEx5.DataSource = cb;
            }
            catch (Exception err)
            {
                MessageBox.Show("操作失败！" + err.ToString());

            }
        }

        private void kryptonColorButton15_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable cb = SqlHelperERP.ExecuteDataTable(@"select functioncode as 功能编码,functionname 功能名称  from yx_functionName where orgid=5 and                                                                                                                                                                   functiongroup=1003", CommandType.Text);
                this.dataGridViewEx5.DataSource = cb;
            }
            catch (Exception err)
            {
                MessageBox.Show("操作失败！" + err.ToString());

            }
        }

        private void kryptonColorButton1_Click_1(object sender, EventArgs e)
        {
            string f = @"frmXSBase";
            execFunction(f);

        }
    }
}
