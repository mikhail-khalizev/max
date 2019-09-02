using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_c4db-b126bc0d")]
        public void Method_1015_c4db()
        {
            ii(0x1015_c4db, 5); push(0x30);                             /* push 0x30 */
            ii(0x1015_c4e0, 5); call(Definitions.sys_check_available_stack_size, 0x986d); /* call 0x10165d52 */
            ii(0x1015_c4e5, 1); push(ebx);                              /* push ebx */
            ii(0x1015_c4e6, 1); push(ecx);                              /* push ecx */
            ii(0x1015_c4e7, 1); push(esi);                              /* push esi */
            ii(0x1015_c4e8, 1); push(edi);                              /* push edi */
            ii(0x1015_c4e9, 1); push(ebp);                              /* push ebp */
            ii(0x1015_c4ea, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_c4ec, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1015_c4f2, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1015_c4f5, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1015_c4f8, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1015_c4fc, 5); call(/* sys */ 0x1016_5df8, 0x98f7);    /* call 0x10165df8 */
            ii(0x1015_c501, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1015_c504, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1015_c508, 5); call(/* sys */ 0x1016_5df8, 0x98eb);    /* call 0x10165df8 */
            ii(0x1015_c50d, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1015_c510, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1015_c514, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_c516, 2); if(jg(0x1015_c520, 8)) goto l_0x1015_c520; /* jg 0x1015c520 */
            ii(0x1015_c518, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1015_c51c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_c51e, 2); if(jle(0x1015_c525, 5)) goto l_0x1015_c525; /* jle 0x1015c525 */
        l_0x1015_c520:
            ii(0x1015_c520, 5); jmp(0x1015_c5a7, 0x82); goto l_0x1015_c5a7; /* jmp 0x1015c5a7 */
        l_0x1015_c525:
            ii(0x1015_c525, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x1015_c529, 3); sar(eax, 2);                            /* sar eax, 0x2 */
            ii(0x1015_c52c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_c52e, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x1015_c532, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_c534, 2); if(jg(0x1015_c53e, 8)) goto l_0x1015_c53e; /* jg 0x1015c53e */
            ii(0x1015_c536, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x1015_c53a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_c53c, 2); if(jnz(0x1015_c547, 9)) goto l_0x1015_c547; /* jnz 0x1015c547 */
        l_0x1015_c53e:
            ii(0x1015_c53e, 7); mov(memd[ss, ebp - 20], 0);             /* mov dword [ebp-0x14], 0x0 */
            ii(0x1015_c545, 2); jmp(0x1015_c5a2, 0x5b); goto l_0x1015_c5a2; /* jmp 0x1015c5a2 */
        l_0x1015_c547:
            ii(0x1015_c547, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x1015_c54b, 3); sar(eax, 2);                            /* sar eax, 0x2 */
            ii(0x1015_c54e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_c550, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x1015_c554, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_c556, 2); if(jg(0x1015_c560, 8)) goto l_0x1015_c560; /* jg 0x1015c560 */
            ii(0x1015_c558, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x1015_c55c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_c55e, 2); if(jnz(0x1015_c569, 9)) goto l_0x1015_c569; /* jnz 0x1015c569 */
        l_0x1015_c560:
            ii(0x1015_c560, 7); mov(memd[ss, ebp - 20], 0xc);           /* mov dword [ebp-0x14], 0xc */
            ii(0x1015_c567, 2); jmp(0x1015_c5a2, 0x39); goto l_0x1015_c5a2; /* jmp 0x1015c5a2 */
        l_0x1015_c569:
            ii(0x1015_c569, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x1015_c56d, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x1015_c56f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_c571, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x1015_c575, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_c577, 2); if(jl(0x1015_c582, 9)) goto l_0x1015_c582; /* jl 0x1015c582 */
            ii(0x1015_c579, 7); mov(memd[ss, ebp - 20], 0xf);           /* mov dword [ebp-0x14], 0xf */
            ii(0x1015_c580, 2); jmp(0x1015_c5a2, 0x20); goto l_0x1015_c5a2; /* jmp 0x1015c5a2 */
        l_0x1015_c582:
            ii(0x1015_c582, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x1015_c586, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x1015_c588, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_c58a, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x1015_c58e, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_c590, 2); if(jl(0x1015_c59b, 9)) goto l_0x1015_c59b; /* jl 0x1015c59b */
            ii(0x1015_c592, 7); mov(memd[ss, ebp - 20], 0xd);           /* mov dword [ebp-0x14], 0xd */
            ii(0x1015_c599, 2); jmp(0x1015_c5a2, 7); goto l_0x1015_c5a2; /* jmp 0x1015c5a2 */
        l_0x1015_c59b:
            ii(0x1015_c59b, 7); mov(memd[ss, ebp - 20], 0xe);           /* mov dword [ebp-0x14], 0xe */
        l_0x1015_c5a2:
            ii(0x1015_c5a2, 5); jmp(0x1015_c749, 0x1a2); goto l_0x1015_c749; /* jmp 0x1015c749 */
        l_0x1015_c5a7:
            ii(0x1015_c5a7, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1015_c5ab, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_c5ad, 2); if(jl(0x1015_c5b7, 8)) goto l_0x1015_c5b7; /* jl 0x1015c5b7 */
            ii(0x1015_c5af, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1015_c5b3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_c5b5, 2); if(jge(0x1015_c5bc, 5)) goto l_0x1015_c5bc; /* jge 0x1015c5bc */
        l_0x1015_c5b7:
            ii(0x1015_c5b7, 5); jmp(0x1015_c63e, 0x82); goto l_0x1015_c63e; /* jmp 0x1015c63e */
        l_0x1015_c5bc:
            ii(0x1015_c5bc, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x1015_c5c0, 3); sar(eax, 2);                            /* sar eax, 0x2 */
            ii(0x1015_c5c3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_c5c5, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x1015_c5c9, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_c5cb, 2); if(jg(0x1015_c5d5, 8)) goto l_0x1015_c5d5; /* jg 0x1015c5d5 */
            ii(0x1015_c5cd, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x1015_c5d1, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_c5d3, 2); if(jnz(0x1015_c5de, 9)) goto l_0x1015_c5de; /* jnz 0x1015c5de */
        l_0x1015_c5d5:
            ii(0x1015_c5d5, 7); mov(memd[ss, ebp - 20], 8);             /* mov dword [ebp-0x14], 0x8 */
            ii(0x1015_c5dc, 2); jmp(0x1015_c639, 0x5b); goto l_0x1015_c639; /* jmp 0x1015c639 */
        l_0x1015_c5de:
            ii(0x1015_c5de, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x1015_c5e2, 3); sar(eax, 2);                            /* sar eax, 0x2 */
            ii(0x1015_c5e5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_c5e7, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x1015_c5eb, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_c5ed, 2); if(jg(0x1015_c5f7, 8)) goto l_0x1015_c5f7; /* jg 0x1015c5f7 */
            ii(0x1015_c5ef, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x1015_c5f3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_c5f5, 2); if(jnz(0x1015_c600, 9)) goto l_0x1015_c600; /* jnz 0x1015c600 */
        l_0x1015_c5f7:
            ii(0x1015_c5f7, 7); mov(memd[ss, ebp - 20], 4);             /* mov dword [ebp-0x14], 0x4 */
            ii(0x1015_c5fe, 2); jmp(0x1015_c639, 0x39); goto l_0x1015_c639; /* jmp 0x1015c639 */
        l_0x1015_c600:
            ii(0x1015_c600, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x1015_c604, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x1015_c606, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_c608, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x1015_c60c, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_c60e, 2); if(jl(0x1015_c619, 9)) goto l_0x1015_c619; /* jl 0x1015c619 */
            ii(0x1015_c610, 7); mov(memd[ss, ebp - 20], 7);             /* mov dword [ebp-0x14], 0x7 */
            ii(0x1015_c617, 2); jmp(0x1015_c639, 0x20); goto l_0x1015_c639; /* jmp 0x1015c639 */
        l_0x1015_c619:
            ii(0x1015_c619, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x1015_c61d, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x1015_c61f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_c621, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x1015_c625, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_c627, 2); if(jl(0x1015_c632, 9)) goto l_0x1015_c632; /* jl 0x1015c632 */
            ii(0x1015_c629, 7); mov(memd[ss, ebp - 20], 5);             /* mov dword [ebp-0x14], 0x5 */
            ii(0x1015_c630, 2); jmp(0x1015_c639, 7); goto l_0x1015_c639; /* jmp 0x1015c639 */
        l_0x1015_c632:
            ii(0x1015_c632, 7); mov(memd[ss, ebp - 20], 6);             /* mov dword [ebp-0x14], 0x6 */
        l_0x1015_c639:
            ii(0x1015_c639, 5); jmp(0x1015_c749, 0x10b); goto l_0x1015_c749; /* jmp 0x1015c749 */
        l_0x1015_c63e:
            ii(0x1015_c63e, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1015_c642, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_c644, 6); if(jg(0x1015_c6cc, 0x82)) goto l_0x1015_c6cc; /* jg 0x1015c6cc */
            ii(0x1015_c64a, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x1015_c64e, 3); sar(eax, 2);                            /* sar eax, 0x2 */
            ii(0x1015_c651, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_c653, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x1015_c657, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_c659, 2); if(jg(0x1015_c663, 8)) goto l_0x1015_c663; /* jg 0x1015c663 */
            ii(0x1015_c65b, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x1015_c65f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_c661, 2); if(jnz(0x1015_c66c, 9)) goto l_0x1015_c66c; /* jnz 0x1015c66c */
        l_0x1015_c663:
            ii(0x1015_c663, 7); mov(memd[ss, ebp - 20], 8);             /* mov dword [ebp-0x14], 0x8 */
            ii(0x1015_c66a, 2); jmp(0x1015_c6c7, 0x5b); goto l_0x1015_c6c7; /* jmp 0x1015c6c7 */
        l_0x1015_c66c:
            ii(0x1015_c66c, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x1015_c670, 3); sar(eax, 2);                            /* sar eax, 0x2 */
            ii(0x1015_c673, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_c675, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x1015_c679, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_c67b, 2); if(jg(0x1015_c685, 8)) goto l_0x1015_c685; /* jg 0x1015c685 */
            ii(0x1015_c67d, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x1015_c681, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_c683, 2); if(jnz(0x1015_c68e, 9)) goto l_0x1015_c68e; /* jnz 0x1015c68e */
        l_0x1015_c685:
            ii(0x1015_c685, 7); mov(memd[ss, ebp - 20], 0xc);           /* mov dword [ebp-0x14], 0xc */
            ii(0x1015_c68c, 2); jmp(0x1015_c6c7, 0x39); goto l_0x1015_c6c7; /* jmp 0x1015c6c7 */
        l_0x1015_c68e:
            ii(0x1015_c68e, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x1015_c692, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x1015_c694, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_c696, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x1015_c69a, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_c69c, 2); if(jl(0x1015_c6a7, 9)) goto l_0x1015_c6a7; /* jl 0x1015c6a7 */
            ii(0x1015_c69e, 7); mov(memd[ss, ebp - 20], 9);             /* mov dword [ebp-0x14], 0x9 */
            ii(0x1015_c6a5, 2); jmp(0x1015_c6c7, 0x20); goto l_0x1015_c6c7; /* jmp 0x1015c6c7 */
        l_0x1015_c6a7:
            ii(0x1015_c6a7, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x1015_c6ab, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x1015_c6ad, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_c6af, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x1015_c6b3, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_c6b5, 2); if(jl(0x1015_c6c0, 9)) goto l_0x1015_c6c0; /* jl 0x1015c6c0 */
            ii(0x1015_c6b7, 7); mov(memd[ss, ebp - 20], 0xb);           /* mov dword [ebp-0x14], 0xb */
            ii(0x1015_c6be, 2); jmp(0x1015_c6c7, 7); goto l_0x1015_c6c7; /* jmp 0x1015c6c7 */
        l_0x1015_c6c0:
            ii(0x1015_c6c0, 7); mov(memd[ss, ebp - 20], 0xa);           /* mov dword [ebp-0x14], 0xa */
        l_0x1015_c6c7:
            ii(0x1015_c6c7, 5); jmp(0x1015_c749, 0x7d); goto l_0x1015_c749; /* jmp 0x1015c749 */
        l_0x1015_c6cc:
            ii(0x1015_c6cc, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x1015_c6d0, 3); sar(eax, 2);                            /* sar eax, 0x2 */
            ii(0x1015_c6d3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_c6d5, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x1015_c6d9, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_c6db, 2); if(jg(0x1015_c6e5, 8)) goto l_0x1015_c6e5; /* jg 0x1015c6e5 */
            ii(0x1015_c6dd, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x1015_c6e1, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_c6e3, 2); if(jnz(0x1015_c6ee, 9)) goto l_0x1015_c6ee; /* jnz 0x1015c6ee */
        l_0x1015_c6e5:
            ii(0x1015_c6e5, 7); mov(memd[ss, ebp - 20], 0);             /* mov dword [ebp-0x14], 0x0 */
            ii(0x1015_c6ec, 2); jmp(0x1015_c749, 0x5b); goto l_0x1015_c749; /* jmp 0x1015c749 */
        l_0x1015_c6ee:
            ii(0x1015_c6ee, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x1015_c6f2, 3); sar(eax, 2);                            /* sar eax, 0x2 */
            ii(0x1015_c6f5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_c6f7, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x1015_c6fb, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_c6fd, 2); if(jg(0x1015_c707, 8)) goto l_0x1015_c707; /* jg 0x1015c707 */
            ii(0x1015_c6ff, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x1015_c703, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_c705, 2); if(jnz(0x1015_c710, 9)) goto l_0x1015_c710; /* jnz 0x1015c710 */
        l_0x1015_c707:
            ii(0x1015_c707, 7); mov(memd[ss, ebp - 20], 4);             /* mov dword [ebp-0x14], 0x4 */
            ii(0x1015_c70e, 2); jmp(0x1015_c749, 0x39); goto l_0x1015_c749; /* jmp 0x1015c749 */
        l_0x1015_c710:
            ii(0x1015_c710, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x1015_c714, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x1015_c716, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_c718, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x1015_c71c, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_c71e, 2); if(jl(0x1015_c729, 9)) goto l_0x1015_c729; /* jl 0x1015c729 */
            ii(0x1015_c720, 7); mov(memd[ss, ebp - 20], 1);             /* mov dword [ebp-0x14], 0x1 */
            ii(0x1015_c727, 2); jmp(0x1015_c749, 0x20); goto l_0x1015_c749; /* jmp 0x1015c749 */
        l_0x1015_c729:
            ii(0x1015_c729, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x1015_c72d, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x1015_c72f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_c731, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x1015_c735, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_c737, 2); if(jl(0x1015_c742, 9)) goto l_0x1015_c742; /* jl 0x1015c742 */
            ii(0x1015_c739, 7); mov(memd[ss, ebp - 20], 3);             /* mov dword [ebp-0x14], 0x3 */
            ii(0x1015_c740, 2); jmp(0x1015_c749, 7); goto l_0x1015_c749; /* jmp 0x1015c749 */
        l_0x1015_c742:
            ii(0x1015_c742, 7); mov(memd[ss, ebp - 20], 2);             /* mov dword [ebp-0x14], 0x2 */
        l_0x1015_c749:
            ii(0x1015_c749, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1015_c74c, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1015_c74f, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1015_c752, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_c754, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_c755, 1); pop(edi);                               /* pop edi */
            ii(0x1015_c756, 1); pop(esi);                               /* pop esi */
            ii(0x1015_c757, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_c758, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_c759, 1); ret();                                  /* ret */
        }
    }
}
