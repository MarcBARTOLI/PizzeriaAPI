using MediatR;
using PizzeriaAPI.Application.GetMenu;

namespace PizzeriaAPI.ApiService;

public static class ApiHandlers
{
    public static async Task<IResult> GetMenu(IMediator mediator, CancellationToken token)
    {
        var query = new GetMenuQuery();
        var result = await mediator.Send(query, token);

        return result.ToHttpResult();
    }
}