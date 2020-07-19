using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_024a-11fade95")]
        public void Method_0019_024a()
        {
            ii(0x19_024a, 2);  mov(sp, bp);                            /* mov sp, bp */
            ii(0x19_024c, 5);  mov(esi, memd[ds, 0xa42]);              /* mov esi, [0xa42] */
            ii(0x19_0251, 1);  pop(dx);                                /* pop dx */
            ii(0x19_0252, 3);  push(memw[ds, si + 4]);                 /* push word [si+0x4] */
            ii(0x19_0255, 4);  push(memd[ds, si + 32]);                /* push dword [si+0x20] */
            ii(0x19_0259, 3);  push(memw[ds, si + 58]);                /* push word [si+0x3a] */
            ii(0x19_025c, 3);  push(memw[ds, si + 6]);                 /* push word [si+0x6] */
            ii(0x19_025f, 1);  pop(es);                                /* pop es */
            ii(0x19_0260, 3);  push(memw[ds, si + 8]);                 /* push word [si+0x8] */
            ii(0x19_0263, 2);  pop(fs);                                /* pop fs */
            ii(0x19_0265, 3);  push(memw[ds, si + 10]);                /* push word [si+0xa] */
            ii(0x19_0268, 2);  pop(gs);                                /* pop gs */
            ii(0x19_026a, 4);  mov(eax, memd[ds, si + 40]);            /* mov eax, [si+0x28] */
            ii(0x19_026e, 4);  mov(ebx, memd[ds, si + 28]);            /* mov ebx, [si+0x1c] */
            ii(0x19_0272, 4);  mov(ecx, memd[ds, si + 36]);            /* mov ecx, [si+0x24] */
            ii(0x19_0276, 4);  mov(ebp, memd[ds, si + 20]);            /* mov ebp, [si+0x14] */
            ii(0x19_027a, 4);  mov(edi, memd[ds, si + 12]);            /* mov edi, [si+0xc] */
            ii(0x19_027e, 4);  mov(esi, memd[ds, si + 16]);            /* mov esi, [si+0x10] */
            ii(0x19_0282, 2);  test(dx, dx);                           /* test dx, dx */
            ii(0x19_0284, 4);  movzx(edx, sp);                         /* movzx edx, sp */
            ii(0x19_0288, 2);  if(jz(0x19_0294, 0xa)) goto l_0x19_0294;/* jz 0x294 */
            ii(0x19_028a, 5);  pop(memw_a32[ss, edx + 16]);            /* pop word [ss:edx+0x10] */
            ii(0x19_028f, 2);  pop(edx);                               /* pop edx */
            ii(0x19_0291, 1);  pop(ds);                                /* pop ds */
            ii(0x19_0292, 2);  iretd(); return;                        /* iretd */
        l_0x19_0294:
            ii(0x19_0294, 5);  pop(memw_a32[ss, edx + 12]);            /* pop word [ss:edx+0xc] */
            ii(0x19_0299, 2);  pop(edx);                               /* pop edx */
            ii(0x19_029b, 1);  pop(ds);                                /* pop ds */
            ii(0x19_029c, 1);  iretw();                                /* iretw */
        }
    }
}
