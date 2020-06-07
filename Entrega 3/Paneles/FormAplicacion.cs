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
    public partial class FormAplicacion : Form
    {
        public FormAplicacion()
        {
            InitializeComponent();
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
    }
}
