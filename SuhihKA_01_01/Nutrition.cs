using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuhihKA_01_01
{
    class Nutrition
    {
        public string NameProduct { get; set; }  //Имя продукта
        public double AmountOfProtein { get; set; }  //Количество белка
        public double AmountOfCarbohydrates { get; set; }  //Количество углеводов

        public double Q
        { 
            get
            {
                
                return (AmountOfProtein * 4)+ (AmountOfCarbohydrates * 4);
            }
        }

    }
}
