using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANA_user_copy_export.FileIO
{
    class FileConverter
    {
        public static List<String> ConvertToRole(List<String> rawFile, String userName, String pass)
        {
            List<String> formated = new List<String>();

            rawFile.RemoveAt(0);
            
            formated.Add(
                SQL.SqlCommands.CreateUser(1) + userName + SQL.SqlCommands.CreateUser(2) + pass + SQL.SqlCommands.CreateUser(3));
            formated.Add(
                SQL.SqlCommands.AlterUser(1) + userName + SQL.SqlCommands.AlterUser(2));

            foreach (var row in rawFile)
            {
                string sor2 = row.Split(';')[1];

                if (!sor2.Equals("PUBLIC"))
                {
                    if (sor2.StartsWith("sap."))
                    {
                        formated.Add(SQL.SqlCommands.GenerateDBInsertSQLRole(1) + sor2 + SQL.SqlCommands.GenerateDBInsertSQLRole(2) + userName + SQL.SqlCommands.GenerateDBInsertSQLRole(3));
                    }
                    else
                        formated.Add(SQL.SqlCommands.GenerateDBInsertSQLPrivilege(1) + sor2 + SQL.SqlCommands.GenerateDBInsertSQLPrivilege(2) + userName + SQL.SqlCommands.GenerateDBInsertSQLPrivilege(3));



                }

            }



            return formated;
        }

       
             public static List<String> ConvertToPrivilege(List<String> rawFile, String userName, String OldUserName)
        {
            List<String> formated = new List<String>();
            int uneccesaryPriv=0;



            rawFile.RemoveAt(0);



            foreach (var row in rawFile)
            {
                
                 
                    string sor2 = row.Split(';')[3].Replace("ADMIN", " ADMIN"); 
                    sor2 = sor2.Replace("CREATE", "CREATE ");
                    sor2 = sor2.Replace("STRUCTURED", "STRUCTURED ");
                    sor2 = sor2.Replace("WORKLOAD", "WORKLOAD ");
                    sor2 = sor2.Replace("OPERATOR", " OPERATOR");
                    sor2 = sor2.Replace("EXTENDED", "EXTENDED ");
                    sor2 = sor2.Replace("CATALOG", "CATALOG ");

                if(row.Split(';')[2]!=OldUserName)
                {
                    if (row.Split(';')[4] == "TRUE") //GRANT OPTION TRUE
                    {
                        if (row.Split(';')[1] == "?" && row.Split(';')[2] == "?")   //AZ ELSŐ KÉT OSZLOP ?
                        {
                            formated.Add(
                                SQL.SqlCommands.GenerateDBInsertSQLPrivilege(1) + sor2 + SQL.SqlCommands.GenerateDBInsertSQLPrivilege(2) + userName + SQL.SqlCommands.GenerateDBInsertSQLPrivilege(3)
                                );
                        }
                        else
                        if (row.Split(';')[1] != "?" && row.Split(';')[2] != "?")   //AZ ELSŐ KÉT OSZLOP NEM ? -- PRIVILEGE ON
                        {
                            formated.Add(
                                  SQL.SqlCommands.GenerateDBInsertSQLPrivilegeOn(1) + sor2 + SQL.SqlCommands.GenerateDBInsertSQLPrivilegeOn(2) + row.Split(';')[2]+ SQL.SqlCommands.GenerateDBInsertSQLPrivilegeOn(3)+ row.Split(';')[1] + SQL.SqlCommands.GenerateDBInsertSQLPrivilegeOn(4) + userName + SQL.SqlCommands.GenerateDBInsertSQLPrivilegeOn(5)+ SQL.SqlCommands.GenerateDBInsertSQLPrivilegeOn(6) + SQL.SqlCommands.GenerateDBInsertSQLPrivilegeOn(7)
                                  );
                        }
                        else
                            if (row.Split(';')[1] == "?" && row.Split(';')[2] != "?")   //A MÁSODIK OSZLOP NEM ? -- PRIVILEGE ON
                        {
                            formated.Add(
                                  SQL.SqlCommands.GenerateDBInsertSQLPrivilegeOnSchema(1) + sor2 + SQL.SqlCommands.GenerateDBInsertSQLPrivilegeOnSchema(2) + row.Split(';')[2] + SQL.SqlCommands.GenerateDBInsertSQLPrivilegeOnSchema(3) + userName + SQL.SqlCommands.GenerateDBInsertSQLPrivilegeOnSchema(4) + SQL.SqlCommands.GenerateDBInsertSQLPrivilegeOnSchema(5) + SQL.SqlCommands.GenerateDBInsertSQLPrivilegeOnSchema(6)
                                      );
                        }


                    }
                    else                            //GRANT OPTION FALSE
                    {
                        if (row.Split(';')[4] == "FALSE")
                        {
                            if (row.Split(';')[1] == "?" && row.Split(';')[2] == "?")   //AZ ELSŐ KÉT OSZLOP ?
                            {
                                formated.Add(
                                    SQL.SqlCommands.GenerateDBInsertSQLPrivilege(1) + sor2 + SQL.SqlCommands.GenerateDBInsertSQLPrivilege(2) + userName + SQL.SqlCommands.GenerateDBInsertSQLPrivilege(3)
                                    );
                            }
                            else
                            if (row.Split(';')[1] != "?" && row.Split(';')[2] != "?")   //AZ ELSŐ KÉT OSZLOP NEM ? -- PRIVILEGE ON
                            {
                                formated.Add(
                                      SQL.SqlCommands.GenerateDBInsertSQLPrivilegeOn(1) + sor2 + SQL.SqlCommands.GenerateDBInsertSQLPrivilegeOn(2) + row.Split(';')[2] + SQL.SqlCommands.GenerateDBInsertSQLPrivilegeOn(3) + row.Split(';')[1] + SQL.SqlCommands.GenerateDBInsertSQLPrivilegeOn(4) + userName + SQL.SqlCommands.GenerateDBInsertSQLPrivilegeOn(5) + SQL.SqlCommands.GenerateDBInsertSQLPrivilegeOn(7)
                                      );
                            }
                            else
                            if (row.Split(';')[1] == "?" && row.Split(';')[2] != "?")   //A MÁSODIK OSZLOP NEM ? -- PRIVILEGE ON
                            {
                                formated.Add(
                                      SQL.SqlCommands.GenerateDBInsertSQLPrivilegeOnSchema(1) + sor2 + SQL.SqlCommands.GenerateDBInsertSQLPrivilegeOnSchema(2) + row.Split(';')[2] + SQL.SqlCommands.GenerateDBInsertSQLPrivilegeOnSchema(3) + userName + SQL.SqlCommands.GenerateDBInsertSQLPrivilegeOnSchema(4) + SQL.SqlCommands.GenerateDBInsertSQLPrivilegeOnSchema(6)
                                      );
                            }
                            //utólag még tesztelni kell
                            else
                            if (row.Split(';')[1] != "?" && row.Split(';')[2] == "?")   //AZ ELSŐ OSZLOP NEM ? A MÁSODIK IGEN
                            {
                                formated.Add(
                                    SQL.SqlCommands.GenerateDBInsertSQLPrivilege(1) + sor2 + SQL.SqlCommands.GenerateDBInsertSQLPrivilege(2) + userName + SQL.SqlCommands.GenerateDBInsertSQLPrivilegeOn(2)+ row.Split(';')[1] + SQL.SqlCommands.GenerateDBInsertSQLPrivilege(3)
                                    );
                            }


                        }
                    }
                }





            }


            int j = formated.Count() - 1;


            for (int i = 0; i < uneccesaryPriv; i++)
            {
                formated.RemoveAt(j--);
            }
          



            return formated;
        }




    }
}
