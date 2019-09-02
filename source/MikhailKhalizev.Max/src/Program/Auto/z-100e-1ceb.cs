using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_1ceb-c7c1ebaf")]
        public void Method_100e_1ceb()
        {
            ii(0x100e_1ceb, 5); push(0x24);                             /* push 0x24 */
            ii(0x100e_1cf0, 5); call(Definitions.sys_check_available_stack_size, 0x8_405d); /* call 0x10165d52 */
            ii(0x100e_1cf5, 1); push(ebx);                              /* push ebx */
            ii(0x100e_1cf6, 1); push(ecx);                              /* push ecx */
            ii(0x100e_1cf7, 1); push(esi);                              /* push esi */
            ii(0x100e_1cf8, 1); push(edi);                              /* push edi */
            ii(0x100e_1cf9, 1); push(ebp);                              /* push ebp */
            ii(0x100e_1cfa, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_1cfc, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_1d02, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100e_1d05, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100e_1d08, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_1d0b, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100e_1d0e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_1d10, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100e_1d13, 3); add(eax, 4);                            /* add eax, 0x4 */
            ii(0x100e_1d16, 5); call(0x1013_ad11, 0x5_8ff6);            /* call 0x1013ad11 */
            ii(0x100e_1d1b, 2); test(al, al);                           /* test al, al */
            ii(0x100e_1d1d, 2); if(jnz(0x100e_1d3a, 0x1b)) goto l_0x100e_1d3a; /* jnz 0x100e1d3a */
            ii(0x100e_1d1f, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100e_1d22, 3); add(eax, 4);                            /* add eax, 0x4 */
            ii(0x100e_1d25, 5); call(0x1007_65d0, -0x6_b75a);           /* call 0x100765d0 */
            ii(0x100e_1d2a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_1d2c, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100e_1d2f, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100e_1d31, 5); call(0x100e_2f04, 0x11ce);              /* call 0x100e2f04 */
            ii(0x100e_1d36, 2); test(al, al);                           /* test al, al */
            ii(0x100e_1d38, 2); if(jnz(0x100e_1d3c, 2)) goto l_0x100e_1d3c; /* jnz 0x100e1d3c */
        l_0x100e_1d3a:
            ii(0x100e_1d3a, 2); jmp(0x100e_1d9d, 0x61); goto l_0x100e_1d9d; /* jmp 0x100e1d9d */
        l_0x100e_1d3c:
            ii(0x100e_1d3c, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100e_1d3f, 3); add(eax, 4);                            /* add eax, 0x4 */
            ii(0x100e_1d42, 5); call(0x1007_65d0, -0x6_b777);           /* call 0x100765d0 */
            ii(0x100e_1d47, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_1d49, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100e_1d4c, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100e_1d4e, 5); call(0x100e_32c2, 0x156f);              /* call 0x100e32c2 */
            ii(0x100e_1d53, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100e_1d58, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100e_1d5b, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100e_1d5d, 5); call(0x100e_3e05, 0x20a3);              /* call 0x100e3e05 */
            ii(0x100e_1d62, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100e_1d65, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100e_1d67, 5); call(0x100e_3fc4, 0x2258);              /* call 0x100e3fc4 */
            ii(0x100e_1d6c, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100e_1d71, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100e_1d74, 5); call(0x100e_19f6, -0x383);              /* call 0x100e19f6 */
            ii(0x100e_1d79, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100e_1d7c, 5); call(0x100e_185e, -0x523);              /* call 0x100e185e */
            ii(0x100e_1d81, 5); call(0x100d_5470, -0xc916);             /* call 0x100d5470 */
            ii(0x100e_1d86, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100e_1d89, 5); mov(ebx, 0x3e3);                        /* mov ebx, 0x3e3 */
            ii(0x100e_1d8e, 5); mov(edx, 0x3e2);                        /* mov edx, 0x3e2 */
            ii(0x100e_1d93, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100e_1d98, 5); call(0x1013_daea, 0x5_bd4d);            /* call 0x1013daea */
        l_0x100e_1d9d:
            ii(0x100e_1d9d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_1d9f, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_1da0, 1); pop(edi);                               /* pop edi */
            ii(0x100e_1da1, 1); pop(esi);                               /* pop esi */
            ii(0x100e_1da2, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_1da3, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_1da4, 1); ret();                                  /* ret */
        }
    }
}
