using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleApp
{
    interface ISellable
    {
        double CalculateInterest();

        string MakeSale();
    }
}
