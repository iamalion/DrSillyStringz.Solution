using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
    public class Engineer 
    {
        // [Required(ErrorMessage = "You must select a engineer.")]
        public int EngineerId { get; set; }
        [Display(Name = "Engineer Name: ")]
        public string EngineerName { get; set; }
        public List<EngineerMachine> JoinEntities { get; }
    }
}