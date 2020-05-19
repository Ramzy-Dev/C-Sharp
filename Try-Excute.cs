using System;
namespace Test
{
    class EXX
    {
        static Leen newobjct=new Leen();
        static void Main()
        {
            newobjct.newname="Hamza";
            newobjct.manufacture=new DateTime(2020,12,3);
            newobjct.multi();  // just call 
            newobjct.addition();
            int add=newobjct.addition();
            Console.WriteLine("My son name is {0} \n and his date is {1} ",newobjct.newname , newobjct.manufacture );
            Console.WriteLine("Total addtion is {0}",add);

            Leen Const1=new Leen();
            Console.WriteLine("Name constructor one is " + Const1.newname);

            Leen Const2=new Leen (399.22,"Silver","Hadeer");
            Console.WriteLine("Constructor two is {0} and color is {1}  ",Const2.newname,Const2.color);
            
            

        }

    }
}