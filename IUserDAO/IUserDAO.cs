using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.UsersAwards.IDAO
{
    public interface IUserDAO
    {
        bool EditName(int id);

        bool EditBirthDate(int id);

        bool AddAward();

        bool DeleteAward(Guid id);

        IEnumerable<User> GetAll();
    }
}
