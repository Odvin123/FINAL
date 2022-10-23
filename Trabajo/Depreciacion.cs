using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo
{
   public class Depreciacion
    {
        
        public DateTime Fecha { get; set; }
        public double ValorActivo { get; set; }
        public double ValorDesecho{ get; set; }
        public int VidaUtil { get; set; }
        public double DepreAcum { get; set; }
        public double Resul { get; set; }
        public double ValorNeto { get; set; }



        public double CalcularLineaRecta(double ValorActivo,
                                    double ValorDesecho,
                                     int VidaUtil)
        { 
        
          //Resul= (ValorActivo-ValorDesecho)/VidaUtil;
            return Math.Round((ValorActivo - ValorDesecho) / VidaUtil, 2);


            //return Resul;
        }

        public double CalcularSuma(double ValorActivo,
                                    double ValorDesecho,
                                     int VidaUtil,
                                     int periodo)
        {

            int Sum = 0;
            //for (int i = 1; i <= years; i++)
            //{
            //    Sum += (i * (i + 1)) / 2;
            //}

            for (int i = 0; i <= VidaUtil; i++)
            {
                Sum += i;
            }

            //return Math.Round(((years - period + 1) / Sum) * (Value - Residual), 2);
            double resul = ((double)(VidaUtil - periodo + 1) / (double)Sum) * (ValorActivo - ValorDesecho); //466    233     0
            return Math.Round(resul, 2);
        }

        public List<Depreciacion> Tabla(double ValorActivo,
                                    double ValorDesecho,
                                     int VidaUtil)
        {

            double Resul;
           Resul = CalcularLineaRecta(ValorActivo,ValorDesecho,VidaUtil);

            List<Depreciacion> d = new List<Depreciacion>();

            double DA = Resul ;
            for (int i = 1; i <= VidaUtil; i++)
            {
                Depreciacion  D = new Depreciacion();
                DateTime Fecha = DateTime.Now;
                D.Fecha = Fecha.AddYears(i);
                D.Resul = Resul;
               D.ValorActivo = ValorActivo;
                D.ValorDesecho = ValorDesecho;
                D.VidaUtil = VidaUtil;
                D.DepreAcum = Resul ;
                //D.ValorNeto = ValorActivo - D.Resul;

                d.Add(D);

            }

            return d;
        }

        public List<Depreciacion> tablaSuma(double ValorActivo,
                                    double ValorDesecho,
                                     int VidaUtil)
        {

            //double Resul;
            //Resul = CalcularSuma(ValorActivo, ValorDesecho, VidaUtil, n);

            List<Depreciacion> d = new List<Depreciacion>();

            double DA = 0;
            for (int i = 0; i <= VidaUtil; i++)
            {
                Depreciacion D = new Depreciacion();
                DateTime Fecha = DateTime.Now;
                D.Fecha = Fecha.AddYears(i);
                D.Resul = CalcularSuma(ValorActivo, ValorDesecho, VidaUtil, i);
                D.ValorActivo = ValorActivo;
                D.ValorDesecho = ValorDesecho;
                D.VidaUtil = VidaUtil;
                D.DepreAcum = (CalcularSuma(ValorActivo, ValorDesecho, VidaUtil, i)+DA);
                //D.ValorNeto = ValorActivo - D.Resul;

                d.Add(D);
                if (i == 0) continue;
                DA += CalcularSuma(ValorActivo, ValorDesecho, VidaUtil, i);

            }

            return d;
        }

}
}
