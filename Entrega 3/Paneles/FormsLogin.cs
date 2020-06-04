using Entrega_3.Clases;
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

namespace Entrega_3
{

    public partial class PanelLogin : Form
    {

        public PanelLogin()
        {
            InitializeComponent();
        }

        Clases.DataBase database = new Clases.DataBase();
       
        Clases.MailSender mailSender = new Clases.MailSender();
      
        Clases.User user = new Clases.User();
        DateTime hora = new DateTime();
   
        Clases.ProfilelUser perfi2 = new Clases.ProfilelUser();
        double intervalo = 1000;
        
        //SongClass cancion = new SongClass(); Ya instancie este objeto.
        //Video video = new Video(); // YA instancie
        Clases.ProfileManagment profileManagment = new Clases.ProfileManagment();
        IDictionary<Clases.User, List<Clases.Profile>> diccUserProfiles = new Dictionary<Clases.User, List<Clases.Profile>>();
        List<Clases.User> usuarios = new List<Clases.User>();
        Clases.Serialization serializar = new Serialization();



        private void button1_Click(object sender, EventArgs e)
        {
            List<Clases.User> deserializarUser = serializar.Deserialize<List<Clases.User>>(File.Open("data.bin", FileMode.Open));
            if (txtUser.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("POR FAVOR RELLENE AMBOS DATOS");
            }

            else if (deserializarUser.Count > 0)//aca hay que poner que se verifique el inicio de secion
            {
                int error = 1;
                for (int d = 0; d < deserializarUser.Count; d++)
                {
                    error--;
                    if (deserializarUser[d].NameUser==txtUser.Text && deserializarUser[d].Password==txtPassword.Text)
                    {
                            
                        this.Hide();
                        PanelUsuario panelUser = new PanelUsuario();
                        panelUser.Show();
                        break;
                    }
                    else
                    {
                        error++;
                    }
                   
                }
                if (error>0)
                {
                    MessageBox.Show("Usuario o contraseña invalida");
                }
                
                
            }
           


            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
