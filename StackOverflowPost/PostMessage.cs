using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowPost
{
    public class PostMessage
    {
        public PostMessage(List<Post> lstPost)
        {
            Console.Clear();
            foreach (Post p in lstPost)
            {
                Console.WriteLine("Post Number: {0:00}\t\tDate: {1:D}\nTitle: {2}\nMessage: {3}\nUpVotes: {4}\tDownVotes: {5}\n", 
                    p.Number, p.When, p.Title, p.Msg, p.UpVote, p.DownVote);
            }
        }
    }
}
