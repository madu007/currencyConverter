internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            do {
                double amount = 0;
                double result = 0;
                double dollarNaria = 947.50;
                double dollarPounds = 0.807363;
                double dollarEuro = 0.94;
                double dollarFranc = 0.90;
                double dollarCedi = 11.48;
                double nariaDollar = 0.001277;
                double nariaEuro = 0.0012;
                double nariaFranc = 0.0011;
                double nariaCedi = 0.015;
                double nariaPounds = 0.0010;
                double poundsDollar = 1.24;
                double poundsEuro = 1.15;
                double poundsFranc = 1.11;
                double poundsCedi = 14.22;
                double poundsNaria = 972.11;
                double euroDollar = 1.07;
                double euroNaria = 836.88;
                double euroFranc = 0.96;
                double euroCedi = 12.24;
                double euroPounds = 0.86;
                double francNaria = 875.13;
                double francDollar = 1.12;
                double francEuro = 1.05;
                double francPounds = 0.90;
                double francCedi = 12.80;
                double cediNaria = 68.38;
                double cediDollar = 0.087;
                double cediEuro = 0.082;
                double cediPounds = 0.070;
                double cediFranc = 53.55;
                //double rupee = 0;
                //double yen = 0;
                //double yuan = 0;
                //double rand = 0;
                //double ruble = 0;
                Console.WriteLine("-----------------");
                Console.WriteLine("Convert currency");
                Console.WriteLine("-----------------");

                Console.WriteLine("How much do you want to convert? :");
                amount = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Select currency to convert to: ");
                Console.WriteLine("\t1 : dollar to naria");
                Console.WriteLine("\t2 : dollar to pounds");
                Console.WriteLine("\t3 : dollar to euro");
                Console.WriteLine("\t4 : dollar to franc");
                Console.WriteLine("\t5 : dollar to cedi");
                Console.WriteLine("\t6 : naria to dollar");
                Console.WriteLine("\t7 : naria to pounds");
                Console.WriteLine("\t8 : naria to euro");
                Console.WriteLine("\t9 : naria to franc");
                Console.WriteLine("\t10 : naria to cedi");
                Console.WriteLine("\t11 : pounds to cedi");
                Console.WriteLine("\t12 : pounds to dollar");
                Console.WriteLine("\t13 : pounds to euro");
                Console.WriteLine("\t14 : pounds to franc");
                Console.WriteLine("\t15 : pounds to naria");
                Console.WriteLine("\t16 : euro to naria");
                Console.WriteLine("\t17 : euro to dollar");
                Console.WriteLine("\t18 : euro to franc");
                Console.WriteLine("\t19 : euro to cedi");
                Console.WriteLine("\t20 : euro to pounds");
                Console.WriteLine("\t21 : franc to pounds");
                Console.WriteLine("\t22 : franc to cedi");
                Console.WriteLine("\t23 : franc to dollar");
                Console.WriteLine("\t24 : franc to naria");
                Console.WriteLine("\t25 : franc to euro");
                Console.WriteLine("\t26 : cedi to euro");
                Console.WriteLine("\t27 : cedi to naria");
                Console.WriteLine("\t28 : cedi to dollar");
                Console.WriteLine("\t29 : cedi to pounds");
                Console.WriteLine("\t30 : cedi to franc");

                Console.WriteLine("Enter your`opation");
                switch (Console.ReadLine())
                {
                    case "1":
                        result = amount * dollarNaria;
                        Console.WriteLine($"Your currency: #{result} naria");
                        break;

                    case "2":
                        result = amount * dollarPounds;
                        Console.WriteLine($"Your currency: #{result} pound");
                        break;

                    case "3":
                        result = amount * dollarEuro;
                        Console.WriteLine($"Your currency: #{result} euro");
                        break;

                    case "4":
                        result = amount * dollarFranc;
                        Console.WriteLine($"Your currency: #{result} franc");
                        break;

                    case "5":
                        result = amount * dollarCedi;
                        Console.WriteLine($"Your currency: #{result} cedi");
                        break;

                    case "6":
                        result = amount * nariaDollar;
                        Console.WriteLine($"Your currency: ${result} dollar");
                        break;

                    case "7":
                        result = amount * nariaPounds;
                        Console.WriteLine($"Your currency: #{result} pound");
                        break;

                    case "8":
                        result = amount * nariaEuro;
                        Console.WriteLine($"Your currency: #{result} euro");
                        break;

                    case "9":
                        result = amount * nariaFranc;
                        Console.WriteLine($"Your currency: #{result} franc");
                        break;

                    case "10":
                        result = amount * nariaCedi;
                        Console.WriteLine($"Your currency: #{result} cedi");
                        break;

                    case "11":
                        result = amount * poundsCedi;
                        Console.WriteLine($"Your currency: #{result} cedi");
                        break;

                    case "12":
                        result = amount * poundsDollar;
                        Console.WriteLine($"Your currency: ${result} dollar");
                        break;

                    case "13":
                        result = amount * poundsEuro;
                        Console.WriteLine($"Your currency: #{result} euro");
                        break;

                    case "14":
                        result = amount * poundsFranc;
                        Console.WriteLine($"Your currency: #{result} franc");
                        break;

                    case "15":
                        result = amount * poundsNaria;
                        Console.WriteLine($"Your currency: #{result} naria");
                        break;

                    case "16":
                        result = amount * euroNaria;
                        Console.WriteLine($"Your currency: #{result} naria");
                        break;

                    case "17":
                        result = amount * euroDollar;
                        Console.WriteLine($"Your currency: ${result} dollar");
                        break;

                    case "18":
                        result = amount * euroFranc;
                        Console.WriteLine($"Your currency: #{result} franc");
                        break;

                    case "19":
                        result = amount * euroCedi;
                        Console.WriteLine($"Your currency: #{result} cedi");
                        break;

                    case "20":
                        result = amount * euroPounds;
                        Console.WriteLine($"Your currency: #{result} pound");
                        break;

                    case "21":
                        result = amount * francPounds;
                        Console.WriteLine($"Your currency: #{result} pound");
                        break;

                    case "22":
                        result = amount * francCedi;
                        Console.WriteLine($"Your currency: #{result} cedi");
                        break;

                    case "23":
                        result = amount * francDollar;
                        Console.WriteLine($"Your currency: ${result} dollar");
                        break;

                    case "24":
                        result = amount * francNaria;
                        Console.WriteLine($"Your currency: #{result} naria");
                        break;

                    case "25":
                        result = amount * francEuro;
                        Console.WriteLine($"Your currency: #{result} euro");
                        break;

                    case "26":
                        result = amount * cediEuro;
                        Console.WriteLine($"Your currency: #{result} euro");
                        break;

                    case "27":
                        result = amount * cediNaria;
                        Console.WriteLine($"Your currency: #{result} naria");
                        break;

                    case "28":
                        result = amount * cediDollar;
                        Console.WriteLine($"Your currency: ${result} dollar");
                        break;

                    case "29":
                        result = amount * cediPounds;
                        Console.WriteLine($"Your currency: #{result} pound");
                        break;

                    case "30":
                        result = amount * cediFranc;
                        Console.WriteLine($"Your currency: #{result} franc");
                        break;

                    default:
                        Console.WriteLine("Please enter a vaild opation!");
                        break;
                }
                Console.WriteLine("Would you like to continue? (Y = yes, N = no: )");

            } while ( Console.ReadLine().ToUpper() == "Y");
            Console.WriteLine("Thanks for using currency converter!");
        }
        catch (FormatException e)
        {
            Console.WriteLine("Enter ONLY numbers please!");
        }
        catch (Exception e) { Console.WriteLine("Sorry can't be found"); }
        Console.ReadLine();
    }
}
