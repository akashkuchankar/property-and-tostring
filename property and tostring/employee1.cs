using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property_and_tostring
{
    internal class employee1
    {
        private int id;
        private double salary;
        private string name;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public override string ToString()
        {
            return $"{id} {salary} {name}";
        }
    }
}
