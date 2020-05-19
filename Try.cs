using System;
namespace Test
{
    class Leen
    {
        private string name;
        public double price;
        public string color{get;set;}  //auto prpperties
        public bool isnew =true;
        public DateTime manufacture;
        public string newname
        {
            get
            {
                return name.ToUpper();
            }
            set
            {
                name=value;
            }
        }
        public Leen ()
        {
            this.name="Leen Reda";
            this.price=600.5;
            this.color="Silver";
            this.isnew=true;
            this.manufacture=DateTime.Now;  // لز عايز الوقت الحالى 
        }
        public Leen (double pprice,string ccolor , string nname)
        {
            price=pprice;
            color=ccolor;
            name=nname;

        }

        public void multi()
        {
            int x=30 , y=40;
            Console.WriteLine($"Multiplication is {x*y} ");
        }

        public int addition()
        {
            int a=20 , b=190;
            return a+b;
        }
    }
}