using System.Collections.Generic;
using cadeMedicoApi.Models;
using CadeMedicoApi.Models;
using Microsoft.EntityFrameworkCore;


namespace CadeMedicoApi.DATA
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        /*CRIANDO AS TABELAS*/
        public DbSet<MedicoModel> Medicos{get; set;}
        public DbSet<CidadeModel> Cidades{get; set;}
        public DbSet<EspecialidadeModel> Especialidades{get; set;}
        public DbSet<UsuarioModel> Usuarios{get; set;}
        public DbSet<PrivilegioModel> Privilegios{get; set;}

        protected override void OnModelCreating(ModelBuilder builder){

            builder.Entity<MedicoModel>()
                .HasData(new List<MedicoModel>(){
                    new MedicoModel(1,"Manuel Mejia","000444", "984898988"),
                    new MedicoModel(2,"Victor Barros","111222", "955554155"),
                    new MedicoModel(3,"Gadiel Mejia","555234", "944555868"),
                    new MedicoModel(4,"Adrian Mejia","050224", "912346579"),
                    new MedicoModel(5,"Yuqui Maria", "123555", "983584636")
            });


             builder.Entity<CidadeModel>()
                .HasData(new List<CidadeModel>(){
                    new CidadeModel(1,"Londrina", "PR"),
                    new CidadeModel(2,"Rolandia", "PR"),
                    new CidadeModel(3,"Maringá","PR"),
                    new CidadeModel(4,"Cambé","PR"),
                    new CidadeModel(5,"Ibipora","PR"),
            });   

            builder.Entity<EspecialidadeModel>()
                .HasData(new List<EspecialidadeModel>(){
                    new EspecialidadeModel(1,"Cardiologia"),
                    new EspecialidadeModel(2,"Obstetrícia"),
                    new EspecialidadeModel(3,"Pediatria"),
                    new EspecialidadeModel(4,"Neurologia"),
                    new EspecialidadeModel(5,"Oftalmologia")
            });   

            builder.Entity<PrivilegioModel>()
                .HasData(new List<PrivilegioModel>(){
                    new PrivilegioModel(1,"MASTER"),
                    new PrivilegioModel(2,"ADM"),
                    new PrivilegioModel(3,"USER"),
                    new PrivilegioModel(4,"USERMED")
               });  

            builder.Entity<UsuarioModel>()
                .HasData(new List<UsuarioModel>(){
                    new UsuarioModel(1, "Natasha","nat","321",1),
                    new UsuarioModel(2,"Shinichi","nishi","124",2),
                    new UsuarioModel (3,"Marceline","Marce","852",3),
                    new UsuarioModel(4,"Luci","lu","987",4),
                    new UsuarioModel(5,"Yuqui","yuyu","526",5)
            });  

             builder.Entity<MedicoCidade>()
             .HasKey(MC => new {MC.MedicoId, MC.CidadeId});

             builder.Entity <MedicoCidade>() .HasData(new List<MedicoCidade>(){
                 new MedicoCidade() {MedicoId = 1, CidadeId = 1},
                 new MedicoCidade() {MedicoId = 1, CidadeId = 2},
                 new MedicoCidade() {MedicoId = 3, CidadeId = 3},
                 new MedicoCidade() {MedicoId = 4, CidadeId = 4},
                 new MedicoCidade() {MedicoId = 5, CidadeId = 5},
           });

             builder.Entity<MedicoEspecialidade>()
             .HasKey(MC => new {MC.MedicoId, MC.EspecialidadeId});

             builder.Entity <MedicoEspecialidade>() .HasData(new List<MedicoEspecialidade>(){
                 new MedicoEspecialidade() {MedicoId = 5, EspecialidadeId = 1},
                 new MedicoEspecialidade() {MedicoId = 4, EspecialidadeId = 2},
                 new MedicoEspecialidade() {MedicoId = 3, EspecialidadeId = 3},
                 new MedicoEspecialidade() {MedicoId = 2, EspecialidadeId = 4},
                 new MedicoEspecialidade() {MedicoId = 1, EspecialidadeId = 5},
           });
        }
    }
}