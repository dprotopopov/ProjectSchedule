using System;
using System.Linq;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Updating;
using DevExpress.Persistent.BaseImpl;
using DevExpress.ExpressApp.Security;
//using DevExpress.ExpressApp.Reports;
//using DevExpress.ExpressApp.PivotChart;
//using DevExpress.ExpressApp.Security.Strategy;
using ProjectSchedule.Module.BusinessObjects;

namespace ProjectSchedule.Module.DatabaseUpdate
{
    // Allows you to handle a database update when the application version changes (http://documentation.devexpress.com/#Xaf/clsDevExpressExpressAppUpdatingModuleUpdatertopic help article for more details).
    public class Updater : ModuleUpdater
    {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion) :
            base(objectSpace, currentDBVersion)
        {
        }
        // Override to specify the database update code which should be performed after the database schema is updated (http://documentation.devexpress.com/#Xaf/DevExpressExpressAppUpdatingModuleUpdater_UpdateDatabaseAfterUpdateSchematopic).
        public override void UpdateDatabaseAfterUpdateSchema()
        {
            base.UpdateDatabaseAfterUpdateSchema();
            //string name = "MyName";
            //DomainObject1 theObject = ObjectSpace.FindObject<DomainObject1>(CriteriaOperator.Parse("Name=?", name));
            //if(theObject == null) {
            //    theObject = ObjectSpace.CreateObject<DomainObject1>();
            //    theObject.Name = name;
            //}

            foreach (string name in new string[] { "Owner", "Writer", "Reader" })
            {
                ProjectRole theObject = ObjectSpace.FindObject<ProjectRole>(CriteriaOperator.Parse("Name=?", name));
                if (theObject == null)
                {
                    theObject = ObjectSpace.CreateObject<ProjectRole>();
                    theObject.Name = name;
                }
            }
            foreach (string name in new string[] { "Time", "Money" })
            {
                ProjectResource theObject = ObjectSpace.FindObject<ProjectResource>(CriteriaOperator.Parse("Name=?", name));
                if (theObject == null)
                {
                    theObject = ObjectSpace.CreateObject<ProjectResource>();
                    theObject.Name = name;
                }
            }

            {
                string subject = "Install & setup application";
                ProjectTask theTask = ObjectSpace.FindObject<ProjectTask>(CriteriaOperator.Parse("Subject=?", subject));
                if (theTask == null)
                {
                    theTask = ObjectSpace.CreateObject<ProjectTask>();
                    theTask.Subject = subject;
                    theTask.StartDate = System.DateTime.Now;
                    theTask.DueDate = System.DateTime.Now;

                    ProjectTask theSubTask = ObjectSpace.CreateObject<ProjectTask>();
                    theSubTask.Subject = "Verify application roles & permissions";
                    theSubTask.StartDate = System.DateTime.Now;
                    theSubTask.DueDate = System.DateTime.Now;
                    theSubTask.ParentTasks.Add(theTask);
                    theTask.SubTasks.Add(theSubTask);

                    BudgetAccount theBudget = ObjectSpace.CreateObject<BudgetAccount>();
                    theBudget.Subject = "Initial application configuration";
                    theBudget.StartDate = System.DateTime.Now;
                    theBudget.DueDate = System.DateTime.Now;
                    theBudget.ProjectTask = theTask;
                    theBudget.ProjectResource = ObjectSpace.FindObject<ProjectResource>(CriteriaOperator.Parse("Name=?", "Time"));
                    theBudget.AmountPlanned = 2.0m;
                    theBudget.AmountSpent = 0.0m;
                    theTask.BudgetAccounts.Add(theBudget);
                }
            }
        }

        // Override to perform the required changes with the database structure before the database schema is updated (http://documentation.devexpress.com/#Xaf/DevExpressExpressAppUpdatingModuleUpdater_UpdateDatabaseBeforeUpdateSchematopic).
        public override void UpdateDatabaseBeforeUpdateSchema()
        {
            base.UpdateDatabaseBeforeUpdateSchema();
            //if(CurrentDBVersion < new Version("1.1.0.0") && CurrentDBVersion > new Version("0.0.0.0")) {
            //    RenameColumn("DomainObject1Table", "OldColumnName", "NewColumnName");
            //}
        }
    }
}
