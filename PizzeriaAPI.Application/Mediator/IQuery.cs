using MediatR;

namespace PizzeriaAPI.Application.Mediator;

public interface IQuery<out TResponse> : IRequest<TResponse>;