using BlogSite.Core.Repository;
using BlogSite.Models.Entities;

namespace BlogSite.Repository.Repositories.Abstracts;

public interface IPostRepository : IRepository<Post, Guid>
{
    
}