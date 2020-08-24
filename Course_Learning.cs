using System;  // called namespace // that mean i will use namespace called "System"  //تسمى مكتبه  library..................//هى من الاخر مكتبه عشان هاستخدم جواها حاجات زى كونسول
using static System.Console; //console  فى حاله لو لا نريد كتابه   <----
using static System.Convert; //convert  فى حاله لو لا نريد كتابه   <----


//Solution Explorer عند انشاء المشروع بالبدايه خالص يتم تكوين شئ اسمه 
//ماذا يحتوى اذن ؟؟؟ 
//1- solution ودى بتعرفنى كام مشروع موجود وممكن عمل مشروع جديد اخر منه
//2-solution ماذا يحتوى ؟؟؟
//يحتوى على  اسم المشروع ويكون هذا هو اسم نيم سبيس اتوماتيك  الذى تعمل عمله من البدايه وبداخله عدد 2 ملف وهم 
//dependencies ويتحوى على مكتبات كتير تسهل التعامل مع الطابعات ووووو حيث تتم اوتوماتيك 
//programme.cs وهذا هو ملف المشروع وبيتعمل كلاس ويكون بنفس الاسم اتوماتيك 

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

 


namespace Training   //  مثل المجلد  ويقوم بترتيب الكود وعن طريقه عن انشاء واحد جديد وقتها اقدر استخدم كلاس بنفس الاسم فى كلاس سابق عادى 
// اى يسمح لنا بعمل كلاس بنفس الاسم فى كلاس اخر
//وهى من الاخر المشروع بتاعى اللى اسمه كذا 


