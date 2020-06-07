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
    public partial class FormAplicacion : Form
    {
        Clases.User usuario = new Clases.User();
        Clases.Serialization serializar = new Clases.Serialization();
        public FormAplicacion(Clases.User user)
        {
            InitializeComponent();
            usuario = user;
            if (user.Plan == "Basico")
            {

                btnPlaylisMusica.Visible = false;
                btnPlaylistVideo.Visible = false;
                btnCambiarPerfil.Visible = false;
                panel12.Visible = false;
               
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

        private void btnVolverNormalidad_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnVolverNormalidad.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void SubMenuAjustes_Click(object sender, EventArgs e)
        {   
            if(panelSubMenuAjustes.Visible==true)
            {
                panelSubMenuAjustes.Visible = false;
            }
            else 
                    
            { panelSubMenuAjustes.Visible = true; }
            
        }

        private void btnPlaylistVideo_Click(object sender, EventArgs e)
        {
            if (panelSubMenuAjustes.Visible == true)
            {
                panelSubMenuAjustes.Visible = false;
            }
        }

        private void btnPlaylisMusica_Click(object sender, EventArgs e)
        {
            if (panelSubMenuAjustes.Visible == true)
            {
                panelSubMenuAjustes.Visible = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (panelSubMenuAjustes.Visible == true)
            {
                panelSubMenuAjustes.Visible = false;
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (panelSubMenuAjustes.Visible == true)
            {
                panelSubMenuAjustes.Visible = false;
            }
        }

        private void pic12_Click(object sender, EventArgs e)
        {
            if (subpanel1.Visible == true)
            {
                subpanel1.Visible = false;
            }
            else
            {
                subpanel1.Visible = true;
            }
            if (subpanel2.Visible == true)
            {
                subpanel2.Visible = false;
            }
            if (subpanel3.Visible == true)
            {
                subpanel3.Visible = false;
            }
        }

        private void pic13_Click(object sender, EventArgs e)
        {
            if (subpanel1.Visible == true)
            {
                subpanel1.Visible = false;
            }
            if (subpanel2.Visible == true)
            {
                subpanel2.Visible = false;
            }
            else
            {
                subpanel2.Visible = true;
            }
            if (subpanel3.Visible == true)
            {
                subpanel3.Visible = false;
            }
        }

        private void pic14_Click(object sender, EventArgs e)
        {
            if (subpanel1.Visible == true)
            {
                subpanel1.Visible = false;
            }
            if (subpanel2.Visible == true)
            {
                subpanel2.Visible = false;
            }
            if (subpanel3.Visible == true)
            {
                subpanel3.Visible = false;
            }
            else
            {
                subpanel3.Visible = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelContenedorPincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelCrearUsuario.Visible = true;
            panelContenedorPincipal.Visible = true;
            string h = ".jpg";

           

            Image image1 = Image.FromFile(usuario.Profiles[0].PleasuresMusic[0] + h);
            pic12.Image = image1;
            Image image2 = Image.FromFile(usuario.Profiles[0].PleasuresMusic[1] + h);
            pic13.Image = image2;
            Image image3 = Image.FromFile(usuario.Profiles[0].PleasuresMusic[2] + h);
            pic14.Image = image3;












        }

        private void crear1_Click(object sender, EventArgs e)
        {
            panelContenedorPincipal.Visible = false;
            panelCrearUsuario.Visible = true;
           
        }

        private void crear2_Click(object sender, EventArgs e)
        {
            panelContenedorPincipal.Visible = false;
            panelCrearUsuario.Visible = true;
        }

        private void crear3_Click(object sender, EventArgs e)
        {
            panelContenedorPincipal.Visible = false;
            panelCrearUsuario.Visible = true;
        }

        private void crear4_Click(object sender, EventArgs e)
        {
            panelContenedorPincipal.Visible = false;
            panelCrearUsuario.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelCrearUsuario.Visible = true;
            panelContenedorPincipal.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelCrearUsuario.Visible = true;
            panelContenedorPincipal.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelCrearUsuario.Visible = true;
            panelContenedorPincipal.Visible = true;
        }

        private void btnCambiarPerfil_Click(object sender, EventArgs e)
        {
            panelContenedorPincipal.Visible = false;
            panelCrearUsuario.Visible = false;
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
            if (nomPerfil.Text == "" || privacidadPerfil.SelectedItem == null || gustosMusicales.CheckedItems.Count< 3 || gustosPeliculas.CheckedItems.Count<3)
            {
                MessageBox.Show("RELLENE TODOS LOS DATOS");
                if(gustosMusicales.CheckedItems.Count < 3)
                {
                    MessageBox.Show("Debe ingresar al menos 3 gustos musicales");
                }
                if (gustosMusicales.CheckedItems.Count < 3)
                {
                    MessageBox.Show("Debe ingresar al menos 3 categorias de peliculas favoritas");
                }

            }
            else if (errores == 0)
            {
                panelCrearUsuario.Visible = false;
                List<String> gustosMusica = new List<string>();
                List<String> gustosPelis = new List<string>();
                for (int i = 0; i < gustosMusicales.Items.Count; i++)
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
                Clases.Profile perfil = new Clases.Profile(nomPerfil.Text, privacidadPerfil.SelectedItem.ToString(), gustosMusica, gustosPelis);
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
                panelContenedorPincipal.Visible = false;
                panelCrearUsuario.Visible = false;

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

        private void pic9_Click(object sender, EventArgs e)
        {

        }

        private void gustosMusicales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pic10_Click(object sender, EventArgs e)
        {

        }
    }
}
