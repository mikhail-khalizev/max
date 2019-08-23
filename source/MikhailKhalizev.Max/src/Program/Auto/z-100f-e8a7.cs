using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_e8a7-2d0baf88")]
        public void Method_100f_e8a7()
        {
            ii(0x100f_e8a7, 4); cmp(memb[ss, ebp - 0x8], 0xa);          /* cmp byte [ebp-0x8], 0xa */
            ii(0x100f_e8ab, 2); if(jz(0x100f_e8d3, 0x26)) goto l_0x100f_e8d3; /* jz 0x100fe8d3 */
            ii(0x100f_e8ad, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x100f_e8b1, 5); call(0x100f_2ec7, -0xb9ef);             /* call 0x100f2ec7 */
            ii(0x100f_e8b6, 5); mov(eax, 0x47);                         /* mov eax, 0x47 */
            ii(0x100f_e8bb, 5); call(0x1007_5fdc, -0x8_88e4);           /* call 0x10075fdc */
            ii(0x100f_e8c0, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100f_e8c3, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100f_e8c7, 3); cmp(eax, 0x2d);                         /* cmp eax, 0x2d */
            ii(0x100f_e8ca, 2); if(jge(0x100f_e8d3, 0x7)) goto l_0x100f_e8d3; /* jge 0x100fe8d3 */
            ii(0x100f_e8cc, 7); mov(memd[ss, ebp - 0x10], 0x2d);        /* mov dword [ebp-0x10], 0x2d */
        l_0x100f_e8d3:
            ii(0x100f_e8d3, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x100f_e8d7, 5); call(0x100a_8a8d, -0x5_5e4f);           /* call 0x100a8a8d */
            ii(0x100f_e8dc, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_e8de, 5); call(0x100f_4fa2, -0x9941);             /* call 0x100f4fa2 */
            ii(0x100f_e8e3, 2); if(jmp_func(0x100f_e927, 0x42)) return; /* jmp 0x100fe927 */
        }
    }
}
