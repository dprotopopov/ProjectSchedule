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
  public partial class BudgetPlanningAndUsage : ProjectSchedule.Module.BusinessObjects.Comment
  {
    private ProjectSchedule.Module.BusinessObjects.BudgetAccount _budgetAccount;
    private System.Decimal _amountSpent;
    private System.Decimal _amountPlanned;
    public BudgetPlanningAndUsage(DevExpress.Xpo.Session session)
      : base(session)
    {
    }
    public System.Decimal AmountPlanned
    {
      get
      {
        return _amountPlanned;
      }
      set
      {
        SetPropertyValue("AmountPlanned", ref _amountPlanned, value);
      }
    }
    public System.Decimal AmountSpent
    {
      get
      {
        return _amountSpent;
      }
      set
      {
        SetPropertyValue("AmountSpent", ref _amountSpent, value);
      }
    }
    [DevExpress.Xpo.AssociationAttribute("BudgetPlanningAndUsages-BudgetAccount")]
    public ProjectSchedule.Module.BusinessObjects.BudgetAccount BudgetAccount
    {
      get
      {
        return _budgetAccount;
      }
      set
      {
        SetPropertyValue("BudgetAccount", ref _budgetAccount, value);
      }
    }
  }
}
