// using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PcShop.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BoardFormFactor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SizeClass = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoardFormFactor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PcComponent",
                columns: table => new
                {
                    ComponentId = table.Column<Guid>(type: "uuid", nullable: false),
                    ComponentType = table.Column<string>(type: "text", nullable: false),
                    Brand = table.Column<string>(type: "text", nullable: false),
                    Model = table.Column<string>(type: "text", nullable: false),
                    CurrentPrice = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: false),
                    IsSellable = table.Column<bool>(type: "boolean", nullable: false),
                    StockQuantity = table.Column<int>(type: "integer", nullable: false),
                    ImageUrl = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    ReleaseYear = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PcComponent", x => x.ComponentId);
                });

            migrationBuilder.CreateTable(
                name: "Port",
                columns: table => new
                {
                    PortId = table.Column<Guid>(type: "uuid", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    Version = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Port", x => x.PortId);
                });

            migrationBuilder.CreateTable(
                name: "StorageFormFactor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorageFormFactor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Username = table.Column<string>(type: "text", nullable: false),
                    EmailAddress = table.Column<string>(type: "text", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: false),
                    RoleLevel = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Case",
                columns: table => new
                {
                    ComponentId = table.Column<Guid>(type: "uuid", nullable: false),
                    FormFactorId = table.Column<Guid>(type: "uuid", nullable: false),
                    Color = table.Column<string>(type: "text", nullable: false),
                    PanelType = table.Column<string>(type: "text", nullable: false),
                    CableManagement = table.Column<string>(type: "text", nullable: true),
                    MaxGpuClearanceMm = table.Column<int>(type: "integer", nullable: false),
                    MaxCpuCoolerHeightMm = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Case", x => x.ComponentId);
                    table.ForeignKey(
                        name: "FK_Case_BoardFormFactor_FormFactorId",
                        column: x => x.FormFactorId,
                        principalTable: "BoardFormFactor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Case_PcComponent_ComponentId",
                        column: x => x.ComponentId,
                        principalTable: "PcComponent",
                        principalColumn: "ComponentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cooling",
                columns: table => new
                {
                    ComponentId = table.Column<Guid>(type: "uuid", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    HeightMm = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cooling", x => x.ComponentId);
                    table.ForeignKey(
                        name: "FK_Cooling_PcComponent_ComponentId",
                        column: x => x.ComponentId,
                        principalTable: "PcComponent",
                        principalColumn: "ComponentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CPU",
                columns: table => new
                {
                    ComponentId = table.Column<Guid>(type: "uuid", nullable: false),
                    Cores = table.Column<int>(type: "integer", nullable: false),
                    PerformanceCores = table.Column<int>(type: "integer", nullable: true),
                    Threads = table.Column<int>(type: "integer", nullable: false),
                    Socket = table.Column<string>(type: "text", nullable: false),
                    Frequency = table.Column<int>(type: "integer", nullable: false),
                    Cache = table.Column<int>(type: "integer", nullable: false),
                    Wattage = table.Column<int>(type: "integer", nullable: false),
                    HasIntegratedGraphics = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPU", x => x.ComponentId);
                    table.ForeignKey(
                        name: "FK_CPU_PcComponent_ComponentId",
                        column: x => x.ComponentId,
                        principalTable: "PcComponent",
                        principalColumn: "ComponentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GPU",
                columns: table => new
                {
                    ComponentId = table.Column<Guid>(type: "uuid", nullable: false),
                    VulkanVersion = table.Column<double>(type: "double precision", precision: 10, scale: 1, nullable: false),
                    OpenglVersion = table.Column<double>(type: "double precision", precision: 10, scale: 1, nullable: true),
                    CudaCores = table.Column<int>(type: "integer", nullable: true),
                    Cores = table.Column<int>(type: "integer", nullable: false),
                    VramAmount = table.Column<int>(type: "integer", nullable: false),
                    VramType = table.Column<string>(type: "text", nullable: false),
                    Frequency = table.Column<int>(type: "integer", nullable: false),
                    Wattage = table.Column<int>(type: "integer", nullable: false),
                    Cooling = table.Column<string>(type: "text", nullable: false),
                    FansAmount = table.Column<int>(type: "integer", nullable: true),
                    Overclockable = table.Column<bool>(type: "boolean", nullable: false),
                    BiosLock = table.Column<bool>(type: "boolean", nullable: false),
                    Color = table.Column<string>(type: "text", nullable: true),
                    LengthMm = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GPU", x => x.ComponentId);
                    table.ForeignKey(
                        name: "FK_GPU_PcComponent_ComponentId",
                        column: x => x.ComponentId,
                        principalTable: "PcComponent",
                        principalColumn: "ComponentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Motherboard",
                columns: table => new
                {
                    ComponentId = table.Column<Guid>(type: "uuid", nullable: false),
                    FormFactorId = table.Column<Guid>(type: "uuid", nullable: false),
                    Socket = table.Column<string>(type: "text", nullable: false),
                    PcieSlots = table.Column<int>(type: "integer", nullable: false),
                    RamSlots = table.Column<int>(type: "integer", nullable: false),
                    RamType = table.Column<string>(type: "text", nullable: false),
                    MaxRamCapacityGb = table.Column<int>(type: "integer", nullable: false),
                    SataConnections = table.Column<int>(type: "integer", nullable: false),
                    OnboardWifiVersion = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motherboard", x => x.ComponentId);
                    table.ForeignKey(
                        name: "FK_Motherboard_BoardFormFactor_FormFactorId",
                        column: x => x.FormFactorId,
                        principalTable: "BoardFormFactor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Motherboard_PcComponent_ComponentId",
                        column: x => x.ComponentId,
                        principalTable: "PcComponent",
                        principalColumn: "ComponentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NetworkCard",
                columns: table => new
                {
                    ComponentId = table.Column<Guid>(type: "uuid", nullable: false),
                    WifiType = table.Column<string>(type: "text", nullable: false),
                    BluetoothType = table.Column<string>(type: "text", nullable: true),
                    MaxSpeed = table.Column<int>(type: "integer", nullable: false),
                    PcieLevel = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NetworkCard", x => x.ComponentId);
                    table.ForeignKey(
                        name: "FK_NetworkCard_PcComponent_ComponentId",
                        column: x => x.ComponentId,
                        principalTable: "PcComponent",
                        principalColumn: "ComponentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PSU",
                columns: table => new
                {
                    ComponentId = table.Column<Guid>(type: "uuid", nullable: false),
                    Wattage = table.Column<int>(type: "integer", nullable: false),
                    Rating = table.Column<string>(type: "text", nullable: true),
                    Modular = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PSU", x => x.ComponentId);
                    table.ForeignKey(
                        name: "FK_PSU_PcComponent_ComponentId",
                        column: x => x.ComponentId,
                        principalTable: "PcComponent",
                        principalColumn: "ComponentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RAM",
                columns: table => new
                {
                    ComponentId = table.Column<Guid>(type: "uuid", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    Frequency = table.Column<int>(type: "integer", nullable: false),
                    Size = table.Column<int>(type: "integer", nullable: false),
                    Color = table.Column<string>(type: "text", nullable: true),
                    Wattage = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RAM", x => x.ComponentId);
                    table.ForeignKey(
                        name: "FK_RAM_PcComponent_ComponentId",
                        column: x => x.ComponentId,
                        principalTable: "PcComponent",
                        principalColumn: "ComponentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sticker",
                columns: table => new
                {
                    ComponentId = table.Column<Guid>(type: "uuid", nullable: false),
                    WidthMm = table.Column<int>(type: "integer", nullable: false),
                    HeightMm = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sticker", x => x.ComponentId);
                    table.ForeignKey(
                        name: "FK_Sticker_PcComponent_ComponentId",
                        column: x => x.ComponentId,
                        principalTable: "PcComponent",
                        principalColumn: "ComponentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Storage",
                columns: table => new
                {
                    ComponentId = table.Column<Guid>(type: "uuid", nullable: false),
                    FormFactorId = table.Column<Guid>(type: "uuid", nullable: false),
                    StorageSize = table.Column<int>(type: "integer", nullable: false),
                    Speed = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Heatsink = table.Column<int>(type: "integer", nullable: true),
                    Wattage = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storage", x => x.ComponentId);
                    table.ForeignKey(
                        name: "FK_Storage_PcComponent_ComponentId",
                        column: x => x.ComponentId,
                        principalTable: "PcComponent",
                        principalColumn: "ComponentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Storage_StorageFormFactor_FormFactorId",
                        column: x => x.FormFactorId,
                        principalTable: "StorageFormFactor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Build",
                columns: table => new
                {
                    BuildId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    CalculatedPrice = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Build", x => x.BuildId);
                    table.ForeignKey(
                        name: "FK_Build_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Shippingaddress = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: false),
                    Warranty = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Order_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PortsBridge",
                columns: table => new
                {
                    MotherboardId = table.Column<Guid>(type: "uuid", nullable: false),
                    PortId = table.Column<Guid>(type: "uuid", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortsBridge", x => new { x.MotherboardId, x.PortId });
                    table.ForeignKey(
                        name: "FK_PortsBridge_Motherboard_MotherboardId",
                        column: x => x.MotherboardId,
                        principalTable: "Motherboard",
                        principalColumn: "ComponentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PortsBridge_Port_PortId",
                        column: x => x.PortId,
                        principalTable: "Port",
                        principalColumn: "PortId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BuildComponentBridge",
                columns: table => new
                {
                    BuildId = table.Column<Guid>(type: "uuid", nullable: false),
                    ComponentId = table.Column<Guid>(type: "uuid", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildComponentBridge", x => new { x.BuildId, x.ComponentId });
                    table.ForeignKey(
                        name: "FK_BuildComponentBridge_Build_BuildId",
                        column: x => x.BuildId,
                        principalTable: "Build",
                        principalColumn: "BuildId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BuildComponentBridge_PcComponent_ComponentId",
                        column: x => x.ComponentId,
                        principalTable: "PcComponent",
                        principalColumn: "ComponentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomDesign",
                columns: table => new
                {
                    CustomDesignId = table.Column<Guid>(type: "uuid", nullable: false),
                    CaseComponentId = table.Column<Guid>(type: "uuid", nullable: false),
                    StickerId = table.Column<Guid>(type: "uuid", nullable: false),
                    BuildId = table.Column<Guid>(type: "uuid", nullable: false),
                    SideLocation = table.Column<string>(type: "text", nullable: false),
                    XAxis = table.Column<int>(type: "integer", nullable: false),
                    YAxis = table.Column<int>(type: "integer", nullable: false),
                    RotationDegree = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomDesign", x => x.CustomDesignId);
                    table.ForeignKey(
                        name: "FK_CustomDesign_Build_BuildId",
                        column: x => x.BuildId,
                        principalTable: "Build",
                        principalColumn: "BuildId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomDesign_Case_CaseComponentId",
                        column: x => x.CaseComponentId,
                        principalTable: "Case",
                        principalColumn: "ComponentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomDesign_Sticker_StickerId",
                        column: x => x.StickerId,
                        principalTable: "Sticker",
                        principalColumn: "ComponentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BuildBridge",
                columns: table => new
                {
                    BuildId = table.Column<Guid>(type: "uuid", nullable: false),
                    OrderId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildBridge", x => new { x.BuildId, x.OrderId });
                    table.ForeignKey(
                        name: "FK_BuildBridge_Build_BuildId",
                        column: x => x.BuildId,
                        principalTable: "Build",
                        principalColumn: "BuildId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BuildBridge_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Build_UserId",
                table: "Build",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildBridge_OrderId",
                table: "BuildBridge",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildComponentBridge_ComponentId",
                table: "BuildComponentBridge",
                column: "ComponentId");

            migrationBuilder.CreateIndex(
                name: "IX_Case_FormFactorId",
                table: "Case",
                column: "FormFactorId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomDesign_BuildId",
                table: "CustomDesign",
                column: "BuildId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomDesign_CaseComponentId",
                table: "CustomDesign",
                column: "CaseComponentId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomDesign_StickerId",
                table: "CustomDesign",
                column: "StickerId");

            migrationBuilder.CreateIndex(
                name: "IX_Motherboard_FormFactorId",
                table: "Motherboard",
                column: "FormFactorId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserId",
                table: "Order",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PortsBridge_PortId",
                table: "PortsBridge",
                column: "PortId");

            migrationBuilder.CreateIndex(
                name: "IX_Storage_FormFactorId",
                table: "Storage",
                column: "FormFactorId");

            migrationBuilder.CreateIndex(
                name: "IX_User_EmailAddress",
                table: "User",
                column: "EmailAddress",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuildBridge");

            migrationBuilder.DropTable(
                name: "BuildComponentBridge");

            migrationBuilder.DropTable(
                name: "Cooling");

            migrationBuilder.DropTable(
                name: "CPU");

            migrationBuilder.DropTable(
                name: "CustomDesign");

            migrationBuilder.DropTable(
                name: "GPU");

            migrationBuilder.DropTable(
                name: "NetworkCard");

            migrationBuilder.DropTable(
                name: "PortsBridge");

            migrationBuilder.DropTable(
                name: "PSU");

            migrationBuilder.DropTable(
                name: "RAM");

            migrationBuilder.DropTable(
                name: "Storage");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Build");

            migrationBuilder.DropTable(
                name: "Case");

            migrationBuilder.DropTable(
                name: "Sticker");

            migrationBuilder.DropTable(
                name: "Motherboard");

            migrationBuilder.DropTable(
                name: "Port");

            migrationBuilder.DropTable(
                name: "StorageFormFactor");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "BoardFormFactor");

            migrationBuilder.DropTable(
                name: "PcComponent");
        }
    }
}
