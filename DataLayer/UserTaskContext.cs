﻿using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class UserTaskContext
    {
        private readonly TaskyPrototypeContext _taskyPrototypeContext;

        public UserTaskContext(TaskyPrototypeContext taskyPrototypeContext)
        {
            _taskyPrototypeContext = taskyPrototypeContext;
        }

        public void Create(User user, UserTask entity)
        {
            entity.User = user;

            _taskyPrototypeContext.UserTasks.Add(entity);
            _taskyPrototypeContext.SaveChanges();

            user.Tasks.Add(entity);


        }

        public UserTask Read(int key, bool useNavigationalProperties = false, bool isReadOnlyTrue = true)
        {
            try
            {
                IQueryable<UserTask> query = _taskyPrototypeContext.UserTasks;

                if (useNavigationalProperties)
                {
                    query = query.Include(t => t.User);
                }
                if (isReadOnlyTrue)
                {
                    query = query.AsNoTrackingWithIdentityResolution();
                }

                return query.FirstOrDefault(t => t.TaskId == key);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<UserTask> ReadAll(int key, bool useNavigationalProperties = false, bool isReadOnlyTrue = true)
        {
            try
            {
                IQueryable<UserTask> query = _taskyPrototypeContext.UserTasks;

                if (useNavigationalProperties)
                {
                    query = query.Include(t => t.User);
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

        public void Update(UserTask entity, bool useNavigationalProperties = false)
        {
            UserTask userTaskFromDb = Read(entity.TaskId, useNavigationalProperties, false);

            if (userTaskFromDb != null) 
            {
                userTaskFromDb = entity;
            }

            _taskyPrototypeContext.SaveChanges();
        }

        public void Delete(int key)
        {
            UserTask userTaskFromDb = Read(key, false, false);

            if (userTaskFromDb != null)
            {
                throw new ArgumentException("Task " + key + " does not exist.");
            }

            _taskyPrototypeContext.UserTasks.Remove(userTaskFromDb);
            _taskyPrototypeContext.SaveChanges();
        }

    }
}
