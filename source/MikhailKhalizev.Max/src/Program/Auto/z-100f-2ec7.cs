using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_2ec7-452b92f2")]
        public void Method_100f_2ec7()
        {
            ii(0x100f_2ec7, 5); push(0xec);                             /* push 0xec */
            ii(0x100f_2ecc, 5); call(Definitions.sys_check_available_stack_size, 0x7_2e81); /* call 0x10165d52 */
            ii(0x100f_2ed1, 1); push(ebx);                              /* push ebx */
            ii(0x100f_2ed2, 1); push(ecx);                              /* push ecx */
            ii(0x100f_2ed3, 1); push(edx);                              /* push edx */
            ii(0x100f_2ed4, 1); push(esi);                              /* push esi */
            ii(0x100f_2ed5, 1); push(edi);                              /* push edi */
            ii(0x100f_2ed6, 1); push(ebp);                              /* push ebp */
            ii(0x100f_2ed7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_2ed9, 6); sub(esp, 0xd0);                         /* sub esp, 0xd0 */
            ii(0x100f_2edf, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100f_2ee2, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_2ee6, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_2eec, 5); mov(edx, 0x101c_a468);                  /* mov edx, 0x101ca468 */
            ii(0x100f_2ef1, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100f_2ef3, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x100f_2ef6, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_2efa, 5); call(0x1013_367f, 0x4_0780);            /* call 0x1013367f */
            ii(0x100f_2eff, 5); mov(ebx, 0xba);                         /* mov ebx, 0xba */
            ii(0x100f_2f04, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_2f06, 6); lea(eax, ebp - 0xc8);                   /* lea eax, [ebp-0xc8] */
            ii(0x100f_2f0c, 5); call(Definitions.sys_memset, 0x7_2ecf); /* call 0x10165de0 */
            ii(0x100f_2f11, 6); lea(ebx, ebp - 0xc8);                   /* lea ebx, [ebp-0xc8] */
            ii(0x100f_2f17, 5); mov(edx, 0x101c_8178);                  /* mov edx, 0x101c8178 */
            ii(0x100f_2f1c, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_2f20, 5); call(0x100f_2a6f, -0x4b6);              /* call 0x100f2a6f */
            ii(0x100f_2f25, 6); lea(ebx, ebp - 0xc8);                   /* lea ebx, [ebp-0xc8] */
            ii(0x100f_2f2b, 5); mov(edx, 0x101c_8184);                  /* mov edx, 0x101c8184 */
            ii(0x100f_2f30, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_2f34, 5); call(0x100f_2a6f, -0x4ca);              /* call 0x100f2a6f */
            ii(0x100f_2f39, 6); lea(ebx, ebp - 0xc8);                   /* lea ebx, [ebp-0xc8] */
            ii(0x100f_2f3f, 5); mov(edx, 0x101c_819c);                  /* mov edx, 0x101c819c */
            ii(0x100f_2f44, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_2f48, 5); call(0x100f_2a6f, -0x4de);              /* call 0x100f2a6f */
            ii(0x100f_2f4d, 6); lea(ebx, ebp - 0xc8);                   /* lea ebx, [ebp-0xc8] */
            ii(0x100f_2f53, 5); mov(edx, 0x101c_81a8);                  /* mov edx, 0x101c81a8 */
            ii(0x100f_2f58, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_2f5c, 5); call(0x100f_2a6f, -0x4f2);              /* call 0x100f2a6f */
            ii(0x100f_2f61, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_2f65, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_2f6b, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x100f_2f71, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_2f76, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100f_2f79, 2); if(jz(0x100f_2f8a, 0xf)) goto l_0x100f_2f8a; /* jz 0x100f2f8a */
            ii(0x100f_2f7b, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100f_2f7f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_2f81, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x100f_2f86, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_2f88, 2); if(jnz(0x100f_2f95, 0xb)) goto l_0x100f_2f95; /* jnz 0x100f2f95 */
        l_0x100f_2f8a:
            ii(0x100f_2f8a, 6); lea(eax, ebp - 0xc8);                   /* lea eax, [ebp-0xc8] */
            ii(0x100f_2f90, 5); call(0x100f_2bf4, -0x3a1);              /* call 0x100f2bf4 */
        l_0x100f_2f95:
            ii(0x100f_2f95, 4); or(memb[ss, ebp - 0x8], 0x1);           /* or byte [ebp-0x8], 0x1 */
            ii(0x100f_2f99, 6); lea(eax, ebp - 0xcc);                   /* lea eax, [ebp-0xcc] */
            ii(0x100f_2f9f, 5); call(0x100e_0608, -0x1_299c);           /* call 0x100e0608 */
            ii(0x100f_2fa4, 6); mov(memd[ss, ebp - 0xd0], eax);         /* mov [ebp-0xd0], eax */
            ii(0x100f_2faa, 4); and(memb[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x100f_2fae, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100f_2fb1, 6); mov(eax, memd[ds, eax + 0xfa]);         /* mov eax, [eax+0xfa] */
            ii(0x100f_2fb7, 5); call(0x1010_2c18, 0xfc5c);              /* call 0x10102c18 */
            ii(0x100f_2fbc, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_2fbe, 6); lea(eax, ebp - 0xcc);                   /* lea eax, [ebp-0xcc] */
            ii(0x100f_2fc4, 5); call(0x100e_0548, -0x1_2a81);           /* call 0x100e0548 */
            ii(0x100f_2fc9, 2); jmp(0x100f_2fd6, 0xb); goto l_0x100f_2fd6; /* jmp 0x100f2fd6 */
        l_0x100f_2fcb:
            ii(0x100f_2fcb, 6); lea(eax, ebp - 0xcc);                   /* lea eax, [ebp-0xcc] */
            ii(0x100f_2fd1, 5); call(0x1007_6bf8, -0x7_c3de);           /* call 0x10076bf8 */
        l_0x100f_2fd6:
            ii(0x100f_2fd6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_2fd8, 6); lea(eax, ebp - 0xcc);                   /* lea eax, [ebp-0xcc] */
            ii(0x100f_2fde, 5); call(0x1013_ad71, 0x4_7d8e);            /* call 0x1013ad71 */
            ii(0x100f_2fe3, 2); test(al, al);                           /* test al, al */
            ii(0x100f_2fe5, 2); if(jz(0x100f_3016, 0x2f)) goto l_0x100f_3016; /* jz 0x100f3016 */
            ii(0x100f_2fe7, 6); lea(eax, ebp - 0xcc);                   /* lea eax, [ebp-0xcc] */
            ii(0x100f_2fed, 5); call(0x100e_04e4, -0x1_2b0e);           /* call 0x100e04e4 */
            ii(0x100f_2ff2, 5); call(0x1007_35ac, -0x7_fa4b);           /* call 0x100735ac */
            ii(0x100f_2ff7, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x100f_2ffc, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_2ffe, 6); lea(eax, ebp - 0xcc);                   /* lea eax, [ebp-0xcc] */
            ii(0x100f_3004, 5); call(0x1010_2a58, 0xfa4f);              /* call 0x10102a58 */
            ii(0x100f_3009, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_300b, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_300f, 5); call(0x1010_11ff, 0xe1eb);              /* call 0x101011ff */
            ii(0x100f_3014, 2); jmp(0x100f_2fcb, -0x4b); goto l_0x100f_2fcb; /* jmp 0x100f2fcb */
        l_0x100f_3016:
            ii(0x100f_3016, 7); mov(memb[ds, 0x101c_391e], 0x8);        /* mov byte [0x101c391e], 0x8 */
            ii(0x100f_301d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_301f, 6); lea(eax, ebp - 0xcc);                   /* lea eax, [ebp-0xcc] */
            ii(0x100f_3025, 5); call(0x100e_043c, -0x1_2bee);           /* call 0x100e043c */
            ii(0x100f_302a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_302c, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_302d, 1); pop(edi);                               /* pop edi */
            ii(0x100f_302e, 1); pop(esi);                               /* pop esi */
            ii(0x100f_302f, 1); pop(edx);                               /* pop edx */
            ii(0x100f_3030, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_3031, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_3032, 1); ret();                                  /* ret */
        }
    }
}
