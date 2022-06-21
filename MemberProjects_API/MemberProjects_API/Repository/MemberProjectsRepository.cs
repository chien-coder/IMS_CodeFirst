using EF.Core.Repository.Interface.Repository;
using EF.Core.Repository.Repository;
using MemberProjects_API.Data;
using MemberProjects_API.Models;

namespace MemberProjects_API.Repository
{
    public interface IMemberProjectsRepository: ICommonRepository<MemberProjects>
    {
        
    }

    public class MemberprojectsRepository : CommonRepository<MemberProjects>, IMemberProjectsRepository
    {
        
        public MemberprojectsRepository(MyDbContext myDbContext): base(myDbContext)
        {
           
        }

       
    }
}
