using EF.Core.Repository.Interface.Repository;
using EF.Core.Repository.Repository;
using IMS_Chien.Context;
using IMS_Chien.Models;

namespace IMS_Chien.Repositorys
{
    public interface IRoleRepository: ICommonRepository<Role>
    {
    }

    public class RoleRepository: CommonRepository<Role>,IRoleRepository
    {
        public RoleRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        } 
    }
}
