using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager
{
    public enum ErrorCodes
    {
        NoAddress,
        NoBuilding,
    }

    [Serializable]
    class AddressException : Exception
    {
        public ErrorCodes Code { get; }

        public AddressException(ErrorCodes code)
        {
            Code = code;
        }
    }
}
