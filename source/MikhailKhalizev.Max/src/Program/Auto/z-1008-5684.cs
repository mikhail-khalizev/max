using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_5684-b86b13df")]
        public void Method_1008_5684()
        {
            ii(0x1008_5684, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1008_5687, 3); inc(memd_a32[ss, ebp - 0x28]);          /* inc dword [ebp-0x28] */
            ii(0x1008_568a, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x1008_568e, 5); mov(ebx, 0x64);                         /* mov ebx, 0x64 */
            ii(0x1008_5693, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1008_5695, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1008_5698, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1008_569a, 4); movsx(edx, memw_a32[ss, ebp - 0x28]);   /* movsx edx, word [ebp-0x28] */
            ii(0x1008_569e, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1008_56a0, 6); if(jged_func(0x1008_589c, 0x1f6)) return; /* jge 0x1008589c */
            ii(0x1008_56a6, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1008_56a9, 5); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x1008_56ae, 5); and(eax, 0x7);                          /* and eax, 0x7 */
            ii(0x1008_56b3, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1008_56b6, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1008_56ba, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1008_56bd, 7); mov(ax, memw_a32[ds, eax + 0x101c_5348]); /* mov ax, [eax+0x101c5348] */
            ii(0x1008_56c4, 4); imul(eax, memd_a32[ss, ebp - 0x28]);    /* imul eax, [ebp-0x28] */
            ii(0x1008_56c8, 3); mov(edx, memd_a32[ss, ebp - 0x44]);     /* mov edx, [ebp-0x44] */
            ii(0x1008_56cb, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1008_56cd, 4); mov(memw_a32[ss, ebp - 0x48], dx);      /* mov [ebp-0x48], dx */
            ii(0x1008_56d1, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1008_56d5, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1008_56d8, 7); mov(ax, memw_a32[ds, eax + 0x101c_534a]); /* mov ax, [eax+0x101c534a] */
            ii(0x1008_56df, 4); imul(eax, memd_a32[ss, ebp - 0x28]);    /* imul eax, [ebp-0x28] */
            ii(0x1008_56e3, 3); mov(edx, memd_a32[ss, ebp - 0x42]);     /* mov edx, [ebp-0x42] */
            ii(0x1008_56e6, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1008_56e8, 4); mov(memw_a32[ss, ebp - 0x46], dx);      /* mov [ebp-0x46], dx */
            ii(0x1008_56ec, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1008_56ef, 5); add(eax, 0x3);                          /* add eax, 0x3 */
            ii(0x1008_56f4, 5); and(eax, 0x6);                          /* and eax, 0x6 */
            ii(0x1008_56f9, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1008_56fc, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1008_56ff, 5); and(eax, 0x1);                          /* and eax, 0x1 */
            ii(0x1008_5704, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1008_5707, 2); if(jmpd_func(0x1008_570d, 0x4)) return; /* jmp 0x1008570d */
        }
    }
}
