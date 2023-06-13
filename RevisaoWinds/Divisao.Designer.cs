namespace RevisaoWinds
{
    partial class Divisao
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
            this.txV2 = new System.Windows.Forms.TextBox();
            this.txV1 = new System.Windows.Forms.TextBox();
            this.btCal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txV2
            // 
            this.txV2.Location = new System.Drawing.Point(241, 70);
            this.txV2.Name = "txV2";
            this.txV2.Size = new System.Drawing.Size(100, 20);
            this.txV2.TabIndex = 0;
            this.txV2.TextChanged += new System.EventHandler(this.txV2_TextChanged);
            // 
            // txV1
            // 
            this.txV1.Location = new System.Drawing.Point(52, 70);
            this.txV1.Name = "txV1";
            this.txV1.Size = new System.Drawing.Size(100, 20);
            this.txV1.TabIndex = 1;
            this.txV1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btCal
            // 
            this.btCal.Location = new System.Drawing.Point(159, 252);
            this.btCal.Name = "btCal";
            this.btCal.Size = new System.Drawing.Size(100, 46);
            this.btCal.TabIndex = 2;
            this.btCal.Text = "Calcular";
            this.btCal.UseVisualStyleBackColor = true;
            this.btCal.Click += new System.EventHandler(this.btCal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "lb_resultado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Divisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 348);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCal);
            this.Controls.Add(this.txV1);
            this.Controls.Add(this.txV2);
            this.Name = "Divisao";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txV2;
        private System.Windows.Forms.TextBox txV1;
        private System.Windows.Forms.Button btCal;
        private System.Windows.Forms.Label label1;
    }
}