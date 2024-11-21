using Adam_Waleed_0522028_api.Data;
using Adam_Waleed_0522028_api.Dtos.DirectorDto;
using Adam_Waleed_0522028_api.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Net;

namespace Adam_Waleed_0522028_api.Repo.DirectorsRepo
{
    public class Direcotrs_Repo : IDirectior_Repo
    {
        private readonly AppdbContext _dbContext;

        public Direcotrs_Repo(AppdbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddDirectior(Director_Dto director_Dto)
        {
            var dir = new Director_M
            {
                Id = director_Dto.Id,
                Name = director_Dto.Name,
                Contact = director_Dto.Contact,
                Email = director_Dto.Email,
            };
            _dbContext.Add(dir);
            _dbContext.SaveChanges();
        }

        public bool Update(Director_Dto_Update director_Dto_Update, int id)
        {
            var dir = _dbContext.director_Ms.Find(id);
            if (dir == null)
                return false;
            dir.Name = director_Dto_Update.Name;
            dir.Contact = director_Dto_Update.Contact;
            dir.Email = director_Dto_Update.Email;

            _dbContext.Update(dir);
            _dbContext.SaveChanges();
            return true;
        }

        void IDirectior_Repo.Delete(int id)
        {
            var res = _dbContext.director_Ms.FirstOrDefault(x => x.Id == id);
            _dbContext.director_Ms.Remove(res);
            _dbContext.SaveChanges();
        }
    }
}
