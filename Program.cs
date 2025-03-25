using Modul6_103022300159;

class Program
{
    static void Main()
    {
        SayaTubeUser user = new SayaTubeUser("Achmad fadjry adlil faqih");

        string[] videoTitles = {
            "Review Film Interstellar oleh Achmad fadjry adlil faqih",
            "Review Film Inception oleh Achmad fadjry adlil faqih",
            "Review Film The Dark Knight oleh Achmad fadjry adlil faqih",
            "Review Film The Shawshank Redemption oleh ",
            "Review Film The Godfather oleh Achmad fadjry adlil faqih",
            "Review Film The Matrix oleh Achmad fadjry adlil faqih",
            "Review Film Fight Club oleh Achmad fadjry adlil faqih",
            "Review Film Parasite oleh Achmad fadjry adlil faqih",
            "Review Film Forrest Gump oleh Achmad fadjry adlil faqih",
            "Review Film Pulp Fiction oleh Achmad fadjry adlil faqih"
        };

        foreach (var title in videoTitles)
        {
            SayaTubeVideo video = new SayaTubeVideo(title);
            video.IncreasePlayCount(new Random().Next(1000, 10000));
            user.AddVideo(video);
        }

        user.PrintAllVideoPlaycount();
    }
}