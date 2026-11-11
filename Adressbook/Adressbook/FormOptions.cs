using System;
using System.ComponentModel;
using System.Windows.Forms;

using AppResources = Adressbook.Resources.Resources;

namespace Adressbook
{
    public partial class FormOptions : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string FilePath { get; set; }

        private string selecteddLanguage;

        public FormOptions()
        {
            InitializeComponent();

            selecteddLanguage = LanguageManager.CurrentLanguge;

            LanguageManager.ApplyCulture(selecteddLanguage);
            ApplyLanguage();

            LoadLanguages(selecteddLanguage);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            FilePath = form1.GetSelectedFileFromExplorer();

            txtFilePath.Text = FilePath;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormOptions_Load(object sender, EventArgs e)
        {
            txtFilePath.Text = FilePath;

            chckBxStartupLoad.Checked = Properties.Settings.Default.LoadAdressbookOnStartup;
        }

        private void chckBxStartupLoad_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.LoadAdressbookOnStartup = chckBxStartupLoad.Checked;
            Properties.Settings.Default.AdressbookPath = FilePath;

            Properties.Settings.Default.Language = selecteddLanguage;
            Properties.Settings.Default.Save();

            LanguageManager.ApplyCulture(selecteddLanguage);
        }

        private void LoadLanguages(string selectedLanguage)
        {
            cmbBoxLanguage.SelectedIndexChanged -= cmbBoxLanguage_SelectedIndexChanged;

            cmbBoxLanguage.Items.Clear();

            cmbBoxLanguage.Items.Add(new LanguageItem
            {
                Code = "en",
                DisplayName = AppResources.LanguageEnglish
            });

            cmbBoxLanguage.Items.Add(new LanguageItem
            {
                Code = "de",
                DisplayName = AppResources.LanguageGerman
            });

            cmbBoxLanguage.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (LanguageItem item in cmbBoxLanguage.Items)
            {
                if (item.Code == selectedLanguage)
                {
                    cmbBoxLanguage.SelectedItem = item;
                    break;
                }
            }

            cmbBoxLanguage.SelectedIndexChanged += cmbBoxLanguage_SelectedIndexChanged;
        }

        private void ApplyLanguage()
        {
            Text = AppResources.FormOptionsTitle;

            btnCancel.Text = AppResources.ButtonCancel;
            btnOk.Text = AppResources.ButtonOk;
            btnBrowse.Text = AppResources.ButtonBrowse;

            chckBxStartupLoad.Text = AppResources.CheckLoadOnStartup;
        }

        private void cmbBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxLanguage.SelectedItem is LanguageItem language)
            {
                selecteddLanguage = language.Code;
            }
        }
    }
}
