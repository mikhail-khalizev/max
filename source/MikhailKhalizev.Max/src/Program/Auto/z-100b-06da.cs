using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_06da-14fb5ab6")]
        public void Method_100b_06da()
        {
            ii(0x100b_06da, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100b_06df, 5); calld(Definitions.sys_check_available_stack_size, 0xb_566e); /* call 0x10165d52 */
            ii(0x100b_06e4, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_06e5, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_06e6, 1); pushd(edx);                             /* push edx */
            ii(0x100b_06e7, 1); pushd(esi);                             /* push esi */
            ii(0x100b_06e8, 1); pushd(edi);                             /* push edi */
            ii(0x100b_06e9, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_06ea, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_06ec, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100b_06f2, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_06f5, 5); calld(0x1008_ac50, -0x2_5aaa);          /* call 0x1008ac50 */
            ii(0x100b_06fa, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_06fc, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100b_06fe, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_0701, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_0704, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_0707, 5); calld(0x1007_6574, -0x3_a198);          /* call 0x10076574 */
            ii(0x100b_070c, 5); calld(0x1015_2962, 0xa_2251);           /* call 0x10152962 */
            ii(0x100b_0711, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_0713, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_0716, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_0719, 5); calld(0x1007_6630, -0x3_a0ee);          /* call 0x10076630 */
            ii(0x100b_071e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_0720, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_0723, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_0726, 5); calld(0x100b_7cfc, 0x75d1);             /* call 0x100b7cfc */
            ii(0x100b_072b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_072d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_0730, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100b_0733, 5); calld(0x1008_afe4, -0x2_5754);          /* call 0x1008afe4 */
            ii(0x100b_0738, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_073b, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_0740, 5); calld(0x100a_5e27, -0xa91e);            /* call 0x100a5e27 */
            ii(0x100b_0745, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_0747, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_0748, 1); popd(edi);                              /* pop edi */
            ii(0x100b_0749, 1); popd(esi);                              /* pop esi */
            ii(0x100b_074a, 1); popd(edx);                              /* pop edx */
            ii(0x100b_074b, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_074c, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_074d, 1); retd(); return;                         /* ret */
        }
    }
}
