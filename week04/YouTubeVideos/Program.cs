using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learning C# Programming", "TechEdu Channel", 450);
        video1.AddComment(new Comment("John Smith", "Great tutorial! Very helpful for beginners."));
        video1.AddComment(new Comment("Sarah Johnson", "Clear explanations, thank you!"));
        video1.AddComment(new Comment("Mike Chen", "Could you make a video about advanced topics next?"));
        videos.Add(video1);

        Video video2 = new Video("10 Minute Morning Workout", "FitnessGuru", 600);
        video2.AddComment(new Comment("Emma Wilson", "Perfect workout for busy mornings!"));
        video2.AddComment(new Comment("David Brown", "I do this every day now, feeling great!"));
        video2.AddComment(new Comment("Lisa Garcia", "Love the music choice in this video."));
        video2.AddComment(new Comment("Tom Anderson", "Can you show modifications for beginners?"));
        videos.Add(video2);

        Video video3 = new Video("Amazing Sunset Timelapse", "NatureFilms", 180);
        video3.AddComment(new Comment("Alex Rodriguez", "Absolutely breathtaking footage!"));
        video3.AddComment(new Comment("Maria Gonzalez", "Where was this filmed? So beautiful!"));
        video3.AddComment(new Comment("Chris Taylor", "Nature never ceases to amaze me."));
        videos.Add(video3);

        Console.WriteLine("YouTube Video Information:\n");
        Console.WriteLine("=" + new string('=', 50));

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine("=" + new string('=', 50));
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
