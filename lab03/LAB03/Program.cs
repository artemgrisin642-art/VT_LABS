namespace LAB03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Задание 1.1 (Код проверки пишем ниже)
            Rational r1 = new Rational(3, 8);
            Console.WriteLine(r1);


            // Задание 1.2 (Код проверки пишем ниже)
            Rational r2 = new Rational(4);
            Console.WriteLine(r2);

            // Задание 1.3 (Код проверки пишем ниже)
            Rational r3 = new Rational();
            Console.WriteLine(r3);

            // Задание 1.4 (Код проверки пишем ниже)

            //Rational r4 = new Rational(3, 0);
            //Console.WriteLine(r4);

            // Задание 2.1 (Код проверки пишем ниже)
            Rational r5 = new Rational(4, 8);
            Console.WriteLine(r5);

            // Задание 2.2 (Код проверки пишем ниже)
            Rational r6 = new Rational(4, -9);
            Console.WriteLine(r6);

            // Задание 3.1 (Код проверки пишем ниже)
            Console.WriteLine(r1 / r5);


            // Задание 3.2 (Код проверки пишем ниже)
            Console.WriteLine(r1 != r2);
        }
    }
}