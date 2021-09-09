using ATO.net.Models;
using ATO.net.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Web;

namespace ATO.net.Repository
{
    public class EmployeeRepository : EmployeeRepositoryInterface
    {
		private List<Employee> empDatabase = new List<Employee>();
		public List<Employee> InsertEmployee(List<Employee> employee)
		{
			EmployeeService employeeService = new EmployeeService();
			
			DateTime currentdate = DateTime.Now;
			for (int i = 0; i < employee.Count; i++)
			{
				Payslip payslip = new Payslip();
				payslip.SetGrossIncome(employee[i].annualSalary);
				payslip.SetSuperAmount(employee[i].superRate, payslip.GetGrossIncome());
				Double incomeTax = employeeService.CalculateIncomeTax(payslip.GetGrossIncome());
				payslip.SetIncomeTax(incomeTax);
				payslip.SetNetIncome(payslip.GetGrossIncome(), payslip.GetIncomeTax());
				String currentMonth = currentdate.ToString("MMM", new CultureInfo("en-US"));
				int lastDay = DateTime.DaysInMonth(currentdate.Year, currentdate.Month);
				String lastD = lastDay.ToString();
				String fromDate = "01 " + currentMonth;
				String toDate = lastD + " " + currentMonth;
				payslip = new Payslip(fromDate, toDate, payslip.GetIncomeTax(), payslip.GetNetIncome(), payslip.GetSuperAmount(), payslip.GetGrossIncome());
				empDatabase.Add(new Employee(employee[i].firstName, employee[i].lastName, employee[i].annualSalary, employee[i].superRate, employee[i].paymentMonth,payslip));
				
			}

			return empDatabase;
		}

	}


}