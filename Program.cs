using System;

namespace Stack_Overflow_Post
{
    class Program
    {
        static void Main(string[] args)
        {
            Post StackOverflow = new Post();

            Console.WriteLine("Enter post Title: ");
            var userTitle = Console.ReadLine();
            StackOverflow.SetTitle(userTitle);

            Console.WriteLine("Description: \n");
            var userDescription = Console.ReadLine();
            StackOverflow.SetDescription(userDescription);

            Console.WriteLine("Title: {0} \nDate: {1} \nDescription {2}", StackOverflow.GetTitle(), StackOverflow.GetDate(), StackOverflow.GetDescription());

            var run = true;
            while (run == true)
            {
                Console.WriteLine("Press Y to upvote, N to downvote or S to exit: ");
                var userChoice = Console.ReadLine();

                if (userChoice == "y")
                {
                    StackOverflow.SetUpVote();
                    Console.WriteLine("Total UpVotes: {0}", StackOverflow.GetUpvoteCount());
                    Console.WriteLine("Total DownVotes: {0}", StackOverflow.GetDownVoteCount());
                }
                else if (userChoice == "n")
                {
                    StackOverflow.SetDownVote();
                    Console.WriteLine("Total UpVotes: {0}", StackOverflow.GetUpvoteCount());
                    Console.WriteLine("Total DownVotes: {0}", StackOverflow.GetDownVoteCount());
                }
                else if (userChoice == "s")
                {
                    run = false;
                }
                else
                {
                    Console.WriteLine("Error try again.");
                }
            }

        }
    }
}
