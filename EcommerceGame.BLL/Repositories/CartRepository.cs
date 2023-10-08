using Demo.DAL.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceGame.BLL.Repositories
{
    internal class CartRepository
    {
        FinalMVCContext dbContext;

        public CartRepository(FinalMVCContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
