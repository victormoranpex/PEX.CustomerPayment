using HelperKit.Mvc;
using System;

namespace PEX.CustomerPayment.Presentation.Controllers
{
    public class BaseController : HelperController
    {
        public override void InvalidateContext()
        {
            throw new NotImplementedException();
        }
    }
}