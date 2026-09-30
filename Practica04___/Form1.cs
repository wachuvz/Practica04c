using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica04___
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombres = txnombre.Text;
            string apellidos = txapellido.Text;
            string telefonos = txtelefono.Text;
            string edad = txedad.Text;
            string estatura = txestatura.Text;

            string genero = "";

            if (rbmasculino.Checked)
            {
                genero = "Masculino";
            }
            else if (rbfemenino.Checked)
            {
                genero = "Femenino";
            }
            else if (rbotro.Checked)
            {
                genero = "Otro";
            }

            string mensaje = $" Nombres: {nombres}\n Apellidos: {apellidos}\n Telefono: {telefonos}\n Edad: {edad}\n Estatura: {estatura}\n Genero: {genero}";

            ///Ruta de almacenamiento de archivo TXT
            string rutaFile = "C:\\Users\\wachu\\Downloads\\datos.txt";
            ///Valor de verificacion de archivo existen
            bool ArchivoExiste = File.Exists(rutaFile);
            ///Instanciacion de la clase/objeto streamwriter para escribir archivo TXT
            using (StreamWriter Escritor = new StreamWriter(rutaFile, true))
            {
                if (ArchivoExiste)
                {
                    Escritor.WriteLine();
                }
                Escritor.WriteLine(mensaje);
            }

            MessageBox.Show(mensaje, "Registros de usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void txnombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}