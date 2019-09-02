using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_1da5-888ca63")]
        public void Method_100e_1da5()
        {
            ii(0x100e_1da5, 5); push(0x24);                             /* push 0x24 */
            ii(0x100e_1daa, 5); call(Definitions.sys_check_available_stack_size, 0x8_3fa3); /* call 0x10165d52 */
            ii(0x100e_1daf, 1); push(ebx);                              /* push ebx */
            ii(0x100e_1db0, 1); push(ecx);                              /* push ecx */
            ii(0x100e_1db1, 1); push(esi);                              /* push esi */
            ii(0x100e_1db2, 1); push(edi);                              /* push edi */
            ii(0x100e_1db3, 1); push(ebp);                              /* push ebp */
            ii(0x100e_1db4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_1db6, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_1dbc, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100e_1dbf, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100e_1dc2, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_1dc5, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100e_1dc8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_1dca, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100e_1dcd, 3); add(eax, 4);                            /* add eax, 0x4 */
            ii(0x100e_1dd0, 5); call(0x1013_ad11, 0x5_8f3c);            /* call 0x1013ad11 */
            ii(0x100e_1dd5, 2); test(al, al);                           /* test al, al */
            ii(0x100e_1dd7, 2); if(jnz(0x100e_1df4, 0x1b)) goto l_0x100e_1df4; /* jnz 0x100e1df4 */
            ii(0x100e_1dd9, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100e_1ddc, 3); add(eax, 4);                            /* add eax, 0x4 */
            ii(0x100e_1ddf, 5); call(0x1007_65d0, -0x6_b814);           /* call 0x100765d0 */
            ii(0x100e_1de4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_1de6, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100e_1de9, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100e_1deb, 5); call(0x100e_2f92, 0x11a2);              /* call 0x100e2f92 */
            ii(0x100e_1df0, 2); test(al, al);                           /* test al, al */
            ii(0x100e_1df2, 2); if(jnz(0x100e_1df6, 2)) goto l_0x100e_1df6; /* jnz 0x100e1df6 */
        l_0x100e_1df4:
            ii(0x100e_1df4, 2); jmp(0x100e_1e57, 0x61); goto l_0x100e_1e57; /* jmp 0x100e1e57 */
        l_0x100e_1df6:
            ii(0x100e_1df6, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100e_1df9, 3); add(eax, 4);                            /* add eax, 0x4 */
            ii(0x100e_1dfc, 5); call(0x1007_65d0, -0x6_b831);           /* call 0x100765d0 */
            ii(0x100e_1e01, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_1e03, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100e_1e06, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100e_1e08, 5); call(0x100e_3347, 0x153a);              /* call 0x100e3347 */
            ii(0x100e_1e0d, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100e_1e12, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100e_1e15, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100e_1e17, 5); call(0x100e_3e05, 0x1fe9);              /* call 0x100e3e05 */
            ii(0x100e_1e1c, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100e_1e1f, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100e_1e21, 5); call(0x100e_3fc4, 0x219e);              /* call 0x100e3fc4 */
            ii(0x100e_1e26, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100e_1e2b, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100e_1e2e, 5); call(0x100e_19f6, -0x43d);              /* call 0x100e19f6 */
            ii(0x100e_1e33, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100e_1e36, 5); call(0x100e_185e, -0x5dd);              /* call 0x100e185e */
            ii(0x100e_1e3b, 5); call(0x100d_5470, -0xc9d0);             /* call 0x100d5470 */
            ii(0x100e_1e40, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100e_1e43, 5); mov(ebx, 0x3ed);                        /* mov ebx, 0x3ed */
            ii(0x100e_1e48, 5); mov(edx, 0x3ec);                        /* mov edx, 0x3ec */
            ii(0x100e_1e4d, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100e_1e52, 5); call(0x1013_daea, 0x5_bc93);            /* call 0x1013daea */
        l_0x100e_1e57:
            ii(0x100e_1e57, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_1e59, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_1e5a, 1); pop(edi);                               /* pop edi */
            ii(0x100e_1e5b, 1); pop(esi);                               /* pop esi */
            ii(0x100e_1e5c, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_1e5d, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_1e5e, 1); ret();                                  /* ret */
        }
    }
}
