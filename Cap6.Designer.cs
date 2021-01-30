
namespace Cap6_7
{
    partial class Cap6
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.groupGeneral = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_promedio = new System.Windows.Forms.TextBox();
            this.txt_maxima = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_minima = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.txt_salones = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupGeneral.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btn_nuevo);
            this.groupBox2.Controls.Add(this.groupGeneral);
            this.groupBox2.Controls.Add(this.btn_salir);
            this.groupBox2.Location = new System.Drawing.Point(36, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 359);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Base de Datos";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(58, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 131);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notas";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Window;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(19, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(332, 94);
            this.listBox1.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.listBox2);
            this.groupBox3.Location = new System.Drawing.Point(20, 166);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(209, 133);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Promedios";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(17, 22);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(175, 94);
            this.listBox2.TabIndex = 14;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_nuevo.Location = new System.Drawing.Point(58, 315);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(116, 27);
            this.btn_nuevo.TabIndex = 10;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // groupGeneral
            // 
            this.groupGeneral.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupGeneral.Controls.Add(this.label2);
            this.groupGeneral.Controls.Add(this.txt_promedio);
            this.groupGeneral.Controls.Add(this.txt_maxima);
            this.groupGeneral.Controls.Add(this.label5);
            this.groupGeneral.Controls.Add(this.txt_minima);
            this.groupGeneral.Controls.Add(this.label4);
            this.groupGeneral.Location = new System.Drawing.Point(249, 166);
            this.groupGeneral.Name = "groupGeneral";
            this.groupGeneral.Size = new System.Drawing.Size(220, 133);
            this.groupGeneral.TabIndex = 14;
            this.groupGeneral.TabStop = false;
            this.groupGeneral.Text = "General";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nota Maxima";
            // 
            // txt_promedio
            // 
            this.txt_promedio.BackColor = System.Drawing.SystemColors.Window;
            this.txt_promedio.Location = new System.Drawing.Point(116, 96);
            this.txt_promedio.Name = "txt_promedio";
            this.txt_promedio.Size = new System.Drawing.Size(92, 23);
            this.txt_promedio.TabIndex = 11;
            // 
            // txt_maxima
            // 
            this.txt_maxima.BackColor = System.Drawing.SystemColors.Window;
            this.txt_maxima.Location = new System.Drawing.Point(116, 28);
            this.txt_maxima.Name = "txt_maxima";
            this.txt_maxima.Size = new System.Drawing.Size(92, 23);
            this.txt_maxima.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Promedio general";
            // 
            // txt_minima
            // 
            this.txt_minima.BackColor = System.Drawing.SystemColors.Window;
            this.txt_minima.Location = new System.Drawing.Point(116, 63);
            this.txt_minima.Name = "txt_minima";
            this.txt_minima.Size = new System.Drawing.Size(92, 23);
            this.txt_minima.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nota Minima";
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_salir.Location = new System.Drawing.Point(301, 315);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(116, 27);
            this.btn_salir.TabIndex = 9;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // txt_salones
            // 
            this.txt_salones.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_salones.Location = new System.Drawing.Point(223, 35);
            this.txt_salones.Name = "txt_salones";
            this.txt_salones.Size = new System.Drawing.Size(108, 23);
            this.txt_salones.TabIndex = 7;
            this.txt_salones.TextChanged += new System.EventHandler(this.txt_salones_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad de Salones";
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_agregar.Location = new System.Drawing.Point(349, 32);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(116, 27);
            this.btn_agregar.TabIndex = 8;
            this.btn_agregar.Text = "Agregar Salones";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox4.Controls.Add(this.btn_agregar);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txt_salones);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(569, 468);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos";
            // 
            // Cap6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(567, 468);
            this.Controls.Add(this.groupBox4);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Cap6";
            this.Text = "Capitulo #6";
            this.Load += new System.EventHandler(this.Cap6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupGeneral.ResumeLayout(false);
            this.groupGeneral.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_salones;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.GroupBox groupGeneral;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_promedio;
        private System.Windows.Forms.TextBox txt_maxima;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_minima;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_salir;
    }
}