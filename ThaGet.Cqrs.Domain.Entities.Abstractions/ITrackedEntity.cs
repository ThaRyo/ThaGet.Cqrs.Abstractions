using System;

namespace ThaGet.Cqrs.Domain.Entities.Abstractions
{
    public interface ITrackedEntity
    {
        public DateTime CreatedAtUtc { get; set; }
        public DateTime? UpdatedAtUtc { get; set; }
    }
}
