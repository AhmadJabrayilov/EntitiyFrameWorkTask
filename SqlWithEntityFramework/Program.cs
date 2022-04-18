using SqlWithEntityFramework.DAL;
using SqlWithEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SqlWithEntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AddPost();
            //GetAllPosts();
            EditPostTitle(2);
        }

        static void AddPost()
        {
            Post post = new Post
            {
                Title = "Example Title4=5",
                Content = "Example Content4=5",
                Image = "Example image4=5"

            };

            using (PostDbContext dbContext = new PostDbContext())
            {
                dbContext.Posts.Add(post);
                dbContext.SaveChanges();
            }
            Console.WriteLine("Post Created");

        }

        static void GetAllPosts()
        {
            using (PostDbContext dbContext = new PostDbContext())
            {
                List<Post> posts = dbContext.Posts.ToList();
                foreach (var item in posts)
                {
                    Console.WriteLine($"ID: {item.Id} / Title: {item.Title} / Content: {item.Content} / Image: {item.Image}");
                }

            }
            Console.WriteLine("Post Created");
        }

        static void EditPostTitle(int? id)
        {

            if(id == null)
            {
                Console.WriteLine("Id null ola bilmez");
                return;
            }
          

            using (PostDbContext dbContext = new PostDbContext())
            {
                Post dbpost = dbContext.Posts.Find(id);
                if(id == null)
                {
                    Console.WriteLine($"{id}-li post tapilmadi ");
                    return;
                }
                dbpost.Content = "Edited Title";
                dbpost.Content = "Edited Content";
                dbpost.Content = "Edited Image";

                Console.WriteLine($"{id}. Post Edited");

                dbContext.SaveChanges();
                
            }

        }
       
    }
}

