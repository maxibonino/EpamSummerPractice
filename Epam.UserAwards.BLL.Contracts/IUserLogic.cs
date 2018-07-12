using System;
using System.Collections.Generic;
using Entities;

namespace Epam.UsersAwards.BLL.Contracts
{
    public interface IUserLogic
    {
        User Add(string surname, string name, string birth);

        bool EditName(int id, string newName);

        bool EditBirthDate(int id, string newBirthDate);

        bool AddAward(int userId, int awardId);

        bool DeleteUser(int id);

        bool DeleteAward(int userId, int awardId);

        IEnumerable<User> GetAll();
    }
}
