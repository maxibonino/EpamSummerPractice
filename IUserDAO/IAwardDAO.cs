using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.UsersAwards.IDAO
{
    public interface IAwardDAO
    {
        bool EditTitle(int id);

        bool EditDescription(int id);

        bool Delete(int id);
    }
}
