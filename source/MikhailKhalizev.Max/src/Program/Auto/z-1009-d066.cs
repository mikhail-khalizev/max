using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_d066-32514311")]
        public void Method_1009_d066()
        {
            ii(0x1009_d066, 5); push(0x34);                             /* push 0x34 */
            ii(0x1009_d06b, 5); call(Definitions.sys_check_available_stack_size, 0xc_8ce2); /* call 0x10165d52 */
            ii(0x1009_d070, 1); push(ecx);                              /* push ecx */
            ii(0x1009_d071, 1); push(esi);                              /* push esi */
            ii(0x1009_d072, 1); push(edi);                              /* push edi */
            ii(0x1009_d073, 1); push(ebp);                              /* push ebp */
            ii(0x1009_d074, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_d076, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1009_d07c, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_d07f, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1009_d082, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x1009_d085, 5); mov(ebx, 3);                            /* mov ebx, 0x3 */
            ii(0x1009_d08a, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1009_d08d, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_d090, 5); call(0x100a_3671, 0x65dc);              /* call 0x100a3671 */
            ii(0x1009_d095, 2); test(al, al);                           /* test al, al */
            ii(0x1009_d097, 6); if(jnz(0x1009_d123, 0x86)) goto l_0x1009_d123; /* jnz 0x1009d123 */
            ii(0x1009_d09d, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_d0a0, 4); cmp(memb[ds, eax + 6], 0);              /* cmp byte [eax+0x6], 0x0 */
            ii(0x1009_d0a4, 2); if(jz(0x1009_d0b5, 0xf)) goto l_0x1009_d0b5; /* jz 0x1009d0b5 */
            ii(0x1009_d0a6, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_d0a9, 3); mov(al, memb[ds, eax + 0x4e]);          /* mov al, [eax+0x4e] */
            ii(0x1009_d0ac, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1009_d0b1, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_d0b3, 2); if(jnz(0x1009_d0b7, 2)) goto l_0x1009_d0b7; /* jnz 0x1009d0b7 */
        l_0x1009_d0b5:
            ii(0x1009_d0b5, 2); jmp(0x1009_d123, 0x6c); goto l_0x1009_d123; /* jmp 0x1009d123 */
        l_0x1009_d0b7:
            ii(0x1009_d0b7, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_d0ba, 4); mov(memb[ds, eax + 6], 0);              /* mov byte [eax+0x6], 0x0 */
            ii(0x1009_d0be, 5); mov(eax, 0x45);                         /* mov eax, 0x45 */
            ii(0x1009_d0c3, 5); call(Definitions.sys_new, 0xc_8d38);    /* call 0x10165e00 */
            ii(0x1009_d0c8, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_d0cb, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_d0ce, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1009_d0d1, 4); cmp(memd[ss, ebp - 0x14], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1009_d0d5, 2); if(jz(0x1009_d0f4, 0x1d)) goto l_0x1009_d0f4; /* jz 0x1009d0f4 */
            ii(0x1009_d0d7, 4); movsx(ecx, memw[ss, ebp - 4]);          /* movsx ecx, word [ebp-0x4] */
            ii(0x1009_d0db, 3); mov(ebx, memd[ss, ebp - 8]);            /* mov ebx, [ebp-0x8] */
            ii(0x1009_d0de, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1009_d0e1, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_d0e4, 5); call(Definitions.my_ctor_c9, 0x41);     /* call 0x1009d12a */
            ii(0x1009_d0e9, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1009_d0ec, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1009_d0ef, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1009_d0f2, 2); jmp(0x1009_d0fa, 6); goto l_0x1009_d0fa; /* jmp 0x1009d0fa */
        l_0x1009_d0f4:
            ii(0x1009_d0f4, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1009_d0f7, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
        l_0x1009_d0fa:
            ii(0x1009_d0fa, 3); mov(edx, memd[ss, ebp - 0x1c]);         /* mov edx, [ebp-0x1c] */
            ii(0x1009_d0fd, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x1009_d100, 5); call(0x1008_b060, -0x1_20a5);           /* call 0x1008b060 */
            ii(0x1009_d105, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x1009_d108, 5); call(0x1008_af84, -0x1_2189);           /* call 0x1008af84 */
            ii(0x1009_d10d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_d10f, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_d114, 5); call(0x100a_4d50, 0x7c37);              /* call 0x100a4d50 */
            ii(0x1009_d119, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_d11b, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x1009_d11e, 5); call(0x1008_8b7c, -0x1_45a7);           /* call 0x10088b7c */
        l_0x1009_d123:
            ii(0x1009_d123, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_d125, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_d126, 1); pop(edi);                               /* pop edi */
            ii(0x1009_d127, 1); pop(esi);                               /* pop esi */
            ii(0x1009_d128, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_d129, 1); ret();                                  /* ret */
        }
    }
}
