using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TodoList.Models.Entities
{
    public class TodoItem
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [RegularExpression(@"[a-zA-Z]{3,32}", ErrorMessage="Title has to have 3-32 letters.")]
        public string Title { get; set; }
        [ScaffoldColumn(false)]
        public bool IsFinished { get; set; }
    }
}