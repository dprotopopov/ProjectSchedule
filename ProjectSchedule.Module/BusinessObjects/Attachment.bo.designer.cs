//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
namespace ProjectSchedule.Module.BusinessObjects
{
  [DefaultClassOptions]
  [DevExpress.Persistent.Base.ImageNameAttribute("BO_FileAttachment")]
  public partial class Attachment : FileAttachmentBase
  {
    private ProjectSchedule.Module.BusinessObjects.Company _company;
    private ProjectSchedule.Module.BusinessObjects.ProjectTask _projectTask;
    private ProjectSchedule.Module.BusinessObjects.Comment _comment;
    private ProjectSchedule.Module.BusinessObjects.ProjectEvent _projectEvent;
    public Attachment(DevExpress.Xpo.Session session)
      : base(session)
    {
    }
    [DevExpress.Xpo.AssociationAttribute("Attachments-ProjectEvent")]
    public ProjectSchedule.Module.BusinessObjects.ProjectEvent ProjectEvent
    {
      get
      {
        return _projectEvent;
      }
      set
      {
        SetPropertyValue("ProjectEvent", ref _projectEvent, value);
      }
    }
    [DevExpress.Xpo.AssociationAttribute("Attachments-Comment")]
    public ProjectSchedule.Module.BusinessObjects.Comment Comment
    {
      get
      {
        return _comment;
      }
      set
      {
        SetPropertyValue("Comment", ref _comment, value);
      }
    }
    [DevExpress.Xpo.AssociationAttribute("Attachments-ProjectTask")]
    public ProjectSchedule.Module.BusinessObjects.ProjectTask ProjectTask
    {
      get
      {
        return _projectTask;
      }
      set
      {
        SetPropertyValue("ProjectTask", ref _projectTask, value);
      }
    }
    [DevExpress.Xpo.AssociationAttribute("Attachments-Company")]
    public ProjectSchedule.Module.BusinessObjects.Company Company
    {
      get
      {
        return _company;
      }
      set
      {
        SetPropertyValue("Company", ref _company, value);
      }
    }
  }
}
