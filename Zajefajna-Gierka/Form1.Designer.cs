namespace Zajefajna_Gierka
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtHaslo = new System.Windows.Forms.TextBox();
            this.BtnZaloguj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogin.Font = new System.Drawing.Font("MS PGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLogin.ForeColor = System.Drawing.SystemColors.Window;
            this.txtLogin.Location = new System.Drawing.Point(545, 144);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(121, 11);
            this.txtLogin.TabIndex = 0;
            // 
            // txtHaslo
            // 
            this.txtHaslo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHaslo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHaslo.Font = new System.Drawing.Font("MS PGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtHaslo.ForeColor = System.Drawing.SystemColors.Window;
            this.txtHaslo.Location = new System.Drawing.Point(545, 172);
            this.txtHaslo.MaximumSize = new System.Drawing.Size(121, 11);
            this.txtHaslo.MinimumSize = new System.Drawing.Size(121, 11);
            this.txtHaslo.Name = "txtHaslo";
            this.txtHaslo.PasswordChar = '*';
            this.txtHaslo.Size = new System.Drawing.Size(121, 11);
            this.txtHaslo.TabIndex = 1;
            // 
            // BtnZaloguj
            // 
            this.BtnZaloguj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnZaloguj.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnZaloguj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnZaloguj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnZaloguj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnZaloguj.Font = new System.Drawing.Font("MS PGothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnZaloguj.ForeColor = System.Drawing.Color.White;
            this.BtnZaloguj.Location = new System.Drawing.Point(545, 241);
            this.BtnZaloguj.Name = "BtnZaloguj";
            this.BtnZaloguj.Size = new System.Drawing.Size(121, 23);
            this.BtnZaloguj.TabIndex = 2;
            this.BtnZaloguj.Text = "Login";
            this.BtnZaloguj.UseVisualStyleBackColor = false;
            this.BtnZaloguj.Click += new System.EventHandler(this.BtnZaloguj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1016, 551);
            this.Controls.Add(this.BtnZaloguj);
            this.Controls.Add(this.txtHaslo);
            this.Controls.Add(this.txtLogin);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1032, 590);
            this.MinimumSize = new System.Drawing.Size(1032, 590);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtHaslo;
        private System.Windows.Forms.Button BtnZaloguj;
    }
}

