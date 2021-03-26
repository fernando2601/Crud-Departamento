using MVCUDEMY.Data;
using MVCUDEMY.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVCUDEMY.Services
{
    public class DepartmentService
    {
        private readonly MVCUDEMYContext _context;

        public DepartmentService(MVCUDEMYContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }

    }
}
