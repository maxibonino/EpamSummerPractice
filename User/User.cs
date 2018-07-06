using System;

namespace Entities
{
    public class User
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public DateTime BirthDate { get; set; }

        public int Age { get; set; }

        public Byte[] Photo { get; set; }

        public IList<Guid> _awards { get; set; }
    }
}
