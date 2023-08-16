using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MXM_Porter.MODEL
{
    public class DM_Azure_204
    {
    }
    //AZURE!
    public class TableAzure
    {
        [Key]
        public int ID { get; set; }
        public string? ReferenceAzure { get; set; }
        
    }

    //204
    public class Table204
    {
        [Key]
        public int ID { get; set; }
        public string? Reference204 { get; set; }
     
    }

}
