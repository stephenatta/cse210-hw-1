using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>
        {
            new Video("Introduction to C#", "Tech Guru", 600),
            new Video("Advanced OOP Concepts", "Code Master", 1200),
            new Video("Data Structures Explained", "Programming Simplified", 900)
        };

        // Adding comments to each video
        videos[0].AddComment(new Comment("Alice", "Great explanation!"));
        videos[0].AddComment(new Comment("Bob", "Very helpful, thanks!"));
        videos[0].AddComment(new Comment("Charlie", "Best tutorial ever!"));

        videos[1].AddComment(new Comment("Dave", "This was really insightful!"));
        videos[1].AddComment(new Comment("Eve", "Loved the OOP examples."));

        videos[2].AddComment(new Comment("Frank", "I finally understand linked lists!"));
        videos[2].AddComment(new Comment("Grace", "Can you make more videos on algorithms?"));
        videos[2].AddComment(new Comment("Hank", "This is exactly what I needed."));

        // Displaying all video information
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
