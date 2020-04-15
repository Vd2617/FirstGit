using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUsersApp.Data.Repository
{
    public class UsersRepository
    {
        private readonly AppDBContext appDBContext;
        public UsersRepository(AppDBContext appDBContext) {
            this.appDBContext = appDBContext;
        }
    }
}
