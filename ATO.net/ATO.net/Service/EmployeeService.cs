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
	public class EmployeeService : EmployeeServiceInterface
	{
		private List<Taxthreshold> taxthresholds = new List<Taxthreshold>();
		private EmployeeRepositoryInterface employeeRepository = new EmployeeRepository();
		private TaxthresholdRepositoryInterface taxthresholdRepository = new TaxthresholdRepository();
		

		public List<Taxthreshold> LoadTaxthreshold()
        {
			Taxthreshold taxthreshold = new Taxthreshold();
			if (taxthresholdRepository.HasRows() == false)
			{
				Debug.WriteLine("hihi" + taxthresholdRepository.HasRows());
				using (StreamReader r = File.OpenText(@"C:\Users\cheli\Documents\GitHub\ATO.NET\ATO.net\ATO.net\TaxthresholdJson\taxthresholddata.json"))
				{
					string json = r.ReadToEnd();
					List<Taxthreshold> items = JsonConvert.DeserializeObject<List<Taxthreshold>>(json);
					for (int i = 0; i < items.Count; i++)
					{
						taxthresholds.Add(items[i]);
						taxthresholdRepository.InsertToDB(items[i]);
					}
				}
			}
			else 
			{
				taxthresholds = taxthresholdRepository.ReadTaxthresholdList();
			}
		
			return taxthresholds;
        }

		public Double CalculateIncomeTax(Double grossIncome)
		{
			this.LoadTaxthreshold();
			
			Double incomeTax = 0;
			for (int i = 0; i < taxthresholds.Count; i++)
			{
				if (grossIncome-(taxthresholds[i].taxMin) > 0 )
				{
					incomeTax = taxthresholds[i].taxLump + ((grossIncome - taxthresholds[i].taxMin)*taxthresholds[i].taxCent);
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