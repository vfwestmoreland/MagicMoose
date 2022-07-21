namespace MagicMoose
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> responses = new List<string>();
            responses.Add("As I see it, yes.");
            responses.Add("Ask again later.");
            responses.Add("Better not tell you now.");
            responses.Add("Cannot predict now.");
            responses.Add("Concentrate and ask again.");
            responses.Add("Don't count on it.");
            responses.Add("It is certain.");
            responses.Add("It is decidedly so.");
            responses.Add("Most likely.");
            responses.Add("My reply is no.");
            responses.Add("My sources say no.");
            responses.Add("Outlook not so good");
            responses.Add("Outlook good.");
            responses.Add("Reply hazy, try again");
            responses.Add("Signs point to yes");
            responses.Add("Very doubtful."); 
            responses.Add("Without a doubt.");
            responses.Add("Yes");
            responses.Add("Yes - definitely.");
            responses.Add("You may rely on it.");

            var random = new Random();
            int index = random.Next(responses.Count);
            string response = responses[index] + " - The Magic Moose has spoken!";

            Console.Write("Ask the Magic Moose any question:" );
            string question = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine(question + " " + response);

            Console.ReadLine();
            
        }
    }
}