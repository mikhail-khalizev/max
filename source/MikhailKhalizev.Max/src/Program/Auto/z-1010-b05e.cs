using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e7b6d653-5e8c-425d-b53f-528a5347409e")]
        public void Method_1010_b05e()
        {
            ii(0x1010_b05e, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1010_b063, 5); calld(Definitions.sys_check_available_stack_size, 0x5_acea); /* call 0x10165d52 */
            ii(0x1010_b068, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_b069, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_b06a, 1); pushd(edx);                             /* push edx */
            ii(0x1010_b06b, 1); pushd(esi);                             /* push esi */
            ii(0x1010_b06c, 1); pushd(edi);                             /* push edi */
            ii(0x1010_b06d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_b06e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_b070, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1010_b076, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_b079, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_b07c, 3); mov(edx, memd_a32[ds, eax + 0xd]);      /* mov edx, [eax+0xd] */
            ii(0x1010_b07f, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x1010_b084, 5); calld(0x100c_aafc, -0x4_058d);          /* call 0x100caafc */
            ii(0x1010_b089, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_b08c, 5); calld(0x1010_a3fc, -0xc95);             /* call 0x1010a3fc */
            ii(0x1010_b091, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_b094, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_b096, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1010_b099, 5); calld(Definitions.sys_display_draw_0, 0x5_c3e6); /* call 0x10167484 */
            ii(0x1010_b09e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_b0a0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_b0a1, 1); popd(edi);                              /* pop edi */
            ii(0x1010_b0a2, 1); popd(esi);                              /* pop esi */
            ii(0x1010_b0a3, 1); popd(edx);                              /* pop edx */
            ii(0x1010_b0a4, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_b0a5, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_b0a6, 1); retd(); return;                         /* ret */
        }
    }
}
