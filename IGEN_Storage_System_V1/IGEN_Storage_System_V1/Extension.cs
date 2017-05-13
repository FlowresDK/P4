
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGEN_Storage_System_V1
{
    class Extension
    { 
        private SqlConnection SqlConn new SqlConnection();

        public void Print1() //TODO - Find better name
        {
        }

        public void Print2() //TODO - Find better name
        {
        }

        public void Print3() //TODO - Find better name
        {
        }

        public void CheckRights()
        {
        }

        public void CleanGiverRegistry()
        {
            var cutOfDate = DateTime.Today.AddDays(-365);

            SqlConn.ExecuteSQL("DELETE FROM giver WHERE giver_reg_date < " + cutOfDate);//Cheeck query-string upon implementation
        }

        public void CleanItemRegistry()
        {
        }

        public void CleanItemActionLog()
        {
            var cutOfDate = DateTime.Today.AddDays(-365);

            SqlConn.ExecuteSQL("DELETE FROM item_action_log WHERE log_date < " + cutOfDate);//Cheeck query-string upon implementation
        }
    }
}
