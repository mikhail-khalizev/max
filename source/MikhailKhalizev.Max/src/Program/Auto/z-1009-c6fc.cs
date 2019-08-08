using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3174b8f8-ac42-4c5e-8540-6aa0c2418e06")]
        public void Method_1009_c6fc()
        {
            ii(0x1009_c6fc, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1009_c701, 5); calld(Definitions.sys_check_available_stack_size, 0xc_964c); /* call 0x10165d52 */
            ii(0x1009_c706, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_c707, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_c708, 1); pushd(edx);                             /* push edx */
            ii(0x1009_c709, 1); pushd(esi);                             /* push esi */
            ii(0x1009_c70a, 1); pushd(edi);                             /* push edi */
            ii(0x1009_c70b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_c70c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_c70e, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_c714, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_c717, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_c71a, 5); calld(0x1013_a0af, 0x9_d990);           /* call 0x1013a0af */
            ii(0x1009_c71f, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_c722, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1009_c725, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_c728, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_c72b, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_c72e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_c731, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_c733, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_c734, 1); popd(edi);                              /* pop edi */
            ii(0x1009_c735, 1); popd(esi);                              /* pop esi */
            ii(0x1009_c736, 1); popd(edx);                              /* pop edx */
            ii(0x1009_c737, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_c738, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_c739, 1); retd(); return;                         /* ret */
        }
    }
}
