using cadeMedicoApi.Models;
using System.Collections.Generic;

namespace CadeMedicoApi.Models
{
    public class EspecialidadeModel
    {
        public EspecialidadeModel()
        {}

        public EspecialidadeModel(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;
            
        }
       public int Id {get; set; }
       public string Nome {get; set; } 

       public IEnumerable<MedicoEspecialidade> MedicoEspecialidade{get; set; }
      
       
       

    }
}