using Microsoft.EntityFrameworkCore;
using MVCClinica.Models;

namespace MVCClinica.Data
{
    public class DBClinicaMVC : DbContext
    {
        public DBClinicaMVC(DbContextOptions<DBClinicaMVC> options) : base(options) { }

        public DbSet<Medico> Medicos { get; set; }
    }
}
