using System;
namespace Lesson_39  
{
    class prog
    {
        static Computer mycom = new Computer();  // Called  object  Mean That is an instance of a typical class 
        static void Main()
        {
            mycom.Newbrand = "Mac";
            mycom.price = 6000;
            mycom.product = new DateTime(2020, 10, 30);
            mycom.color = "silver";

            mycom.xx();
            // for printing
            mycom.yy();
            int ss = mycom.yy();
            Console.WriteLine(mycom.Newbrand);



       

        }
    }


}
