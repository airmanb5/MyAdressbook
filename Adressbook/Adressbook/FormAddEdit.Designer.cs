namespace Adressbook
{
    partial class FormAddEdit
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
            dateTimePicker1 = new DateTimePicker();
            inputHaircolor = new TextBox();
            inputHeight = new TextBox();
            inputLastName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            inputFirstName = new TextBox();
            btnConfirm = new Button();
            btnCancel = new Button();
            StatusStrip1 = new StatusStrip();
            toolStripStatusLabelSpacer = new ToolStripStatusLabel();
            statusLabel = new ToolStripStatusLabel();
            StatusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(337, 162);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 59;
            // 
            // inputHaircolor
            // 
            inputHaircolor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inputHaircolor.Location = new Point(342, 236);
            inputHaircolor.Name = "inputHaircolor";
            inputHaircolor.Size = new Size(150, 31);
            inputHaircolor.TabIndex = 58;
            inputHaircolor.TextChanged += inputHaircolor_TextChanged;
            // 
            // inputHeight
            // 
            inputHeight.Location = new Point(342, 199);
            inputHeight.Name = "inputHeight";
            inputHeight.Size = new Size(150, 31);
            inputHeight.TabIndex = 57;
            inputHeight.TextChanged += inputHeight_TextChanged;
            // 
            // inputLastName
            // 
            inputLastName.Location = new Point(342, 125);
            inputLastName.Name = "inputLastName";
            inputLastName.Size = new Size(150, 31);
            inputLastName.TabIndex = 56;
            inputLastName.TextChanged += inputLastName_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(241, 162);
            label5.Name = "label5";
            label5.Size = new Size(90, 25);
            label5.TabIndex = 55;
            label5.Text = "Birth Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(244, 239);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 54;
            label4.Text = "Hair Color";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(271, 199);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 53;
            label3.Text = "Height";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 125);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 52;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(239, 91);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 51;
            label1.Text = "First Name";
            // 
            // inputFirstName
            // 
            inputFirstName.Location = new Point(342, 88);
            inputFirstName.Name = "inputFirstName";
            inputFirstName.Size = new Size(150, 31);
            inputFirstName.TabIndex = 50;
            inputFirstName.TextChanged += inputFirstName_TextChanged;
            // 
            // btnConfirm
            // 
            btnConfirm.DialogResult = DialogResult.OK;
            btnConfirm.Location = new Point(669, 82);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(112, 34);
            btnConfirm.TabIndex = 60;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += EditBtn_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(669, 262);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 61;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += cancelAddBtn_Click;
            // 
            // StatusStrip1
            // 
            StatusStrip1.AutoSize = false;
            StatusStrip1.ImageScalingSize = new Size(24, 24);
            StatusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelSpacer, statusLabel });
            StatusStrip1.Location = new Point(0, 418);
            StatusStrip1.Name = "StatusStrip1";
            StatusStrip1.Size = new Size(800, 32);
            StatusStrip1.Stretch = false;
            StatusStrip1.TabIndex = 63;
            StatusStrip1.Text = "dfdfdf";
            // 
            // toolStripStatusLabelSpacer
            // 
            toolStripStatusLabelSpacer.BackColor = SystemColors.Control;
            toolStripStatusLabelSpacer.Name = "toolStripStatusLabelSpacer";
            toolStripStatusLabelSpacer.Size = new Size(22, 25);
            toolStripStatusLabelSpacer.Text = "  ";
            toolStripStatusLabelSpacer.TextAlign = ContentAlignment.MiddleRight;
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(42, 25);
            statusLabel.Text = "Test";
            statusLabel.Click += txtStatus_Click;
            // 
            // FormAddEdit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(StatusStrip1);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(dateTimePicker1);
            Controls.Add(inputHaircolor);
            Controls.Add(inputHeight);
            Controls.Add(inputLastName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(inputFirstName);
            Name = "FormAddEdit";
            Text = "FormAddEdit";
            Load += FormEdit_Load;
            StatusStrip1.ResumeLayout(false);
            StatusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dateTimePicker1;
        private TextBox inputHaircolor;
        private TextBox inputHeight;
        private TextBox inputLastName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox inputFirstName;
        private Button btnConfirm;
        private Button btnCancel;
        private StatusStrip StatusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelSpacer;
        private ToolStripStatusLabel statusLabel;
    }
}