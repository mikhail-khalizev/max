using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_b1ed-ab638e60")]
        public void Method_1010_b1ed()
        {
            ii(0x1010_b1ed, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1010_b1f2, 5); calld(Definitions.sys_check_available_stack_size, 0x5_ab5b); /* call 0x10165d52 */
            ii(0x1010_b1f7, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_b1f8, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_b1f9, 1); pushd(edx);                             /* push edx */
            ii(0x1010_b1fa, 1); pushd(esi);                             /* push esi */
            ii(0x1010_b1fb, 1); pushd(edi);                             /* push edi */
            ii(0x1010_b1fc, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_b1fd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_b1ff, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1010_b205, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_b208, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_b20b, 3); mov(edx, memd_a32[ds, eax + 0xd]);      /* mov edx, [eax+0xd] */
            ii(0x1010_b20e, 3); sub(edx, 0x25);                         /* sub edx, 0x25 */
            ii(0x1010_b211, 5); mov(eax, 0x50);                         /* mov eax, 0x50 */
            ii(0x1010_b216, 5); calld(0x100c_aafc, -0x4_071f);          /* call 0x100caafc */
            ii(0x1010_b21b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_b21e, 5); calld(0x1010_a564, -0xcbf);             /* call 0x1010a564 */
            ii(0x1010_b223, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_b226, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_b228, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1010_b22b, 5); calld(Definitions.sys_display_draw_0, 0x5_c254); /* call 0x10167484 */
            ii(0x1010_b230, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_b232, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_b233, 1); popd(edi);                              /* pop edi */
            ii(0x1010_b234, 1); popd(esi);                              /* pop esi */
            ii(0x1010_b235, 1); popd(edx);                              /* pop edx */
            ii(0x1010_b236, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_b237, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_b238, 1); retd();                                 /* ret */
        }
    }
}
