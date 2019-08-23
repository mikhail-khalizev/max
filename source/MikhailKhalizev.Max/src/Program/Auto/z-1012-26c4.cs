using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_26c4-fdc73460")]
        public void Method_1012_26c4()
        {
            ii(0x1012_26c4, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1012_26c9, 5); calld(Definitions.sys_check_available_stack_size, 0x4_3684); /* call 0x10165d52 */
            ii(0x1012_26ce, 1); pushd(esi);                             /* push esi */
            ii(0x1012_26cf, 1); pushd(edi);                             /* push edi */
            ii(0x1012_26d0, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_26d1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_26d3, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1012_26d9, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1012_26dc, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x1012_26df, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1012_26e2, 3); mov(memd_a32[ss, ebp - 0xc], ecx);      /* mov [ebp-0xc], ecx */
            ii(0x1012_26e5, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x1012_26e9, 4); movsx(edx, memb_a32[ss, ebp - 0x4]);    /* movsx edx, byte [ebp-0x4] */
            ii(0x1012_26ed, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1012_26f2, 5); calld(0x1013_d195, 0x1_aa9e);           /* call 0x1013d195 */
            ii(0x1012_26f7, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1012_26fb, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1012_26ff, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_2702, 6); mov(eax, memd_a32[ds, eax + 0x101b_b05e]); /* mov eax, [eax+0x101bb05e] */
            ii(0x1012_2708, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x1012_270b, 5); calld(0x100c_aafc, -0x5_7c14);          /* call 0x100caafc */
            ii(0x1012_2710, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_2712, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_2713, 1); popd(edi);                              /* pop edi */
            ii(0x1012_2714, 1); popd(esi);                              /* pop esi */
            ii(0x1012_2715, 1); retd();                                 /* ret */
        }
    }
}
