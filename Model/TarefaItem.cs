using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTodo.Model;
public class TarefaItem
{    
    public string? Title { get; set; }
    public bool IsDone { get; set; } = false;
}