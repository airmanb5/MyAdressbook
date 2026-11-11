namespace Adressbook
{
    partial class FormOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOptions));
            txtFilePath = new TextBox();
            btnBrowse = new Button();
            lblFilePath = new Label();
            btnOk = new Button();
            btnCancel = new Button();
            chckBxStartupLoad = new CheckBox();
            cmbBoxLanguage = new ComboBox();
            SuspendLayout();
            // 
            // txtFilePath
            // 
            resources.ApplyResources(txtFilePath, "txtFilePath");
            txtFilePath.Name = "txtFilePath";
            txtFilePath.ReadOnly = true;
            // 
            // btnBrowse
            // 
            resources.ApplyResources(btnBrowse, "btnBrowse");
            btnBrowse.Name = "btnBrowse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // lblFilePath
            // 
            resources.ApplyResources(lblFilePath, "lblFilePath");
            lblFilePath.Name = "lblFilePath";
            // 
            // btnOk
            // 
            resources.ApplyResources(btnOk, "btnOk");
            btnOk.DialogResult = DialogResult.OK;
            btnOk.Name = "btnOk";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            resources.ApplyResources(btnCancel, "btnCancel");
            btnCancel.Name = "btnCancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // chckBxStartupLoad
            // 
            resources.ApplyResources(chckBxStartupLoad, "chckBxStartupLoad");
            chckBxStartupLoad.Name = "chckBxStartupLoad";
            chckBxStartupLoad.UseVisualStyleBackColor = true;
            chckBxStartupLoad.CheckedChanged += chckBxStartupLoad_CheckedChanged;
            // 
            // cmbBoxLanguage
            // 
            resources.ApplyResources(cmbBoxLanguage, "cmbBoxLanguage");
            cmbBoxLanguage.FormattingEnabled = true;
            cmbBoxLanguage.Items.AddRange(new object[] { resources.GetString("cmbBoxLanguage.Items"), resources.GetString("cmbBoxLanguage.Items1") });
            cmbBoxLanguage.Name = "cmbBoxLanguage";
            cmbBoxLanguage.SelectedIndexChanged += cmbBoxLanguage_SelectedIndexChanged;
            // 
            // FormOptions
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cmbBoxLanguage);
            Controls.Add(chckBxStartupLoad);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(lblFilePath);
            Controls.Add(btnBrowse);
            Controls.Add(txtFilePath);
            Name = "FormOptions";
            Load += FormOptions_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFilePath;
        private Button btnBrowse;
        private Label lblFilePath;
        private Button btnOk;
        private Button btnCancel;
        private CheckBox chckBxStartupLoad;
        private ComboBox cmbBoxLanguage;
    }
}