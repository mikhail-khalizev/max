using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_03a6-e2442620")]
        public void Method_0019_03a6()
        {
            ii(0x19_03a6, 2);  pushfd();                               /* pushfd */
            ii(0x19_03a8, 1);  push(ds);                               /* push ds */
            ii(0x19_03a9, 2);  push(esi);                              /* push esi */
            ii(0x19_03ab, 3);  mov(si, 0xa8);                          /* mov si, 0xa8 */
            ii(0x19_03ae, 2);  mov(ds, si);                            /* mov ds, si */
            ii(0x19_03b0, 2);  mov(ss, si);                            /* mov ss, si */
            ii(0x19_03b2, 5);  mov(esi, memd[ds, 0xa42]);              /* mov esi, [0xa42] */
            ii(0x19_03b7, 4);  pop(memd[ds, si + 16]);                 /* pop dword [si+0x10] */
            ii(0x19_03bb, 3);  pop(memw[ds, si + 4]);                  /* pop word [si+0x4] */
            ii(0x19_03be, 4);  mov(memd[ds, si + 40], eax);            /* mov [si+0x28], eax */
            ii(0x19_03c2, 4);  mov(memd[ds, si + 28], ebx);            /* mov [si+0x1c], ebx */
            ii(0x19_03c6, 4);  mov(memd[ds, si + 36], ecx);            /* mov [si+0x24], ecx */
            ii(0x19_03ca, 4);  mov(memd[ds, si + 32], edx);            /* mov [si+0x20], edx */
            ii(0x19_03ce, 4);  mov(memd[ds, si + 12], edi);            /* mov [si+0xc], edi */
            ii(0x19_03d2, 4);  mov(memd[ds, si + 20], ebp);            /* mov [si+0x14], ebp */
            ii(0x19_03d6, 3);  mov(memw[ds, si + 6], es);              /* mov [si+0x6], es */
            ii(0x19_03d9, 3);  mov(memw[ds, si + 8], fs);              /* mov [si+0x8], fs */
            ii(0x19_03dc, 3);  mov(memw[ds, si + 10], gs);             /* mov [si+0xa], gs */
            ii(0x19_03df, 2);  pop(eax);                               /* pop eax */
            ii(0x19_03e1, 3);  mov(bx, memw[ds, si + 58]);             /* mov bx, [si+0x3a] */
            ii(0x19_03e4, 3);  and(bh, 3);                             /* and bh, 0x3 */
            ii(0x19_03e7, 2);  or(ah, bh);                             /* or ah, bh */
            ii(0x19_03e9, 4);  mov(memd[ds, si + 58], eax);            /* mov [si+0x3a], eax */
            ii(0x19_03ed, 3);  xor(eax, eax);                          /* xor eax, eax */
            ii(0x19_03f0, 2);  pop(ebp);                               /* pop ebp */
            ii(0x19_03f2, 1);  leave();                                /* leave */
            ii(0x19_03f3, 1);  retf();                                 /* retf */
        }
    }
}
