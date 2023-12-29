using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_oop_calisma
{
    internal class Car
    {
        // Class'ın özellikleri tanımladık.
        public string marka;
        public string model;
        public int engine;
        public int km;


        


        public Car(string amarka,string amodel,int aengine,int akm) //Yapıcı metod
        {
            marka=amarka;
            model=amodel;
            engine = aengine;
            km=akm;
        }
    }
}
