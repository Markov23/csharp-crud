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
    public partial class actualizarForm : Form
    {
        conexionSQL conexion = new conexionSQL();
        List<Pokemon> registros = new List<Pokemon>();
        DataTable dt = new DataTable();
        DataRow row;
        private int id = 0;
        private bool buscado = false;

        public actualizarForm()
        {
            InitializeComponent();
            dt.Columns.Add("ID");
            dt.Columns.Add("MOTE");
            dt.Columns.Add("NIVEL");
            dt.Columns.Add("ENTRENADOR");
            tablaPokemon.DataSource = dt;
            tablaPokemon.DefaultCellStyle.Font = new Font("Bahnschrift Condensed", 12, FontStyle.Regular);
            tablaPokemon.DefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 0, 0);
            llenarTabla();
        }

        private void llenarTabla()
        {
            dt.Rows.Clear();
            registros = conexion.realizarConsulta("SELECT * FROM pokemon");
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
            if (!tbEntrenador.Text.Equals("") && !tbMote.Text.Equals("") && !tbNivel.Text.Equals(""))
            {
                if(buscado == true)
                {
                    string query = "UPDATE pokemon SET mote = '" + tbMote.Text + "', nivel = " + tbNivel.Text + ", entrenador = " + tbEntrenador.Text + " WHERE id= " + id;
                    string resultado = conexion.realizarOperación(query);

                    if (resultado.Equals("1"))
                    {
                        limpiarControles();
                        llenarTabla();
                    }
                    else
                    {
                        MessageBox.Show("Por favor, verifique los datos de entrada");
                        Console.WriteLine(resultado);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un registro");
                }
                
            }
            else
            {
                MessageBox.Show("Por favor, rellene todos los campos");
            }
        }

        private void limpiarControles()
        {
            tbMote.Clear();
            tbNivel.Clear();
            tbEntrenador.Clear();
        }

        private void tablaPokemon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = dt.Rows[tablaPokemon.CurrentRow.Index];

            buscado = true;
            id = Int32.Parse(row["ID"].ToString());

            tbMote.Text = row["MOTE"].ToString();
            tbNivel.Text = row["NIVEL"].ToString();
            tbEntrenador.Text = row["ENTRENADOR"].ToString();
        }
    }
}
