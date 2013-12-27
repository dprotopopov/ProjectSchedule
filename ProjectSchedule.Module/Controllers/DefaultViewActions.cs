using System;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.BaseImpl;
using ProjectSchedule.Module.BusinessObjects;

namespace ProjectSchedule.Module.Controllers
{
    // For more information on Controllers and their life cycle, check out the http://documentation.devexpress.com/#Xaf/CustomDocument2621 and http://documentation.devexpress.com/#Xaf/CustomDocument3118 help articles.
    public partial class DefaultViewActions : ViewController
    {
        // Use this to do something when a Controller is instantiated (do not execute heavy operations here!).
        public DefaultViewActions()
        {
            InitializeComponent();
            RegisterActions(components);
            // For instance, you can specify activation conditions of a Controller or create its Actions (http://documentation.devexpress.com/#Xaf/CustomDocument2622).
            //TargetObjectType = typeof(DomainObject1);
            //TargetViewType = ViewType.DetailView;
            //TargetViewId = "DomainObject1_DetailView";
            //TargetViewNesting = Nesting.Root;
            //SimpleAction myAction = new SimpleAction(this, "MyActionId", DevExpress.Persistent.Base.PredefinedCategory.RecordEdit);
        }
        // Override to do something before Controllers are activated within the current Frame (their View property is not yet assigned).
        protected override void OnFrameAssigned()
        {
            base.OnFrameAssigned();
            //For instance, you can access another Controller via the Frame.GetController<AnotherControllerType>() method to customize it or subscribe to its events.
        }
        // Override to do something when a Controller is activated and its View is assigned.
        protected override void OnActivated()
        {
            base.OnActivated();
            //For instance, you can customize the current View and its editors (http://documentation.devexpress.com/#Xaf/CustomDocument2729) or manage the Controller's Actions visibility and availability (http://documentation.devexpress.com/#Xaf/CustomDocument2728).
        }
        // Override to access the controls of a View for which the current Controller is intended.
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // For instance, refer to the http://documentation.devexpress.com/Xaf/CustomDocument3165.aspx help article to see how to access grid control properties.
        }
        // Override to do something when a Controller is deactivated.
        protected override void OnDeactivated()
        {
            // For instance, you can unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }

        private void postponeAction_Execute(object sender, ParametrizedActionExecuteEventArgs e)
        {
            Task theTask = (Task)e.CurrentObject;
            int? paramValue = e.ParameterCurrentValue as int?;
            theTask.DueDate = theTask.DueDate + TimeSpan.FromDays((double)paramValue);
        }

        private void commentAction_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            ProjectTask theTask = (ProjectTask)View.CurrentObject;
            Comment theComment = ObjectSpace.CreateObject<Comment>();
            theComment.DateTime = System.DateTime.Now;
            theComment.ProjectTasks.Add(theTask);
            theComment.Text = theTask.Comment;
            foreach (Attachment file in theTask.Files)
            {
                file.Comment = theComment;
                theComment.Attachments.Add(file);
            }
            theTask.Comments.Add(theComment);
            theTask.Comment = "";
            theTask.Files.Clear();
            View.Refresh();
        }
    }
}
