using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProfessionalCSharp.Services
{
    public struct FurnitureStruct
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public FurnitureStruct(double length, double width)
        {
            Length = length;
            Width = width;

        }
        
        public double Diagonal()
        {
            FurnitureStruct furniture = new FurnitureStruct();
            Console.WriteLine("Enter the length of your furniture");
            string furnitureLengthString = Console.ReadLine();

            if (int.TryParse(furnitureLengthString, out int LengthOfFurniture))
            {
                furniture.Width = 10;
                furniture.Length = LengthOfFurniture;
               
            }
            else
            {
                Console.WriteLine("You have entered an invalid value");
            }
            return Math.Sqrt(furniture.Length * furniture.Length + furniture.Width * furniture.Width);
        }

        public void implementFurnitureStruct()
        {
            var furniture = new FurnitureStruct();
            var v = furniture.Diagonal();
            Console.WriteLine($"Dimension is {v}");
        }
        
    }
    
}
