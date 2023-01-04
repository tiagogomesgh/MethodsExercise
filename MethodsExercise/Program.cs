namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int patientAge;
            string patientName;
            string patientGender;
            string patientHeight;
            
            Console.WriteLine("Hello, Welcome to the Doctors Office Please Fill out this clipboard. Thanks!");
            Console.WriteLine("Name:     ");
            patientName = Console.ReadLine();
            Console.WriteLine("Age:     ");
            patientAge = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Male/Female:     ");
            patientGender = Console.ReadLine();
            Console.WriteLine("Height:     ");
            patientHeight = Console.ReadLine();
            
            InfoSheet(patientAge, patientName, patientGender, patientHeight);

            int Sum = Add(1, 1, 1, 1, 1);
            Console.WriteLine($"The sum of these numbers is {Sum}");
            int Difference = Subtract(5, 10, 15, 75);
            Console.WriteLine($"The difference in these numbers is {Difference}");
            int Product = Multiply(2, 2, 80);
            Console.WriteLine($"The Product of these numbers is {Product}");
            int Dividend = Divide(400, 4);
            Console.WriteLine($"The Dividend of these numbers is {Dividend}");



        }

        public static void InfoSheet(int patientAge, string patientName, string patientGender, string patientHeight)
        {
            int cReferalRating;
            Console.WriteLine("Thank you very much for choosing our services!");
            Thread.Sleep(2000);
            Console.WriteLine("How like are you to refer our services to a friend?");
            Thread.Sleep(2000);
            Console.WriteLine("   1   |   2   |   3   |   5   |   6   |   7   |   8   |   9   |   10   ");
            cReferalRating = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Thank you very much, your data is being stored in our database.");
            Console.WriteLine($"Patient: {patientName}\n Age: {patientAge}\n Gender: {patientGender}\n Height: {patientHeight} ");
            Thread.Sleep(2000);
            Console.WriteLine($"APPROVAL RATING: {cReferalRating}");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            

        }

        public static int Add(params int[] ListNumbers)
        {
            
            int total = 0;

            foreach (var i in ListNumbers)
            {
                total += i;
            }
            
            return total;
        }
        public static int Subtract(params int[] ListNumbers)
        {
            
            int total = 0;

            foreach (var i in ListNumbers)
            {
                total -= i;
            }
            
            return total;
        }

        public static int Multiply(params int[] ListNumbers)
        {
            int total = 1;
            

            foreach (var i in ListNumbers)
            {
                
                total *= i;
                
            }

            return total;
        }
        public static int Divide(params int[] ListNumbers)
        {
            int total = 0;
            

            for (var i = 0; i < ListNumbers.Length-1; i++)
            {
                total = ListNumbers[i] / ListNumbers[i + 1];
                

            }

            return total;

        }

    }
}
