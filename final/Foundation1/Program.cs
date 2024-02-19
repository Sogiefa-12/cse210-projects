using System;

class Program
{
    static void Main()
{
        List<Video> videos = new List<Video>();

        videos.Add(new Video("Video1", "Author1", 120));
        videos.Add(new Video("Video2", "Author2", 180));
        videos.Add(new Video("Video3", "Author3", 240));

        var comment1 = new Comment("User1", "Great video!");
        var comment2 = new Comment("User2", "Amazing content!");
        videos[0].Comments.Add(comment1);
        videos[0].Comments.Add(comment2);

        var comment3 = new Comment("User3", "Loved the video!");
        var comment4 = new Comment("User4", "Interesting topic!");
        videos[1].Comments.Add(comment3);
        videos[1].Comments.Add(comment4);

        var comment5 = new Comment("User5", "Excellent explanation!");
        var comment6 = new Comment("User6", "Learned a lot!");
        videos[2].Comments.Add(comment5);
        videos[2].Comments.Add(comment6);

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}\nAuthor: {video.Author}\nLength: {video.LengthInSeconds} seconds\nNumber of comments: {video.NumberOfComments}");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"Commenter: {comment.Commenter}\nComment text: {comment.CommentText}");
            }
            Console.WriteLine();
        }
    }
}