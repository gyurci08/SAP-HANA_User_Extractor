using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HANA_user_copy_export.FileIO
{
    class Loader
    {
      
      

        public static List<String> Load(String path)
        {
            List<String> raw = new List<String>();
            List<String> noWhitespaceRaw = new List<String>();

            String sor;
            using (StreamReader streamReader = File.OpenText(path))
            {
                while ((sor = streamReader.ReadLine()) != null)
                {
                    sor=String.Concat(sor.Where(c => !Char.IsWhiteSpace(c)));
                    raw.Add(sor);
                }
                streamReader.Close();
            }


            return raw;
        }

    }
}
