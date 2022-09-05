// Задача “со звездочкой”: Напишите функцию, которая принимает одно число - высоту елочки
//  и рисует ее в консоли звездочками.

Console.WriteLine("Насколько высока елочка? ");
            int width = int.Parse(Console.ReadLine());
            for (int i = width; i > 0; i--)
            {
                for (int j = width - i; j < width; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= width - i ; j++)
                {
                    Console.Write("*");
                }
                for (int j = 0; j < width - i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }