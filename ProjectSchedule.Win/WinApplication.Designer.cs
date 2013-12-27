namespace ProjectSchedule.Win
{
    partial class ProjectScheduleWindowsFormsApplication
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.module1 = new DevExpress.ExpressApp.SystemModule.SystemModule();
            this.module2 = new DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.schedulerWindowsFormsModule1 = new DevExpress.ExpressApp.Scheduler.Win.SchedulerWindowsFormsModule();
            this.schedulerModuleBase1 = new DevExpress.ExpressApp.Scheduler.SchedulerModuleBase();
            this.fileAttachmentsWindowsFormsModule1 = new DevExpress.ExpressApp.FileAttachments.Win.FileAttachmentsWindowsFormsModule();
            this.securityStrategyComplex1 = new DevExpress.ExpressApp.Security.SecurityStrategyComplex();
            this.authenticationActiveDirectory1 = new DevExpress.ExpressApp.Security.AuthenticationActiveDirectory();
            this.securityModule1 = new DevExpress.ExpressApp.Security.SecurityModule();
            this.cloneObjectModule1 = new DevExpress.ExpressApp.CloneObject.CloneObjectModule();
            this.module3 = new ProjectSchedule.Module.ProjectScheduleModule();
            this.module4 = new ProjectSchedule.Module.Win.ProjectScheduleWindowsFormsModule();
            this.reportsWindowsFormsModule1 = new DevExpress.ExpressApp.Reports.Win.ReportsWindowsFormsModule();
            this.reportsModule1 = new DevExpress.ExpressApp.Reports.ReportsModule();
            this.viewVariantsModule1 = new DevExpress.ExpressApp.ViewVariantsModule.ViewVariantsModule();
            this.htmlPropertyEditorWindowsFormsModule1 = new DevExpress.ExpressApp.HtmlPropertyEditor.Win.HtmlPropertyEditorWindowsFormsModule();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Integrated Security=SSPI;Pooling=false;Data Source=.\\SQLEXPRESS;Initial Catalog=P" +
    "rojectSchedule";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // securityStrategyComplex1
            // 
            this.securityStrategyComplex1.Authentication = this.authenticationActiveDirectory1;
            this.securityStrategyComplex1.RoleType = typeof(DevExpress.ExpressApp.Security.Strategy.SecuritySystemRole);
            this.securityStrategyComplex1.UserType = typeof(DevExpress.ExpressApp.Security.Strategy.SecuritySystemUser);
            // 
            // authenticationActiveDirectory1
            // 
            this.authenticationActiveDirectory1.CreateUserAutomatically = true;
            this.authenticationActiveDirectory1.LogonParametersType = null;
            // 
            // reportsModule1
            // 
            this.reportsModule1.EnableInplaceReports = true;
            this.reportsModule1.ReportDataType = typeof(DevExpress.Persistent.BaseImpl.ReportData);
            // 
            // viewVariantsModule1
            // 
            this.viewVariantsModule1.GenerateVariantsNode = true;
            this.viewVariantsModule1.ShowAdditionalNavigation = false;
            // 
            // ProjectScheduleWindowsFormsApplication
            // 
            this.ApplicationName = "ProjectSchedule";
            this.Connection = this.sqlConnection1;
            this.Modules.Add(this.module1);
            this.Modules.Add(this.module2);
            this.Modules.Add(this.viewVariantsModule1);
            this.Modules.Add(this.module3);
            this.Modules.Add(this.htmlPropertyEditorWindowsFormsModule1);
            this.Modules.Add(this.fileAttachmentsWindowsFormsModule1);
            this.Modules.Add(this.module4);
            this.Modules.Add(this.schedulerModuleBase1);
            this.Modules.Add(this.schedulerWindowsFormsModule1);
            this.Modules.Add(this.securityModule1);
            this.Modules.Add(this.cloneObjectModule1);
            this.Modules.Add(this.reportsModule1);
            this.Modules.Add(this.reportsWindowsFormsModule1);
            this.Security = this.securityStrategyComplex1;
            this.DatabaseVersionMismatch += new System.EventHandler<DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs>(this.ProjectScheduleWindowsFormsApplication_DatabaseVersionMismatch);
            this.CustomizeLanguagesList += new System.EventHandler<DevExpress.ExpressApp.CustomizeLanguagesListEventArgs>(this.ProjectScheduleWindowsFormsApplication_CustomizeLanguagesList);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.ExpressApp.SystemModule.SystemModule module1;
        private DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule module2;
        private ProjectSchedule.Module.ProjectScheduleModule module3;
        private ProjectSchedule.Module.Win.ProjectScheduleWindowsFormsModule module4;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private DevExpress.ExpressApp.Scheduler.Win.SchedulerWindowsFormsModule schedulerWindowsFormsModule1;
        private DevExpress.ExpressApp.Scheduler.SchedulerModuleBase schedulerModuleBase1;
        private DevExpress.ExpressApp.FileAttachments.Win.FileAttachmentsWindowsFormsModule fileAttachmentsWindowsFormsModule1;
        private DevExpress.ExpressApp.Security.SecurityStrategyComplex securityStrategyComplex1;
        private DevExpress.ExpressApp.Security.SecurityModule securityModule1;
        private DevExpress.ExpressApp.CloneObject.CloneObjectModule cloneObjectModule1;
        private DevExpress.ExpressApp.Security.AuthenticationActiveDirectory authenticationActiveDirectory1;
        private DevExpress.ExpressApp.Reports.Win.ReportsWindowsFormsModule reportsWindowsFormsModule1;
        private DevExpress.ExpressApp.Reports.ReportsModule reportsModule1;
        private DevExpress.ExpressApp.ViewVariantsModule.ViewVariantsModule viewVariantsModule1;
        private DevExpress.ExpressApp.HtmlPropertyEditor.Win.HtmlPropertyEditorWindowsFormsModule htmlPropertyEditorWindowsFormsModule1;
    }
}
