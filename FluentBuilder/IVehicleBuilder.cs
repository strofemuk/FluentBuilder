﻿using System;
namespace FluentBuilderDemo.FluentBuilder
{
    public interface IVehicleBuilder
    {
        IVehicleBuilder CreateVehicle(string type);
        IVehicleBuilder NumberOfDoors(int numberOfDoors);
        IVehicleBuilder UseEngine(int numberOfCylinders, int engineSizeInCC);
        IVehicleBuilder OnFrame(string frame);
        IVehicleBuilder WithThisManyWheels(int numberOfWheels);
        Vehicle Construct();
    }
}
