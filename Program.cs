using System;  // called namespace // that mean i will use namespace called "System"
using static System.Console; //console  فى حاله لو لا نريد كتابه   <----
using static System.Convert; //convert  فى حاله لو لا نريد كتابه   <----



namespace Training   //مثل المجلد  
{

    class Lesson_11_Rules_Isentifiers //ولكن خاص بنا  namespace    ملف تحت المجلد ويسمى ايضا  //class---> object يتم كتابه داخلها كل الاوامر لان السى شارب عباره عن اوبجت اورينتيت وكل شئ عباره عن كائن او 
    {
        static void Main_11()  // called method    called main method  // all is reserved keywords 
        {
            
            //identifier //هو المعرف    اسم يتم اعطائه وغير مسحموح برقم بالاول 
            //like --> program - main  -names of variables-   وله ضوابط 
            // تبدا  بحروف و واندر سكور وبعدها ارقام فقط وغير مسحموح بارقام بالاول  
            // م وغير مسموح برموز غير الرمز اندرسكور
            //------
            // Case sesitive اللغه حساسه جدا للحروف 
            // ;-> when we see it in end if line we will call it   "statement" 
            // Variable -> هو مكان فى الذاكره لتخزين عليه البيانات 
            // حيث يت تخزين البيانات فى الرامات وتتم العمليات الحسابيه فى البروسيسور 
            // variables   has  kind  Called "data Type"   and has name called  "identifier"
            //x//  _  يفضل عدم استخدامه بالبدايه عند تعريف اسم متغير 
            //x#// المتعيرات يفضل ان تبدا بخرف صغير
            // = called    assignment  operator
            //----------------------------------------------------



        }
    }
    class Lesson_12_Data_Types_Variables 
    {
        static void Main_12()
        {
             
            //Data Type :-
            //1- Numeric Data Type consists of  مرتبين ترتيب تصاعدى

            /*byte b=10;  //byte   // maxvalue is 255 
             * we can use method to know that ->console.Writeline(byte.maxvalue); //->output is 255
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
           
           
            //------------------------------------------------------------------

            // can make default value for variables 
            //string wew=default (string);  //  output zero  or nothing 
            // we can declare variable without assign it 
            //string df;
            //or Multiple Declarations
            //int x,y,z;
            //then assignment fo variable


        }
    }
    class Lesson_13_Printing
    {
        static void Main_13()
        {
            //Console.WriteLine(ss);  // called also method and all  methods has ()  and called also statement because has end of it ;
            //Console.Write("Leen"); //Write نستخدمها للطباعه ولكن بدون عمل سطر جديد
            //Console.WriteLine("Leen"); //writeline -> مثلها ولكن تعمل سطر جديد
            //  ways to print variables ---------
            //string name = "Leen love";
            //byte age = 4;
            //Console.WriteLine("My lovely daughter is " + name + " clearHer Age is " + age); 
            // + -> called concatenation يقوم بعمليه الدمج بين النصوص ويستخدم ايضا للجمع بين الاعداد
            //-- another way for concatenation 
            //Console.WriteLine("My love is {0} and her age is {1} " , name , age);
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
            //Console.WriteLine($"Welcome mr {name_1} your Age is { age_1 } Years Old  ");


        }
    }
    class Lesson_14_Arithmetic_Operators
    {
        static void Main_14()
        {
            // + addition      - substaction    * multiplication  / division    % -> Modulus اى متبقى قسمه   ++ increemnt   -- decrement
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

        }
    }
    class Lesson_17_If_Statement
    {
        static void Main_17()
        {
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
            //######### using if -->use two numbers if chracter is + - *  excute that
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

            //Nested If
            //             int x = 10;
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
        }
    }
    class Lesson_18_switch_case
    {
        static void Main_18()
        {
            //#########################Quize######################################
            //######### using swich  -->use two numbers if chracter is + - *  excute that
            // int nn_1 ,  nn_2 , result ; 
            // char ch ;
            
            // Console.WriteLine("Enter First Number please ");
            // nn_1 =Convert.ToInt32(Console.ReadLine());

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


            //#############   Same EX
            //             Console.WriteLine("Enter First Number ");
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



        }
    }
    class Lesson_19_Ternary_Oeraor
    {
        static void Main_19()
        {
                        // int n_1=10  , nn_2=20;
            // var massage=n_1<nn_2 ? "greater" : "less";  // var or string but i use var to let compiler choose 
            // Console.WriteLine(massage);

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
            //             int i = 0;
            // for(; ; )
            // {
            //     if (i<=10)
            //     {
            //         Console.WriteLine($"Multiplication 2  *  {i} =  {i * 2} ");
            //         i++;
            //     }
            //     else
            //     {
            //         break;
            //     }
            // }

            //##################################  EX

            //             int i = 0;
            // for(; ; )
            // {
            //     if (i<10)
            //     {
            //         Console.WriteLine($"Number of i is : {i} ");
            //         i++;
            //     }
            //     else
            //     {
            //         break;
            //     }
            // }


            //##################################
            //             for (int i=0;i<=10;i++)
            // {
            //     if (i == 7)
            //         break;   // when found 7 stop
            //     Console.WriteLine(i);

            // }


            //######################################
            //             for (int i=0;i<=10;i++)
            // {
            //     if (i == 7)
            //         continue;    // skip for 7 only 
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
            // int i;
            // back:WriteLine("Guess Any Number");
            // i=ToInt32(ReadLine());
            // while (i !=13)
            // {
            //     WriteLine("you loss !!");
            //     goto back;   // نستخدممها لتكرار الامر ونضع اى اسم  هنا وضعت اسم باك ووضعتها ايضا فوق امام الامر المراد تكراره
            // }
            // WriteLine("You Win");

            //###############################

            // int i=0;
            // while (i<=5)
            // {
            //     WriteLine("The Value Of i {0}" , i);
            //     i++;
            // }

            //#######################################
            // int i =0;
            // while (true)
            // {
            //     WriteLine(i);
            //     i++;
            //     if (i>=20)
            //     break;
            // }

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



        }
    }
    class Lesson_23_foreach_loop
    {
        static void Main_23()
        {
                        // Deals with arrays 
            // string[] names={"leen", "Hamza","hadeer"};  // array
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
            //--->Implicit Casting  تلقائى     and      Explicit Casting   قصرى-اجبارى 
            //#### implicit casting  يتم التحويل بدون تلف البيانات وبيكون من نوع الى نوع اصغر منه 
            // int nn=10;
            // double gg =nn;

            // //explicit casting  وهنا لو تم التحوويل بالعكس 
            // double kk=4.6;
            // //int kj=kk;  //double  اصغر من  int  هنا هايكون فى خطأ لان 
            // //int kj=(int)kk;  //  هناا الحل للتحويل وسين عرض الرقم الصحيح فقط دون ما بعد العلامه العشريه
            // // can use convert  but it different 
            // int kj=ToInt32(kk);// الاختلاف فقط ان هنا هايقوم بالتقريب ويكون الناتج ٥
            // //### ex 
            // long pl=long.MaxValue;  // هنا بقوله اعطنى اكبر قيمه ممكنه
            // int md =(int)pl;  // الناتج هنا هايكون ١- لانه لن يستوعبها 


        }
    }
    class Lesson_27_String_Manipulation
    {
        static void Main_27()
        {
                        string Nmmmed="leen reda mahmoud";
            WriteLine(Nmmmed.Length);  // لمعرفه عدد الحروف 
            WriteLine(Nmmmed.ToUpper());  // Capital letters 
            WriteLine(Nmmmed.ToLower());
            WriteLine(Nmmmed.Substring(0,10)); // يقتطع الكلمه المراد
            string[]jj=Nmmmed.Split(' ');  // بيقطع الكلمه كيف ؟ الميثود بتروح للفاريبال وتشوف الفراغ ده فين
            WriteLine(jj[0]);
            // ممكن الدمج لهم  by using join  or concat
            WriteLine(jj[0] + "--" + jj[1] + "-"+ jj[2]);  
            WriteLine(string.Concat(jj[0],jj[1],jj[2])); // using concat but without spaces 
            // if i want to put spaces 
            WriteLine(string.Join("//",jj[0],jj[1],jj[2])); // using join with spaces 
            WriteLine(Nmmmed.Contains("lee")); // للتاكد من ان حروف معينه موجوده
            // another solution using if
            if (Nmmmed.IndexOf("mahmoud")!=1)
            {
                WriteLine($"name is exist its numcer {Nmmmed.IndexOf("mahmoud")}");
            }
            else
            {
                WriteLine("Not exist");

            }
                       
            string name = "Suresh Dasari";
            WriteLine(name.IndexOf("u"));
            if (name.IndexOf("esh")<=3)
            {
                WriteLine( $"yes {name.IndexOf("esh")}");
            }
            else
            {
                WriteLine("no");
            }
            

        }
    }
    
}

//good jop