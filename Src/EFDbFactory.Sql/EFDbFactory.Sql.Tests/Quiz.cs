﻿using System.Collections.Generic;

namespace EFDbFactory.Sql.Tests
{
    public partial class Quiz
    {
        public Quiz()
        {
            Question = new HashSet<Question>();
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public virtual ICollection<Question> Question { get; set; }
    }
}
