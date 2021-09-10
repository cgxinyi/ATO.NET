using ATO.net.Models;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;

namespace ATO.net
{
    partial class TaxthresholdDataContext
    {
       public int ReadHasRow()
		{
			TaxthresholdDataContextDataContext dc = new TaxthresholdDataContextDataContext(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=ATO.net.Models.Model1;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
			Table<Taxthreshold> taxTable = dc.GetTable<Taxthreshold>();
			IQueryable<Taxthreshold> query = from row in taxTable select row;
			return query.Count();
		}

		public void AddTaxthreshold(Taxthreshold taxthreshold)
		{
			//Data maping object to our database  
			TaxthresholdDataContextDataContext dc = new TaxthresholdDataContextDataContext(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=ATO.net.Models.Model1;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
			//Adds an entity in a pending insert state to this System.Data.Linq.Table<TEntity>and parameter is the entity which to be added  
			dc.Taxthresholds.InsertOnSubmit(taxthreshold);
			// executes the appropriate commands to implement the changes to the database  
			dc.SubmitChanges();
		}

		public List<Taxthreshold> ReadTaxthresholdTable()
		{
			List<Taxthreshold> taxthresholdList = new List<Taxthreshold>();
			TaxthresholdDataContextDataContext dc = new TaxthresholdDataContextDataContext(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=ATO.net.Models.Model1;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
			Table<Taxthreshold> taxTable = dc.GetTable<Taxthreshold>();
			IQueryable<Taxthreshold> query = from row in taxTable select row;
			taxthresholdList = query.ToList();
			return taxthresholdList;
		}




	}
}