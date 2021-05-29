﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Context;
using API.Models;

namespace API.Repositories.Data
{
    public class DepartmentRepository : GeneralRepository<Department, MyContext, int>
    {
        private readonly MyContext myContext;

        public DepartmentRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
