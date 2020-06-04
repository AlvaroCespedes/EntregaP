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
namespace Entrega_3
{
    public partial class PanelUsuario : Form
    {
        public PanelUsuario()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnVolverNormalidad.Visible = true;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnVolverNormalidad_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnVolverNormalidad.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            panel23.Visible = false;
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

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (SubMenuAjustes.Visible == true)
            {
                SubMenuAjustes.Visible = false;
            }
            else
            {
                SubMenuAjustes.Visible = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel24.Visible = true;
            panel2.Visible = false;
            panel13.Visible = false;


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            btnPlay.Visible = false;
            btnPausa.Visible = true;


        }

        private void btnPausa_Click(object sender, EventArgs e)
        {
            btnPausa.Visible = false;
            btnPlay.Visible = true;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            panel17.Visible = false;
            panel20.Visible = false;

            if (panel14.Visible == true)
            {
                panel14.Visible = false;

            }
            else
            {
                panel14.Visible = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel14.Visible = false;
            txtBarraMusica.Text="safaera - Bad bunny";
            btnPlay.Visible = false;
            btnPausa.Visible = true;
            btnDetener.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel17.Visible = false;
            txtBarraMusica.Text = "Gasolina  - the big boss";
            btnPlay.Visible = false;
            btnPausa.Visible = true;
            btnDetener.Visible = true;
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            panel14.Visible = false;
            panel20.Visible = false;

            if (panel17.Visible == true)
            {
                panel17.Visible = false;

            }
            else
            {
                panel17.Visible = true;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel17.Visible = false;
            panel14.Visible = false;

            if (panel20.Visible == true)
            {
                panel20.Visible = false;

            }
            else
            {
                panel20.Visible = true;
            }
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            btnDetener.Visible = false;
            txtBarraMusica.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            panel20.Visible = false;
            txtBarraMusica.Text = "WA-CHI-TU-RRO";
            btnPlay.Visible = false;
            btnPausa.Visible = true;
            btnDetener.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PROXIMAMENTE");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PROXIMAMENTE");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PROXIMAMENTE");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel23.Visible = true;
        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            panel24.Visible = false;
            panel2.Visible = true;
            panel13.Visible = true;
            SubMenuAjustes.Visible = false;
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox22_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
          
        }
    }
}
