namespace CryptoRC4
{
    partial class frmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.plainTextBox = new MetroFramework.Controls.MetroTextBox();
            this.cipherTextBox = new MetroFramework.Controls.MetroTextBox();
            this.encryptionKeyTextBox = new MetroFramework.Controls.MetroTextBox();
            this.plainTextLabel = new MetroFramework.Controls.MetroLabel();
            this.cipherLabel = new MetroFramework.Controls.MetroLabel();
            this.encryptionKeyLabel = new MetroFramework.Controls.MetroLabel();
            this.decryptBtn = new MetroFramework.Controls.MetroTile();
            this.encryptBtn = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // plainTextBox
            // 
            // 
            // 
            // 
            this.plainTextBox.CustomButton.Image = null;
            this.plainTextBox.CustomButton.Location = new System.Drawing.Point(73, 2);
            this.plainTextBox.CustomButton.Name = "";
            this.plainTextBox.CustomButton.Size = new System.Drawing.Size(307, 307);
            this.plainTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.plainTextBox.CustomButton.TabIndex = 1;
            this.plainTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.plainTextBox.CustomButton.UseSelectable = true;
            this.plainTextBox.CustomButton.Visible = false;
            this.plainTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.plainTextBox.Lines = new string[0];
            this.plainTextBox.Location = new System.Drawing.Point(23, 262);
            this.plainTextBox.MaxLength = 32767;
            this.plainTextBox.Multiline = true;
            this.plainTextBox.Name = "plainTextBox";
            this.plainTextBox.PasswordChar = '\0';
            this.plainTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.plainTextBox.SelectedText = "";
            this.plainTextBox.SelectionLength = 0;
            this.plainTextBox.SelectionStart = 0;
            this.plainTextBox.ShortcutsEnabled = true;
            this.plainTextBox.Size = new System.Drawing.Size(383, 312);
            this.plainTextBox.TabIndex = 0;
            this.plainTextBox.UseSelectable = true;
            this.plainTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.plainTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.plainTextBox.TextChanged += new System.EventHandler(this.plainTextChanged);
            // 
            // cipherTextBox
            // 
            // 
            // 
            // 
            this.cipherTextBox.CustomButton.Image = null;
            this.cipherTextBox.CustomButton.Location = new System.Drawing.Point(82, 2);
            this.cipherTextBox.CustomButton.Name = "";
            this.cipherTextBox.CustomButton.Size = new System.Drawing.Size(307, 307);
            this.cipherTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cipherTextBox.CustomButton.TabIndex = 1;
            this.cipherTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cipherTextBox.CustomButton.UseSelectable = true;
            this.cipherTextBox.CustomButton.Visible = false;
            this.cipherTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.cipherTextBox.Lines = new string[0];
            this.cipherTextBox.Location = new System.Drawing.Point(717, 262);
            this.cipherTextBox.MaxLength = 32767;
            this.cipherTextBox.Multiline = true;
            this.cipherTextBox.Name = "cipherTextBox";
            this.cipherTextBox.PasswordChar = '\0';
            this.cipherTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cipherTextBox.SelectedText = "";
            this.cipherTextBox.SelectionLength = 0;
            this.cipherTextBox.SelectionStart = 0;
            this.cipherTextBox.ShortcutsEnabled = true;
            this.cipherTextBox.Size = new System.Drawing.Size(392, 312);
            this.cipherTextBox.TabIndex = 1;
            this.cipherTextBox.UseSelectable = true;
            this.cipherTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cipherTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.cipherTextBox.TextChanged += new System.EventHandler(this.cipherTextChanged);

