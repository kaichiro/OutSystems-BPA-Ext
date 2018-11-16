using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OutSystems.NssBPA
{
    public class BPA_Individualizado
    {
        public BPA_Individualizado(string prd_cnes_02, DateTime prd_cmp_03, string prd_cnsmed_04, string prd_pa_09, int prd_qt_15)
        {
            Prd_cnes_02 = prd_cnes_02 ?? throw new ArgumentNullException(nameof(prd_cnes_02));
            Prd_cmp_03 = prd_cmp_03;
            Prd_cnsmed_04 = prd_cnsmed_04 ?? throw new ArgumentNullException(nameof(prd_cnsmed_04));
            Prd_pa_09 = prd_pa_09 ?? throw new ArgumentNullException(nameof(prd_pa_09));
            Prd_qt_15 = prd_qt_15;
        }

        private string Prd_cnes_02 { get; set; }
        private DateTime Prd_cmp_03 { get; set; }
        private string Prd_cnsmed_04 { get; set; }

        private string Prd_pa_09 { get; set; }
        private int Prd_qt_15 { get; set; }

        public long Get_09_15() => Prd_qt_15 + long.Parse("0" + BPA_Utils.RetornApenasNumeros(Prd_pa_09));

        public string GetIndividualizadoLine()
        {
            string retorno = "03"
                + Prd_cnes_02
                + BPA_Utils.UPadLeft(Prd_cmp_03.ToString(), 7, BPA_Utils.Tipo.ZERO)
                + $"{Prd_cnsmed_04:yyyyMM}"

                + BPA_Utils.UPadLeft(Prd_pa_09.ToString(), 10, BPA_Utils.Tipo.ZERO)
                + BPA_Utils.UPadLeft(Prd_qt_15.ToString(), 6, BPA_Utils.Tipo.ZERO)
                ;
            retorno = retorno.Replace("\r\n", "");
            return retorno + string.Format("({0})", retorno.Length);
        }
    }
}