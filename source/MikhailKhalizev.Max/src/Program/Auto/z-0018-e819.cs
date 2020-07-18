using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_e819-3fca6a7a")]
        public void Method_0018_e819()
        {
            ii(0x18_e819, 4);  mov(bp, memw[ds, 0x996]);               /* mov bp, [0x996] */
            ii(0x18_e81d, 3);  mov(ds, memw[ss, bp + 6]);              /* mov ds, [bp+0x6] */
            ii(0x18_e820, 4);  mov(edi, memd[ss, bp + 8]);             /* mov edi, [bp+0x8] */
            ii(0x18_e824, 4);  mov(memw_a32[ds, edi + 32], ax);        /* mov [edi+0x20], ax */
            ii(0x18_e828, 4);  pop(memw_a32[ds, edi + 36]);            /* pop word [edi+0x24] */
            ii(0x18_e82c, 4);  pop(memw_a32[ds, edi + 34]);            /* pop word [edi+0x22] */
            ii(0x18_e830, 4);  pop(memd_a32[ds, edi]);                 /* pop dword [edi] */
            ii(0x18_e834, 5);  pop(memd_a32[ds, edi + 4]);             /* pop dword [edi+0x4] */
            ii(0x18_e839, 5);  pop(memd_a32[ds, edi + 8]);             /* pop dword [edi+0x8] */
            ii(0x18_e83e, 4);  add(esp, 4);                            /* add esp, 0x4 */
            ii(0x18_e842, 5);  pop(memd_a32[ds, edi + 16]);            /* pop dword [edi+0x10] */
            ii(0x18_e847, 5);  pop(memd_a32[ds, edi + 20]);            /* pop dword [edi+0x14] */
            ii(0x18_e84c, 5);  pop(memd_a32[ds, edi + 24]);            /* pop dword [edi+0x18] */
            ii(0x18_e851, 5);  pop(memd_a32[ds, edi + 28]);            /* pop dword [edi+0x1c] */
            ii(0x18_e856, 5);  pop(memw[es, 0x996]);                   /* pop word [es:0x996] */
            ii(0x18_e85b, 4);  mov(eax, memd[ss, bp + 12]);            /* mov eax, [bp+0xc] */
            ii(0x18_e85f, 1);  pop(ss);                                /* pop ss */
            ii(0x18_e860, 2);  xchg(esp, eax);                         /* xchg esp, eax */
            ii(0x18_e862, 3);  mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x18_e865, 3);  jmp_func(0x18_e067, -0x801);            /* jmp 0xe067 */
        }
    }
}
