using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mailer_API.Migrations
{
    public partial class initialmigscript : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "draft_mail_table",
                columns: table => new
                {
                    draft_mail_ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    mail_from = table.Column<string>(maxLength: 80, nullable: true),
                    mail_subject = table.Column<string>(maxLength: 100, nullable: true),
                    mail_body = table.Column<string>(maxLength: 5000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_draft_mail_table", x => x.draft_mail_ID);
                });

            migrationBuilder.CreateTable(
                name: "mail_table",
                columns: table => new
                {
                    mail_ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    mail_from = table.Column<string>(maxLength: 80, nullable: true),
                    mail_to_1 = table.Column<string>(maxLength: 80, nullable: true),
                    mail_to_2 = table.Column<string>(maxLength: 80, nullable: true),
                    mail_to_3 = table.Column<string>(maxLength: 80, nullable: true),
                    mail_to_4 = table.Column<string>(maxLength: 80, nullable: true),
                    mail_to_5 = table.Column<string>(maxLength: 80, nullable: true),
                    mail_subject = table.Column<string>(maxLength: 100, nullable: true),
                    mail_body = table.Column<string>(maxLength: 5000, nullable: true),
                    mail_date = table.Column<DateTime>(nullable: false),
                    mail_status = table.Column<string>(nullable: true),
                    is_starred = table.Column<int>(nullable: false),
                    is_important = table.Column<int>(nullable: false),
                    sender_delete_status = table.Column<string>(nullable: true),
                    receiver_delete_status = table.Column<string>(nullable: true),
                    attachment_1 = table.Column<string>(maxLength: 100, nullable: true),
                    attachment_2 = table.Column<string>(maxLength: 100, nullable: true),
                    attachment_3 = table.Column<string>(maxLength: 100, nullable: true),
                    attachment_4 = table.Column<string>(maxLength: 100, nullable: true),
                    attachment_5 = table.Column<string>(maxLength: 100, nullable: true),
                    sender_id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mail_table", x => x.mail_ID);
                });

            migrationBuilder.CreateTable(
                name: "user_table",
                columns: table => new
                {
                    user_ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    first_name = table.Column<string>(maxLength: 20, nullable: true),
                    second_name = table.Column<string>(maxLength: 20, nullable: true),
                    username = table.Column<string>(maxLength: 20, nullable: true),
                    password = table.Column<string>(maxLength: 16, nullable: true),
                    phone_number = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_table", x => x.user_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "draft_mail_table");

            migrationBuilder.DropTable(
                name: "mail_table");

            migrationBuilder.DropTable(
                name: "user_table");
        }
    }
}
