// See https://aka.ms/new-console-template for more information


using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

public class SayaTubeVideo {
    private int id;
    private string title;
    private int playCount=0;

    public SayaTubeVideo(string title) {
        Random random = new Random();
        id = random.Next(1, 99999);
        this.title = title;
    }
    public void IncreasePlayCount(int id) {
        try {
            checked {
                this.playCount += playCount;
            }
        }
        catch(OverflowException e)
        { 
            Console.WriteLine(e.Message); 
        }
    }

    public int getPlayCount() { 
        return playCount;
    }

    public void PrintVideoDetails() {
        Console.WriteLine("Video ID :{0}", id);
        Console.WriteLine("Judul :  {0}", title);
        Console.WriteLine("PlayCount : {0}", playCount);
    }
}
public class SayaTubeUser{
    private int id;
    private List<SayaTubeVideo> uploadedVideos;
    public string Username;

    public SayaTubeUser(string Username)
    {
        Random random = new Random();
        id = random.Next(1, 99999);
        this.Username = Username;
    }

    public int GetTotalVideoPlayCount() {
        int total = 0;
        foreach(SayaTubeVideo video in uploadedVideos) {
            total += video.getPlayCount();
        }
        return total;
    }

    public void addVideo(SayaTubeVideo video) { 
        uploadedVideos.Add(video);
    }

    public void PrintAllVideoPlayCount() {
        
        Console.WriteLine("User :{0}", id);
        for (int i = 0; i < uploadedVideos.Count; i++) {
            Console.WriteLine("video " + (i+1) + " judul " 
                + uploadedVideos + " count : " + uploadedVideos[i].getPlayCount());
        }
    }
}

class program { 
    static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Film the Conjuring di review oleh Herdi Ardana");
        video.PrintVideoDetails();
        Console.WriteLine("");
        SayaTubeUser wd= new SayaTubeUser("Herdi Ardana aksjjnsdjasnja");
        wd.PrintAllVideoPlayCount();       
    }
}