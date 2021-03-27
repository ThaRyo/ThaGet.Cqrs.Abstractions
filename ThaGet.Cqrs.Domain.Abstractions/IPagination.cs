using System.Collections.Generic;

namespace ThaGet.Cqrs.Domain.Abstractions
{
    public interface IPagination<T>
    {
        IEnumerable<T> Items { get; set; }

        int TotalCount { get; set; }
    }
}
