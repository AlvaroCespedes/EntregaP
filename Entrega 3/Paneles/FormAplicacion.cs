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
using Entrega_3.Clases;

namespace Entrega_3.Paneles
{

    public partial class FormAplicacion : Form
    {
        //est es solo para probar busqueda
        static DateTime date = new DateTime();

        static List<string> premios = new List<string>();

        static List<string> discograpich = new List<string>();
        static List<SongClass> canciones = new List<SongClass>();
        static Album album = new Album("nameAlbum", "gender", "producer", singer, date);
        static Album album2 = new Album("nameAlbum2", "gender2", "producer2", singer, date);
        static Album album3 = new Album("nameAlbum3", "gender3", "producer3", singer, date);
        static Album album4 = new Album("nameAlbum4", "gender4", "producer4", singer, date);

        static List<Album> listaAlbum = new List<Album>();
        static Singer singer = new Singer(canciones, listaAlbum, premios, "voiceType", "genders", 22, discograpich, "name", 12, "Lastname", "genero", "nationality", "ocupacion");
        static Singer singer2 = new Singer(canciones, listaAlbum, premios, "voiceType2", "genders2", 22, discograpich, "name2", 12, "Lastname2", "genero2", "nationality2", "ocupacion2");
        static Singer singer3 = new Singer(canciones, listaAlbum, premios, "voiceType3", "genders3", 22, discograpich, "name3", 12, "Lastname3", "genero3", "nationality3", "ocupacion3");
        static Singer singer4 = new Singer(canciones, listaAlbum, premios, "voiceType4", "genders4", 22, discograpich, "name4", 12, "Lastname4", "genero4", "nationality4", "ocupacion4");

        static List<Video> videos = new List<Video>();
        static Actor Mactor = new Actor("name", 22, "lName", "gender", "nationality", "Ocupacion", videos, premios, 22);
        static Actor Mactor2 = new Actor("name2", 22, "lName2", "gender2", "nationality2", "Ocupacion2", videos, premios, 22);
        static Actor Mactor3 = new Actor("name3", 22, "lName3", "gender3", "nationality3", "Ocupacion3", videos, premios, 22);
        static Actor Mactor4 = new Actor("name4", 22, "lName4", "gender4", "nationality4", "Ocupacion4", videos, premios, 22);
        static Director d = new Director("nDi", 22, "LastD", "gender", "nationality", "ocupation", videos, premios, 22);
        static Director d2 = new Director("nDi2", 222, "LastD2", "gender2", "nationality2", "ocupation2", videos, premios, 222);
        static Director d3 = new Director("nDi3", 22, "Last3", "gender3", "nationality3", "ocupatio3", videos, premios, 22);
        static Director d4 = new Director("nDi4", 222, "LastD4", "gender4", "nationality4", "ocupation4", videos, premios, 222);

        SongClass cancion = new SongClass("Cgender", "publicationYear", "title", 22, 22, "study", "keyword", "composer", singer, album, "format", 1, 2);
        SongClass cancion2 = new SongClass("Cgender2", "publicationYear2", "title2", 22, 22, "study2", "keyword2", "composer2", singer2, album2, "format2", 11, 22);
        SongClass cancion3 = new SongClass("Cgender3", "publicationYear3", "title3", 22, 22, "study3", "keyword3", "composer3", singer3, album3, "format3", 111, 222);
        SongClass cancion4 = new SongClass("Cgender4", "publicationYear4", "title4", 22, 22, "study4", "keyword4", "composer4", singer4, album4, "format4", 1111, 2222);

        Video video = new Video("Vgender", "publicationYear", "title", 22, 22, "study", "keyword", "description", Mactor, d, "format", 1, 2);
        Video video2 = new Video("Vgender2", "publicationYear2", "title2", 22, 22, "study2", "keyword2", "description2", Mactor2, d2, "format2", 11, 22);
        Video video3 = new Video("Vgender3", "publicationYear3", "title3", 22, 22, "study3", "keyword3", "description3", Mactor3, d3, "format3", 111, 222);
        Video video4 = new Video("Vgender4", "publicationYear4", "title4", 22, 22, "study4", "keyword4", "description4", Mactor4, d4, "format4", 1111, 2222);



