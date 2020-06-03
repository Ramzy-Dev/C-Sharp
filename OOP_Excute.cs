// using System;
// namespace Lesson_39  
// {
//     class prog
//     {
//         static Computer mycom = new Computer();  // Called  object  Mean That is an instance of a typical class 
//         static void Main()
//         {
//             mycom.Newbrand = "Mac";
//             mycom.price = 6000;
//             mycom.product = new DateTime(2020, 10, 30); // لو عايز اخصص وقت معين
//             mycom.color = "silver";

//             mycom.multi();
//             // for printing
//             mycom.addition();
//             int ss = mycom.addition();
//             Console.WriteLine(mycom.Newbrand);

//             // can make another object  for explain constructor
//             Computer cons=new Computer();
//             Console.WriteLine(cons.Newbrand);

//             Computer const2=new Computer ("Macmac Mac" , 33.44 ,new DateTime(2020,12,12));
//             Console.WriteLine($"my mac called {const2.Newbrand} \n Price is {const2.price} ");

//             //inheritance............
//             Inheritanc_Programmer jj=new Inheritanc_Programmer("Lololeen","alkhobar",3500.20);
//             jj.inheritanc_adress="Saudi arabia-alkhobar";
//             jj.ProgrammingLanguage("C-sharp");
          





//         }
//     }

//         class OOP
//     {
//         // first declare properties,fields,attributes
//         public string name;
//         public string color { get; set; }
//         private string tall { get; set; }

//         //encapsulation for accress modifier private --- tall
//         public string _tall
//         {
//             get
//             {
//                 return tall = "good"; 
//             }
//             set
//             {
//                 tall = value;
//             }
//         }

//         //constructors to assign values
//         public OOP()
//         {
//             this.name = "leen";
//             this.color = "yellow yellow ";  // ok
//             this.tall = "very tall";  // not make overwrite
//         }

//         //----------------------------------------------------

//         // another way for constructor------  in this case must creat another constructor in Drived class (child)
//         // look chang in line 64  and  75
//         //public OOP(string nname, string ccolor,string ttall)
//         //{
//         //    this.name = nname;
//         //    this.color = ccolor;
//         //    this.tall = ttall;
//         //}


//         // methods
//         //-------------procedures--------------//ok
//         public void multi(int x, int y)  
//         {
//             int z = x * y;
//             Console.WriteLine($"Multiplication is {z} ");
//         }

//         //-------------- function ----------------//ok
//         public int add(int a, int b)
//         {
//             return a + b;
//         }



//     }






// }
