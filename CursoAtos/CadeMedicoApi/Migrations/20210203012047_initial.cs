using Microsoft.EntityFrameworkCore.Migrations;

namespace CadeMedicoApi.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Estado = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Especialidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medicos",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    EspecialidadeId = table.Column<int>(type: "INTEGER", nullable: false),
                    Crm = table.Column<string>(type: "TEXT", nullable: true),
                    Telefone = table.Column<string>(type: "TEXT", nullable: true),
                    CidadeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Privilegios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Privilegios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Login = table.Column<string>(type: "TEXT", nullable: true),
                    Senha = table.Column<string>(type: "TEXT", nullable: true),
                    PrivilegioId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedicoCidade",
                columns: table => new
                {
                    MedicoId = table.Column<int>(type: "INTEGER", nullable: false),
                    CidadeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicoCidade", x => new { x.MedicoId, x.CidadeId });
                    table.ForeignKey(
                        name: "FK_MedicoCidade_Cidades_CidadeId",
                        column: x => x.CidadeId,
                        principalTable: "Cidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicoCidade_Medicos_MedicoId",
                        column: x => x.MedicoId,
                        principalTable: "Medicos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Estado", "Nome" },
                values: new object[] { 5, "PR", "Ibipora" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Estado", "Nome" },
                values: new object[] { 4, "PR", "Cambé" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Estado", "Nome" },
                values: new object[] { 3, "PR", "Maringá" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Estado", "Nome" },
                values: new object[] { 2, "PR", "Rolandia" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Estado", "Nome" },
                values: new object[] { 1, "PR", "Londrina" });

            migrationBuilder.InsertData(
                table: "Especialidades",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 1, "Cardiologia" });

            migrationBuilder.InsertData(
                table: "Especialidades",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 2, "Obstetrícia" });

            migrationBuilder.InsertData(
                table: "Especialidades",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 3, "Pediatria" });

            migrationBuilder.InsertData(
                table: "Especialidades",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 4, "Neurologia" });

            migrationBuilder.InsertData(
                table: "Especialidades",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 5, "Oftalmologia" });

            migrationBuilder.InsertData(
                table: "Medicos",
                columns: new[] { "id", "CidadeId", "Crm", "EspecialidadeId", "Nome", "Telefone" },
                values: new object[] { 3, 3, "555234", 3, "Gadiel Mejia", "944555868" });

            migrationBuilder.InsertData(
                table: "Medicos",
                columns: new[] { "id", "CidadeId", "Crm", "EspecialidadeId", "Nome", "Telefone" },
                values: new object[] { 2, 2, "111222", 1, "Victor Barros", "955554155" });

            migrationBuilder.InsertData(
                table: "Medicos",
                columns: new[] { "id", "CidadeId", "Crm", "EspecialidadeId", "Nome", "Telefone" },
                values: new object[] { 1, 1, "000444", 2, "Manuel Mejia", "984898988" });

            migrationBuilder.InsertData(
                table: "Medicos",
                columns: new[] { "id", "CidadeId", "Crm", "EspecialidadeId", "Nome", "Telefone" },
                values: new object[] { 5, 5, "123555", 5, "Yuqui Maria", "983584636" });

            migrationBuilder.InsertData(
                table: "Medicos",
                columns: new[] { "id", "CidadeId", "Crm", "EspecialidadeId", "Nome", "Telefone" },
                values: new object[] { 4, 4, "050224", 4, "Adrian Mejia", "912346579" });

            migrationBuilder.InsertData(
                table: "Privilegios",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 4, "USERMED" });

            migrationBuilder.InsertData(
                table: "Privilegios",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 3, "USER" });

            migrationBuilder.InsertData(
                table: "Privilegios",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 2, "ADM" });

            migrationBuilder.InsertData(
                table: "Privilegios",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 1, "MASTER" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Login", "Nome", "PrivilegioId", "Senha" },
                values: new object[] { 4, "lu", "Luci", 4, "987" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Login", "Nome", "PrivilegioId", "Senha" },
                values: new object[] { 2, "nishi", "Shinichi", 2, "124" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Login", "Nome", "PrivilegioId", "Senha" },
                values: new object[] { 1, "nat", "Natasha", 1, "321" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Login", "Nome", "PrivilegioId", "Senha" },
                values: new object[] { 5, "yuyu", "Yuqui", 5, "526" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Login", "Nome", "PrivilegioId", "Senha" },
                values: new object[] { 3, "Marce", "Marceline", 3, "852" });

            migrationBuilder.InsertData(
                table: "MedicoCidade",
                columns: new[] { "CidadeId", "MedicoId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "MedicoCidade",
                columns: new[] { "CidadeId", "MedicoId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "MedicoCidade",
                columns: new[] { "CidadeId", "MedicoId" },
                values: new object[] { 3, 3 });

            migrationBuilder.InsertData(
                table: "MedicoCidade",
                columns: new[] { "CidadeId", "MedicoId" },
                values: new object[] { 4, 4 });

            migrationBuilder.InsertData(
                table: "MedicoCidade",
                columns: new[] { "CidadeId", "MedicoId" },
                values: new object[] { 5, 5 });

            migrationBuilder.CreateIndex(
                name: "IX_MedicoCidade_CidadeId",
                table: "MedicoCidade",
                column: "CidadeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Especialidades");

            migrationBuilder.DropTable(
                name: "MedicoCidade");

            migrationBuilder.DropTable(
                name: "Privilegios");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Cidades");

            migrationBuilder.DropTable(
                name: "Medicos");
        }
    }
}
