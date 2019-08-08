using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("07ac4d71-03a7-483a-8a33-33af8f5efa03")]
        public void Method_1008_8e4c()
        {
            ii(0x1008_8e4c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_8e51, 5); calld(Definitions.sys_check_available_stack_size, 0xd_cefc); /* call 0x10165d52 */
            ii(0x1008_8e56, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_8e57, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_8e58, 1); pushd(esi);                             /* push esi */
            ii(0x1008_8e59, 1); pushd(edi);                             /* push edi */
            ii(0x1008_8e5a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_8e5b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_8e5d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_8e63, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_8e66, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_8e69, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1008_8e6e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_8e71, 5); calld(0x1007_5e24, -0x1_3052);          /* call 0x10075e24 */
            ii(0x1008_8e76, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_8e79, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_8e7c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_8e7f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_8e82, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_8e84, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_8e85, 1); popd(edi);                              /* pop edi */
            ii(0x1008_8e86, 1); popd(esi);                              /* pop esi */
            ii(0x1008_8e87, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_8e88, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_8e89, 1); retd(); return;                         /* ret */
        }
    }
}
