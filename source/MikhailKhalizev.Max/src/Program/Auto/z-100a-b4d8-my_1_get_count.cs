using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("78c679eb-94ff-4673-bddc-751addde5fd3")]
        public void my_1_get_count()
        {
            ii(0x100a_b4d8, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_b4dd, 5); calld(Definitions.sys_check_available_stack_size, 0xb_a870); /* call 0x10165d52 */
            ii(0x100a_b4e2, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_b4e3, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_b4e4, 1); pushd(edx);                             /* push edx */
            ii(0x100a_b4e5, 1); pushd(esi);                             /* push esi */
            ii(0x100a_b4e6, 1); pushd(edi);                             /* push edi */
            ii(0x100a_b4e7, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_b4e8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_b4ea, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_b4f0, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_b4f3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_b4f6, 4); mov(ax, memw_a32[ds, eax + 0x4]);       /* mov ax, [eax+0x4] */
            ii(0x100a_b4fa, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_b4fd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_b500, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_b502, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_b503, 1); popd(edi);                              /* pop edi */
            ii(0x100a_b504, 1); popd(esi);                              /* pop esi */
            ii(0x100a_b505, 1); popd(edx);                              /* pop edx */
            ii(0x100a_b506, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_b507, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_b508, 1); retd(); return;                         /* ret */
        }
    }
}
