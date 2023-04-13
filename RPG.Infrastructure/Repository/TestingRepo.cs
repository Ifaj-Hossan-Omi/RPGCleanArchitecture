using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Infrastructure.Data;

namespace RPG.Infrastructure.Repository
{
    public class TestingRepo : ITestingRepo
    {
        private readonly DataContext _context;

        public TestingRepo(DataContext context)
        {
            _context = context;
        }
    }
}
