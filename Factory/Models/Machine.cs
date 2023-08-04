using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
    public class Machine
    {
        // [Required(ErrorMessage = "You must select a machine.")]
        public int MachineId { get; set; }
        [Display(Name = "Machine Name: ")]
        public string MachineName { get; set; }
        public List<EngineerMachine> JoinEntities { get; }
    
    }
}