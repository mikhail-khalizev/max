using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3c91e1a0-a1b7-4926-a34a-69e388b90648")]
        public void Method_0014_e819()
        {
            ii(0x14_e819, 4); mov(bp, memw_a16[ds, 0x996]);             /* mov bp, [0x996] */
            ii(0x14_e81d, 3); mov(ds, memw_a16[ss, bp + 0x6]);          /* mov ds, [bp+0x6] */
            ii(0x14_e820, 4); mov(edi, memd_a16[ss, bp + 0x8]);         /* mov edi, [bp+0x8] */
            ii(0x14_e824, 4); mov(memw_a32[ds, edi + 0x20], ax);        /* mov [edi+0x20], ax */
            ii(0x14_e828, 4); popw(memw_a32[ds, edi + 0x24]);           /* pop word [edi+0x24] */
            ii(0x14_e82c, 4); popw(memw_a32[ds, edi + 0x22]);           /* pop word [edi+0x22] */
            ii(0x14_e830, 4); popd(memd_a32[ds, edi]);                  /* pop dword [edi] */
            ii(0x14_e834, 5); popd(memd_a32[ds, edi + 0x4]);            /* pop dword [edi+0x4] */
            ii(0x14_e839, 5); popd(memd_a32[ds, edi + 0x8]);            /* pop dword [edi+0x8] */
            ii(0x14_e83e, 4); add(esp, 0x4);                            /* add esp, 0x4 */
            ii(0x14_e842, 5); popd(memd_a32[ds, edi + 0x10]);           /* pop dword [edi+0x10] */
            ii(0x14_e847, 5); popd(memd_a32[ds, edi + 0x14]);           /* pop dword [edi+0x14] */
            ii(0x14_e84c, 5); popd(memd_a32[ds, edi + 0x18]);           /* pop dword [edi+0x18] */
            ii(0x14_e851, 5); popd(memd_a32[ds, edi + 0x1c]);           /* pop dword [edi+0x1c] */
            ii(0x14_e856, 5); popw(memw_a16[es, 0x996]);                /* pop word [es:0x996] */
            ii(0x14_e85b, 4); mov(eax, memd_a16[ss, bp + 0xc]);         /* mov eax, [bp+0xc] */
            ii(0x14_e85f, 1); popw(ss);                                 /* pop ss */
            ii(0x14_e860, 2); xchg(esp, eax);                           /* xchg esp, eax */
            ii(0x14_e862, 3); mov(ebp, esp);                            /* mov ebp, esp */
            ii(0x14_e865, 3); if(jmpw_func(0x14_e067, -0x801)) return;  /* jmp 0xe067 */
        }
    }
}
