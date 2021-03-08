using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class CatchErr
    {
        private string Empty;
        private string InValidNumber;
        private string InvalidPrice;

        public CatchErr()
        {
        }

        public CatchErr(string empty, string invalidNumber, string invalidPrice)
        {
            Empty = empty;
            InValidNumber = invalidNumber;
            InvalidPrice = invalidPrice;
        }

        public string CatchEmpty
        {
            get => Empty;
            set => Empty = value;
        }

        public string CatchInValidNumber
        {
            get => InValidNumber;
            set => InValidNumber = value;
        }

        public string CatchInvalidPrice
        {
            get => InvalidPrice;
            set => InvalidPrice = value;
        }
    }
}
