﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Library_Database.Entitiy
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public string  ?Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
