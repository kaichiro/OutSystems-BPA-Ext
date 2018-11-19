using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OutSystems.NssBPA;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            BPA_Controller ctrl = new BPA_Controller();
            ctrl.CreateBPA_Cabecalho(DateTime.Now, "resp 07", "SCMR", "3216549870", "Santa Casa de Misericó´rdia", "M", 300);

            for (int x_ = 0; x_ < 301; x_++)
            {
                ctrl.AddBPA_Individualizado("", DateTime.Now, "", "", DateTime.Now, "", "", "M", "", "", 1, "", "", "", "Pac%£Ýente çáâ_", DateTime.Now.AddYears(-26), "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            }

            string FileName = string.Format("{0:yyyy.MM.dd-HH.mm.ss}.txt", DateTime.Now);
            string FullFileName = FileName;

            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(FullFileName, true))
            {
                sw.WriteLine(ctrl.GetFullBPA());
                sw.Close();
                System.Diagnostics.Process.Start(".");
            }

        }
    }
}
