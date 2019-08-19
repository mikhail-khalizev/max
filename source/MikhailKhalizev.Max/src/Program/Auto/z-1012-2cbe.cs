using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_2cbe-cc456e08")]
        public void Method_1012_2cbe()
        {
            ii(0x1012_2cbe, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_2cc1, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_2cc4, 4); cmp(ax, memw_a32[ds, edx + 0x49]);      /* cmp ax, [edx+0x49] */
            ii(0x1012_2cc8, 6); if(jged_func(0x1012_2dfe, 0x130)) return; /* jge 0x10122dfe */
            ii(0x1012_2cce, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1012_2cd2, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_2cd5, 6); mov(al, memb_a32[ds, eax + 0x101b_b061]); /* mov al, [eax+0x101bb061] */
            ii(0x1012_2cdb, 3); mov(memb_a32[ss, ebp - 0x44], al);      /* mov [ebp-0x44], al */
            ii(0x1012_2cde, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1012_2ce2, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_2ce5, 7); mov(ax, memw_a32[ds, eax + 0x101b_b076]); /* mov ax, [eax+0x101bb076] */
            ii(0x1012_2cec, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x1012_2cef, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1012_2cf3, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_2cf6, 7); mov(ax, memw_a32[ds, eax + 0x101b_b074]); /* mov ax, [eax+0x101bb074] */
            ii(0x1012_2cfd, 4); cmp(ax, memw_a32[ss, ebp - 0x48]);      /* cmp ax, [ebp-0x48] */
            ii(0x1012_2d01, 6); if(jzd_func(0x1012_2df9, 0xf2)) return; /* jz 0x10122df9 */
            ii(0x1012_2d07, 3); mov(al, memb_a32[ss, ebp - 0x44]);      /* mov al, [ebp-0x44] */
            ii(0x1012_2d0a, 3); mov(memb_a32[ss, ebp - 0x4c], al);      /* mov [ebp-0x4c], al */
            ii(0x1012_2d0d, 5); if(jmpd_func(0x1012_2ddc, 0xca)) return; /* jmp 0x10122ddc */
        }
    }
}
