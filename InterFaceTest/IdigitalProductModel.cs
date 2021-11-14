using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceTest
{
    internal interface IdigitalProductModel : IProductModel //可將iproductModel放到Idigital實體觀察program
    {
        int TotalDownloadsLeft { get; }
    }

}
