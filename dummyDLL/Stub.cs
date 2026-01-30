using System;

namespace Il2CppScheduleOne.Vehicles
{
    public class LandVehicle { }
}

namespace Il2CppScheduleOne.PlayerScripts
{
    public class PlayerMovement
    {
        // Fix: We give it a dummy body so the compiler stops complaining.
        // The mod only cares that "get_CurrentVehicle" exists as a method name.
        public Il2CppScheduleOne.Vehicles.LandVehicle CurrentVehicle 
        { 
            get { return null; } 
        }
    }
}