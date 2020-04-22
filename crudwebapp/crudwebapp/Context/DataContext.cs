using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using crudwebapp.Entities;


namespace crudwebapp.Context
{
    public class DataContext : DbContext
    {
        public DataContext() { }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    }

}
