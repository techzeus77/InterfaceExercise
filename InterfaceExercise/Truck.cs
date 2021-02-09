﻿using System;
using System.Collections.Generic;
using System.Text;


namespace InterfaceExercise
{
    public class Truck: IVehicle, ICompany
    {
        public Truck()
        {

        }

        public double EngineSize { get; set; } = 6;
        public string Make { get; set; } = "F-150";
        public string Model { get; set; } = "Mustang";
        public int SeatCount { get; set; } = 4;



        public string CompanyName { get; set; } = "Ford";
        public string Motto { get; set; } = "Built Ford Tough";
        bool HasChangedGears { get; set; }
        bool IVehicle.HasChangedGears { get; set; }

        public bool HasFourWheelDrive { get; set; } = true;

        public void Drive()
        {
            if (HasFourWheelDrive == true)
            {
                Console.WriteLine($"4 wheel drive {GetType().Name} now driving forward. . .");
            }

            else
            {
                Console.WriteLine($"{GetType().Name} now driving forward. . .");
            }

            
        }
        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing. . .");
                HasChangedGears = false;
            }

            else
            {
                Console.WriteLine("Can't reverse until we change gears");
            }


        }
        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now in park. . .");
                HasChangedGears = false;
            }

            else
            {
                Console.WriteLine("Can't park until we change gears");
            }
        }

        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }

    }
}
