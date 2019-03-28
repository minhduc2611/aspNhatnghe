using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading; // -lap-trinh-da-luong-trong-csharp 
// async, await va task 
//async --> gan await 
// method gan them chu async --> Task<string>
// void -> k trar veef g

using System.Threading.Tasks;

namespace demo.Models
{
    public class Test
    {
        public string Test01()
        {
            Thread.Sleep(3000);
            return "Test01 sync";
        }
        
        public double Test02()
        {
            Thread.Sleep(5000);
            return new Random().NextDouble();
        }
        public void Test03()
        {
            Thread.Sleep(5000);
        }

        public async Task<string> Test01Async()
        {
            await Task.Delay(3000);
            //Thread.Sleep(3000);
            return "Test01 async";
        }
        public async Task<double> Test02Async()
        {
            await Task.Delay(5000); // await luon di cung async
            return new Random().NextDouble();
        }

        public async Task Test03Async() // ham voi k con ghi gi chi can ghi tab
        {
            await Task.Delay(2000);
            
        }
    }
}
