using System;

namespace TrainingShoeby02
{
    public class UserInterface
    {
        public static UserInterface Instance { get; } = new UserInterface();

        private UserInterface()
        {
            
        }
        
        public int GetBuyCount()
        {
            Console.WriteLine("How many products would you like to buy?");
            var buyCount = Int32.Parse(Console.ReadLine());

            return buyCount;
        }

        public void Message(string message) 
            => Console.WriteLine(message);
    }
}