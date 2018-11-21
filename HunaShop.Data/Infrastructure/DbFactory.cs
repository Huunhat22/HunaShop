using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HunaShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private HunaShopDbContext dbContext;

        public HunaShopDbContext Init()
        {
            return dbContext ?? (dbContext = new HunaShopDbContext());
        }
        protected override void DisposeCore()
        {
            if(dbContext != null)
                base.DisposeCore();
        }
    }
}
