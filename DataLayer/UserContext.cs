using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Identity;
using BusinessLayer;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class UserContext : IDb<User, string>
    {
        private readonly TaskyPrototypeContext _taskyPrototypeContext;

        public UserContext(TaskyPrototypeContext taskyPrototypeContext)
        {
            _taskyPrototypeContext = taskyPrototypeContext;
        }

        public void Create(User entity)
        {
            try
            {
                _taskyPrototypeContext.Users.Add(entity);
                _taskyPrototypeContext.SaveChanges();
            }
            catch (Exception) 
            {
                throw new Exception("User already exists.");
            }
        }

        public User Read(string key, bool useNavigationalProperties = false, bool isReadOnlyTrue = true)
        {
            try
            {
                IQueryable<User> query = _taskyPrototypeContext.Users;
                if (useNavigationalProperties)
                {
                    query = query.Include(u => u.Tasks);
                }
                if (isReadOnlyTrue)
                {
                    query = query.AsNoTrackingWithIdentityResolution();
                }

                return query.SingleOrDefault(u => u.Username == key);
            }
            catch(Exception)
            {
                throw;
            }
        }

        public List<User> ReadAll(string key, bool useNavigationalProperties = false, bool isReadOnlyTrue = true)
        {
            try
            {
                IQueryable<User> query = _taskyPrototypeContext.Users;
                if (useNavigationalProperties)
                {
                    query = query.Include(u => u.Tasks);
                }
                if (isReadOnlyTrue)
                {
                    query = query.AsNoTrackingWithIdentityResolution();
                }

                return query.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Update(User entity, bool useNavigationalProperties = false)
        {
            try
            {
                User userFromDb = Read(entity.Username, useNavigationalProperties = false);

                if (userFromDb != null)
                {
                    throw new ArgumentException("User with username " + entity.Username + " does not exist.");
                }

                _taskyPrototypeContext.Update(entity.Password);
                _taskyPrototypeContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(string key)
        {
            try
            {
                User user = Read(key, false, false);

                if (user != null) 
                {
                    throw new ArgumentException("User with username " + key + " does not exist");
                }

                _taskyPrototypeContext.Users.Remove(user);
                _taskyPrototypeContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
