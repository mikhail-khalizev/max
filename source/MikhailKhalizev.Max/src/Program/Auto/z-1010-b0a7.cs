using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("bd7fc41e-3d47-4505-b005-bef5fe2f7134")]
        public void Method_1010_b0a7()
        {
            ii(0x1010_b0a7, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1010_b0ac, 5); calld(Definitions.sys_check_available_stack_size, 0x5_aca1); /* call 0x10165d52 */
            ii(0x1010_b0b1, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_b0b2, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_b0b3, 1); pushd(edx);                             /* push edx */
            ii(0x1010_b0b4, 1); pushd(esi);                             /* push esi */
            ii(0x1010_b0b5, 1); pushd(edi);                             /* push edi */
            ii(0x1010_b0b6, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_b0b7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_b0b9, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1010_b0bf, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_b0c2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_b0c5, 3); mov(eax, memd_a32[ds, eax + 0xd]);      /* mov eax, [eax+0xd] */
            ii(0x1010_b0c8, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1010_b0cb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_b0ce, 4); imul(eax, memd_a32[ss, ebp - 0x8], 0x14); /* imul eax, [ebp-0x8], 0x14 */
            ii(0x1010_b0d2, 6); mov(eax, memd_a32[ds, eax + 0x101b_a5bc]); /* mov eax, [eax+0x101ba5bc] */
            ii(0x1010_b0d8, 5); calld(/* sys */ 0x1017_90ce, 0x6_dff1); /* call 0x101790ce */
            ii(0x1010_b0dd, 5); mov(ebx, 0x48);                         /* mov ebx, 0x48 */
            ii(0x1010_b0e2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_b0e4, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1010_b0e6, 5); calld(0x100c_aafc, -0x4_05ef);          /* call 0x100caafc */
            ii(0x1010_b0eb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_b0ee, 5); calld(0x1010_a4a1, -0xc52);             /* call 0x1010a4a1 */
            ii(0x1010_b0f3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_b0f6, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_b0f8, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1010_b0fb, 5); calld(Definitions.sys_display_draw_0, 0x5_c384); /* call 0x10167484 */
            ii(0x1010_b100, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_b102, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_b103, 1); popd(edi);                              /* pop edi */
            ii(0x1010_b104, 1); popd(esi);                              /* pop esi */
            ii(0x1010_b105, 1); popd(edx);                              /* pop edx */
            ii(0x1010_b106, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_b107, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_b108, 1); retd(); return;                         /* ret */
        }
    }
}
