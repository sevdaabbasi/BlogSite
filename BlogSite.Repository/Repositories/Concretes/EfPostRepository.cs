using BlogSite.Core.Repository;
using BlogSite.Models.Entities;
using BlogSite.Repository.Context;
using BlogSite.Repository.Repositories.Abstracts;

namespace BlogSite.Repository.Repositories.Concretes;

public class EfPostRepository : EfRepositoryBase<BaseDbContext,Post,Guid>, IPostRepository
{
    public EfPostRepository(BaseDbContext context) : base(context)
    {
        
    }
}