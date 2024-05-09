namespace AS2324._3G.Prof.PCTODB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvDati = new DataGridView();
            btnConnectionDB = new Button();
            btnElencoPiloti = new Button();
            btnElencoSquadre = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDati).BeginInit();
            SuspendLayout();
            // 
            // dgvDati
            // 
            dgvDati.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDati.Location = new Point(15, 217);
            dgvDati.Name = "dgvDati";
            dgvDati.RowHeadersWidth = 51;
            dgvDati.Size = new Size(834, 309);
            dgvDati.TabIndex = 0;
            // 
            // btnConnectionDB
            // 
            btnConnectionDB.Location = new Point(252, 12);
            btnConnectionDB.Name = "btnConnectionDB";
            btnConnectionDB.Size = new Size(329, 39);
            btnConnectionDB.TabIndex = 1;
            btnConnectionDB.Text = "Connessione al DB";
            btnConnectionDB.UseVisualStyleBackColor = true;
            // 
            // btnElencoPiloti
            // 
            btnElencoPiloti.Location = new Point(162, 135);
            btnElencoPiloti.Name = "btnElencoPiloti";
            btnElencoPiloti.Size = new Size(171, 41);
            btnElencoPiloti.TabIndex = 2;
            btnElencoPiloti.Text = "Elenco piloti";
            btnElencoPiloti.UseVisualStyleBackColor = true;
            // 
            // btnElencoSquadre
            // 
            btnElencoSquadre.Location = new Point(531, 135);
            btnElencoSquadre.Name = "btnElencoSquadre";
            btnElencoSquadre.Size = new Size(171, 41);
            btnElencoSquadre.TabIndex = 2;
            btnElencoSquadre.Text = "Elenco squadre";
            btnElencoSquadre.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 536);
            Controls.Add(btnElencoSquadre);
            Controls.Add(btnElencoPiloti);
            Controls.Add(btnConnectionDB);
            Controls.Add(dgvDati);
            Name = "Form1";
            Text = "Prof;02/05/2024;3G;PCTO DB test uso DB da c#";
            ((System.ComponentModel.ISupportInitialize)dgvDati).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDati;
        private Button btnConnectionDB;
        private Button btnElencoPiloti;
        private Button btnElencoSquadre;
    }
}
