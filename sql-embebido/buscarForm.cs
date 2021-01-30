using sql_embebido.SQL;
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
    public partial class buscarForm : Form
    {
        conexionSQL conexion = new conexionSQL();
        List<Pokemon> registros = new List<Pokemon>();
        DataTable dt = new DataTable();
        DataRow row;

        public buscarForm()
        {
            InitializeComponent();
            dt.Columns.Add("ID");
            dt.Columns.Add("MOTE");
            dt.Columns.Add("NIVEL");
            dt.Columns.Add("ENTRENADOR");
            tablaPokemon.DataSource = dt;
            tablaPokemon.DefaultCellStyle.Font = new Font("Bahnschrift Condensed", 12, FontStyle.Regular);
            tablaPokemon.DefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 0, 0);
            llenarTabla("SELECT * FROM pokemon");
        }

        private void llenarTabla(string query)
        {
            dt.Rows.Clear();
            registros = conexion.realizarConsulta(query);
            for (int i = 0; i < registros.Count; i++)
            {
                row = dt.NewRow();

                row["ID"] = registros[i].getId();
                row["MOTE"] = registros[i].getMote();
                row["NIVEL"] = registros[i].getNivel();
                row["ENTRENADOR"] = registros[i].getEntrenador();

                dt.Rows.Add(row);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!tbId.Text.Equals(""))
            {
                llenarTabla("SELECT * FROM pokemon WHERE id = "+tbId.Text);
                limpiarControles();
            }
            else
            {
                llenarTabla("SELECT * FROM pokemon");
            }
        }

        private void limpiarControles()
        {
            tbId.Clear();
        }
    }
}
