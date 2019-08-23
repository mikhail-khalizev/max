using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_c8cf-a305d7f0")]
        public void Method_100a_c8cf()
        {
            ii(0x100a_c8cf, 5); push(0x44);                             /* push 0x44 */
            ii(0x100a_c8d4, 5); call(Definitions.sys_check_available_stack_size, 0xb_9479); /* call 0x10165d52 */
            ii(0x100a_c8d9, 1); push(ebx);                              /* push ebx */
            ii(0x100a_c8da, 1); push(ecx);                              /* push ecx */
            ii(0x100a_c8db, 1); push(esi);                              /* push esi */
            ii(0x100a_c8dc, 1); push(edi);                              /* push edi */
            ii(0x100a_c8dd, 1); push(ebp);                              /* push ebp */
            ii(0x100a_c8de, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_c8e0, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100a_c8e6, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_c8e9, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_c8ec, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_c8ee, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_c8f1, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_c8f4, 5); call(0x1013_ad11, 0x8_e418);            /* call 0x1013ad11 */
            ii(0x100a_c8f9, 2); test(al, al);                           /* test al, al */
            ii(0x100a_c8fb, 2); if(jz(0x100a_c91a, 0x1d)) goto l_0x100a_c91a; /* jz 0x100ac91a */
            ii(0x100a_c8fd, 5); mov(eax, StringDefinitions.MoveFinished); /* mov eax, 0x101a0e1c */
            ii(0x100a_c902, 1); push(eax);                              /* push eax */
            ii(0x100a_c903, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_c906, 1); push(eax);                              /* push eax */
            ii(0x100a_c907, 5); call(Definitions.sys_sprintf, 0xb_95f5); /* call 0x10165f01 */
            ii(0x100a_c90c, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x100a_c90f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_c912, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_c915, 5); jmp(0x100a_ca29, 0x10f); goto l_0x100a_ca29; /* jmp 0x100aca29 */
        l_0x100a_c91a:
            ii(0x100a_c91a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_c91d, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100a_c920, 5); call(Definitions.my_3_get_count, -0x2_14a5); /* call 0x1008b480 */
            ii(0x100a_c925, 1); cwde();                                 /* cwde */
            ii(0x100a_c926, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_c928, 2); if(jnz(0x100a_c98b, 0x61)) goto l_0x100a_c98b; /* jnz 0x100ac98b */
            ii(0x100a_c92a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_c92d, 3); mov(eax, memd[ds, eax + 0x24]);         /* mov eax, [eax+0x24] */
            ii(0x100a_c930, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_c933, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x100a_c936, 2); if(jz(0x100a_c974, 0x3c)) goto l_0x100a_c974; /* jz 0x100ac974 */
            ii(0x100a_c938, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_c93b, 3); mov(eax, memd[ds, eax + 0x24]);         /* mov eax, [eax+0x24] */
            ii(0x100a_c93e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_c941, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100a_c944, 6); push(memd[ds, eax + 0x101c_81d7]);      /* push dword [eax+0x101c81d7] */
            ii(0x100a_c94a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_c94d, 3); mov(eax, memd[ds, eax + 0x28]);         /* mov eax, [eax+0x28] */
            ii(0x100a_c950, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_c953, 1); inc(eax);                               /* inc eax */
            ii(0x100a_c954, 1); push(eax);                              /* push eax */
            ii(0x100a_c955, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_c958, 3); mov(eax, memd[ds, eax + 0x26]);         /* mov eax, [eax+0x26] */
            ii(0x100a_c95b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_c95e, 1); inc(eax);                               /* inc eax */
            ii(0x100a_c95f, 1); push(eax);                              /* push eax */
            ii(0x100a_c960, 5); mov(eax, StringDefinitions.MoveToIIUsingS); /* mov eax, 0x101a0e2c */
            ii(0x100a_c965, 1); push(eax);                              /* push eax */
            ii(0x100a_c966, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_c969, 1); push(eax);                              /* push eax */
            ii(0x100a_c96a, 5); call(Definitions.sys_sprintf, 0xb_9592); /* call 0x10165f01 */
            ii(0x100a_c96f, 3); add(esp, 0x14);                         /* add esp, 0x14 */
            ii(0x100a_c972, 2); jmp(0x100a_c986, 0x12); goto l_0x100a_c986; /* jmp 0x100ac986 */
        l_0x100a_c974:
            ii(0x100a_c974, 5); mov(eax, StringDefinitions.MoveCalculating); /* mov eax, 0x101a0e45 */
            ii(0x100a_c979, 1); push(eax);                              /* push eax */
            ii(0x100a_c97a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_c97d, 1); push(eax);                              /* push eax */
            ii(0x100a_c97e, 5); call(Definitions.sys_sprintf, 0xb_957e); /* call 0x10165f01 */
            ii(0x100a_c983, 3); add(esp, 0x8);                          /* add esp, 0x8 */
        l_0x100a_c986:
            ii(0x100a_c986, 5); jmp(0x100a_ca23, 0x98); goto l_0x100a_ca23; /* jmp 0x100aca23 */
        l_0x100a_c98b:
            ii(0x100a_c98b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_c98e, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100a_c991, 5); call(Definitions.my_3_get_count, -0x2_1516); /* call 0x1008b480 */
            ii(0x100a_c996, 1); dec(eax);                               /* dec eax */
            ii(0x100a_c997, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100a_c99a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_c99d, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100a_c9a0, 5); call(0x100a_aa28, -0x1f7d);             /* call 0x100aaa28 */
            ii(0x100a_c9a5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_c9a7, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100a_c9aa, 5); call(0x1007_5e64, -0x3_6b4b);           /* call 0x10075e64 */
            ii(0x100a_c9af, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_c9b2, 3); mov(eax, memd[ds, eax + 0x24]);         /* mov eax, [eax+0x24] */
            ii(0x100a_c9b5, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_c9b8, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x100a_c9bb, 2); if(jnz(0x100a_c9dd, 0x20)) goto l_0x100a_c9dd; /* jnz 0x100ac9dd */
            ii(0x100a_c9bd, 4); movsx(eax, memw[ss, ebp - 0xe]);        /* movsx eax, word [ebp-0xe] */
            ii(0x100a_c9c1, 1); inc(eax);                               /* inc eax */
            ii(0x100a_c9c2, 1); push(eax);                              /* push eax */
            ii(0x100a_c9c3, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100a_c9c7, 1); inc(eax);                               /* inc eax */
            ii(0x100a_c9c8, 1); push(eax);                              /* push eax */
            ii(0x100a_c9c9, 5); mov(eax, StringDefinitions.MoveToII);   /* mov eax, 0x101a0e58 */
            ii(0x100a_c9ce, 1); push(eax);                              /* push eax */
            ii(0x100a_c9cf, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_c9d2, 1); push(eax);                              /* push eax */
            ii(0x100a_c9d3, 5); call(Definitions.sys_sprintf, 0xb_9529); /* call 0x10165f01 */
            ii(0x100a_c9d8, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x100a_c9db, 2); jmp(0x100a_ca23, 0x46); goto l_0x100a_ca23; /* jmp 0x100aca23 */
        l_0x100a_c9dd:
            ii(0x100a_c9dd, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_c9e0, 3); mov(eax, memd[ds, eax + 0x24]);         /* mov eax, [eax+0x24] */
            ii(0x100a_c9e3, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_c9e6, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100a_c9e9, 6); push(memd[ds, eax + 0x101c_81d7]);      /* push dword [eax+0x101c81d7] */
            ii(0x100a_c9ef, 4); movsx(eax, memw[ss, ebp - 0xe]);        /* movsx eax, word [ebp-0xe] */
            ii(0x100a_c9f3, 1); inc(eax);                               /* inc eax */
            ii(0x100a_c9f4, 1); push(eax);                              /* push eax */
            ii(0x100a_c9f5, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100a_c9f9, 1); inc(eax);                               /* inc eax */
            ii(0x100a_c9fa, 1); push(eax);                              /* push eax */
            ii(0x100a_c9fb, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_c9fe, 3); mov(eax, memd[ds, eax + 0x28]);         /* mov eax, [eax+0x28] */
            ii(0x100a_ca01, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_ca04, 1); inc(eax);                               /* inc eax */
            ii(0x100a_ca05, 1); push(eax);                              /* push eax */
            ii(0x100a_ca06, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_ca09, 3); mov(eax, memd[ds, eax + 0x26]);         /* mov eax, [eax+0x26] */
            ii(0x100a_ca0c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_ca0f, 1); inc(eax);                               /* inc eax */
            ii(0x100a_ca10, 1); push(eax);                              /* push eax */
            ii(0x100a_ca11, 5); mov(eax, StringDefinitions.MoveToIIViaIIUsingS); /* mov eax, 0x101a0e68 */
            ii(0x100a_ca16, 1); push(eax);                              /* push eax */
            ii(0x100a_ca17, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_ca1a, 1); push(eax);                              /* push eax */
            ii(0x100a_ca1b, 5); call(Definitions.sys_sprintf, 0xb_94e1); /* call 0x10165f01 */
            ii(0x100a_ca20, 3); add(esp, 0x1c);                         /* add esp, 0x1c */
        l_0x100a_ca23:
            ii(0x100a_ca23, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_ca26, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
        l_0x100a_ca29:
            ii(0x100a_ca29, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_ca2c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_ca2e, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_ca2f, 1); pop(edi);                               /* pop edi */
            ii(0x100a_ca30, 1); pop(esi);                               /* pop esi */
            ii(0x100a_ca31, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_ca32, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_ca33, 1); ret();                                  /* ret */
        }
    }
}
