using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IGEN_Storage_system_v2
{
    public class Tax
    {
        public int TaxID { get; set; }
        public int GiverID { get; set; }
        public int ItemID { get; set; }
        public int Taxstate { get; set; }

        BindingSource bs = new BindingSource();


        public Tax(int taxID, int giverID, int itemID, int taxState)
        {
            TaxID = taxID;
            GiverID = giverID;
            ItemID = itemID;
            Taxstate = taxState;
        }

        public void ShowTaxList(DataGridView dataGrid)
        {
            var taxList = SqlConnector.RetrieveTax("SQL her");
            bs.DataSource = typeof(Tax);

            foreach (var tax in taxList)
            {
                bs.Add(tax);
            }

            dataGrid.DataSource = bs;
        }

    }
}
