// using System;


// namespace Lesson_39
// {
//     class Computer
//     {
//         // class --->consist of class + object -> class = (attributes or properties  +  methods--> (function or procedures))  and object is an instance of a typical class
//         //1- Attributes or properties 

//         //Generally, in object-oriented programming languages like c# you need to define fields as private,
//         //and then use properties to access their values in a public way with get and set accessors.
//         //properties can contain one or two code blocks called accessors and those are called a get accessor and set accessor. 


//         private string brand;    // private-> call access modifiers  // that statement called  "field" and we access their values in a public way with get and set accessors Using prpperties. 
//         public double price;
//         public DateTime product;
//         public string color { get; set; }  // auto prpoerties


//         //Full properties to make encapsulation 
//         public string Newbrand
//         {
//             get
//             {
//                 return brand.ToUpper();  // return value
//             }
//             set
//             {
//                 brand= value;  // assign value 
//             }
            

//         }

//         // Constructors:------------------

//         public Computer()  // can write it automatic by write (ctor)
//         // when creat constructor must be public and must take same name for class 
//            we use it to define prperty or attributes in class by many methods 
//            we use constructor to save time with short code

//         {
//          // this --> Mean الكلاس الحالى /// وممكن الاستغناء عنها 
//             this.brand="Undefined";
//             this.product=DateTime.Now;  // if i want time now
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

//         public void multi()  //method proceduers
//         {
//             int x=30 , y=40;
//             Console.WriteLine($"Multiplication is {x*y} ");

//         }

//         //-2 function mean will return something

//         public int addition()  // method function 
//         {
//             int a=20 , b=190;
//             return a+b;
//         }


//     }

//     //   Lesson  41------ Inherirance--------------------------


//     //Base Class- main class  (parent)
//     class Inheritanc_Person
//     {
//         public string inheritanc_name{get;set;}  // property
//         public string inheritanc_adress {get;set;}
//         public byte inheritanc_age {get;set;}
//         public string inheritanc_kind {get;set;}
        
           
//          public void inheritanc_Speak()
//          {
//              Console.WriteLine("I speak .....");

//          }
//          public void inheritanc_Work()
//          {
//              Console.WriteLine("I work ....");

//          }

//          //constructor   /// لازم يتعمل لها وراثه لحالها 

//         public Inheritanc_Person(string kind , string adress)
//         {
//             this.inheritanc_kind=kind;
//             this.inheritanc_adress=adress;
//         }

         
//     }
//     //Drived Class (child)
//     // We will Inherite from Person 
//     class Inheritanc_Programmer:Inheritanc_Person  // هنا تم نقل كل الخصائص وممكن ايضا اضافه خصائص جديده كما سيحدث الان
//     {
//         public double inheritanc_salary{get;set;}  // اضافه جديده

//         public void ProgrammingLanguage(string language)
//         {
//             Console.WriteLine("I Programme with "+ language );
//         }

//         // inheritance for constructor
//         public Inheritanc_Programmer (string name ,string adress,double salary) : base(name,adress)
//         {
//            this.inheritanc_salary=salary;

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

//     //-------------lesson     41---------------------
//     class Excute : OOP    // inheritance
//     {
//         public string hand { get; set; }  // can put here as i like (add more)
//         //public Excute(string nname, string ccolor, string ttall) :base(nname,ccolor,ttall )
//         //{

//         //}

//         static void Main()
//         {


//             // object--------------
//             //var exc_OOP = new OOP();
//             //var XXX = new Excute("fathiya","fucken black","short");
//             var XXX = new Excute();

//             // overwrite 

//             XXX.name = "Hamza leen";  //ok
//             //-------------------------

//             XXX.hand = "very soft";
//             // ------  call function -------
//             XXX.multi(100, 2);
//             //------- print ------------
//             Console.WriteLine(XXX.name);
//             Console.WriteLine(XXX.color);
//             Console.WriteLine(XXX._tall);
//             //------call function ------------
//             Console.WriteLine(XXX.add(22, 100));
//             Console.WriteLine(XXX.hand);

//         }
//     }
// }