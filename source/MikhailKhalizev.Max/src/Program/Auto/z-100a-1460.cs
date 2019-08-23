using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_1460-e035da8a")]
        public void Method_100a_1460()
        {
            ii(0x100a_1460, 5); push(0x34);                             /* push 0x34 */
            ii(0x100a_1465, 5); call(Definitions.sys_check_available_stack_size, 0xc_48e8); /* call 0x10165d52 */
            ii(0x100a_146a, 1); push(ecx);                              /* push ecx */
            ii(0x100a_146b, 1); push(esi);                              /* push esi */
            ii(0x100a_146c, 1); push(edi);                              /* push edi */
            ii(0x100a_146d, 1); push(ebp);                              /* push ebp */
            ii(0x100a_146e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_1470, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100a_1476, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_1479, 3); mov(memd[ss, ebp - 0x8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100a_147c, 3); mov(memb[ss, ebp - 0x4], bl);           /* mov [ebp-0x4], bl */
            ii(0x100a_147f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_1482, 5); call(0x1007_6204, -0x2_b283);           /* call 0x10076204 */
            ii(0x100a_1487, 3); mov(ebx, memd[ss, ebp - 0xc]);          /* mov ebx, [ebp-0xc] */
            ii(0x100a_148a, 3); add(ebx, 0x2);                          /* add ebx, 0x2 */
            ii(0x100a_148d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_148f, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100a_1491, 5); call(0x1007_6e00, -0x2_a696);           /* call 0x10076e00 */
            ii(0x100a_1496, 2); test(al, al);                           /* test al, al */
            ii(0x100a_1498, 2); if(jz(0x100a_14a3, 0x9)) goto l_0x100a_14a3; /* jz 0x100a14a3 */
            ii(0x100a_149a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_149d, 4); cmp(memb[ds, eax + 0x3d], 0x4);         /* cmp byte [eax+0x3d], 0x4 */
            ii(0x100a_14a1, 2); if(jz(0x100a_14a5, 0x2)) goto l_0x100a_14a5; /* jz 0x100a14a5 */
        l_0x100a_14a3:
            ii(0x100a_14a3, 2); jmp(0x100a_14ae, 0x9); goto l_0x100a_14ae; /* jmp 0x100a14ae */
        l_0x100a_14a5:
            ii(0x100a_14a5, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_14a8, 4); cmp(memb[ds, eax + 0x3e], 0xd);         /* cmp byte [eax+0x3e], 0xd */
            ii(0x100a_14ac, 2); if(jnz(0x100a_14b0, 0x2)) goto l_0x100a_14b0; /* jnz 0x100a14b0 */
        l_0x100a_14ae:
            ii(0x100a_14ae, 2); jmp(0x100a_14b9, 0x9); goto l_0x100a_14b9; /* jmp 0x100a14b9 */
        l_0x100a_14b0:
            ii(0x100a_14b0, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_14b3, 4); cmp(memb[ds, eax + 0x3e], 0x2e);        /* cmp byte [eax+0x3e], 0x2e */
            ii(0x100a_14b7, 2); if(jnz(0x100a_14bb, 0x2)) goto l_0x100a_14bb; /* jnz 0x100a14bb */
        l_0x100a_14b9:
            ii(0x100a_14b9, 2); jmp(0x100a_14c4, 0x9); goto l_0x100a_14c4; /* jmp 0x100a14c4 */
        l_0x100a_14bb:
            ii(0x100a_14bb, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_14be, 4); cmp(memb[ds, eax + 0x3e], 0x1f);        /* cmp byte [eax+0x3e], 0x1f */
            ii(0x100a_14c2, 2); if(jnz(0x100a_14c6, 0x2)) goto l_0x100a_14c6; /* jnz 0x100a14c6 */
        l_0x100a_14c4:
            ii(0x100a_14c4, 2); jmp(0x100a_14de, 0x18); goto l_0x100a_14de; /* jmp 0x100a14de */
        l_0x100a_14c6:
            ii(0x100a_14c6, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100a_14cb, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_14ce, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x100a_14d1, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_14d4, 5); call(0x1007_1e00, -0x2_f6d9);           /* call 0x10071e00 */
            ii(0x100a_14d9, 1); cwde();                                 /* cwde */
            ii(0x100a_14da, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_14dc, 2); if(jg(0x100a_14e0, 0x2)) goto l_0x100a_14e0; /* jg 0x100a14e0 */
        l_0x100a_14de:
            ii(0x100a_14de, 2); jmp(0x100a_14f5, 0x15); goto l_0x100a_14f5; /* jmp 0x100a14f5 */
        l_0x100a_14e0:
            ii(0x100a_14e0, 4); cmp(memb[ss, ebp - 0x4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100a_14e4, 2); if(jnz(0x100a_14f3, 0xd)) goto l_0x100a_14f3; /* jnz 0x100a14f3 */
            ii(0x100a_14e6, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_14e9, 3); mov(eax, memd[ds, eax + 0x2a]);         /* mov eax, [eax+0x2a] */
            ii(0x100a_14ec, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_14ef, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_14f1, 2); if(jge(0x100a_14f5, 0x2)) goto l_0x100a_14f5; /* jge 0x100a14f5 */
        l_0x100a_14f3:
            ii(0x100a_14f3, 2); jmp(0x100a_14fa, 0x5); goto l_0x100a_14fa; /* jmp 0x100a14fa */
        l_0x100a_14f5:
            ii(0x100a_14f5, 5); jmp(0x100a_15cc, 0xd2); goto l_0x100a_15cc; /* jmp 0x100a15cc */
        l_0x100a_14fa:
            ii(0x100a_14fa, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_14fd, 5); call(0x1007_20b1, -0x2_f451);           /* call 0x100720b1 */
            ii(0x100a_1502, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100a_1507, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x100a_150a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_150d, 5); call(0x1007_2388, -0x2_f18a);           /* call 0x10072388 */
            ii(0x100a_1512, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100a_1516, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1518, 2); if(jge(0x100a_1527, 0xd)) goto l_0x100a_1527; /* jge 0x100a1527 */
            ii(0x100a_151a, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_151d, 3); mov(eax, memd[ds, eax + 0x30]);         /* mov eax, [eax+0x30] */
            ii(0x100a_1520, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_1523, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1525, 2); if(jl(0x100a_1529, 0x2)) goto l_0x100a_1529; /* jl 0x100a1529 */
        l_0x100a_1527:
            ii(0x100a_1527, 2); jmp(0x100a_1546, 0x1d); goto l_0x100a_1546; /* jmp 0x100a1546 */
        l_0x100a_1529:
            ii(0x100a_1529, 5); mov(eax, StringDefinitions.Workers);    /* mov eax, 0x101a099b */
            ii(0x100a_152e, 1); push(eax);                              /* push eax */
            ii(0x100a_152f, 5); mov(ecx, StringDefinitions.MoreSNeededSTurnedOff5); /* mov ecx, 0x101a09a3 */
            ii(0x100a_1534, 5); mov(ebx, StringDefinitions.CannotTurnSOnSNeeded6); /* mov ebx, 0x101a09c3 */
            ii(0x100a_1539, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100a_153c, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_153f, 5); call(0x100a_0f77, -0x5cd);              /* call 0x100a0f77 */
            ii(0x100a_1544, 2); jmp(0x100a_1584, 0x3e); goto l_0x100a_1584; /* jmp 0x100a1584 */
        l_0x100a_1546:
            ii(0x100a_1546, 4); cmp(memb[ss, ebp - 0x4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100a_154a, 2); if(jz(0x100a_1569, 0x1d)) goto l_0x100a_1569; /* jz 0x100a1569 */
            ii(0x100a_154c, 5); mov(eax, StringDefinitions.Power4);     /* mov eax, 0x101a09e2 */
            ii(0x100a_1551, 1); push(eax);                              /* push eax */
            ii(0x100a_1552, 5); mov(ecx, StringDefinitions.MoreSNeededSTurnedOff3); /* mov ecx, 0x101a09e8 */
            ii(0x100a_1557, 5); mov(ebx, StringDefinitions.CannotTurnSOnSNeeded3); /* mov ebx, 0x101a0a08 */
            ii(0x100a_155c, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100a_155f, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_1562, 5); call(0x100a_0f77, -0x5f0);              /* call 0x100a0f77 */
            ii(0x100a_1567, 2); jmp(0x100a_1584, 0x1b); goto l_0x100a_1584; /* jmp 0x100a1584 */
        l_0x100a_1569:
            ii(0x100a_1569, 5); mov(eax, StringDefinitions.RawMaterial); /* mov eax, 0x101a0a27 */
            ii(0x100a_156e, 1); push(eax);                              /* push eax */
            ii(0x100a_156f, 5); mov(ecx, StringDefinitions.MoreSNeededSTurnedOff4); /* mov ecx, 0x101a0a34 */
            ii(0x100a_1574, 5); mov(ebx, StringDefinitions.CannotTurnSOnSNeeded5); /* mov ebx, 0x101a0a54 */
            ii(0x100a_1579, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100a_157c, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_157f, 5); call(0x100a_0f77, -0x60d);              /* call 0x100a0f77 */
        l_0x100a_1584:
            ii(0x100a_1584, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x100a_1587, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_158a, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x100a_158d, 5); call(0x100a_13f7, -0x19b);              /* call 0x100a13f7 */
            ii(0x100a_1592, 4); cmp(memb[ss, ebp - 0x4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100a_1596, 2); if(jz(0x100a_15b1, 0x19)) goto l_0x100a_15b1; /* jz 0x100a15b1 */
            ii(0x100a_1598, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_159b, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x100a_159e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_15a1, 5); call(0x1007_1f2e, -0x2_f678);           /* call 0x10071f2e */
            ii(0x100a_15a6, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100a_15a9, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_15ac, 5); call(0x100a_110d, -0x4a4);              /* call 0x100a110d */
        l_0x100a_15b1:
            ii(0x100a_15b1, 5); mov(ebx, 0x2e);                         /* mov ebx, 0x2e */
            ii(0x100a_15b6, 5); mov(edx, 0x4);                          /* mov edx, 0x4 */
            ii(0x100a_15bb, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_15be, 5); call(0x1016_3053, 0xc_1a90);            /* call 0x10163053 */
            ii(0x100a_15c3, 7); mov(memd[ss, ebp - 0x1c], 0x1);         /* mov dword [ebp-0x1c], 0x1 */
            ii(0x100a_15ca, 2); jmp(0x100a_15d3, 0x7); goto l_0x100a_15d3; /* jmp 0x100a15d3 */
        l_0x100a_15cc:
            ii(0x100a_15cc, 7); mov(memd[ss, ebp - 0x1c], 0);           /* mov dword [ebp-0x1c], 0x0 */
        l_0x100a_15d3:
            ii(0x100a_15d3, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100a_15d6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_15d8, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_15d9, 1); pop(edi);                               /* pop edi */
            ii(0x100a_15da, 1); pop(esi);                               /* pop esi */
            ii(0x100a_15db, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_15dc, 1); ret();                                  /* ret */
        }
    }
}
