using HANA_user_copy_export.Prequisites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANA_user_copy_export
{
    public partial class MainWindow : Form
    {
        private String oldUser;
        private String newUser;
        private String filePathRoles;
        private String filePathPrivileges;
        List<String> allSQL;
        private String logPath = "./Runtime log/log.txt";


        public MainWindow()
        {
            InitializeComponent();
            FileIO.LogWriter.createLogFile(logPath);
        }

       


        private void GenerateSQLBT_Click(object sender, EventArgs e)
        {
            newUser = newUserTB.Text.ToUpper();
            oldUser = oldUserTB.Text.ToUpper();

            if (Checks.CheckTextBox(oldUserTB.Text) && Checks.CheckTextBox(newUser))
            {
                sqlRoleTB.Text = SQL.SqlCommands.GenerateDBDataSQLRoles(oldUser);
                sqlRoleTB.Enabled = true;

                sqlPrivilegesTB.Text = SQL.SqlCommands.GenerateDBDataSQLPrivileges(oldUser);
                sqlPrivilegesTB.Enabled = true;

                

            }
            else { MessageBox.Show("Enter the usernames (without special characters)", "Stop!", 0, MessageBoxIcon.Information); }
        }


        private void GenerateCommandsBT_Click(object sender, EventArgs e)
        {
            newUser = newUserTB.Text.ToUpper();
            oldUser = oldUserTB.Text.ToUpper();
           

            try {
                if (Checks.CheckTextBox(oldUser) && Checks.CheckTextBox(newUser) && Checks.CheckFileOpened(filePathRoles) && Checks.CheckFileOpened(filePathPrivileges))
                {
                   

                    passwordTB.Text = Security.PasswordGenerator.Generate();
                    passwordTB.Enabled = true;
                    
                    allSQL = FileIO.FileConverter.ConvertToRole(FileIO.Loader.Load(filePathRoles), newUser, passwordTB.Text);
                    allSQL.AddRange(FileIO.FileConverter.ConvertToPrivilege(FileIO.Loader.Load(filePathPrivileges), newUser, oldUser));
                    FileIO.Writer.Write(allSQL, "./Text/SQL_COMMANDS.txt");
                    System.Diagnostics.Process.Start("notepad.exe", "./Text/SQL_COMMANDS.txt");
                    Report.Logger.StartLog(newUser, passwordTB.Text);
                }
                else { MessageBox.Show("Enter the usernames (without special characters) and load the right files.", "Stop!", 0, MessageBoxIcon.Information); }
            }
            catch(Exception x) { MessageBox.Show("You must loaded the wrong file(s)! \n\nExc: " + x.ToString().Substring(0, 31), "Error!" , 0,MessageBoxIcon.Error); }
            




        }


        private void loadRolesBT_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePathRoles = openFileDialog.FileName;
                }
            }
        }

        private void loadPrivilegesBT_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePathPrivileges = openFileDialog.FileName;
                }
            }
        }

    }
    

}

