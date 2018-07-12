using System;
using System.Collections.Generic;
using Entities;
using Epam.UsersAwards.BLL.Contracts;

namespace Epam.UsersAwards.BLL.Logic
{
    public class UserLogic : IUserLogic, IEditPicture
    {
        private static int _id = 0;

        public User Add(string surname, string name, string birth)
        {
            return new User
            {
                Id = _id++,
                Name = $"{surname.Trim()} {name.Trim()}",
                BirthDate = DateTime.Parse(birth),
                Age = DateTime.Now.Year - DateTime.Parse(birth).Year,
            };
        }

        public bool AddAward(int userId, int awardId)
        {
            throw new NotImplementedException();
        }

        public bool ChangePhoto(int id, byte[] picture)
        {
            throw new NotImplementedException();
        }

        public bool DeleteAward(int userId, int awardId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public bool EditBirthDate(int id, string newName)
        {
            throw new NotImplementedException();
        }

        public bool EditName(int id, string newBirthDate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Entities.User> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
