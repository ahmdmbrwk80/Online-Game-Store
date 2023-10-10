using Demo.BLL.Interfaces;

using Demo.DAL.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL
{
    public class UintOfWork : IUintOfWork
    {
        private readonly FinalMVCContext _dbcontext;

       
        public UintOfWork(FinalMVCContext dbcontext)
        {
          
            _dbcontext = dbcontext;
        }

        public int Complete()
        {
            return  _dbcontext.SaveChanges();
        }

        public void Dispose()
        {
            _dbcontext.Dispose();
        }

    
    }
}
