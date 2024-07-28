using MediatR;

namespace PizzeriaAPI.Application.Mediator;

public interface ICommand<out TResponse> : IRequest<TResponse>;