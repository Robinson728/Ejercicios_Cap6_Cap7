
namespace Cap6_7
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
            this.Cap4 = new System.Windows.Forms.Button();
            this.Cap5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cap4
            // 
            this.Cap4.Location = new System.Drawing.Point(34, 73);
            this.Cap4.Name = "Cap4";
            this.Cap4.Size = new System.Drawing.Size(156, 52);
            this.Cap4.TabIndex = 0;
            this.Cap4.Text = "Capitulo 6";
            this.Cap4.UseVisualStyleBackColor = true;
            this.Cap4.Click += new System.EventHandler(this.Cap4_Click);
            // 
            // Cap5
            // 
            this.Cap5.Location = new System.Drawing.Point(263, 73);
            this.Cap5.Name = "Cap5";
            this.Cap5.Size = new System.Drawing.Size(156, 52);
            this.Cap5.TabIndex = 1;
            this.Cap5.Text = "Capitulo 7";
            this.Cap5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ejercicios correspondientes a los capitulos 6 y 7, Programacion Aplicada";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(461, 170);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cap5);
            this.Controls.Add(this.Cap4);
            this.Name = "Form1";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cap4;
        private System.Windows.Forms.Button Cap5;
        private System.Windows.Forms.Label label1;
    }
}

