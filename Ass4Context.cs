using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_C_
{
    public class Ass4Context :DbContext
    {
        public Ass4Context()
        {
        }

        public Ass4Context(DbContextOptions<Ass4Context> options)
            : base(options)
        {
        }
    }
}
