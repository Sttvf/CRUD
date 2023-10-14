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
    public partial class frmNuevaCita : Form
    {
        List<clsCita> cts;
        int id = 0;

        public frmNuevaCita(List<clsCita> citas)
        {
            InitializeComponent();
            cts = citas;
            id = int.Parse(citas[citas.Count-1].ID.ToString())+1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            clsCita cita = new clsCita() { ID = id, Folio = "00"+id, Cliente = textBox1.Text.ToString(), FechaCita = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day) };
            cts.Add(cita);
            this.Close();
        }
    }
}
