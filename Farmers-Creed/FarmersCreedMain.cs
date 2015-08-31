namespace FarmersCreed
{
    using System;
    using FarmersCreed.Simulator;

    class FarmersCreedMain
    {
        static void Main()
        {
            ExtendedFarmSimulator simulator = new ExtendedFarmSimulator();
            simulator.Run();
        }
    }
}
