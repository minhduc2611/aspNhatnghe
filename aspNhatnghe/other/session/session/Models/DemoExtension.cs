using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace session.Models
{
    public static class DemoExtension
    {
        //them vao lop datetime method TinhKHonagcachngay()
        public static int TinhKhoangCachNgay(this DateTime d1, DateTime d2)
        {
            return Math.Abs( (d1 - d2).Days);
        }
        // them hang tongN() vao lop so nguyen int (tra ve gia tri TOng N so nguyen dau tien )

        public static int TongN(this int N) {

            int S = 0;
            for (int i = 1; i <= N; i++) {
                S += i;
            } 

            return S;
        }


    }
}
