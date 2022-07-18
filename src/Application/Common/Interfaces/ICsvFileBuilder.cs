using MarketScreener.Application.TodoLists.Queries.ExportTodos;

namespace MarketScreener.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}

