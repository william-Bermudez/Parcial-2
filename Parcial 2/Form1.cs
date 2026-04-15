using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_2
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();


        }
        public class vehiculo
        {
            public string marca { get; set; }
            public string modelo { get; set; }
            public double precio { get; set; }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                DataGridViewRow fila = dttodo.Rows[e.RowIndex];

                string marca = fila.Cells[0].Value.ToString();
                string modelo = fila.Cells[1].Value.ToString();
                string precio = fila.Cells[2].Value.ToString();

                MessageBox.Show(
                    "Resumen del vehículo:\n\n" +
                    "Marca: " + marca + "\n" +
                    "Modelo: " + modelo + "\n" +
                    "Precio: $" + precio,
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                }


            }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textmarca.Text) && !string.IsNullOrEmpty(textmodelo.Text) &&  !string.IsNullOrEmpty(textprecio.Text))
            {
                double precio = Convert.ToDouble(textprecio.Text);
               
                dttodo.Rows.Add(textmarca.Text, textmodelo.Text, textprecio.Text);
                textmodelo.Clear();
                textprecio.Clear();
                textmarca.Clear();
               
            }
            else
            {
                MessageBox.Show("Por favor complete los campos.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void form1_Load(object sender, EventArgs e)
        {

        }
    }
}
