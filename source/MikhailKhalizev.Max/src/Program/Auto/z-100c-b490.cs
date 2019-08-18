using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f1a78dac-bab1-43bf-99e2-c2862b382587")]
        public void Method_100c_b490()
        {
            ii(0x100c_b490, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_b495, 5); calld(Definitions.sys_check_available_stack_size, 0x9_a8b8); /* call 0x10165d52 */
            ii(0x100c_b49a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_b49b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_b49c, 1); pushd(edx);                             /* push edx */
            ii(0x100c_b49d, 1); pushd(esi);                             /* push esi */
            ii(0x100c_b49e, 1); pushd(edi);                             /* push edi */
            ii(0x100c_b49f, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_b4a0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b4a2, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_b4a8, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_b4ab, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_b4ae, 4); mov(ax, memw_a32[ds, eax + 0x11]);      /* mov ax, [eax+0x11] */
            ii(0x100c_b4b2, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_b4b5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_b4b8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b4ba, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_b4bb, 1); popd(edi);                              /* pop edi */
            ii(0x100c_b4bc, 1); popd(esi);                              /* pop esi */
            ii(0x100c_b4bd, 1); popd(edx);                              /* pop edx */
            ii(0x100c_b4be, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_b4bf, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_b4c0, 1); retd(); return;                         /* ret */
        }
    }
}
