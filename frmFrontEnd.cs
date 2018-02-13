/* Title    : FrmFrontEnd.cs
 * Author   : Simone Spagna
 * Purpose  : This is a frontend used to test how the RC4 alghoritm works
 * */

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace CryptoRC4
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmFrontEnd : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox txtInput;
		private System.Windows.Forms.TextBox txtOutput;
		private System.Windows.Forms.Button cmdEncrypt;
		private System.Windows.Forms.Button cmdDecrypt;
		private System.Windows.Forms.Label lblInputBox;
		private System.Windows.Forms.Label lblOutputBox;
		private System.Windows.Forms.Label lblKey;
		private System.Windows.Forms.Label lblwarningout;
		private System.Windows.Forms.Label lblmaxin;
        private TextBox txtEncryption;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

		public frmFrontEnd()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.cmdEncrypt = new System.Windows.Forms.Button();
            this.cmdDecrypt = new System.Windows.Forms.Button();
            this.lblInputBox = new System.Windows.Forms.Label();
            this.lblOutputBox = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblwarningout = new System.Windows.Forms.Label();
            this.lblmaxin = new System.Windows.Forms.Label();
            this.txtEncryption = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(10, 74);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(259, 258);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(442, 74);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(259, 258);
            this.txtOutput.TabIndex = 1;
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // cmdEncrypt
            // 
            this.cmdEncrypt.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEncrypt.Location = new System.Drawing.Point(278, 148);
            this.cmdEncrypt.Name = "cmdEncrypt";
            this.cmdEncrypt.Size = new System.Drawing.Size(154, 37);
            this.cmdEncrypt.TabIndex = 2;
            this.cmdEncrypt.Text = "=> EnCrypt =>";
            this.cmdEncrypt.Click += new System.EventHandler(this.cmdEncrypt_Click);
            // 
            // cmdDecrypt
            // 
            this.cmdDecrypt.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDecrypt.Location = new System.Drawing.Point(278, 222);
            this.cmdDecrypt.Name = "cmdDecrypt";
            this.cmdDecrypt.Size = new System.Drawing.Size(154, 36);
            this.cmdDecrypt.TabIndex = 3;
            this.cmdDecrypt.Text = "<= DeCrypt <=";
            this.cmdDecrypt.Click += new System.EventHandler(this.cmdDecrypt_Click);
            // 
            // lblInputBox
            // 
            this.lblInputBox.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputBox.Location = new System.Drawing.Point(10, 9);
            this.lblInputBox.Name = "lblInputBox";
            this.lblInputBox.Size = new System.Drawing.Size(259, 28);
            this.lblInputBox.TabIndex = 4;
            this.lblInputBox.Text = "In Clear Text Box";
            // 
            // lblOutputBox
            // 
            this.lblOutputBox.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputBox.Location = new System.Drawing.Point(442, 9);
            this.lblOutputBox.Name = "lblOutputBox";
            this.lblOutputBox.Size = new System.Drawing.Size(259, 28);
            this.lblOutputBox.TabIndex = 5;
            this.lblOutputBox.Text = "Crypted Text Box";
            // 
            // lblKey
            // 
            this.lblKey.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKey.Location = new System.Drawing.Point(10, 351);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(163, 27);
            this.lblKey.TabIndex = 6;
            this.lblKey.Text = "Encryption Key :";
            // 
            // lblwarningout
            // 
            this.lblwarningout.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwarningout.Location = new System.Drawing.Point(442, 37);
            this.lblwarningout.Name = "lblwarningout";
            this.lblwarningout.Size = new System.Drawing.Size(259, 28);
            this.lblwarningout.TabIndex = 8;
            this.lblwarningout.Text = "Some char may not be displayed";
            // 
            // lblmaxin
            // 
            this.lblmaxin.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmaxin.Location = new System.Drawing.Point(10, 37);
            this.lblmaxin.Name = "lblmaxin";
            this.lblmaxin.Size = new System.Drawing.Size(182, 28);
            this.lblmaxin.TabIndex = 10;
            // 
            // txtEncryption
            // 
            this.txtEncryption.Location = new System.Drawing.Point(182, 351);
            this.txtEncryption.Name = "txtEncryption";
            this.txtEncryption.Size = new System.Drawing.Size(509, 22);
            this.txtEncryption.TabIndex = 7;
            this.txtEncryption.Text = "ab48495fdjk4950dj39405fk";
            this.txtEncryption.LostFocus += new System.EventHandler(this.txtEncryption_LostFocus);
            // 
            // frmFrontEnd
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(719, 421);
            this.Controls.Add(this.lblmaxin);
            this.Controls.Add(this.lblwarningout);
            this.Controls.Add(this.txtEncryption);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.lblOutputBox);
            this.Controls.Add(this.lblInputBox);
            this.Controls.Add(this.cmdDecrypt);
            this.Controls.Add(this.cmdEncrypt);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Name = "frmFrontEnd";
            this.Text = "RC4 Demo Frontend";
            this.Load += new System.EventHandler(this.frmFrontEnd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmFrontEnd());
		}

		#region User control functions

		private void frmFrontEnd_Load(object sender, System.EventArgs e)
		{
			//
			// disable command buttons
			//
			this.cmdDecrypt.Visible = false;
			this.cmdEncrypt.Visible = false;
			//
			// Initialize the label that says how many characters can be entered
			// in input text box
			//
			this.lblmaxin.Text = "Max " + this.txtInput.MaxLength + " Chars"; 
		}

		private void txtEncryption_LostFocus(object sender, System.EventArgs e)
		{
			//
			// check if key is null
			//
			if ( this.txtEncryption.Text.ToString() == "" )
			{
				//
				// key is null - display error message
				//
				MessageBox.Show ("The Encryption key must not be NULL!","Error");
			}
		}


		private void txtInput_TextChanged(object sender, System.EventArgs e)
		{
			//
			// Check if entered input text is not null
			//
			if ( this.txtInput.Text.ToString() != "" ) 
			{
				//
				// Enable Encrypt command button if it is not enabled yet
				//
				if ( !this.cmdEncrypt.Visible )
				{
					this.cmdEncrypt.Visible = true;
				}
			}
			else
			{
				//
				// Disable Encrypt command button it is not disabled yet
				//
				if ( this.cmdEncrypt.Visible )
				{
					this.cmdEncrypt.Visible = false;
				}
			}
		}

		private void txtOutput_TextChanged(object sender, System.EventArgs e)
		{
			//
			// Check if entered input text is not null
			//
			if ( this.txtOutput.Text.ToString() != "" )
			{
				//
				// Enable Encryp command button if it is not enabled yet
				//
				if ( !this.cmdDecrypt.Visible )
				{
					this.cmdDecrypt.Visible = true;
				}

				this.m_sCrypSave = this.txtOutput.Text;
			}
			else
			{
				//
				// Disable dencryp command button if it is not disabled yet
				//
				if ( this.cmdDecrypt.Visible )
				{
					this.cmdDecrypt.Visible = false;
				}
			}
		}

		private void cmdEncrypt_Click(object sender, System.EventArgs e)
		{
			if ( this.txtOutput.Text.ToString() != "" )
			{
				//
				// Advise customer that Output Box will be clear
				//
				MessageBox.Show ("The Crypted Text box is going to be clear!","Warning message");
				this.txtOutput.Text = "";
			}
			
			//
			// Call Engine
			//
			RC4Engine myRC4Engine		= new RC4Engine();
			myRC4Engine.EncryptionKey	= this.txtEncryption.Text;
			myRC4Engine.InClearText		= this.txtInput.Text;
			myRC4Engine.Encrypt();
			//
			// Save also to string the result because some char could
			// be lost into textbox
			//
			this.m_sCrypSave			= myRC4Engine.CryptedText;
			this.txtOutput.Text			= this.m_sCrypSave;
		}

		private void cmdDecrypt_Click(object sender, System.EventArgs e)
		{
			if ( this.txtInput.Text.ToString() != "" )
			{
				//
				// Advise customer that Input Box will be clear
				//
				MessageBox.Show ("The InClear Text box is going to be clear!","Warning message");
				this.txtInput.Text = "";
			}

			//
			// Call Engine
			//
			RC4Engine myRC4Engine		= new RC4Engine();
			myRC4Engine.EncryptionKey	= this.txtEncryption.Text;
			myRC4Engine.CryptedText		= this.m_sCrypSave;
			myRC4Engine.Decrypt();
			this.txtInput.Text			= myRC4Engine.InClearText;
		}
		#endregion

		#region User Private Field
		//
		// Used to store Crypted Text
		//
		private string m_sCrypSave = "";
		#endregion

	}
}
