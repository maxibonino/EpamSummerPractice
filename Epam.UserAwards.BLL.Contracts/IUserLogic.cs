using System;
using System.Collections.Generic;
using Entities;

namespace Epam.UserAwards.BLL.Contracts
{
    public interface IUserLogic
    {
        bool EditName(int id);

        bool EditBirthDate(int id);

        bool AddAward();

        bool DeleteAward(Guid id);

        IEnumerable<User> GetAll();
    }
}
