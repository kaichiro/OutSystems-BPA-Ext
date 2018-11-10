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
            ctrl.CreateBPA_Cabecalho(DateTime.Now, 5,1);

            ctrl.AddBPA_Individualizado("31", DateTime.Now.AddMinutes(3), "357", "1-1/8", 1);
            ctrl.AddBPA_Individualizado("32", DateTime.Now.AddMinutes(3), "159", "11119", 1);

            Console.Out.WriteLine(ctrl.GetFullBPA());
        }
    }
}
