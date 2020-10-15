using System;
using System.Collections.Generic;

namespace CrudWithReactAspNetCore.Models
{
    public partial class Peoples
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public string Date { get; set; }
        public string Text { get; set; }
        public string Dekret { get; set; }
    }
}
