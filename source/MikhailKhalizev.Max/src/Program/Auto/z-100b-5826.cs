using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b2b2d93d-401b-4d91-bf7b-23f91a6fa73c")]
        public void Method_100b_5826()
        {
            ii(0x100b_5826, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100b_582b, 5); calld(Definitions.sys_check_available_stack_size, 0xb_0522); /* call 0x10165d52 */
            ii(0x100b_5830, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_5831, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_5832, 1); pushd(edx);                             /* push edx */
            ii(0x100b_5833, 1); pushd(esi);                             /* push esi */
            ii(0x100b_5834, 1); pushd(edi);                             /* push edi */
            ii(0x100b_5835, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_5836, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_5838, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100b_583e, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_5841, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_5844, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_5847, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_584a, 5); calld(0x1007_6574, -0x3_f2db);          /* call 0x10076574 */
            ii(0x100b_584f, 5); calld(0x1015_27ed, 0x9_cf99);           /* call 0x101527ed */
            ii(0x100b_5854, 5); calld(0x1008_b0e4, -0x2_a775);          /* call 0x1008b0e4 */
            ii(0x100b_5859, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_585b, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100b_585d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_5860, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_5863, 5); calld(0x1007_65d0, -0x3_f298);          /* call 0x100765d0 */
            ii(0x100b_5868, 5); calld(0x100a_297d, -0x1_2ef0);          /* call 0x100a297d */
            ii(0x100b_586d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_586f, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_5870, 1); popd(edi);                              /* pop edi */
            ii(0x100b_5871, 1); popd(esi);                              /* pop esi */
            ii(0x100b_5872, 1); popd(edx);                              /* pop edx */
            ii(0x100b_5873, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_5874, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_5875, 1); retd(); return;                         /* ret */
        }
    }
}
