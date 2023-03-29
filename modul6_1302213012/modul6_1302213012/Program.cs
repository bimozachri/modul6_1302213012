// See https://aka.ms/new-console-template for more information
using modul6_1302213012;

namespace modul6_1302213012
{
    class Program
    {
        static void Main(string[] args)
        {
            SayaTubeUser user = new SayaTubeUser("Bimo");

            SayaTubeVideo video1 = new SayaTubeVideo("Review film Ant-Man oleh Bimo");
            SayaTubeVideo video2 = new SayaTubeVideo("Review film Ant-Man and The Wasp oleh Bimo");
            SayaTubeVideo video3 = new SayaTubeVideo("Review film Iron Man 1 oleh Bimo");
            SayaTubeVideo video4 = new SayaTubeVideo("Review film Avengers End Game oleh Bimo");
            SayaTubeVideo video5 = new SayaTubeVideo("Review film Guardians of Galaxy oleh Bimo");
            SayaTubeVideo video6 = new SayaTubeVideo("Review film Spiderman No Way Home oleh Bimo");
            SayaTubeVideo video7 = new SayaTubeVideo("Review film Spiderman Home Coming oleh Bimo");
            SayaTubeVideo video8 = new SayaTubeVideo("Review film Spiderman 1 oleh Bimo");
            SayaTubeVideo video9 = new SayaTubeVideo("Review film Doctor Strange oleh Bimo");
            SayaTubeVideo video10 = new SayaTubeVideo("Review film Hulk oleh Bimo");

            video1.IncreasePlayCount(2);
            video1.PrintVideoDetails();

            video2.IncreasePlayCount(2);
            video2.PrintVideoDetails();

            video3.IncreasePlayCount(2);
            video3.PrintVideoDetails();

            video4.IncreasePlayCount(2);
            video4.PrintVideoDetails();

            video5.IncreasePlayCount(2);
            video5.PrintVideoDetails();

            video6.IncreasePlayCount(2);
            video6.PrintVideoDetails();

            video7.IncreasePlayCount(2);
            video7.PrintVideoDetails();

            video8.IncreasePlayCount(2);
            video8.PrintVideoDetails();

            video9.IncreasePlayCount(2);
            video9.PrintVideoDetails();

            video10.IncreasePlayCount(2);
            video10.PrintVideoDetails();

            Console.WriteLine(" ");

            user.AddVideo(video1);
            user.AddVideo(video2);
            user.AddVideo(video3);
            user.AddVideo(video4);
            user.AddVideo(video5);
            user.AddVideo(video6);
            user.AddVideo(video7);
            user.AddVideo(video8);
            user.AddVideo(video9);
            user.AddVideo(video10);

            user.PrintAllVideoCount();

            Console.WriteLine("Video ditonton 25.000.000");
            video1.IncreasePlayCount(25000000);
            Console.WriteLine("Video ditonton 25.000.000 bisa jika 25.000.001 tidak bisa");
            Console.WriteLine();

            Console.WriteLine("Video ditonton limit int");
            for (int i = 0; i < 84; i++)
            {
                video1.IncreasePlayCount(25000000);
            }
            video1.PrintVideoDetails();
            Console.WriteLine();
            video1.IncreasePlayCount(25000000);
            Console.WriteLine();

            user.PrintAllVideoCount();
        }
    }
}

