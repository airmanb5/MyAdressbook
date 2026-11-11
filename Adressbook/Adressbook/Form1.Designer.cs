namespace Adressbook
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            printWindow = new ListView();
            columnFirstName = new ColumnHeader();
            columnLastName = new ColumnHeader();
            columnAge = new ColumnHeader();
            columnHeight = new ColumnHeader();
            columnHairColor = new ColumnHeader();
            contextMenuStripEditDelete = new ContextMenuStrip(components);
            toolStripMenuItemEdit = new ToolStripMenuItem();
            toolStripMenuItemDelete = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            toolStripMenuFile = new ToolStripMenuItem();
            toolStripMenuLoad = new ToolStripMenuItem();
            toolStripMenuSave = new ToolStripMenuItem();
            toolStripMenuSaveAs = new ToolStripMenuItem();
            toolStripMenuPerson = new ToolStripMenuItem();
            toolStripMenuAdd = new ToolStripMenuItem();
            toolStripMenuEdit = new ToolStripMenuItem();
            toolStripMenuDelete = new ToolStripMenuItem();
            toolStripMenuTools = new ToolStripMenuItem();
            toolStripMenuOptions = new ToolStripMenuItem();
            StatusStrip2 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            contextMenuStripEditDelete.SuspendLayout();
            menuStrip1.SuspendLayout();
            StatusStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // printWindow
            // 
            printWindow.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            printWindow.Columns.AddRange(new ColumnHeader[] { columnFirstName, columnLastName, columnAge, columnHeight, columnHairColor });
            printWindow.ContextMenuStrip = contextMenuStripEditDelete;
            printWindow.Location = new Point(0, 36);
            printWindow.Name = "printWindow";
            printWindow.Size = new Size(800, 379);
            printWindow.TabIndex = 15;
            printWindow.UseCompatibleStateImageBehavior = false;
            printWindow.View = View.Details;
            printWindow.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnFirstName
            // 
            columnFirstName.Text = "First Name";
            columnFirstName.Width = 100;
            // 
            // columnLastName
            // 
            columnLastName.Text = "Last Name";
            columnLastName.Width = 100;
            // 
            // columnAge
            // 
            columnAge.Text = "Age";
            // 
            // columnHeight
            // 
            columnHeight.Text = "Height (cm)";
            columnHeight.Width = 104;
            // 
            // columnHairColor
            // 
            columnHairColor.Text = "Hair Color";
            columnHairColor.Width = 100;
            // 
            // contextMenuStripEditDelete
            // 
            contextMenuStripEditDelete.ImageScalingSize = new Size(24, 24);
            contextMenuStripEditDelete.Items.AddRange(new ToolStripItem[] { toolStripMenuItemEdit, toolStripMenuItemDelete });
            contextMenuStripEditDelete.Name = "contextMenuStripEditDelete";
            contextMenuStripEditDelete.Size = new Size(135, 68);
            // 
            // editToolStripMenuItem2
            // 
            toolStripMenuItemEdit.Name = "editToolStripMenuItem2";
            toolStripMenuItemEdit.Size = new Size(134, 32);
            toolStripMenuItemEdit.Text = "Edit";
            toolStripMenuItemEdit.Click += editToolStripMenuItem2_Click;
            // 
            // deleteToolStripMenuItem
            // 
            toolStripMenuItemDelete.Name = "deleteToolStripMenuItem";
            toolStripMenuItemDelete.Size = new Size(134, 32);
            toolStripMenuItemDelete.Text = "Delete";
            toolStripMenuItemDelete.Click += deleteToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuFile, toolStripMenuPerson, toolStripMenuTools });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 24;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuFile
            // 
            toolStripMenuFile.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuLoad, toolStripMenuSave, toolStripMenuSaveAs });
            toolStripMenuFile.Name = "toolStripMenuFile";
            toolStripMenuFile.Size = new Size(54, 29);
            toolStripMenuFile.Text = "File";
            // 
            // toolStripMenuLoad
            // 
            toolStripMenuLoad.Name = "toolStripMenuLoad";
            toolStripMenuLoad.Size = new Size(188, 34);
            toolStripMenuLoad.Text = "Load";
            toolStripMenuLoad.Click += toolStripMenuLoad_Click;
            // 
            // toolStripMenuSave
            // 
            toolStripMenuSave.Name = "toolStripMenuSave";
            toolStripMenuSave.Size = new Size(188, 34);
            toolStripMenuSave.Text = "Save";
            toolStripMenuSave.Click += toolStripMenuSave_Click;
            // 
            // toolStripMenuSaveAs
            // 
            toolStripMenuSaveAs.Name = "toolStripMenuSaveAs";
            toolStripMenuSaveAs.Size = new Size(188, 34);
            toolStripMenuSaveAs.Text = "Save As...";
            toolStripMenuSaveAs.Click += toolStripMenuSaveAs_Click;
            // 
            // toolStripMenuPerson
            // 
            toolStripMenuPerson.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuAdd, toolStripMenuEdit, toolStripMenuDelete });
            toolStripMenuPerson.Name = "toolStripMenuPerson";
            toolStripMenuPerson.Size = new Size(81, 29);
            toolStripMenuPerson.Text = "Person";
            // 
            // toolStripMenuAdd
            // 
            toolStripMenuAdd.Name = "toolStripMenuAdd";
            toolStripMenuAdd.Size = new Size(164, 34);
            toolStripMenuAdd.Text = "Add";
            toolStripMenuAdd.Click += toolStripMenuAdd_Click;
            // 
            // toolStripMenuEdit
            // 
            toolStripMenuEdit.Enabled = false;
            toolStripMenuEdit.Name = "toolStripMenuEdit";
            toolStripMenuEdit.Size = new Size(164, 34);
            toolStripMenuEdit.Text = "Edit";
            toolStripMenuEdit.Click += toolStripMenuEdit_Click;
            // 
            // toolStripMenuDelete
            // 
            toolStripMenuDelete.Enabled = false;
            toolStripMenuDelete.Name = "toolStripMenuDelete";
            toolStripMenuDelete.Size = new Size(164, 34);
            toolStripMenuDelete.Text = "Delete";
            toolStripMenuDelete.Click += toolStripMenuDelete_Click;
            // 
            // toolStripMenuTools
            // 
            toolStripMenuTools.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuOptions });
            toolStripMenuTools.Name = "toolStripMenuTools";
            toolStripMenuTools.Size = new Size(69, 29);
            toolStripMenuTools.Text = "Tools";
            // 
            // toolStripMenuOptions
            // 
            toolStripMenuOptions.Name = "toolStripMenuOptions";
            toolStripMenuOptions.Size = new Size(270, 34);
            toolStripMenuOptions.Text = "Options";
            toolStripMenuOptions.Click += toolStripMenuOptions_Click;
            // 
            // StatusStrip2
            // 
            StatusStrip2.AutoSize = false;
            StatusStrip2.ImageScalingSize = new Size(24, 24);
            StatusStrip2.Items.AddRange(new ToolStripItem[] { statusLabel });
            StatusStrip2.Location = new Point(0, 418);
            StatusStrip2.Name = "StatusStrip2";
            StatusStrip2.RightToLeft = RightToLeft.Yes;
            StatusStrip2.Size = new Size(800, 32);
            StatusStrip2.TabIndex = 26;
            StatusStrip2.Text = "dfdfdf";
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(42, 25);
            statusLabel.Text = "Test";
            statusLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(StatusStrip2);
            Controls.Add(menuStrip1);
            Controls.Add(printWindow);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "MyAdressbook";
            FormClosing += Form1_FormClosing;
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            contextMenuStripEditDelete.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            StatusStrip2.ResumeLayout(false);
            StatusStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView printWindow;
        private ColumnHeader columnFirstName;
        private ColumnHeader columnLastName;
        private ColumnHeader columnAge;
        private ColumnHeader columnHeight;
        private ColumnHeader columnHairColor;
        private ContextMenuStrip contextMenuStripEditDelete;
        private ToolStripMenuItem toolStripMenuItemEdit;
        private ToolStripMenuItem toolStripMenuItemDelete;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuFile;
        private ToolStripMenuItem toolStripMenuLoad;
        private ToolStripMenuItem toolStripMenuSave;
        private ToolStripMenuItem toolStripMenuPerson;
        private StatusStrip moinServusMoin;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel statusLabel;
        private StatusStrip StatusStrip2;
        private ToolStripMenuItem toolStripMenuAdd;
        private ToolStripMenuItem toolStripMenuEdit;
        private ToolStripMenuItem toolStripMenuDelete;
        private ToolStripMenuItem toolStripMenuSaveAs;
        private ToolStripMenuItem toolStripMenuTools;
        private ToolStripMenuItem toolStripMenuOptions;
    }
}
