using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Video 1
        Video video1 = new Video();
        video1._title = "Learning C# Basics";
        video1._author = "Elder";
        video1._length = 300;

        Comment c1_1 = new Comment {
            _commenterName = "Carlos", 
            _commentText = "Great explanation!" 
        };
        Comment c1_2 = new Comment { 
            _commenterName = "Maria", 
            _commentText = "Very helpful!" 
        };
        Comment c1_3 = new Comment { 
            _commenterName = "Juan", 
            _commentText = "Thanks for the tutorial!" 
        };
        video1._comments.Add(c1_1);
        video1._comments.Add(c1_2);
        video1._comments.Add(c1_3);

        // Video 2
        Video video2 = new Video();
        video2._title = "Abstraction in OOP";
        video2._author = "Benjamin";
        video2._length = 450;

        Comment c2_1 = new Comment { 
            _commenterName = "Ana", 
            _commentText = "Now I finally understand classes." 
        };
        Comment c2_2 = new Comment { 
            _commenterName = "Luis", 
            _commentText = "Clear and straight to the point." 
        };
        Comment c2_3 = new Comment { 
            _commenterName = "Sofia", 
            _commentText = "Awesome video!" 
        };

        video2._comments.Add(c2_1);
        video2._comments.Add(c2_2);
        video2._comments.Add(c2_3);

        // Video 3
        Video video3 = new Video();
        video3._title = "C# Lists and Loops";
        video3._author = "Roberto";
        video3._length = 620;

        Comment c3_1 = new Comment { 
            _commenterName = "Diego", _commentText = "Foreach loops are so clean." };
        Comment c3_2 = new Comment { 
            _commenterName = "Elena", _commentText = "Helped me a lot with my homework!" };
        Comment c3_3 = new Comment { 
            _commenterName = "Mateo", _commentText = "Keep making more C# videos." };
        video3._comments.Add(c3_1);
        video3._comments.Add(c3_2);
        video3._comments.Add(c3_3);

        // List of videos
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video information
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Comments ({video.GetCommentCount()}):");

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"  - {comment._commenterName}: {comment._commentText}");
            }

            Console.WriteLine();
        }
    }
}