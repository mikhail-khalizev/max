using System;
using System.Diagnostics;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("dccd9fea-e52d-490f-a051-cc88dcb1fac1")]
        public void Method_0014_f8e4()
        {
            Console.WriteLine("Видимо paging_fail завершился провалом."); 
            if (Debugger.Launch())
                Debugger.Break();

            ii(0x14_f8e4, 2); @int(0xfc);                               /* int 0xfc */
            ii(0x14_f8e6, 3); callw(0x14_fb9c, 0x2b3);                  /* call 0xfb9c */
            ii(0x14_f8e9, 1); pushw(cs);                                /* push cs */
            ii(0x14_f8ea, 2); @int(0xfc);                               /* int 0xfc */
            ii(0x14_f8ec, 3); callw(0x14_fb9c, 0x2ad);                  /* call 0xfb9c */
        }
    }
}