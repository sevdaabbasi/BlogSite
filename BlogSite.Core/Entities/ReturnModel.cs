using System.Net;
using System.Security.Principal;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BlogSite.Core.Entities;

public class ReturnModel<TData>
{
    public TData Data { get; set; }
    public bool Success { get; set; }
    public string Message { get; set; }
    public int Status { get; set; }
}