using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_798c-11200c8a")]
        public void /* sys */ Method_1018_798c()
        {
            ii(0x1018_798c, 1);  push(edx);                            /* push edx */
            ii(0x1018_798d, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1018_798f, 2);  mov(eax, cs);                         /* mov eax, cs */
            ii(0x1018_7991, 4);  mov(memw[ds, edx + 2], ax);           /* mov [edx+0x2], ax */
            ii(0x1018_7995, 2);  mov(eax, ds);                         /* mov eax, ds */
            ii(0x1018_7997, 4);  mov(memw[ds, edx + 6], ax);           /* mov [edx+0x6], ax */
            ii(0x1018_799b, 2);  mov(eax, es);                         /* mov eax, es */
            ii(0x1018_799d, 3);  mov(memw[ds, edx], ax);               /* mov [edx], ax */
            ii(0x1018_79a0, 2);  mov(eax, ss);                         /* mov eax, ss */
            ii(0x1018_79a2, 4);  mov(memw[ds, edx + 4], ax);           /* mov [edx+0x4], ax */
            ii(0x1018_79a6, 2);  mov(eax, fs);                         /* mov eax, fs */
            ii(0x1018_79a8, 4);  mov(memw[ds, edx + 8], ax);           /* mov [edx+0x8], ax */
            ii(0x1018_79ac, 2);  mov(eax, gs);                         /* mov eax, gs */
            ii(0x1018_79ae, 4);  mov(memw[ds, edx + 10], ax);          /* mov [edx+0xa], ax */
            ii(0x1018_79b2, 1);  pop(edx);                             /* pop edx */
            ii(0x1018_79b3, 1);  ret();                                /* ret */
        }
    }
}
