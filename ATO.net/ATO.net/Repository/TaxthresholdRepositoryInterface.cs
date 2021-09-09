using ATO.net.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATO.net.Repository
{
    interface TaxthresholdRepositoryInterface
    {
        Boolean HasRows();
        void InsertToDB(Taxthreshold taxthreshold);
        List<Taxthreshold> ReadTaxthresholdList();
    }
    
}
