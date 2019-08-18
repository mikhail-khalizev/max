using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c81c9c88-5ae2-4e33-99e1-ea4519db330d")]
        public void Method_100c_b550()
        {
            ii(0x100c_b550, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_b555, 5); calld(Definitions.sys_check_available_stack_size, 0x9_a7f8); /* call 0x10165d52 */
            ii(0x100c_b55a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_b55b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_b55c, 1); pushd(esi);                             /* push esi */
            ii(0x100c_b55d, 1); pushd(edi);                             /* push edi */
            ii(0x100c_b55e, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_b55f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b561, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_b567, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_b56a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_b56d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100c_b570, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_b573, 5); calld(0x1013_ac7d, 0x6_f705);           /* call 0x1013ac7d */
            ii(0x100c_b578, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_b57b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_b57e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b580, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_b581, 1); popd(edi);                              /* pop edi */
            ii(0x100c_b582, 1); popd(esi);                              /* pop esi */
            ii(0x100c_b583, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_b584, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_b585, 1); retd(); return;                         /* ret */
        }
    }
}
