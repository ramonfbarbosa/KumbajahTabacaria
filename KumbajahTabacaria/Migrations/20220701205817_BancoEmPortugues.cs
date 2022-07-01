using Microsoft.EntityFrameworkCore.Migrations;

namespace KumbajahTabacaria.Migrations
{
    public partial class BancoEmPortugues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_ORDER_ITEMS_TB_ORDERS_ORDER_ID",
                table: "TB_ORDER_ITEMS");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_ORDER_ITEMS_TB_PRODUCTS_PRODUCT_ID",
                table: "TB_ORDER_ITEMS");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_ORDERS_TB_ADDRESSES_ADDRESS_ID",
                table: "TB_ORDERS");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_ORDERS_TB_ORDER_STATUS_ORDER_STATUS_ID",
                table: "TB_ORDERS");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_ORDERS_TB_USERS_USER_ID",
                table: "TB_ORDERS");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_PRODUCTS_TB_BRANDS_BRAND_ID",
                table: "TB_PRODUCTS");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_PRODUCTS_TB_CATEGORIES_CATEGORY_ID",
                table: "TB_PRODUCTS");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_PRODUCTS_TB_COLORS_COLOR_ID",
                table: "TB_PRODUCTS");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_PRODUCTS_TB_STOCKS_STOCK_ID",
                table: "TB_PRODUCTS");

            migrationBuilder.DropTable(
                name: "AddressUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_USERS",
                table: "TB_USERS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_STOCKS",
                table: "TB_STOCKS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_PRODUCTS",
                table: "TB_PRODUCTS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_ORDERS",
                table: "TB_ORDERS");

            migrationBuilder.DropIndex(
                name: "IX_TB_ORDERS_ADDRESS_ID",
                table: "TB_ORDERS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_ORDER_STATUS",
                table: "TB_ORDER_STATUS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_ORDER_ITEMS",
                table: "TB_ORDER_ITEMS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_COLORS",
                table: "TB_COLORS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_CATEGORIES",
                table: "TB_CATEGORIES");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_BRANDS",
                table: "TB_BRANDS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_ADDRESSES",
                table: "TB_ADDRESSES");

            migrationBuilder.DropColumn(
                name: "ConfirmPassword",
                table: "TB_USERS");

            migrationBuilder.RenameTable(
                name: "TB_USERS",
                newName: "TAB_CLIENTES");

            migrationBuilder.RenameTable(
                name: "TB_STOCKS",
                newName: "TAB_ESTOQUE");

            migrationBuilder.RenameTable(
                name: "TB_PRODUCTS",
                newName: "TAB_PRODUTOS");

            migrationBuilder.RenameTable(
                name: "TB_ORDERS",
                newName: "TAB_PEDIDOS");

            migrationBuilder.RenameTable(
                name: "TB_ORDER_STATUS",
                newName: "TAB_STATUS_DO_PEDIDO");

            migrationBuilder.RenameTable(
                name: "TB_ORDER_ITEMS",
                newName: "TAB_ITENS_DE_PEDIDO");

            migrationBuilder.RenameTable(
                name: "TB_COLORS",
                newName: "TAB_CORES");

            migrationBuilder.RenameTable(
                name: "TB_CATEGORIES",
                newName: "TAB_CATEGORIAS");

            migrationBuilder.RenameTable(
                name: "TB_BRANDS",
                newName: "TAB_MARCAS");

            migrationBuilder.RenameTable(
                name: "TB_ADDRESSES",
                newName: "TAB_ENDERECOS");

            migrationBuilder.RenameColumn(
                name: "PHONE_NUMBER",
                table: "TAB_CLIENTES",
                newName: "CELULAR");

            migrationBuilder.RenameColumn(
                name: "PASSWORD",
                table: "TAB_CLIENTES",
                newName: "SENHA");

            migrationBuilder.RenameColumn(
                name: "LAST_NAME",
                table: "TAB_CLIENTES",
                newName: "SOBRENOME");

            migrationBuilder.RenameColumn(
                name: "BIRTH_DATE",
                table: "TAB_CLIENTES",
                newName: "DT_ANIVERSARIO");

            migrationBuilder.RenameColumn(
                name: "QUANTITY",
                table: "TAB_ESTOQUE",
                newName: "QUANTIDADE");

            migrationBuilder.RenameColumn(
                name: "PRICE",
                table: "TAB_PRODUTOS",
                newName: "PRECO");

            migrationBuilder.RenameColumn(
                name: "NAME",
                table: "TAB_PRODUTOS",
                newName: "NOME");

            migrationBuilder.RenameColumn(
                name: "IMAGE",
                table: "TAB_PRODUTOS",
                newName: "IMAGEM");

            migrationBuilder.RenameColumn(
                name: "DESCRIPTION",
                table: "TAB_PRODUTOS",
                newName: "DESCRICAO");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "TAB_PRODUTOS",
                newName: "CreatedTime");

            migrationBuilder.RenameIndex(
                name: "IX_TB_PRODUCTS_STOCK_ID",
                table: "TAB_PRODUTOS",
                newName: "IX_TAB_PRODUTOS_STOCK_ID");

            migrationBuilder.RenameIndex(
                name: "IX_TB_PRODUCTS_COLOR_ID",
                table: "TAB_PRODUTOS",
                newName: "IX_TAB_PRODUTOS_COLOR_ID");

            migrationBuilder.RenameIndex(
                name: "IX_TB_PRODUCTS_CATEGORY_ID",
                table: "TAB_PRODUTOS",
                newName: "IX_TAB_PRODUTOS_CATEGORY_ID");

            migrationBuilder.RenameIndex(
                name: "IX_TB_PRODUCTS_BRAND_ID",
                table: "TAB_PRODUTOS",
                newName: "IX_TAB_PRODUTOS_BRAND_ID");

            migrationBuilder.RenameColumn(
                name: "PHONE_NUMBER",
                table: "TAB_PEDIDOS",
                newName: "CELULAR");

            migrationBuilder.RenameColumn(
                name: "BUY_MOMENT",
                table: "TAB_PEDIDOS",
                newName: "HR_COMPRA");

            migrationBuilder.RenameIndex(
                name: "IX_TB_ORDERS_USER_ID",
                table: "TAB_PEDIDOS",
                newName: "IX_TAB_PEDIDOS_USER_ID");

            migrationBuilder.RenameIndex(
                name: "IX_TB_ORDERS_ORDER_STATUS_ID",
                table: "TAB_PEDIDOS",
                newName: "IX_TAB_PEDIDOS_ORDER_STATUS_ID");

            migrationBuilder.RenameColumn(
                name: "QUANTITY",
                table: "TAB_ITENS_DE_PEDIDO",
                newName: "QUANTIDADE");

            migrationBuilder.RenameColumn(
                name: "PRICE",
                table: "TAB_ITENS_DE_PEDIDO",
                newName: "PRECO");

            migrationBuilder.RenameIndex(
                name: "IX_TB_ORDER_ITEMS_PRODUCT_ID",
                table: "TAB_ITENS_DE_PEDIDO",
                newName: "IX_TAB_ITENS_DE_PEDIDO_PRODUCT_ID");

            migrationBuilder.RenameIndex(
                name: "IX_TB_ORDER_ITEMS_ORDER_ID",
                table: "TAB_ITENS_DE_PEDIDO",
                newName: "IX_TAB_ITENS_DE_PEDIDO_ORDER_ID");

            migrationBuilder.RenameColumn(
                name: "COLOR_NAME",
                table: "TAB_CORES",
                newName: "NM_COR");

            migrationBuilder.RenameColumn(
                name: "NAME",
                table: "TAB_CATEGORIAS",
                newName: "NM_CATEGORIA");

            migrationBuilder.RenameColumn(
                name: "NAME",
                table: "TAB_MARCAS",
                newName: "NM_MARCA");

            migrationBuilder.RenameColumn(
                name: "STREET",
                table: "TAB_ENDERECOS",
                newName: "RUA");

            migrationBuilder.RenameColumn(
                name: "STATE",
                table: "TAB_ENDERECOS",
                newName: "ESTADO");

            migrationBuilder.RenameColumn(
                name: "REFERENCE",
                table: "TAB_ENDERECOS",
                newName: "REFERENCIA");

            migrationBuilder.RenameColumn(
                name: "NUMBER",
                table: "TAB_ENDERECOS",
                newName: "NUMERO");

            migrationBuilder.RenameColumn(
                name: "DISTRICT",
                table: "TAB_ENDERECOS",
                newName: "BAIRRO");

            migrationBuilder.RenameColumn(
                name: "COMPLEMENT",
                table: "TAB_ENDERECOS",
                newName: "COMPLEMENTO");

            migrationBuilder.RenameColumn(
                name: "CITY",
                table: "TAB_ENDERECOS",
                newName: "CIDADE");

            migrationBuilder.AlterColumn<string>(
                name: "CELULAR",
                table: "TAB_CLIENTES",
                type: "VARCHAR(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(80)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CELULAR",
                table: "TAB_PEDIDOS",
                type: "VARCHAR(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "ESTADO",
                table: "TAB_ENDERECOS",
                type: "VARCHAR(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(MAX)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "CIDADE",
                table: "TAB_ENDERECOS",
                type: "VARCHAR(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(MAX)",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "TAB_ENDERECOS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TAB_CLIENTES",
                table: "TAB_CLIENTES",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TAB_ESTOQUE",
                table: "TAB_ESTOQUE",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TAB_PRODUTOS",
                table: "TAB_PRODUTOS",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TAB_PEDIDOS",
                table: "TAB_PEDIDOS",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TAB_STATUS_DO_PEDIDO",
                table: "TAB_STATUS_DO_PEDIDO",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TAB_ITENS_DE_PEDIDO",
                table: "TAB_ITENS_DE_PEDIDO",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TAB_CORES",
                table: "TAB_CORES",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TAB_CATEGORIAS",
                table: "TAB_CATEGORIAS",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TAB_MARCAS",
                table: "TAB_MARCAS",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TAB_ENDERECOS",
                table: "TAB_ENDERECOS",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "TAB_USER_ADDRESS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USER_ID = table.Column<int>(type: "INT", nullable: false),
                    ADDRESS_ID = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TAB_USER_ADDRESS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TAB_USER_ADDRESS_TAB_CLIENTES_USER_ID",
                        column: x => x.USER_ID,
                        principalTable: "TAB_CLIENTES",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TAB_USER_ADDRESS_TAB_ENDERECOS_USER_ID",
                        column: x => x.USER_ID,
                        principalTable: "TAB_ENDERECOS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TAB_PEDIDOS_ADDRESS_ID",
                table: "TAB_PEDIDOS",
                column: "ADDRESS_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TAB_USER_ADDRESS_USER_ID",
                table: "TAB_USER_ADDRESS",
                column: "USER_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TAB_ITENS_DE_PEDIDO_TAB_PEDIDOS_ORDER_ID",
                table: "TAB_ITENS_DE_PEDIDO",
                column: "ORDER_ID",
                principalTable: "TAB_PEDIDOS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TAB_ITENS_DE_PEDIDO_TAB_PRODUTOS_PRODUCT_ID",
                table: "TAB_ITENS_DE_PEDIDO",
                column: "PRODUCT_ID",
                principalTable: "TAB_PRODUTOS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TAB_PEDIDOS_TAB_CLIENTES_USER_ID",
                table: "TAB_PEDIDOS",
                column: "USER_ID",
                principalTable: "TAB_CLIENTES",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TAB_PEDIDOS_TAB_ENDERECOS_ADDRESS_ID",
                table: "TAB_PEDIDOS",
                column: "ADDRESS_ID",
                principalTable: "TAB_ENDERECOS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TAB_PEDIDOS_TAB_STATUS_DO_PEDIDO_ORDER_STATUS_ID",
                table: "TAB_PEDIDOS",
                column: "ORDER_STATUS_ID",
                principalTable: "TAB_STATUS_DO_PEDIDO",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TAB_PRODUTOS_TAB_CATEGORIAS_CATEGORY_ID",
                table: "TAB_PRODUTOS",
                column: "CATEGORY_ID",
                principalTable: "TAB_CATEGORIAS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TAB_PRODUTOS_TAB_CORES_COLOR_ID",
                table: "TAB_PRODUTOS",
                column: "COLOR_ID",
                principalTable: "TAB_CORES",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TAB_PRODUTOS_TAB_ESTOQUE_STOCK_ID",
                table: "TAB_PRODUTOS",
                column: "STOCK_ID",
                principalTable: "TAB_ESTOQUE",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TAB_PRODUTOS_TAB_MARCAS_BRAND_ID",
                table: "TAB_PRODUTOS",
                column: "BRAND_ID",
                principalTable: "TAB_MARCAS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TAB_ITENS_DE_PEDIDO_TAB_PEDIDOS_ORDER_ID",
                table: "TAB_ITENS_DE_PEDIDO");

            migrationBuilder.DropForeignKey(
                name: "FK_TAB_ITENS_DE_PEDIDO_TAB_PRODUTOS_PRODUCT_ID",
                table: "TAB_ITENS_DE_PEDIDO");

            migrationBuilder.DropForeignKey(
                name: "FK_TAB_PEDIDOS_TAB_CLIENTES_USER_ID",
                table: "TAB_PEDIDOS");

            migrationBuilder.DropForeignKey(
                name: "FK_TAB_PEDIDOS_TAB_ENDERECOS_ADDRESS_ID",
                table: "TAB_PEDIDOS");

            migrationBuilder.DropForeignKey(
                name: "FK_TAB_PEDIDOS_TAB_STATUS_DO_PEDIDO_ORDER_STATUS_ID",
                table: "TAB_PEDIDOS");

            migrationBuilder.DropForeignKey(
                name: "FK_TAB_PRODUTOS_TAB_CATEGORIAS_CATEGORY_ID",
                table: "TAB_PRODUTOS");

            migrationBuilder.DropForeignKey(
                name: "FK_TAB_PRODUTOS_TAB_CORES_COLOR_ID",
                table: "TAB_PRODUTOS");

            migrationBuilder.DropForeignKey(
                name: "FK_TAB_PRODUTOS_TAB_ESTOQUE_STOCK_ID",
                table: "TAB_PRODUTOS");

            migrationBuilder.DropForeignKey(
                name: "FK_TAB_PRODUTOS_TAB_MARCAS_BRAND_ID",
                table: "TAB_PRODUTOS");

            migrationBuilder.DropTable(
                name: "TAB_USER_ADDRESS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TAB_STATUS_DO_PEDIDO",
                table: "TAB_STATUS_DO_PEDIDO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TAB_PRODUTOS",
                table: "TAB_PRODUTOS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TAB_PEDIDOS",
                table: "TAB_PEDIDOS");

            migrationBuilder.DropIndex(
                name: "IX_TAB_PEDIDOS_ADDRESS_ID",
                table: "TAB_PEDIDOS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TAB_MARCAS",
                table: "TAB_MARCAS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TAB_ITENS_DE_PEDIDO",
                table: "TAB_ITENS_DE_PEDIDO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TAB_ESTOQUE",
                table: "TAB_ESTOQUE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TAB_ENDERECOS",
                table: "TAB_ENDERECOS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TAB_CORES",
                table: "TAB_CORES");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TAB_CLIENTES",
                table: "TAB_CLIENTES");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TAB_CATEGORIAS",
                table: "TAB_CATEGORIAS");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "TAB_ENDERECOS");

            migrationBuilder.RenameTable(
                name: "TAB_STATUS_DO_PEDIDO",
                newName: "TB_ORDER_STATUS");

            migrationBuilder.RenameTable(
                name: "TAB_PRODUTOS",
                newName: "TB_PRODUCTS");

            migrationBuilder.RenameTable(
                name: "TAB_PEDIDOS",
                newName: "TB_ORDERS");

            migrationBuilder.RenameTable(
                name: "TAB_MARCAS",
                newName: "TB_BRANDS");

            migrationBuilder.RenameTable(
                name: "TAB_ITENS_DE_PEDIDO",
                newName: "TB_ORDER_ITEMS");

            migrationBuilder.RenameTable(
                name: "TAB_ESTOQUE",
                newName: "TB_STOCKS");

            migrationBuilder.RenameTable(
                name: "TAB_ENDERECOS",
                newName: "TB_ADDRESSES");

            migrationBuilder.RenameTable(
                name: "TAB_CORES",
                newName: "TB_COLORS");

            migrationBuilder.RenameTable(
                name: "TAB_CLIENTES",
                newName: "TB_USERS");

            migrationBuilder.RenameTable(
                name: "TAB_CATEGORIAS",
                newName: "TB_CATEGORIES");

            migrationBuilder.RenameColumn(
                name: "PRECO",
                table: "TB_PRODUCTS",
                newName: "PRICE");

            migrationBuilder.RenameColumn(
                name: "NOME",
                table: "TB_PRODUCTS",
                newName: "NAME");

            migrationBuilder.RenameColumn(
                name: "IMAGEM",
                table: "TB_PRODUCTS",
                newName: "IMAGE");

            migrationBuilder.RenameColumn(
                name: "DESCRICAO",
                table: "TB_PRODUCTS",
                newName: "DESCRIPTION");

            migrationBuilder.RenameColumn(
                name: "CreatedTime",
                table: "TB_PRODUCTS",
                newName: "CreatedAt");

            migrationBuilder.RenameIndex(
                name: "IX_TAB_PRODUTOS_STOCK_ID",
                table: "TB_PRODUCTS",
                newName: "IX_TB_PRODUCTS_STOCK_ID");

            migrationBuilder.RenameIndex(
                name: "IX_TAB_PRODUTOS_COLOR_ID",
                table: "TB_PRODUCTS",
                newName: "IX_TB_PRODUCTS_COLOR_ID");

            migrationBuilder.RenameIndex(
                name: "IX_TAB_PRODUTOS_CATEGORY_ID",
                table: "TB_PRODUCTS",
                newName: "IX_TB_PRODUCTS_CATEGORY_ID");

            migrationBuilder.RenameIndex(
                name: "IX_TAB_PRODUTOS_BRAND_ID",
                table: "TB_PRODUCTS",
                newName: "IX_TB_PRODUCTS_BRAND_ID");

            migrationBuilder.RenameColumn(
                name: "HR_COMPRA",
                table: "TB_ORDERS",
                newName: "BUY_MOMENT");

            migrationBuilder.RenameColumn(
                name: "CELULAR",
                table: "TB_ORDERS",
                newName: "PHONE_NUMBER");

            migrationBuilder.RenameIndex(
                name: "IX_TAB_PEDIDOS_USER_ID",
                table: "TB_ORDERS",
                newName: "IX_TB_ORDERS_USER_ID");

            migrationBuilder.RenameIndex(
                name: "IX_TAB_PEDIDOS_ORDER_STATUS_ID",
                table: "TB_ORDERS",
                newName: "IX_TB_ORDERS_ORDER_STATUS_ID");

            migrationBuilder.RenameColumn(
                name: "NM_MARCA",
                table: "TB_BRANDS",
                newName: "NAME");

            migrationBuilder.RenameColumn(
                name: "QUANTIDADE",
                table: "TB_ORDER_ITEMS",
                newName: "QUANTITY");

            migrationBuilder.RenameColumn(
                name: "PRECO",
                table: "TB_ORDER_ITEMS",
                newName: "PRICE");

            migrationBuilder.RenameIndex(
                name: "IX_TAB_ITENS_DE_PEDIDO_PRODUCT_ID",
                table: "TB_ORDER_ITEMS",
                newName: "IX_TB_ORDER_ITEMS_PRODUCT_ID");

            migrationBuilder.RenameIndex(
                name: "IX_TAB_ITENS_DE_PEDIDO_ORDER_ID",
                table: "TB_ORDER_ITEMS",
                newName: "IX_TB_ORDER_ITEMS_ORDER_ID");

            migrationBuilder.RenameColumn(
                name: "QUANTIDADE",
                table: "TB_STOCKS",
                newName: "QUANTITY");

            migrationBuilder.RenameColumn(
                name: "RUA",
                table: "TB_ADDRESSES",
                newName: "STREET");

            migrationBuilder.RenameColumn(
                name: "REFERENCIA",
                table: "TB_ADDRESSES",
                newName: "REFERENCE");

            migrationBuilder.RenameColumn(
                name: "NUMERO",
                table: "TB_ADDRESSES",
                newName: "NUMBER");

            migrationBuilder.RenameColumn(
                name: "ESTADO",
                table: "TB_ADDRESSES",
                newName: "STATE");

            migrationBuilder.RenameColumn(
                name: "COMPLEMENTO",
                table: "TB_ADDRESSES",
                newName: "COMPLEMENT");

            migrationBuilder.RenameColumn(
                name: "CIDADE",
                table: "TB_ADDRESSES",
                newName: "CITY");

            migrationBuilder.RenameColumn(
                name: "BAIRRO",
                table: "TB_ADDRESSES",
                newName: "DISTRICT");

            migrationBuilder.RenameColumn(
                name: "NM_COR",
                table: "TB_COLORS",
                newName: "COLOR_NAME");

            migrationBuilder.RenameColumn(
                name: "SOBRENOME",
                table: "TB_USERS",
                newName: "LAST_NAME");

            migrationBuilder.RenameColumn(
                name: "SENHA",
                table: "TB_USERS",
                newName: "PASSWORD");

            migrationBuilder.RenameColumn(
                name: "DT_ANIVERSARIO",
                table: "TB_USERS",
                newName: "BIRTH_DATE");

            migrationBuilder.RenameColumn(
                name: "CELULAR",
                table: "TB_USERS",
                newName: "PHONE_NUMBER");

            migrationBuilder.RenameColumn(
                name: "NM_CATEGORIA",
                table: "TB_CATEGORIES",
                newName: "NAME");

            migrationBuilder.AlterColumn<string>(
                name: "PHONE_NUMBER",
                table: "TB_ORDERS",
                type: "VARCHAR(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "STATE",
                table: "TB_ADDRESSES",
                type: "VARCHAR(MAX)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "CITY",
                table: "TB_ADDRESSES",
                type: "VARCHAR(MAX)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "PHONE_NUMBER",
                table: "TB_USERS",
                type: "VARCHAR(80)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(20)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConfirmPassword",
                table: "TB_USERS",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_ORDER_STATUS",
                table: "TB_ORDER_STATUS",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_PRODUCTS",
                table: "TB_PRODUCTS",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_ORDERS",
                table: "TB_ORDERS",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_BRANDS",
                table: "TB_BRANDS",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_ORDER_ITEMS",
                table: "TB_ORDER_ITEMS",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_STOCKS",
                table: "TB_STOCKS",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_ADDRESSES",
                table: "TB_ADDRESSES",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_COLORS",
                table: "TB_COLORS",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_USERS",
                table: "TB_USERS",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_CATEGORIES",
                table: "TB_CATEGORIES",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "AddressUser",
                columns: table => new
                {
                    AddressesId = table.Column<int>(type: "INT", nullable: false),
                    UsersId = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressUser", x => new { x.AddressesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_AddressUser_TB_ADDRESSES_AddressesId",
                        column: x => x.AddressesId,
                        principalTable: "TB_ADDRESSES",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AddressUser_TB_USERS_UsersId",
                        column: x => x.UsersId,
                        principalTable: "TB_USERS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ORDERS_ADDRESS_ID",
                table: "TB_ORDERS",
                column: "ADDRESS_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AddressUser_UsersId",
                table: "AddressUser",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ORDER_ITEMS_TB_ORDERS_ORDER_ID",
                table: "TB_ORDER_ITEMS",
                column: "ORDER_ID",
                principalTable: "TB_ORDERS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ORDER_ITEMS_TB_PRODUCTS_PRODUCT_ID",
                table: "TB_ORDER_ITEMS",
                column: "PRODUCT_ID",
                principalTable: "TB_PRODUCTS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ORDERS_TB_ADDRESSES_ADDRESS_ID",
                table: "TB_ORDERS",
                column: "ADDRESS_ID",
                principalTable: "TB_ADDRESSES",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ORDERS_TB_ORDER_STATUS_ORDER_STATUS_ID",
                table: "TB_ORDERS",
                column: "ORDER_STATUS_ID",
                principalTable: "TB_ORDER_STATUS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ORDERS_TB_USERS_USER_ID",
                table: "TB_ORDERS",
                column: "USER_ID",
                principalTable: "TB_USERS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PRODUCTS_TB_BRANDS_BRAND_ID",
                table: "TB_PRODUCTS",
                column: "BRAND_ID",
                principalTable: "TB_BRANDS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PRODUCTS_TB_CATEGORIES_CATEGORY_ID",
                table: "TB_PRODUCTS",
                column: "CATEGORY_ID",
                principalTable: "TB_CATEGORIES",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PRODUCTS_TB_COLORS_COLOR_ID",
                table: "TB_PRODUCTS",
                column: "COLOR_ID",
                principalTable: "TB_COLORS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PRODUCTS_TB_STOCKS_STOCK_ID",
                table: "TB_PRODUCTS",
                column: "STOCK_ID",
                principalTable: "TB_STOCKS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
