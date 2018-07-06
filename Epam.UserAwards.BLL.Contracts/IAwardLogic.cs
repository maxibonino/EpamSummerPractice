namespace Epam.UserAwards.BLL.Contracts
{
    public interface IAwardLogic
    {
        bool EditTitle(int id);
        bool EditDescription(int id);
    }
}
