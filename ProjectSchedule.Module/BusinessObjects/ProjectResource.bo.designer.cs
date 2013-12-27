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
  [DevExpress.Persistent.Base.ImageNameAttribute("BO_Opportunity")]
  [DevExpress.ExpressApp.DC.XafDefaultPropertyAttribute("Name")]
  public partial class ProjectResource : DevExpress.Persistent.BaseImpl.BaseObject
  {
    private System.String _name;
    private System.Drawing.Image _icon;
    private System.String _unit;
    public ProjectResource(DevExpress.Xpo.Session session)
      : base(session)
    {
    }
    public System.String Name
    {
      get
      {
        return _name;
      }
      set
      {
        SetPropertyValue("Name", ref _name, value);
      }
    }
    public System.String Unit
    {
      get
      {
        return _unit;
      }
      set
      {
        SetPropertyValue("Unit", ref _unit, value);
      }
    }
    [DevExpress.Xpo.ValueConverterAttribute(typeof(DevExpress.Xpo.Metadata.ImageValueConverter))]
    public System.Drawing.Image Icon
    {
      get
      {
        return _icon;
      }
      set
      {
        SetPropertyValue("Icon", ref _icon, value);
      }
    }
    [DevExpress.Xpo.AssociationAttribute("BudgetAccounts-ProjectResource")]
    public XPCollection<ProjectSchedule.Module.BusinessObjects.BudgetAccount> BudgetAccounts
    {
      get
      {
        return GetCollection<ProjectSchedule.Module.BusinessObjects.BudgetAccount>("BudgetAccounts");
      }
    }
  }
}