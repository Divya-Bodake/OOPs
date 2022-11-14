using OOps.InventoryManagement;

namespace OOps
{
    internal class Program
    {
        static string inventoryFilePath = @"C:\Bridgelabz\Assignments\Day11-12\OOPs\OOps\Inventory.json";

        static void Main(string[] args)
        {
            InventoryDetailsManagement inventoryDetailsManagement = new InventoryDetailsManagement();
            inventoryDetailsManagement.ReadJsonFile(inventoryFilePath);
        }
    }
}