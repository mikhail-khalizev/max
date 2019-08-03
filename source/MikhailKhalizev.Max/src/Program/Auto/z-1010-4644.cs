using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("117f9bbe-e59b-43e7-903a-82083bfbd1a9")]
        public void Method_1010_4644()
        {
            ii(0x1010_4644, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1010_4649, 5); calld(Definitions.sys_check_available_stack_size, 0x61704); /* call 0x10165d52 */
            ii(0x1010_464e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_464f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_4650, 1); pushd(esi);                             /* push esi */
            ii(0x1010_4651, 1); pushd(edi);                             /* push edi */
            ii(0x1010_4652, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_4653, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_4655, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1010_465b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_465e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1010_4661, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1010_4664, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_4667, 5); calld(0x1013_a369, 0x35cfd);            /* call 0x1013a369 */
            ii(0x1010_466c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_466e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_466f, 1); popd(edi);                              /* pop edi */
            ii(0x1010_4670, 1); popd(esi);                              /* pop esi */
            ii(0x1010_4671, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_4672, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_4673, 1); retd(); return;                         /* ret */
        }
    }
}
