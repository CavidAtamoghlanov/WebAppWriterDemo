using DataAccessLayer.Abstracts;
using DataAccessLayer.Contexts;
using EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogDal
    {
        public void AddBlog(Blog blog)
        {
            using (var context = new MyAppDbContext())
            {
                context.Blogs.AddAsync(blog);
                context.SaveChanges();
            }
        }

        public ICollection<Blog> AllBlog()
        {
            using (var context = new MyAppDbContext())
            {
                return context.Blogs.ToList();
            }
        }

        public void Delete(Blog entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteBlog(Blog blog)
        {
            using (var context = new MyAppDbContext())
            {
                context.Blogs.Remove(blog);
                context.SaveChanges();
            }
        }

        public ICollection<Blog> GetAll()
        {
            throw new NotImplementedException();
        }

        public Blog GetById(int id)
        {
            using (var context = new MyAppDbContext())
            {
                return context.Blogs.FirstOrDefault(x => x.BlogID == id);
            }
        }

        public void Insert(Blog entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Blog entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateBlog(Blog blog)
        {
            using (var context = new MyAppDbContext())
            {
                context.Update(blog);
                context.SaveChanges();
            }
        }
    }
}
