using MediatR;

namespace ThaGet.Cqrs.Contract.Abstractions
{
    public interface IContract<TResponse> : IRequest<TResponse> { }
}
