using AutoMapper;
using BlogSite.Models.Entities;
using BlogSite.Models.Posts;

namespace BlogSite.Service.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreatePostRequestDto, Post>();
        CreateMap<Post, PostResponseDto>();
    }
}