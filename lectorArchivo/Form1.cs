using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace lectorArchivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           
            
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textRuta_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            if(buscar.ShowDialog() == DialogResult.OK)
            {
                textRuta.Text = buscar.FileName;
            }

        }

        private void botonCargarInfo_Click(object sender, EventArgs e)
        {
            String ruta = textRuta.Text;
            StreamReader lector = new StreamReader(@""+ruta);
            List<String> lineasEntrada = new List<string>();
            List<String> lineasSalida = new List<string>();
            string lineaActual;
            int contador = 0;
            while((lineaActual = lector.ReadLine()) != null)
            {
                lineasEntrada.Add(lineaActual);
                lineasSalida.Add((contador + 1) + " -> " + lineaActual);
                contador++;
            }

            salidaDatos.Lines = lineasSalida.ToArray();
        }

        private void cargarInfoConsola_Click(object sender, EventArgs e)
        {
            String[] lineasEntradas = entradaDatosConsola.Lines;
            String[] lineasSalidas = lineasEntradas;
            for(int i = 0; i < lineasEntradas.Length;i++)
            {
                lineasSalidas[i] = i + " -> " + lineasEntradas[i];
            }
            salidaDatos.Lines = lineasSalidas;
        }

        private void checkConsola_CheckedChanged(object sender, EventArgs e)
        {
            limpiarCampos();

            if (checkConsola.Checked)
            {
                entradaDatosConsola.Enabled = true;
                checkArchivo.Enabled = false;
                cargarInfoConsola.Enabled = true;
                botonLimpiar.Enabled = true;
                
            }
            else
            {
                entradaDatosConsola.Enabled = false;
                checkArchivo.Enabled = true;
                cargarInfoConsola.Enabled = false;
                botonLimpiar.Enabled = false;
            }

        }
        private void checkArchivo_CheckedChanged(object sender, EventArgs e)
        {
            limpiarCampos();

            if (checkArchivo.Checked)
            {
                textRuta.Enabled = true;
                botonBuscar.Enabled = true;
                botonCargarInfo.Enabled = true;
                botonLimpiar.Enabled = true;
                checkConsola.Enabled = false;
            }
            else
            {
                textRuta.Enabled = false;
                botonBuscar.Enabled = false;
                botonCargarInfo.Enabled = false;
                checkConsola.Enabled = true;
                botonLimpiar.Enabled = false;
            }

        }


        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            textRuta.Clear();
            entradaDatosConsola.Clear();
            salidaDatos.Clear();
        }

        private void tabIngreso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void botonCargarInfo_Click_1(object sender, EventArgs e)
        {

        }
    }
}
