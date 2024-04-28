using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace porches
{
    class EmpNumGen
    {
        private int lastEmpNumber = 0;

        private string EmpNumberFilePath = "last_Emp_number.txt";

        private void LoadLastEmpNumber()
        {
            if (File.Exists(EmpNumberFilePath))
            {
                string content = File.ReadAllText(EmpNumberFilePath);
                int.TryParse(content, out lastEmpNumber);
            }
        }

        private void SaveLastEmpNumber()
        {
            File.WriteAllText(EmpNumberFilePath, lastEmpNumber.ToString());
        }

        public string GenerateEmpNumber()
        {
            lastEmpNumber++; // Increment the last used order number
            string formattedNumber = lastEmpNumber.ToString("0000"); // Format the number as 4-digit with leading zeros
            string orderNumber = "EMP-" + formattedNumber; // Combine with the prefix "ORD-"
            SaveLastEmpNumber(); // Save the last used order number to the file
            return orderNumber;
        }

        public EmpNumGen()
        {
            LoadLastEmpNumber();
        }
    }
}
