using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XPTO.UserInfo.Core.Impl;
using XPTO.UserInfo.Core.Interface;

namespace XPTO.UserInfo.Web.Controllers
{
    public class BaseController : Controller
    {
        public IXptoSelect xs = new XptoSelect();
        public IXptoInsert xi = new XptoInsert();
        public IXptoUpdate xu = new XptoUpdate();
        public IXptoDelete xd = new XptoDelete();
    }
}