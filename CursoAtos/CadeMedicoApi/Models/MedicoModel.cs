using System.Collections.Generic;
using CadeMedicoApi.Models;

namespace cadeMedicoApi.Models
{
    public class MedicoModel
    {
       public MedicoModel(){} 

       public MedicoModel(int id, string nome, string crm, string telefone)
       {
           this.id = id;
           this.Nome = nome;
           this.Crm = crm;
           this.Telefone = telefone;
           
       }
        public int id {get;set;}

        public string Nome {get;set;}
        
        public string Crm {get;set;}

        public string Telefone {get;set;}

        
        public IEnumerable<MedicoCidade> MedicoCidade { get; set; }

        public IEnumerable<MedicoEspecialidade> MedicoEspecialidade{get; set; }
        
        
    

    }
}