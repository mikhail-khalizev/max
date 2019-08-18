using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_5876-9e8ad5ef")]
        public void Method_100b_5876()
        {
            ii(0x100b_5876, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100b_587b, 5); calld(Definitions.sys_check_available_stack_size, 0xb_04d2); /* call 0x10165d52 */
            ii(0x100b_5880, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_5881, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_5882, 1); pushd(edx);                             /* push edx */
            ii(0x100b_5883, 1); pushd(esi);                             /* push esi */
            ii(0x100b_5884, 1); pushd(edi);                             /* push edi */
            ii(0x100b_5885, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_5886, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_5888, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100b_588e, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_5891, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_5893, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_5896, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_5899, 5); calld(0x1013_ad71, 0x8_54d3);           /* call 0x1013ad71 */
            ii(0x100b_589e, 2); test(al, al);                           /* test al, al */
            ii(0x100b_58a0, 2); if(jzd(0x100b_58b9, 0x17)) goto l_0x100b_58b9; /* jz 0x100b58b9 */
            ii(0x100b_58a2, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_58a5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_58a8, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_58ab, 5); calld(0x1007_6574, -0x3_f33c);          /* call 0x10076574 */
            ii(0x100b_58b0, 5); calld(0x1015_2a52, 0x9_d19d);           /* call 0x10152a52 */
            ii(0x100b_58b5, 2); test(al, al);                           /* test al, al */
            ii(0x100b_58b7, 2); if(jnzd(0x100b_58bb, 0x2)) goto l_0x100b_58bb; /* jnz 0x100b58bb */
        l_0x100b_58b9:
            ii(0x100b_58b9, 2); jmpd(0x100b_58f1, 0x36); goto l_0x100b_58f1; /* jmp 0x100b58f1 */
        l_0x100b_58bb:
            ii(0x100b_58bb, 5); calld(0x1008_ac50, -0x2_ac70);          /* call 0x1008ac50 */
            ii(0x100b_58c0, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_58c2, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100b_58c4, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_58c7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_58ca, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_58cd, 5); calld(0x1007_6574, -0x3_f35e);          /* call 0x10076574 */
            ii(0x100b_58d2, 5); calld(0x1015_2962, 0x9_d08b);           /* call 0x10152962 */
            ii(0x100b_58d7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_58d9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_58dc, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_58df, 5); calld(0x1007_6630, -0x3_f2b4);          /* call 0x10076630 */
            ii(0x100b_58e4, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_58e7, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_58ec, 5); calld(0x100a_5e27, -0xfaca);            /* call 0x100a5e27 */
        l_0x100b_58f1:
            ii(0x100b_58f1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_58f3, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_58f4, 1); popd(edi);                              /* pop edi */
            ii(0x100b_58f5, 1); popd(esi);                              /* pop esi */
            ii(0x100b_58f6, 1); popd(edx);                              /* pop edx */
            ii(0x100b_58f7, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_58f8, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_58f9, 1); retd(); return;                         /* ret */
        }
    }
}
