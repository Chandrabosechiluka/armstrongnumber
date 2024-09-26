namespace armstrongnumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (IsArmstrong(number))
            {
                Console.WriteLine($"{number} is an Armstrong number.");
            }
            else
            {
                Console.WriteLine($"{number} is not an Armstrong number.");
            }
        }

        static bool IsArmstrong(int num)
        {
            int originalNum = num;
            int sum = 0;
            int digits = num.ToString().Length;

            while (num > 0)
            {
                int digit = num % 10;
                sum += (int)Math.Pow(digit, digits); 
                num /= 10;
            }

            return sum == originalNum;
        }
    }
}
