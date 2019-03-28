using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace demo.Controllers
{
    public class TestController : Controller
    {
        public IActionResult DemoSync()
        {   // test/demosync
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Test t = new Test();
            t.Test01();
            t.Test02();
            t.Test03();
            sw.Stop();
            return Content($"chay het {sw.ElapsedMilliseconds}  ms");
        }

        public async Task<IActionResult> DemoAsync()
        {    // test/demoasync
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Test t = new Test();
            var x = t.Test01Async();
            var y = t.Test02Async();
            var z = t.Test03Async();
            await x;
            await y;
            await z;
            sw.Stop();
            return Content($"chay het {sw.ElapsedMilliseconds}  ms");
        }
    }
}