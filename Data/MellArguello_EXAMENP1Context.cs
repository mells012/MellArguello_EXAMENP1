using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MellArguello_EXAMENP1.Models;

namespace MellArguello_EXAMENP1.Data
{
    public class MellArguello_EXAMENP1Context : DbContext
    {
        public MellArguello_EXAMENP1Context (DbContextOptions<MellArguello_EXAMENP1Context> options)
            : base(options)
        {
        }

        public DbSet<MellArguello_EXAMENP1.Models.MA_Burger> MA_Burger { get; set; } = default!;
    }
}
