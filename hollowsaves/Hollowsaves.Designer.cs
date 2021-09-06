
using System;
using System.IO;

namespace hollowsaves
{
	partial class Hollowsaves
    {
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hollowsaves));
            this.originPath = new System.Windows.Forms.Button();
            this.originPathTextBox = new System.Windows.Forms.TextBox();
            this.destinyPathTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.generateSaveButton = new System.Windows.Forms.Button();
            this.restoreSaveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.destinyPathButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // originPath
            // 
            this.originPath.Image = ((System.Drawing.Image)(resources.GetObject("originPath.Image")));
            this.originPath.Location = new System.Drawing.Point(468, 20);
            this.originPath.Name = "originPath";
            this.originPath.Size = new System.Drawing.Size(27, 22);
            this.originPath.TabIndex = 3;
            this.originPath.UseVisualStyleBackColor = true;
            this.originPath.Click += new System.EventHandler(this.originPath_Click);
            // 
            // originPathTextBox
            // 
            this.originPathTextBox.Location = new System.Drawing.Point(129, 21);
            this.originPathTextBox.Name = "originPathTextBox";
            this.originPathTextBox.Size = new System.Drawing.Size(339, 20);
            this.originPathTextBox.TabIndex = 4;
            this.originPathTextBox.Text = global::hollowsaves.Properties.Settings.Default.originPath;
            // 
            // destinyPathTextBox
            // 
            this.destinyPathTextBox.Location = new System.Drawing.Point(129, 60);
            this.destinyPathTextBox.Name = "destinyPathTextBox";
            this.destinyPathTextBox.Size = new System.Drawing.Size(339, 20);
            this.destinyPathTextBox.TabIndex = 5;
            this.destinyPathTextBox.Text = global::hollowsaves.Properties.Settings.Default.destinyPath;
            this.destinyPathTextBox.TextChanged += new System.EventHandler(this.destinyPathTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(129, 133);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(339, 20);
            this.nameTextBox.TabIndex = 8;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "HK AppData Saves";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Your saves path";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Save name (optional)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // generateSaveButton
            // 
            this.generateSaveButton.Location = new System.Drawing.Point(324, 159);
            this.generateSaveButton.Name = "generateSaveButton";
            this.generateSaveButton.Size = new System.Drawing.Size(144, 23);
            this.generateSaveButton.TabIndex = 12;
            this.generateSaveButton.Text = "Generate save";
            this.generateSaveButton.UseVisualStyleBackColor = true;
            this.generateSaveButton.Click += new System.EventHandler(this.generateSaveButton_Click);
            // 
            // restoreSaveButton
            // 
            this.restoreSaveButton.Location = new System.Drawing.Point(324, 221);
            this.restoreSaveButton.Name = "restoreSaveButton";
            this.restoreSaveButton.Size = new System.Drawing.Size(144, 23);
            this.restoreSaveButton.TabIndex = 14;
            this.restoreSaveButton.Text = "Restore selected save";
            this.restoreSaveButton.UseVisualStyleBackColor = true;
            this.restoreSaveButton.Click += new System.EventHandler(this.restoreSaveButtonClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 15;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(129, 194);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(339, 21);
            this.comboBox2.TabIndex = 18;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // destinyPathButton
            // 
            this.destinyPathButton.Image = ((System.Drawing.Image)(resources.GetObject("destinyPathButton.Image")));
            this.destinyPathButton.Location = new System.Drawing.Point(468, 59);
            this.destinyPathButton.Name = "destinyPathButton";
            this.destinyPathButton.Size = new System.Drawing.Size(27, 22);
            this.destinyPathButton.TabIndex = 19;
            this.destinyPathButton.UseVisualStyleBackColor = true;
            this.destinyPathButton.Click += new System.EventHandler(this.destinyPathButton_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Your saves list";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Hollowsaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 268);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.destinyPathButton);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.restoreSaveButton);
            this.Controls.Add(this.generateSaveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.destinyPathTextBox);
            this.Controls.Add(this.originPathTextBox);
            this.Controls.Add(this.originPath);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hollowsaves";
            this.Text = "HK Saves";
            this.Load += new System.EventHandler(this.Hollowsaves_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button originPath;
        private System.Windows.Forms.TextBox originPathTextBox;
        private System.Windows.Forms.TextBox destinyPathTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button generateSaveButton;
        private System.Windows.Forms.Button restoreSaveButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button destinyPathButton;
        private System.Windows.Forms.Label label6;
    }
}

