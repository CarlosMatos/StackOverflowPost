using System;

namespace StackOverflowPost
{
    public class Post
    {
        public int Number { get; set; }
        public string Msg { get; set; }
        public string Title { get; set; }

        public int UpVote { get; set; }
        public int DownVote { get; set; }

        public DateTime When { get; set; }
        
        public Post(int number, string msg, string title)
        {
            Number = number;
            Msg = msg;
            Title = title;
            UpVote = 0;
            DownVote = 0;
            When = DateTime.Now;
        }

        public Post(int vote)
        {
            if (vote == 1) UpVote++;
            else if (vote == 0) DownVote++;
            
        }

    }
}
