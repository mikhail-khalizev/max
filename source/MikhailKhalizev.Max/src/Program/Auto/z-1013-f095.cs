using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_f095-dccdf489")]
        public void Method_1013_f095()
        {
            ii(0x1013_f095, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_f09a, 5); calld(Definitions.sys_check_available_stack_size, 0x2_6cb3); /* call 0x10165d52 */
            ii(0x1013_f09f, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_f0a0, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_f0a1, 1); pushd(esi);                             /* push esi */
            ii(0x1013_f0a2, 1); pushd(edi);                             /* push edi */
            ii(0x1013_f0a3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_f0a4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_f0a6, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_f0ac, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_f0af, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_f0b2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_f0b5, 6); mov(memd_a32[ds, eax], 0);              /* mov dword [eax], 0x0 */
            ii(0x1013_f0bb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_f0be, 7); mov(memd_a32[ds, eax + 0x4], 0);        /* mov dword [eax+0x4], 0x0 */
            ii(0x1013_f0c5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_f0c8, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1013_f0cb, 3); mov(memd_a32[ds, edx + 0x8], eax);      /* mov [edx+0x8], eax */
            ii(0x1013_f0ce, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_f0d1, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_f0d4, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_f0d7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_f0d9, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_f0da, 1); popd(edi);                              /* pop edi */
            ii(0x1013_f0db, 1); popd(esi);                              /* pop esi */
            ii(0x1013_f0dc, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_f0dd, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_f0de, 1); retd();                                 /* ret */
        }
    }
}
