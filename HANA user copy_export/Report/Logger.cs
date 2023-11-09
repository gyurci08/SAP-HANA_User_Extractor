using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANA_user_copy_export.Report
{
    class Logger
    {
        public static void StartLog(String user, String pass)
        {
            FileIO.LogWriter.Write(user + "\t\t" + pass,"./Runtime log/log.txt");




        }
    }
}
