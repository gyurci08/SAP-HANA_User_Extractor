using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANA_user_copy_export.FileIO
{
    class LogWriter
    {
        public static void createLogFile(String path)
        {
            using (File.Create(path));
        }


        public static async void Write(String line, String path)
        {
            


            using (StreamWriter w = File.AppendText(path))
            {
                w.Flush();

              
                    w.WriteLine(line);

            




                w.Close();
            }
        }
    }
}