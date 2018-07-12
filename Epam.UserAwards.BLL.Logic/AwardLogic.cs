using Epam.UsersAwards.BLL.Contracts;

namespace Epam.UsersAwards.BLL.Logic
{
    public class AwardLogic : IAwardLogic
    {
        private readonly IAwardDAO _awardDAO;

        public AwardLogic(IAwardDAO awardDAO)
        {
            _awardDAO = awardDAO;
        }

        public bool EditDescription(int id)
        {
            //_awardDAO.
        }

        public bool EditTitle(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
