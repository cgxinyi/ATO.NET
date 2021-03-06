//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ATO.net.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Payslip
    {
        public Payslip() {}

        public Payslip( String fromD,
                    String toD,
                    Double income,
                    Double net,
                    Double superA,
                    Double gross)
    {
        fromDate = fromD;
    	toDate = toD;
    	incomeTax = income;
    	netIncome = net;
    	superAmount = superA;
    	grossIncome = gross;
    }

    public int payslipId { get; set; }
        public String fromDate { get; set; }
        public String toDate { get; set; }
        public Double incomeTax;
        public Double netIncome;
        public Double superAmount;
        public Double grossIncome;
        public int Employee_employeeId { get; set; }
    
        public virtual Employee Employee { get; set; }

        public Double GetGrossIncome()
        {
            return grossIncome;
        }

        public Double GetIncomeTax()
        {
            return incomeTax;
        }
        public Double GetNetIncome()
        {
            return netIncome;
        }
        public Double GetSuperAmount()
        {
            return superAmount;
        }
        public void SetGrossIncome(Double annualSalary)
        {
            grossIncome = annualSalary/12;

        }

        public void SetIncomeTax(Double incomeT)
        {

            incomeTax = incomeT;

        }

        public void SetNetIncome(Double grossIncome, Double incomeTax)
        {
            netIncome = grossIncome-incomeTax;

        }

        public void SetSuperAmount(Double superRate, Double grossIncome)
        {
            superRate = superRate/100;
            superAmount = superRate*grossIncome;
        }
    }
}
