using PrescriptionCalculator.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrescriptionCalculator.Core
{
    public class MedicineCore : IMedicineCore
    {
        public string Working()
        {
            return "Working!";
        }
    }
}
