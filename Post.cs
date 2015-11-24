using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Design a class called Post. This class models a StackOverflow post. It should have properties
//for title, description and the date/time it was created. We should be able to up-vote or down-vote
//a post. We should also be able to see the current vote value. In the main method, create a post,
//up-vote and down-vote it a few times and then display the current vote value.

//In this exercise, you will learn that a StackOverflow post should provide methods for up-voting
//and down-voting. You should not give the ability to set the Vote property from the outside,
//because otherwise, you may accidentally change the votes of a class to 0 or to a random
//number. And this is how we create bugs in our programs. The class should always protect its
//state and hide its implementation detail.

//Educational tip: The aim of this exercise is to help you understand that classes should
//encapsulate data AND behavior around that data. Many developers (even those with years of
//experience) tend to create classes that are purely data containers, and other classes that are
//purely behavior (methods) providers. This is not object-oriented programming. This is
//procedural programming. Such programs are very fragile. Making a change breaks many parts
//of the code.

namespace Lecture15Exercise
{
    class Post
    {
        private string _title = "Post Title";
        private string _description = "This is the post's description!";
        private DateTime _postedDate = DateTime.Now;
        private int _upVotes, _downVotes, _totalVotes = 0;

        public void UpVote()
        {
            _upVotes++;
            _totalVotes = _upVotes - _downVotes;
        }

        public void DownVote()
        {
            _downVotes++;
            _totalVotes = _upVotes - _downVotes;
        }

        public int GetUpvotes() => _upVotes;
        public int GetDownVotes() => _downVotes;
        public int GetTotalVotes() => _totalVotes;
        public string GetTitle() => _title;
        public string GetDescription() => _description;
        public DateTime GetPostedDate() => _postedDate;
    }
}