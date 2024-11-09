namespace BlogSite.Core.Entities;

public abstract class Entity<TId>
{
    public TId Id { get; set; }
    public DateTime CreatedTime { get; set; }
    public DateTime? UpdateTime { get; set; }
}