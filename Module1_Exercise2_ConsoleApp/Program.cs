using System.Linq;

namespace Module1_Exercise2_ConsoleApp
{
    using System;
    using System.Diagnostics;

    internal class Program
    {

        public static void OutFunction(ref Car car)
        {
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int r = new Random().Next(-100, 100);

            int toOut = 222;

            var name10 = Function(10);
            var name12 = Function(12);

            int[] numbers = new[] { /*0*/99, /*1*/98, /*2*/97, /*3*/96 };

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = 22;
                Console.WriteLine(numbers[i]);
            }

            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            var length = numbers.Length;

            Console.WriteLine(numbers[0]);
            numbers[0] = 22;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            ForLoop();

            //int index = 11;
            //while (index < 10)
            //{
            //    Console.WriteLine(index);
            //    if (index == 5)
            //    {
            //        index++;
            //        continue;
            //    }

            //    index++;
            //}

            var index = 5;
            do 
            {
                continue;
                Console.WriteLine("123");
                index++;
            } while (index < 5);

            SwitchExample();

            //IfElseExample();
            IfElseElseIfExample();

            byte number = 4; // 0000 0100
            short number2 = number; // 00000000 00000100

            byte number3 = (byte)number2; //00000100

            short number_1 = 256; // 0000001 0000000
            int number2_1 = number_1; // 00000000 00000000 00000001 00000000

            short number3_1 = (short)number2_1; //00000001 00000000


            short number_2 = 255; //0000000 1111111
            byte @byte = (byte)number_2; // 1111111


            Car car1 = new Car { A =  10, IsStated = false, Name = "asdadasd", Weight = 20};
            Car car2 = car1; // reference type | = - copy of reference
            car2.A = 20;

            object car_ob = car1; // upcast
            Car down_cast = (Car)car_ob; // downcast

            Console.WriteLine(car1.A);
            Console.WriteLine(car2.A);

            car2.Name = "Updated";

            Console.WriteLine(car1.Name);
            Console.WriteLine(car2.Name);

            StructA structA1 = new StructA { A = 10, Name = "Vlad" };
            StructA structA2 = structA1;

            object ob_st = structA1; // value types and boxing.

            int x1 = 12;
            object obj = x1; // boxing
            int unboxing_obj = (int)obj; // unboxing


            //StructA structA3 = new StructA()
            //{
            //    A = structA1.A,
            //    Name = structA1.Name,
            //};

            structA2.Name = "Vlad Updated";

            structA2.A = 20;

            Console.WriteLine(structA1.A);
            Console.WriteLine(structA2.A);

            Console.WriteLine(structA1.Name);
            Console.WriteLine(structA2.Name);

            // class, string, Exception, Delegate, Array - reference types.
            // struct, enum, int, byte, long, char ...

            byte by = 1;
            ValueType a = by;

            var read = Console.ReadLine();
            int N = int.Parse(read);

            Params("stqwe",  2, 4, 6);
            var car = new Car();
            int x = 0;

            string s = ChangeNumber(ref x);
            
            ChangeCarName(ref car);

            SwitchExample();
            SwitchExample();
            SwitchExample();
            SwitchExample();

            IfElseElseIfExample();

            string str = "text";
            string[] strs = new string[2] { "asd", "123" };

            Console.WriteLine(str);
            //DisplayExample(str);
            //DisplayRefExample(ref str);
            
            ArrayRefExample(strs);

            //DisplayIn(ref str);

            //DisplayOutExample(out string str1);

            DisplayOutExample(out string str1);

            Console.WriteLine(str1);

            Console.WriteLine(str);
        }

        public static void MethodOrFunction(string[] strings)
        {
            strings[0] = "asdasd";
        }

        public static string Function(int number)
        {
            Console.WriteLine(number);
            return "Vlad" + number;
        }


        public static void MethodOrFunction(string anotherOne, int anotherTwo) // overload example 1
        {
            Console.WriteLine($"MethodOrFunction Overload1 - 1: {anotherOne} 2: {anotherTwo}");
        }

