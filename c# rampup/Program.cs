namespace first
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // pound to kilogram converter
            Console.WriteLine("pound to kilogram");
            int pound = Convert.ToInt32(Console.ReadLine());
            Double kilogram = pound / 2.2;
            Console.WriteLine(pound + "lb is " + kilogram + "kg");

            // mile to kilometer converter
            Console.WriteLine("mile to kilometer");
            int  mile= Convert.ToInt32(Console.ReadLine());
            Double  kilometer= mile * 1.609 ;
            Console.WriteLine( mile + "mi is " + kilometer + "km");

            // Fahrenheit to Celsius converter
            Console.WriteLine("Fahrenheit to Celsius converter");
            int Fahrenheit = Convert.ToInt32(Console.ReadLine());
            Double Celsius = (Fahrenheit - 32) * 5/9 ;
            Console.WriteLine(Fahrenheit + "°F is " + Celsius + "°c");

            // average age of the group
            Console.WriteLine("Group age");
            int st1 = Convert.ToInt32(Console.ReadLine());
            int st2 = Convert.ToInt32(Console.ReadLine());
            int st3 = Convert.ToInt32(Console.ReadLine());
            int st4 = Convert.ToInt32(Console.ReadLine());
            int st5 = Convert.ToInt32(Console.ReadLine());
            int st6 = Convert.ToInt32(Console.ReadLine());
            int st7 = Convert.ToInt32(Console.ReadLine());
            int st8 = Convert.ToInt32(Console.ReadLine());
            int st9 = Convert.ToInt32(Console.ReadLine());
            int st10 = Convert.ToInt32(Console.ReadLine());
            double st_average = (st1 + st2 + st3 + st4 + st5 + st6 + st7 + st8 + st9 + st10) /10 ;
            Console.WriteLine("The age of the students are" + st1 + st2 + st3 + st4 + st5 + st6 + st7 + st8 + st9 + st10);
            Console.WriteLine("The average of the students is:" + st_average);

        }
    }
}
