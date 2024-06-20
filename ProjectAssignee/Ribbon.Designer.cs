namespace ProjectAssignee
{
    partial class Ribbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CustomTab = this.Factory.CreateRibbonTab();
            this.CustomGroup = this.Factory.CreateRibbonGroup();
            this.SetResourceName = this.Factory.CreateRibbonButton();
            this.CustomTab.SuspendLayout();
            this.CustomGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomTab
            // 
            this.CustomTab.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.CustomTab.Groups.Add(this.CustomGroup);
            this.CustomTab.Label = "CustomTab";
            this.CustomTab.Name = "CustomTab";
            // 
            // CustomGroup
            // 
            this.CustomGroup.Items.Add(this.SetResourceName);
            this.CustomGroup.Label = "CustomGroup";
            this.CustomGroup.Name = "CustomGroup";
            // 
            // SetResourceName
            // 
            this.SetResourceName.Label = "Set resource name";
            this.SetResourceName.Name = "SetResourceName";
            this.SetResourceName.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonAssign_Click);
            // 
            // Ribbon
            // 
            this.Name = "Ribbon";
            this.RibbonType = "Microsoft.Project.Project";
            this.Tabs.Add(this.CustomTab);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon_Load);
            this.CustomTab.ResumeLayout(false);
            this.CustomTab.PerformLayout();
            this.CustomGroup.ResumeLayout(false);
            this.CustomGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab CustomTab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup CustomGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton SetResourceName;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon Ribbon
        {
            get { return this.GetRibbon<Ribbon>(); }
        }
    }
}
