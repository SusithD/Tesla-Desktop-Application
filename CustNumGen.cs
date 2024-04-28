using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace porches
{
    class CustNumGen
    {

        private int lastCustNumber = 0;

        private string orderNumberFilePath = "last_Cust_number.txt";

        private void LoadLastOrderNumber()
        {
            if (File.Exists(orderNumberFilePath))
            {
                string content = File.ReadAllText(orderNumberFilePath);
                int.TryParse(content, out lastCustNumber);
            }
        }

        private void SaveLastOrderNumber()
        {
            File.WriteAllText(orderNumberFilePath, lastCustNumber.ToString());
        }

        public string GenerateOrderNumber()
        {
            lastCustNumber++; // Increment the last used order number
            string formattedNumber = lastCustNumber.ToString("0000"); // Format the number as 4-digit with leading zeros
            string orderNumber = "Cust-" + formattedNumber; // Combine with the prefix "ORD-"
            SaveLastOrderNumber(); // Save the last used order number to the file
            return orderNumber;
        }

        public CustNumGen()
        {
            LoadLastOrderNumber();
        }
    }
}