        public static void MethodOrFunction(byte @byte, string anotherOne, bool anotherTwo = true) // overload example 2
        {
            Console.WriteLine($"MethodOrFunction Overload2 - 1: {@byte} 2: {anotherOne} 3: {anotherTwo}");//  $"{your_varialbe}" - string interpolation.
        }

        public static string ChangeNumber(ref int change)
        {
            change = 10;
            Console.WriteLine(change);

            return "asdasdasd";
        }

        public static void ChangeCarName(ref Car change)
        {
            change.Name = "new Name";
            change = new Car();
            change.Weight = 10;
        }

        public static void ClassRefTypeExample()
        {
            Console.WriteLine("Method: ClassExampleRefType");
            var class_A1 = new Car
            {
                A = 10
            };

            Console.WriteLine("class_A1.A: " + class_A1.A);

            Car class_A2 = class_A1;

            class_A1.A = 200;

            class_A1 = new Car
            {
                A = 500
            };

            Console.WriteLine("class_A2.A: " + class_A2.A);
            
            //var randomNumber = new Random().Next(-500, 500); // For HomeWork
        }


        public static void StructValueTypeExample()
        {
            var struct_A1 = new StructA
            {
                A = 20
            };

            Console.WriteLine("struct_A1.A: " + struct_A1.A);

            StructA struct_A2 = struct_A1;
            struct_A2.A = 200;
            Console.WriteLine("struct_A2.A: " + struct_A2.A);
        }

        public static void DisplayExample(string text)
        {
            text = "DisplayRef_Changed"; // Okey
            Console.WriteLine("From DisplayRef_Changed: " + text);
        }

        public static void DisplayIn(in string text)
        {
            //text = "123"; // Error
            Console.WriteLine(text);
        }

        public static void DisplayRefExample(ref int text)
        {
            Console.WriteLine(text);
        }

        public static void Params(string text,  params int[] ints)
        {
    
        }

        public static void ArrayRefExample(string[] texts)
        {
            for (int i = 0; i < texts.Length; i++)
            {
                texts[i] = $"vlad_{i}";
            }
        }

        public static void DisplayOutExample(out string text) // with out I'm always should fill its.
        {
            //var map = new Dictionary<int, string>(); // example where in .NET we use out params, by convension with bool TryGet(... out var param), bool TryCheck(... out var param), bool TrySomethin(..., out var param)
            //map.TryGetValue(0, out var newValue);

            text = "DisplayOut_Changed"; // Okey
            Console.WriteLine(text);
        }

        public static void ArraysExample()
        {
            //Array is ref type. (does not matter what type inside array struct or class.)
            string[] strings = new string[200000]; // created array with 20 null strings because string is ref type and default value of ref type is null;

            var watcher = new Stopwatch();
            watcher.Start();
            for (int i = 0; i < strings.Length; i++)
            {
                strings[i] = "str_" + i; 
            }

            watcher.Stop();
            var time = watcher.Elapsed;

            foreach (string str in strings)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("Display All Values in Strings");
            for (int i = 0; i < strings.Length; i++)
            {
                Console.Write(i + " ");
            }

            //Now strings are full with str_0 to str_19

            int[] ints = new int[20]; //created array with 20 items everyone with 0 value because int is value type and default int value type is 0;
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = i;
            }

