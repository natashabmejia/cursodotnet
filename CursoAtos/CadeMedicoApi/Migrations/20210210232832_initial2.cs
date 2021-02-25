using Microsoft.EntityFrameworkCore.Migrations;

namespace CadeMedicoApi.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CidadeId",
                table: "Medicos");

            migrationBuilder.DropColumn(
                name: "EspecialidadeId",
                table: "Medicos");

            migrationBuilder.CreateTable(
                name: "MedicoEspecialidade",
                columns: table => new
                {
                    MedicoId = table.Column<int>(type: "INTEGER", nullable: false),
                    EspecialidadeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicoEspecialidade", x => new { x.MedicoId, x.EspecialidadeId });
                    table.ForeignKey(
                        name: "FK_MedicoEspecialidade_Especialidades_EspecialidadeId",
                        column: x => x.EspecialidadeId,
                        principalTable: "Especialidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicoEspecialidade_Medicos_MedicoId",
                        column: x => x.MedicoId,
                        principalTable: "Medicos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MedicoEspecialidade",
                columns: new[] { "EspecialidadeId", "MedicoId" },
                values: new object[] { 1, 5 });

            migrationBuilder.InsertData(
                table: "MedicoEspecialidade",
                columns: new[] { "EspecialidadeId", "MedicoId" },
                values: new object[] { 2, 4 });

            migrationBuilder.InsertData(
                table: "MedicoEspecialidade",
                columns: new[] { "EspecialidadeId", "MedicoId" },
                values: new object[] { 3, 3 });

            migrationBuilder.InsertData(
                table: "MedicoEspecialidade",
                columns: new[] { "EspecialidadeId", "MedicoId" },
                values: new object[] { 4, 2 });

            migrationBuilder.InsertData(
                table: "MedicoEspecialidade",
                columns: new[] { "EspecialidadeId", "MedicoId" },
                values: new object[] { 5, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_MedicoEspecialidade_EspecialidadeId",
                table: "MedicoEspecialidade",
                column: "EspecialidadeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicoEspecialidade");

            migrationBuilder.AddColumn<int>(
                name: "CidadeId",
                table: "Medicos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EspecialidadeId",
                table: "Medicos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CidadeId", "EspecialidadeId" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CidadeId", "EspecialidadeId" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "CidadeId", "EspecialidadeId" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "CidadeId", "EspecialidadeId" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "CidadeId", "EspecialidadeId" },
                values: new object[] { 5, 5 });
        }
    }
}
