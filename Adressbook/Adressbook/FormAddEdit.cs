using AdressbookLib;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.ComponentModel;
using System.Windows.Forms;

using AppResources = Adressbook.Resources.Resources;

namespace Adressbook
{
    public partial class FormAddEdit : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Person EditedPerson { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool EditMode {  get; set; }

        public FormAddEdit()
        {
            InitializeComponent();

            LanguageManager.ApplyCulture(LanguageManager.CurrentLanguge);

            ApplyLanguage();
        }

        private void printWindow_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            EditedPerson.FirstName = inputFirstName.Text;
            EditedPerson.LastName = inputLastName.Text;
            EditedPerson.BirthDate = dateTimePicker1.Value;

            if (double.TryParse(inputHeight.Text, out double height))
            {
                EditedPerson.Height = height;
            }

            EditedPerson.HairColor = inputHaircolor.Text;

            this.Close();
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            if (EditedPerson.BirthDate != DateTime.MinValue)
            {
                inputFirstName.Text = EditedPerson.FirstName;
                inputLastName.Text = EditedPerson.LastName;
                dateTimePicker1.Value = EditedPerson.BirthDate;
                inputHeight.Text = EditedPerson.Height.ToString();
                inputHaircolor.Text = EditedPerson.HairColor;

                ApplyLanguage();
            }
        }

        private void cancelAddBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EnableDisableEditButton()
        {
            if (string.IsNullOrWhiteSpace(inputFirstName.Text) || string.IsNullOrWhiteSpace(inputLastName.Text) || string.IsNullOrWhiteSpace(inputHeight.Text) || string.IsNullOrWhiteSpace(inputHaircolor.Text) || !Int32.TryParse(inputHeight.Text, out int height))
            {
                btnConfirm.Enabled = false;
            }
            else
            {
                btnConfirm.Enabled = true;
            }
        }

        private void inputFirstName_TextChanged(object sender, EventArgs e)
        {
            EnableDisableEditButton();
        }

        private void inputLastName_TextChanged(object sender, EventArgs e)
        {
            EnableDisableEditButton();
        }

        private void inputHeight_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(inputHeight.Text, out int height))
            {
              statusLabel.Text = string.Empty;

                EnableDisableEditButton();
            }
            else
            {
                btnConfirm.Enabled = false;

                if (!string.IsNullOrWhiteSpace(inputHeight.Text))
                {
                    statusLabel.Text = "Please enter a valid Height.";
                }
            }
        }

        private void inputHaircolor_TextChanged(object sender, EventArgs e)
        {
            EnableDisableEditButton();
        }

        private void txtStatus_Click(object sender, EventArgs e)
        {

        }

        private void ApplyLanguage()
        {
            if (EditMode)
            {
                Text = AppResources.FormEditTitle;
            }
            else
            {
                Text = AppResources.FormAddTitle;
            }

            btnConfirm.Text = AppResources.ButtonConfirm;
            
            btnCancel.Text = AppResources.ButtonCancel;
        }
    }
}

