using System;  // called namespace // that mean i will use namespace called "System"  //تسمى مكتبه  library..................//هى من الاخر مكتبه عشان هاستخدم جواها حاجات زى كونسول
using static System.Console; //console  فى حاله لو لا نريد كتابه   <----
using static System.Convert; //convert  فى حاله لو لا نريد كتابه   <----
class Preface_For_Programming
{
    //.net framework class library (FCL) --- such as system ,system.security.... مكتبات الدوت نت 
    //what .Net    (DLL) هى بيئه للتطوير من قبل المبرمج والتشغيل من قبل العميل ولو نلاحظ اوقات لما نشغل برنامج او لعبه فى اوقات معينه يطلبه ملف اسمه دوت نت وده ملف اللى اتعلم به التطبيق عشان يشتغل وهو بيكون دى ال الى 
    //How the .Net faramewor works??
             /*
              *Source Code اول حاجه كتابه الكود
              *Microsoft Intermediate Language Compiler (MSIL)    ثم بعد ذلك يتم  تحويله  الى لغه وسيطه عن طريق  
              *JIT (Just In Time) Compiler   -------Machine Language    ثم يتم تحويل اللغه الوسيطه الى لغه الاله 
              * Command Lnagugae Runtime  ----- Application    ثم يتم تحويل لغه الاله الى تطبيق  
              */

        /*
         *هل ممكن ابرمج لمبرمج ؟؟
         *نعم وذلك لان المشروع عباره عن نيم سبيس + كلاسيس وانا ممكن اعمل مشروع دى ال ال واعطى ذلك للمبرمج للتكمله مثلا
         */

         /*
          * لو عايز اشوف الملف التنفيذى للبرنامج كيف ؟
          * Folder bin   ----- Folder Debug ---- file.exe 
          */

    // استحاله تلاقى ميثود مش داخل كلاس قاعده عامه 



            //Solution Explorer عند انشاء المشروع بالبدايه خالص يتم تكوين شئ اسمه 
            //ماذا يحتوى اذن ؟؟؟ 
            //1- solution ودى بتعرفنى كام مشروع موجود وممكن عمل مشروع جديد اخر منه
            //2-solution ماذا يحتوى ؟؟؟
            //يحتوى على  اسم المشروع ويكون هذا هو اسم نيم سبيس اتوماتيك  الذى تعمل عمله من البدايه وبداخله عدد 2 ملف وهم 
            //dependencies ويتحوى على مكتبات كتير تسهل التعامل مع الطابعات ووووو حيث تتم اوتوماتيك 
            //programme.cs وهذا هو ملف المشروع وبيتعمل كلاس ويكون بنفس الاسم اتوماتيك 


//---------
// Whats the different between Coder and Developer 
   /*
    *Coder بس بيكتب الكود وليس له علاقه بدوره البرنامج
    *Developer بيعمل كل شئ
    */


//Software Life Cycle
  /*
   *Gathering Requirements (Planning) شخص يذهب للعميل لمعرفه متطلباته وكتابتها
   *Analysis تحليل هذه المعطيات وتحيلها وارجع للعميل تانى اذا فى شئ 
   *Design  كيف يتم عمل هذه المعطيات واصصمم شاشات واعرضها على العميل مره اخرى للتاكد انه طلبه 
   *Development اى كتابه الكود البرمجى 
   *Testing التاكد من الكود 
   *Deployment اقوم بتنزل التطبيق عند العميل 
   *Maintenance اى اعطى للعميل فتره عام ضمان مثلا تجنبا لظهور اى مشاكل 
   */
//Testing .....
   /*
    *Unit Test اى عمل اختبار لجزئيه صغيره فى التطبيق
    *Functional Test  اى اختبار الدوال الحسابيه هل تعمل صحيحه ام لا
    *Performance Test اختبار السرعه
    *Stress Test اختبار لو استخدم التطبيق اكثر من مستخدم 
    *User Acceptance Test اختبار وموافق العميل نفسه صاحب التطبيق
    */

// diffrent betwwen A compiler   and  Interpreter
   /*
    *Machine Language كلهم مترجمين الى  
    *A compiler  يترجم كل شئ مره واحده ولو فى مشكله يقوم بعرضه مره واحده 
    *Interpreter  يقوم بالترجمه سطر سطر واذا فى مشكله لا يكمل
    *ممكن كتابه الكود فى اى مكان حتى لو ورد مثلا بس عند الحفظ نكتب الامتداد سى اس 
    *
    */

//------------------------------------------------------------
//الكمبيوتر لا يفهم الا رقمين صفر و  واحد
// for Understanding it open link  ......
//https://medium.com/@LindaVivah/learn-how-to-read-binary-in-5-minutes-dac1feb991e
//http://khaled-pcinfo.blogspot.com/2012/09/0-1.html
//computer just understand 0,1 that called binary 
//0 mean off   1   maen  on  حيث تتم هذه العمليه عن طريق اطفاء الكهرباء او تشغيلها عن طريق الترانستور الذى داخل المعالج ومنه ملايين
//decemal men  0,1,2,3,4,5,6,7,8,9
// what if i want write characters ?  by using ASCII convert it 
//bit=binary digit
//1 bit=0 or 1
//byte = 8 bit    (10001101) that 8 bit and all called byte 
//---------------------------------------------------
// fisrt language called   (((assembly code)))    and was very difficult وتستخدم فى الهندسه العكسيه الان للاختراق
// then low level language like c  and  C++  work direct with machin called also native language
//the high level languge that languages use compiler to translat to machine language
//IDE (integrated development environment) insid it compiler     وهو المسئول عن تنفيد البرنامح   CLR   بيئه تطوير متكامله  ويحتوى على مكتبات و 
//IDE   --->>  Write Code --> compiler-->bytecode->CLR-->native code
//لو فى اى خطا فى كتابه الكود بيظهر ان فى خطا ولذلك لان داخله كومبيلر
// syntax هى قواعد بيتم استخدامها لتكون مفهومه للكمبيوتر والاله
// namespace system use to organize code and is collection of classes,interfaces,structs,enums,delegates
// OOP كل شئ فى السى شارب عباره عن اوبجت لانها 
//How Memory works?? by process called "garbage collection .  ---- "ويتاكد ايضا ان لا يوجد فاريبال محجوز بدون فائده  memory heap  بتحديد الاماكن وحجزها ويسمى هذا الجزء  CLR  حيث يقوم  
//Variable  or  object  --> حجز مكان فى الذاكره --->who  do that ?? CLR automatic   ->> ثم تحرير المحجوز   ---> that proceess called garbage collection 
//native language  (c   c++)
//managed language (csharp   java)
//strongly typed  ==  case sensitive 
// .net framework consists of   (class Library)    +     (Common Language Runtime  (CLR))
// Bulid  exe   ----->>>> Excutable file  معناه ان اعمل للبرنامج بتاعه عشان اقدره انفذه وهنا يسمى  <------------
//Run   يعنى اشغل البرنامج عشان بس اشوفه بدون عمل له بناء
//Debug ----->      عند سطر معين عشان انفذ الكود سطر سطر واعرف وين المشكله    break point  معناها عمل تصحيح للكود   وممكن عمل   <--------------


