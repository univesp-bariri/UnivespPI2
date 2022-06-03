using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ProjectPI2.Migrations
{
    public partial class yellowpages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "candidatura",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    data = table.Column<DateTime>(type: "DATE", nullable: false),
                    expiradata = table.Column<DateTime>(type: "DATE", nullable: false),
                    contratanteId = table.Column<int>(type: "integer", nullable: false),
                    candidatoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_candidatura", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "candidato",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    qualificacao = table.Column<string>(type: "varchar(50)", nullable: true),
                    usuarioId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_candidato", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "categoria",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "varchar(50)", nullable: true),
                    candidaturaId = table.Column<int>(type: "integer", nullable: false),
                    trabalhoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categoria", x => x.id);
                    table.ForeignKey(
                        name: "FK_categoria_candidatura_candidaturaId",
                        column: x => x.candidaturaId,
                        principalTable: "candidatura",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "trabalho",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "varchar(50)", nullable: true),
                    titulo = table.Column<string>(type: "varchar(30)", nullable: true),
                    salario = table.Column<double>(type: "DOUBLE PRECISION", nullable: false),
                    dataContratacao = table.Column<DateTime>(type: "DATE", nullable: false),
                    categoriaId = table.Column<int>(type: "integer", nullable: false),
                    localId = table.Column<int>(type: "integer", nullable: false),
                    candidaturaId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trabalho", x => x.id);
                    table.ForeignKey(
                        name: "FK_trabalho_candidatura_candidaturaId",
                        column: x => x.candidaturaId,
                        principalTable: "candidatura",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trabalho_categoria_categoriaId",
                        column: x => x.categoriaId,
                        principalTable: "categoria",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "local",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "varchar(50)", nullable: true),
                    endereco = table.Column<string>(type: "varchar(50)", nullable: true),
                    cep = table.Column<string>(type: "varchar(8)", nullable: true),
                    cidade = table.Column<string>(type: "varchar(30)", nullable: true),
                    estado = table.Column<string>(type: "varchar(20)", nullable: true),
                    pais = table.Column<string>(type: "varchar(20)", nullable: true),
                    candidaturaId = table.Column<int>(type: "integer", nullable: false),
                    trabalhoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_local", x => x.id);
                    table.ForeignKey(
                        name: "FK_local_candidatura_candidaturaId",
                        column: x => x.candidaturaId,
                        principalTable: "candidatura",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_local_trabalho_trabalhoId",
                        column: x => x.trabalhoId,
                        principalTable: "trabalho",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "contratante",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    setor = table.Column<string>(type: "varchar(20)", nullable: true),
                    usuarioId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contratante", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    username = table.Column<string>(type: "varchar(20)", nullable: false),
                    senha = table.Column<string>(type: "varchar(20)", nullable: false),
                    email = table.Column<string>(type: "varchar(30)", nullable: false),
                    nome = table.Column<string>(type: "varchar(50)", nullable: false),
                    endereco = table.Column<string>(type: "varchar(50)", nullable: false),
                    cep = table.Column<string>(type: "varchar(8)", nullable: false),
                    cidade = table.Column<string>(type: "varchar(30)", nullable: false),
                    estado = table.Column<string>(type: "varchar(20)", nullable: false),
                    pais = table.Column<string>(type: "varchar(20)", nullable: false),
                    pjuridica = table.Column<bool>(type: "Boolean  DEFAULT FALSE", nullable: false),
                    cnpj = table.Column<string>(type: "VARCHAR(14)", nullable: true),
                    cpf = table.Column<string>(type: "VARCHAR(11)", nullable: true),
                    contratanteId = table.Column<int>(type: "integer", nullable: false),
                    candidatoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.id);
                    table.ForeignKey(
                        name: "FK_usuario_candidato_candidatoId",
                        column: x => x.candidatoId,
                        principalTable: "candidato",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_usuario_contratante_contratanteId",
                        column: x => x.contratanteId,
                        principalTable: "contratante",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_candidato_usuarioId",
                table: "candidato",
                column: "usuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_categoria_candidaturaId",
                table: "categoria",
                column: "candidaturaId");

            migrationBuilder.CreateIndex(
                name: "IX_categoria_trabalhoId",
                table: "categoria",
                column: "trabalhoId");

            migrationBuilder.CreateIndex(
                name: "IX_contratante_usuarioId",
                table: "contratante",
                column: "usuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_local_candidaturaId",
                table: "local",
                column: "candidaturaId");

            migrationBuilder.CreateIndex(
                name: "IX_local_trabalhoId",
                table: "local",
                column: "trabalhoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_trabalho_candidaturaId",
                table: "trabalho",
                column: "candidaturaId");

            migrationBuilder.CreateIndex(
                name: "IX_trabalho_categoriaId",
                table: "trabalho",
                column: "categoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_usuario_candidatoId",
                table: "usuario",
                column: "candidatoId");

            migrationBuilder.CreateIndex(
                name: "IX_usuario_contratanteId",
                table: "usuario",
                column: "contratanteId");

            migrationBuilder.AddForeignKey(
                name: "FK_candidato_usuario_usuarioId",
                table: "candidato",
                column: "usuarioId",
                principalTable: "usuario",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_categoria_trabalho_trabalhoId",
                table: "categoria",
                column: "trabalhoId",
                principalTable: "trabalho",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_contratante_usuario_usuarioId",
                table: "contratante",
                column: "usuarioId",
                principalTable: "usuario",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_candidato_usuario_usuarioId",
                table: "candidato");

            migrationBuilder.DropForeignKey(
                name: "FK_contratante_usuario_usuarioId",
                table: "contratante");

            migrationBuilder.DropForeignKey(
                name: "FK_categoria_candidatura_candidaturaId",
                table: "categoria");

            migrationBuilder.DropForeignKey(
                name: "FK_trabalho_candidatura_candidaturaId",
                table: "trabalho");

            migrationBuilder.DropForeignKey(
                name: "FK_categoria_trabalho_trabalhoId",
                table: "categoria");

            migrationBuilder.DropTable(
                name: "local");

            migrationBuilder.DropTable(
                name: "usuario");

            migrationBuilder.DropTable(
                name: "candidato");

            migrationBuilder.DropTable(
                name: "contratante");

            migrationBuilder.DropTable(
                name: "candidatura");

            migrationBuilder.DropTable(
                name: "trabalho");

            migrationBuilder.DropTable(
                name: "categoria");
        }
    }
}
