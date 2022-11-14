using OOps.InventoryDataManagement;
using OOps.InventoryManagement;

namespace OOps
{
    internal class Program
    {
        //static string inventoryFilePath = @"C:\Bridgelabz\Assignments\Day11-12\OOPs\OOps\Inventory.json";
        static string inventoryDataFilePath = @"C:\Bridgelabz\Assignments\Day11-12\OOPs\OOps\InventoryDataManagement\InventoryData.json";


        static void Main(string[] args)
        {
            //InventoryDetailsManagement inventoryDetailsManagement = new InventoryDetailsManagement();
            //inventoryDetailsManagement.ReadJsonFile(inventoryFilePath);

            InventoryDetailsManagementList inventoryDetailsManagementList = new InventoryDetailsManagementList();
            inventoryDetailsManagementList.ReadJsonFile(inventoryDataFilePath);
        }
    }
}