using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.UsersAwards.IDAO
{
    public interface IEditPicture
    {
        bool ChangePhoto(int id, byte[] picture);
    }
}
