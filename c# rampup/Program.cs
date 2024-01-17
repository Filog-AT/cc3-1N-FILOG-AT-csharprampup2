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
            int mile = Convert.ToInt32(Console.ReadLine());
            Double kilometer = mile * 1.609;
            Console.WriteLine(mile + "mi is " + kilometer + "km");

            // Fahrenheit to Celsius converter
            Console.WriteLine("Fahrenheit to Celsius converter");
            int Fahrenheit = Convert.ToInt32(Console.ReadLine());
            Double Celsius = (Fahrenheit - 32) * 5 / 9;
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
            double st_average = (st1 + st2 + st3 + st4 + st5 + st6 + st7 + st8 + st9 + st10) / 10;
            Console.WriteLine("The age of the students are" + st1 + st2 + st3 + st4 + st5 + st6 + st7 + st8 + st9 + st10);
            Console.WriteLine("The average of the students is:" + st_average);

            //Story
            string a = "ken";
            string b = "jay";
            string c = "henry";
            string d = "josh";
            string e = "Pandora's box";
            string f = "Soul Eater";
            string g = "Totem of Undying";
            string h = "Netherite Armor";
            string i = "Lawrence";

            Console.Write($"The wandering hero {a} was traveling with his friend {b} to find " +
                $"{e} which can grant a wish to those who possess it, but along the way, they encountered " +
                $"the demon king {c}. And he challenged them in a fight, and if they defeat him, he will show the way " +
                $"to {e}. They fought for a day until {a} pulled out his legendary sword {f}. But even with {f}, it was" +
                $" not enough to kill {c} that’s until the time stopped, and {d} showed up. {a} and {b} were shocked because" +
                $" {d} is a powerful deity, and they don’t know if he will destroy them. But instead, {d} helped them kill {c}. " +
                $"{c} gave them the {g} which can protect the user from death, and he also gave them {h} which can protect the " +
                $"user from magic and physical attacks. After that, {f} told them, “Entertain me” and disappeared. With the use of" +
                $" {f}, {g}, and the {h}, they finally put an end to {c}. The demon king {c} followed his promise and told them the" +
                $" way to {e}, and they went on their way. And they also rescued {i}, who was a scholar and knows the exact way to" +
                $" {e}.");


                }
    }
}
