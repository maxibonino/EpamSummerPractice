using System;
using System.Collections.Generic;

namespace Entities
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public int Age { get; set; }

        // Фотография пользователя
        public byte[] Photo { get; set; }

        public IList<int> _awards { get; set; }
    }
}