        //hasta aqui
        Clases.User usuario = new Clases.User();
        Clases.Serialization serializar = new Clases.Serialization();
        string TipoCuenta;
        public FormAplicacion(Clases.User user)
        {
            InitializeComponent();
            usuario = user;
            if (user.Plan == "Basico")
            {
                TipoCuenta = "Basico";

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
                TipoCuenta = "Premiun";
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
                TipoCuenta = "Familiar";
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
            panel4.Visible = false;
            if (panelSubMenuAjustes.Visible==true)
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
            if (panel4.Visible == true)
            {
                panel4.Visible = false;
            }

        }

        private void btnPlaylisMusica_Click(object sender, EventArgs e)
        {
            if (panelSubMenuAjustes.Visible == true)
            {
                panelSubMenuAjustes.Visible = false;
            }
            if (panel4.Visible == true)
            {
                panel4.Visible = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (panelSubMenuAjustes.Visible == true)
            {
                panelSubMenuAjustes.Visible = false;
            }
            if (panel4.Visible == true)
            {
                panel4.Visible = false;
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (panelSubMenuAjustes.Visible == true)
            {
                panelSubMenuAjustes.Visible = false;
            }
            if (panel4.Visible == true)
            {
                panel4.Visible = false;
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
            if (listCanciones.Visible == true)
            {
                listCanciones.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelCrearUsuario.Visible = true;
            panelContenedorPincipal.Visible = true;
            panel5.Visible = false;
            
            string h = ".jpg";
            b1.Visible = false;
            b2.Visible = false;
            b3.Visible = false;
            b4.Visible = false;


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
            b1.Visible = false;
            b2.Visible = false;
            b3.Visible = false;
            b4.Visible = false;

        }

        private void crear2_Click(object sender, EventArgs e)
        {
            panelContenedorPincipal.Visible = false;
            panelCrearUsuario.Visible = true;
            b1.Visible = false;
            b2.Visible = false;
            b3.Visible = false;
            b4.Visible = false;
        }

        private void crear3_Click(object sender, EventArgs e)
        {
            panelContenedorPincipal.Visible = false;
            panelCrearUsuario.Visible = true;
            b1.Visible = false;
            b2.Visible = false;
            b3.Visible = false;
            b4.Visible = false;
        }

        private void crear4_Click(object sender, EventArgs e)
        {
            panelContenedorPincipal.Visible = false;
            panelCrearUsuario.Visible = true;
            b1.Visible = false;
            b2.Visible = false;
            b3.Visible = false;
            b4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelCrearUsuario.Visible = true;
            panelContenedorPincipal.Visible = true;
            panel5.Visible = false;
            string h = ".jpg";
            b1.Visible = false;
            b2.Visible = false;
            b3.Visible = false;
            b4.Visible = false;


            Image image1 = Image.FromFile(usuario.Profiles[1].PleasuresMusic[0] + h);
            pic12.Image = image1;
            Image image2 = Image.FromFile(usuario.Profiles[1].PleasuresMusic[1] + h);
            pic13.Image = image2;
            Image image3 = Image.FromFile(usuario.Profiles[1].PleasuresMusic[2] + h);
            pic14.Image = image3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelCrearUsuario.Visible = true;
            panelContenedorPincipal.Visible = true;
            string h = ".jpg";
            b1.Visible = false;
            b2.Visible = false;
            b3.Visible = false;
            b4.Visible = false;
            panel5.Visible = false;


            Image image1 = Image.FromFile(usuario.Profiles[2].PleasuresMusic[0] + h);
            pic12.Image = image1;
            Image image2 = Image.FromFile(usuario.Profiles[2].PleasuresMusic[1] + h);
            pic13.Image = image2;
            Image image3 = Image.FromFile(usuario.Profiles[2].PleasuresMusic[2] + h);
            pic14.Image = image3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelCrearUsuario.Visible = true;
            panelContenedorPincipal.Visible = true;
            string h = ".jpg";
            b1.Visible = false;
            b2.Visible = false;
            b3.Visible = false;
            b4.Visible = false;
            panel5.Visible = false;


            Image image1 = Image.FromFile(usuario.Profiles[3].PleasuresMusic[0] + h);
            pic12.Image = image1;
            Image image2 = Image.FromFile(usuario.Profiles[3].PleasuresMusic[1] + h);
            pic13.Image = image2;
            Image image3 = Image.FromFile(usuario.Profiles[3].PleasuresMusic[2] + h);
            pic14.Image = image3;
        }

        private void btnCambiarPerfil_Click(object sender, EventArgs e)
        {
            panelContenedorPincipal.Visible = false;
            panelCrearUsuario.Visible = false;
            panel4.Visible = false;
            
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

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            label15.Text = "Cambio de Contraseña";
            l1.Text = "Constraseña actual";
            l2.Text = "Nueva constraseña";
            l3.Text = "Confirme nueva";
            l1.Visible = true;
            l2.Visible = true;
            l3.Visible = true;
            l4.Visible = true;
            l5.Visible = true;
            l6.Visible = true;
            radioButton1.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            btnCambiarClave.Visible = true;
            btncambiarp.Visible = false;


            if (panel4.Visible == true)
            {
                panel4.Visible = false;
            }
            else
            {
                panel4.Visible = true;
            }
        }

        private void btnCambiarPlan_Click(object sender, EventArgs e)
        {
            label15.Text = "Escoja Plan";
            l1.Visible = false;
            l2.Visible = false;
            l3.Visible = true;
            l3.Text = "Contraseña";
            l4.Visible = false;
            l5.Visible = false;
            l6.Visible = true;
            btnCambiarClave.Visible = false;
            btncambiarp.Visible = true;
            radioButton1.Visible = true;
            radioButton4.Visible = true;
            radioButton5.Visible = true;

            if (panel4.Visible == true)
            {
                panel4.Visible = false;
            }
            else
            {
                panel4.Visible = true;
            }
        }

        private void btnOtro_Click(object sender, EventArgs e)
        {
            panelContenedorPincipal.Visible = false;
            panel4.Visible = false;
            panelSubMenuAjustes.Visible = false;
            panelCrearUsuario.Visible = false;
            b1.Visible = true;
            if (TipoCuenta == "Familiar")
            {
                b2.Visible = true;
                b3.Visible = true;
                b4.Visible = true;
            }
            
            
        }

        private void panelSubMenuAjustes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCambiarClave_Click(object sender, EventArgs e)
        {
           
        }

        private void b1_Click(object sender, EventArgs e)
        {
            panelCrearUsuario.Visible = true;
            panelContenedorPincipal.Visible = true;
            panel5.Visible = true;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            panelCrearUsuario.Visible = true;
            panelContenedorPincipal.Visible = true;
            panel5.Visible = true;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            panelCrearUsuario.Visible = true;
            panelContenedorPincipal.Visible = true;
            panel5.Visible = true;
        }

        private void b4_Click(object sender, EventArgs e)
        {
            panelCrearUsuario.Visible = true;
            panelContenedorPincipal.Visible = true;
            panel5.Visible = true;
        }
        private void pic10_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (listCanciones.Visible == true)
            {
                listCanciones.Visible = false;
                listCanciones.Items.Clear();

            }
            else
            {
                listCanciones.Items.Clear();
                listCanciones.Visible = true;
            }
            try
            {
                int entero = 0;
                string answer = txtBusqueda.Text;
                string[] listaStr = answer.Split(',');//TIENE QUE IR EN EL FORMS

                try
                {
                    entero = Int32.Parse(answer);
                }
                catch (FormatException)
                {

                }
                if (entero != 0)
                {
                    //Buscar por resolucion de video o cancion
                    var resolution = from s in canciones
                                     where s.Resolution == entero
                                     select s;
                    var resolution2 = from s in videos
                                      where s.Resolution == entero
                                      select s;
                    foreach (SongClass x in resolution)
                    {
                        listCanciones.Items.Add(x);
                    }
                    foreach (Video z in resolution2)
                    {
                        listCanciones.Items.Add(z);
                    }

                    //Buscar por nota definida.
                    var nota = from s in canciones
                               where s.Evaluation == entero
                               select s;
                    var nota2 = from s in videos
                                where s.Evaluation == entero
                                select s;
                    foreach (SongClass x in nota)
                    {
                        listCanciones.Items.Add(x);
                    }
                    foreach (Video z in nota2)
                    {
                        listCanciones.Items.Add(z);
                    }

                }
                else //STRINGS
                {
                    string answer2 = answer.ToUpper(); //Ponerlo en el FORMS
                    var title = from s in canciones //Filtro por Titutlo de la cancion. Y video.
                                where s.Title.ToUpper() == answer2
                                select s;
                    var title2 = from s in videos
                                 where s.Title.ToUpper() == answer2
                                 select s;
                    foreach (SongClass ojb2 in title)
                    {
                        listCanciones.Items.Add(ojb2);
                    }
                    foreach (Video ojb2 in title2)
                    {
                        listCanciones.Items.Add(ojb2);
                    }

                    var keyWord = from s in canciones //Filtro por palabra clave
                                  where s.Keyword == answer
                                  select s;
                    var keyword2 = from s in videos
                                   where s.Keyword == answer
                                   select s;
                    foreach (SongClass x in keyWord)
                    {
                        listCanciones.Items.Add(x);
                    }
                    foreach (Video z in keyword2)
                    {
                        listCanciones.Items.Add(z);
                    }
                    //Busqueda por persona. Se buscara por director/Actor, Singer/Composer. Todo sera buscado por nombres.
                    var persona = from s in canciones
                                  where s.Singer.Name == answer || s.Composer == answer
                                  select s;
                    var persona2 = from s in videos
                                   where s.Director.Name == answer || s.MainActor.Name == answer
                                   select s;
                    foreach (SongClass x in persona)
                    {
                        listCanciones.Items.Add(x);
                    }
                    foreach (Video z in persona2)
                    {
                        listCanciones.Items.Add(z);
                    }

                    //Busqueda por caracteristica de personas. Se buscara director en videos y singer en canciones.
                    // En Ambos se buscara por Gender o Nacionalidad
                    var person = from s in canciones
                                 where s.Singer.Gender == answer || s.Singer.Nationality == answer
                                 select s;
                    var person2 = from s in videos
                                  where s.Director.Gender == answer || s.Director.Nationality == answer
                                  select s;
                    foreach (SongClass x123 in person)
                    {
                        listCanciones.Items.Add(x123);
                    }
                    foreach (Video z123 in person2)
                    {
                        listCanciones.Items.Add(z123);
                    }

                    var category = from s in canciones //Categoria = Genero de musica, en el caso de video a que tipo pertenece.
                                   where s.Gender == answer
                                   select s;
                    var category2 = from s in videos
                                    where s.Gender == answer
                                    select s;

                    foreach (SongClass y2 in category)
                    {
                        listCanciones.Items.Add(y2);
                    }
                    foreach (Video z1 in category2)
                    {
                        listCanciones.Items.Add(z1);
                    }
                }
                //Multiples filtrosss ----------------------------------------------------- Por ahora con strings
                if (listaStr.Count() >= 2)
                {
                    var Multi1 = from s in canciones //Genero y palabra clave
                                 where (s.Gender == listaStr[0] && s.Keyword == listaStr[1]) || (s.Gender == listaStr[1] && s.Keyword == listaStr[0])
                                 select s;
                    var multi2 = from s in videos
                                 where (s.Gender == listaStr[0] && s.Keyword == listaStr[1]) || (s.Gender == listaStr[1] && s.Keyword == listaStr[0])
                                 select s;
                    foreach (SongClass j in Multi1)
                    {
                        listCanciones.Items.Add(j);
                    }
                    foreach (Video j in multi2)
                    {
                        listCanciones.Items.Add(j);
                    }
                    //Palabra clave y persona
                    var Mezcla = from s in canciones
                                 where (s.Keyword == listaStr[0] && (s.Singer.Name == listaStr[1] || s.Composer == listaStr[1])) || (s.Keyword == listaStr[1] && (s.Singer.Name == listaStr[0] || s.Composer == listaStr[0]))
                                 select s;
                    var Mezcla2 = from s in videos
                                  where (s.Keyword == listaStr[0] && (s.Director.Name == listaStr[1] || s.MainActor.Name == listaStr[1])) || (s.Keyword == listaStr[1] && (s.Director.Name == listaStr[0] || s.MainActor.Name == listaStr[0]))
                                  select s;
                    foreach (SongClass j in Mezcla)
                    {
                        listCanciones.Items.Add(j);
                    }
                    foreach (Video j in Mezcla2)
                    {
                        listCanciones.Items.Add(j);
                    }

                    //Palabra clave y caracteristica de la persona.
                    var anakin = from s in canciones
                                 where (s.Keyword == listaStr[0] && (s.Singer.Gender == listaStr[1] || s.Singer.Nationality == listaStr[1])) || (s.Keyword == listaStr[1] && (s.Singer.Gender == listaStr[0] || s.Singer.Nationality == listaStr[0]))
                                 select s;
                    var anakin2 = from s in videos
                                  where (s.Keyword == listaStr[0] && (s.Director.Gender == listaStr[1] || s.Director.Nationality == listaStr[1])) || (s.Keyword == listaStr[1] && (s.Director.Gender == listaStr[0] || s.Director.Nationality == listaStr[0]))
                                  select s;
                    foreach (SongClass j in anakin)
                    {
                        listCanciones.Items.Add(j);
                    }
                    foreach (Video j in anakin2)
                    {
                        listCanciones.Items.Add(j);
                    }
                }
                if (listCanciones.Items.Count == 0)// ESto es cuando no pudo encontrar nada relacionado con canciones y videos.
                {
                    MessageBox.Show("No se pudo encontrar nada relacionado. Intente de nuevo.");
                }

                //Multiples filtro a la vez.



            }

            catch (System.Runtime.Serialization.SerializationException) //VEr despues
            {
                MessageBox.Show("Terminos no validos.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            canciones.Add(cancion);
            canciones.Add(cancion2);
            canciones.Add(cancion3);
            canciones.Add(cancion4);
            videos.Add(video);
            videos.Add(video2);
            videos.Add(video3);
            videos.Add(video4);

            listaAlbum.Add(album);
            listaAlbum.Add(album2);
            listaAlbum.Add(album3);
            listaAlbum.Add(album4);

            foreach (SongClass x in canciones)
            {
                listCanciones.Items.Add(x);
            }
            foreach (Video x in videos)
            {
                listCanciones.Items.Add(x);
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            listCanciones.Items.Clear();
        }
    }
}
