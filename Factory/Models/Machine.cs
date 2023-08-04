using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
    public class Machine
    {
        
        public int MachineId { get; set; }
        [Display(Name = "Machine Name: ")]
        public string MachineName { get; set; }
        [Required(ErrorMessage ="You must select an engineer.")]
        public int EngineerId { get; set; }
        public List<EngineerMachine> JoinEntities { get; }
    
    }
}