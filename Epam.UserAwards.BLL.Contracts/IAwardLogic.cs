namespace Epam.UsersAwards.BLL.Contracts
{
    public interface IAwardLogic
    {
        bool EditTitle(int id);

        bool EditDescription(int id);

        bool Delete(int id);
    }
}
