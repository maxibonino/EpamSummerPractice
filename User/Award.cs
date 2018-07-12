using System;

namespace Entities
{
    public class Award
    {
        public int Id { get; set; }

        public String Title { get; set; }

        public String Description { get; set; }

        // Изображение награды/медали
        public Byte[] Image { get; set; }
    }
}
