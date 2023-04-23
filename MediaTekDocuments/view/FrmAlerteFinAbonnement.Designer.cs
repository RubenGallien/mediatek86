
namespace MediaTekDocuments.view
{
    partial class FrmAlerteFinAbonnement
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
            this.lblFinAbonnements = new System.Windows.Forms.Label();
            this.dgvFinAbonnements = new System.Windows.Forms.DataGridView();
            this.btnConfirmationFinAbonnement = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinAbonnements)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFinAbonnements
            // 
            this.lblFinAbonnements.AutoSize = true;
            this.lblFinAbonnements.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinAbonnements.Location = new System.Drawing.Point(12, 18);
            this.lblFinAbonnements.Name = "lblFinAbonnements";
            this.lblFinAbonnements.Size = new System.Drawing.Size(603, 20);
            this.lblFinAbonnements.TabIndex = 0;
            this.lblFinAbonnements.Text = "Cet ou ces abonnement(s) arrive à expiration dans moins de 30 jours :";
            // 
            // dgvFinAbonnements
            // 
            this.dgvFinAbonnements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinAbonnements.Location = new System.Drawing.Point(16, 47);
            this.dgvFinAbonnements.Name = "dgvFinAbonnements";
            this.dgvFinAbonnements.RowHeadersWidth = 51;
            this.dgvFinAbonnements.RowTemplate.Height = 24;
            this.dgvFinAbonnements.Size = new System.Drawing.Size(595, 150);
            this.dgvFinAbonnements.TabIndex = 1;
            this.dgvFinAbonnements.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFinAbonnements_ColumnHeaderMouseClick);
            // 
            // btnConfirmationFinAbonnement
            // 
            this.btnConfirmationFinAbonnement.Location = new System.Drawing.Point(246, 205);
            this.btnConfirmationFinAbonnement.Name = "btnConfirmationFinAbonnement";
            this.btnConfirmationFinAbonnement.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmationFinAbonnement.TabIndex = 2;
            this.btnConfirmationFinAbonnement.Text = "OK";
            this.btnConfirmationFinAbonnement.UseVisualStyleBackColor = true;
            this.btnConfirmationFinAbonnement.Click += new System.EventHandler(this.btnConfirmationFinAbonnement_Click);
            // 
            // FrmAlerteFinAbonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 240);
            this.Controls.Add(this.btnConfirmationFinAbonnement);
            this.Controls.Add(this.dgvFinAbonnements);
            this.Controls.Add(this.lblFinAbonnements);
            this.Name = "FrmAlerteFinAbonnement";
            this.Text = "FIN ABONNEMENT(S)";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinAbonnements)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFinAbonnements;
        private System.Windows.Forms.DataGridView dgvFinAbonnements;
        private System.Windows.Forms.Button btnConfirmationFinAbonnement;
    }
}