            //namespace Training   //  مثل المجلد  ويقوم بترتيب الكود وعن طريقه عن انشاء واحد جديد وقتها اقدر استخدم كلاس بنفس الاسم فى كلاس سابق عادى 
            // اى يسمح لنا بعمل كلاس بنفس الاسم فى كلاس اخر
            //وهى من الاخر المشروع بتاعى اللى اسمه كذا 
 
    
}
    class Lesson_Rules_Identifiers //ولكن خاص بنا  namespace    ملف تحت المجلد ويسمى ايضا  //class---> object يتم كتابه داخلها كل الاوامر لان السى شارب عباره عن اوبجت اورينتيت وكل شئ عباره عن   
     {
        static void Main_11()  // called method    called main method  // all is reserved keywords // ومن هنا يتم تنفيذ البرنامج 
        {
            
            //identifier //هو المعرف    اسم يتم اعطائه وغير مسحموح برقم بالاول 
            //   Rules Of identifiers 
            // تبدا  بحروف و واندر سكور وبعدها ارقام فقط وغير مسحموح بارقام بالاول  
            // م وغير مسموح برموز غير الرمز اندرسكور
            //------
            // Case sesitive  or strongly typed    اللغه حساسه جدا للحروف 

            // ;   -> when we see it in end if line we will call it   "statement" 
            // Variable -> هو مكان فى الذاكره لتخزين عليه البيانات 
            // حيث يت تخزين البيانات فى الرامات وتتم العمليات الحسابيه فى البروسيسور 
            // variables   has  kind  Called "data Type"   and has name called  "identifier"
            //x//  _  يفضل عدم استخدامه بالبدايه عند تعريف اسم متغير 
            //x#// المتعيرات يفضل ان تبدا بحرف صغير
            // = called    assignment  operator
            //----------------------------------------------------

        }
     }
    class Lesson_Data_Types_Variables 
     {

        static void Main_12()  // called main method  or function 
        {
         
            // variables   has  kind  Called "data Type"   and has name called  "identifier"


            //Curved brackets  ()
            //square brackets []
            //curly brackets {}

            //double quotes  ""
            //single quotes  ''
            // semi-colon   ;
            //  forward Salsh    /
            // back slash        \
             
            //Data Type :-
            //1- Numeric Data Type consists of  مرتبين ترتيب تصاعدى

            /*
             *sbyte  //127
             *byte b=10;  //byte   // max value is 255 
             * we can use method to know that  ->console.Writeline(byte.maxvalue); //->output is 255
             *short s=10;   // int16
             *int i=10; //int 32
             *long l=10; //in 64
             *
             */



            //----------
            /*
             *double d=22.3; 
             *float f=22.33f; 
             *decimal d1=24.4m;
             */



            //---------------
            /*
             *char c='+';   // يخزن فيه حرف واحد فقط
             *string ss ="LEEEn";
             */


             //----------------------🍄🌈🌈🌈🍉
            /*
             *bool bb=true;
             *bool bbb =false;
             */


             //----------------------🍄🌈🌈🌈🍉
             /*
              *DateTime d = DateTime.Now;  // called struct  its lik class because contains Many Methods
              */


             //----------------------🍄🌈🌈🌈🍉
            /*
             *object O = 123;
             *O = "Leen";  // لايعترض ويشيل اى حاجه 
             *O=10;
             *O=O+20; // Problem Cant because still object but there are solution With (var) 
             */

             //------------------------🍄🌈🌈🌈🍉
              /*
               * var
               */

             //--------------------------------------------------
             //Question Interview 💚💚💚
                /*
                 *ايه الفرق الجوهرى بين الاوبجت والفار ؟ مش الاتنين بيشيلو اى داتا تايب 
                 *الاوبجت بيحط جواه القيمه وبتاخد الداتا تايب بتاعه ك اوبجت 
                 *الفار بياخد القيمه وبياخد معاها الداتا تايب الجديده اللى هايشتغل بيها 
                 */

            //------------------------🍄🌈🌈🌈🍉
            //Const.........Fix Value
             //const int x = 100;
             // Cant Change 




           

           // Converting .........................🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠
           // ممكن عمل تحويل بين المتغيرات 
            // double d = 10.55;
            // int n = 15;
            // n =Convert.ToInt32(d);  
            //Console.WriteLine(n); // out   11  

            //-----------------------------------------------------------------------------

            //---------------MATH
            // يوجد داخلها كل الدوال الرياضه بس الاشهر داله التقريب🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠
            // double d = 10.55;
            // int n = 15;
            // double R;
            // R = Math.Round(d, 1);  // اى بقوله قرب الدى الى رقم واحد صحيح والناتج خزنه داخل الار التى من نوع دبل
            // Console.WriteLine(R);

            //----------------------------------------------------------------
            //Substring يوجد دوال جاهزه خاصه بالاسترنت🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠

            // String name = default;
            // string sub;
            // Console.WriteLine("Enter Name");
            // name = Console.ReadLine();
            // sub = name.Substring(0, 3);
            // Console.WriteLine("Welcome " + sub);

            //----------------------------------🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠

            //Trim()يوجد دوال جاهزه خاصه بالاسترنت
            //مفيده جدا فى قواعد البيانات حيث بتقوم بحذف اى مسافات فى اول واخر الكلام
            // String name = default;
            // string sub;
            // Console.WriteLine("Enter Name");
            // name = Console.ReadLine();
            // sub = name.Trim();
            // Console.WriteLine("Welcome " + sub);

            //----------------------------------------------------------
                               //-------------------DateTime - bool Variables متغيرات التاريخ والوقت-------------------🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠
            // DateTime d;
            // d = DateTime.Now;  // calculate date automatic 
            // d = new DateTime(2020,08,19,12,30,00);// if i want make it manual 
            // // if i want to devide Time what can i do ? نسخدمها لو حابب اعرض التاريخ بشكل معين
            // int year = d.Year;
            // int month = d.Month;
            // int day = d.Day;
            // //Console.WriteLine(day +"/"+ month +"/"+ year);
            // // another way for printing
            // string output = d.ToString("yyyy/MM/dd");
            // string output_2 = d.ToString("hh:mm:ss  tt");
            // Console.WriteLine(output_2);

            //------------------------------------------------------------------

            // can make default value for variables 
            //string wew=default (string);  //  output zero  or nothing  in this case we can print it without errors

            // we can declare variable without assign it  Or Intialize it
            // also declare with null

            // Nullable Types ------------------------------------

            //string x=null; // string accept that without any problems // called nullable type------------
            //short? xx=null;// any thing else not accept must put ? to accept   using question mark ?

            //string name;  // in this case we must declare it in another statement to  can print 
            //or Multiple Declarations
            //int x,y,z;
            //then assignment fo variable

            // لمعرفه اقصى واقل قيمه لاى متغير
            //Console.WriteLine(int.MaxValue);

            
            // int x;------>  ---?
            //int x=5;  -----> mean assignment  Or Declare  or Initialize 
                         /*
                          *قاعده  💚 : ما يتم جمعه على سترينج فهو سترينج   مثال  💚
                          * int x=5;
                          *int y=10;
                          *int z=x+y;
                          *Console.WriteLine("the total is " + z);  //15
                          *Console.WriteLine("the total is " + z+y);  // ????   1510  لان سترنج جه الاول واى حاجه بعدها بيعتبرها سترنج الا لو عملت اقواس 
                          *Console.WriteLine("the total is " +(z+y));  // ????   25
                          *Console.WriteLine( z+y + "the total is ");  // ????   25  
                          */


        }
     }
    class Lesson_Printing
     {
        static void Main_13()
        {
            //Console.WriteLine(ss);  // called also method and all  methods has curved brackets ()  and called also statement because has end of it ;
            //Console.WriteLine تعنى من الاخر ان الكونسول ده او الشاشه السوده دى اكتب فيها الجمله دى وبس 
            //Console.Write("Leen"); //Write  نستخدمها للطباعه ولكن بدون عمل سطر جديد داخل الكونسول 
            //Console  ---> called class 
            //WriteLine ---called method
            //------------------------------------------------------------------------------
            //WriteLine --> this method it's implementation or it's code  inside  class called Console and console inside System   so we declare namespace called System
            //----------------------------------------------------------------------------
            //Did namespace contain only class? No .. if you write namespace System after main method followed by . you with see many kinds 

            // we can also use namespace System before class console without using "using System;"in the beggining 

            //Console.WriteLine("Leen"); //writeline -> مثلها ولكن تعمل سطر جديد
            //  ways to print variables ---------
            //string name = "Leen love";
            //byte age = 4;
            //Console.WriteLine("My lovely daughter is " + name + " clearHer Age is " + age); 
            // + -> called concatenation يقوم بعمليه الدمج بين النصوص ويستخدم ايضا للجمع بين الاعداد
            //-- another way for concatenation 
            //Console.WriteLine("My love is {0} and her age is {1} " , name , age);  // called place holder 
            // its prefer use pace holder beacause its mor readable 
            // another way for concatenation which appeared in c#6  called "String Interpolation " -->$
            //Console.WriteLine($"My lovely name is {name} and here age is: {age} years Old !!! ");

            //--------------------------
            
            //string name_1 ; // نتركه فارغا للتخزين فيه لاحقا
            //byte age_1 ;   // مثلها 
            //Console.WriteLine("Enter Your name :");
            //x/سنأخذ الشئ الذى سوف يكتبه ثم نخزنه فى متغير 
            //name_1=Console.ReadLine();    // Redaline معناه ان المتغير بيساوى القيمه المقروئه من من اليوز و نسخدم لعمل ذلك <----
            //x# ثم يتم التخرين فى المتغير console class  االموجوده فى   mithod which called Readline  او بمعنى اخر يتم قراءه النص المدخل عن طريق  <----
            //Console.WriteLine("Enter Your Age Please:");
            //age_1 =Convert.ToByte(Console.ReadLine());  // لابد من عمل تحويل لان ريدلاين لاترجع الا نصوص فقط
            // or can kind data type is   "var"  without making convert

            //Console.WriteLine($"Welcome mr {name_1} your Age is { age_1 } Years Old  ");

            //main method only البرنامج بيدا التنفيذ من 
            //  ex----------------

        //     static void print()
        //     {
        //     Console.WriteLine("Hello im ramzy");
        //     }
        //     static void Main()
        //     {
        //     Console.WriteLine("Hello Leen");
        //     print();   // call function or call method 
        //    }

            //----------------------  // escape sequence----- and verbatim literal------------------
            // string name = "\"leen\"";  // using backslash  to write "
            // string name = "\\leen\\";  // using backslash to   write \
            //string name = "one \n two \n three";  // using backsalsh for new line 
            //string name = @"one\leen\reda";  // using verbatim literal to print \ (لترتيب افضل نستخدمها)
            //string name = "one\\leen\\reda";  // using backslash to print \
            // Console.WriteLine(name);


        }
     }
    class Lesson_14_Arithmetic_Operators_and_Assignment_Operator
     {
        static void Main_14()
        {
                        //// assignment operator     =

            //// + addition      - subtraction    * multiplication  / division    % -> Modulus اى متبقى قسمه   ++ increemnt   -- decrement
            //int number_1 = 10, number_2 = 5 , total = number_1 * number_2; // Can declare all variables  One same line if Data Type For all same 
            //// ################   using  +=
            ///*
            //*int x=10;
            //* x+=90;  //output 100  
            //*/

            ////####################using +
            ///*
            // *int x=10+5; // out 15
            // *
            // */
            // //   using  ++  or --  
            //int x = 10;
            //x += 1;  //  or ++
            //Console.WriteLine(x);

            //Console.WriteLine($"The Number is {total} ");


            ////-----------------Hawas------------------------
            //// Literals
            //Console.WriteLine("Leen\thamza");// t mean tab and take distance between words
            //Console.WriteLine("---------------------------");
            //Console.WriteLine("Leen\nHamza"); // new Line
            //Console.WriteLine("---------------------------");
            //Console.WriteLine("Leen \"Hamza\" Ramzy"); // To Put double quotation
            //Console.WriteLine("---------------------------");
            //Console.WriteLine("\a");  // beeb voice
            //Console.WriteLine("---------------------------");

            ////-----  Operators
            ////-----------Modulus معناها المتبقى من خارج القسمه 
            ////for instance ...
            //int xx = 5;
            //xx = xx % 3;
            //Console.WriteLine("Modulus");
            //Console.WriteLine(x);  // 2 لان النتيجه واحد ومتبقى عدد اثنان بعد القسمه
            //Console.WriteLine("---------------------------");
            ////--------- Increment
            //int y = 10;
            ////y++;  //same 
            //++y;   // same 
            //Console.WriteLine(y);
            //int z = 10;
            //Console.WriteLine(++z); //but here if i used increment will not same why called prefix ومعناها اجمع واحد على واى 
            //Console.WriteLine(z++);//but here if i used increment will not same why  called postfix معناها اجمع واحد بعد ما تطلع قيمه واى  وكل هذا هايبان اكثر فى اللوب
            //int C = 10;
            //C += 50;   ///  Same  C=C+50;
            //Console.WriteLine(C);
            //Console.WriteLine("---------------------------");
            ////Convertion Or Casting  -----------------------
            //// Convert between data Types
            ///*
            // *1-Implicit Convertion
            // *2-Explicit Convertion
            // *3-System Convert Convertion
            // */
            ////Implicit Convertion   وهو يقصد به سهل اى من الصغير الى الكبير او الصغير داخل الكبير ولا يسبب مشاكل
            //int aa = 3;
            //long ss = 40000;
            //ss = aa;  // هنا القاعده دائما اليمين بيتحط فى الشمال
            //Console.WriteLine("Implicit Convertion");
            //Console.WriteLine(ss);// output 3
            //Console.WriteLine("---------------------------");

            ////Explicit Convertion 
            //int ww = 8;
            //double sde = 20.90;
            //ww = (int)sde;  // Cant implicit convertion and must make explicit by (int)
            ////but we will lost data like 0.90
            //int w = 6;
            //double dd = 20.3;
            //w = (int)dd;

            //Console.WriteLine("Explicit For Object");
            ////Explicit For Object Also
            //object f = 10;
            //f = (int)f + 70;
            //Console.WriteLine(f);
            //Console.WriteLine("---------------------------");
            ////------------  A مهم جدا لتنظيم الكود ويستخدم فى الحياه العمليه 
            //#region OldCod
            //int ssss = 10;
            //Console.WriteLine(ssss);

            //#endregion

            ///*
            // * string to any type      use     int.pars();
            // * any type to any type    use     convert.toint32     
            // */

            //Console.WriteLine("Enter Age Please");
            //int age = int.Parse(Console.ReadLine());   //string to any type      use     int.pars();
            //Console.WriteLine(age);

            //char c = 'a';
            //string name =Convert.ToString(c);  //any type to any type    use     convert.toint32
            //Console.WriteLine("---------------------------");



            ////if we want to know ASCII code for ant thing
            //Console.WriteLine("ASCII ");
            //char ch = 'z';
            //int ch2 = ch;
            //Console.WriteLine(ch2);
            //Console.WriteLine("---------------------------");

        }
     }
    class Lesson_15_Comparison_Operators
     {
        static void Main_15()
        {
                        // < > <= >=   ==   != 
            // bool result_1 = 3>4;
            // bool result_2 =10<8;
            // bool result_3 =10==10;
            // bool result_4 =10!=3;
            // // \n --> new line 
            // // \t  --> space

            // ######## EX  ==
            // int x = 19, y = 29;
            // Console.WriteLine(x == y);


            
            // Console.WriteLine(result_1 +"\n"+ result_2 +"\n"+ result_3 +"\n"+ result_4);  

        }
     }
    class Lesson_16_Logical_Operators
    {
        static void Main_16()
        {
                        //  AND &&      OR ||      NOT  !
                        // can use  &     and  |   but in this case cmpiler must check all بمعنى لو تحقق شرط لازم ايضا يعمل فحص للطرف الاخر ايضا بعكس الاخريات
            //bool result_5 = 6<5  && 8>9;  // تعتبر صحيحه لو تحقق كل الشروط 
            //bool result_6 = 6>3 || 6>6; // اى طرف صحيح يكون 
            //bool result_7 = !(6>3 || 6>6);// mean not true 
            //bool result_8 = !(5==8); // inside mean flase but when using ! now mean true 
            //Console.WriteLine(result_8);

            //######## EX   &&
            //             int x = 19;
            // Console.WriteLine(x < 10 && x > 1);  // out   ---> Flase

            //#######  EX     !
            //             int x = 10;
            // Console.WriteLine(!(x < 1 || x > 5));//Reverse the result, returns false if the result is true




            //----------------------------null coalecing Operator   Mean ??   تستخدم فى اختصار الاكواد-----------------------
            //int ? ticketonsale = null;
            // int availableticket;
            // if (ticketonsale == null)
            // {
            //     availableticket = 0;
            // }
            // else
            // {
            //     availableticket = ticketonsale.Value;  //  or       availableticket = (int)ticketonsale;// casting
            // }

            // or On one Step Using    null coalecing operator
            //int availableticket = ticketonsale ?? 0;   // mean if ticketonsale = null that will use 0 (default) or any number you will put if no will use value of ticketonsale
            //Console.WriteLine("Available is {0}",availableticket); 



        }
    }
    class Lesson_17_If_Statement
    {
        static void Main_17()
        {
            //ولكن فى هذه الحاله سياخذ البرنامج وقت ويكون ابطئ لانه حتى لو تحقق الشرط بيفحص الباقى ايضا  else if بدلا من  if ممكن تكرار 
            //------------------------------------------------------------------------
            // write Programme that if number positive or negative ✅✅✅✅✅✅
            //---------------------------------------------------------------------------
            // int n_1 ;
            // Console.WriteLine("Enter Number Please:");
            // n_1=Convert.ToInt32 (Console.ReadLine());
            // if (n_1 >0)
            // {
            //     Console.WriteLine($"The number {n_1} is Positive ");
            // }else if (n_1<0)
            // {
            //     Console.WriteLine($"This number {n_1} is negative ");
            // } else
            // {
            //     Console.WriteLine($"May be This number {n_1} is Zero ");
            // } 


            //#########################Quize######################################
            //######### using if -->use two numbers if chracter is + - *  excute that  ✅✅✅✅✅
            // int nn_1 ,  nn_2 , result ; 
            // char ch ;
            
            // Console.WriteLine("Enter First Number please ");
            // nn_1 =Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("Enter The Second Number Please ");
            // nn_2=Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("Enter Your Operator Please");
            // ch=Convert.ToChar(Console.ReadLine());

            // if (ch == '+' )
            // {
            //     //Console.WriteLine("Total number Is :" + (result=nn_1+nn_2));
            //     Console.WriteLine($"Total number Is : {result=nn_1 + nn_2}");
            // } else if (ch == '-')
            // {
            //     Console.WriteLine($"Total Substarction is : {result=nn_1 - nn_2} ");
            // }else if (ch == '*')
            // {
            //     Console.WriteLine($"Total Of Multiply Is : {result=nn_1 * nn_2} ");
            // }else if (ch == '/')
            // {
            //     Console.WriteLine($"Total of devision is {result=nn_1 / nn_2} ");
            // }else
            // {
            //     Console.WriteLine("Unknown ");
            // }

            //////////////////////////////////////-----------------------------------------------------

            //Nested If
            // int x = 10;
            // if (x>=0)
            // {
            //     if (x==10)
            //     {
            //         Console.WriteLine("yes");

            //     }
            //     else
            //     {
            //         Console.WriteLine("No");
            //     }
            // }

                /*
                 * 
                 * 
                 * 
                 * اكتب برنامج يحسب قيمه الوزن المدخل اوتوماتيي✅✅✅✅✅✅✅✅✅✅✅✅✅
                 * الوزن من 1-19=15ريال
                 * الوزن من 20-50=30ريال
                 * الوزن من 51-100=45ريال
                 *لكل 50كيلو زياده فق 100كيلو يتم زياده 22ريال
                 * 
                 * 
                 */
             int cost = 0;
             string decession;
                do
            {

                Console.WriteLine("Enter Wight Please From 1 Kg : 100 Kg");
                int wight = int.Parse(Console.ReadLine());
                if (wight >= 1 && wight <= 19)
                {
                    cost = 15;
                }
                else if (wight >= 20 && wight <= 50)
                {
                    cost = 30;
                }
                else if (wight >= 51 && wight <= 100)
                {
                    cost = 45;
                }
                else if (wight >= 101)
                {
                     int sub = wight - 51;
                     int div = sub / 50;
                     cost = 45 + 22 * (int)div;
                }
                else
                {
                    Console.WriteLine("Sorry You Entered Wrong Wight");
                    Console.WriteLine("Try Again Later  \n Thank You for using my App.");
                    break;

                }
                Console.WriteLine("You Must Pay {0}", cost);
                Console.WriteLine("Thank You for using my App.");
                do
                {
                    Console.WriteLine("Another Proceess ? Yes Or No");
                    decession = Console.ReadLine().ToUpper();
                    if (decession != "YES" && decession != "NO")
                    {
                        Console.WriteLine("Invlaid Choice Try Again Please");
                    }
                    else if (decession == "NO")
                    {
                        Console.WriteLine("Thank You !! Wainting You Soon");
                    }
                } while (decession != "YES" && decession != "NO");

            } while (decession == "YES");

        }
    }
    class Lesson_18_switch_case
    {
        static void Main_18()
        {
            //#########################Quize######################################
            //######### using swich  -->use two numbers if chracter is + - *  excute that ✅✅✅✅✅


            // int nn_1 ,  nn_2 , result ; 
            // char ch ;
            
            // Console.WriteLine("Enter First Number please ");
            //nn_1 =Int32.Parse((Console.ReadLine()));

            // Console.WriteLine("Enter The Second Number Please ");
            // nn_2=Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("Enter Your Operator Please");
            // ch=Convert.ToChar(Console.ReadLine());
            // switch (ch)
            // {
            //     case '+':
            //     result=nn_1+nn_2;
            //     break;

            //     case '-':
            //     result=nn_1-nn_2;
            //     break;

            //     case '*':
            //     result=nn_1 * nn_2 ;
            //     break;

            //     case '/':
            //     result=nn_1 / nn_2 ;
            //     break;

            //     default:
            //     result=0;
            //     break;
            // }
            // Console.WriteLine($"The result Is {result}");

            //----------------another solution 
            // int n_1, n_2, result;
            // char xx;
            // string decession;
            // do
            // {
            //     Console.WriteLine("Enter First Number Please");
            //     n_1 = Convert.ToInt32(Console.ReadLine());

            //     Console.WriteLine("Enter Second Number Please");
            //     n_2 = Int32.Parse(Console.ReadLine());

            //     Console.WriteLine("Enter Character Please");
            //     xx = char.Parse(Console.ReadLine());

            //     if (xx == '+')
            //     {
            //         result = n_2 + n_1;
            //         Console.WriteLine($"You Entered {xx}  and toltal amount is {result}");
            //     }
            //     if (xx == '*')
            //     {
            //         result = n_1 * n_2;
            //         Console.WriteLine($"You Entered {xx}  And Result is {result}");
            //     }

            //     do
            //     {
            //         Console.WriteLine("Do you want to Try Again  YES  or NO ");
            //         decession = Console.ReadLine().ToUpper();
            //         if (decession!="YES"&& decession != "NO")
            //         {
            //             Console.WriteLine("Invalid   YES Or  NO");
            //         }
            //         else if (decession == "NO")
            //         {
            //             Console.WriteLine("Thank You  BYYYYYY");
            //         }
            //     }
            //     while (decession != "YES" && decession != "NO") ;
            // } while (decession == "YES");



            //#############   Same EX  but using Switch ✅✅✅✅✅✅✅✅✅✅✅✅✅✅✅
            // Console.WriteLine("Enter First Number ");
            // double n1 = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine("Enter Second Number ");
            // double n2 = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine("Enter Operation Please");
            // char n3 = Convert.ToChar(Console.ReadLine());
            // var result = default(Double);     /// DEFAULT //////   //////

            // switch (n3)
            // {
            //     case '+':
            //          result = n1 + n2;   // OR can use WriteLine    directly without declare assign  another variable
            //         break;


            //     case '-':
            //          result = n1 - n2;
            //         break;


            //     case '*':
            //         result = n1 * n2;
            //         break;


            //     case '/':
                    
            //           result = n1 / n2;
            //           break;

                   

            // }
            // Console.WriteLine("The Result is " + result);


            // another ex using   GOTO   
            //decimal cost = 0;
            // agin:
            // Console.WriteLine("1-Honey , 2-Milk , 3-Dates");
            // var enteredNumber = int.Parse(Console.ReadLine());
            // switch (enteredNumber)
            // {
            //     case 1:
            //         cost += 6;
            //         break;
            //     case 2:
            //         cost += 7;
            //         break;
            //     case 3:
            //         cost += 10;
            //         break;
            //     default:
            //         Console.WriteLine(" Sorry !!! Try Again number  {0}  you entered isnt Valid",enteredNumber);
            //         break;


            // }
            // decide:  // label
            // Console.WriteLine("Do You want Another Thing Yes or No ?");
            // var decession = Console.ReadLine();
            // switch (decession.ToUpper())
            // {
            //     case "YES":
            //         goto agin;  // Iteration statement لا ينصح باستخدامها لان تتبع البرنامج بيكون صعب جدا ولها بديل 
            //     case "NO":
            //         break;
            //     default:
            //         Console.WriteLine("Not Correct {0} Try agin",decession);
            //         goto decide;
            // }
            // Console.WriteLine("Total Bill  Amount is  {0}", cost);
            // Console.WriteLine("Thank You ❤");



        }
    }
    class Lesson_19_Ternary_Opraor
    {
        static void Main_19()
        {
            // int n_1=10  , nn_2=20;
            // var massage=n_1<nn_2 ? "greater" : "less";  // var or string but i use var to let compiler choose 
            // Console.WriteLine(massage);

            //Ternary Operator..............................................

            // int x = 10;
            // var aa = x == 10 ? "Fucken yes" : "fucken no";
            // Console.WriteLine(aa);

            // nested Trnary Operator................................
            // int x = 20, y = 20;
            // var z = x < y ? "Greather Than" : x > y ? "Less Than" : x == y ? "Equal" : "Nothing";
            // Console.WriteLine(z);

            //-------------------------Thinking   💚💚💚💚💚💚
                        // ternary Operator
            // int result=default;
            // Console.WriteLine("Guss Number Please");
            // int number = Int32.Parse(Console.ReadLine());
            // Console.WriteLine(result);
            // result=number == 7 ? "You Win !!!!!!!!!" : "Fucken no";


        }
    }
    class Lesson_20_loops_FOR_LOOP
    {
        static void Main_20()
        {
                    //##############   QUIZE  اعرض جدول الضرب لاى رقم 
            // int number;
            // Console.WriteLine("Enter Number Please");
            // number=Convert.ToInt32(Console.ReadLine());
            // for (int i=0 ; i<=10 ; i++)  // -> i+=2  وهنا هايطبع الارقام الزوجيه وهكذا
            // {
            //     Console.WriteLine($"{number} * {i} = {number * i}");
            // }

            //###################  another solution  
            // var i = 0;
            // Console.WriteLine("Enter Number ");
            // var number = Int32.Parse(Console.ReadLine());

            // for (; ; )
            // {
            //     if (i <= 10)
            //     {
            //         Console.WriteLine($"{number} *  {i} =  {i * 2}");
            //         i++;
            //     }
            // }
            //     else
            //     {
            //         break;
            //     }
            // }

            //##################################  EX



            //##################################
            ///------اطبع من ١ الى ١٠ واذا وصل الى الرقم ٧ انهى العمليهك
            //  for (int i=0;i<=10;i++)
            // {
            //     if (i == 7)
            //         break;   // when found 7 stop
            //     Console.WriteLine(i);

            // }

            //-------------------another solution 
            // for (var i = 0; i <= 10; i++)
            // {
            //     if (i == 7)
            //     {
                  
            //         break;
                    
            //     }
            //     Console.WriteLine(i);
            // }


            //######################################
            //--------------------- اطبع الارقام من واحد الى  ١٠ واذا صادف رقم ٧ اعمل له تخطى 
            //   for (int i=0;i<=10;i++)
            // {
            //     if (i == 7)
            //         continue;    // skip for 7 only 
            //     Console.WriteLine(i);

            // }


            // loop called also ----->    iteration 


            // برمج برنامج يطبع الارقامن من ١-٢٠ ويتوقف عن ١٠
            // for(int i = 1; i <= 20; i++)
            // {
            //     Console.Write(i+" ");
            //     if (i == 10)
            //     {
            //         break ;
            //     }
            // }
            //------------------------------------------------
            // برنامج يطبع الارقام الزوجيه باستخدام شرط 
            // for (var i = 0; i <= 10; i++)
            // {
            //     if (i % 2 == 1)
            //     {
            //         continue;  // mean skip
            //     }
            //     Console.WriteLine(i);
            // }






        }
    }
    class Lesson_21_While_loop_Statement
    {
        static void Main_21()
        {
            // using static System.Console; //console  فى حاله لو لا نريد كتابه   <----
            //using static System.Convert; //convert  فى حاله لو لا نريد كتابه   <----

            //-----------------------------------------Write A programme like lucky number every time he choose 🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠


            // int i;
            // back:   // label
            //WriteLine("Guess Any Number");
            // i=ToInt32(ReadLine());
            // while (i !=13)
            // {
            //     WriteLine("you loss !!");
            //     goto back;   // نستخدممها لتكرار الامر ونضع اى اسم  هنا وضعت اسم باك ووضعتها ايضا فوق امام الامر المراد تكراره
            // }
            // WriteLine("You Win");

            //##############################################   or if you didnt want to use --goto--
            //Console.WriteLine("Guess Any Number Please !");
            // var i = Convert.ToDouble(Console.ReadLine());
            // while(i != 11)
            // {
            //Console.WriteLine($"Your Number Is {i}  Try Again please");
            //Console.WriteLine("Guess Any Number Please !");
            //i = Convert.ToDouble(Console.ReadLine());


            // }
            // Console.WriteLine($"Your Number is {i}  You Win !");

            //###############################
            //-----------------------------------------------------------------Print Numbers From 1-5  using while  🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠


            // int i=0;
            // while (i<=5)
            // {
            //     WriteLine("The Value Of i {0}" , i);
            //     i++;
            // }

            //#######################################
            //------------------------------------------------------------print numbers from 0-20 using while true   with if 🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠
            //int i = 0;
            // while (true)
            // {
            // if (i <= 20)
            // {
            //Console.WriteLine(i);
            //i++;
            // }
            // }

            //##################  
            //------------------------------------------------------------print numbers from 0-10 using while🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠
            //             int i = 0;
            // while (i <= 10)
                
            // {
            //     Console.WriteLine(i);
            //     i++;

            // }

            //############################################################
            //------------------------------------------------------------   Print From 1-10 using loop and if 🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠

            //double i = 0;

            // while (true)
            // {
            //     Console.WriteLine("Value of i: {0}", i);

            //     i++;
            //     if (i > 20)
            //     {
            //         break;
            //     }


            // }


            //#####################  
            //---------------------------------------------------------------------------- Calculate Total from 1-5  outbut  must be 15   🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠🦠
            //             int i = 1 ,sum=0;
            // while (i<=5)
            // {
            //     sum += i;
            //     i++;

            // }
            // Console.WriteLine("Total is {0} ", sum);

        }
    }
    class Lesson_22_Do_while_Loop_Statement
    {
        static void Main_22()
        {
             // it like while  but easy  but  condition was written last not first 
            // string name;
            // do
            // {
            //     WriteLine("Guess Name");
            //     name=ReadLine();
            //     WriteLine("Try Again");
            // }
            // while (name !="leen");
            // WriteLine("You Win!!!");

            //####################################################
            // int i =0;
            // do{
            //     WriteLine("Number is {0} " , i);
            //     i++;
            // }
            // while(i<=10);

            //https://www.tutorialsteacher.com/csharp/csharp-do-while-loop


            //##################   print   from 1-10  using   do while 
            //             int i = 0;
            // do
            // {
            //     Console.WriteLine(i);
            //     i++;
            // }
            // while (i <= 10);


            //###############################    print 1-10 using    do   while   and  if statement################
            //             //
            // int i = 0;
            // do
            // {
            //     Console.WriteLine(i);
            //     i++;
            //     if (i>10)
            //     {
            //         break;

            //     }
            // }
            // while (true);

            //---------------------اطبع برنامج يطلب الرقم ثم يطبع الارقام الزوجيه له
            // Console.WriteLine("Enter Number");
            // int number = int.Parse(Console.ReadLine());
            // int i = 0;
            // while (number >= i)
            // {
            //     Console.WriteLine(i);
            //     i += 2;
            // }



        }
    }
    class Lesson_23_foreach_loop
    {
        static void Main_23()
        {
                        // Deals with arrays 
            // string[] names={"leen", "Hamza","hadeer"};  // array
            // Array.Sort(names);   // لعمل ترتيب ابجدى
            // foreach(string value in names)
            // {
            //     //WriteLine(value);  // لعرض الاسماء
            //     //WriteLine(value.ToUpper());// لعرض الاسماء فى احرف كبيره
            //     WriteLine($" {value} contains {value.Length} characters. ");  // لعرض عدد الاحرف

            // }

        }
    }
    class Lesson_24_Arrays
    {
        static void Main_24()
        {
             // array consists of values + Index
            // int[] numbers=new int[6];  // فى حاله حجز مكان للذاكره للمصفوفه وعدم وضع لها قيم وهنا حجزت ٦ اماكن 
            // Int32 [] names ={3,5,7,9,10};  // مصفوفه مباشره
            // //## print  hamza ??
            // WriteLine(names[2]);



            // Declare an array
            //string[] cars;

            // Add values, using new
            //cars = new string[] {"Volvo", "BMW", "Ford"};




            //############## #########################  EX   make overwrite and print how many elements in array#######################
            //             string[] names = { "leen", "Hamza", "Azza" };
            // names[1] = "Hamza Reda";   // overwrite  
            // Console.WriteLine(names[1]);
            //Console.WriteLine(names.Length);  // لمعرفه عدد الاراى 
            //#########################################################

            //#################  using for print Array
            //             string[] names = { "Leen", "Hamza", "Azza" };
            // names[0] = "Leen Reda";
            // for (int i=0;i<names.Length;i++)
            // {
            //     Console.WriteLine(names[i]);
            // }

            //#########################################################################

            ///#############  using name  Space called ----using System.Linq;-- to get max   min    sum
            //             int[] numbers = { 22, 3, 1, 98, 21 };
            // Console.WriteLine(numbers.Max());
            // Console.WriteLine(numbers.Min());
            // Console.WriteLine(numbers.Sum());

            //##################################################################




            // foreach (var ww in names)   // var mean فى حاله عدم معرفه نوع الفاريبال او نوع مجهول وبتركه للمترجم معرفته 
            // {
            //     //WriteLine(ww);
            //     //or
            //     WriteLine($"Result is {ww} * 2 = { ww * 2}");  // لعرض حاصل ضرب ٢
            // }


        }
    }
    class Lesson_25_Multi_Dimentional_Arrays
    {
        static void Main_25()
        {
            // int[,] mnmn = new int [3,5]; // حجز ٣ صفوف و٥ اعمده 
            // //first row
            // mnmn[0,0]=10;
            // mnmn[0,1]=44;
            // mnmn[0,2]=33;
            // mnmn[0,3]=12;
            // mnmn[0,4]=66;

            // //Second row
            // mnmn[1,0]=12;
            // mnmn[1,1]=66;
            // mnmn[1,2]=55;
            // mnmn[1,3]=35;
            // mnmn[1,4]=87;

            // //Third row
            // mnmn[2,0]=94;
            // mnmn[2,1]=61;
            // mnmn[2,2]=52;
            // mnmn[2,3]=88;
            // mnmn[2,4]=43;

            // foreach(var ii in mnmn)
            // {
            //     WriteLine(ii);
            // }


        }
    }
    class Lesson_26_Casting__0r__convertion
    {
        static void Main_26()
        {
            // types of casting 
            //--->Implicit Casting or convertion   (automatically)- converting a smaller type to a larger type size
            //--ex char -> int -> long -> float -> double


             //Explicit Casting  (manually)  قصرى-اجبارى converting a larger type to a smaller size type
             //--ex--double -> float -> long -> int -> char


             //#### implicit casting  يتم التحويل بدون تلف البيانات وبيكون من نوع الى نوع اصغر منه 
             // int nn=10;
             // double gg =nn;

             // //explicit casting  وهنا لو تم التحوويل بالعكس 
             // double kk=4.6;
             // //int kj=kk;  //double  اصغر من  int  هنا هايكون فى خطأ لان 
             // //int kj=(int)kk;  //  هناا الحل للتحويل وسين عرض الرقم الصحيح فقط دون ما بعد العلامه العشريه



             //Type Conversion Methods
             //It is also possible to convert data types explicitly by using built-in methods,
             // such as Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) and Convert.ToInt64 (long):

            
             // // can use convert  but it different 
             // int kj=ToInt32(kk);// الاختلاف فقط ان هنا هايقوم بالتقريب ويكون الناتج ٥
             // //### ex 
             // long pl=long.MaxValue;  // هنا بقوله اعطنى اكبر قيمه ممكنه
             // int md =(int)pl;  // الناتج هنا هايكون ١- لانه لن يستوعبها 


            //---------------------- casting -----string------ using two ways
            //---------------------- first way using parse if im sure entered number

            //string x = "129";
            //int y = Convert.ToInt32(x);
            //int y = int.Parse(x);
            //Console.WriteLine(y);

            //------------------------second way if im not sure for entered number that return bool (true or false)
            string x = "129";
            int result = 0;
            bool y = int.TryParse(x, out result); // الطريقه دى لابد من بوول  ثم النتيجه لازم تخزن فى فاريبال جديد
            //Console.WriteLine(y);
            //or using if
            if (y == true)
            {
                Console.WriteLine("Conversion Done !");
            }
            else
            {
                Console.WriteLine("Invalid Input number check again Please!");
            }

            // what diffrent between type casting and convertion 
            // فى حاله تحويل متغير يحتوى على رقم كبير جدا 
            // type casting use that  (int)    // outbut--> يتم تنفيذه لاقرب رقم 
            //convertion  use  Convert.toint32  // give excepion namre is overflow  ولا يتم التنفيذ
            



        }
    }
    class Lesson_27_String_Manipulation
    {
        static void Main_27()
        {
            //string Nmmmed="leen reda mahmoud";


            // WriteLine(Nmmmed.Length);  // لمعرفه عدد الحروف 
            // WriteLine(Nmmmed.ToUpper());  // Capital letters 
            // WriteLine(Nmmmed.ToLower());
            // WriteLine(Nmmmed.Substring(0,10)); // يقتطع الكلمه المراد

            // هنا لازم اعمل تقطيع الاول ثم عمل دمج وهذا شرط 


            //string[]jj=Nmmmed.Split(' ');  // بيقطع الكلمه كيف ؟ الميثود بتروح للفاريبال وتشوف الفراغ ده فين
            //or can use new array like that
            //string[]uu= "Reda Mahmoud Abd-Elgawad".Split();



            ////ممكن الدمج لهم  by using join  or concat  or +


            //using  +
            //WriteLine(jj[0] + "--" + jj[1] + "-"+ jj[2]); 

            //using concat----------- 
            //WriteLine(string.Concat(jj[0]," ",jj[1]," ",jj[2])); // using concat but without spaces   ," " عشان المسافه

            //using join-------------------
            // if i want to put spaces 
            //WriteLine(string.Join("//",jj[0],jj[1],jj[2])); // using join with spaces


            //########################################################## 


            // للتاكد من حرف معين موجود ؟؟؟؟
            //WriteLine(Nmmmed.Contains("lee")); // للتاكد من ان حروف معينه موجوده

            
            // another solution using if
            // if (Nmmmed.IndexOf("mahmoud")!=1)
            // {
            //     WriteLine($"name is exist its numcer {Nmmmed.IndexOf("mahmoud")}");
            // }
            // else
            // {
            //     WriteLine("Not exist");

            // }
                       
            // string name = "Suresh Dasari";
            // WriteLine(name.IndexOf("u"));
            // if (name.IndexOf("esh")<=3)
            // {
            //     WriteLine( $"yes {name.IndexOf("esh")}");
            // }
            // else
            // {
            //     WriteLine("no");
            // }
            

        }
    }
    class Lesson28_Currency_Formating
    {
        static void Main_28()
        {
            // double number=565123.33;
            // Console.WriteLine($"Number is {number :c} "); // c -> mean currency وتقوم بعرض على شكل مالى وتعتمد على العمله الموجود فى اعددات النظام  نفسه
            // Console.WriteLine($"Number is {number : ###,### ###.###} "); // لعرض فراغات بين الارقام ووضع علامات كما اريد
            // Console.WriteLine($"Number is {number: 000 000 000} "); // لاستبدال الفراغات بنقط



        }
    }
    class Lesson_29_Date_Time_Formate
    {
        static void Main_29()
        {
            // DateTime date=DateTime.Now;
            // Console.WriteLine(date);  // show date and time
            // Console.WriteLine($"{date:d}");  // show date Only
            // Console.WriteLine($"{date:dd}"); // show day
            // Console.WriteLine($"{date:MM}"); //  show month
            // Console.WriteLine($"{date:mm}");  // show minutes 
            // Console.WriteLine($"{date:yy}");  // show year
            // Console.WriteLine($"{date:yyyy}"); // show year full
            // Console.WriteLine($"{date:MM/yyyy}");// Month+Year
            // Console.WriteLine($"{date:hh:mm:ss}");
            

        }
    }
    class Lesson_30_Functin_and_Procedures
    {

                
        //###### Functions and procedures  or called  Methods   ########
        // الغرض منها 
        // DRY  mean dont repeat your self لاتكرر نفسك
        // ااى تفادى التكرار
        //procedures مجموعه من الاجراءات ولا ترجع قيمه 
        //function ترجع قيمه  
        

        //static ->Mean means that the method belongs to the Program class and not an object of the Program class.
        //void ->means that this method does not have a return value.
        //show ->is the name of the method


        // static void Show(string name)  // name -> called parameter  // use to show name// called procedures
        // {
        //     Console.WriteLine($"Welcome {name}");
        // }

        // //###################  another ex
        // static void Name_Age(string name, int age)
        // {
        //     Console.WriteLine("Name is " + name + "Age is " + age + "Years Old");
        // }

        //###########################################
        // static int Addition(int a , int b)  // method or function -->must return somthing    use for additinal 2 numbers
        // {
            // int result=a+b;
            // return result;
            //or
            //return a+b; 

        // }

        // static void Main_30()
        // {
            // Show("Leen Reda ");
            // Console.WriteLine(Addition(22,44));  // call function addition 


            // Name_Age("Leen Reda ", 4);
            // Name_Age("Hamza Reda ", 2);
            // Name_Age("Hadeer Mohamed", 26);
        // }
       


        
    }
    class Lesson_31_Parameter_Passing_by_Valueـreference_out
    {
        // static int By_value(int x)
        // {
        //     //return x *= 2;
        //     //or
        //     x=x*2;
        //     return x;
        // }

        // static int By_Reference(ref int x)
        // {
        //     return x *=3;
        // }

        // static int By_out(out int x)
        // {
        //     x=1000;
        //     return x *=6;
        // }

        // static void Main()
        // {
        //     int x=100;
        //     //or can use ant variable 
        //     //int yy=100;
        //     Console.WriteLine($"Result Befor Pass By value is  {x} ");
        //     Console.WriteLine($"Result inside Pass By value is  {By_value(x)} ");
        //     Console.WriteLine($"Result After Pass By value is  {x} ");
        //     Console.WriteLine("---------------------------------------");

        //     Console.WriteLine($"Result Befor Pass By value is  {x} ");
        //     Console.WriteLine($"Result inside Pass By value is  {By_Reference(ref x)} ");
        //     Console.WriteLine($"Result After Pass By value is  {x} ");
        //     Console.WriteLine("---------------------------------------");

        //     Console.WriteLine("---------------------------------------");
        //     Console.WriteLine($"Result Befor Pass By value is  {x} ");
        //     Console.WriteLine($"Result inside Pass By value is  {By_out(out x)} ");
        //     Console.WriteLine($"Result After Pass By value is  {x} ");
        //     Console.WriteLine("---------------------------------------");

            

        // }
    }
    class Lesson_32_Exception_Handling
    {
        static void Main_32()
        {
            // اداره الاستثناءات والاخطاء
            // هى اخطاء قد تحدث عند عمل البرنامج
            // مثال القسمه على صفر او تعريف متغير واسناد له قيمه من نوع اخر 
            //############  example
            // Console.WriteLine("Enter Your Age Please :");
            // int age=Convert.ToInt32(ReadLine());
            // Console.WriteLine("Your Age is {0} ",age);
            // Unhandled exception نفترض ان المستخدم ادخل حروف بدلا من ارقام ؟ وقتها بيطون هناك  
            // والحل ؟؟؟
            // use   try  and catch  ونقوم بوضع فى تراى الاوامر المحتمل فيها الخطأ
            // Console.WriteLine("Enter Your Age Please");
            // try
            // {
            //     int age=Convert.ToInt32(ReadLine());
            // }
            // catch (FormatException xx)
            // {
            //     Console.WriteLine("Age Not Valid {0} ",xx.Message);
            // }

            // catch (OverflowException xx)
            // {
            //     Console.WriteLine("Age Too Big {0} ",xx.Message);
            // }
            // catch (Exception xx)  // or can use finally ----- catch  وهو ينفذ فى جميع الحالات ونستخدمه فى قاعده البيانات // ممكن استخدام اكثر من 
            // {
            //     Console.WriteLine("Age Not Correct {0} ",xx.Message);
            // }

            // finally
            // {
            //     Console.WriteLine("Finally Block Is excuted");
            // }

            // //####################   another example 

            // try
            // {
            //     int[] number = { 1, 2, 3, 4 };
            //     Console.WriteLine("Number is {0} ", number[2]);
            // }
            // catch (Exception ex)
            // {
            //     Console.WriteLine("Not exist Man {0} ", ex.Message);
            // }
            // finally
            // {
            //     Console.WriteLine("End OF programme ! ");
            // }

            // can use also throw   look to w3school
            //https://www.w3schools.com/cs/cs_exceptions.asp

        }
        
    }
    class Lesson_33_Enums_and_constants
    {
        // contants  like variables  But it never change !
        //Enumerations التعدادات 
        //enumerations -->تسمح لنا بتخزين قيم ثابته مثل ايام الاسبوع مثلا 
        //enums
        //# using do-while   guess number to go next level
        // enum Levels
        // {
        //     easy,
        //     medieum,
        //     hard
        // }
        static void Main_33()
        {
        //     int number;
        //     Levels cc = Levels.easy;
        //     Console.WriteLine("Your Level Now is "+ cc);
        //     do
        //     {
        //         Console.WriteLine("Guess Number Please:");
        //         number = Convert.ToInt32(Console.ReadLine());
        //     } while (number != 10);
        //     Console.WriteLine("You Win ");
        //     cc++;
        //     Console.WriteLine("your Level now is " + cc);
        //     do
        //     {
        //         Console.WriteLine("Guess Number Please:");
        //         number = Convert.ToInt32(Console.ReadLine());
        //     } while (number != 20);
        //     Console.WriteLine("You Win ");
        //     cc++;
        //     Console.WriteLine("your Level now is " + cc);

        }


    }
    class Lesson_34_Structs
    {

            // structs --->  Mean structure
            // // نستخدم هذه التقنيه فى حال تخزين بيانات متعدده فى  كيان واحد مثل بيانات طالب معين
            // struct Student
            // {
            //     public String name;
            //     public byte age;
            //     public string address;

            // }
            // static void Main()
            // {
            //     Student std=new Student();
            //     std.name="Leen Reda";
            //     std.age=4;
            //     std.address="Saudi Arabia";

            //     Console.WriteLine(std.name);


            // }

            //#############  another way/////

        // struct Student
        // {
        //     public string name;
        //     public int age;
        //     public string address;
        //     public Student(string n,int ag,string add)
        //     {
        //         name = n;
        //         age = ag;
        //         address = add;

        //     }

        //     static void Main()
        //     {
        //         Student std = new Student("Leen Reda ", 4,"saudi arabia");
        //         Console.WriteLine(std.name);
        //     }
            


        // }
            
        
    }
    class Lesson_35_checking_for_overflow
    {
        // static void Main()
        // {
        //     //ex
        //     byte b=byte.MaxValue;//255 
        //     b++; // لان تم تعدى الحد الاقصى overflow  هنا معناه تم عمل له  
        //     // وبذلك سنفقد البيانات وستكون النتيجه صفر اى يذهب اوتوماتيك الى اول رقم فى المجال المتاح له
        //     Console.WriteLine(b);

        //     // للتاكد checked  ممكن استخدام 

        //     checked
        //     {
        //         int i=int.MaxValue;
        //         Console.WriteLine(i);
        //         i++;
        //         Console.WriteLine(i);
        //     }

        //     // or by using try-catch
        //                 try
        //     {
        //     checked
        //         {
        //             int age = int.MaxValue;
        //             Console.WriteLine(age);
        //             age++;
        //             Console.WriteLine(age);
        //         }

        //     }
        //     catch(OverflowException ex)
        //     {
        //         Console.WriteLine(ex.Message);
        //     }

        // }
    }
    class DifferentTypesOfMethodsParameters
    {
        // 4 types of method parameters
        /*
         * value parameters
         * Reference Parameters
         * Out parameters
         * Parameter Arrays
         * 
         * and what different between  Method parameters and method arguments
         *Method parameter بيقال عليها ذلك لما بعرفها مع الميثود 
         *Method arguments بيقال عليها ذلك فى حاله انادى على الفانكش واضع لها قيم 
         */

        //-------Value parameter-------- المتغير الجديد لا يؤثر على المتغير القديم وممكن طباعه كل متغير على حده وكل منهم له مكان بالذاكره 
        public static void Main()
        {
            int y = 500;
            Number(y);
            Console.WriteLine(y);
        }
        public static void Number(int i)
        {
            i = 101;
            Console.WriteLine(i);
        }
        //--------Reference parameter--------
                //-------Reference  parameter--------  تؤشر على نفس المكان فى الذاكره والمتعير الجديد ياخذ نفس قيمه القديم 
        public static void Mainn()
        {
            int y = 900;
            Number(ref y);
            Console.WriteLine(y);
        }
        public static void Number(ref int i)
        {
            i = 101;
            
        }

        //-------Out Parameters---فى حاله ارجاع اكثر من قيمه 
        public static void Mainn1()
        {
            int sum;
            int multi;
            int devesion;
            Addition(900, 99, out sum, out multi,out devesion);
            Console.WriteLine("Addition = {0} and Multiplication = {1} and devesion = {2}", sum, multi,devesion);

        }
        public static void Addition(int x,int y,out int sum,out int multi,out int devesion)
        {
            sum=x + y;
            multi = x * y;
            devesion = x / y;


        }
        //------- Parameters array----------------------
        static void Mainm()
        {
            string [] students = { "Leen", "Hamza", "RR" };
            TestArray(students);

        }
        public static void TestArray(params string [] arr)  // can use params to make parameter in calling function is optional
            // l ممكن ايضا نستخدمها لوضع قيم مباشره فى البراميتر فى كول فانكشن
            //l مكانها بيكون اخر مكان وبتكون مره واحده فقط
        {
            Console.WriteLine("Ther are {0} Elements in array",arr.Length);
            foreach(string i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
    class Namespace_
    {
     // using TeamBb= ProjectA.TeamB; // can use directive name with any alias name  and do-without full qualified name
     //     namespace Program
     //     {
     //    class Edu
     //     {
     //     static void Main()
     //     {
     //         ProjectA.TeamA.One.Print();// call namespace using full qualified name
     //         TeamBb.One.Print();  // using alias name

     //     }
     //     }
     //     }  



        //  namespace ProjectA  
        //  {
        //  namespace TeamA // we can dispense with namespace by using (namespace ProjectA.TeamA)// called also
        // //namespace indside namespace.
        //  {
        //  class One
        //   {
        //     public static void Print()
        //     {
        //         Console.WriteLine("Team A //  Project A");
        //     }

        //  }
        //  }


        // }



        //  namespace ProjectA
        //    {
        //  namespace TeamB
        //  {
        //   class One
        //       {
        //         public static void Print()
        //         {
        //             Console.WriteLine("Team  B // Project A");
        //         }

        //     }
        // }

    }
    class Lesson_OOP___________________________________________________OOP__________________________________________ 
    {
        static void Main_36()
        {
            //  اهم شئ فيها الكلاس والكلاس يعتبر تمثيل شامل 
         
            //Can make new class called for ex computer include 1- properties 2-methods 3-events

            //C# have 2 banches To learn toutorial  ???---->  1- Structured Programming(Basic)    2- OOP
            //What OOP ???
            // First  we Have Primitive Data Types Like string-int-bool ....   and User defined Data Type ودى اللى بيعرفها المبرمج وهنا نشأت فكره البرمجه كائنيه التوجه ازاى ؟؟؟
            //مثلا لو عايز دلوقتى اخزن شخص والشخص ده خصائص كيف هاعملها اذن وقتها لازم استخدم البرمجه الشيئيه 
            //اذن ممكن استخدمها لتعريف اى شئ بالاعلان عن كلاس وبقوله ده مثلا انسان واعطى له خاصائص بدون قيم ثم اعمل له ميثود عشان اعطى له اوامر معينه ثم عن طريق الاوبجت احدد بقى 
            //الشخص لين والشخص حمزه واعطى لكل شخص ما اريد

            
            

        }

    }
    class Lesson_Properties_access_AccressModifiers_Classes_Objects
    {
        //مما يتكون الكلاس ؟؟
        //properties - or Attributes    مثلا كمبيوتر وله خصائص وهذه هى الخصائص
        // public string brand; // properties ---  // يتم الاعلان عنه مبدئيا بدون اى قيم  
        // public double price;
        // public DateTime manufacturedate;
        // public string color;
        // Class When Created By default is Internal 

        // access modifiers  
        //public   private   internal    protected 
        //public  اى ممكن الوصول له من اى مكان حتى لو ملف اخر حتى لو مشروع اخر
        //private  and by default without declare it all private على مستوى الكلاس التى تحتوى عليه فقط
        //internal  ---> like public but one different   تسمح لنا من اى مكان داخل المشروع لكن لو ذهبنا لمشروع اخر لن يعمل هى مثل البابلك 
        //protected  فقط على مستوى الفئات او مشتقاته هى مثل البرايفت بس الفرق انها تعمل ايضا على اى شئ يرث منها 

        //-----------------💜❤️💕😎😃💜❤️💕😎😃💜❤️💕😎😃💜❤️💕😎😃----------------
        //using System;
//namespace Tests
//{
//    class Prog
//    {
//        static void Main()
//        {
//            ClasseAccess Cls = new ClasseAccess();
//            Cls.AssignData("Leen", 10);
//            Cls.PrintDetails();
//        }
//    }
//    class ClasseAccess
//    {
//        //Attributes-fields-Variables For class-prppertes
//        string name;
//        int age;

//        public void AssignData(string name,int age)
//        {
//            this.name = name;
//            this.age = age;
//        }

//        public void PrintDetails()
//        {
//            Console.WriteLine($"My Name is {name} My Age is {age}");
//        }

//    }
//--------------------------💜❤️💕😎😃💜❤️💕😎😃💜❤️💕😎😃💜❤️💕😎😃----------------

        //using System;
//namespace Prog
//{
//    class Executable
//    {
//        static void Main()
//        {
//            //-----How To call Methods------💙💜❤️💕😎😃
//            ProjectOne.Methods.print();  // calling static procedures
//            Console.WriteLine(ProjectOne.Methods.Addition(100, 9000));

//            //--------------💙💜❤️💕😎😃   OBJECTS----------------------💙💜❤️💕😎😃
//            // Object is Instance of Class
//            ProjectOne.CarOne carFirst= new ProjectOne.CarOne();
//            carFirst.Info("Red", "Ford", 1000);
//            carFirst.showData();



//        }

//    }
//}


//namespace ProjectOne
//{

//    class Methods
//    {
//        /// <summary>
//        /// class:-  Consists Of ........
//        /// 
//        /// 1-prpperties 0r Fields 0r Attributes
//        /// 2-Methods [Procedures-Functions]
//        /// 3-Events 
//        /// </summary>
//        ///
//        // Ex For prpperties💁💙💜❤️💕😎😃🤪💁💁
//        //public string Xx;  // public mean accress modifier that mean can accress it any where

//        // Types Of access Modifiers🤪💁💁💙💜❤️💕😎😃
//        // public --> can access it out of class and prject also
//        //private -->access it inside of class only and all be default if didnt make access modifiers will be private
//        //intrtnal-->like public but the only difference is cant access it out of assembly (Cant out of project)
//        //protected -->can access it inside class and all inheritance from it




//        //  kاهم شئ فى البرمجه الكائنيه  هو   الكلاس والكلاس يعتبر تمثيل شامل 
//        // lولما بعمل اوبجت هنا بيكون تمثيل خاص 
//        // copy from class called object  this operation called instance
//        //Can make new class called for ex computer include 1- properties-fields-attributes  2-methods 3-events
//        //properties like variables but this belong to class


//        // EX:--🤪💁💁💙💜❤️💕😎😃
//        //public static void print()
//        // Public ---->because it out of scoop main class to can see
//        // static --->    to didnt make object if remove it must be make object
//        // void ---->  that mean that procedure didnt return any thing and called procedures



//        //--------💙💜❤️💕😎😃  Methods [procedures   and functions ] -----------💙💜❤️💕😎😃

//        public static void print()
//            // Public ---->because it out of scoop main class to can see
//                                   // static --->    to didnt make object if remove it must be make object
//                                   // void ---->  that mean that procedure didnt return any thing and called procedures
//        {
//            Console.WriteLine("Leen");
//        }
//        public static int Addition(int a, int b)
//        {
//            // int that  mean called function and return thing

//            return a + b;
//        }
//        public int Multi(int a, int b)
//        {
//            return a * b;
//        }
//        public int Substraction(int a, int b)
//        {
//            return a / b;
//        }

//        public static int cv;


//        //--------------💙💜❤️💕😎😃   OBJECTS----------------------💙💜❤️💕😎😃

//    }
//    class CarOne
//    {
//        //----Fields 
//        string color;  // called poperties - Fields 
//        string model;
//        int price;

//        // Then give values for this fields by Methods
//        public void Info(string _color,string _model,int _pric) // between here called parameters 
//        {
//            color = _color;
//            model = _model;
//            price = _pric;
//        }

//        //then show class data.....
//        public void showData()
//        {
//            Console.WriteLine("Color is {0}\nModel is {1}\nPrice is {2}",color,model,price);
//        }
//    }
//}

    }
     class lesson_Encapsulation_Full_properties_autoproperties
    {
        //encapsulation حمايه بيانات الكلاس من الوصول المباشر
        //properties طريقه كتابه 
        //طريقتان
        //1-full properties----------
        // private string brand; // called field//   //barndProperty حتى لا اتعامل معه مباشره سنتعامل مع encapsulation  لو عايز اخلى دى 
        // public string color {get;set;}  // auto property without encapsulation
        // to make barand encapsulation 
        //first way  with full properties
        // public string barndProperty
        // {
        //     get  // can read it
        //     {
        //         return brand.ToUpper(); // مثلا ارجاع حروف كبيره
        //     }
        //     set  // can write also on it
        //     {
        //         brand=value;
        //     }
        // }

        //2- auto properties ولكن هنا لا يتم تطبيق انكابسوليشن  انظر الى اللون فوق ماذا حدث 


        //------------------------another Ex.................................
        //using System;
//namespace Executable
//{
//    class Prog
//    {
//        static void Main()
//        {
//            Tests.Encapsulation Enc = new Tests.Encapsulation("Ford", 120.00, DateTime.Now, "Red");
//            Enc.Printing();  // that represent get

//            //taht represent  set
//            Enc.brandProperty = "BMW";
//            Enc.Printing();
//        }
//    }
//}
//namespace Tests
//{
//    class Encapsulation
//    {
//        // Properties-Attributes-Fields  ---> but properties Have another Deep Meaning that let us To can Incapulate Fields
//        // Encapsulation اى حمايه ييانات الفيلدز من الوصول المباشر من  الاوبجت هنا لازم يكون الفيلد برافيت
//        //there are two ways to write Encapsulation

//        //First way Called      Full Properties
//        private string brand; // A هذا معرف على مستوى الكلاس فقط    by default is private not necessary to declare private 
//        public double price;
//        public DateTime manufacturDate;
//        public string color { get; set; }  // Auto Properties   and we put get and set that maen can read and write on this field
//        // Auto Properties can write it by Prop + Double tabe
//        //auti properties  هى  شائعه الاستخدام الا فى حاله تطبيق شرط معين على الفيلد وقتها نستخدم الطريقه الاولى مثال على ذلك سطر رقم ٣٤ لو عايز ارجع حروف كبيره



//        public string brandProperty  //Encapsulation For Field brand  by Full properties
//        {
//            get  // Mean i can Read it Value 
//            {
//                return brand;// if i want return upper characters
//            }
//            set // Mean I can Give it Value  that maen can Write  ---- Using get and set Mean اى نستطيع الوصل له كتابه وقراءه
//            {
//                brand = value;
//            }
//        }
//        //-- Second Way Called Auto Properties
//        //A-هنا لا نطبق فيها مفهوم انكابسوليشن لان الفيلد يبقى بابلك
//        //For ex  Look Synatx No 24



//        public Encapsulation(string brandProperty, double price, DateTime manufacturDate, string color) // same name properties here why ? to use this
//        {
//            this.brandProperty = brandProperty;  //we you this to confirm that brandProperty belong to class not in parameters
//            this.price = price;
//            this.manufacturDate = manufacturDate;
//            this.color = color;
//        }



//        public void Printing()   //  Procedures 
//        {
//            Console.WriteLine(brandProperty + "\n" + price + "\n" + manufacturDate + "\n" + color);  // cw + Double tabe
//        }
//    }
//}


    }
    class Lesson_Methods
    {
        // function or procedures عباره عن داله او اجراء method <----
        //using System;
//namespace Executable
//{
//    class Prog
//    {
//        static void Main()
//        {
//            //calling procedure 
//            Methods.Meth.EvenNumbers(20); // call direct without make intance of class (Object)

//            //calling function
//            Methods.Meth newMeth = new Methods.Meth();
//            //output data by two ways   first way;-
//            var result=newMeth.Multi(30, 900);
//            Console.WriteLine(result);
//            //second way---
//            Console.WriteLine(newMeth.Multi(200,100)); // direct way without intialize new variable
//        }

//    }
//}

////--------------
//namespace Methods
//{
//    class Meth
//    {
//        //---------Procedures----------------------

//        // write a programe   calling Even Numbers

//        // will not return any thing and its name procedure 
//        public static void EvenNumbers(int y)  // public mean  access Modifiers //void mean return type and that mean 
//        {
//            int n = 0;
//            while (n <= y)
//            {
//                Console.WriteLine(n);
//                n+=2;
//            }
//        }
//        // method which contain static called static methos or procedure  same like main method وهنا عشان انادى عليها فقط اكتب اسم الكلاس
//        //method which dosent contain ststic called intance method  or funtion same like EvenNumbers عشان انادى  عليها لازم عمل اوبجت جديد




//        //------------Functions----------------------

//        public int Multi(int a, int b)  // mean will trturn data type int
//        {
//            return a + b;  // this called intance method and return int
//        }
//    }
//}



    
    }
    class Lesson_Constructor
    {
        // Constructor  maen->  A constructor is a  special method that is used to initialize objects.
        //يحمل نفس اسم الكلاس وليس له ارجاع 
       // public بمعنى ممكن عمله عند انشاؤ الكلاس وبيكون بنفس اسمه ويكون  
    

             //can write it automatic by write (ctor)
             // when creat constructor must be public and must take same name for class 
             // we use it to define prperty or attributes in class by many methods 
             // we use constructor to save time with short code


        // Ex------------------------------------
        //using System;
//namespace Executable
//{
//    class Prog
//    {
//        static void Main()
//        {
//            Tests.Car newCar = new Tests.Car("Yellow", "Ford", 20000);
//            newCar.ShowData();



//        }
//    }
//}
////---------------------------------------------------------
//namespace Tests
//{
//    class Car
//    {
//        //prpperties-fields-attributes
//        string color;
//        string brand;
//        int price;

//        //Constructor 
//        public Car (string _color, string _brand,int _price)  // Con Put Parameters or no as you like
//        {
//            this.color = _color; // this--- can use or no as you like
//            this.brand = _brand;
//            this.price = _price;
//        }
//        //A-ملحوظه مهمه اذا لم يتم عمل كونستراكنور بيتم عملها اتوماتيك وبيكون اسمها Default Constructor
//        //public Car()
//        //{
//           // Default Constructor which in c#  // وتستخدم ايضا لازاله اى خطا لكى لا نستخدم ارجيومينتش     
//        //}

//        // Old Way --------
//        //public void sameConstructor(string _house, string _tall)
//        //{
//        //    house = _house;
//        //    tall = _tall;
//        //}

//        public void ShowData()
//        {
//            Console.WriteLine($"My car color is {color} , My car brand is {brand} and its price is {price}");
//        }
//    }
//}




    }
    class Lesson_Inheritance
    {
        // Inheritance mean t is possible to inherit fields and methods from one class to another. 

        //Derived Class (child) - the class that inherits from another class
        //Base Class (parent) - the class being inherited from
        // اى نقل مكونات الفئه الرئيسيه الى الفئه المشتقه
        //الغرض منه تفادى تكرار الاكواد

        
//using System;
//namespace Executable
//{
//    class Prog
//    {
//        static void Main()
//        {
//            Inheritance.Programmer ProgOne = new Inheritance.Programmer("Leen", "Qutor", 10, 10.00,10);
//            ProgOne.Languags("French");
//            ProgOne.ShowData();
//            Console.WriteLine(ProgOne.salary);
//        }
//    }
//}

////--------------------------------------------------

//namespace Inheritance
//{
//    // Inheritance represnts relationship betwwen 2 classes (based class or parent class or Main Class   and  Drived Class or child class)

//    class Person  // Based Class
//    {
//        public string name { get; set; }
//        public string address { get; set; }
//        public int age { get; set; }

//        //Constructor
//        public Person(string name, string address, int age)  // i فى هذه الحاله او فى حاله عمل ذلك لابد من عملها تحت ايضا
//        {
//            this.name = name;
//            this.address = address;
//            this.age = age;
//        }
//        public Person()
//        {
//            // Aنستخدمه حتى لا نعمل للكنستراكتور وراثه وايضا  فى الاوبجت لو مش عايز استخدم ارجيومنت   
//        }

//        // Procedure ........
//        public void Speak()
//        {
//            Console.WriteLine("I can speak");
//        }
//        // procedure........
//        public void Work()
//        {
//            Console.WriteLine("I can speak");
//        }


//    }
//    //deived class 
//    class Programmer : Person   // drived Class/Child Class
//    {
//        // here هنا تم اخذ كل الخصائص من اعلى وممكن ايضا اضافه خاصائص جديده
//        public double salary { get; set; }
//        public int waight { get; set; }
//        //procedure.....
//        public void Languags(string lang)
//        {
//            Console.WriteLine("I love language " + lang);

//        }
//        //inheritance   for Constructor.....
//        public Programmer(string name, string address, int age, double salary,int waight) : base(name, address, age) //l  طريقه عمل وراثه للكونستراكتور ووممكن لا اعمل له وراثه لو عملت كونستراكتور فارغ
//        {
//            this.salary = salary;
//            this.waight = waight;
//        }
//        public void ShowData()
//        {
//            Console.WriteLine($"MY name is {name}" +
//                $"\n My address is {address}" +
//                $"\n My age is {age}" +
//                $"\n Salary is {salary}" +
//                $"\n My wight is {waight}" +
//                $"\n Thanks ......");
//        }



//    }
//}


 
    }
    class Method_Overloading
    {
        /*
          *when Creat Many Mathods With Same Name But with different Parameters
          *its kind of plymorphisme
          *الغرض منها اوقات نحتاجها فى البحث فى قاعده البيانات 
          *
          *
        */
        //        /*
//         * Method Overloading
//         * mean that Many Methods with same name But with different Parameters
//         * اوقات نستخدمها فى البحث فى قواعد البيانات 
//         * is consider Type Of Polymorphisme
//         * 
//         */

///using System;
//namespace Executable
//{
//    class Prog
//    {
//        /*
//         * Method Overloading
//         * mean that Many Methods with same name But with different Parameters
//         * اوقات نستخدمها فى البحث فى قواعد البيانات 
//         * is consider Type Of Polymorphisme
//         * 
//         */
//        static void Main()
//        {
//            overloadingPolymorphisme OverLoad = new overloadingPolymorphisme("LG", 050);
//            OverLoad.searchInfo(666); // حيث يظهر هنا اكثر من اختيار وهذا هو مفهوم اوفر لودينج
//        }
//    }
//}
//    class overloadingPolymorphisme
//    {

//        // properties-attributes-fields
//        public string tvName { get; set; }
//        public int tvId { get; set; }


//        //Constructor
//        public overloadingPolymorphisme(string _tvName, int _tvId)
//        {
//            this.tvName = _tvName;
//            this.tvId = _tvId;
//        }

//        //Methods

//        public void searchInfo(string _tvName)
//        {
//        Console.WriteLine("Toshipa"); 
//        }

//        public void searchInfo(int _tvId)
//        {
//        Console.WriteLine("0581847320");
//        }

//        public void searchInfo()
//        {
//        Console.WriteLine("under maintanance");
//        }

//        // Another Ex
//        public void Find(string _tvName)  // لارجاع مجموعه من الحواسيب او ممكن لا نستخدمها
//        {
            
//        }
//        public void Find(int _tvId)
//        {
            
//        }

//    }



    }
    class Overriding
{
    //using System;
//namespace Exexutable
//{
//                /*
//                *Its Method in based Class and we want to override it again in scope of dreived class 
//                *Overriding  عمليه اعاده التعريف تسمى 
//                *thre are 2 ways 
//                *1-Using keyword virual in base class and override in drived class  called override
//                *2-using keyword new in dreived class  called hiding or shadwing 
//                */
//class Prog
//    {
//        static void Main()
//        {
//            Programmer Progg = new Programmer();
//            Person Per = new Person();
//            Progg.Name();
//            Progg.Speaking();
            
//        }
//    }
//    //Based Classe
//    class Person
//    {
//        public virtual void Name()
//        {
//            Console.WriteLine("Im Working .........");
//        }

//        //---For second Way Hiding
//        public void Speaking()
//        {
//            Console.WriteLine("i speak ........");
//        }
//    }
//    //Derived Class
//    class Programmer:Person
//    {
//        // First Way using Overriding
//        public override void Name()
//        {
//            base.Name();  // That Mean Will Print Massage in Based Class
//            Console.WriteLine("Im Programmer");// massage after override
//        }
//        // for second Way
//        public new void Speaking()
//        {
//            Console.WriteLine("i speak ........  C#");
//        }
//    }
//}



}
    class Abstract_Classes_And_Sealed_Classes
    {
        //using System;
//namespace Executable
//{
//    class Prog
//    {
//        static void Main()
//        {

//            Abstraction.AbstractTwo Abs = new Abstraction.AbstractTwo("LoLAAAA");
//            Abs.Walking();
//        }
//    }
//}

//namespace Abstraction
//{
//    abstract class AbstractOne  // abstract mean cant make intance  but can make inheritance to redeclare it 
//    {
//        //Abstract class cant inheritance it but can creat new class to inherit from it 
//        //A-انشاء انواع عامه لايمكن استنساخها  اى لا يمكن عمل اوبجت منها والحل وقتها ان لابد من عمل كلاس يرث منها
//        //A-الهدف انشاء انواع عامه تسمح لنا باختبارات معينه
//        //A-هى شئ افتراضى وغير حقيقى

//        //Properties
//        public string name { get; set; }

//        //Constructor
//        public AbstractOne(string name)
//        {
//            this.name = name;
//        }


//        //Procedure....
//        public void showMassages() // Must لابد من اعاده تعريفها طالما تم استخدام ابستراكت
//        {

//            Console.WriteLine($"My Name is {name}");
//        }
//        public void Walking()
//        {
//            Console.WriteLine("Im Walking");
//        }

//    }


//    class AbstractTwo : AbstractOne
//    {
//        public AbstractTwo(string name) : base(name)
//        {
//            this.name = name;
//        }
//    }
//                     /*
//                      * Sealed Classes.......
//                      * 
//                      * cant inherite it never وهى ومستقه بذاتها 
//                      * A بمعنى انها تحمى الكلاس من اى عمليه وراثه
//                      */
//    sealed class Book
//    {
//        // Cant Make any inheritnce from Book
//    }
//}
    }

    





    



