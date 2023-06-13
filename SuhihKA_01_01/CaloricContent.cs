using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuhihKA_01_01
{
    class CaloricContent:Nutrition
    {
       
        
        public int P { get; set; }  //Калорийность

        private double Qp;

        public double Func_Qp  //Функция вычисления Qp
        {
            get { return Qp = (Q * 1.2) + (P * 7); }
           
        }

    }
}
