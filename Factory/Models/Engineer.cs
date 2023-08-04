using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
    public class Engineer 
    {
        
        public int EngineerId { get; set; }
        [Display(Name = "Engineer Name: ")]
        public string EngineerName { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "You must select a machine.")]
        public int MachineId { get; set; }
        public List<EngineerMachine> JoinEntities { get; }
    }
}