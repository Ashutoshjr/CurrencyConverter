using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Server
    {

        private readonly IConverter _converter;   

        public Server(IConverter converter)
        {
            _converter = converter;

        }


        public string GetWorsBeforeComma(int beforeComma)
        {
           return _converter.NumberToDollar(beforeComma);
        }

        public string GetWordsAfterComma(int afterComma)
        {
            return _converter.NumberToCent(afterComma);
        }

    }
}
