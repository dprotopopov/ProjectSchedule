using System;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.Xpo;
using DevExpress.ExpressApp.Web;
using System.Collections.Generic;
//using DevExpress.ExpressApp.Security;

namespace ProjectSchedule.Web
{
    // You can override various virtual methods and handle corresponding events to manage various aspects of your XAF application UI and behavior.
    public partial class ProjectScheduleAspNetApplication : WebApplication
    { // http://documentation.devexpress.com/#Xaf/DevExpressExpressAppWebWebApplicationMembersTopicAll
        private DevExpress.ExpressApp.SystemModule.SystemModule module1;
        private DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule module2;
        private ProjectSchedule.Module.ProjectScheduleModule module3;
        private ProjectSchedule.Module.Web.ProjectScheduleAspNetModule module4;
        private DevExpress.ExpressApp.FileAttachments.Web.FileAttachmentsAspNetModule fileAttachmentsAspNetModule1;
        private DevExpress.ExpressApp.Scheduler.Web.SchedulerAspNetModule schedulerAspNetModule1;
        private DevExpress.ExpressApp.Scheduler.SchedulerModuleBase schedulerModuleBase1;
        private DevExpress.ExpressApp.Reports.Web.ReportsAspNetModule reportsAspNetModule1;
        private DevExpress.ExpressApp.Reports.ReportsModule reportsModule1;
        private DevExpress.ExpressApp.ViewVariantsModule.ViewVariantsModule viewVariantsModule1;
        private DevExpress.ExpressApp.Security.SecurityStrategyComplex securityStrategyComplex1;
        private DevExpress.ExpressApp.Security.AuthenticationActiveDirectory authenticationActiveDirectory1;
        private DevExpress.ExpressApp.Security.SecurityModule securityModule1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;

        public ProjectScheduleAspNetApplication()
        {
            InitializeComponent();
        }

        // Override to execute custom code after a logon has been performed, the SecuritySystem object is initialized, logon parameters have been saved and user model differences are loaded.
        protected override void OnLoggedOn(LogonEventArgs args)
        { // http://documentation.devexpress.com/#Xaf/DevExpressExpressAppXafApplication_LoggedOntopic
            base.OnLoggedOn(args);
        }

        // Override to execute custom code after a user has logged off.
        protected override void OnLoggedOff()
        { // http://documentation.devexpress.com/#Xaf/DevExpressExpressAppXafApplication_LoggedOfftopic
            base.OnLoggedOff();
        }

        protected override void CreateDefaultObjectSpaceProvider(CreateCustomObjectSpaceProviderEventArgs args)
        {
            args.ObjectSpaceProvider = new XPObjectSpaceProviderThreadSafe(args.ConnectionString, args.Connection);
        }

        private void ProjectScheduleAspNetApplication_DatabaseVersionMismatch(object sender, DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs e)
        {
#if EASYTEST
			e.Updater.Update();
			e.Handled = true;
#else
            if (System.Diagnostics.Debugger.IsAttached)
            {
                e.Updater.Update();
                e.Handled = true;
            }
            else
            {
                string message = "The application cannot connect to the specified database, because the latter doesn't exist or its version is older than that of the application.\r\n" +
                    "This error occurred  because the automatic database update was disabled when the application was started without debugging.\r\n" +
                    "To avoid this error, you should either start the application under Visual Studio in debug mode, or modify the " +
                    "source code of the 'DatabaseVersionMismatch' event handler to enable automatic database update, " +
                    "or manually create a database using the 'DBUpdater' tool.\r\n" +
                    "Anyway, refer to the following help topics for more detailed information:\r\n" +
                    "'Update Application and Database Versions' at http://www.devexpress.com/Help/?document=ExpressApp/CustomDocument2795.htm\r\n" +
                    "'Database Security References' at http://www.devexpress.com/Help/?document=ExpressApp/CustomDocument3237.htm\r\n" +
                    "If this doesn't help, please contact our Support Team at http://www.devexpress.com/Support/Center/";

                if (e.CompatibilityError != null && e.CompatibilityError.Exception != null)
                {
                    message += "\r\n\r\nInner exception: " + e.CompatibilityError.Exception.Message;
                }
                throw new InvalidOperationException(message);
            }
#endif
        }

        private void InitializeComponent()
        {
            this.module1 = new DevExpress.ExpressApp.SystemModule.SystemModule();
            this.module2 = new DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule();
            this.module3 = new ProjectSchedule.Module.ProjectScheduleModule();
            this.module4 = new ProjectSchedule.Module.Web.ProjectScheduleAspNetModule();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.fileAttachmentsAspNetModule1 = new DevExpress.ExpressApp.FileAttachments.Web.FileAttachmentsAspNetModule();
            this.schedulerAspNetModule1 = new DevExpress.ExpressApp.Scheduler.Web.SchedulerAspNetModule();
            this.schedulerModuleBase1 = new DevExpress.ExpressApp.Scheduler.SchedulerModuleBase();
            this.reportsAspNetModule1 = new DevExpress.ExpressApp.Reports.Web.ReportsAspNetModule();
            this.reportsModule1 = new DevExpress.ExpressApp.Reports.ReportsModule();
            this.viewVariantsModule1 = new DevExpress.ExpressApp.ViewVariantsModule.ViewVariantsModule();
            this.securityStrategyComplex1 = new DevExpress.ExpressApp.Security.SecurityStrategyComplex();
            this.authenticationActiveDirectory1 = new DevExpress.ExpressApp.Security.AuthenticationActiveDirectory();
            this.securityModule1 = new DevExpress.ExpressApp.Security.SecurityModule();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Integrated Security=SSPI;Pooling=false;Data Source=.\\SQLEXPRESS;Initial Catalog=P" +
    "rojectSchedule";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
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
            // ProjectScheduleAspNetApplication
            // 
            this.ApplicationName = "ProjectSchedule";
            this.Connection = this.sqlConnection1;
            this.Modules.Add(this.module1);
            this.Modules.Add(this.module2);
            this.Modules.Add(this.viewVariantsModule1);
            this.Modules.Add(this.module3);
            this.Modules.Add(this.module4);
            this.Modules.Add(this.fileAttachmentsAspNetModule1);
            this.Modules.Add(this.schedulerModuleBase1);
            this.Modules.Add(this.schedulerAspNetModule1);
            this.Modules.Add(this.reportsModule1);
            this.Modules.Add(this.reportsAspNetModule1);
            this.Modules.Add(this.securityModule1);
            this.Security = this.securityStrategyComplex1;
            this.DatabaseVersionMismatch += new System.EventHandler<DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs>(this.ProjectScheduleAspNetApplication_DatabaseVersionMismatch);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
    }
}
