using System;
using System.Collections.Generic;

class Movie
{
    private string MovieTitle;
    private string ShowDateTime;
    public string Title
    {
        get { return MovieTitle; }
        set { MovieTitle = value; }
    }
    public string ShowTime
    {
        get { return ShowDateTime; }
        set { ShowDateTime = value; }
    }

    public Movie(string title, string showTime)
    {
        Title = title;
        ShowTime = showTime;
    }

    public override string ToString()
    {
        return Title + "\t" + ShowTime;
    }
}
