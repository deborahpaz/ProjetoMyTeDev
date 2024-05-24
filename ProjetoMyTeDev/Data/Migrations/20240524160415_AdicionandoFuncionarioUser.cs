using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoMyTeDev.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoFuncionarioUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RegistroDiario_Funcionario_FuncionarioId",
                table: "RegistroDiario");

            migrationBuilder.DropTable(
                name: "Funcionario");

            migrationBuilder.DropIndex(
                name: "IX_RegistroDiario_FuncionarioId",
                table: "RegistroDiario");

            migrationBuilder.AddColumn<string>(
                name: "FuncionarioId1",
                table: "RegistroDiario",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CargoId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataContratacao",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DepartamentoId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FuncionarioId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FuncionarioNome",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Localidade",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NivelAcessoId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_RegistroDiario_FuncionarioId1",
                table: "RegistroDiario",
                column: "FuncionarioId1");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CargoId",
                table: "AspNetUsers",
                column: "CargoId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DepartamentoId",
                table: "AspNetUsers",
                column: "DepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_NivelAcessoId",
                table: "AspNetUsers",
                column: "NivelAcessoId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Cargo_CargoId",
                table: "AspNetUsers",
                column: "CargoId",
                principalTable: "Cargo",
                principalColumn: "CargoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Departamento_DepartamentoId",
                table: "AspNetUsers",
                column: "DepartamentoId",
                principalTable: "Departamento",
                principalColumn: "DepartamentoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_NivelAcesso_NivelAcessoId",
                table: "AspNetUsers",
                column: "NivelAcessoId",
                principalTable: "NivelAcesso",
                principalColumn: "NivelAcessoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RegistroDiario_AspNetUsers_FuncionarioId1",
                table: "RegistroDiario",
                column: "FuncionarioId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Cargo_CargoId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Departamento_DepartamentoId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_NivelAcesso_NivelAcessoId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_RegistroDiario_AspNetUsers_FuncionarioId1",
                table: "RegistroDiario");

            migrationBuilder.DropIndex(
                name: "IX_RegistroDiario_FuncionarioId1",
                table: "RegistroDiario");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CargoId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_DepartamentoId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_NivelAcessoId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FuncionarioId1",
                table: "RegistroDiario");

            migrationBuilder.DropColumn(
                name: "CargoId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DataContratacao",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DepartamentoId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FuncionarioId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FuncionarioNome",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Localidade",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NivelAcessoId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Senha",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    FuncionarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CargoId = table.Column<int>(type: "int", nullable: false),
                    DepartamentoId = table.Column<int>(type: "int", nullable: false),
                    NivelAcessoId = table.Column<int>(type: "int", nullable: false),
                    DataContratacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FuncionarioNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Localidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.FuncionarioId);
                    table.ForeignKey(
                        name: "FK_Funcionario_Cargo_CargoId",
                        column: x => x.CargoId,
                        principalTable: "Cargo",
                        principalColumn: "CargoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Funcionario_Departamento_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "Departamento",
                        principalColumn: "DepartamentoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Funcionario_NivelAcesso_NivelAcessoId",
                        column: x => x.NivelAcessoId,
                        principalTable: "NivelAcesso",
                        principalColumn: "NivelAcessoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RegistroDiario_FuncionarioId",
                table: "RegistroDiario",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_CargoId",
                table: "Funcionario",
                column: "CargoId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_DepartamentoId",
                table: "Funcionario",
                column: "DepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_NivelAcessoId",
                table: "Funcionario",
                column: "NivelAcessoId");

            migrationBuilder.AddForeignKey(
                name: "FK_RegistroDiario_Funcionario_FuncionarioId",
                table: "RegistroDiario",
                column: "FuncionarioId",
                principalTable: "Funcionario",
                principalColumn: "FuncionarioId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
