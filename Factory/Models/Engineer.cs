using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
    public class Engineer 
    {
        
        public int EngineerId { get; set; }
        [Display(Name = "Engineer Name: ")]
        [Required(ErrorMessage = "The name field can't be blank.")]
        public string EngineerName { get; set; }
        [Required(ErrorMessage = "The job title field can't be blank.")]
        public int MachineId { get; set; }
        public string JobTitle { get; set; }
        public List<EngineerMachine> JoinEntities { get; }
    }
}