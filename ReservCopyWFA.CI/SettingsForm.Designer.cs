namespace ReservCopyWFA.CI
{
    partial class SettingsForm
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
            this.dateNameFolderCheckBox = new System.Windows.Forms.CheckBox();
            this.saveSettingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateNameFolderCheckBox
            // 
            this.dateNameFolderCheckBox.AutoSize = true;
            this.dateNameFolderCheckBox.Checked = true;
            this.dateNameFolderCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dateNameFolderCheckBox.Location = new System.Drawing.Point(12, 12);
            this.dateNameFolderCheckBox.Name = "dateNameFolderCheckBox";
            this.dateNameFolderCheckBox.Size = new System.Drawing.Size(343, 17);
            this.dateNameFolderCheckBox.TabIndex = 1;
            this.dateNameFolderCheckBox.Text = "Использовать в наменовании папки хранилища текущую дату";
            this.dateNameFolderCheckBox.UseVisualStyleBackColor = true;
            // 
            // saveSettingButton
            // 
            this.saveSettingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveSettingButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveSettingButton.Location = new System.Drawing.Point(155, 160);
            this.saveSettingButton.Name = "saveSettingButton";
            this.saveSettingButton.Size = new System.Drawing.Size(75, 23);
            this.saveSettingButton.TabIndex = 2;
            this.saveSettingButton.Text = "Сохранить";
            this.saveSettingButton.UseVisualStyleBackColor = true;
            this.saveSettingButton.Click += new System.EventHandler(this.SaveSettingButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 212);
            this.ControlBox = false;
            this.Controls.Add(this.saveSettingButton);
            this.Controls.Add(this.dateNameFolderCheckBox);
            this.Name = "SettingsForm";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox dateNameFolderCheckBox;
        private System.Windows.Forms.Button saveSettingButton;
    }
}