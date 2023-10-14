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
    public partial class Form2 : Form
    {
        List<clsCita> cts;

        public Form2(List<clsCita> citas)
        {
            InitializeComponent();
            cts = citas;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cts.Count; i++)
            {
                if (cts[i].Folio == txtFolio.Text)
                {
                    cts.Find(cita => cts[i].Folio == txtFolio.Text).Folio = txtFolio.Text;
                    cts.Find(cita => cts[i].Folio == txtFolio.Text).FechaCita = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
                    cts.Find(cita => cts[i].Folio == txtFolio.Text).Cliente = txtCliente.Text;
                }
            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
