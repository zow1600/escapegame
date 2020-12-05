//using System;
//using System.Collections.Generic;
//using System.Text;
//using Excel = Microsoft.Office.Interop.Excel;




//namespace NewEscapeGame
//{
//    class LoadFile
//    {

        
//        public static List<Puzzles> GetCars(string filepath)
//        {
//            List<Puzzles> result = new List<Puzzles>();

//            foreach (string vehicle in inventory)
//            {
//                Puzzles car = new Puzzles();
//                string[] carinfo = vehicle.Split(",");

//                car.InventoryNumber = carinfo[0];
//                car.Year = Convert.ToDouble(carinfo[1]);
//                car.Make = carinfo[2];
//                car.Model = carinfo[3];
//                car.Mileage = Convert.ToDouble(carinfo[4]);
//                car.Price = Convert.ToDecimal(carinfo[5]);

//                result.Add(car);
//            }

//            return result;
//        }
//}
