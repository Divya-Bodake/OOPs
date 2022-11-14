using Newtonsoft.Json;
using OOps.InventoryManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOps.InventoryDataManagement
{
    internal class InventoryDetailsManagementList
    {
        public void ReadJsonFile(string file)
        {
            var jsonData = File.ReadAllText(file);
            InventoryData inventories = JsonConvert.DeserializeObject<InventoryData>(jsonData);
            List<Inventory> RiceList = inventories.Rice;
            Display(RiceList);
            List<Inventory> PulsesList = inventories.Pulses;
            Display(RiceList);
            List<Inventory> WheatList = inventories.Wheat;
            Display(RiceList);

        }
        public void Display(List<Inventory> inventories)
        {
            foreach (var data in inventories)
            {
                Console.WriteLine(data.Name + " \n" + data.Weight + " \n" + data.Price);
            }
        }
    }
}
