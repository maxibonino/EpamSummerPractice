namespace Epam.UsersAwards.BLL.Contracts
{
    public interface IEditPicture
    {
        // Устанавливает и удаляет(присваиванием null) фото
        bool ChangePhoto(int id, byte[] picture);
    }
}
