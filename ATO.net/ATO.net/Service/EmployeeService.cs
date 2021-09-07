using ATO.net.Models;
using ATO.net.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Web;

namespace ATO.net.Service
{
	public class EmployeeService
	{
		private List<Taxthreshold> taxthresholds = new List<Taxthreshold>();
		private EmployeeRepository employeeRepository = new EmployeeRepository();
		

		public List<Taxthreshold> LoadTaxthreshold()
        {
			Taxthreshold taxthreshold = new Taxthreshold();
			if (taxthreshold.HasRows() == false)
			{
				Debug.WriteLine("hihi" + taxthreshold.HasRows());
				using (StreamReader r = File.OpenText(@"C:\Users\cheli\Documents\GitHub\ATO.NET\ATO.net\ATO.net\TaxthresholdJson\taxthresholddata.json"))
				{
					string json = r.ReadToEnd();
					List<Taxthreshold> items = JsonConvert.DeserializeObject<List<Taxthreshold>>(json);
					for (int i = 0; i < items.Count; i++)
					{
						taxthresholds.Add(items[i]);
						taxthreshold.InsertToDB(items[i]);
					}
				}
			}
			else 
			{
				taxthresholds = taxthreshold.ReadTaxthresholdList();
			}
		
			return taxthresholds;
        }

		public Double CalculateIncomeTax(Double grossIncome)
		{
			this.LoadTaxthreshold();
			Double incomeTax = 0;
			for (int i = 0; i < taxthresholds.Count; i++)
			{
				int count = 0;
				if (grossIncome-(taxthresholds[i].taxMin) > 0 && count==0)
				{
					incomeTax = taxthresholds[i].taxLump + ((grossIncome - taxthresholds[i].taxMin)*taxthresholds[i].taxCent);
					Debug.WriteLine("fdgsgf"+ taxthresholds[i].taxCent);
					count=1;
				}
			}
			return incomeTax;
		}

		public List<Employee> InsertEmployee(List<Employee> employee)
		{
		
			return employeeRepository.InsertEmployee(employee);
		}

	}

	
}