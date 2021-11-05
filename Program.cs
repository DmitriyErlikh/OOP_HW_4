using System;

namespace OOP_HW_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Building b1 = new Building(5,5,50,1);
            b1.setNumberOfEntrances(2);
            Console.WriteLine($"№ здания: {b1.getBuildingNumber()}");
            Console.WriteLine($"Кол-во кв. в подъезде:{b1.apartmentsInEntrances()}");
            Console.WriteLine($"Кол-во кв. на этаже: {b1.apartmentsOnFloor()}");

            Building b2 = new Building(5, 5, 50, 1);
            b1.setNumberOfEntrances(1);
            Console.WriteLine($"№ здания: {b2.getBuildingNumber()}");
            Console.WriteLine($"Кол-во кв. в подъезде:{b2.apartmentsInEntrances()}");
            Console.WriteLine($"Кол-во кв. на этаже: {b2.apartmentsOnFloor()}");
            Console.ReadKey();
        }

        static int buildingNumbers = 0;
        public class Building
        {
            
            private int buildingNumber { get; set; }
            private int buildinHeight { get; set; }
            private int numberOfFloors { get; set; }
            private int numberOfApartments { get; set; }
            private int numberOfEntrances { get; set; }

            public int getBuildingNumber()
            {
                return buildingNumber;
            }
            public int getBuildinHeight()
            {
                return buildinHeight;
            }
            public int getNumberOfFloors()
            {
                return numberOfFloors;
            }
            public int getNumberOfApartments()
            {
                return numberOfApartments;
            }
            public int getNumberOfEntrances()
            {
                return numberOfEntrances;
            }
            internal void setBuildinHeight(int buildinHeight)
            {
                this.buildinHeight = buildinHeight;
            }
            internal void setNumberOfFloors(int numberOfFloors)
            {
                this.numberOfFloors = numberOfFloors;
            }
            internal void setNumberOfApartments(int numberOfApartments)
            {
                this.numberOfApartments = numberOfApartments;
            }
            internal void setNumberOfEntrances(int numberOfEntrances)
            {
                this.numberOfEntrances = numberOfEntrances;
            }
            internal Building(int buildinHeight, int numberOfFloors, int numberOfApartments, int numberOfEntrances) 
            {
                this.buildingNumber = ++buildingNumbers;
                this.buildinHeight = buildinHeight;
                this.numberOfFloors = numberOfFloors;
                this.numberOfApartments = numberOfApartments;
                this.numberOfEntrances = numberOfEntrances;
            }
            public int floorHeight()
            {
                if (buildinHeight > 0 && numberOfFloors > 0)
                {
                    return buildinHeight / numberOfFloors;
                }
                return 0;
            }
            public int apartmentsInEntrances()
            {
                if (numberOfApartments > 0 && numberOfEntrances > 0)
                {
                    return numberOfApartments / numberOfEntrances;
                }
                return 0;
            }
            public int apartmentsOnFloor()
            {
                if (numberOfApartments > 0 && numberOfFloors > 0)
                {
                    return numberOfApartments / numberOfFloors;
                }
                return 0;
            }
        }
    }
}
