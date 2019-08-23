using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_29b0-c1532749")]
        public void Method_1016_29b0()
        {
            ii(0x1016_29b0, 5); push(0x24);                             /* push 0x24 */
            ii(0x1016_29b5, 5); call(Definitions.sys_check_available_stack_size, 0x3398); /* call 0x10165d52 */
            ii(0x1016_29ba, 1); push(ebx);                              /* push ebx */
            ii(0x1016_29bb, 1); push(ecx);                              /* push ecx */
            ii(0x1016_29bc, 1); push(edx);                              /* push edx */
            ii(0x1016_29bd, 1); push(esi);                              /* push esi */
            ii(0x1016_29be, 1); push(edi);                              /* push edi */
            ii(0x1016_29bf, 1); push(ebp);                              /* push ebp */
            ii(0x1016_29c0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_29c2, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1016_29c8, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1016_29cb, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_29ce, 5); call(0x1007_6338, -0xe_c69b);           /* call 0x10076338 */
            ii(0x1016_29d3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_29d5, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1016_29d8, 5); call(0x1007_64b8, -0xe_c525);           /* call 0x100764b8 */
        l_0x1016_29dd:
            ii(0x1016_29dd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_29df, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1016_29e2, 5); call(0x1013_ad71, -0x2_7c76);           /* call 0x1013ad71 */
            ii(0x1016_29e7, 2); test(al, al);                           /* test al, al */
            ii(0x1016_29e9, 2); if(jz(0x1016_2a02, 0x17)) goto l_0x1016_2a02; /* jz 0x10162a02 */
            ii(0x1016_29eb, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1016_29ee, 5); call(0x1007_636c, -0xe_c687);           /* call 0x1007636c */
            ii(0x1016_29f3, 5); call(0x1016_19cc, -0x102c);             /* call 0x101619cc */
            ii(0x1016_29f8, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1016_29fb, 5); call(0x1007_6bf8, -0xe_be08);           /* call 0x10076bf8 */
            ii(0x1016_2a00, 2); jmp(0x1016_29dd, -0x25); goto l_0x1016_29dd; /* jmp 0x101629dd */
        l_0x1016_2a02:
            ii(0x1016_2a02, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_2a04, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1016_2a07, 5); call(0x1007_5f6c, -0xe_caa0);           /* call 0x10075f6c */
            ii(0x1016_2a0c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_2a0e, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_2a0f, 1); pop(edi);                               /* pop edi */
            ii(0x1016_2a10, 1); pop(esi);                               /* pop esi */
            ii(0x1016_2a11, 1); pop(edx);                               /* pop edx */
            ii(0x1016_2a12, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_2a13, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_2a14, 1); ret();                                  /* ret */
        }
    }
}
