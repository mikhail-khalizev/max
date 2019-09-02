using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_4473-3f88cfaf")]
        public void Method_100b_4473()
        {
            ii(0x100b_4473, 5); push(0x20);                             /* push 0x20 */
            ii(0x100b_4478, 5); call(Definitions.sys_check_available_stack_size, 0xb_18d5); /* call 0x10165d52 */
            ii(0x100b_447d, 1); push(ebx);                              /* push ebx */
            ii(0x100b_447e, 1); push(ecx);                              /* push ecx */
            ii(0x100b_447f, 1); push(edx);                              /* push edx */
            ii(0x100b_4480, 1); push(esi);                              /* push esi */
            ii(0x100b_4481, 1); push(edi);                              /* push edi */
            ii(0x100b_4482, 1); push(ebp);                              /* push ebp */
            ii(0x100b_4483, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_4485, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x100b_448b, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100b_448e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_4490, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_4493, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_4496, 5); call(0x1013_ad71, 0x8_68d6);            /* call 0x1013ad71 */
            ii(0x100b_449b, 2); test(al, al);                           /* test al, al */
            ii(0x100b_449d, 2); if(jz(0x100b_44bb, 0x1c)) goto l_0x100b_44bb; /* jz 0x100b44bb */
            ii(0x100b_449f, 5); call(0x1008_ac50, -0x2_9854);           /* call 0x1008ac50 */
            ii(0x100b_44a4, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_44a6, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100b_44a8, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100b_44ab, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_44ae, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_44b1, 5); call(0x1007_6574, -0x3_df42);           /* call 0x10076574 */
            ii(0x100b_44b6, 5); call(0x1015_2962, 0x9_e4a7);            /* call 0x10152962 */
        l_0x100b_44bb:
            ii(0x100b_44bb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_44bd, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_44c0, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_44c3, 5); call(0x1013_ad71, 0x8_68a9);            /* call 0x1013ad71 */
            ii(0x100b_44c8, 2); test(al, al);                           /* test al, al */
            ii(0x100b_44ca, 2); if(jz(0x100b_44e8, 0x1c)) goto l_0x100b_44e8; /* jz 0x100b44e8 */
            ii(0x100b_44cc, 5); call(0x1008_ac50, -0x2_9881);           /* call 0x1008ac50 */
            ii(0x100b_44d1, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_44d3, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100b_44d5, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100b_44d8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_44db, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_44de, 5); call(0x1007_6574, -0x3_df6f);           /* call 0x10076574 */
            ii(0x100b_44e3, 5); call(0x1015_2962, 0x9_e47a);            /* call 0x10152962 */
        l_0x100b_44e8:
            ii(0x100b_44e8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_44ea, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_44ed, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_44f0, 5); call(0x1007_6630, -0x3_dec5);           /* call 0x10076630 */
            ii(0x100b_44f5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_44f7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_44fa, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_44fd, 5); call(0x1007_6630, -0x3_ded2);           /* call 0x10076630 */
            ii(0x100b_4502, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_4504, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_4507, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100b_450a, 5); call(0x1008_afe4, -0x2_952b);           /* call 0x1008afe4 */
            ii(0x100b_450f, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100b_4512, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_4517, 5); call(0x100a_5e27, -0xe6f5);             /* call 0x100a5e27 */
            ii(0x100b_451c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_451e, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_451f, 1); pop(edi);                               /* pop edi */
            ii(0x100b_4520, 1); pop(esi);                               /* pop esi */
            ii(0x100b_4521, 1); pop(edx);                               /* pop edx */
            ii(0x100b_4522, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_4523, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_4524, 1); ret();                                  /* ret */
        }
    }
}
