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
    using System.Data;
    using System.Data.SqlClient;
    using System.Diagnostics;
    using Moq;
    using System.Linq;
    using System.Data.Linq.Mapping;

   
    public partial class Taxthreshold 
    {
        private Func<IDbConnection> p;

        public static object Rows { get; internal set; }

       
        public Taxthreshold(Func<IDbConnection> p)
        {
            this.p = p;
        }

        internal static object AsEnumerable()
        {
            throw new NotImplementedException();
        }




        //   public int taxthresholdId { get; set; }
        //   public Double taxMin { get; set; }
        //   public Double taxCent { get; set; }
        //   public Double taxLump { get; set; }

        public static implicit operator Taxthreshold(global::Moq.Mock<Taxthreshold> v)
        {
            throw new NotImplementedException();
        }

        public virtual bool HasRows()
        {
            throw new NotImplementedException();
        }

        
    }

   
}
