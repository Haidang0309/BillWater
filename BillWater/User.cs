using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillWater
{
    public class User
    {
        public string Yourname { get; set; }
        public int Phonenumber { get; set; }
        public string Customtype { get; set; }
        public int Amountofwaterthismonth { get; set; }
        public int Amountofwaterlastmonth { get; set; }
        public int Amountofwaterconsumed {  get; set; }
        public double Totalbill {  get; set; }

        public User()
        {

        }

        public User(string name, int Phone, string custom, int Amountofwaterthismonth, int Amountofwaterlastmonth, int Amountofwaterconsumed, double Totalbill)
        {
            Yourname = name;
            Phonenumber = Phone;
            Customtype = custom;
            this.Amountofwaterthismonth = Amountofwaterthismonth;
            this.Amountofwaterlastmonth = Amountofwaterlastmonth;
            this.Amountofwaterconsumed = Amountofwaterconsumed;
            this.Totalbill = Totalbill;
        }
    }
}
