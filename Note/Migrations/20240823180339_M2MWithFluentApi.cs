using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Note.Migrations
{
    /// <inheritdoc />
    public partial class M2MWithFluentApi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "coursestudent");

            migrationBuilder.CreateTable(
                name: "StudentCourse",
                columns: table => new
                {
                    studentID = table.Column<int>(type: "int", nullable: false),
                    courseID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourse", x => new { x.studentID, x.courseID });
                    table.ForeignKey(
                        name: "FK_StudentCourse_Courses_courseID",
                        column: x => x.courseID,
                        principalTable: "Courses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentCourse_students_studentID",
                        column: x => x.studentID,
                        principalTable: "students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourse_courseID",
                table: "StudentCourse",
                column: "courseID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentCourse");

            migrationBuilder.CreateTable(
                name: "coursestudent",
                columns: table => new
                {
                    CoursesID = table.Column<int>(type: "int", nullable: false),
                    StudentsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_coursestudent", x => new { x.CoursesID, x.StudentsID });
                    table.ForeignKey(
                        name: "FK_coursestudent_Courses_CoursesID",
                        column: x => x.CoursesID,
                        principalTable: "Courses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_coursestudent_students_StudentsID",
                        column: x => x.StudentsID,
                        principalTable: "students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_coursestudent_StudentsID",
                table: "coursestudent",
                column: "StudentsID");
        }
    }
}
