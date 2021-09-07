using System;
using System.IO;
using System.Windows.Forms;

namespace hollowsaves
{
    public partial class Hollowsaves : Form
	{
		public Hollowsaves()
		{
			InitializeComponent();

			if (String.IsNullOrEmpty(Properties.Settings.Default.originPath))
			{
				Properties.Settings.Default.originPath = String.Concat("C:\\Users\\<Your username>\\AppData\\LocalLow\\Team Cherry\\Hollow Knight");
				originPathTextBox.Text = Properties.Settings.Default.originPath;
				Properties.Settings.Default.Save();
			}

			if (String.IsNullOrEmpty(Properties.Settings.Default.destinyPath))
			{
				Properties.Settings.Default.destinyPath = String.Concat("C:\\Users\\<Your username>\\", Environment.SpecialFolder.MyDocuments, "\\saves");
				destinyPathTextBox.Text = Properties.Settings.Default.destinyPath;
				Properties.Settings.Default.Save();
			}

			if (Directory.Exists(Properties.Settings.Default.destinyPath))
			{
				string[] dirs = Directory.GetDirectories(Properties.Settings.Default.destinyPath);
				foreach (string dir in dirs)
				{
					comboBox2.Items.Add(dir);
				}
			}
		}

		private void originPath_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			fbd.Description = "Select Hollow Knight saves folder path";
			if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK) { 
				originPathTextBox.Text = fbd.SelectedPath;
				Properties.Settings.Default.originPath = fbd.SelectedPath;
				Properties.Settings.Default.Save();
			}
		}
  
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void generateSaveButton_Click(object sender, EventArgs e)
        {
			if (String.IsNullOrEmpty(originPathTextBox.Text))
            {
				MessageBox.Show("Select HK AppData saves path");
				return;
			}

			if (String.IsNullOrEmpty(destinyPathTextBox.Text))
			{
				MessageBox.Show("Select your saves path");
				return;
			}

			if (!Directory.Exists(originPathTextBox.Text))
			{
				MessageBox.Show("Selected HK AppData saves path does not exist");
				return;
			}

			if (!Directory.Exists(destinyPathTextBox.Text))
			{
				MessageBox.Show("Selected saves path does not exist");
				return;
			}

			string[] datFiles = Directory.GetFiles(originPathTextBox.Text, "*.dat");

			if(datFiles.Length == 0)
			{
				MessageBox.Show("Not .dat files found in \"" + originPathTextBox.Text + "\"");
				return;
			}

			string saveName = nameTextBox.Text;

			if (String.IsNullOrEmpty(saveName))
            {
				saveName = "save_" + DateTime.UtcNow.ToString("yyyy-MM-ddTHH_mm_ss");
			}

			string path = String.Concat(destinyPathTextBox.Text, "\\", saveName);

			if (!Directory.Exists(path))
			{
				DirectoryInfo di = Directory.CreateDirectory(path);
			}

			foreach (string f in datFiles)
            {
				string fName = f.Substring(originPathTextBox.Text.Length + 1);
				File.Copy(Path.Combine(originPathTextBox.Text, fName), Path.Combine(path, fName), true);
			}

			MessageBox.Show("Save \"" + saveName + "\" file generated!");

			string[] dirs = Directory.GetDirectories(destinyPathTextBox.Text);
			comboBox2.Items.Clear();
			foreach (string dir in dirs)
			{
				comboBox2.Items.Add(dir);
			}
		}


        private void restoreSaveButtonClick(object sender, EventArgs e)
        {
			if (comboBox2.SelectedItem== null) {
				MessageBox.Show("Select a save to restore");
				return;
            }

			if (!Directory.Exists(comboBox2.SelectedItem.ToString()))
			{
				MessageBox.Show("Selected save does not exist");
				return;
			}

			string[] datFiles = Directory.GetFiles(comboBox2.SelectedItem.ToString(), "*.dat");

			if (datFiles.Length == 0)
			{
				MessageBox.Show("Not .dat files found in \"" + comboBox2.SelectedItem.ToString() + "\"");
				return;
			}

			foreach (string f in datFiles)
			{
				string fName = f.Substring(comboBox2.SelectedItem.ToString().Length + 1);
				File.Copy(Path.Combine(comboBox2.SelectedItem.ToString(), fName), Path.Combine(originPathTextBox.Text, fName), true);			
			}

			MessageBox.Show("Save \"" + comboBox2.SelectedItem.ToString() + "\" restored!");
		}

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void destinyPathButton_Click_1(object sender, EventArgs e)
        {
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			fbd.Description = "Select Hollow Knight save files path";
			if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
				destinyPathTextBox.Text = fbd.SelectedPath;
				Properties.Settings.Default.destinyPath = fbd.SelectedPath;
				Properties.Settings.Default.Save();
			}
				

			if (!String.IsNullOrEmpty(fbd.SelectedPath))
            {
				string[] dirs = Directory.GetDirectories(fbd.SelectedPath);
				comboBox2.Items.Clear();
				foreach (string dir in dirs)
				{
					comboBox2.Items.Add(dir);
				}
			}	
		}

        private void destinyPathTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Hollowsaves_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
