﻿using Obligatorio.Forms;
using Obligatorio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obligatorio
{
    public partial class NewPropertyHouseScreen : Form
    {
        private int habitaciones;
        private int dormitorios;
        private int baños;
        private int año;
        private double metros;
        private string departamento;
        private string ciudad;        
        private string estado;
        private int garages;
        private string direccion;
        private bool parrillero;
        private int precio;
        private string barrio;
        private string comentarios;

        public NewPropertyHouseScreen()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            precio = Convert.ToInt32(textBox1.Text);
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            direccion = textBox11.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dormitorios = Convert.ToInt32(textBox2.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            habitaciones = Convert.ToInt32(textBox6.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            baños = Convert.ToInt32(textBox3.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            ciudad = textBox5.Text;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            año = Convert.ToInt32(textBox7.Text);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            metros = Convert.ToInt32(textBox8.Text);
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            garages = Convert.ToInt32(textBox12.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            barrio = textBox4.Text;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            departamento = textBox13.Text;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            comentarios=textBox9.Text;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            String estado = comboBox3.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Casa casa = new Casa
            {
                Precio = precio, //Convert.ToInt32(textBox1),
                Habitaciones = habitaciones,//Convert.ToInt32(textBox6),
                Dormitorios = dormitorios,//Convert.ToInt32(textBox2),
                Baños = baños,//Convert.ToInt32(textBox3),
                AñoConstruccion = año,//Convert.ToInt32(textBox7),
                MetrosCuadrados = metros,//Convert.ToDouble(textBox8),
                Departamento = departamento,//textBox13.Text,
                Ciudad = ciudad,//textBox5.Text,
                Barrio = barrio,//textBox4.Text,
                EstadoFisico = estado,
                Garages = garages, //Convert.ToInt32(textBox12),
                Direccion = direccion, //textBox11.Text,
                Parrillero = parrillero,
                Comentarios = new List<string>(),
                
            };
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            using (NewPropertyScreen House = new NewPropertyScreen())
            {
                House.ShowDialog();
                Application.Exit();
            }
        }

        
    }
}
