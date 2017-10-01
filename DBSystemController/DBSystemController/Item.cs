using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSystemController
{
    public class Item
    {
        public int id_Person { get; set; }

        public string Firstname { get; set; }

        public string Surname { get; set; }

        public string FullInfo
        {
            get
            {
                return $"{ Firstname } { Surname }";
            }

        }

    }
}
