using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_d90b-cbea0792")]
        public void Method_1010_d90b()
        {
            ii(0x1010_d90b, 5); push(0x108);                            /* push 0x108 */
            ii(0x1010_d910, 5); call(Definitions.sys_check_available_stack_size, 0x5_843d); /* call 0x10165d52 */
            ii(0x1010_d915, 1); push(ebx);                              /* push ebx */
            ii(0x1010_d916, 1); push(ecx);                              /* push ecx */
            ii(0x1010_d917, 1); push(edx);                              /* push edx */
            ii(0x1010_d918, 1); push(esi);                              /* push esi */
            ii(0x1010_d919, 1); push(edi);                              /* push edi */
            ii(0x1010_d91a, 1); push(ebp);                              /* push ebp */
            ii(0x1010_d91b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_d91d, 6); sub(esp, 0xec);                         /* sub esp, 0xec */
            ii(0x1010_d923, 4); mov(memb[ss, ebp - 0x4], 0);            /* mov byte [ebp-0x4], 0x0 */
            ii(0x1010_d927, 6); lea(eax, ebp - 0xe8);                   /* lea eax, [ebp-0xe8] */
            ii(0x1010_d92d, 5); call(0x1010_d71b, -0x217);              /* call 0x1010d71b */
        l_0x1010_d932:
            ii(0x1010_d932, 7); cmp(memb[ds, 0x101c_5630], 0x1);        /* cmp byte [0x101c5630], 0x1 */
            ii(0x1010_d939, 2); if(jnz(0x1010_d940, 0x5)) goto l_0x1010_d940; /* jnz 0x1010d940 */
            ii(0x1010_d93b, 5); call(0x1012_ac94, 0x1_d354);            /* call 0x1012ac94 */
        l_0x1010_d940:
            ii(0x1010_d940, 5); call(/* sys */ 0x1016_b208, 0x5_d8c3);  /* call 0x1016b208 */
            ii(0x1010_d945, 6); mov(memd[ss, ebp - 0xd8], eax);         /* mov [ebp-0xd8], eax */
            ii(0x1010_d94b, 7); cmp(memd[ss, ebp - 0xd8], 0);           /* cmp dword [ebp-0xd8], 0x0 */
            ii(0x1010_d952, 2); if(jle(0x1010_d960, 0xc)) goto l_0x1010_d960; /* jle 0x1010d960 */
            ii(0x1010_d954, 10); cmp(memd[ss, ebp - 0xd8], 0x7000);     /* cmp dword [ebp-0xd8], 0x7000 */
            ii(0x1010_d95e, 2); if(jl(0x1010_d962, 0x2)) goto l_0x1010_d962; /* jl 0x1010d962 */
        l_0x1010_d960:
            ii(0x1010_d960, 2); jmp(0x1010_d966, 0x4); goto l_0x1010_d966; /* jmp 0x1010d966 */
        l_0x1010_d962:
            ii(0x1010_d962, 4); mov(memb[ss, ebp - 0x4], 0);            /* mov byte [ebp-0x4], 0x0 */
        l_0x1010_d966:
            ii(0x1010_d966, 10); mov(memd[ss, ebp - 0xec], 0);          /* mov dword [ebp-0xec], 0x0 */
            ii(0x1010_d970, 2); jmp(0x1010_d97e, 0xc); goto l_0x1010_d97e; /* jmp 0x1010d97e */
        l_0x1010_d972:
            ii(0x1010_d972, 6); mov(eax, memd[ss, ebp - 0xec]);         /* mov eax, [ebp-0xec] */
            ii(0x1010_d978, 6); inc(memd[ss, ebp - 0xec]);              /* inc dword [ebp-0xec] */
        l_0x1010_d97e:
            ii(0x1010_d97e, 7); movsx(eax, memw[ss, ebp - 0xec]);       /* movsx eax, word [ebp-0xec] */
            ii(0x1010_d985, 3); cmp(eax, 0xc);                          /* cmp eax, 0xc */
            ii(0x1010_d988, 6); if(jge(0x1010_da4d, 0xbf)) goto l_0x1010_da4d; /* jge 0x1010da4d */
            ii(0x1010_d98e, 7); movsx(eax, memw[ss, ebp - 0xec]);       /* movsx eax, word [ebp-0xec] */
            ii(0x1010_d995, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_d998, 8); cmp(memd[ds, eax + ebp - 0xc8], 0);     /* cmp dword [eax+ebp-0xc8], 0x0 */
            ii(0x1010_d9a0, 6); if(jz(0x1010_da48, 0xa2)) goto l_0x1010_da48; /* jz 0x1010da48 */
            ii(0x1010_d9a6, 7); movsx(eax, memw[ss, ebp - 0xec]);       /* movsx eax, word [ebp-0xec] */
            ii(0x1010_d9ad, 5); add(eax, 0x7000);                       /* add eax, 0x7000 */
            ii(0x1010_d9b2, 6); cmp(eax, memd[ss, ebp - 0xd8]);         /* cmp eax, [ebp-0xd8] */
            ii(0x1010_d9b8, 2); if(jnz(0x1010_d9dc, 0x22)) goto l_0x1010_d9dc; /* jnz 0x1010d9dc */
            ii(0x1010_d9ba, 4); cmp(memb[ss, ebp - 0x4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1010_d9be, 2); if(jnz(0x1010_d9d6, 0x16)) goto l_0x1010_d9d6; /* jnz 0x1010d9d6 */
            ii(0x1010_d9c0, 7); movsx(eax, memw[ss, ebp - 0xec]);       /* movsx eax, word [ebp-0xec] */
            ii(0x1010_d9c7, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_d9ca, 7); mov(eax, memd[ds, eax + ebp - 0xc8]);   /* mov eax, [eax+ebp-0xc8] */
            ii(0x1010_d9d1, 5); call(0x100c_fbbe, -0x3_de18);           /* call 0x100cfbbe */
        l_0x1010_d9d6:
            ii(0x1010_d9d6, 4); mov(memb[ss, ebp - 0x4], 0x1);          /* mov byte [ebp-0x4], 0x1 */
            ii(0x1010_d9da, 2); jmp(0x1010_da4d, 0x71); goto l_0x1010_da4d; /* jmp 0x1010da4d */
        l_0x1010_d9dc:
            ii(0x1010_d9dc, 7); movsx(edx, memw[ss, ebp - 0xec]);       /* movsx edx, word [ebp-0xec] */
            ii(0x1010_d9e3, 3); imul(edx, edx, 0xc);                    /* imul edx, edx, 0xc */
            ii(0x1010_d9e6, 6); mov(eax, memd[ss, ebp - 0xd8]);         /* mov eax, [ebp-0xd8] */
            ii(0x1010_d9ec, 7); cmp(eax, memd[ds, edx + ebp - 0x94]);   /* cmp eax, [edx+ebp-0x94] */
            ii(0x1010_d9f3, 2); if(jnz(0x1010_da0c, 0x17)) goto l_0x1010_da0c; /* jnz 0x1010da0c */
            ii(0x1010_d9f5, 7); movsx(eax, memw[ss, ebp - 0xec]);       /* movsx eax, word [ebp-0xec] */
            ii(0x1010_d9fc, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x1010_d9ff, 7); mov(eax, memd[ds, eax + ebp - 0x98]);   /* mov eax, [eax+ebp-0x98] */
            ii(0x1010_da06, 6); mov(memd[ss, ebp - 0xd8], eax);         /* mov [ebp-0xd8], eax */
        l_0x1010_da0c:
            ii(0x1010_da0c, 7); movsx(edx, memw[ss, ebp - 0xec]);       /* movsx edx, word [ebp-0xec] */
            ii(0x1010_da13, 3); imul(edx, edx, 0xc);                    /* imul edx, edx, 0xc */
            ii(0x1010_da16, 6); mov(eax, memd[ss, ebp - 0xd8]);         /* mov eax, [ebp-0xd8] */
            ii(0x1010_da1c, 7); cmp(eax, memd[ds, edx + ebp - 0x98]);   /* cmp eax, [edx+ebp-0x98] */
            ii(0x1010_da23, 2); if(jnz(0x1010_da48, 0x23)) goto l_0x1010_da48; /* jnz 0x1010da48 */
            ii(0x1010_da25, 10); add(memd[ss, ebp - 0xd8], 0xffff_fc18); /* add dword [ebp-0xd8], 0xfffffc18 */
            ii(0x1010_da2f, 7); movsx(edx, memw[ss, ebp - 0xec]);       /* movsx edx, word [ebp-0xec] */
            ii(0x1010_da36, 3); imul(edx, edx, 0xc);                    /* imul edx, edx, 0xc */
            ii(0x1010_da39, 6); lea(eax, ebp - 0xe8);                   /* lea eax, [ebp-0xe8] */
            ii(0x1010_da3f, 7); call_abs(memd[ds, edx + ebp - 0x90]);   /* call dword [edx+ebp-0x90] */
            ii(0x1010_da46, 2); jmp(0x1010_da4d, 0x5); goto l_0x1010_da4d; /* jmp 0x1010da4d */
        l_0x1010_da48:
            ii(0x1010_da48, 5); jmp(0x1010_d972, -0xdb); goto l_0x1010_d972; /* jmp 0x1010d972 */
        l_0x1010_da4d:
            ii(0x1010_da4d, 7); cmp(memd[ss, ebp - 0xe4], 0);           /* cmp dword [ebp-0xe4], 0x0 */
            ii(0x1010_da54, 2); if(jnz(0x1010_da5f, 0x9)) goto l_0x1010_da5f; /* jnz 0x1010da5f */
            ii(0x1010_da56, 7); cmp(memd[ss, ebp - 0xe0], 0);           /* cmp dword [ebp-0xe0], 0x0 */
            ii(0x1010_da5d, 2); if(jz(0x1010_da61, 0x2)) goto l_0x1010_da61; /* jz 0x1010da61 */
        l_0x1010_da5f:
            ii(0x1010_da5f, 2); jmp(0x1010_da66, 0x5); goto l_0x1010_da66; /* jmp 0x1010da66 */
        l_0x1010_da61:
            ii(0x1010_da61, 5); jmp(0x1010_d932, -0x134); goto l_0x1010_d932; /* jmp 0x1010d932 */
        l_0x1010_da66:
            ii(0x1010_da66, 6); lea(eax, ebp - 0xe8);                   /* lea eax, [ebp-0xe8] */
            ii(0x1010_da6c, 5); call(0x1010_d7fa, -0x277);              /* call 0x1010d7fa */
            ii(0x1010_da71, 7); cmp(memd[ss, ebp - 0xe0], 0);           /* cmp dword [ebp-0xe0], 0x0 */
            ii(0x1010_da78, 2); if(jz(0x1010_da83, 0x9)) goto l_0x1010_da83; /* jz 0x1010da83 */
            ii(0x1010_da7a, 7); mov(memd[ss, ebp - 0x8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x1010_da81, 2); jmp(0x1010_da9b, 0x18); goto l_0x1010_da9b; /* jmp 0x1010da9b */
        l_0x1010_da83:
            ii(0x1010_da83, 7); movsx(edx, memw[ss, ebp - 0xdc]);       /* movsx edx, word [ebp-0xdc] */
            ii(0x1010_da8a, 5); mov(eax, 0x45);                         /* mov eax, 0x45 */
            ii(0x1010_da8f, 5); call(0x100c_aafc, -0x4_2f98);           /* call 0x100caafc */
            ii(0x1010_da94, 7); mov(memd[ss, ebp - 0x8], 0x1);          /* mov dword [ebp-0x8], 0x1 */
        l_0x1010_da9b:
            ii(0x1010_da9b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_da9e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_daa0, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_daa1, 1); pop(edi);                               /* pop edi */
            ii(0x1010_daa2, 1); pop(esi);                               /* pop esi */
            ii(0x1010_daa3, 1); pop(edx);                               /* pop edx */
            ii(0x1010_daa4, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_daa5, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_daa6, 1); ret();                                  /* ret */
        }
    }
}
