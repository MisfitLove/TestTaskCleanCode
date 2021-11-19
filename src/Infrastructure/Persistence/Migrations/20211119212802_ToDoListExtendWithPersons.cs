using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CleanArchitecture.Infrastructure.Persistence.Migrations
{
    public partial class ToDoListExtendWithPersons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonTodoList",
                columns: table => new
                {
                    PersonsPersonId = table.Column<Guid>(type: "uuid", nullable: false),
                    TodoListsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonTodoList", x => new { x.PersonsPersonId, x.TodoListsId });
                    table.ForeignKey(
                        name: "FK_PersonTodoList_Persons_PersonsPersonId",
                        column: x => x.PersonsPersonId,
                        principalTable: "Persons",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonTodoList_TodoLists_TodoListsId",
                        column: x => x.TodoListsId,
                        principalTable: "TodoLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonTodoList_TodoListsId",
                table: "PersonTodoList",
                column: "TodoListsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonTodoList");
        }
    }
}
