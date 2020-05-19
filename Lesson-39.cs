// using System;


// namespace Lesson_39
// {
//     class Computer
//     {
//         // class --->consist of class + object -> class = (attributes or properties  +  methods--> (function or procedures))  and object is an instance of a typical class
//         //1- Attributes or properties 
//         private string brand;    // private call access modifiers
//         public double price;
//         public DateTime product;
//         public string color { get; set; }  // 


//         //Full properties to make encapsulation 
//         public string Newbrand
//         {
//             get
//             {
//                 return brand.ToUpper();
//             }
//             set
//             {
//                 brand= value;
//             }
            

//         }

//         // Constructors:
//         public Computer()  // can write it automatic by write (ctor)
//         {
//             //will use her this --> Mean الكلاس الحالى /// ممكن الاستغناء عنها 
//             this.brand="Undefined";
//             this.product=DateTime.Now;
//             this.price=00.00;

//         }
//         // another constructor
//         public Computer(string bbrand,double pprice,DateTime pproduct)
//         {
//             brand=bbrand;
//             price=pprice;
//             product=pproduct;

//         }
   





//         //##########################################################
//         //2-Methods  :-

//          //-1 procedures 

//         public void xx()  //method proceduers
//         {
//             Console.WriteLine("Running ....");

//         }

//         //-2 function mean will return something

//         public int yy()  // method function 
//         {
//             return 1;
//         }


//     }
// }