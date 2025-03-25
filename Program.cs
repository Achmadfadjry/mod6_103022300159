using Modul6_103022300159;

class Program
{
    static void Main()
    {
        SayaTubeUser user = new SayaTubeUser("Achmad fadjry adlil faqih");

        string[] videoTitles = {
            "Review Film adit sopo jarwo oleh Achmad fadjry adlil faqih",
            "Review Film spongebob oleh Achmad fadjry adlil faqih",
            "Review Film batman oleh Achmad fadjry adlil faqih",
            "Review Film Superman oleh Achmad fadjry adlil faqih",
            "Review Film Doraemon oleh Achmad fadjry adlil faqih",
            "Review Film thenopals oleh Achmad fadjry adlil faqih",
            "Review Film juki the movie oleh Achmad fadjry adlil faqih",
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