using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appListas
{
    public partial class Form1 : Form
    {
        List<clsCita> citas = new List<clsCita>() {
            new clsCita() { ID = 1, Folio = "001", Cliente = "Néstor León", FechaCita = new DateTime(2023, 10, 10) },
            new clsCita() { ID = 2, Folio = "002", Cliente = "Javier Lopez", FechaCita = new DateTime(2023, 11, 10) },
            new clsCita() { ID = 3, Folio = "003", Cliente = "Juan Perez", FechaCita = new DateTime(2022, 02, 22) },
        };

        

        public Form1()
        {
            InitializeComponent();

            act();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = citas.FindAll(
                c => c.Cliente.Contains(txtBusquedaCliente.Text)
                     &
                     (
                        dtpBusquedaFecha.Checked ? 
                                c.FechaCita.Date == dtpBusquedaFecha.Value.Date 
                                : true
                     )
                     &
                     (
                        c.Folio.Contains(textBox1.Text)
                     )
                );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNuevaCita Agregar = new frmNuevaCita(citas);
            Agregar.Show();
            act();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            citas.RemoveAt(dataGridView1.SelectedRows[0].Index);
            act();
        }

        public void act()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = citas;
            label4.Text = "Cantidad de registros: " + citas.Count;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            act();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 formModificar = new Form2(citas);
            formModificar.Show();
            act();
        }
    }
}
