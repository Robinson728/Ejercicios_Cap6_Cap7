using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cap6_7
{
    public partial class Cap6 : Form
    {
        public Cap6()
        {
            InitializeComponent();
        }

        private void Cap6_Load(object sender, EventArgs e)
        {

        }

        private bool Validar()
        {
            bool ok = true;

            if (txt_salones.Text == string.Empty)
            {
                ok = false;
                errorProvider1.SetError(txt_salones, "Este campo no puede estar vacio");
            }
            return ok;
        }

        private void AgregarSalones()
        {
            int cantidad = 0, salones = 0, totalestudiantes = 0;

            if(Validar() == true)
            {
                errorProvider1.Clear();
                txt_promedio.Clear();
                txt_minima.Clear();
                txt_maxima.Clear();
                salones = Convert.ToInt32(txt_salones.Text);
            }

            float[][] calif = new float[salones][];

            for (int i = 0; i < salones; i++)
            {
                cantidad = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Digite la cantidad de estudiantes de salon " + (i + 1), "Estudiantes"));
                calif[i] = new float[cantidad];
                totalestudiantes += cantidad;
            }
            AgregarCalificacion(calif, salones, totalestudiantes);
        }

        private void AgregarCalificacion(float[][] calif, int salones, int totalestudiantes)
        {
            for (int i = 0; i < salones; i++)
            {
                for (int r = 0; r < calif[i].GetLength(0); r++)
                {
                    calif[i][r] = Convert.ToSingle(Microsoft.VisualBasic.Interaction.InputBox("Digite la calificacion del estudiantes " + (r + 1) + " del salon " + (i + 1), "Calificacion"));
                }
            }
            Maximo(calif, salones, totalestudiantes);
            Minimo(calif, salones, totalestudiantes);
            Promedio(calif, salones, totalestudiantes);
            Imprimir(calif, salones, totalestudiantes);
        }

        private void Maximo(float[][] calif, int salones, int totalestudiantes)
        {
            float suma = 0.0f, maxima = 0.0f;

            for (int i = 0; i < salones; i++)
            {
                for (int r = 0; r < calif[i].GetLength(0); r++)
                {
                    if (calif[i][r] > maxima)
                    {
                        maxima = calif[i][r];
                    }
                    suma += calif[i][r];
                }
            }
            txt_maxima.Text = Convert.ToString(maxima);
        }

        private void Minimo(float[][] calif, int salones, int totalestudiantes)
        {
            float suma = 0.0f, minima = 99999.0f;

            for (int i = 0; i < salones; i++)
            {
                for (int r = 0; r < calif[i].GetLength(0); r++)
                {
                    if (calif[i][r] < minima)
                    {
                        minima = calif[i][r];
                    }
                    suma += calif[i][r];
                }
            }
            txt_minima.Text = Convert.ToString(minima);
        }

        private void Promedio(float[][] calif, int salones, int totalestudiantes)
        {
            float suma = 0.0f, promediogeneral = 0.0f, total = 0.0f;
            float[] promedio = new float[salones];

            for (int i = 0; i < salones; i++)
            {
                for (int r = 0; r < calif[i].GetLength(0); r++)
                {
                    total += calif[i][r];
                    suma += calif[i][r];
                }
                promedio[i] = total / calif[i].GetLength(0);
                total = 0.0f;
            }

            for (int i = 0; i < salones; i++)
            {
                listBox2.Items.Add("            Salon " + (i + 1));
                listBox2.Items.Add("                    Promedio " + ": " + Math.Round(promedio[i], 2, MidpointRounding.ToEven).ToString());
            }
            promediogeneral = suma / totalestudiantes;
            txt_promedio.Text = Math.Round(promediogeneral, 2, MidpointRounding.ToEven).ToString();
        }

        private void Imprimir(float[][] calif, int salones, int totalestudiantes)
        {
            for (int i = 0; i < salones; i++)
            {
                listBox1.Items.Add("             Salon " + (i + 1));
                for (int r = 0; r < calif[i].GetLength(0); r++)
                {
                    listBox1.Items.Add("                       Estudiante: " + (r + 1) + "         Calificacion: " + calif[i][r]);
                }
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            AgregarSalones();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            txt_maxima.Clear();
            txt_minima.Clear();
            txt_promedio.Clear();
            txt_salones.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            errorProvider1.Clear();
        }

        private void txt_salones_TextChanged(object sender, EventArgs e)
        {

        }
    }
}