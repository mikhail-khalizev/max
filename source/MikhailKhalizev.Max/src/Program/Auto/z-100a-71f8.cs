using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_71f8-45d39adb")]
        public void Method_100a_71f8()
        {
            ii(0x100a_71f8, 5); push(0x24);                             /* push 0x24 */
            ii(0x100a_71fd, 5); call(Definitions.sys_check_available_stack_size, 0xb_eb50); /* call 0x10165d52 */
            ii(0x100a_7202, 1); push(ebx);                              /* push ebx */
            ii(0x100a_7203, 1); push(ecx);                              /* push ecx */
            ii(0x100a_7204, 1); push(edx);                              /* push edx */
            ii(0x100a_7205, 1); push(esi);                              /* push esi */
            ii(0x100a_7206, 1); push(edi);                              /* push edi */
            ii(0x100a_7207, 1); push(ebp);                              /* push ebp */
            ii(0x100a_7208, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_720a, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_7210, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_7213, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_7216, 3); add(edx, 0x1b);                         /* add edx, 0x1b */
            ii(0x100a_7219, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x100a_721c, 5); call(0x1007_6668, -0x3_0bb9);           /* call 0x10076668 */
            ii(0x100a_7221, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_7223, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_7226, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100a_7229, 5); call(0x1007_6630, -0x3_0bfe);           /* call 0x10076630 */
            ii(0x100a_722e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_7230, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_7233, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x100a_7236, 5); call(0x1007_6630, -0x3_0c0b);           /* call 0x10076630 */
            ii(0x100a_723b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_723d, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x100a_7240, 5); call(0x1013_ad11, 0x9_3acc);            /* call 0x1013ad11 */
            ii(0x100a_7245, 2); test(al, al);                           /* test al, al */
            ii(0x100a_7247, 2); if(jz(0x100a_7255, 0xc)) goto l_0x100a_7255; /* jz 0x100a7255 */
            ii(0x100a_7249, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_724b, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x100a_724e, 5); call(0x1007_5f2c, -0x3_1327);           /* call 0x10075f2c */
            ii(0x100a_7253, 2); jmp(0x100a_72a6, 0x51); goto l_0x100a_72a6; /* jmp 0x100a72a6 */
        l_0x100a_7255:
            ii(0x100a_7255, 5); call(0x1008_ac50, -0x1_c60a);           /* call 0x1008ac50 */
            ii(0x100a_725a, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100a_725c, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100a_725e, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_7261, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x100a_7264, 5); call(0x1007_6574, -0x3_0cf5);           /* call 0x10076574 */
            ii(0x100a_7269, 5); call(0x1015_2962, 0xa_b6f4);            /* call 0x10152962 */
            ii(0x100a_726e, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x100a_7271, 5); call(0x1007_6574, -0x3_0d02);           /* call 0x10076574 */
            ii(0x100a_7276, 5); call(0x1015_26ac, 0xa_b431);            /* call 0x101526ac */
            ii(0x100a_727b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_727d, 2); if(jnz(0x100a_729c, 0x1d)) goto l_0x100a_729c; /* jnz 0x100a729c */
            ii(0x100a_727f, 5); call(0x1008_a79c, -0x1_cae8);           /* call 0x1008a79c */
            ii(0x100a_7284, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100a_7286, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100a_7288, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x100a_728b, 5); call(0x1007_65d0, -0x3_0cc0);           /* call 0x100765d0 */
            ii(0x100a_7290, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_7292, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100a_7297, 5); call(0x100a_53ac, -0x1ef0);             /* call 0x100a53ac */
        l_0x100a_729c:
            ii(0x100a_729c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_729e, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x100a_72a1, 5); call(0x1007_5f2c, -0x3_137a);           /* call 0x10075f2c */
        l_0x100a_72a6:
            ii(0x100a_72a6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_72a8, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_72a9, 1); pop(edi);                               /* pop edi */
            ii(0x100a_72aa, 1); pop(esi);                               /* pop esi */
            ii(0x100a_72ab, 1); pop(edx);                               /* pop edx */
            ii(0x100a_72ac, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_72ad, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_72ae, 1); ret();                                  /* ret */
        }
    }
}
