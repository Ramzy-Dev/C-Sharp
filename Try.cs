using System;
namespace Encapsulation
{
    class Encap
    {
        private string name;
        public string color;  //field
        //constructors ..........

        //full property
        public string Name  
        {
            get
            {
                return name;
            }
            set
            {
                if(value=="Leen")
                {
                    name=value;
                }
            }
        }
        public Encap()
        {
            color="green";
            
        }

    }
    class Printing
    {
        static void Main()
        {
            Encap kk=new Encap();
            kk.Name="Leen";
            //kk.color="yellow";
            
            Console.WriteLine(kk.Name+"\n"+kk.color);
        }
    }

}