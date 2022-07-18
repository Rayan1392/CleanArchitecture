using System.Globalization;
using MarketScreener.Application.TodoLists.Queries.ExportTodos;
using CsvHelper.Configuration;

namespace MarketScreener.Infrastructure.Files.Maps;

public class TodoItemRecordMap : ClassMap<TodoItemRecord>
{
    public TodoItemRecordMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.Done).ConvertUsing(c => c.Done ? "Yes" : "No");
    }
}

