using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SSGeek.Models;
using System.Data.SqlClient;
using System.IO;
using System.Web.WebPages;
using WebActivatorEx;

namespace SSGeek.DAL
{
    public class ForumPostSqlDAL : IForumPostDAL
    {
        private List<ForumPost> allForumPosts =new List<ForumPost>();

        public List<ForumPost> AllForumPosts
        {
            get { return allForumPosts; }
            set { allForumPosts = value; }
        }

        public List<ForumPost> GetAllPosts()
        {
            try
            {
                using (StreamReader reader = new StreamReader(@"C: \Users\aobiedat\Tech Elevator\.Net class\week1\week8team0-c-week8-pair-exercises\m3-w2d1-ssgeek-exercises-pair\SSGeek\bin\ForumLog.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] currentLine = reader.ReadLine().Split('|');
                        if (currentLine.Length >= 3)
                        {
                            ForumPost currForumPost = new ForumPost();
                            currForumPost.Username = currentLine[0];
                            currForumPost.Subject = currentLine[1];
                            currForumPost.Message = currentLine[2];
                            allForumPosts.Add(currForumPost);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return AllForumPosts;
        }

        public bool SaveNewPost(ForumPost post)
        {
            try
            {
                if (!post.Username.IsEmpty())
                {
                    using (StreamWriter writer = new StreamWriter(@"C: \Users\aobiedat\Tech Elevator\.Net class\week1\week8team0-c-week8-pair-exercises\m3-w2d1-ssgeek-exercises-pair\SSGeek\bin\ForumLog.txt", true))
                    {
                        writer.WriteLine(post.Username + "|" + post.Subject + "|" + post.Message);
                        return true;
                    }
                 
                }
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
    }
}