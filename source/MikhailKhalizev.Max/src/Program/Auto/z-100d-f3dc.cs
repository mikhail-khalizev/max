using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_f3dc-3d718304")]
        public void Method_100d_f3dc()
        {
            ii(0x100d_f3dc, 5); push(0x24);                             /* push 0x24 */
            ii(0x100d_f3e1, 5); call(Definitions.sys_check_available_stack_size, 0x8_696c); /* call 0x10165d52 */
            ii(0x100d_f3e6, 1); push(ebx);                              /* push ebx */
            ii(0x100d_f3e7, 1); push(ecx);                              /* push ecx */
            ii(0x100d_f3e8, 1); push(esi);                              /* push esi */
            ii(0x100d_f3e9, 1); push(edi);                              /* push edi */
            ii(0x100d_f3ea, 1); push(ebp);                              /* push ebp */
            ii(0x100d_f3eb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_f3ed, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100d_f3f3, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100d_f3f6, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100d_f3f9, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_f3fc, 5); add(eax, 0x2f0);                        /* add eax, 0x2f0 */
            ii(0x100d_f401, 5); call(0x100e_0cf0, 0x18ea);              /* call 0x100e0cf0 */
            ii(0x100d_f406, 3); lea(ebx, memd[ss, ebp - 12]);           /* lea ebx, [ebp-0xc] */
            ii(0x100d_f409, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_f40b, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100d_f40d, 5); call(0x100e_05c4, 0x11b2);              /* call 0x100e05c4 */
            ii(0x100d_f412, 2); jmp(0x100d_f41c, 8); goto l_0x100d_f41c; /* jmp 0x100df41c */
        l_0x100d_f414:
            ii(0x100d_f414, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x100d_f417, 5); call(0x1007_6bf8, -0x6_8824);           /* call 0x10076bf8 */
        l_0x100d_f41c:
            ii(0x100d_f41c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_f41e, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x100d_f421, 5); call(0x1013_ad71, 0x5_b94b);            /* call 0x1013ad71 */
            ii(0x100d_f426, 2); test(al, al);                           /* test al, al */
            ii(0x100d_f428, 2); if(jz(0x100d_f450, 0x26)) goto l_0x100d_f450; /* jz 0x100df450 */
            ii(0x100d_f42a, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x100d_f42d, 5); call(0x100e_04b0, 0x107e);              /* call 0x100e04b0 */
            ii(0x100d_f432, 5); call(0x1007_35ac, -0x6_be8b);           /* call 0x100735ac */
            ii(0x100d_f437, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100d_f439, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100d_f43b, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x100d_f43e, 5); call(0x100e_04b0, 0x106d);              /* call 0x100e04b0 */
            ii(0x100d_f443, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_f445, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100d_f449, 5); call(0x100a_1ea3, -0x3_d5ab);           /* call 0x100a1ea3 */
            ii(0x100d_f44e, 2); jmp(0x100d_f414, -0x3c); goto l_0x100d_f414; /* jmp 0x100df414 */
        l_0x100d_f450:
            ii(0x100d_f450, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_f452, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x100d_f455, 5); call(0x100e_043c, 0xfe2);               /* call 0x100e043c */
            ii(0x100d_f45a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_f45c, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_f45d, 1); pop(edi);                               /* pop edi */
            ii(0x100d_f45e, 1); pop(esi);                               /* pop esi */
            ii(0x100d_f45f, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_f460, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_f461, 1); ret();                                  /* ret */
        }
    }
}
