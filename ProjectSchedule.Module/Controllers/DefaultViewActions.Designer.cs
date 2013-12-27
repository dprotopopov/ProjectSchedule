namespace ProjectSchedule.Module.Controllers
{
    partial class DefaultViewActions
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
            this.components = new System.ComponentModel.Container();
            this.commentAction = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.postponeAction = new DevExpress.ExpressApp.Actions.ParametrizedAction(this.components);
            // 
            // commentAction
            // 
            this.commentAction.Caption = "Comment";
            this.commentAction.Category = "Edit";
            this.commentAction.ConfirmationMessage = null;
            this.commentAction.Id = "Comment";
            this.commentAction.ImageName = "comment";
            this.commentAction.PaintStyle = DevExpress.ExpressApp.Templates.ActionItemPaintStyle.Image;
            this.commentAction.Shortcut = null;
            this.commentAction.Tag = null;
            this.commentAction.TargetObjectsCriteria = null;
            this.commentAction.TargetObjectType = typeof(ProjectSchedule.Module.BusinessObjects.ProjectTask);
            this.commentAction.TargetViewId = "";
            this.commentAction.ToolTip = null;
            this.commentAction.TypeOfView = typeof(DevExpress.ExpressApp.View);
            this.commentAction.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.commentAction_Execute);
            // 
            // postponeAction
            // 
            this.postponeAction.Caption = "Postpone";
            this.postponeAction.Category = "Edit";
            this.postponeAction.ConfirmationMessage = null;
            this.postponeAction.Id = "Postpone";
            this.postponeAction.ImageName = null;
            this.postponeAction.NullValuePrompt = null;
            this.postponeAction.ShortCaption = null;
            this.postponeAction.Shortcut = null;
            this.postponeAction.Tag = null;
            this.postponeAction.TargetObjectsCriteria = null;
            this.postponeAction.TargetObjectType = typeof(ProjectSchedule.Module.BusinessObjects.ProjectTask);
            this.postponeAction.TargetViewId = null;
            this.postponeAction.ToolTip = null;
            this.postponeAction.TypeOfView = typeof(DevExpress.ExpressApp.View);
            this.postponeAction.ValueType = typeof(int);
            this.postponeAction.Execute += new DevExpress.ExpressApp.Actions.ParametrizedActionExecuteEventHandler(this.postponeAction_Execute);
            // 
            // DefaultViewActions
            // 
            this.TypeOfView = typeof(DevExpress.ExpressApp.View);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction commentAction;
        private DevExpress.ExpressApp.Actions.ParametrizedAction postponeAction;
    }
}
