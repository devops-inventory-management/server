using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevOpsInventoryManagement.Domain.Entities;

namespace DevOpsInventoryManagement.BLL.Interfaces
{
    public interface IAuthService
    {
        public string Generate(User user);
    }
}
