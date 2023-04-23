
namespace MediaTekDocuments.view
{
    partial class FrmAuthentification
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbAuthentificationUser = new System.Windows.Forms.TextBox();
            this.txbAuthentificationMdp = new System.Windows.Forms.TextBox();
            this.btnAuthentificationConnexion = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 145);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(92, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Authentification";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(71, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(71, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Utilisateur :";
            // 
            // txbAuthentificationUser
            // 
            this.txbAuthentificationUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAuthentificationUser.Location = new System.Drawing.Point(78, 245);
            this.txbAuthentificationUser.Name = "txbAuthentificationUser";
            this.txbAuthentificationUser.Size = new System.Drawing.Size(302, 34);
            this.txbAuthentificationUser.TabIndex = 4;
            // 
            // txbAuthentificationMdp
            // 
            this.txbAuthentificationMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAuthentificationMdp.Location = new System.Drawing.Point(78, 377);
            this.txbAuthentificationMdp.Name = "txbAuthentificationMdp";
            this.txbAuthentificationMdp.Size = new System.Drawing.Size(302, 34);
            this.txbAuthentificationMdp.TabIndex = 5;
            // 
            // btnAuthentificationConnexion
            // 
            this.btnAuthentificationConnexion.BackColor = System.Drawing.Color.Salmon;
            this.btnAuthentificationConnexion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAuthentificationConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuthentificationConnexion.ForeColor = System.Drawing.Color.White;
            this.btnAuthentificationConnexion.Location = new System.Drawing.Point(78, 442);
            this.btnAuthentificationConnexion.Name = "btnAuthentificationConnexion";
            this.btnAuthentificationConnexion.Size = new System.Drawing.Size(302, 66);
            this.btnAuthentificationConnexion.TabIndex = 6;
            this.btnAuthentificationConnexion.Text = "Connexion";
            this.btnAuthentificationConnexion.UseVisualStyleBackColor = false;
            this.btnAuthentificationConnexion.Click += new System.EventHandler(this.btnAuthentificationConnexion_Click);
            // 
            // FrmAuthentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(499, 649);
            this.Controls.Add(this.btnAuthentificationConnexion);
            this.Controls.Add(this.txbAuthentificationMdp);
            this.Controls.Add(this.txbAuthentificationUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAuthentification";
            this.Text = "Authentification";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbAuthentificationUser;
        private System.Windows.Forms.TextBox txbAuthentificationMdp;
        private System.Windows.Forms.Button btnAuthentificationConnexion;
    }
}