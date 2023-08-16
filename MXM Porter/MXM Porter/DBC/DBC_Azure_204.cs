using MXM_Porter.MODEL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MXM_Porter.DBC
{
    public class DBC_Azure_204 : DbContext
    {
    //For Azure
   
        public DbSet<TableAzure>? TableAzures { get; set; }
   

    //For 204
 
        public DbSet<Table204>? Table204s { get; set; }

    
    }
}