{

    class Lesson_11_Rules_Identifiers //ولكن خاص بنا  namespace    ملف تحت المجلد ويسمى ايضا  //class---> object يتم كتابه داخلها كل الاوامر لان السى شارب عباره عن اوبجت اورينتيت وكل شئ عباره عن   
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
    class Lesson_12_Data_Types_Variables 
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

            /*byte b=10;  //byte   // max value is 255 
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


            //----------------------
            /*
             *bool bb=true;
             *bool bbb =false;
             */
           
           

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

            
            // intialize ---?  that mean give value for variable


        }
     }
    class Lesson_13_Printing
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
            // assignment operator     =

            // + addition      - subtraction    * multiplication  / division    % -> Modulus اى متبقى قسمه   ++ increemnt   -- decrement
            //int number_1 = 10, number_2 = 5 , count = number_1 * number_2; // Can declare One Data Type if all same 
            // ################   using  +=
            /*
            *int x=10;
            * x+=90;  //output 100  
            */

            //####################using +
            /*
             *int x=10+5; // out 15
             *
             */
            //##############   using  ++  or --  
            //             int x = 10;
            // x += 1;  //  or ++
            // Console.WriteLine(x);

            //#############################


            
            //Console.WriteLine($"The Number is {count} ");


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


            //#####################   Calculate Total from 1-5
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
    class Methods_OR_Function
    {
        public static void Main() 
        {
            /*
             * The Structure Of a Method (access Modifier-return type-parameter-method body)
             * The Difference between Static and Instance Method
             * Methods Useful because the allow you define your logic once and use it at many places
             * Maintenance is easier
             * 
             */

            //must creat intance or object from that class to can call instance Function
            Methods_OR_Function M = new Methods_OR_Function();
            //M.EvenNumbers();
            //if it static method in this case just write name class and call static methos
            Methods_OR_Function.EvenNumbers(20);// or EvenNumbers(20); // مباشر لانها داخل نفس الكلاس
            int result=M.Multi(10, 90); //
            Console.WriteLine(result);

            
        }
        // Make Method calling Even Numbers
        public static void EvenNumbers(int y)  // public called access Modifiers //void called return type
        {
            int n = 0;
            while (n <= y)
            {
                Console.WriteLine(n);
                n++;
            }
        }
        // method which contain static called static methos same like main method وهنا عشان انادى عليها فقط اكتب اسم الكلاس
        //method which dosent contain ststic called intance method same like EvenNumbers عشان انادى  عليها لازم عمل اوبجت جديد
        public int Multi(int a,int b)  // mean will trturn data type int
        {
            return a + b;  // this called intance method and return int
        }



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
    namespace classes
    {
          class Programme
    {
        static void Main()
        {  
            /*
             * what is a class
             * purpose of a class constructor
             * overloading class constructor
             * understanding this keyword
             * Destructors
             */
            //Class consists of 
            /*
             * fields
             * methods
             */
            Customer CC = new Customer("Leen", "Reda");// Her Must use parameter but there are way for not use by creat another constructor
            // her---->لان يوجد عدد ٢ كونستراكتور بنفس اسم الكلاس Over Loading  هنا يظهر كلمه 
            // CC.PrintFullName();
        }
    }
    class Customer
    {
        string firstName;   // called field
        string lastName;
        // then creat constructor to initialization to fields
        //the pupose of a class constructor is to initialize class fields
        // Constructor do not have return vlaues and always have the same name as the class
        // Constructors are not mandatory . if we dont provide a constructor a default parameters less constructor is automatically provided

        // then creat constructor to initialization to fields
        // لو  اعطيت قيم للفيدلز لن احتاج الى كونستراكتور
        public Customer(string fName, string lName)  // called constructor  لاعطاء قيم ابتدائيه 
        {
            this.firstName = fName;  // We Can Dispense with "this" why use this ? that mean as if كما لو  i created object from class called "Customer "
            this.lastName = lName;
             
        }
        public Customer() : this("No First Name", "No Last name")  // بقوم بانشاء ذلك لو مش عايز استخدم فوق اى براميتر
        {

        }
   
        //destructors
        // Make Release for resources  يقوم بنتظيف الذاكره بعد انتهاء البرنامج
        ~Customer()
        {
            // garbage collection make calling automatic for this Destructor
        }

    }

    }

    namespace Static_And_Instance_Class_Mmbers
{
    class Static_And_Instance_Class_Mmbers
    {
        static void Main()
        {
            /*
             * Class Member : = field,method,properties,events,indexers,constructors.
             * static member : are invoked using class name ,where as instance members are invoked using instance(object) Of the class
             * static constructor:are used to initialize static field in class and only called once and called befor instance constructor
             * Static Class Members: 
             * Instance Class Members
             * Difference between Static and Instance Members
             * An example explaining when you should make certain Members Static
             */
            //first Object 
            Circle Cr = new Circle(5);  // object
            float area_a=Cr.CalculateArea(); // To Call instance Method  وتم تخزينها فى متغير فلووت لانها هاترجع فلووت
            Console.WriteLine("Area is {0} ", area_a);
            // Second object  
            Circle Cr2 = new Circle(9);  // نصف القطر ٩
            float araea_b=Cr2.CalculateArea();
            Console.WriteLine("Area ={0}", araea_b);
            // if i want many objects the value of "PI" Never change .
            // every time we creat new object we store pi in memory and that way not good so what solution ??
            // we will declare variable pi as static field


            // if i want print direct must first add  public before static
            Console.WriteLine(Circle.pi);


        }
    }
    class Circle
    {
        // k--حساب مساحه الدائره التى  نصف قطرها ٥  
        //static float pi = 3.14f;  // static field to improve memory and if i want to initial value must creat static constructor
        public static float pi = 3.14f;  // make it public to can use direct in line 28
        int radius;
        static Circle()  // static constructor didnt have access modifiers like (public) حيث يتم تنفيذه مره واحده فقط  وبيكون اول شئ بيتم تنفيذه
        {
            // if i use print here لو استخدمت اى جمله طباعه هنا سيتم الطابعه مره واحده مع ان يوجد ٢ اوبجت
            Console.WriteLine("static constructor");
            pi =3.14f;
        }

        public Circle(int rRadius) // intance constructor 
        {
            Console.WriteLine("Instance constructor");  // هنا سيتم الطباعه مرتين لان يوجد عدد ٢ اوبجت
            this.radius = rRadius;
        } 
         public float CalculateArea()
        {
            //return this.pi * this.radius * this.radius;
            return Circle.pi * this.radius * this.radius;    //to improve memory
        }

    }

}
    class Lesson_36_OOP 
    {
        static void Main_36()
        {
            //  اهم شئ فيها الكلاس والكلاس يعتبر تمثيل شامل 
            // copy from class called object  this operation called instance
            //Can make new class called for ex computer include 1- properties 2-methods 3-events

        }

    }
    class Lesson_37_Properties_and_access_Modifiers
    {
        //properties - or Attributes    مثلا كمبيوتر وله خصائص وهذه هى الخصائص
        // public string brand;   
        // public double price;
        // public DateTime manufacturedate;
        // public string color;

        // access modifiers  
        //public   private   internal    protected 
        //public  اى ممكن الوصول له من اى مكان حتى لو ملف اخر حتى لو مشروع اخر
        //private على مستوى الكلاس التى تحتوى عليه فقط
        //internal  تسمح من الداخل والخارج ولكن على مستوى المشروع لكن لو ذهبنا لمشروع اخر لن يعمل هى مثل البابلك 
        //protected  فقط على مستوى الفئات او مشتقاته هى مثل البرايفت بس الفرق انها تعمل ايضا على اى شئ يرث منها 





    }
    class lesson_38_Encapsulation_Full_properties_autoproperties
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

    }
    class Lesson_39_Methods
    {
        // function or procedures عباره عن داله او اجراء method <----
        // الشرح موجود فى فجيول بيسيك ستوديو
    
    }
    class Lesson_40_Constructor
    {
        // Constructor  maen->  A constructor is a  special method that is used to initialize objects.
        //يحمل نفس اسم الكلاس وليس له ارجاع 
       // public بمعنى ممكن عمله عند انشاؤ الكلاس وبيكون بنفس اسمه ويكون  
       // look at next slid in lesson 39





       // public string name{get;set;}
        // public byte age{get;set;}
        // public string color;
        // public string love;


             //can write it automatic by write (ctor)
             // when creat constructor must be public and must take same name for class 
             // we use it to define prperty or attributes in class by many methods 
             // we use constructor to save time with short code


        // public Constructors(string newname,byte newage)  
        // {
        //     name=newname;  //  can define by parameter   عند استخدام البراميتر لازم ايضا تعريفه فى براميتر الاوبجت عند عمله 
        //     age=newage;   //  can define by parameter
        //     love="Family";  // can also define it direct
        //     this.color="red";  // can use this 
 
        // }
        // static void Main()
        // {
        //     Constructors pp=new Constructors("loloooooooo",66);
           
        //     Console.WriteLine("My daughter's name is " + pp.name + " \n " + "Her age is "+ pp.age + " Years old"+"\n its color is "+pp.color + "\n"+pp.love);
        // }




    }
    class Lesson_41_Inheritance
    {
        // Inheritance mean t is possible to inherit fields and methods from one class to another. 

        //Derived Class (child) - the class that inherits from another class
        //Base Class (parent) - the class being inherited from
        // اى نقل مكونات الفئه الرئيسيه الى الفئه المشتقه
        //الغرض منه تفادى تكرار الاكواد

        
    }
    class Method_Overloading

    {
      // 
        // static int Multi(int x, int y)
        // {
        //     return x * y;
        // }
        // static double Multi(double x, double y)
        // {
        //     return x + y;
        // }
        // static string Multi(string name)
        // {
        //     return name;
        // }
        // static void Main()
        // {
        //     Console.WriteLine(Multi(10, 5));
        //     Console.WriteLine(Multi(10.8, 5));
        //     Console.WriteLine(Multi("Hamza"));

        // } 
    }
        
    
}

