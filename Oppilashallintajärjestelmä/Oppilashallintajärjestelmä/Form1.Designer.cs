
namespace Oppilashallintajärjestelmä
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IdTB = new System.Windows.Forms.TextBox();
            this.EnimiTB = new System.Windows.Forms.TextBox();
            this.SnimiTB = new System.Windows.Forms.TextBox();
            this.ONroTB = new System.Windows.Forms.TextBox();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.PuhTB = new System.Windows.Forms.TextBox();
            this.PoistaBT = new System.Windows.Forms.Button();
            this.PaivitaBT = new System.Windows.Forms.Button();
            this.TyhjennaBT = new System.Windows.Forms.Button();
            this.TallennaBT = new System.Windows.Forms.Button();
            this.TietotauluDG = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TietotauluDG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "ETUNIMI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "SUKUNIMI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(414, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "OPISKELIJANRO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(414, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "SÄHKÖPOSTI:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(414, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 29);
            this.label6.TabIndex = 3;
            this.label6.Text = "PUHELIN:";
            // 
            // IdTB
            // 
            this.IdTB.Location = new System.Drawing.Point(162, 42);
            this.IdTB.Name = "IdTB";
            this.IdTB.Size = new System.Drawing.Size(221, 29);
            this.IdTB.TabIndex = 6;
            // 
            // EnimiTB
            // 
            this.EnimiTB.Location = new System.Drawing.Point(162, 90);
            this.EnimiTB.Name = "EnimiTB";
            this.EnimiTB.Size = new System.Drawing.Size(221, 29);
            this.EnimiTB.TabIndex = 7;
            // 
            // SnimiTB
            // 
            this.SnimiTB.Location = new System.Drawing.Point(162, 136);
            this.SnimiTB.Name = "SnimiTB";
            this.SnimiTB.Size = new System.Drawing.Size(221, 29);
            this.SnimiTB.TabIndex = 8;
            // 
            // ONroTB
            // 
            this.ONroTB.Location = new System.Drawing.Point(639, 137);
            this.ONroTB.Name = "ONroTB";
            this.ONroTB.Size = new System.Drawing.Size(221, 29);
            this.ONroTB.TabIndex = 11;
            // 
            // EmailTB
            // 
            this.EmailTB.Location = new System.Drawing.Point(639, 91);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(221, 29);
            this.EmailTB.TabIndex = 10;
            // 
            // PuhTB
            // 
            this.PuhTB.Location = new System.Drawing.Point(639, 43);
            this.PuhTB.Name = "PuhTB";
            this.PuhTB.Size = new System.Drawing.Size(221, 29);
            this.PuhTB.TabIndex = 9;
            // 
            // PoistaBT
            // 
            this.PoistaBT.Location = new System.Drawing.Point(620, 182);
            this.PoistaBT.Name = "PoistaBT";
            this.PoistaBT.Size = new System.Drawing.Size(167, 53);
            this.PoistaBT.TabIndex = 15;
            this.PoistaBT.Text = "POISTA";
            this.PoistaBT.UseVisualStyleBackColor = true;
            this.PoistaBT.Click += new System.EventHandler(this.PoistaBT_Click);
            // 
            // PaivitaBT
            // 
            this.PaivitaBT.Location = new System.Drawing.Point(419, 182);
            this.PaivitaBT.Name = "PaivitaBT";
            this.PaivitaBT.Size = new System.Drawing.Size(167, 53);
            this.PaivitaBT.TabIndex = 16;
            this.PaivitaBT.Text = "PÄIVITÄ";
            this.PaivitaBT.UseVisualStyleBackColor = true;
            this.PaivitaBT.Click += new System.EventHandler(this.PaivitaBT_Click);
            // 
            // TyhjennaBT
            // 
            this.TyhjennaBT.Location = new System.Drawing.Point(17, 182);
            this.TyhjennaBT.Name = "TyhjennaBT";
            this.TyhjennaBT.Size = new System.Drawing.Size(167, 53);
            this.TyhjennaBT.TabIndex = 17;
            this.TyhjennaBT.Text = "TYHJENNÄ";
            this.TyhjennaBT.UseVisualStyleBackColor = true;
            // 
            // TallennaBT
            // 
            this.TallennaBT.Location = new System.Drawing.Point(216, 182);
            this.TallennaBT.Name = "TallennaBT";
            this.TallennaBT.Size = new System.Drawing.Size(167, 53);
            this.TallennaBT.TabIndex = 18;
            this.TallennaBT.Text = "TALLENNA";
            this.TallennaBT.UseVisualStyleBackColor = true;
            this.TallennaBT.Click += new System.EventHandler(this.TallennaBT_Click);
            // 
            // TietotauluDG
            // 
            this.TietotauluDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TietotauluDG.Location = new System.Drawing.Point(12, 242);
            this.TietotauluDG.Name = "TietotauluDG";
            this.TietotauluDG.Size = new System.Drawing.Size(1249, 373);
            this.TietotauluDG.TabIndex = 19;
            this.TietotauluDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TietotauluDG_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 627);
            this.Controls.Add(this.TietotauluDG);
            this.Controls.Add(this.TallennaBT);
            this.Controls.Add(this.TyhjennaBT);
            this.Controls.Add(this.PaivitaBT);
            this.Controls.Add(this.PoistaBT);
            this.Controls.Add(this.ONroTB);
            this.Controls.Add(this.EmailTB);
            this.Controls.Add(this.PuhTB);
            this.Controls.Add(this.SnimiTB);
            this.Controls.Add(this.EnimiTB);
            this.Controls.Add(this.IdTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TietotauluDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IdTB;
        private System.Windows.Forms.TextBox EnimiTB;
        private System.Windows.Forms.TextBox SnimiTB;
        private System.Windows.Forms.TextBox ONroTB;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.TextBox PuhTB;
        private System.Windows.Forms.Button PoistaBT;
        private System.Windows.Forms.Button PaivitaBT;
        private System.Windows.Forms.Button TyhjennaBT;
        private System.Windows.Forms.Button TallennaBT;
        private System.Windows.Forms.DataGridView TietotauluDG;
    }
}

