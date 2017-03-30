﻿namespace Consolidate.Excel2010
{
    partial class Ribbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.btnLoadSheet = this.Factory.CreateRibbonButton();
            this.btnStartConsolidate = this.Factory.CreateRibbonButton();
            this.ddlOriginalSheet = this.Factory.CreateRibbonDropDown();
            this.ddlRefSheet = this.Factory.CreateRibbonDropDown();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "Consolidate";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.btnLoadSheet);
            this.group1.Items.Add(this.ddlOriginalSheet);
            this.group1.Items.Add(this.ddlRefSheet);
            this.group1.Items.Add(this.btnStartConsolidate);
            this.group1.Label = "Consolidate";
            this.group1.Name = "group1";
            // 
            // btnLoadSheet
            // 
            this.btnLoadSheet.Label = "加载Sheet";
            this.btnLoadSheet.Name = "btnLoadSheet";
            this.btnLoadSheet.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnLoadSheet_Click);
            // 
            // btnStartConsolidate
            // 
            this.btnStartConsolidate.Label = "开始匹配";
            this.btnStartConsolidate.Name = "btnStartConsolidate";
            this.btnStartConsolidate.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnStartConsolidate_Click);
            // 
            // ddlOriginalSheet
            // 
            this.ddlOriginalSheet.Label = "原数据";
            this.ddlOriginalSheet.Name = "ddlOriginalSheet";
            // 
            // ddlRefSheet
            // 
            this.ddlRefSheet.Label = "引用数据";
            this.ddlRefSheet.Name = "ddlRefSheet";
            // 
            // Ribbon
            // 
            this.Name = "Ribbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnLoadSheet;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown ddlOriginalSheet;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown ddlRefSheet;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnStartConsolidate;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon Ribbon
        {
            get { return this.GetRibbon<Ribbon>(); }
        }
    }
}
