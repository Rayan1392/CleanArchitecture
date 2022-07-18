using MarketScreener.Application.Common.Mappings;
using MarketScreener.Domain.Entities;

namespace MarketScreener.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}

