using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_238c-d81b5e73")]
        public void Method_100b_238c()
        {
            ii(0x100b_238c, 5); push(0x24);                             /* push 0x24 */
            ii(0x100b_2391, 5); call(Definitions.sys_check_available_stack_size, 0xb_39bc); /* call 0x10165d52 */
            ii(0x100b_2396, 1); push(ecx);                              /* push ecx */
            ii(0x100b_2397, 1); push(esi);                              /* push esi */
            ii(0x100b_2398, 1); push(edi);                              /* push edi */
            ii(0x100b_2399, 1); push(ebp);                              /* push ebp */
            ii(0x100b_239a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_239c, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100b_23a2, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100b_23a5, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x100b_23a8, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x100b_23ab, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100b_23ae, 3); add(edx, 0x15);                         /* add edx, 0x15 */
            ii(0x100b_23b1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_23b4, 5); call(0x1007_6d98, -0x3_b621);           /* call 0x10076d98 */
            ii(0x100b_23b9, 2); test(al, al);                           /* test al, al */
            ii(0x100b_23bb, 6); if(jz(0x100b_243d, 0x7c)) goto l_0x100b_243d; /* jz 0x100b243d */
            ii(0x100b_23c1, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_23c4, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x100b_23c7, 5); call(0x100b_7c44, 0x5878);              /* call 0x100b7c44 */
            ii(0x100b_23cc, 3); lea(ebx, memd[ss, ebp - 0x10]);         /* lea ebx, [ebp-0x10] */
            ii(0x100b_23cf, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_23d1, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_23d3, 5); call(0x100b_7b28, 0x5750);              /* call 0x100b7b28 */
            ii(0x100b_23d8, 2); jmp(0x100b_23e2, 8); goto l_0x100b_23e2; /* jmp 0x100b23e2 */
        l_0x100b_23da:
            ii(0x100b_23da, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100b_23dd, 5); call(0x1007_6bf8, -0x3_b7ea);           /* call 0x10076bf8 */
        l_0x100b_23e2:
            ii(0x100b_23e2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_23e4, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100b_23e7, 5); call(0x1013_ad71, 0x8_8985);            /* call 0x1013ad71 */
            ii(0x100b_23ec, 2); test(al, al);                           /* test al, al */
            ii(0x100b_23ee, 2); if(jz(0x100b_2426, 0x36)) goto l_0x100b_2426; /* jz 0x100b2426 */
            ii(0x100b_23f0, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100b_23f3, 5); call(0x100b_7a14, 0x561c);              /* call 0x100b7a14 */
            ii(0x100b_23f8, 5); call(0x100b_7d68, 0x596b);              /* call 0x100b7d68 */
            ii(0x100b_23fd, 3); cmp(eax, memd[ss, ebp - 4]);            /* cmp eax, [ebp-0x4] */
            ii(0x100b_2400, 2); if(jnz(0x100b_2424, 0x22)) goto l_0x100b_2424; /* jnz 0x100b2424 */
            ii(0x100b_2402, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100b_2405, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_2408, 5); call(0x1015_27b8, 0xa_03ab);            /* call 0x101527b8 */
            ii(0x100b_240d, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100b_2410, 5); call(0x100b_7a7c, 0x5667);              /* call 0x100b7a7c */
            ii(0x100b_2415, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_2417, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_241a, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x100b_241d, 5); call(0x100b_7be4, 0x57c2);              /* call 0x100b7be4 */
            ii(0x100b_2422, 2); jmp(0x100b_2426, 2); goto l_0x100b_2426; /* jmp 0x100b2426 */
        l_0x100b_2424:
            ii(0x100b_2424, 2); jmp(0x100b_23da, -0x4c); goto l_0x100b_23da; /* jmp 0x100b23da */
        l_0x100b_2426:
            ii(0x100b_2426, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100b_242b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_242e, 5); call(0x100a_297d, -0xfab6);             /* call 0x100a297d */
            ii(0x100b_2433, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_2435, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100b_2438, 5); call(0x100b_7650, 0x5213);              /* call 0x100b7650 */
        l_0x100b_243d:
            ii(0x100b_243d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_243f, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_2440, 1); pop(edi);                               /* pop edi */
            ii(0x100b_2441, 1); pop(esi);                               /* pop esi */
            ii(0x100b_2442, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_2443, 1); ret();                                  /* ret */
        }
    }
}
