﻿using CaWorkshop.Domain.Entities;
using System.Linq.Expressions;

namespace CaWorkshop.Application.TodoLists.Queries.GetTodoLists;

public class TodoItemDto
{
    public int Id { get; set; }

    public int ListId { get; set; }

    public string? Title { get; set; }

    public bool Done { get; set; }

    public int Priority { get; set; }

    public string? Note { get; set; }

}


