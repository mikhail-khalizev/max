using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7bd45760-0a79-4a9e-8c98-e0f4b8879123")]
        public void Method_1008_9f38()
        {
            ii(0x1008_9f38, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_9f3d, 5); calld(Definitions.sys_check_available_stack_size, 0xd_be10); /* call 0x10165d52 */
            ii(0x1008_9f42, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_9f43, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_9f44, 1); pushd(edx);                             /* push edx */
            ii(0x1008_9f45, 1); pushd(esi);                             /* push esi */
            ii(0x1008_9f46, 1); pushd(edi);                             /* push edi */
            ii(0x1008_9f47, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_9f48, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_9f4a, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_9f50, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_9f53, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_9f56, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_9f59, 5); calld(0x1008_a284, 0x326);              /* call 0x1008a284 */
            ii(0x1008_9f5e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_9f61, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_9f64, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_9f66, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_9f67, 1); popd(edi);                              /* pop edi */
            ii(0x1008_9f68, 1); popd(esi);                              /* pop esi */
            ii(0x1008_9f69, 1); popd(edx);                              /* pop edx */
            ii(0x1008_9f6a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_9f6b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_9f6c, 1); retd(); return;                         /* ret */
        }
    }
}