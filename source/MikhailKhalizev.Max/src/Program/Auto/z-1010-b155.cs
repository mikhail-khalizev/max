using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1e8dd57b-83cc-4b88-8553-85510899c2a8")]
        public void Method_1010_b155()
        {
            ii(0x1010_b155, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1010_b15a, 5); calld(Definitions.sys_check_available_stack_size, 0x5_abf3); /* call 0x10165d52 */
            ii(0x1010_b15f, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_b160, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_b161, 1); pushd(edx);                             /* push edx */
            ii(0x1010_b162, 1); pushd(esi);                             /* push esi */
            ii(0x1010_b163, 1); pushd(edi);                             /* push edi */
            ii(0x1010_b164, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_b165, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_b167, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1010_b16d, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_b170, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_b173, 3); mov(edx, memd_a32[ds, eax + 0xd]);      /* mov edx, [eax+0xd] */
            ii(0x1010_b176, 3); sub(edx, 0x1f);                         /* sub edx, 0x1f */
            ii(0x1010_b179, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1010_b17e, 5); calld(0x100c_aafc, -0x4_0687);          /* call 0x100caafc */
            ii(0x1010_b183, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_b186, 5); calld(0x1010_a564, -0xc27);             /* call 0x1010a564 */
            ii(0x1010_b18b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_b18e, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_b190, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1010_b193, 5); calld(Definitions.sys_display_draw_0, 0x5_c2ec); /* call 0x10167484 */
            ii(0x1010_b198, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_b19a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_b19b, 1); popd(edi);                              /* pop edi */
            ii(0x1010_b19c, 1); popd(esi);                              /* pop esi */
            ii(0x1010_b19d, 1); popd(edx);                              /* pop edx */
            ii(0x1010_b19e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_b19f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_b1a0, 1); retd(); return;                         /* ret */
        }
    }
}
