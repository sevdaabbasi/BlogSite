namespace BlogSite.Models.Posts;

public sealed record UpdatePostRequestDto(Guid id,string Title, string Content);