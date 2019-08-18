using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("62b560b1-cabf-4da8-a9d3-a1ab07d1c56a")]
        public void Method_1010_b6b1()
        {
            ii(0x1010_b6b1, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1010_b6b6, 5); calld(Definitions.sys_check_available_stack_size, 0x5_a697); /* call 0x10165d52 */
            ii(0x1010_b6bb, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_b6bc, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_b6bd, 1); pushd(edx);                             /* push edx */
            ii(0x1010_b6be, 1); pushd(esi);                             /* push esi */
            ii(0x1010_b6bf, 1); pushd(edi);                             /* push edi */
            ii(0x1010_b6c0, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_b6c1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_b6c3, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1010_b6c9, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_b6cc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_b6cf, 3); mov(eax, memd_a32[ds, eax + 0xd]);      /* mov eax, [eax+0xd] */
            ii(0x1010_b6d2, 3); add(eax, 0x9);                          /* add eax, 0x9 */
            ii(0x1010_b6d5, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_b6d8, 4); imul(eax, memd_a32[ss, ebp - 0x8], 0x14); /* imul eax, [ebp-0x8], 0x14 */
            ii(0x1010_b6dc, 6); mov(eax, memd_a32[ds, eax + 0x101b_a5bc]); /* mov eax, [eax+0x101ba5bc] */
            ii(0x1010_b6e2, 5); calld(/* sys */ 0x1017_90ce, 0x6_d9e7); /* call 0x101790ce */
            ii(0x1010_b6e7, 5); mov(ebx, 0x47);                         /* mov ebx, 0x47 */
            ii(0x1010_b6ec, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_b6ee, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1010_b6f0, 5); calld(0x100c_aafc, -0x4_0bf9);          /* call 0x100caafc */
            ii(0x1010_b6f5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_b6f8, 5); calld(0x1010_a8f7, -0xe06);             /* call 0x1010a8f7 */
            ii(0x1010_b6fd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_b700, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_b702, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1010_b705, 5); calld(Definitions.sys_display_draw_0, 0x5_bd7a); /* call 0x10167484 */
            ii(0x1010_b70a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_b70c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_b70d, 1); popd(edi);                              /* pop edi */
            ii(0x1010_b70e, 1); popd(esi);                              /* pop esi */
            ii(0x1010_b70f, 1); popd(edx);                              /* pop edx */
            ii(0x1010_b710, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_b711, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_b712, 1); retd(); return;                         /* ret */
        }
    }
}
