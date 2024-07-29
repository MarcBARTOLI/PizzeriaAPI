using FluentResults;
using PizzeriaAPI.Application.Mediator;

namespace PizzeriaAPI.Application.GetMenu;

public record GetMenuQuery : IQuery<Result<MenuDTO>>;