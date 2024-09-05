namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float myFloat = 64.4f;
            float myOtherFloat = 0.0f;
            float result = 0f;

            Random rand = new Random();
            int myInt = rand.Next(2, 30);

            try
            {
                result = Divide(myFloat, myOtherFloat);
            }
            catch (Exception e)
            {
                // Prints message and ask user to enter a number
                Console.WriteLine(e.Message);
                Console.WriteLine("Please enter a number other than zero.");
                

                try
                {
                    myOtherFloat = (float)Convert.ToDouble(Console.ReadLine());
                    result = Divide(myFloat, myOtherFloat);
                }
                catch (Exception e2)
                {
                    Console.WriteLine(e2.Message);
                }
            }
            finally 
            {
                Console.WriteLine("Calculations conpleted with a result of " + result);
            }

            try
            {
                // Checks to see if the user is old enough to play mature games
                CheckAge(myInt);
            }
            catch
            {
                Console.WriteLine($"You are {myInt}, you are not old enough");
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        /// <exception cref="DivideByZeroException"></exception>
        static float Divide(float x, float y) 
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
            else 
            {
                return x / y;
            }           
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="age"></param>
        /// <exception cref="ArgumentException"></exception>
        static void CheckAge(int age) 
        {
            if (age >= 17)
            {
                Console.WriteLine($"You are {age}, you can play mature games!");
            }
            else 
            {
                throw new ArgumentException();
            }
        }
    }
}
