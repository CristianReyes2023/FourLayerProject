using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistencia.Data.Migrations
{
    /// <inheritdoc />
    public partial class FourthMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ciudad_departamento_IdDepartamentoFk",
                table: "ciudad");

            migrationBuilder.DropForeignKey(
                name: "FK_departamento_pais_IdPaisFk",
                table: "departamento");

            migrationBuilder.DropForeignKey(
                name: "FK_persona_ciudad_IdCiudadFk",
                table: "persona");

            migrationBuilder.AlterColumn<int>(
                name: "IdCiudadFk",
                table: "persona",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "varchar(3)",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "pais",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(3)",
                oldMaxLength: 3)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "IdPaisFk",
                table: "departamento",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "varchar(3)",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "departamento",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(3)",
                oldMaxLength: 3)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "IdDepartamentoFk",
                table: "ciudad",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "varchar(3)",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ciudad",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(3)",
                oldMaxLength: 3)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_ciudad_departamento_IdDepartamentoFk",
                table: "ciudad",
                column: "IdDepartamentoFk",
                principalTable: "departamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_departamento_pais_IdPaisFk",
                table: "departamento",
                column: "IdPaisFk",
                principalTable: "pais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_persona_ciudad_IdCiudadFk",
                table: "persona",
                column: "IdCiudadFk",
                principalTable: "ciudad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ciudad_departamento_IdDepartamentoFk",
                table: "ciudad");

            migrationBuilder.DropForeignKey(
                name: "FK_departamento_pais_IdPaisFk",
                table: "departamento");

            migrationBuilder.DropForeignKey(
                name: "FK_persona_ciudad_IdCiudadFk",
                table: "persona");

            migrationBuilder.AlterColumn<string>(
                name: "IdCiudadFk",
                table: "persona",
                type: "varchar(3)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "pais",
                type: "varchar(3)",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "IdPaisFk",
                table: "departamento",
                type: "varchar(3)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "departamento",
                type: "varchar(3)",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "IdDepartamentoFk",
                table: "ciudad",
                type: "varchar(3)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "ciudad",
                type: "varchar(3)",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddForeignKey(
                name: "FK_ciudad_departamento_IdDepartamentoFk",
                table: "ciudad",
                column: "IdDepartamentoFk",
                principalTable: "departamento",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_departamento_pais_IdPaisFk",
                table: "departamento",
                column: "IdPaisFk",
                principalTable: "pais",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_persona_ciudad_IdCiudadFk",
                table: "persona",
                column: "IdCiudadFk",
                principalTable: "ciudad",
                principalColumn: "Id");
        }
    }
}
