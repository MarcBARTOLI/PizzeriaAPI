using PizzeriaAPI.Application.Mediator;

namespace PizzeriaAPI.Application.GetMenu;

public class GetMenuQueryHandler : IQueryHandler<GetMenuQuery, MenuDTO>
{
    public async Task<MenuDTO> Handle(GetMenuQuery request, CancellationToken cancellationToken)
    {
        //TODO get menu from repo
        return await Task.FromResult(new MenuDTO(
        [
            new PizzaDTO("Margarita", ["Tomato", "Basil", "Mozza"]),
            new PizzaDTO("Queen", ["Tomato", "Basil", "Mozza", "Mushrooms"]),
            new PizzaDTO("Pepperoni", ["Tomato", "Mozza", "Pepperoni"]),
        ]));
    }
}