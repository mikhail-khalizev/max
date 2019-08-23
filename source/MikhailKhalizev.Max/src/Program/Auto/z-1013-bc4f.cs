using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_bc4f-443338ad")]
        public void Method_1013_bc4f()
        {
            ii(0x1013_bc4f, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1013_bc54, 5); calld(Definitions.sys_check_available_stack_size, 0x2_a0f9); /* call 0x10165d52 */
            ii(0x1013_bc59, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_bc5a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_bc5b, 1); pushd(edx);                             /* push edx */
            ii(0x1013_bc5c, 1); pushd(esi);                             /* push esi */
            ii(0x1013_bc5d, 1); pushd(edi);                             /* push edi */
            ii(0x1013_bc5e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_bc5f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_bc61, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_bc67, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_bc6a, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x1013_bc6f, 3); lea(edx, ebp - 0x8);                    /* lea edx, [ebp-0x8] */
            ii(0x1013_bc72, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_bc75, 5); calld(0x1013_ba86, -0x1f4);             /* call 0x1013ba86 */
            ii(0x1013_bc7a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_bc7d, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_bc80, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_bc83, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_bc85, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_bc86, 1); popd(edi);                              /* pop edi */
            ii(0x1013_bc87, 1); popd(esi);                              /* pop esi */
            ii(0x1013_bc88, 1); popd(edx);                              /* pop edx */
            ii(0x1013_bc89, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_bc8a, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_bc8b, 1); retd();                                 /* ret */
        }
    }
}
