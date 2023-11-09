using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANA_user_copy_export.Prequisites
{
    class Checks
    {
        public static Boolean CheckTextBox(String s)
        {
            String specialCharacters = "'.;?,-*/{}@&&#<>¤ß$Ł[]đĐÄ|€~ˇ^˘°˛`˙´˝¨"+ '\u0022';


            if (s==null)                //Existence check
                return false;


            if (s.Length < 1)                //Length check
                return false;

            for (int i=0;i<s.Length;i++)   //Special character check
            {
                
                
                for (int j = 0; j < specialCharacters.Length; j++)        
                {
                    if (s[i].Equals(specialCharacters[j])) return false;
                }

            }



            return true;
        }



        public static Boolean CheckFileOpened(String s)
        {
           

            if (s == null)                //Existence check
                return false;


            if (s.Length < 1)                //Length check
                return false;



            return true;
        }




    }
}
