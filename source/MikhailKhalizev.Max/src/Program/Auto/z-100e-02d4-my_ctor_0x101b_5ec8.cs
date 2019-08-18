using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_02d4-961afb15")]
        public void my_ctor_0x101b_5ec8()
        {
            ii(0x100e_02d4, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x100e_02d9, 5); calld(Definitions.sys_check_available_stack_size, 0x8_5a74); /* call 0x10165d52 */
            ii(0x100e_02de, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_02df, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_02e0, 1); pushd(edx);                             /* push edx */
            ii(0x100e_02e1, 1); pushd(esi);                             /* push esi */
            ii(0x100e_02e2, 1); pushd(edi);                             /* push edi */
            ii(0x100e_02e3, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_02e4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_02e6, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100e_02ec, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_02ef, 5); calld(0x1008_b3ec, -0x5_4f08);          /* call 0x1008b3ec */
            ii(0x100e_02f4, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_02f7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_02fa, 5); calld(0x1008_b1e4, -0x5_511b);          /* call 0x1008b1e4 */
            ii(0x100e_02ff, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_0302, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100e_0305, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_0308, 5); calld(0x100e_0a20, 0x713);              /* call 0x100e0a20 */
            ii(0x100e_030d, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_0310, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_0313, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x100e_0316, 5); calld(0x100e_09b8, 0x69d);              /* call 0x100e09b8 */
            ii(0x100e_031b, 3); sub(eax, 0x4);                          /* sub eax, 0x4 */
            ii(0x100e_031e, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_0321, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100e_0324, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_0327, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_032a, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_032d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_0330, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_0332, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_0333, 1); popd(edi);                              /* pop edi */
            ii(0x100e_0334, 1); popd(esi);                              /* pop esi */
            ii(0x100e_0335, 1); popd(edx);                              /* pop edx */
            ii(0x100e_0336, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_0337, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_0338, 1); retd(); return;                         /* ret */
        }
    }
}
