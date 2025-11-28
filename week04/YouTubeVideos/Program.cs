using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("YouTube Video Tracker\n");

        Video v1 = new Video("Buenos Aires Temple Tour", "Church Newsroom", 510);
        Video v2 = new Video("How to Improve Scripture Study", "Faith Insights", 360);
        Video v3 = new Video("Daily Motivation – Start Strong!", "MindsetChannel", 280);
        Video v4 = new Video("Exploring Argentine Traditions", "CultureVibes", 420);

        v1.AddComment(new Comment("Lucía", "Hermoso recorrido, gracias por compartir."));
        v1.AddComment(new Comment("Peter", "I visited this temple in 2019. Amazing experience."));
        v1.AddComment(new Comment("María", "Qué paz transmite este lugar."));

        v2.AddComment(new Comment("Jonathan", "Great tips, I will apply them today."));
        v2.AddComment(new Comment("Ana", "This helped me focus more during study."));
        v2.AddComment(new Comment("Sophie", "Short and clear, loved it."));

        v3.AddComment(new Comment("Leo", "Just what I needed today."));
        v3.AddComment(new Comment("Carla", "Very uplifting message!"));
        v3.AddComment(new Comment("Tomás", "I'm sharing this with a friend."));

        v4.AddComment(new Comment("Juli", "I love Argentine culture!"));
        v4.AddComment(new Comment("Matheus", "This video made me want to visit Argentina."));
        v4.AddComment(new Comment("Eli", "Beautiful traditions and colors."));

        List<Video> videos = new List<Video> { v1, v2, v3, v4 };

        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}
