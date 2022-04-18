using SqlWithEntityFramework.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace SqlWithEntityFramework.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }




        //static void AddPost()
        //{
        //    Post post = new Post
        //    {
        //        Title = "Example Title",
        //        Content = "Example Content",
        //        Image = "Example image"

        //    };

        //    using(PostDbContext dbContext = new PostDbContext())
        //    {
        //        dbContext.Posts.Add(post);
        //        dbContext.SaveChanges();
        //    }
        //    Console.WriteLine("Post Created");

        //}

    }

}
