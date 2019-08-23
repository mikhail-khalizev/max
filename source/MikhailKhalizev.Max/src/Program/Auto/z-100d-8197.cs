using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_8197-f7d0bbbf")]
        public void Method_100d_8197()
        {
            ii(0x100d_8197, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100d_819c, 5); calld(Definitions.sys_check_available_stack_size, 0x8_dbb1); /* call 0x10165d52 */
            ii(0x100d_81a1, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_81a2, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_81a3, 1); pushd(esi);                             /* push esi */
            ii(0x100d_81a4, 1); pushd(edi);                             /* push edi */
            ii(0x100d_81a5, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_81a6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_81a8, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100d_81ae, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_81b1, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100d_81b4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_81b7, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100d_81ba, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_81bd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_81c0, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
            ii(0x100d_81c2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_81c5, 3); mov(edx, memd_a32[ds, eax + 0x4]);      /* mov edx, [eax+0x4] */
            ii(0x100d_81c8, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_81cb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_81ce, 3); mov(memd_a32[ds, eax + 0x4], edx);      /* mov [eax+0x4], edx */
            ii(0x100d_81d1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_81d4, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x100d_81d7, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100d_81da, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_81dd, 3); mov(edx, memd_a32[ds, eax + 0x6]);      /* mov edx, [eax+0x6] */
            ii(0x100d_81e0, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_81e3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_81e6, 2); add(ebx, edx);                          /* add ebx, edx */
            ii(0x100d_81e8, 3); mov(memd_a32[ds, eax + 0x8], ebx);      /* mov [eax+0x8], ebx */
            ii(0x100d_81eb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_81ee, 3); mov(ebx, memd_a32[ds, eax + 0x4]);      /* mov ebx, [eax+0x4] */
            ii(0x100d_81f1, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100d_81f4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_81f7, 3); mov(edx, memd_a32[ds, eax + 0x8]);      /* mov edx, [eax+0x8] */
            ii(0x100d_81fa, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_81fd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_8200, 2); add(ebx, edx);                          /* add ebx, edx */
            ii(0x100d_8202, 3); mov(memd_a32[ds, eax + 0xc], ebx);      /* mov [eax+0xc], ebx */
            ii(0x100d_8205, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_8207, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_8208, 1); popd(edi);                              /* pop edi */
            ii(0x100d_8209, 1); popd(esi);                              /* pop esi */
            ii(0x100d_820a, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_820b, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_820c, 1); retd();                                 /* ret */
        }
    }
}
