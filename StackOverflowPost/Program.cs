using System;
using System.Collections.Generic;

namespace StackOverflowPost
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("WELLCOME TO STACKOVERFLOW HOMEMADE\n\n");

            var Option="";
            var count = 0;
            var PostNumber = 0;
            var Text = "";
            string Title = "";

            List<Post> lstPost = new List<Post>();

            var Posting = true;
            while (Posting)
            {
                Console.WriteLine("For a new post, press P. For voting in a post, press V. To quit, press Q:");
                
                Option = Console.ReadLine().ToUpper();

                switch (Option)
                {
                    case "P":
                        count = 0;
                        PostTheMessage(ref PostNumber, Title, Text, lstPost);
                        break;

                    case "V":
                        count = 0;
                        VoteInThePost(lstPost);
                        break;

                    case "Q":
                        Posting = false;
                        Console.WriteLine("Thank you for using Stackoverflow Homemade. See you later, alligator!");
                        break;
                    default:
                        count++;
                        if (count >= 3) Posting = false;
                        else Console.WriteLine("Please, enter a valid option\n");
                        
                        break;
                }
            }
        }

        static void PostTheMessage(ref int PostNumber, string Title, string Text, 
            List<Post> lstPost)
        {
            PostNumber++;
            Console.Clear();
            Console.Write("Please, enter the Title.\nTitle: ");
            Title = Console.ReadLine();
            Console.Write("Please, enter the text of the post.\nText: ");
            Text = Console.ReadLine();
            Post post = new Post(PostNumber, Text, Title);
            lstPost.Add(post);
            PostMessage postMessage = new PostMessage(lstPost);
        }

        private static void VoteInThePost(List<Post> lstPost)
        {
            var postNumber= 0;
            Console.Write("\nPlease, enter the number of the Post you want to vote: ");
            
            try
            {
                postNumber = Convert.ToInt32(Console.ReadLine());
            }
            catch 
            {
                Console.WriteLine("\n*** Invalid entry. ***\n");
                return;
            }

            if (postNumber > 0 && postNumber <= lstPost.Count)
            {
                Voting voting = new Voting(postNumber, lstPost);
                PostMessage postMessage = new PostMessage(lstPost);
            }
            else Console.WriteLine("\n*** Invalid Post Number. ***\n");
            
            return;
        }
    }
}
