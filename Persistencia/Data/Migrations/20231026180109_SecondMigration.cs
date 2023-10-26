using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistencia.Data.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ciudades_Departamentos_DepartamentoId",
                table: "Ciudades");

            migrationBuilder.DropForeignKey(
                name: "FK_Departamentos_Paises_PaisId",
                table: "Departamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Direccion_Personas_PersonaId",
                table: "Direccion");

            migrationBuilder.DropForeignKey(
                name: "FK_Matriculas_Personas_PersonaId",
                table: "Matriculas");

            migrationBuilder.DropForeignKey(
                name: "FK_Matriculas_Salones_SalonId",
                table: "Matriculas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Ciudades_CiudadId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Generos_GeneroId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_TipoPersonas_TipoPersonaId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainerSalones_Personas_PersonaId",
                table: "TrainerSalones");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainerSalones_Salones_SalonId",
                table: "TrainerSalones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Direccion",
                table: "Direccion");

            migrationBuilder.DropIndex(
                name: "IX_Direccion_PersonaId",
                table: "Direccion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainerSalones",
                table: "TrainerSalones");

            migrationBuilder.DropIndex(
                name: "IX_TrainerSalones_PersonaId",
                table: "TrainerSalones");

            migrationBuilder.DropIndex(
                name: "IX_TrainerSalones_SalonId",
                table: "TrainerSalones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoPersonas",
                table: "TipoPersonas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Salones",
                table: "Salones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Personas",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_CiudadId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_GeneroId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_TipoPersonaId",
                table: "Personas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Paises",
                table: "Paises");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Matriculas",
                table: "Matriculas");

            migrationBuilder.DropIndex(
                name: "IX_Matriculas_PersonaId",
                table: "Matriculas");

            migrationBuilder.DropIndex(
                name: "IX_Matriculas_SalonId",
                table: "Matriculas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Generos",
                table: "Generos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departamentos",
                table: "Departamentos");

            migrationBuilder.DropIndex(
                name: "IX_Departamentos_PaisId",
                table: "Departamentos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ciudades",
                table: "Ciudades");

            migrationBuilder.DropIndex(
                name: "IX_Ciudades_DepartamentoId",
                table: "Ciudades");

            migrationBuilder.DropColumn(
                name: "PersonaId",
                table: "Direccion");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TrainerSalones");

            migrationBuilder.DropColumn(
                name: "PersonaId",
                table: "TrainerSalones");

            migrationBuilder.DropColumn(
                name: "SalonId",
                table: "TrainerSalones");

            migrationBuilder.DropColumn(
                name: "CiudadId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "GeneroId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "IdNumeroPersona",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "TipoPersonaId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "PersonaId",
                table: "Matriculas");

            migrationBuilder.DropColumn(
                name: "SalonId",
                table: "Matriculas");

            migrationBuilder.DropColumn(
                name: "PaisId",
                table: "Departamentos");

            migrationBuilder.DropColumn(
                name: "DepartamentoId",
                table: "Ciudades");

            migrationBuilder.RenameTable(
                name: "Direccion",
                newName: "direccion");

            migrationBuilder.RenameTable(
                name: "TrainerSalones",
                newName: "trainersalon");

            migrationBuilder.RenameTable(
                name: "TipoPersonas",
                newName: "tipopersona");

            migrationBuilder.RenameTable(
                name: "Salones",
                newName: "salon");

            migrationBuilder.RenameTable(
                name: "Personas",
                newName: "persona");

            migrationBuilder.RenameTable(
                name: "Paises",
                newName: "pais");

            migrationBuilder.RenameTable(
                name: "Matriculas",
                newName: "matricula");

            migrationBuilder.RenameTable(
                name: "Generos",
                newName: "genero");

            migrationBuilder.RenameTable(
                name: "Departamentos",
                newName: "departamento");

            migrationBuilder.RenameTable(
                name: "Ciudades",
                newName: "ciudad");

            migrationBuilder.UpdateData(
                table: "direccion",
                keyColumn: "TipoVia",
                keyValue: null,
                column: "TipoVia",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "TipoVia",
                table: "direccion",
                type: "varchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "direccion",
                keyColumn: "SufijoCardinal",
                keyValue: null,
                column: "SufijoCardinal",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "SufijoCardinal",
                table: "direccion",
                type: "varchar(3)",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "direccion",
                keyColumn: "LetraViaSecundaria",
                keyValue: null,
                column: "LetraViaSecundaria",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "LetraViaSecundaria",
                table: "direccion",
                type: "varchar(3)",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "direccion",
                keyColumn: "Letra",
                keyValue: null,
                column: "Letra",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Letra",
                table: "direccion",
                type: "varchar(3)",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "IdPersonaFk",
                table: "direccion",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "trainersalon",
                keyColumn: "IdPersonaFk",
                keyValue: null,
                column: "IdPersonaFk",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "IdPersonaFk",
                table: "trainersalon",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "tipopersona",
                keyColumn: "DescripcionTipoPersona",
                keyValue: null,
                column: "DescripcionTipoPersona",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "DescripcionTipoPersona",
                table: "tipopersona",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "salon",
                keyColumn: "NombreSalon",
                keyValue: null,
                column: "NombreSalon",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "NombreSalon",
                table: "salon",
                type: "varchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "NombrePersona",
                keyValue: null,
                column: "NombrePersona",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "NombrePersona",
                table: "persona",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "IdCiudadFk",
                table: "persona",
                type: "varchar(3)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "persona",
                keyColumn: "ApellidoPersona",
                keyValue: null,
                column: "ApellidoPersona",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "ApellidoPersona",
                table: "persona",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "persona",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.UpdateData(
                table: "pais",
                keyColumn: "NombrePais",
                keyValue: null,
                column: "NombrePais",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "NombrePais",
                table: "pais",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

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
                name: "IdPersonaFk",
                table: "matricula",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "genero",
                keyColumn: "NombreGenero",
                keyValue: null,
                column: "NombreGenero",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "NombreGenero",
                table: "genero",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "departamento",
                keyColumn: "NombreDepartamento",
                keyValue: null,
                column: "NombreDepartamento",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "NombreDepartamento",
                table: "departamento",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

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

            migrationBuilder.UpdateData(
                table: "ciudad",
                keyColumn: "NombreCiudad",
                keyValue: null,
                column: "NombreCiudad",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "NombreCiudad",
                table: "ciudad",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_direccion",
                table: "direccion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_trainersalon",
                table: "trainersalon",
                columns: new[] { "IdPersonaFk", "IdSalonFk" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_tipopersona",
                table: "tipopersona",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_salon",
                table: "salon",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_persona",
                table: "persona",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_pais",
                table: "pais",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_matricula",
                table: "matricula",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_genero",
                table: "genero",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_departamento",
                table: "departamento",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ciudad",
                table: "ciudad",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_direccion_IdPersonaFk",
                table: "direccion",
                column: "IdPersonaFk");

            migrationBuilder.CreateIndex(
                name: "IX_trainersalon_IdSalonFk",
                table: "trainersalon",
                column: "IdSalonFk");

            migrationBuilder.CreateIndex(
                name: "IX_persona_IdCiudadFk",
                table: "persona",
                column: "IdCiudadFk");

            migrationBuilder.CreateIndex(
                name: "IX_persona_IdGeneroFk",
                table: "persona",
                column: "IdGeneroFk");

            migrationBuilder.CreateIndex(
                name: "IX_persona_IdTipoPerFk",
                table: "persona",
                column: "IdTipoPerFk");

            migrationBuilder.CreateIndex(
                name: "IX_matricula_IdPersonaFk",
                table: "matricula",
                column: "IdPersonaFk");

            migrationBuilder.CreateIndex(
                name: "IX_matricula_IdSalonFk",
                table: "matricula",
                column: "IdSalonFk");

            migrationBuilder.CreateIndex(
                name: "IX_departamento_IdPaisFk",
                table: "departamento",
                column: "IdPaisFk");

            migrationBuilder.CreateIndex(
                name: "IX_ciudad_IdDepartamentoFk",
                table: "ciudad",
                column: "IdDepartamentoFk");

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
                name: "FK_direccion_persona_IdPersonaFk",
                table: "direccion",
                column: "IdPersonaFk",
                principalTable: "persona",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_matricula_persona_IdPersonaFk",
                table: "matricula",
                column: "IdPersonaFk",
                principalTable: "persona",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_matricula_salon_IdSalonFk",
                table: "matricula",
                column: "IdSalonFk",
                principalTable: "salon",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_persona_ciudad_IdCiudadFk",
                table: "persona",
                column: "IdCiudadFk",
                principalTable: "ciudad",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_persona_genero_IdGeneroFk",
                table: "persona",
                column: "IdGeneroFk",
                principalTable: "genero",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_persona_tipopersona_IdTipoPerFk",
                table: "persona",
                column: "IdTipoPerFk",
                principalTable: "tipopersona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_trainersalon_persona_IdPersonaFk",
                table: "trainersalon",
                column: "IdPersonaFk",
                principalTable: "persona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_trainersalon_salon_IdSalonFk",
                table: "trainersalon",
                column: "IdSalonFk",
                principalTable: "salon",
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
                name: "FK_direccion_persona_IdPersonaFk",
                table: "direccion");

            migrationBuilder.DropForeignKey(
                name: "FK_matricula_persona_IdPersonaFk",
                table: "matricula");

            migrationBuilder.DropForeignKey(
                name: "FK_matricula_salon_IdSalonFk",
                table: "matricula");

            migrationBuilder.DropForeignKey(
                name: "FK_persona_ciudad_IdCiudadFk",
                table: "persona");

            migrationBuilder.DropForeignKey(
                name: "FK_persona_genero_IdGeneroFk",
                table: "persona");

            migrationBuilder.DropForeignKey(
                name: "FK_persona_tipopersona_IdTipoPerFk",
                table: "persona");

            migrationBuilder.DropForeignKey(
                name: "FK_trainersalon_persona_IdPersonaFk",
                table: "trainersalon");

            migrationBuilder.DropForeignKey(
                name: "FK_trainersalon_salon_IdSalonFk",
                table: "trainersalon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_direccion",
                table: "direccion");

            migrationBuilder.DropIndex(
                name: "IX_direccion_IdPersonaFk",
                table: "direccion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_trainersalon",
                table: "trainersalon");

            migrationBuilder.DropIndex(
                name: "IX_trainersalon_IdSalonFk",
                table: "trainersalon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tipopersona",
                table: "tipopersona");

            migrationBuilder.DropPrimaryKey(
                name: "PK_salon",
                table: "salon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_persona",
                table: "persona");

            migrationBuilder.DropIndex(
                name: "IX_persona_IdCiudadFk",
                table: "persona");

            migrationBuilder.DropIndex(
                name: "IX_persona_IdGeneroFk",
                table: "persona");

            migrationBuilder.DropIndex(
                name: "IX_persona_IdTipoPerFk",
                table: "persona");

            migrationBuilder.DropPrimaryKey(
                name: "PK_pais",
                table: "pais");

            migrationBuilder.DropPrimaryKey(
                name: "PK_matricula",
                table: "matricula");

            migrationBuilder.DropIndex(
                name: "IX_matricula_IdPersonaFk",
                table: "matricula");

            migrationBuilder.DropIndex(
                name: "IX_matricula_IdSalonFk",
                table: "matricula");

            migrationBuilder.DropPrimaryKey(
                name: "PK_genero",
                table: "genero");

            migrationBuilder.DropPrimaryKey(
                name: "PK_departamento",
                table: "departamento");

            migrationBuilder.DropIndex(
                name: "IX_departamento_IdPaisFk",
                table: "departamento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ciudad",
                table: "ciudad");

            migrationBuilder.DropIndex(
                name: "IX_ciudad_IdDepartamentoFk",
                table: "ciudad");

            migrationBuilder.RenameTable(
                name: "direccion",
                newName: "Direccion");

            migrationBuilder.RenameTable(
                name: "trainersalon",
                newName: "TrainerSalones");

            migrationBuilder.RenameTable(
                name: "tipopersona",
                newName: "TipoPersonas");

            migrationBuilder.RenameTable(
                name: "salon",
                newName: "Salones");

            migrationBuilder.RenameTable(
                name: "persona",
                newName: "Personas");

            migrationBuilder.RenameTable(
                name: "pais",
                newName: "Paises");

            migrationBuilder.RenameTable(
                name: "matricula",
                newName: "Matriculas");

            migrationBuilder.RenameTable(
                name: "genero",
                newName: "Generos");

            migrationBuilder.RenameTable(
                name: "departamento",
                newName: "Departamentos");

            migrationBuilder.RenameTable(
                name: "ciudad",
                newName: "Ciudades");

            migrationBuilder.AlterColumn<string>(
                name: "TipoVia",
                table: "Direccion",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldMaxLength: 15)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "SufijoCardinal",
                table: "Direccion",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(3)",
                oldMaxLength: 3)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "LetraViaSecundaria",
                table: "Direccion",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(3)",
                oldMaxLength: 3)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Letra",
                table: "Direccion",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(3)",
                oldMaxLength: 3)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "IdPersonaFk",
                table: "Direccion",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "PersonaId",
                table: "Direccion",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdPersonaFk",
                table: "TrainerSalones",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "TrainerSalones",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "PersonaId",
                table: "TrainerSalones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SalonId",
                table: "TrainerSalones",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DescripcionTipoPersona",
                table: "TipoPersonas",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "NombreSalon",
                table: "Salones",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(25)",
                oldMaxLength: 25)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "NombrePersona",
                table: "Personas",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "IdCiudadFk",
                table: "Personas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "varchar(3)",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "ApellidoPersona",
                table: "Personas",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Personas",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "CiudadId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GeneroId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdNumeroPersona",
                table: "Personas",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "TipoPersonaId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NombrePais",
                table: "Paises",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Paises",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(3)",
                oldMaxLength: 3)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "IdPersonaFk",
                table: "Matriculas",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "PersonaId",
                table: "Matriculas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SalonId",
                table: "Matriculas",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NombreGenero",
                table: "Generos",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "NombreDepartamento",
                table: "Departamentos",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "IdPaisFk",
                table: "Departamentos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "varchar(3)",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Departamentos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(3)",
                oldMaxLength: 3)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "PaisId",
                table: "Departamentos",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NombreCiudad",
                table: "Ciudades",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "IdDepartamentoFk",
                table: "Ciudades",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "varchar(3)",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Ciudades",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(3)",
                oldMaxLength: 3)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "DepartamentoId",
                table: "Ciudades",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Direccion",
                table: "Direccion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainerSalones",
                table: "TrainerSalones",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoPersonas",
                table: "TipoPersonas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Salones",
                table: "Salones",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Personas",
                table: "Personas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Paises",
                table: "Paises",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Matriculas",
                table: "Matriculas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Generos",
                table: "Generos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departamentos",
                table: "Departamentos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ciudades",
                table: "Ciudades",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Direccion_PersonaId",
                table: "Direccion",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainerSalones_PersonaId",
                table: "TrainerSalones",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainerSalones_SalonId",
                table: "TrainerSalones",
                column: "SalonId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_CiudadId",
                table: "Personas",
                column: "CiudadId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_GeneroId",
                table: "Personas",
                column: "GeneroId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_TipoPersonaId",
                table: "Personas",
                column: "TipoPersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_PersonaId",
                table: "Matriculas",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_SalonId",
                table: "Matriculas",
                column: "SalonId");

            migrationBuilder.CreateIndex(
                name: "IX_Departamentos_PaisId",
                table: "Departamentos",
                column: "PaisId");

            migrationBuilder.CreateIndex(
                name: "IX_Ciudades_DepartamentoId",
                table: "Ciudades",
                column: "DepartamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ciudades_Departamentos_DepartamentoId",
                table: "Ciudades",
                column: "DepartamentoId",
                principalTable: "Departamentos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Departamentos_Paises_PaisId",
                table: "Departamentos",
                column: "PaisId",
                principalTable: "Paises",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Direccion_Personas_PersonaId",
                table: "Direccion",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Matriculas_Personas_PersonaId",
                table: "Matriculas",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Matriculas_Salones_SalonId",
                table: "Matriculas",
                column: "SalonId",
                principalTable: "Salones",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Ciudades_CiudadId",
                table: "Personas",
                column: "CiudadId",
                principalTable: "Ciudades",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Generos_GeneroId",
                table: "Personas",
                column: "GeneroId",
                principalTable: "Generos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_TipoPersonas_TipoPersonaId",
                table: "Personas",
                column: "TipoPersonaId",
                principalTable: "TipoPersonas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerSalones_Personas_PersonaId",
                table: "TrainerSalones",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerSalones_Salones_SalonId",
                table: "TrainerSalones",
                column: "SalonId",
                principalTable: "Salones",
                principalColumn: "Id");
        }
    }
}
