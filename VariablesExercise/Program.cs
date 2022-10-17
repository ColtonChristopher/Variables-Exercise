namespace VariablesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dogName = "Ralph";
            int dogAge = 10;
            char nickName = 'R';
            bool lovesHiking = true;
            double tennisBalls = 32;
            decimal weight = 70.3m;
            Console.WriteLine($"My dog's name is {dogName} he is {dogAge}, years old and he has {tennisBalls} tennis balls and it is {lovesHiking} that he loves to hike, which keeps him at his weight of {weight} and sometimes we call him by his nickname {nickName}");
        }
    }
}