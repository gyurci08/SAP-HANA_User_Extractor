
namespace HANA_user_copy_export
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.newUserTB = new System.Windows.Forms.TextBox();
            this.oldUserTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.loadRolesBT = new System.Windows.Forms.Button();
            this.loadPrivilegesBT = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.sqlRoleTB = new System.Windows.Forms.TextBox();
            this.sqlPrivilegesTB = new System.Windows.Forms.TextBox();
            this.privilegesLA = new System.Windows.Forms.Label();
            this.GenerateSQLBT = new System.Windows.Forms.Button();
            this.GenerateCommandsBT = new System.Windows.Forms.Button();
            this.rolesLA = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.92519F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.78304F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, -1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(802, 104);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.passwordTB, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(270, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(233, 98);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            // 
            // passwordTB
            // 
            this.passwordTB.Enabled = false;
            this.passwordTB.Location = new System.Drawing.Point(53, 16);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(120, 20);
            this.passwordTB.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Creator: Jandzsó György";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.newUserTB, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.oldUserTB, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(252, 98);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // newUserTB
            // 
            this.newUserTB.Location = new System.Drawing.Point(129, 19);
            this.newUserTB.Name = "newUserTB";
            this.newUserTB.Size = new System.Drawing.Size(120, 20);
            this.newUserTB.TabIndex = 1;
            // 
            // oldUserTB
            // 
            this.oldUserTB.Location = new System.Drawing.Point(3, 19);
            this.oldUserTB.Name = "oldUserTB";
            this.oldUserTB.Size = new System.Drawing.Size(120, 20);
            this.oldUserTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "New User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Old User";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.loadRolesBT, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.loadPrivilegesBT, 1, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(509, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(282, 98);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // loadRolesBT
            // 
            this.loadRolesBT.Location = new System.Drawing.Point(3, 31);
            this.loadRolesBT.Name = "loadRolesBT";
            this.loadRolesBT.Size = new System.Drawing.Size(135, 34);
            this.loadRolesBT.TabIndex = 5;
            this.loadRolesBT.Text = "Load ROLES";
            this.loadRolesBT.UseVisualStyleBackColor = true;
            this.loadRolesBT.Click += new System.EventHandler(this.loadRolesBT_Click);
            // 
            // loadPrivilegesBT
            // 
            this.loadPrivilegesBT.Location = new System.Drawing.Point(144, 31);
            this.loadPrivilegesBT.Name = "loadPrivilegesBT";
            this.loadPrivilegesBT.Size = new System.Drawing.Size(135, 34);
            this.loadPrivilegesBT.TabIndex = 5;
            this.loadPrivilegesBT.Text = "Load PRIVILEGES";
            this.loadPrivilegesBT.UseVisualStyleBackColor = true;
            this.loadPrivilegesBT.Click += new System.EventHandler(this.loadPrivilegesBT_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.90909F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.09091F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 574F));
            this.tableLayoutPanel5.Controls.Add(this.sqlRoleTB, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.sqlPrivilegesTB, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.privilegesLA, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.GenerateSQLBT, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.GenerateCommandsBT, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.rolesLA, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 109);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(793, 85);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // sqlRoleTB
            // 
            this.sqlRoleTB.Enabled = false;
            this.sqlRoleTB.Location = new System.Drawing.Point(221, 8);
            this.sqlRoleTB.Name = "sqlRoleTB";
            this.sqlRoleTB.Size = new System.Drawing.Size(563, 20);
            this.sqlRoleTB.TabIndex = 2;
            // 
            // sqlPrivilegesTB
            // 
            this.sqlPrivilegesTB.Enabled = false;
            this.sqlPrivilegesTB.Location = new System.Drawing.Point(221, 52);
            this.sqlPrivilegesTB.Name = "sqlPrivilegesTB";
            this.sqlPrivilegesTB.Size = new System.Drawing.Size(563, 20);
            this.sqlPrivilegesTB.TabIndex = 3;
            // 
            // privilegesLA
            // 
            this.privilegesLA.AutoSize = true;
            this.privilegesLA.Location = new System.Drawing.Point(143, 56);
            this.privilegesLA.Margin = new System.Windows.Forms.Padding(10, 7, 3, 0);
            this.privilegesLA.Name = "privilegesLA";
            this.privilegesLA.Size = new System.Drawing.Size(70, 13);
            this.privilegesLA.TabIndex = 0;
            this.privilegesLA.Text = "PRIVILEGES";
            // 
            // GenerateSQLBT
            // 
            this.GenerateSQLBT.Location = new System.Drawing.Point(3, 6);
            this.GenerateSQLBT.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.GenerateSQLBT.Name = "GenerateSQLBT";
            this.GenerateSQLBT.Size = new System.Drawing.Size(127, 40);
            this.GenerateSQLBT.TabIndex = 0;
            this.GenerateSQLBT.Text = "Generate SQL";
            this.GenerateSQLBT.UseVisualStyleBackColor = true;
            this.GenerateSQLBT.Click += new System.EventHandler(this.GenerateSQLBT_Click);
            // 
            // GenerateCommandsBT
            // 
            this.GenerateCommandsBT.Location = new System.Drawing.Point(3, 50);
            this.GenerateCommandsBT.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.GenerateCommandsBT.Name = "GenerateCommandsBT";
            this.GenerateCommandsBT.Size = new System.Drawing.Size(127, 32);
            this.GenerateCommandsBT.TabIndex = 0;
            this.GenerateCommandsBT.Text = "Generate COMMANDS";
            this.GenerateCommandsBT.UseVisualStyleBackColor = true;
            this.GenerateCommandsBT.Click += new System.EventHandler(this.GenerateCommandsBT_Click);
            // 
            // rolesLA
            // 
            this.rolesLA.AutoSize = true;
            this.rolesLA.Location = new System.Drawing.Point(144, 10);
            this.rolesLA.Margin = new System.Windows.Forms.Padding(11, 5, 3, 0);
            this.rolesLA.Name = "rolesLA";
            this.rolesLA.Size = new System.Drawing.Size(43, 13);
            this.rolesLA.TabIndex = 0;
            this.rolesLA.Text = "ROLES";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 197);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HANA User Copy";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox oldUserTB;
        private System.Windows.Forms.TextBox newUserTB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button GenerateSQLBT;
        private System.Windows.Forms.TextBox sqlRoleTB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button loadRolesBT;
        private System.Windows.Forms.Button loadPrivilegesBT;
        private System.Windows.Forms.TextBox sqlPrivilegesTB;
        private System.Windows.Forms.Label rolesLA;
        private System.Windows.Forms.Label privilegesLA;
        private System.Windows.Forms.Button GenerateCommandsBT;
        private System.Windows.Forms.Label label6;
    }
}

