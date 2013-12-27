using System;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Layout;
using ProjectSchedule.Module.BusinessObjects;
using DevExpress.Web.ASPxEditors;

namespace ProjectSchedule.Module.Web.Controllers
{
    // For more information on Controllers and their life cycle, check out the http://documentation.devexpress.com/#Xaf/CustomDocument2621 and http://documentation.devexpress.com/#Xaf/CustomDocument3118 help articles.
    public partial class ButtonClickHandlingWebController : ViewController
    {
        // Use this to do something when a Controller is instantiated (do not execute heavy operations here!).
        public ButtonClickHandlingWebController()
        {
            InitializeComponent();
            RegisterActions(components);
            // For instance, you can specify activation conditions of a Controller or create its Actions (http://documentation.devexpress.com/#Xaf/CustomDocument2622).
            //TargetObjectType = typeof(DomainObject1);
            //TargetViewType = ViewType.DetailView;
            //TargetViewId = "DomainObject1_DetailView";
            //TargetViewNesting = Nesting.Root;
            //SimpleAction myAction = new SimpleAction(this, "MyActionId", DevExpress.Persistent.Base.PredefinedCategory.RecordEdit);
            TargetObjectType = typeof(ProjectTask);
        }
        // Override to do something before Controllers are activated within the current Frame (their View property is not yet assigned).
        protected override void OnFrameAssigned()
        {
            base.OnFrameAssigned();
            //For instance, you can access another Controller via the Frame.GetController<AnotherControllerType>() method to customize it or subscribe to its events.
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            ControlDetailItem item = null;
            if (View is DevExpress.ExpressApp.DetailView) item = ((DevExpress.ExpressApp.DetailView)View).FindItem("Button") as ControlDetailItem;
            if (View is DevExpress.ExpressApp.ListView) item = ((DevExpress.ExpressApp.ListView)View).FindItem("Button") as ControlDetailItem;
            if (item != null)
            {
                if (item.Control != null)
                {
                    item_ControlCreated(item, EventArgs.Empty);
                }
                item.ControlCreated += item_ControlCreated;
            }
        }
        private void item_ControlCreated(object sender, EventArgs e)
        {
            ASPxButton button = ((ControlDetailItem)sender).Control as ASPxButton;
            if (button == null) return;
            button.ID = "Button";
            button.Text = "Add";
            button.Click += ButtonClickHandlingWebController_Click;
        }
        private void ButtonClickHandlingWebController_Click(object sender, EventArgs e)
        {
            // Perform the required actions here 
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
    }
}
