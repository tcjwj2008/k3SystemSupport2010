﻿namespace YXK3FZ.RP.from
{
    partial class frmDzpYsmx_test
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFcurnumber = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.首页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上一页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下一页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.尾页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFcurnumber);
            this.groupBox1.Controls.Add(this.txtMonth);
            this.groupBox1.Controls.Add(this.txtYear);
            this.groupBox1.Controls.Add(this.btnSelect);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 48);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtFcurnumber
            // 
            this.txtFcurnumber.Location = new System.Drawing.Point(265, 19);
            this.txtFcurnumber.Name = "txtFcurnumber";
            this.txtFcurnumber.Size = new System.Drawing.Size(95, 21);
            this.txtFcurnumber.TabIndex = 6;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(149, 19);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(51, 21);
            this.txtMonth.TabIndex = 5;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(54, 19);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(51, 21);
            this.txtYear.TabIndex = 4;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(387, 15);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 27);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Tag = "查询";
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "客户代码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "期间：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "年份：";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 73);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(872, 358);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.crystalReportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(864, 332);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "明细";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.DisplayGroupTree = false;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(3, 3);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.SelectionFormula = "";
            this.crystalReportViewer1.Size = new System.Drawing.Size(858, 326);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ViewTimeSelectionFormula = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.crystalReportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(864, 332);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "对账单";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = -1;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.DisplayGroupTree = false;
            this.crystalReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer2.Location = new System.Drawing.Point(3, 3);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.SelectionFormula = "";
            this.crystalReportViewer2.Size = new System.Drawing.Size(858, 326);
            this.crystalReportViewer2.TabIndex = 0;
            this.crystalReportViewer2.ViewTimeSelectionFormula = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.首页ToolStripMenuItem,
            this.上一页ToolStripMenuItem,
            this.下一页ToolStripMenuItem,
            this.尾页ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(872, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 首页ToolStripMenuItem
            // 
            this.首页ToolStripMenuItem.Name = "首页ToolStripMenuItem";
            this.首页ToolStripMenuItem.Size = new System.Drawing.Size(48, 21);
            this.首页ToolStripMenuItem.Text = " 首页";
            this.首页ToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 上一页ToolStripMenuItem
            // 
            this.上一页ToolStripMenuItem.Name = "上一页ToolStripMenuItem";
            this.上一页ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.上一页ToolStripMenuItem.Text = "上一页";
            this.上一页ToolStripMenuItem.Click += new System.EventHandler(this.上一页ToolStripMenuItem_Click);
            // 
            // 下一页ToolStripMenuItem
            // 
            this.下一页ToolStripMenuItem.Name = "下一页ToolStripMenuItem";
            this.下一页ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.下一页ToolStripMenuItem.Text = "下一页";
            this.下一页ToolStripMenuItem.Click += new System.EventHandler(this.下一页ToolStripMenuItem_Click);
            // 
            // 尾页ToolStripMenuItem
            // 
            this.尾页ToolStripMenuItem.Name = "尾页ToolStripMenuItem";
            this.尾页ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.尾页ToolStripMenuItem.Text = "尾页";
            this.尾页ToolStripMenuItem.Click += new System.EventHandler(this.尾页ToolStripMenuItem_Click);
            // 
            // frmDzpYsmx_test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 431);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDzpYsmx_test";
            this.Text = "frmDzpYsmx_test";
            this.Load += new System.EventHandler(this.frmDzpYsmx_test_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtFcurnumber;
        public System.Windows.Forms.TextBox txtMonth;
        public System.Windows.Forms.TextBox txtYear;
        public System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.TabPage tabPage2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 首页ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上一页ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下一页ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 尾页ToolStripMenuItem;
    }
}