using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_c8d7-84a703bc")]
        public void Method_100e_c8d7()
        {
            ii(0x100e_c8d7, 5); push(0x40);                             /* push 0x40 */
            ii(0x100e_c8dc, 5); call(Definitions.sys_check_available_stack_size, 0x7_9471); /* call 0x10165d52 */
            ii(0x100e_c8e1, 1); push(ebx);                              /* push ebx */
            ii(0x100e_c8e2, 1); push(ecx);                              /* push ecx */
            ii(0x100e_c8e3, 1); push(esi);                              /* push esi */
            ii(0x100e_c8e4, 1); push(edi);                              /* push edi */
            ii(0x100e_c8e5, 1); push(ebp);                              /* push ebp */
            ii(0x100e_c8e6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_c8e8, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x100e_c8ee, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_c8f1, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100e_c8f4, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100e_c8f9, 5); call(0x1007_6338, -0x7_65c6);           /* call 0x10076338 */
            ii(0x100e_c8fe, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_c900, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100e_c903, 5); call(0x1007_64b8, -0x7_6450);           /* call 0x100764b8 */
            ii(0x100e_c908, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x100e_c90f, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x100e_c912, 5); call(0x1007_20b1, -0x7_a866);           /* call 0x100720b1 */
            ii(0x100e_c917, 2); jmp(0x100e_c921, 0x8); goto l_0x100e_c921; /* jmp 0x100ec921 */
        l_0x100e_c919:
            ii(0x100e_c919, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100e_c91c, 5); call(0x1007_6bf8, -0x7_5d29);           /* call 0x10076bf8 */
        l_0x100e_c921:
            ii(0x100e_c921, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_c923, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100e_c926, 5); call(0x1013_ad71, 0x4_e446);            /* call 0x1013ad71 */
            ii(0x100e_c92b, 2); test(al, al);                           /* test al, al */
            ii(0x100e_c92d, 6); if(jz(0x100e_c9cb, 0x98)) goto l_0x100e_c9cb; /* jz 0x100ec9cb */
            ii(0x100e_c933, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100e_c936, 5); call(0x1007_63a0, -0x7_659b);           /* call 0x100763a0 */
            ii(0x100e_c93b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_c93d, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x100e_c940, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100e_c944, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100e_c946, 6); if(jnz(0x100e_c9c6, 0x7a)) goto l_0x100e_c9c6; /* jnz 0x100ec9c6 */
            ii(0x100e_c94c, 5); call(0x1007_6014, -0x7_693d);           /* call 0x10076014 */
            ii(0x100e_c951, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_c953, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100e_c955, 3); lea(edx, memd[ss, ebp - 0x1c]);         /* lea edx, [ebp-0x1c] */
            ii(0x100e_c958, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100e_c95b, 5); call(0x1007_63d4, -0x7_658c);           /* call 0x100763d4 */
            ii(0x100e_c960, 5); call(0x1007_2388, -0x7_a5dd);           /* call 0x10072388 */
            ii(0x100e_c965, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_c968, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x100e_c96b, 2); jmp(0x100e_c99f, 0x32); goto l_0x100e_c99f; /* jmp 0x100ec99f */
        l_0x100e_c96d:
            ii(0x100e_c96d, 4); movsx(eax, memw[ss, ebp - 0x1a]);       /* movsx eax, word [ebp-0x1a] */
            ii(0x100e_c971, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_c973, 2); if(jge(0x100e_c97b, 0x6)) goto l_0x100e_c97b; /* jge 0x100ec97b */
            ii(0x100e_c975, 3); mov(eax, memd[ss, ebp - 0x1a]);         /* mov eax, [ebp-0x1a] */
            ii(0x100e_c978, 3); sub(memd[ss, ebp - 0x10], eax);         /* sub [ebp-0x10], eax */
        l_0x100e_c97b:
            ii(0x100e_c97b, 2); jmp(0x100e_c9c6, 0x49); goto l_0x100e_c9c6; /* jmp 0x100ec9c6 */
        l_0x100e_c97d:
            ii(0x100e_c97d, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x100e_c981, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_c983, 2); if(jge(0x100e_c98b, 0x6)) goto l_0x100e_c98b; /* jge 0x100ec98b */
            ii(0x100e_c985, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100e_c988, 3); sub(memd[ss, ebp - 0x10], eax);         /* sub [ebp-0x10], eax */
        l_0x100e_c98b:
            ii(0x100e_c98b, 2); jmp(0x100e_c9c6, 0x39); goto l_0x100e_c9c6; /* jmp 0x100ec9c6 */
        l_0x100e_c98d:
            ii(0x100e_c98d, 4); movsx(eax, memw[ss, ebp - 0x1c]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x100e_c991, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_c993, 2); if(jge(0x100e_c99b, 0x6)) goto l_0x100e_c99b; /* jge 0x100ec99b */
            ii(0x100e_c995, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100e_c998, 3); sub(memd[ss, ebp - 0x10], eax);         /* sub [ebp-0x10], eax */
        l_0x100e_c99b:
            ii(0x100e_c99b, 2); jmp(0x100e_c9c6, 0x29); goto l_0x100e_c9c6; /* jmp 0x100ec9c6 */
        l_0x100e_c99d:
            ii(0x100e_c99d, 2); jmp(0x100e_c9c6, 0x27); goto l_0x100e_c9c6; /* jmp 0x100ec9c6 */
        l_0x100e_c99f:
            ii(0x100e_c99f, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100e_c9a2, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x100e_c9a5, 5); cmp(memw[ss, ebp - 0x24], 0x40);        /* cmp word [ebp-0x24], 0x40 */
            ii(0x100e_c9aa, 2); if(jb(0x100e_c9bd, 0x11)) goto l_0x100e_c9bd; /* jb 0x100ec9bd */
            ii(0x100e_c9ac, 5); cmp(memw[ss, ebp - 0x24], 0x40);        /* cmp word [ebp-0x24], 0x40 */
            ii(0x100e_c9b1, 2); if(jbe(0x100e_c98d, -0x26)) goto l_0x100e_c98d; /* jbe 0x100ec98d */
            ii(0x100e_c9b3, 6); cmp(memw[ss, ebp - 0x24], 0x80);        /* cmp word [ebp-0x24], 0x80 */
            ii(0x100e_c9b9, 2); if(jz(0x100e_c96d, -0x4e)) goto l_0x100e_c96d; /* jz 0x100ec96d */
            ii(0x100e_c9bb, 2); jmp(0x100e_c99d, -0x20); goto l_0x100e_c99d; /* jmp 0x100ec99d */
        l_0x100e_c9bd:
            ii(0x100e_c9bd, 5); cmp(memw[ss, ebp - 0x24], 0x20);        /* cmp word [ebp-0x24], 0x20 */
            ii(0x100e_c9c2, 2); if(jz(0x100e_c97d, -0x47)) goto l_0x100e_c97d; /* jz 0x100ec97d */
            ii(0x100e_c9c4, 2); jmp(0x100e_c99d, -0x29); goto l_0x100e_c99d; /* jmp 0x100ec99d */
        l_0x100e_c9c6:
            ii(0x100e_c9c6, 5); jmp(0x100e_c919, -0xb2); goto l_0x100e_c919; /* jmp 0x100ec919 */
        l_0x100e_c9cb:
            ii(0x100e_c9cb, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_c9ce, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x100e_c9d1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_c9d3, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100e_c9d6, 5); call(0x1007_5f6c, -0x7_6a6f);           /* call 0x10075f6c */
            ii(0x100e_c9db, 2); jmp(0x100e_c9e7, 0xa); goto l_0x100e_c9e7; /* jmp 0x100ec9e7 */
        //  ii(0x100e_c9dd, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x100e_c9df, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
        //  ii(0x100e_c9e2, 5); call(0x1007_5f6c, -0x7_6a7b);           /* call 0x10075f6c */
        l_0x100e_c9e7:
            ii(0x100e_c9e7, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x100e_c9ea, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_c9ec, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_c9ed, 1); pop(edi);                               /* pop edi */
            ii(0x100e_c9ee, 1); pop(esi);                               /* pop esi */
            ii(0x100e_c9ef, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_c9f0, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_c9f1, 1); ret();                                  /* ret */
        }
    }
}
