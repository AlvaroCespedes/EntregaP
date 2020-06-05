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

namespace Entrega_3.Paneles
{
    public partial class FormsUsuario : Form
    {
        public FormsUsuario()
        {
            InitializeComponent();
        }

      
        

        private void btnMinimizar_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

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
        {
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
        }

        private void pic13_Click(object sender, EventArgs e)
        {
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
        }

        private void pic14_Click(object sender, EventArgs e)
        {
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
        {
            panelprincipal4.Visible = false;
            panelprincipal3.Visible = false;
            panelprincipal2.Visible = false;

            panelPrincipal1.Visible = false;
            panelMenuIzquierda.Visible = false;
            panelReproducotorAbajo.Visible = false;
            panelSubMenuAjustes.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (panelSubMenuAjustes.Visible == true)
            {
                panelSubMenuAjustes.Visible = false;
            }
            else
            {
                panelSubMenuAjustes.Visible = true;
            }
        }

      

        private void pic1_Click_1(object sender, EventArgs e)
        {
            panelMenuIzquierda.Visible = true;
            panelPrincipal1.Visible = true;
            panelReproducotorAbajo.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            subpane1.Visible = false;
            txtBarraMusica.Text = "safaera - Bad bunny";
            btnPlay.Visible = false;
            btnPausa.Visible = true;
            btnDetener.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            subpanel2.Visible = false;
            txtBarraMusica.Text = "Gasolina  - the big boss";
            btnPlay.Visible = false;
            btnPausa.Visible = true;
            btnDetener.Visible = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            subpanel3.Visible = false;
            txtBarraMusica.Text = "WA-CHI-TU-RRO";
            btnPlay.Visible = false;
            btnPausa.Visible = true;
            btnDetener.Visible = true;
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            btnDetener.Visible = false;
            txtBarraMusica.Text = "";
        }

        private void btnPausa_Click(object sender, EventArgs e)
        {
            btnPausa.Visible = false;
            btnPlay.Visible = true;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            btnPlay.Visible = false;
            btnPausa.Visible = true;

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
            panelprincipal4.Visible = false;
            panelprincipal3.Visible = false;
            panelprincipal2.Visible = false;
            
        }
        private void button8_Click(object sender, EventArgs e)
        {
            panelprincipal4.Visible = false;
            panelprincipal3.Visible = false;
            panelprincipal2.Visible = true;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelprincipal4.Visible = false;
            panelprincipal3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelprincipal4.Visible = true;
        }
    }
}

