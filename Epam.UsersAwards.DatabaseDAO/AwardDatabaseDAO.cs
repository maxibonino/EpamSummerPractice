using IUserDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.UsersAwards.DatabaseDAO
{
    public class AwardDatabaseDAO : IAwardDAO, IEditPicture
    {
        public bool ChangePhoto(byte[] picture)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool EditDescription(int id)
        {
            throw new NotImplementedException();
        }

        public bool EditTitle(int id)
        {
            throw new NotImplementedException();
        }
    }
}
