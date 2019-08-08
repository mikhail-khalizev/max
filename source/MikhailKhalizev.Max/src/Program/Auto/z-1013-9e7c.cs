using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7c2f105e-1f96-4981-ad20-159e3f2972e5")]
        public void Method_1013_9e7c()
        {
            ii(0x1013_9e7c, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1013_9e81, 5); calld(Definitions.sys_check_available_stack_size, 0x2_becc); /* call 0x10165d52 */
            ii(0x1013_9e86, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_9e87, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_9e88, 1); pushd(esi);                             /* push esi */
            ii(0x1013_9e89, 1); pushd(edi);                             /* push edi */
            ii(0x1013_9e8a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_9e8b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_9e8d, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1013_9e93, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_9e96, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_9e99, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1013_9e9c, 3); add(edx, 0xe);                          /* add edx, 0xe */
            ii(0x1013_9e9f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_9ea2, 5); calld(0x100e_06dc, -0x5_97cb);          /* call 0x100e06dc */
            ii(0x1013_9ea7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_9eaa, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_9eac, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_9ead, 1); popd(edi);                              /* pop edi */
            ii(0x1013_9eae, 1); popd(esi);                              /* pop esi */
            ii(0x1013_9eaf, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_9eb0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_9eb1, 1); retd(); return;                         /* ret */
        }
    }
}
