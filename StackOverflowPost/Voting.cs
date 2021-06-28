using System;
using System.Collections.Generic;

namespace StackOverflowPost
{
    internal class Voting
    {
        public Voting(int postNumber, List<Post> lstPost)
        {
            Console.Clear();
            Console.WriteLine("Post Number: {0:00}\t\tDate: {1:D}\nTitle: {2}\nMessage: {3}\nUpVotes: {4}\tDownVotes: {5}\n",
                    lstPost[postNumber - 1].Number, lstPost[postNumber - 1].When, lstPost[postNumber - 1].Title, lstPost[postNumber - 1].Msg, 
                    lstPost[postNumber - 1].UpVote, lstPost[postNumber - 1].DownVote);
            
            var count = 0;
            Console.Write("Enter 1 for UpVote and 0 for DownVote: ");
            var vote = Console.ReadLine();
            while (true)
            {
                if (vote == "1")
                {
                    lstPost[postNumber - 1].UpVote++;
                    break;
                }
                else if (vote == "0")
                {
                    lstPost[postNumber - 1].DownVote++;
                    break;
                }
                else
                {
                    count++;
                    if (count == 3) break;
                    Console.Write("Not a valid option. Please enter 1 for Upvoting or 0 for Downvoting: ");
                    vote = Console.ReadLine();
                }
            }
        }
    }
}