using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Overflow_Post
{
    class Post
    {
        private string _Title, _Description;
        private int _TotalUpVote, _TotalDownVote;
        private DateTime _CreationDate;

        // Default Constructor
        public Post()
        {

        }

        public void SetTitle(string title)
        {
            _Title = title;
            _CreationDate = DateTime.Now;
        }

        public string GetTitle()
        {
            return _Title;
        }

        public void SetDescription(string desc)
        {
            _Description = desc;
        }

        public string GetDescription()
        {
            return _Description;
        }

        public DateTime GetDate()
        {
            return _CreationDate;
        }

        public void SetUpVote()
        {
            _TotalUpVote = _TotalUpVote + 1;
        }

        public int GetUpvoteCount()
        {
            return _TotalUpVote;
        }

        public void SetDownVote()
        {
            _TotalUpVote = _TotalUpVote - 1;
            _TotalDownVote = _TotalDownVote + 1;
        }

        public int GetDownVoteCount()
        {
            return _TotalDownVote;
        }



    }

}
