using System;
using System.Collections.Generic;

public interface ICommentable
{
    List<string> Comment { get; set; }
    void AddComment(string comment);
}
