﻿using System.Globalization;
using MarketScreener.Application.Common.Interfaces;
using MarketScreener.Application.TodoLists.Queries.ExportTodos;
using MarketScreener.Infrastructure.Files.Maps;
using CsvHelper;

namespace MarketScreener.Infrastructure.Files;

public class CsvFileBuilder : ICsvFileBuilder
{
    public byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records)
    {
        using var memoryStream = new MemoryStream();
        using (var streamWriter = new StreamWriter(memoryStream))
        {
            using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

            csvWriter.Configuration.RegisterClassMap<TodoItemRecordMap>();
            csvWriter.WriteRecords(records);
        }

        return memoryStream.ToArray();
    }
}

