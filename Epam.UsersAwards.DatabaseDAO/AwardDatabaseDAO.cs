using System;
using Epam.UsersAwards.IDAO;

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
