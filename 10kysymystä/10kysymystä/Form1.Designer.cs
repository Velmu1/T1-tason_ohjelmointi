
namespace _10kysymystä
{
    partial class Form
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
            this.KysymysLB = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VastausBRB = new System.Windows.Forms.RadioButton();
            this.VastausARB = new System.Windows.Forms.RadioButton();
            this.DummyRB = new System.Windows.Forms.RadioButton();
            this.VastausCRB = new System.Windows.Forms.RadioButton();
            this.VastausDRB = new System.Windows.Forms.RadioButton();
            this.VastausLB = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // KysymysLB
            // 
            this.KysymysLB.AutoSize = true;
            this.KysymysLB.Location = new System.Drawing.Point(74, 65);
            this.KysymysLB.Name = "KysymysLB";
            this.KysymysLB.Size = new System.Drawing.Size(128, 15);
            this.KysymysLB.TabIndex = 0;
            this.KysymysLB.Text = "Vastaus 1.kysymykseen";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VastausDRB);
            this.groupBox1.Controls.Add(this.VastausCRB);
            this.groupBox1.Controls.Add(this.VastausBRB);
            this.groupBox1.Controls.Add(this.VastausARB);
            this.groupBox1.Controls.Add(this.DummyRB);
            this.groupBox1.Location = new System.Drawing.Point(251, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 186);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // VastausBRB
            // 
            this.VastausBRB.AutoSize = true;
            this.VastausBRB.Location = new System.Drawing.Point(7, 49);
            this.VastausBRB.Name = "VastausBRB";
            this.VastausBRB.Size = new System.Drawing.Size(32, 19);
            this.VastausBRB.TabIndex = 2;
            this.VastausBRB.TabStop = true;
            this.VastausBRB.Text = "B";
            this.VastausBRB.UseVisualStyleBackColor = true;
            // 
            // VastausARB
            // 
            this.VastausARB.AutoSize = true;
            this.VastausARB.Location = new System.Drawing.Point(7, 23);
            this.VastausARB.Name = "VastausARB";
            this.VastausARB.Size = new System.Drawing.Size(33, 19);
            this.VastausARB.TabIndex = 1;
            this.VastausARB.TabStop = true;
            this.VastausARB.Text = "A";
            this.VastausARB.UseVisualStyleBackColor = true;
            // 
            // DummyRB
            // 
            this.DummyRB.AutoCheck = false;
            this.DummyRB.AutoSize = true;
            this.DummyRB.Location = new System.Drawing.Point(7, 23);
            this.DummyRB.Name = "DummyRB";
            this.DummyRB.Size = new System.Drawing.Size(31, 19);
            this.DummyRB.TabIndex = 0;
            this.DummyRB.TabStop = true;
            this.DummyRB.Text = "E";
            this.DummyRB.UseVisualStyleBackColor = true;
            this.DummyRB.Visible = false;
            // 
            // VastausCRB
            // 
            this.VastausCRB.AutoSize = true;
            this.VastausCRB.Location = new System.Drawing.Point(7, 75);
            this.VastausCRB.Name = "VastausCRB";
            this.VastausCRB.Size = new System.Drawing.Size(33, 19);
            this.VastausCRB.TabIndex = 3;
            this.VastausCRB.TabStop = true;
            this.VastausCRB.Text = "C";
            this.VastausCRB.UseVisualStyleBackColor = true;
            // 
            // VastausDRB
            // 
            this.VastausDRB.AutoSize = true;
            this.VastausDRB.Location = new System.Drawing.Point(7, 101);
            this.VastausDRB.Name = "VastausDRB";
            this.VastausDRB.Size = new System.Drawing.Size(33, 19);
            this.VastausDRB.TabIndex = 4;
            this.VastausDRB.TabStop = true;
            this.VastausDRB.Text = "D";
            this.VastausDRB.UseVisualStyleBackColor = true;
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(74, 213);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(46, 15);
            this.VastausLB.TabIndex = 2;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 272);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.KysymysLB);
            this.Name = "Form";
            this.Text = "Vastauslomake";
            this.Load += new System.EventHandler(this.Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KysymysLB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton DummyRB;
        private System.Windows.Forms.RadioButton VastausBRB;
        private System.Windows.Forms.RadioButton VastausARB;
        private System.Windows.Forms.RadioButton VastausDRB;
        private System.Windows.Forms.RadioButton VastausCRB;
        private System.Windows.Forms.Label VastausLB;
    }
}

