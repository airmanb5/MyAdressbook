using AdressbookLib;
using System.Text.Json;

using AppResources = Adressbook.Resources.Resources;

namespace Adressbook
{
    public partial class Form1 : Form
    {
        Adressmanagement MyAdressbook;

        Person CurrentPerson;

        Persistor Persistor;

        string fileName = string.Empty;

        public Form1()
        {
            LanguageManager.ApplyCulture(LanguageManager.CurrentLanguge);

            MyAdressbook = new Adressmanagement();

            CurrentPerson = new Person();

            Persistor = new Persistor();

            fileName = Properties.Settings.Default.AdressbookPath;

            InitializeComponent();

            ApplyLanguage();

            if (Properties.Settings.Default.LoadAdressbookOnStartup)
            {
                if (File.Exists(fileName))
                {
                    MyAdressbook = Persistor.LoadFromJson(fileName);

                    Print();

                    statusLabel.Text = AppResources.StatusAdressbookLoaded;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void inputFirstName_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void inputHeight_TextChanged(object sender, EventArgs e)
        {
        }

        private void inputHaircolor_TextChanged(object sender, EventArgs e)
        {
        }

        private void inputLastName_TextChanged(object sender, EventArgs e)
        {
        }

        public void Print()

        {
            printWindow.Items.Clear();

            foreach (Person person in MyAdressbook.Personen)
            {
                ListViewItem item = new ListViewItem(person.FirstName);

                item.SubItems.Add(person.LastName);
                item.SubItems.Add(person.Age.ToString());
                item.SubItems.Add(person.Height.ToString());
                item.SubItems.Add(person.HairColor);

                item.Tag = person;

                printWindow.Items.Add(item);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

        }

        private void btn_Load_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableDisableEditAndDelete();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (printWindow.SelectedItems.Count > 0)
            {
                using FormAddEdit formEdit = new FormAddEdit();

                formEdit.EditMode = true;

                formEdit.EditedPerson = (Person)printWindow.SelectedItems[0].Tag;

                DialogResult result = formEdit.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Print();
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!HasChanges())
            {
                return;
            }
            string message = string.Format(AppResources.MessageSaveBeforeClosing, fileName);

            DialogResult result = MessageBox.Show(message, AppResources.MessageCloseTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Persistor.SaveAsJson(fileName, MyAdressbook);
            }

            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }

        }

        private void inputHeight_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip6_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }



        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Person personToDelete = CurrentPerson;

            MyAdressbook.Delete(personToDelete);

            statusLabel.Text = AppResources.StatusPersonDeleted;



            Print();

            EnableDisableEditAndDelete();
        }

        private bool HasChanges()
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string savedJson = File.ReadAllText(fileName);

            string currentJson = JsonSerializer.Serialize(MyAdressbook, options);

            return savedJson != currentJson;
        }

        private void toolStripMenuLoad_Click(object sender, EventArgs e)
        {
            MyAdressbook = Persistor.LoadFromJson(GetSelectedFileFromExplorer());

            Print();

            statusLabel.Text = AppResources.StatusAdressbookLoaded;
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuSave_Click(object sender, EventArgs e)
        {
            Persistor.SaveAsJson(fileName, MyAdressbook);

            statusLabel.Text = AppResources.StatusAdressbookSaved;
        }

        private void toolStripMenuAdd_Click(object sender, EventArgs e)
        {
            Person personToAdd = new Person();

            using FormAddEdit formEdit = new FormAddEdit();

            formEdit.EditMode = false;
            formEdit.EditedPerson = personToAdd;

            DialogResult result = formEdit.ShowDialog();

            if (result == DialogResult.OK)
            {
                MyAdressbook.Add(formEdit.EditedPerson);

                Print();
            }
        }

        private void toolStripMenuEdit_Click(object sender, EventArgs e)
        {
            if (printWindow.SelectedItems.Count > 0)
            {
                using FormAddEdit formEdit = new FormAddEdit();

                formEdit.EditMode = true;

                formEdit.EditedPerson = (Person)printWindow.SelectedItems[0].Tag;

                DialogResult result = formEdit.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Print();
                }

                EnableDisableEditAndDelete();
            }
        }

        private void toolStripMenuDelete_Click(object sender, EventArgs e)
        {
            Person personToDelete = CurrentPerson;

            MyAdressbook.Delete(personToDelete);

            statusLabel.Text = AppResources.StatusPersonDeleted;

            Print();

            EnableDisableEditAndDelete();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        public string GetSelectedFileFromExplorer()
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "JSON files (*.json)|*.json";

            openFileDialog.ShowDialog();

            return openFileDialog.FileName;
        }

        private void toolStripMenuSaveAs_Click(object sender, EventArgs e)
        {
            statusLabel.Text = Persistor.SaveAsJson(GetSelectedFileFromExplorer(), MyAdressbook);
        }

        private void toolStripMenuOptions_Click(object sender, EventArgs e)
        {
            FormOptions formOptions = new FormOptions();

            formOptions.FilePath = fileName;

            DialogResult result = formOptions.ShowDialog();

            if (result == DialogResult.OK)
            {
                ApplyLanguage();

                fileName = formOptions.FilePath;
            }
        }

        private void ApplyLanguage()
        {
            Text = AppResources.FormMainTitle;

            toolStripMenuFile.Text = AppResources.MenuFile;
            toolStripMenuSave.Text = AppResources.MenuButtonSave;
            toolStripMenuLoad.Text = AppResources.MenuButtonLoad;
            toolStripMenuSaveAs.Text = AppResources.MenuButtonSaveAs;

            toolStripMenuPerson.Text = AppResources.MenuPerson;
            toolStripMenuAdd.Text = AppResources.MenuButtonAdd;
            toolStripMenuEdit.Text = AppResources.MenuButtonEdit;
            toolStripMenuDelete.Text = AppResources.MenuButtonDelete;

            toolStripMenuTools.Text = AppResources.MenuTools;
            toolStripMenuOptions.Text = AppResources.MenuButtonOptions;

            columnFirstName.Text = AppResources.ColumnFirstName;
            columnLastName.Text = AppResources.ColumnLastName;
            columnAge.Text = AppResources.ColumnAge;
            columnHeight.Text = AppResources.ColumnHeight;
            columnHairColor.Text = AppResources.ColumnHairColor;

            toolStripMenuItemEdit.Text = AppResources.MenuButtonEdit;
            toolStripMenuItemDelete.Text = AppResources.MenuButtonDelete;

        }


        private void EnableDisableEditAndDelete()
        {
            if (printWindow.SelectedItems.Count > 0)
            {
                toolStripMenuDelete.Enabled = true;
                toolStripMenuEdit.Enabled = true;
                toolStripMenuItemEdit.Enabled = true;
                toolStripMenuItemDelete.Enabled = true;


                if (printWindow.SelectedItems[0].Tag is Person person)
                {
                    CurrentPerson = person;
                }
            }
            else
            {
                toolStripMenuDelete.Enabled = false;
                toolStripMenuEdit.Enabled = false;
                toolStripMenuItemEdit.Enabled = false;
                toolStripMenuItemDelete.Enabled = false;
            }
        }
    }
}
