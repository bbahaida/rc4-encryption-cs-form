using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoRC4
{
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        CryptoRC4Engine CryptoRC4Engine;
        public frmMain()
        {
            CryptoRC4Engine = new CryptoRC4Engine();
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.ActiveControl = encryptionKeyTextBox;
            encryptBtn.Visible = false;
            decryptBtn.Visible = false;
        }
        private void encryptionKeyTextChanged(object sender, EventArgs e)
        {
            if (plainTextBox.Text != "" && encryptionKeyTextBox.Text != "")
            {
                encryptBtn.Visible = true;
            }
            else
            {
                encryptBtn.Visible = false;
            }

            if(cipherTextBox.Text != "" && encryptionKeyTextBox.Text != "")
            {
                decryptBtn.Visible = true;
            }
            else
            {
                
                decryptBtn.Visible = false;
            }
        }


        private void plainTextChanged(object sender, EventArgs e)
        {
            if (plainTextBox.Text != "" && encryptionKeyTextBox.Text != "")
            {
                encryptBtn.Visible = true;
            }
            else
            {
                encryptBtn.Visible = false;
            }
        }

        private void cipherTextChanged(object sender, EventArgs e)
        {
            if (cipherTextBox.Text != "" && encryptionKeyTextBox.Text != "")
            {
                decryptBtn.Visible = true;
            }
            else
            {
                decryptBtn.Visible = false;
            }
        }


        private void encryptBtn_Click(object sender, EventArgs e)
        {
            if (plainTextBox.Text != "" && encryptionKeyTextBox.Text != "")
            {
                CryptoRC4Engine.ClearText = plainTextBox.Text;
                CryptoRC4Engine.EncryptionKey = encryptionKeyTextBox.Text;
                bool toRet = CryptoRC4Engine.Encrypt();
                if (toRet)
                {
                    if (cipherTextBox.Text != "")
                    {
                        if (MetroFramework.MetroMessageBox.Show(this, "La zone de texte chiffré va être remplacée", "Texte chiffré existe", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            cipherTextBox.Text = CryptoRC4Engine.CryptedText;
                        }

                    }
                    else
                    {
                        cipherTextBox.Text = CryptoRC4Engine.CryptedText;
                    }
                    
                }
                
            }
        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            CryptoRC4Engine.CryptedText = cipherTextBox.Text;
            CryptoRC4Engine.EncryptionKey = encryptionKeyTextBox.Text;
            bool toRet = CryptoRC4Engine.Decrypt();
            if (toRet)
            {
                if (plainTextBox.Text != "")
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "La zone de texte à chiffrer va être remplacée", "Texte existe", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        plainTextBox.Text = CryptoRC4Engine.ClearText;
                    }

                }
                else
                {
                    plainTextBox.Text = CryptoRC4Engine.ClearText;
                }

            }

        }
    }
}
