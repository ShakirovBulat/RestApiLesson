using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiLesson.Models
{
    public class CountModel
    {
        public int count { get; set; }
        public  List<TodoItem> entries  { get; set; }
    }
}
