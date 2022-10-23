using System.Drawing;
using System.Runtime.Intrinsics.Arm;

namespace Trabajo
{
    public partial class Form1 : Form
    {
        Depreciacion d = new Depreciacion();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (rbLR.Checked) // si el boton linea recta esta activo.....
            {
                double ValorActivo = Convert.ToDouble(this.txtValorActivo.Text);
                double ValorDesecho = Convert.ToDouble(this.txtValorDesecho.Text);
                int VidaUtil = Convert.ToInt32(this.txtVidaUtil.Text);
                double x = 0;
                if (rbLR.Checked == true)
                {
                    int cont = 0;
                    foreach (Depreciacion depre in d.Tabla(ValorActivo, ValorDesecho, VidaUtil))
                    {
                        if (cont == 0)
                        {
                            this.DtDepre.Rows.Insert(cont, depre.Fecha, "",
                                                          "", Math.Round(depre.ValorActivo, 2));
                            cont++;
                            continue;
                        }
                        this.DtDepre.Rows.Insert(cont, depre.Fecha, depre.Resul,
                                                      Math.Round(depre.DepreAcum + (depre.Resul * (cont - 1)), 2), Math.Round(depre.ValorActivo - ((depre.DepreAcum + (depre.Resul * (cont - 1)) * (cont - 1))), 2));


                        cont++;
                    }
                }
            }else if (rbSuma.Checked) // si el boton suma estq activo...
            {
                double ValorActivo = Convert.ToDouble(this.txtValorActivo.Text);
                double ValorDesecho = Convert.ToDouble(this.txtValorDesecho.Text);
                int VidaUtil = Convert.ToInt32(this.txtVidaUtil.Text);
                double x = 0;
                if (rbSuma.Checked)
                {
                    int cont = 0;
                    foreach (Depreciacion depre in d.tablaSuma(ValorActivo, ValorDesecho, VidaUtil))
                    {
                        if (cont == 0)
                        {
                            this.DtDepre.Rows.Insert(cont, depre.Fecha, "",
                                                          "", Math.Round(depre.ValorActivo, 2));
                            cont++;
                            continue;
                        }

                        this.DtDepre.Rows.Insert(cont, depre.Fecha, depre.Resul,
                                                      Math.Round(depre.DepreAcum , 2), Math.Round(depre.ValorActivo - depre.DepreAcum, 2));


                        cont++;
                    }










                }
            }




        }

        private void txtValorActivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtValorDesecho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtVidaUtil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void rbLR_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}