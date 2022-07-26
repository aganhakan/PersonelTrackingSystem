﻿using Smurfs.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smurfs.Entities.Conrete
{
    public class Department : IEntity
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public List<Project> Project { get; set; }
    }
}
