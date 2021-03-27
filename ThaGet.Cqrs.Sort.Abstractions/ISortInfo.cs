using ThaGet.Cqrs.Sort.Core.Enums;

namespace ThaGet.Cqrs.Sort.Abstractions
{
    public interface ISortInfo
    {
        SortDirection Direction { get; set; }
        string Property { get; set; }
    }
}