            Console.WriteLine("Display All Values in Ints");
            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write(ints[i] + " ");
            }
            //Now ints are full with 0 to 19 values
        }

        public static void IfElseBadWeatherExample()
        {
            // == | != | < | <= | > | >=
            bool itRain = false;

            if (itRain) 
            {
                Console.WriteLine("Take the umbrella and go to paddles.");

            } else
            {
                Console.WriteLine("Do not take the umbrella.");
            }
        }

        public static void ArrayOfArrayExample()
        {
            int[][] matrix = new int[3][]
            {
                new [] { 1, 2, 3, 9 },
                new [] { 1, 2, },
                new [] { 1, 2, 3 }
            }; // every inner array is null because c#'s array is ref type.

            for (int i = 0; i < matrix.Length; i++)
            {
                int[] temp = new int[i];
                matrix[i] = temp;
            }

            int[][][] s  = new int[10][][];
            s[0] = matrix;

            var array = new [] { 5, 6, 4, 3, 5 , 5 };

            Array.Sort(array);

            Console.WriteLine("Array is initialized");

            int[, ] matrix2 = new int[3, 5]; // every inner array is initialized with 4 elemented array.
            int[,,] ss = new int[5, 7, 4];
        }

        public static void ForLoop()
        {

            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine("Ohh 5 is special number therefore we have continue:" + i);
                }
                Console.WriteLine("Hello World" + i);
            }

            for (/*1 step one time*/int i = 0; /*2 step */i < 10; /*4 step */++i)
            {
                /*3 step */

                if (i == 5)
                {
                    Console.WriteLine("Ohh 5 is special number therefore we have continue:" + i);
                }

                Console.WriteLine("Hello World" + i);
            }


            string text = "red green blue five1 vlad123";
            string[] textSplitedBySpace = "red green blue five1 vlad123".Split(" ");

            for (int i = 0; i < textSplitedBySpace.Length; i++)
            {
                Console.WriteLine();
                string word = textSplitedBySpace[i];
                for (int j = 0; j < word.Length; j++)
                {
                    Console.Write(word[j].ToString() + ' ');
                }
            }

            Console.WriteLine(text);
        }

        public static void DoWhileLoop()
        {
            int index = 3;

            do
            {
                Console.WriteLine("index i:" + index);
                index++;

            } while (index < 10);
        }

        public static void ForEachLoop()
        {
            var myName = "vlad";

            foreach (char symbol in myName)
            {
                Console.WriteLine(symbol);
            }
        }

        public static void IfElseExample()
        {
            // 0 = false;
            // 1 = true;

            // true && true = true
            // true && false = false
            // false && true = false
            // false && false = false

            // true || true = true
            // true || false = true
            // false || true = true
            // false || false = false

            // !!false = !true = false
            // !true = false
            // !false = true

            bool isRain = false;

            string status = "Ok";

            string g = (status == "Ok") ? "Green" : "Black";



            if (isRain)
            {
                Console.WriteLine("Rain is coming.");
            }
            else
            {
                Console.WriteLine("Rain is not coming.");
            }
        }

        public static void IfElseElseIfExample()
        {
            int distance = 12313;

            if (distance < 10)
            {
                Console.WriteLine("Short distance.");
            }
            else if (distance < 20)
            {
                Console.WriteLine("Medium distance.");
            }
            else if (distance < 40)
            {
                Console.WriteLine("Long distance.");
            }
            else
            {
                Console.WriteLine("Very very very very Long distance");
            } 
        }

        public static void SwitchExample()
        {
            string colour = "asdasd";

            switch (colour)
            {
                case "Red":
                    // Your other code logic.
                    Console.WriteLine("I know `Red`, cool.");
                    break;
                case "Black":
                    // Your other code logic.
                    Console.WriteLine("I know `Black`, cool.");
                    break;
                case "Yellow":
                    // Your other code logic.
                    Console.WriteLine("I know `Yellow`, cool.");
                    break;
                default:
                    Console.WriteLine("I Do not know colour...");
                    break;
            }

            if (colour == "Red")
            {
                Console.WriteLine("I know `Red`, cool.");
            }
            else if (colour == "Black")
            {
                Console.WriteLine("I know `Black`, cool.");
            }
            else if (colour == "Yellow")
            {
                Console.WriteLine("I know `Yellow`, cool.");
            }
            else
            {
                Console.WriteLine("I Do not know colour...");
            }
        }

        public static void BoxingAndUnboxing()
        {
            //Boxing

            object o = 4; // boxing because int is struct;
            int number = (int)o; // unboxing

            object structure = new StructA();//boxing because StructA is struct;
            StructA structureUnboxed = (StructA)structure;//boxing because StructA is struct;

            object car = new Car();//no-boxing because Car is class;
            Car carUnboxed = (Car)car;//boxing because StructA is struct;

            //Boxing

            object str = "some string"; // no-boxing, just upcast because string is class
            object strObject = (string)str; // downcast
        }
    }
}