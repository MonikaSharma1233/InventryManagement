using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventryManagement
{
    public class Details
    {
        public List<TypeOfRice> typeOfRice;//its a variable of typeofrice classname datatype
        public List<TypeOfWheat> typeOfWheat;//its a variable of typeofwheat classnamedatatype
        public List<TypeOfPulse> typeOfPulse;//its a variable of typeofpulse classnamedatatype
    }
    public class TypeOfRice
    {
        public string name;
        public int weight;
        public int price;
    }
    public class TypeOfWheat
    {
        public string name;
        public int weight;
        public int price;
    }
    public class TypeOfPulse
    {
        public string name;
        public int weight;
        public int price;
    }
}
