using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerceApp.Models
{
    public class Products
    {
        /*
         * private sadece class
         * protected başka bir class miras aldığında erişebilir
         * internal heryerden aynı proje içerisinde sa
         * protected internal aynı proje heryerden, ama proje dışındandaa miras alınırsa
         * public heryerden
         * private protected
         */

        //Proporties
        public int ProductID { get; set; }
        public String ProductName { get; set; }

        public int SuplierID { get; set; }

        public int CategoryID { get; set; }

        public int UnitPrice { get; set; }

        public int UnitsInStock { get; set; }



        /* 
        //Full Property
        //OOP de buraya encapsulation deniyor
        //field
        private int myVar;
        //property
        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }*/

    }
}