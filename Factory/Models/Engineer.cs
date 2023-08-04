using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
    public class Engineer 
    {
        public int EngineerId { get; set; }
        [Display(Name = "Engineer Name: ")]
        public string EngineerName { get; set; }
        public List<EngineerMachine> JoinEntities { get; }
    }
}