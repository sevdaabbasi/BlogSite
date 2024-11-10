using BlogSite.Core.Entities;
using BlogSite.Models.Posts;

namespace BlogSite.Service.Abstract;

public interface IPostService
{
    ReturnModel<PostResponseDto> Add(CreatePostRequestDto dto);
    ReturnModel<List<PostResponseDto>> GetAll();
    ReturnModel<PostResponseDto> GetById(Guid id);
}