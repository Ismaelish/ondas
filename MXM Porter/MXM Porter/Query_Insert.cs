using MXM_Porter.DBC;
using MXM_Porter.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MXM_Porter
{
    public class Query_Insert
    {
        public List<TableAzure> GetServer1Data()
        {
            using (var context = new DBC_Azure_204())
            {
                return context.TableAzures.ToList();
            }
        }

        public void TransferDataToServer2(List<TableAzure> dataToTransfer)
        {
            using (var context = new DBC_Azure_204())
            {
                foreach (var item in dataToTransfer)
                {
                    var server2Entity = new Table204
                    {
                        ID = item.ID,
                        Reference204 = item.ReferenceAzure,
                     
                    };
                    context.Table204s.Add(server2Entity);
                }

                context.SaveChanges();
            }
        }
    }
}
