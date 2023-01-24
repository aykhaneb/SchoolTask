using P329ConsoleAppPractise.Models;
using P329ConsoleAppPractise.Services.Contracts;
using SchoolTask.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolTask.Managers
{
    internal class StudentManager : ICrudService, IPrintServiceI
    {
        public void Add(Entity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Get(int id)
        {
            throw new NotImplementedException();
        }

        public Entity[] GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Entity entity)
        {
            throw new NotImplementedException();
        }

        Entity ICrudService.Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
