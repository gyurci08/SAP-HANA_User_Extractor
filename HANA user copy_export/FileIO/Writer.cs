using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANA_user_copy_export.FileIO
{
    class Writer
    {
        public static async void Write(List<String> list, String path)
        {
            using (File.Create(path));


            using (StreamWriter w = File.AppendText(path))
            {
                w.Flush();

                foreach (string line in list)
                {

                    w.WriteLine(line);

                }




                w.Close();
            }
        }
    }
}