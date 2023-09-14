using System.ComponentModel.DataAnnotations;

namespace Clase2.Models
{
    public class ToDoItem
    {
        [MinLength(5)]
        [MaxLength(1024)]
        public string? Name { get; set; }
        public bool IsDone { get; set; }
    }
}
