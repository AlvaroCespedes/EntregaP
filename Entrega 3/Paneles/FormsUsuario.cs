using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace Entrega_3.Paneles
{
    public partial class FormsUsuario : Form
    {
        Clases.User usuario = new Clases.User();
        Clases.Serialization serializar = new Clases.Serialization();
        
        public FormsUsuario(Clases.User user)
        {
            

            InitializeComponent();
            usuario = user;
    
            if (user.Plan == "Basico")
            {


                if (user.Profiles.Count == 0)
                {
                    pic5.Visible = true;
                    pic1.Visible = false;
                    pic4.Visible = false;
                    pic7.Visible = false;
                    pic3.Visible = false;
                    pic6.Visible = false;
                    pic2.Visible = false;
                    pic8.Visible = false;
                    crear1.Visible = true;
                    crear2.Visible = false;
                    crear3.Visible = false;
                    crear4.Visible = false;
                }
                else
                {
                    pic5.Visible = false;
                    pic6.Visible = false;
                    pic7.Visible = false;
                    pic8.Visible = false;
                    
                    pic1.Visible = true;
                    pic4.Visible = false;
                    pic3.Visible = false;
                    pic2.Visible = false;

                    crear1.Visible = false;
                    crear2.Visible = false; 
                    crear3.Visible = false;
                    crear4.Visible = false;

                    label8.Text = usuario.Profiles[0].NameProfile;
                    label8.Visible = true;           
                    button1.Visible = true;

                }
            }
            else if (user.Plan == "Premium")
            {
                if (user.Profiles.Count == 0)
                {
                    pic5.Visible = true;
                    pic1.Visible = false;
                    pic4.Visible = false;
                    pic7.Visible = false;
                    pic3.Visible = false;
                    pic6.Visible = false;
                    pic2.Visible = false;
                    pic8.Visible = false;
                    crear1.Visible = true;
                    crear2.Visible = false;
                    crear3.Visible = false;
                    crear4.Visible = false;
                }
                else
                {
                    pic5.Visible = false;
                    pic1.Visible = true;
                    crear1.Visible = false;
                    crear2.Visible = false;
                    crear3.Visible = false;
                    crear4.Visible = false;
                    label8.Text = usuario.Profiles[0].NameProfile;
                    label8.Visible = true;
                    button1.Visible = true;
                    pic6.Visible = false;
                    pic7.Visible = false;
                    pic8.Visible = false;
                    pic4.Visible = false;
                    pic3.Visible = false;
                    pic2.Visible = false;
                }
            }

            else if (user.Plan == "Familiar")
            {
                if (user.Profiles.Count == 0)
                {
                    pic5.Visible = true;
                    pic1.Visible = false;
                    pic4.Visible = false;
                    pic7.Visible = true;
                    pic3.Visible = false;
                    pic6.Visible = true;
                    pic2.Visible = false;
                    pic8.Visible = true;
                    crear1.Visible = true;
                    crear2.Visible = true;
                    crear3.Visible = true;
                    crear4.Visible = true;
                }
                else if (user.Profiles.Count == 1)
                {
                    pic5.Visible = false;
                    pic1.Visible = true;
                    pic4.Visible = false;
                    pic7.Visible = true;
                    pic3.Visible = false;
                    pic6.Visible = true;
                    pic2.Visible = false;
                    pic8.Visible = true;
                    crear1.Visible = false;
                    crear2.Visible = true;
                    crear3.Visible = true;
                    crear4.Visible = true;
                    label8.Text = usuario.Profiles[0].NameProfile;
                    button1.Visible = true;
                    label8.Visible = true;
                }
                else if (user.Profiles.Count == 2)
                {
                    pic5.Visible = false;
                    pic1.Visible = true;
                    pic4.Visible = false;
                    pic7.Visible = true;
                    pic3.Visible = false;
                    pic6.Visible = false;
                    pic2.Visible = true;
                    pic8.Visible = true;
                    crear1.Visible = false;
                    crear2.Visible = false;
                    crear3.Visible = true;
                    crear4.Visible = true;
                    label8.Text = usuario.Profiles[0].NameProfile;
                    label8.Visible = true;
                    label9.Text = usuario.Profiles[1].NameProfile;
                    label9.Visible = true;
                    button1.Visible = true;
                    button2.Visible = true;
                }
                else if (user.Profiles.Count == 3)
                {
                    pic5.Visible = false;
                    pic1.Visible = true;
                    pic4.Visible = false;
                    pic7.Visible = false;
                    pic3.Visible = true;
                    pic6.Visible = false;
                    pic2.Visible = true;
                    pic8.Visible = true;
                    crear1.Visible = false;
                    crear2.Visible = false;
                    crear3.Visible = false;
                    crear4.Visible = true;
                    label8.Text = usuario.Profiles[0].NameProfile;
                    label8.Visible = true;
                    label9.Text = usuario.Profiles[1].NameProfile;
                    label9.Visible = true;
                    label10.Text = usuario.Profiles[2].NameProfile;
                    label10.Visible = true;
                    button1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = true;
                }
                else if (user.Profiles.Count == 4)
                {
                    pic5.Visible = false;
                    pic1.Visible = true;
                    pic4.Visible = true;
                    pic7.Visible = false;
                    pic3.Visible = true;
                    pic6.Visible = false;
                    pic2.Visible = true;
                    pic8.Visible = false;
                    crear1.Visible = false;
                    crear2.Visible = false;
                    crear3.Visible = false;
                    crear4.Visible = false;
                    label8.Text = usuario.Profiles[0].NameProfile;
                    label8.Visible = true;
                    label9.Text = usuario.Profiles[1].NameProfile;
                    label9.Visible = true;
                    label10.Text = usuario.Profiles[2].NameProfile;
                    label10.Visible = true;
                    label11.Text = usuario.Profiles[3].NameProfile;
                    label11.Visible = true;
                    button1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = true;
                    button4.Visible = true;
                }
                

            }
    
        }




        private void btnMinimizar_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            if (pic8.Visible == false)
            {
                panel2.Visible = true;

            }
        }
        //para mover barra
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void pic12_Click(object sender, EventArgs e)
        {/*
            subpanel2.Visible = false;
            subpanel3.Visible = false;
            if (subpane1.Visible == true)
            {
                subpane1.Visible = false;

            }
            else
            {
                subpane1.Visible = true;
            }
            */
        }

        private void pic13_Click(object sender, EventArgs e)
        {/*
            subpane1.Visible = false;
            subpanel3.Visible = false;
            if (subpanel2.Visible == true)
            {
                subpanel2.Visible = false;

            }
            else
            {
                subpanel2.Visible = true;
            }
            */
        }

        private void pic14_Click(object sender, EventArgs e)
        {
            /*
            subpanel2.Visible = false;
            subpane1.Visible = false;
            if (subpanel3.Visible == true)
            {
                subpanel3.Visible = false;

            }
            else
            {
                subpanel3.Visible = true;
            }
            */
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVolverNormalidad_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnVolverNormalidad.Visible = true;

        }

        private void btnVolverNormalidad_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnVolverNormalidad.Visible = false;
            btnMaximizar.Visible = true;


        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;


        }

        private void btnCambiarUsuario_Click(object sender, EventArgs e)
        {/*
            panelprincipal4.Visible = false;
            panelprincipal3.Visible = false;
            panelprincipal2.Visible = false;

            panelPrincipal1.Visible = false;
            panelMenuIzquierda.Visible = false;
            panelReproducotorAbajo.Visible = false;
            panelSubMenuAjustes.Visible = false;
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            if (panelSubMenuAjustes.Visible == true)
            {
                panelSubMenuAjustes.Visible = false;
            }
            else
            {
                panelSubMenuAjustes.Visible = true;
            }
            */
        }

      

        private void pic1_Click_1(object sender, EventArgs e)
        {/*
            panelMenuIzquierda.Visible = true;
            panelPrincipal1.Visible = true;
            panelReproducotorAbajo.Visible = true;
            */
        }

        private void button9_Click(object sender, EventArgs e)
        {/*
            subpane1.Visible = false;
            txtBarraMusica.Text = "safaera - Bad bunny";
            btnPlay.Visible = false;
            btnPausa.Visible = true;
            btnDetener.Visible = true;
            */
        }

        private void button12_Click(object sender, EventArgs e)
        { 
            /*
            subpanel2.Visible = false;
            txtBarraMusica.Text = "Gasolina  - the big boss";
            btnPlay.Visible = false;
            btnPausa.Visible = true;
            btnDetener.Visible = true;
            */
        }

        private void button14_Click(object sender, EventArgs e)
        {
            /*
            subpanel3.Visible = false;
            txtBarraMusica.Text = "WA-CHI-TU-RRO";
            btnPlay.Visible = false;
            btnPausa.Visible = true;
            btnDetener.Visible = true;
            */
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            /*
            btnDetener.Visible = false;
            txtBarraMusica.Text = "";
            */
        }

        private void btnPausa_Click(object sender, EventArgs e)
        {
            /*
            btnPausa.Visible = false;
            btnPlay.Visible = true;
            */
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            /*
            btnPlay.Visible = false;
            btnPausa.Visible = true;
            */

        }

        private void btnD1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PROXIMAEMNTE");
        }

        private void btnD2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PROXIMAEMNTE");
        }

        private void panelPrincipal1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void btnInicio_Click(object sender, EventArgs e)

        {
            /*
            panelprincipal4.Visible = false;
            panelprincipal3.Visible = false;
            panelprincipal2.Visible = false;
            */
        }
        private void button8_Click(object sender, EventArgs e)
        {
            /*
            panelprincipal4.Visible = false;
            panelprincipal3.Visible = false;
            panelprincipal2.Visible = true;
            */

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            panelprincipal4.Visible = false;
            panelprincipal3.Visible = true;
            */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pic5_Click(object sender, EventArgs e)
        {
            if (pic5.Visible == false)
            {
                panel2.Visible = true;

            }
               
        }


        private void pic6_Click(object sender, EventArgs e)
        {
            if (pic6.Visible == false)
            {
                panel2.Visible = true;

            }
        }


        private void pic7_Click(object sender, EventArgs e)
        {
            if (pic7.Visible == false)
            {
                panel2.Visible = true;

            }
        }

        private void FormsUsuario_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pic4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void crear2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void crear4_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Crear_Click(object sender, EventArgs e)
        {
            int errores = 0;
            if (usuario.Profiles.Count > 0)
            {
                for (int a = 0; a < usuario.Profiles.Count; a++)
                {
                    if (nomPerfil.Text == usuario.Profiles[a].NameProfile)
                    {
                        MessageBox.Show("Ya existe un perfil con este nombre");
                        errores++;
                    }
                }

            }
            if (nomPerfil.Text == "" || privacidadPerfil.SelectedItem == null || gustosMusicales.CheckedItems == null || gustosPeliculas.CheckedItems == null)
            {
                MessageBox.Show("RELLENE TODOS LOS DATOS");
            }
            else if(errores==0)
            {
                List<String> gustosMusica = new List<string>();
                List<String> gustosPelis = new List<string>();
                for (int i = 0; i < gustosMusicales.Items.Count;i++) 
                {
                    if (gustosMusicales.GetItemChecked(i) == true)
                    {
                        gustosMusica.Add(gustosMusicales.Items[i].ToString());
                       
                    }
                   
                    
                }
                for (int i = 0; i < gustosPeliculas.Items.Count; i++)
                {
                    if (gustosPeliculas.GetItemChecked(i) == true)
                    {
                        gustosPelis.Add(gustosPeliculas.Items[i].ToString());
                       
                    }


                }
                List<Clases.User> todosUsuarios = new List<Clases.User>();
                Clases.Profile perfil = new Clases.Profile(nomPerfil.Text,privacidadPerfil.SelectedItem.ToString(),gustosMusica,gustosPelis);
                usuario.Profiles.Add(perfil);

                List<Clases.User> deserializarUser = serializar.Deserialize<List<Clases.User>>(File.Open("data.bin", FileMode.Open));
                if (deserializarUser.Count > 0)
                {
                    for (int c = 0; c < deserializarUser.Count; c++)
                    {
                        todosUsuarios.Add(deserializarUser[c]);
                    }
                }
                todosUsuarios.Add(usuario);
               
                serializar.Serialize(todosUsuarios, File.Open("data.bin", FileMode.Create));
                MessageBox.Show("Perfil Creado");
                panel2.Visible = false;

                if (usuario.Plan == "Basico")
                {


                    if (usuario.Profiles.Count == 0)
                    {
                        pic5.Visible = true;
                        pic1.Visible = false;
                        pic4.Visible = false;
                        pic7.Visible = false;
                        pic3.Visible = false;
                        pic6.Visible = false;
                        pic2.Visible = false;
                        pic8.Visible = false;
                        crear1.Visible = true;
                        crear2.Visible = false;
                        crear3.Visible = false;
                        crear4.Visible = false;
                        
                    }
                    else
                    {
                        pic5.Visible = false;
                        pic1.Visible = true;
                        crear1.Visible = false;
                        crear2.Visible = false;
                        crear3.Visible = false;
                        crear4.Visible = false;
                        label8.Text = usuario.Profiles[0].NameProfile;
                        label8.Visible = true;
                        button1.Visible = true;


                    }
                }
                else if (usuario.Plan == "Premium")
                {
                    if (usuario.Profiles.Count == 0)
                    {
                        pic5.Visible = true;
                        pic1.Visible = false;
                        pic4.Visible = false;
                        pic7.Visible = false;
                        pic3.Visible = false;
                        pic6.Visible = false;
                        pic2.Visible = false;
                        pic8.Visible = false;
                        crear1.Visible = true;
                        crear2.Visible = false;
                        crear3.Visible = false;
                        crear4.Visible = false;
                    }
                    else
                    {
                        pic5.Visible = false;
                        pic1.Visible = true;
                        crear1.Visible = false;
                        crear2.Visible = false;
                        crear3.Visible = false;
                        crear4.Visible = false;
                        label8.Text = usuario.Profiles[0].NameProfile;
                        label8.Visible = true;
                        button1.Visible = true;
                    }
                }

                else if (usuario.Plan == "Familiar")
                {
                    if (usuario.Profiles.Count == 0)
                    {
                        pic5.Visible = true;
                        pic1.Visible = false;
                        pic4.Visible = false;
                        pic7.Visible = true;
                        pic3.Visible = false;
                        pic6.Visible = true;
                        pic2.Visible = false;
                        pic8.Visible = true;
                        crear1.Visible = true;
                        crear2.Visible = true;
                        crear3.Visible = true;
                        crear4.Visible = true;
                    }
                    else if (usuario.Profiles.Count == 1)
                    {
                        pic5.Visible = false;
                        pic1.Visible = true;
                        pic4.Visible = false;
                        pic7.Visible = true;
                        pic3.Visible = false;
                        pic6.Visible = true;
                        pic2.Visible = false;
                        pic8.Visible = true;
                        crear1.Visible = false;
                        crear2.Visible = true;
                        crear3.Visible = true;
                        crear4.Visible = true;
                        label8.Text = usuario.Profiles[0].NameProfile;
                        label8.Visible = true;
                        button1.Visible = true;
                    }
                    else if (usuario.Profiles.Count == 2)
                    {
                        pic5.Visible = false;
                        pic1.Visible = true;
                        pic4.Visible = false;
                        pic7.Visible = true;
                        pic3.Visible = false;
                        pic6.Visible = false;
                        pic2.Visible = true;
                        pic8.Visible = true;
                        crear1.Visible = false;
                        crear2.Visible = false;
                        crear3.Visible = true;
                        crear4.Visible = true;
                        label8.Text = usuario.Profiles[0].NameProfile;
                        label8.Visible = true;
                        label9.Text = usuario.Profiles[1].NameProfile;
                        label9.Visible = true;
                        button1.Visible = true;
                        button2.Visible = true;
                    }
                    else if (usuario.Profiles.Count == 3)
                    {
                        pic5.Visible = false;
                        pic1.Visible = true;
                        pic4.Visible = false;
                        pic7.Visible = false;
                        pic3.Visible = true;
                        pic6.Visible = false;
                        pic2.Visible = true;
                        pic8.Visible = true;
                        crear1.Visible = false;
                        crear2.Visible = false;
                        crear3.Visible = false;
                        crear4.Visible = true;
                        label8.Text = usuario.Profiles[0].NameProfile;
                        label8.Visible = true;
                        label9.Text = usuario.Profiles[1].NameProfile;
                        label9.Visible = true;
                        label10.Text = usuario.Profiles[2].NameProfile;
                        label10.Visible = true;
                        button1.Visible = true;
                        button2.Visible = true;
                        button3.Visible = true;
                    }
                    else if (usuario.Profiles.Count == 4)
                    {
                        pic5.Visible = false;
                        pic1.Visible = true;
                        pic4.Visible = true;
                        pic7.Visible = false;
                        pic3.Visible = true;
                        pic6.Visible = false;
                        pic2.Visible = true;
                        pic8.Visible = false;
                        crear1.Visible = false;
                        crear2.Visible = false;
                        crear3.Visible = false;
                        crear4.Visible = false;
                        label8.Text = usuario.Profiles[0].NameProfile;
                        label8.Visible = true;
                        label9.Text = usuario.Profiles[1].NameProfile;
                        label9.Visible = true;
                        label10.Text = usuario.Profiles[2].NameProfile;
                        label10.Visible = true;
                        label11.Text = usuario.Profiles[3].NameProfile;
                        label11.Visible = true;
                        button1.Visible = true;
                        button2.Visible = true;
                        button3.Visible = true;
                        button4.Visible = true;
                    }
                }
            }
        }

        private void privacidadPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            panelPrincipal1.Visible = true;
            panelMenuIzquierda.Visible = true;
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            panelPrincipal1.Visible = true;
            panelMenuIzquierda.Visible = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            panelPrincipal1.Visible = true;
            panelMenuIzquierda.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelPrincipal1.Visible = true;
            panelMenuIzquierda.Visible = true;
        }
    }
}

