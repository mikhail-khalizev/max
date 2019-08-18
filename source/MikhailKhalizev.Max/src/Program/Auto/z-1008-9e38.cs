using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_9e38-730b13d7")]
        public void Method_1008_9e38()
        {
            ii(0x1008_9e38, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_9e3d, 5); calld(Definitions.sys_check_available_stack_size, 0xd_bf10); /* call 0x10165d52 */
            ii(0x1008_9e42, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_9e43, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_9e44, 1); pushd(esi);                             /* push esi */
            ii(0x1008_9e45, 1); pushd(edi);                             /* push edi */
            ii(0x1008_9e46, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_9e47, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_9e49, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_9e4f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_9e52, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_9e55, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_9e58, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_9e5b, 5); calld(0x1013_ac7d, 0xb_0e1d);           /* call 0x1013ac7d */
            ii(0x1008_9e60, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_9e63, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_9e66, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_9e68, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_9e69, 1); popd(edi);                              /* pop edi */
            ii(0x1008_9e6a, 1); popd(esi);                              /* pop esi */
            ii(0x1008_9e6b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_9e6c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_9e6d, 1); retd(); return;                         /* ret */
        }
    }
}
