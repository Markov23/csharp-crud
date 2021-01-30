using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sql_embebido
{
    public partial class Form1 : Form
    {
        Form ventanaInterior;

        public Form1()
        {
            InitializeComponent();
            this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
        }

        private void pbDashboard_Click(object sender, EventArgs e)
        {
            if(panelContenidoSidebar.Width == 220)
            {
                panelContenidoSidebar.Visible = false;
                panelContenidoSidebar.Width = 50;
                panelSidebar.Width = 70;
                lineaSidebar.Width = 30;
                transitionSidebarClose.Show(panelContenidoSidebar);
            }
            else
            {
                panelContenidoSidebar.Visible = false;
                panelContenidoSidebar.Width = 220;
                panelSidebar.Width = 240;
                lineaSidebar.Width = 200;
                transitionSidebarOpen.Show(panelContenidoSidebar);
            }
        }

        private void pbRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            pbMaximizar.Visible = true;
            pbRestaurar.Visible = false;
            panelContenido.Refresh();
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            panelContenido.Refresh();
        }

        private void pbMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            pbMaximizar.Visible = false;
            pbRestaurar.Visible = true;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();
            ventanaInterior = new agregarForm();
            ventanaInterior.TopLevel = false;
            ventanaInterior.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(ventanaInterior);
            ventanaInterior.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();
            ventanaInterior = new buscarForm();
            ventanaInterior.TopLevel = false;
            ventanaInterior.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(ventanaInterior);
            ventanaInterior.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();
            ventanaInterior = new actualizarForm();
            ventanaInterior.TopLevel = false;
            ventanaInterior.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(ventanaInterior);
            ventanaInterior.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();
            ventanaInterior = new eliminarForm();
            ventanaInterior.TopLevel = false;
            ventanaInterior.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(ventanaInterior);
            ventanaInterior.Show();
        }
    }
}
