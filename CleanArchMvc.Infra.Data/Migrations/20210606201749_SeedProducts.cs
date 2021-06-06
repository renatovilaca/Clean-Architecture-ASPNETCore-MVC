using Microsoft.EntityFrameworkCore.Migrations;

namespace CleanArchMvc.Infra.Data.Migrations
{
    public partial class SeedProducts : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Products(Name,Description,Price,Stock,Image,CategoryId) " +
                "VALUES('Pencil','Pencil 0.20',1.34,50,'pencil1.jpg',1)");

            mb.Sql("INSERT INTO Products(Name,Description,Price,Stock,Image,CategoryId) " +
                "VALUES('Rule','Rule 30cm',5.30,60,'rule30.jpg',1)");

            mb.Sql("INSERT INTO Products(Name,Description,Price,Stock,Image,CategoryId) " +
                 "VALUES('Calculator','Calcultaro Cassio X4344',35.00,50,'calcultatorcassio.jpg',2)");

            mb.Sql("INSERT INTO Products(Name,Description,Price,Stock,Image,CategoryId) " +
                "VALUES('Paper Box','Paper Box 500 sheets',52.00,100,'paperbox.jpg',3)");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Products");
        }
    }
}
