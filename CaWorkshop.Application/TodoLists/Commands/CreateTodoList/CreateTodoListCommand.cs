﻿using CaWorkshop.Application.Common.Interfaces;
using CaWorkshop.Domain.Entities;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace CaWorkshop.Application.TodoLists.Commands.CreateTodoList;

public class CreateTodoListCommand : IRequest<int>
{
    [Required]
    [StringLength(240)]
    public string? Title { get; set; }
}

public class CreateTodoListCommandHandler
    : IRequestHandler<CreateTodoListCommand, int>
{
    private readonly IApplicationDbContext _context;

    public CreateTodoListCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreateTodoListCommand request,
        CancellationToken cancellationToken)
    {
        var entity = new TodoList();

        entity.Title = request.Title;

        _context.TodoLists.Add(entity);

        await _context.SaveChangesAsync(cancellationToken);

        return entity.Id;
    }
}