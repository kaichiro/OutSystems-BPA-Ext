using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OutSystems.NssBPA
{
    public class BPA_Individualizado
    {
        public BPA_Individualizado() { }

        public BPA_Individualizado(string prd_cnes_02, DateTime prd_cmp_03, string prd_cnsmed_04)
        {
            Prd_cnes_02 = prd_cnes_02 ?? throw new ArgumentNullException(nameof(prd_cnes_02));
            Prd_cmp_03 = prd_cmp_03;
            Prd_cnsmed_04 = prd_cnsmed_04 ?? throw new ArgumentNullException(nameof(prd_cnsmed_04));
        }

        private string Prd_cnes_02 { get; set; }
        private DateTime Prd_cmp_03 { get; set; }
        private string Prd_cnsmed_04 { get; set; }

        public string GetIndividualizadoLine()
        {
            return "03"
                + Prd_cnes_02
                + Prd_cmp_03.ToString()
                + Prd_cnsmed_04
                ;
        }
    }
}