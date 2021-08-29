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

namespace hollowsaves
{
	public partial class Hollowsaves : Form
	{
		public Hollowsaves()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
		{

		}

		private void originPath_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			fbd.RootFolder = Environment.SpecialFolder.UserProfile;
			fbd.Description = "Select Hollow Knight saves folder path";
			if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				originPathTextBox.Text = fbd.SelectedPath;
		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{

		}

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void destinyPathButton_Click(object sender, EventArgs e)
        {
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			fbd.RootFolder = Environment.SpecialFolder.UserProfile;
			fbd.Description = "Select the folder where saves will be create";
			if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				destinyPathTextBox.Text = fbd.SelectedPath;
		}

    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void generateSaveButton_Click(object sender, EventArgs e)
        {
			if (originPathTextBox.Text == "")
            {
				MessageBox.Show("Select HK AppData saves path");
				return;
			}

			string[] datFiles = Directory.GetFiles(originPathTextBox.Text, "*.dat");

			if(datFiles.Length == 0)
			{
				MessageBox.Show("Not .dat files found in \"" + originPathTextBox.Text + "\"");
				return;
			}

			string saveName = nameTextBox.Text;

			if (saveName.Equals(""))
            {
				saveName = "save_" + DateTime.UtcNow.ToString("yyyy-MM-ddTHH_mm_ss");

			}

			if (destinyPathTextBox.Text == "")
			{
				MessageBox.Show("Select your saves path");
				return;
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
		}

        private void toRestoreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void restoreSaveButtonClick(object sender, EventArgs e)
        {

			if (comboBox2.SelectedItem== null) {
				MessageBox.Show("Select a save to restore");
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


        private void restoreButtonPathButton_Click(object sender, EventArgs e)
        {
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			fbd.RootFolder = Environment.SpecialFolder.UserProfile;
			fbd.Description = "Select Hollow Knight save files path";
			if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				destinyPathTextBox.Text = fbd.SelectedPath;

			if (fbd.SelectedPath != "")
            {
				string[] dirs = Directory.GetDirectories(fbd.SelectedPath);

				foreach (string dir in dirs)
				{
					comboBox2.Items.Add(dir);
				}
			}

		}

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void destinyPathButton_Click_1(object sender, EventArgs e)
        {
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			fbd.RootFolder = Environment.SpecialFolder.UserProfile;
			fbd.Description = "Select the folder where saves will be create";
			if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				destinyPathTextBox.Text = fbd.SelectedPath;
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
    }
}
