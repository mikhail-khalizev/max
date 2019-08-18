using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("dbf795ea-a2e7-4b71-b839-985f13167d36")]
        public void Method_1008_9b68()
        {
            ii(0x1008_9b68, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_9b6d, 5); calld(Definitions.sys_check_available_stack_size, 0xd_c1e0); /* call 0x10165d52 */
            ii(0x1008_9b72, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_9b73, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_9b74, 1); pushd(esi);                             /* push esi */
            ii(0x1008_9b75, 1); pushd(edi);                             /* push edi */
            ii(0x1008_9b76, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_9b77, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_9b79, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_9b7f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_9b82, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_9b85, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_9b88, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_9b8b, 5); calld(0x1007_6c98, -0x1_2ef8);          /* call 0x10076c98 */
            ii(0x1008_9b90, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_9b93, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_9b96, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_9b98, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_9b99, 1); popd(edi);                              /* pop edi */
            ii(0x1008_9b9a, 1); popd(esi);                              /* pop esi */
            ii(0x1008_9b9b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_9b9c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_9b9d, 1); retd(); return;                         /* ret */
        }
    }
}
