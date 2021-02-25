using System.Threading.Tasks;
using cadeMedicoApi.Models;


namespace CadeMedicoApi.DATA
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : class;

        void Delete<T>(T entity) where T : class;

        void Update<T>(T entity) where T : class;

        Task<bool> SaveChangesAsync();
      

        //MEDICO
        Task<MedicoModel[]> GetAllMedicoModelAsync(bool includeMedico);

        Task<MedicoModel[]> GetMedicoModelByEspecialidadeId(int EspecialidadeId, bool includeEspecialidade);

        Task<MedicoModel> GetMedicoModelById(int medicoid, bool includeCidade);

        //CIDADE

        Task<CidadeModel[]> GetAllCidadeModelAsync(bool includeCidade);

        Task<CidadeModel> GetCidadeModelById(int cidadeid, bool includeMedico);
        

        //USUARIO







    }
    
   
}      

    
