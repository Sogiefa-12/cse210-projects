using System;
using System.Collections.Generic;

class Videos
{
    private string title;
    private string author;
    private int Length;
    private List<Comment> comments;


    public void AddComment(string commenterName, string commentText)
    {
        comments.Add(new Comment(commenterName, commentText));
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }


}