using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiDDD.Infra.Data.Migrations
{
    public partial class create_tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ALUNO",
                columns: table => new
                {
                    IDALUNO = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NOME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Matricula = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMAIL = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DATANASCIMENTO = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ALUNO", x => x.IDALUNO);
                });

            migrationBuilder.CreateTable(
                name: "PROFESSOR",
                columns: table => new
                {
                    IDPROFESSOR = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NOME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROFESSOR", x => x.IDPROFESSOR);
                });

            migrationBuilder.CreateTable(
                name: "USUARIO",
                columns: table => new
                {
                    IDUSUARIO = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NOME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    EMAIL = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    SENHA = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DATACRIACAO = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIO", x => x.IDUSUARIO);
                });

            migrationBuilder.CreateTable(
                name: "TURMA",
                columns: table => new
                {
                    IDTURMA = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NOME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PERIODO = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DATAINICIO = table.Column<DateTime>(type: "date", nullable: false),
                    DATATERMINO = table.Column<DateTime>(type: "date", nullable: false),
                    IDPROFESSOR = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TURMA", x => x.IDTURMA);
                    table.ForeignKey(
                        name: "FK_TURMA_PROFESSOR_IDPROFESSOR",
                        column: x => x.IDPROFESSOR,
                        principalTable: "PROFESSOR",
                        principalColumn: "IDPROFESSOR",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TURMAALUNO",
                columns: table => new
                {
                    IDTURMA = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDALUNO = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TURMAALUNO", x => new { x.IDTURMA, x.IDALUNO });
                    table.ForeignKey(
                        name: "FK_TURMAALUNO_ALUNO_IDALUNO",
                        column: x => x.IDALUNO,
                        principalTable: "ALUNO",
                        principalColumn: "IDALUNO",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TURMAALUNO_TURMA_IDTURMA",
                        column: x => x.IDTURMA,
                        principalTable: "TURMA",
                        principalColumn: "IDTURMA",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TURMA_IDPROFESSOR",
                table: "TURMA",
                column: "IDPROFESSOR");

            migrationBuilder.CreateIndex(
                name: "IX_TURMAALUNO_IDALUNO",
                table: "TURMAALUNO",
                column: "IDALUNO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TURMAALUNO");

            migrationBuilder.DropTable(
                name: "USUARIO");

            migrationBuilder.DropTable(
                name: "ALUNO");

            migrationBuilder.DropTable(
                name: "TURMA");

            migrationBuilder.DropTable(
                name: "PROFESSOR");
        }
    }
}
