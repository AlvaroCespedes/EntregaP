using Entrega_3.Paneles;
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
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.InteropServices;

namespace Entrega_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormsRegistro panelregistro = new FormsRegistro();
            panelregistro.Show();
        }

        private void button2_Click(object sender, EventArgs e) //Login. Al momento de apretar Login se tienen que cargar todos los usuarios.
        {
            this.Hide();
            PanelLogin panel = new PanelLogin();
            panel.Show();
            
            try
            {


                /*
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)//Si es que el usuario agrego un archivo para guardar.
                {
                    Stream st = File.Open(dialog.FileName, FileMode.Open);
                    var binfor = new BinaryFormatter();
                    Clases.User persona = (Clases.User)binfor.Deserialize(st);
                    //textNombre.Text = persona.Nombre; 
                }
                else
                {
                    MessageBox.Show("Se cancelo la operacion"); 

                }
                */
                
            }
            catch
            {
                MessageBox.Show("Error");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            PanelUsuario panelUsuario = new PanelUsuario();
            panelUsuario.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }
       
    }
}
