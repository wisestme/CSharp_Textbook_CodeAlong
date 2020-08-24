using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalCSharp.Services
{
    class PhoneConstructor
    {
        private string _model;
        private uint _simSlots;

        public PhoneConstructor(string model, uint simSlots)
        {
            _model = model;
            _simSlots = simSlots;
        }

        public PhoneConstructor(string model)
        {
            _model = model;
            _simSlots = 2;
        }

        
    }
}
