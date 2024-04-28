using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace porches
{
    class OrderNumGen
    {
        private int lastOrderNumber = 0;

        private string orderNumberFilePath = "last_order_number.txt";

        private void LoadLastOrderNumber()
        {
            if (File.Exists(orderNumberFilePath))
            {
                string content = File.ReadAllText(orderNumberFilePath);
                int.TryParse(content, out lastOrderNumber);
            }
        }

        private void SaveLastOrderNumber()
        {
            File.WriteAllText(orderNumberFilePath, lastOrderNumber.ToString());
        }

        public string GenerateOrderNumber()
        {
            lastOrderNumber++; // Increment the last used order number
            string formattedNumber = lastOrderNumber.ToString("0000"); // Format the number as 4-digit with leading zeros
            string orderNumber = "ORD-" + formattedNumber; // Combine with the prefix "ORD-"
            SaveLastOrderNumber(); // Save the last used order number to the file
            return orderNumber;
        }

        public OrderNumGen()
        {
            LoadLastOrderNumber();
        }
    }
}
