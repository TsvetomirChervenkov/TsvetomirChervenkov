using System;
using System.Collections.Generic;

namespace T07.Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            HashSet<string> parkingLot = new HashSet<string>();
            while((input = Console.ReadLine()) != "END")
            {
                string[] inputData = input.Split(", ");
                string direction = inputData[0];
                string licensePlateNumber = inputData[1];
                if (direction == "IN")
                {
                    parkingLot.Add(licensePlateNumber);
                }
                if (direction == "OUT")
                {
                    if (parkingLot.Contains(licensePlateNumber))                    
                        parkingLot.Remove(licensePlateNumber);                                     
                }
            }
            if (parkingLot.Count == 0)
                Console.WriteLine($"Parking Lot is Empty");
            foreach (var item in parkingLot)           
                Console.WriteLine(item);
        }
    }
}
