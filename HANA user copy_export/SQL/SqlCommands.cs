using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANA_user_copy_export.SQL
{
    class SqlCommands
    {
        public static String CreateUser(int x)
        {
            String sql = "";


            /*
            switch (x)
            {
                case 1: sql = "CREATE USER "; break;
                case 2: sql = " PASSWORD '"; break;
                case 3: sql = "';"; break;
            }
            */
           
                switch (x)
            {
                case 1: sql = "CREATE USER "; break;
                case 2: sql = " PASSWORD " + '\u0022'; break;
                case 3: sql = '\u0022'+";"; break;
            }









            return sql;
        }

        public static String AlterUser(int x)
        {
            String sql = "";



            switch (x)
            {
                case 1: sql = "ALTER USER "; break;
                case 2: sql = " FORCE PASSWORD CHANGE;"; break;
            }


            return sql;
        }






        public static String GenerateDBDataSQLRoles(String oldUsername)
        {
            String sql;


            sql = ("SELECT ROLE_NAME, IS_GRANTABLE FROM GRANTED_ROLES where GRANTEE like '" + oldUsername+"';");
       

            return sql;
        }



        public static String GenerateDBDataSQLPrivileges(String oldUsername)
        {
            String sql;


            sql = "select OBJECT_NAME, SCHEMA_NAME, PRIVILEGE, IS_GRANTABLE from GRANTED_PRIVILEGES where grantee = '" + oldUsername+"';";


            return sql;
        }




        public static String GenerateDBInsertSQLRole(int x)
        {
            String sql="";



            switch (x)
            {
                case 1: sql = "call grant_activated_role('"; break;
                case 2: sql = "','"; break;
                case 3: sql = "');"; break;
            }


            return sql;
        }


        public static String GenerateDBInsertSQLPrivilege(int x)
        {
            String sql="";



            switch (x)
            {
                case 1: sql = "GRANT "+ '\u0022'; break;
                case 2: sql = '\u0022'+" to "+ '\u0022'; break;
                case 3: sql = '\u0022'+";"; break;
            }


            return sql;
        }
        public static String GenerateDBInsertSQLPrivilegeOn(int x)
        {
            String sql = "";



            switch (x)
            {
                case 1: sql = "GRANT " + '\u0022'; break;
                case 2: sql = '\u0022' + " ON "+ '\u0022'; break;
                case 3: sql = '\u0022' + "."+ '\u0022' ; break;
                case 4: sql = '\u0022' + " to " + '\u0022'; break;
                case 5: sql = '\u0022'+""; break;
                case 6: sql = " WITH GRANT OPTION"; break;
                case 7: sql = ";"; break;
            }


            return sql;
        }

        public static String GenerateDBInsertSQLPrivilegeOnSchema(int x)
        {
            String sql = "";



            switch (x)
            {
                case 1: sql = "GRANT " + '\u0022'; break;
                case 2: sql = '\u0022' + " ON SCHEMA " + '\u0022'; break;
                case 3: sql = '\u0022' + " to " + '\u0022'; break;
                case 4: sql = '\u0022' + ""; break;
                case 5: sql = " WITH GRANT OPTION"; break;
                case 6: sql = ";"; break;
            }


            return sql;
        }


    }
}