            // 
            // encryptionKeyTextBox
            // 
            // 
            // 
            // 
            this.encryptionKeyTextBox.CustomButton.Image = null;
            this.encryptionKeyTextBox.CustomButton.Location = new System.Drawing.Point(270, 1);
            this.encryptionKeyTextBox.CustomButton.Name = "";
            this.encryptionKeyTextBox.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.encryptionKeyTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.encryptionKeyTextBox.CustomButton.TabIndex = 1;
            this.encryptionKeyTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.encryptionKeyTextBox.CustomButton.UseSelectable = true;
            this.encryptionKeyTextBox.CustomButton.Visible = false;
            this.encryptionKeyTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.encryptionKeyTextBox.Lines = new string[0];
            this.encryptionKeyTextBox.Location = new System.Drawing.Point(286, 94);
            this.encryptionKeyTextBox.MaxLength = 32767;
            this.encryptionKeyTextBox.Name = "encryptionKeyTextBox";
            this.encryptionKeyTextBox.PasswordChar = '\0';
            this.encryptionKeyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.encryptionKeyTextBox.SelectedText = "";
            this.encryptionKeyTextBox.SelectionLength = 0;
            this.encryptionKeyTextBox.SelectionStart = 0;
            this.encryptionKeyTextBox.ShortcutsEnabled = true;
            this.encryptionKeyTextBox.Size = new System.Drawing.Size(302, 33);
            this.encryptionKeyTextBox.TabIndex = 4;
            this.encryptionKeyTextBox.UseSelectable = true;
            this.encryptionKeyTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.encryptionKeyTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.encryptionKeyTextBox.TextChanged += new System.EventHandler(this.encryptionKeyTextChanged);
            // 
            // plainTextLabel
            // 
            this.plainTextLabel.AutoSize = true;
            this.plainTextLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.plainTextLabel.Location = new System.Drawing.Point(23, 212);
            this.plainTextLabel.Name = "plainTextLabel";
            this.plainTextLabel.Size = new System.Drawing.Size(133, 20);
            this.plainTextLabel.TabIndex = 5;
            this.plainTextLabel.Text = "Le texte à chiffrer";
            // 
            // cipherLabel
            // 
            this.cipherLabel.AutoSize = true;
            this.cipherLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.cipherLabel.Location = new System.Drawing.Point(717, 212);
            this.cipherLabel.Name = "cipherLabel";
            this.cipherLabel.Size = new System.Drawing.Size(115, 20);
            this.cipherLabel.TabIndex = 6;
            this.cipherLabel.Text = "Le texte chiffré";
            // 
            // encryptionKeyLabel
            // 
            this.encryptionKeyLabel.AutoSize = true;
            this.encryptionKeyLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.encryptionKeyLabel.Location = new System.Drawing.Point(23, 104);
            this.encryptionKeyLabel.Name = "encryptionKeyLabel";
            this.encryptionKeyLabel.Size = new System.Drawing.Size(193, 20);
            this.encryptionKeyLabel.TabIndex = 7;
            this.encryptionKeyLabel.Text = "Saisir la clé de chiffrement";
            // 
            // decryptBtn
            // 
            this.decryptBtn.ActiveControl = null;
            this.decryptBtn.Location = new System.Drawing.Point(467, 444);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(205, 64);
            this.decryptBtn.TabIndex = 3;
            this.decryptBtn.Text = "Déchiffrer";
            this.decryptBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.decryptBtn.TileImage = global::CryptoRC4.Properties.Resources._001_unlocked;
            this.decryptBtn.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.decryptBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.decryptBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.decryptBtn.UseCustomForeColor = true;
            this.decryptBtn.UseSelectable = true;
            this.decryptBtn.UseStyleColors = true;
            this.decryptBtn.UseTileImage = true;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // encryptBtn
            // 
            this.encryptBtn.ActiveControl = null;
            this.encryptBtn.Location = new System.Drawing.Point(467, 321);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(205, 64);
            this.encryptBtn.TabIndex = 2;
            this.encryptBtn.Text = "Chiffrer";
            this.encryptBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.encryptBtn.TileImage = global::CryptoRC4.Properties.Resources._002_locked;
            this.encryptBtn.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.encryptBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.encryptBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.encryptBtn.UseCustomForeColor = true;
            this.encryptBtn.UseSelectable = true;
            this.encryptBtn.UseStyleColors = true;
            this.encryptBtn.UseTileImage = true;
            this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 638);
            this.Controls.Add(this.encryptionKeyLabel);
            this.Controls.Add(this.cipherLabel);
            this.Controls.Add(this.plainTextLabel);
            this.Controls.Add(this.encryptionKeyTextBox);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.encryptBtn);
            this.Controls.Add(this.cipherTextBox);
            this.Controls.Add(this.plainTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Resizable = false;
            this.Text = "RC4 ISI M1 SSICE";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox plainTextBox;
        private MetroFramework.Controls.MetroTextBox cipherTextBox;
        private MetroFramework.Controls.MetroTile encryptBtn;
        private MetroFramework.Controls.MetroTile decryptBtn;
        private MetroFramework.Controls.MetroTextBox encryptionKeyTextBox;
        private MetroFramework.Controls.MetroLabel plainTextLabel;
        private MetroFramework.Controls.MetroLabel cipherLabel;
        private MetroFramework.Controls.MetroLabel encryptionKeyLabel;
    }
}

