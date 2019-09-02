using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_c339-5665ebcc")]
        public void Method_1015_c339()
        {
            ii(0x1015_c339, 5); push(0x30);                             /* push 0x30 */
            ii(0x1015_c33e, 5); call(Definitions.sys_check_available_stack_size, 0x9a0f); /* call 0x10165d52 */
            ii(0x1015_c343, 1); push(ebx);                              /* push ebx */
            ii(0x1015_c344, 1); push(ecx);                              /* push ecx */
            ii(0x1015_c345, 1); push(esi);                              /* push esi */
            ii(0x1015_c346, 1); push(edi);                              /* push edi */
            ii(0x1015_c347, 1); push(ebp);                              /* push ebp */
            ii(0x1015_c348, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_c34a, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1015_c350, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1015_c353, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1015_c356, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1015_c35a, 5); call(/* sys */ 0x1016_5df8, 0x9a99);    /* call 0x10165df8 */
            ii(0x1015_c35f, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1015_c362, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1015_c366, 5); call(/* sys */ 0x1016_5df8, 0x9a8d);    /* call 0x10165df8 */
            ii(0x1015_c36b, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1015_c36e, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1015_c372, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_c374, 2); if(jg(0x1015_c37e, 8)) goto l_0x1015_c37e; /* jg 0x1015c37e */
            ii(0x1015_c376, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1015_c37a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_c37c, 2); if(jle(0x1015_c380, 2)) goto l_0x1015_c380; /* jle 0x1015c380 */
        l_0x1015_c37e:
            ii(0x1015_c37e, 2); jmp(0x1015_c3ce, 0x4e); goto l_0x1015_c3ce; /* jmp 0x1015c3ce */
        l_0x1015_c380:
            ii(0x1015_c380, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1015_c384, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x1015_c386, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_c388, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1015_c38c, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_c38e, 2); if(jg(0x1015_c398, 8)) goto l_0x1015_c398; /* jg 0x1015c398 */
            ii(0x1015_c390, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1015_c394, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_c396, 2); if(jnz(0x1015_c3a1, 9)) goto l_0x1015_c3a1; /* jnz 0x1015c3a1 */
        l_0x1015_c398:
            ii(0x1015_c398, 7); mov(memd[ss, ebp - 0x14], 0);           /* mov dword [ebp-0x14], 0x0 */
            ii(0x1015_c39f, 2); jmp(0x1015_c3c9, 0x28); goto l_0x1015_c3c9; /* jmp 0x1015c3c9 */
        l_0x1015_c3a1:
            ii(0x1015_c3a1, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1015_c3a5, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x1015_c3a7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_c3a9, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1015_c3ad, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_c3af, 2); if(jg(0x1015_c3b9, 8)) goto l_0x1015_c3b9; /* jg 0x1015c3b9 */
            ii(0x1015_c3b1, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1015_c3b5, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_c3b7, 2); if(jnz(0x1015_c3c2, 9)) goto l_0x1015_c3c2; /* jnz 0x1015c3c2 */
        l_0x1015_c3b9:
            ii(0x1015_c3b9, 7); mov(memd[ss, ebp - 0x14], 6);           /* mov dword [ebp-0x14], 0x6 */
            ii(0x1015_c3c0, 2); jmp(0x1015_c3c9, 7); goto l_0x1015_c3c9; /* jmp 0x1015c3c9 */
        l_0x1015_c3c2:
            ii(0x1015_c3c2, 7); mov(memd[ss, ebp - 0x14], 7);           /* mov dword [ebp-0x14], 0x7 */
        l_0x1015_c3c9:
            ii(0x1015_c3c9, 5); jmp(0x1015_c4ca, 0xfc); goto l_0x1015_c4ca; /* jmp 0x1015c4ca */
        l_0x1015_c3ce:
            ii(0x1015_c3ce, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1015_c3d2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_c3d4, 2); if(jl(0x1015_c3de, 8)) goto l_0x1015_c3de; /* jl 0x1015c3de */
            ii(0x1015_c3d6, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1015_c3da, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_c3dc, 2); if(jge(0x1015_c3e0, 2)) goto l_0x1015_c3e0; /* jge 0x1015c3e0 */
        l_0x1015_c3de:
            ii(0x1015_c3de, 2); jmp(0x1015_c42e, 0x4e); goto l_0x1015_c42e; /* jmp 0x1015c42e */
        l_0x1015_c3e0:
            ii(0x1015_c3e0, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1015_c3e4, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x1015_c3e6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_c3e8, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1015_c3ec, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_c3ee, 2); if(jg(0x1015_c3f8, 8)) goto l_0x1015_c3f8; /* jg 0x1015c3f8 */
            ii(0x1015_c3f0, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1015_c3f4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_c3f6, 2); if(jnz(0x1015_c401, 9)) goto l_0x1015_c401; /* jnz 0x1015c401 */
        l_0x1015_c3f8:
            ii(0x1015_c3f8, 7); mov(memd[ss, ebp - 0x14], 4);           /* mov dword [ebp-0x14], 0x4 */
            ii(0x1015_c3ff, 2); jmp(0x1015_c429, 0x28); goto l_0x1015_c429; /* jmp 0x1015c429 */
        l_0x1015_c401:
            ii(0x1015_c401, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1015_c405, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x1015_c407, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_c409, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1015_c40d, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_c40f, 2); if(jg(0x1015_c419, 8)) goto l_0x1015_c419; /* jg 0x1015c419 */
            ii(0x1015_c411, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1015_c415, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_c417, 2); if(jnz(0x1015_c422, 9)) goto l_0x1015_c422; /* jnz 0x1015c422 */
        l_0x1015_c419:
            ii(0x1015_c419, 7); mov(memd[ss, ebp - 0x14], 2);           /* mov dword [ebp-0x14], 0x2 */
            ii(0x1015_c420, 2); jmp(0x1015_c429, 7); goto l_0x1015_c429; /* jmp 0x1015c429 */
        l_0x1015_c422:
            ii(0x1015_c422, 7); mov(memd[ss, ebp - 0x14], 3);           /* mov dword [ebp-0x14], 0x3 */
        l_0x1015_c429:
            ii(0x1015_c429, 5); jmp(0x1015_c4ca, 0x9c); goto l_0x1015_c4ca; /* jmp 0x1015c4ca */
        l_0x1015_c42e:
            ii(0x1015_c42e, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1015_c432, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_c434, 2); if(jg(0x1015_c481, 0x4b)) goto l_0x1015_c481; /* jg 0x1015c481 */
            ii(0x1015_c436, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1015_c43a, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x1015_c43c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_c43e, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1015_c442, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_c444, 2); if(jg(0x1015_c44e, 8)) goto l_0x1015_c44e; /* jg 0x1015c44e */
            ii(0x1015_c446, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1015_c44a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_c44c, 2); if(jnz(0x1015_c457, 9)) goto l_0x1015_c457; /* jnz 0x1015c457 */
        l_0x1015_c44e:
            ii(0x1015_c44e, 7); mov(memd[ss, ebp - 0x14], 4);           /* mov dword [ebp-0x14], 0x4 */
            ii(0x1015_c455, 2); jmp(0x1015_c47f, 0x28); goto l_0x1015_c47f; /* jmp 0x1015c47f */
        l_0x1015_c457:
            ii(0x1015_c457, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1015_c45b, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x1015_c45d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_c45f, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1015_c463, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_c465, 2); if(jg(0x1015_c46f, 8)) goto l_0x1015_c46f; /* jg 0x1015c46f */
            ii(0x1015_c467, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1015_c46b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_c46d, 2); if(jnz(0x1015_c478, 9)) goto l_0x1015_c478; /* jnz 0x1015c478 */
        l_0x1015_c46f:
            ii(0x1015_c46f, 7); mov(memd[ss, ebp - 0x14], 6);           /* mov dword [ebp-0x14], 0x6 */
            ii(0x1015_c476, 2); jmp(0x1015_c47f, 7); goto l_0x1015_c47f; /* jmp 0x1015c47f */
        l_0x1015_c478:
            ii(0x1015_c478, 7); mov(memd[ss, ebp - 0x14], 5);           /* mov dword [ebp-0x14], 0x5 */
        l_0x1015_c47f:
            ii(0x1015_c47f, 2); jmp(0x1015_c4ca, 0x49); goto l_0x1015_c4ca; /* jmp 0x1015c4ca */
        l_0x1015_c481:
            ii(0x1015_c481, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1015_c485, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x1015_c487, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_c489, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1015_c48d, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_c48f, 2); if(jg(0x1015_c499, 8)) goto l_0x1015_c499; /* jg 0x1015c499 */
            ii(0x1015_c491, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1015_c495, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_c497, 2); if(jnz(0x1015_c4a2, 9)) goto l_0x1015_c4a2; /* jnz 0x1015c4a2 */
        l_0x1015_c499:
            ii(0x1015_c499, 7); mov(memd[ss, ebp - 0x14], 0);           /* mov dword [ebp-0x14], 0x0 */
            ii(0x1015_c4a0, 2); jmp(0x1015_c4ca, 0x28); goto l_0x1015_c4ca; /* jmp 0x1015c4ca */
        l_0x1015_c4a2:
            ii(0x1015_c4a2, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1015_c4a6, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x1015_c4a8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_c4aa, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1015_c4ae, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_c4b0, 2); if(jg(0x1015_c4ba, 8)) goto l_0x1015_c4ba; /* jg 0x1015c4ba */
            ii(0x1015_c4b2, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1015_c4b6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_c4b8, 2); if(jnz(0x1015_c4c3, 9)) goto l_0x1015_c4c3; /* jnz 0x1015c4c3 */
        l_0x1015_c4ba:
            ii(0x1015_c4ba, 7); mov(memd[ss, ebp - 0x14], 2);           /* mov dword [ebp-0x14], 0x2 */
            ii(0x1015_c4c1, 2); jmp(0x1015_c4ca, 7); goto l_0x1015_c4ca; /* jmp 0x1015c4ca */
        l_0x1015_c4c3:
            ii(0x1015_c4c3, 7); mov(memd[ss, ebp - 0x14], 1);           /* mov dword [ebp-0x14], 0x1 */
        l_0x1015_c4ca:
            ii(0x1015_c4ca, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1015_c4cd, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1015_c4d0, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1015_c4d3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_c4d5, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_c4d6, 1); pop(edi);                               /* pop edi */
            ii(0x1015_c4d7, 1); pop(esi);                               /* pop esi */
            ii(0x1015_c4d8, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_c4d9, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_c4da, 1); ret();                                  /* ret */
        }
    }
}
