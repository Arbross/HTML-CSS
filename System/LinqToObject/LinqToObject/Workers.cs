using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObject
{
    class Worker
    {
        public string Name { get; set; }
        public ushort Age { get; set; }
        public int Salary { get; set; }
        public string Departament { get; set; } = "Main";
        public override string ToString()
        {
            return $"{this.GetType().Name, -14} {Name, -10} {Age, -5} {Departament, -15} {Salary, -12}";
        }
    }
    class Developer : Worker
    {
        public List<string> Languages { get; set; }
        public Developer() => Departament = "IT";
        public override string ToString()
        {
            return $"{base.ToString()}Langs : {String.Join(",", Languages)}";
        }
    }
    class QA : Worker
    {
        public string MethodTest { get; set; }
        public QA() => Departament = "IT";
        public override string ToString()
        {
            return $"{base.ToString()}MethodTest : {MethodTest}";
        }
    }
    class DevOps : Worker
    {
        public List<string> TechStack { get; set; }
        public DevOps() => Departament = "IT";
        public override string ToString()
        {
            return $"{base.ToString()}TechStack : {String.Join(",", TechStack)}";
        }
    }
    class Accouter : Worker
    {
        public Accouter() => Departament = "Economics";
    }
    //class Cleaner : Worker
    //{
    //    public string Room { get; set; }
    //    public Cleaner() => Departament = "Clean";
    //}
}
