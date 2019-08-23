using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_1ea3-ad984e53")]
        public void Method_100a_1ea3()
        {
            ii(0x100a_1ea3, 5); push(0x3a4);                            /* push 0x3a4 */
            ii(0x100a_1ea8, 5); call(Definitions.sys_check_available_stack_size, 0xc_3ea5); /* call 0x10165d52 */
            ii(0x100a_1ead, 1); push(esi);                              /* push esi */
            ii(0x100a_1eae, 1); push(edi);                              /* push edi */
            ii(0x100a_1eaf, 1); push(ebp);                              /* push ebp */
            ii(0x100a_1eb0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_1eb2, 6); sub(esp, 0x394);                        /* sub esp, 0x394 */
            ii(0x100a_1eb8, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_1ebb, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x100a_1ebe, 3); mov(memd[ss, ebp - 0x10], ebx);         /* mov [ebp-0x10], ebx */
            ii(0x100a_1ec1, 3); mov(memb[ss, ebp - 0x4], cl);           /* mov [ebp-0x4], cl */
            ii(0x100a_1ec4, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100a_1ec8, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100a_1ece, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x100a_1ed4, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_1ed9, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x100a_1edc, 6); if(jz(0x100a_21fe, 0x31c)) goto l_0x100a_21fe; /* jz 0x100a21fe */
            ii(0x100a_1ee2, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_1ee5, 5); call(0x1007_35ac, -0x2_e93e);           /* call 0x100735ac */
            ii(0x100a_1eea, 4); or(memb[ss, ebp - 0x18], 0x1);          /* or byte [ebp-0x18], 0x1 */
            ii(0x100a_1eee, 3); mov(ebx, memd[ss, ebp - 0xc]);          /* mov ebx, [ebp-0xc] */
            ii(0x100a_1ef1, 4); movsx(edx, memw[ss, ebp - 0x8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100a_1ef5, 6); lea(eax, ebp - 0x390);                  /* lea eax, [ebp-0x390] */
            ii(0x100a_1efb, 5); call(0x100a_0104, -0x1dfc);             /* call 0x100a0104 */
            ii(0x100a_1f00, 6); mov(memd[ss, ebp - 0x394], eax);        /* mov [ebp-0x394], eax */
            ii(0x100a_1f06, 4); and(memb[ss, ebp - 0x18], -0x2 /* 0xfe */); /* and byte [ebp-0x18], 0xfe */
            ii(0x100a_1f0a, 7); movsx(eax, memw[ss, ebp - 0x364]);      /* movsx eax, word [ebp-0x364] */
            ii(0x100a_1f11, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1f13, 2); if(jl(0x100a_1f20, 0xb)) goto l_0x100a_1f20; /* jl 0x100a1f20 */
            ii(0x100a_1f15, 7); movsx(eax, memw[ss, ebp - 0x362]);      /* movsx eax, word [ebp-0x362] */
            ii(0x100a_1f1c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1f1e, 2); if(jge(0x100a_1f22, 0x2)) goto l_0x100a_1f22; /* jge 0x100a1f22 */
        l_0x100a_1f20:
            ii(0x100a_1f20, 2); jmp(0x100a_1f2d, 0xb); goto l_0x100a_1f2d; /* jmp 0x100a1f2d */
        l_0x100a_1f22:
            ii(0x100a_1f22, 7); movsx(eax, memw[ss, ebp - 0x366]);      /* movsx eax, word [ebp-0x366] */
            ii(0x100a_1f29, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1f2b, 2); if(jge(0x100a_1f2f, 0x2)) goto l_0x100a_1f2f; /* jge 0x100a1f2f */
        l_0x100a_1f2d:
            ii(0x100a_1f2d, 2); jmp(0x100a_1f3a, 0xb); goto l_0x100a_1f3a; /* jmp 0x100a1f3a */
        l_0x100a_1f2f:
            ii(0x100a_1f2f, 7); movsx(eax, memw[ss, ebp - 0x360]);      /* movsx eax, word [ebp-0x360] */
            ii(0x100a_1f36, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1f38, 2); if(jge(0x100a_1f3c, 0x2)) goto l_0x100a_1f3c; /* jge 0x100a1f3c */
        l_0x100a_1f3a:
            ii(0x100a_1f3a, 2); jmp(0x100a_1f47, 0xb); goto l_0x100a_1f47; /* jmp 0x100a1f47 */
        l_0x100a_1f3c:
            ii(0x100a_1f3c, 7); movsx(eax, memw[ss, ebp - 0x35e]);      /* movsx eax, word [ebp-0x35e] */
            ii(0x100a_1f43, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1f45, 2); if(jge(0x100a_1f49, 0x2)) goto l_0x100a_1f49; /* jge 0x100a1f49 */
        l_0x100a_1f47:
            ii(0x100a_1f47, 2); jmp(0x100a_1f4d, 0x4); goto l_0x100a_1f4d; /* jmp 0x100a1f4d */
        l_0x100a_1f49:
            ii(0x100a_1f49, 4); mov(memb[ss, ebp - 0x4], 0);            /* mov byte [ebp-0x4], 0x0 */
        l_0x100a_1f4d:
            ii(0x100a_1f4d, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x100a_1f50, 6); lea(eax, ebp - 0x34c);                  /* lea eax, [ebp-0x34c] */
            ii(0x100a_1f56, 5); call(0x1007_6630, -0x2_b92b);           /* call 0x10076630 */
            ii(0x100a_1f5b, 3); mov(al, memb[ss, ebp - 0x4]);           /* mov al, [ebp-0x4] */
            ii(0x100a_1f5e, 6); mov(memb[ss, ebp - 0x344], al);         /* mov [ebp-0x344], al */
            ii(0x100a_1f64, 6); lea(eax, ebp - 0x390);                  /* lea eax, [ebp-0x390] */
            ii(0x100a_1f6a, 5); call(0x100a_04b1, -0x1abe);             /* call 0x100a04b1 */
        l_0x100a_1f6f:
            ii(0x100a_1f6f, 7); movsx(eax, memw[ss, ebp - 0x364]);      /* movsx eax, word [ebp-0x364] */
            ii(0x100a_1f76, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1f78, 2); if(jl(0x100a_1f85, 0xb)) goto l_0x100a_1f85; /* jl 0x100a1f85 */
            ii(0x100a_1f7a, 7); movsx(eax, memw[ss, ebp - 0x362]);      /* movsx eax, word [ebp-0x362] */
            ii(0x100a_1f81, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1f83, 2); if(jge(0x100a_1f87, 0x2)) goto l_0x100a_1f87; /* jge 0x100a1f87 */
        l_0x100a_1f85:
            ii(0x100a_1f85, 2); jmp(0x100a_1f92, 0xb); goto l_0x100a_1f92; /* jmp 0x100a1f92 */
        l_0x100a_1f87:
            ii(0x100a_1f87, 7); movsx(eax, memw[ss, ebp - 0x360]);      /* movsx eax, word [ebp-0x360] */
            ii(0x100a_1f8e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1f90, 2); if(jge(0x100a_1f94, 0x2)) goto l_0x100a_1f94; /* jge 0x100a1f94 */
        l_0x100a_1f92:
            ii(0x100a_1f92, 2); jmp(0x100a_1f9f, 0xb); goto l_0x100a_1f9f; /* jmp 0x100a1f9f */
        l_0x100a_1f94:
            ii(0x100a_1f94, 7); movsx(eax, memw[ss, ebp - 0x35e]);      /* movsx eax, word [ebp-0x35e] */
            ii(0x100a_1f9b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1f9d, 2); if(jge(0x100a_1fa1, 0x2)) goto l_0x100a_1fa1; /* jge 0x100a1fa1 */
        l_0x100a_1f9f:
            ii(0x100a_1f9f, 2); jmp(0x100a_1fb0, 0xf); goto l_0x100a_1fb0; /* jmp 0x100a1fb0 */
        l_0x100a_1fa1:
            ii(0x100a_1fa1, 7); movsx(eax, memw[ss, ebp - 0x366]);      /* movsx eax, word [ebp-0x366] */
            ii(0x100a_1fa8, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1faa, 6); if(jge(0x100a_219c, 0x1ec)) goto l_0x100a_219c; /* jge 0x100a219c */
        l_0x100a_1fb0:
            ii(0x100a_1fb0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_1fb2, 6); lea(eax, ebp - 0x390);                  /* lea eax, [ebp-0x390] */
            ii(0x100a_1fb8, 5); call(0x100a_11c4, -0xdf9);              /* call 0x100a11c4 */
            ii(0x100a_1fbd, 7); movsx(eax, memw[ss, ebp - 0x364]);      /* movsx eax, word [ebp-0x364] */
            ii(0x100a_1fc4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1fc6, 2); if(jge(0x100a_1fe3, 0x1b)) goto l_0x100a_1fe3; /* jge 0x100a1fe3 */
            ii(0x100a_1fc8, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100a_1fca, 7); movsx(ebx, memw[ss, ebp - 0x364]);      /* movsx ebx, word [ebp-0x364] */
            ii(0x100a_1fd1, 2); neg(ebx);                               /* neg ebx */
            ii(0x100a_1fd3, 5); mov(edx, 0x80);                         /* mov edx, 0x80 */
            ii(0x100a_1fd8, 6); lea(eax, ebp - 0x390);                  /* lea eax, [ebp-0x390] */
            ii(0x100a_1fde, 5); call(0x100a_0d25, -0x12be);             /* call 0x100a0d25 */
        l_0x100a_1fe3:
            ii(0x100a_1fe3, 7); movsx(eax, memw[ss, ebp - 0x362]);      /* movsx eax, word [ebp-0x362] */
            ii(0x100a_1fea, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_1fec, 2); if(jge(0x100a_2009, 0x1b)) goto l_0x100a_2009; /* jge 0x100a2009 */
            ii(0x100a_1fee, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100a_1ff0, 7); movsx(ebx, memw[ss, ebp - 0x362]);      /* movsx ebx, word [ebp-0x362] */
            ii(0x100a_1ff7, 2); neg(ebx);                               /* neg ebx */
            ii(0x100a_1ff9, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x100a_1ffe, 6); lea(eax, ebp - 0x390);                  /* lea eax, [ebp-0x390] */
            ii(0x100a_2004, 5); call(0x100a_0d25, -0x12e4);             /* call 0x100a0d25 */
        l_0x100a_2009:
            ii(0x100a_2009, 7); movsx(eax, memw[ss, ebp - 0x366]);      /* movsx eax, word [ebp-0x366] */
            ii(0x100a_2010, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_2012, 2); if(jge(0x100a_202f, 0x1b)) goto l_0x100a_202f; /* jge 0x100a202f */
            ii(0x100a_2014, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100a_2016, 7); movsx(ebx, memw[ss, ebp - 0x366]);      /* movsx ebx, word [ebp-0x366] */
            ii(0x100a_201d, 2); neg(ebx);                               /* neg ebx */
            ii(0x100a_201f, 5); mov(edx, 0x40);                         /* mov edx, 0x40 */
            ii(0x100a_2024, 6); lea(eax, ebp - 0x390);                  /* lea eax, [ebp-0x390] */
            ii(0x100a_202a, 5); call(0x100a_0d25, -0x130a);             /* call 0x100a0d25 */
        l_0x100a_202f:
            ii(0x100a_202f, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
            ii(0x100a_2033, 7); movsx(eax, memw[ss, ebp - 0x364]);      /* movsx eax, word [ebp-0x364] */
            ii(0x100a_203a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_203c, 2); if(jl(0x100a_2049, 0xb)) goto l_0x100a_2049; /* jl 0x100a2049 */
            ii(0x100a_203e, 7); movsx(eax, memw[ss, ebp - 0x362]);      /* movsx eax, word [ebp-0x362] */
            ii(0x100a_2045, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_2047, 2); if(jge(0x100a_204b, 0x2)) goto l_0x100a_204b; /* jge 0x100a204b */
        l_0x100a_2049:
            ii(0x100a_2049, 2); jmp(0x100a_2056, 0xb); goto l_0x100a_2056; /* jmp 0x100a2056 */
        l_0x100a_204b:
            ii(0x100a_204b, 7); movsx(eax, memw[ss, ebp - 0x366]);      /* movsx eax, word [ebp-0x366] */
            ii(0x100a_2052, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_2054, 2); if(jge(0x100a_207e, 0x28)) goto l_0x100a_207e; /* jge 0x100a207e */
        l_0x100a_2056:
            ii(0x100a_2056, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_2058, 6); lea(eax, ebp - 0x390);                  /* lea eax, [ebp-0x390] */
            ii(0x100a_205e, 5); call(0x100a_15dd, -0xa86);              /* call 0x100a15dd */
            ii(0x100a_2063, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_2065, 2); if(jnz(0x100a_207a, 0x13)) goto l_0x100a_207a; /* jnz 0x100a207a */
            ii(0x100a_2067, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100a_2069, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_206b, 6); lea(eax, ebp - 0x390);                  /* lea eax, [ebp-0x390] */
            ii(0x100a_2071, 5); call(0x100a_1c16, -0x460);              /* call 0x100a1c16 */
            ii(0x100a_2076, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_2078, 2); if(jz(0x100a_207e, 0x4)) goto l_0x100a_207e; /* jz 0x100a207e */
        l_0x100a_207a:
            ii(0x100a_207a, 4); mov(memb[ss, ebp - 0x14], 0x1);         /* mov byte [ebp-0x14], 0x1 */
        l_0x100a_207e:
            ii(0x100a_207e, 4); cmp(memb[ss, ebp - 0x14], 0);           /* cmp byte [ebp-0x14], 0x0 */
            ii(0x100a_2082, 6); if(jnz(0x100a_2197, 0x10f)) goto l_0x100a_2197; /* jnz 0x100a2197 */
            ii(0x100a_2088, 7); movsx(eax, memw[ss, ebp - 0x35e]);      /* movsx eax, word [ebp-0x35e] */
            ii(0x100a_208f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_2091, 2); if(jge(0x100a_209e, 0xb)) goto l_0x100a_209e; /* jge 0x100a209e */
            ii(0x100a_2093, 6); lea(eax, ebp - 0x390);                  /* lea eax, [ebp-0x390] */
            ii(0x100a_2099, 5); call(0x100a_1341, -0xd5d);              /* call 0x100a1341 */
        l_0x100a_209e:
            ii(0x100a_209e, 7); movsx(eax, memw[ss, ebp - 0x364]);      /* movsx eax, word [ebp-0x364] */
            ii(0x100a_20a5, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_20a7, 2); if(jl(0x100a_20b4, 0xb)) goto l_0x100a_20b4; /* jl 0x100a20b4 */
            ii(0x100a_20a9, 7); movsx(eax, memw[ss, ebp - 0x362]);      /* movsx eax, word [ebp-0x362] */
            ii(0x100a_20b0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_20b2, 2); if(jge(0x100a_20b6, 0x2)) goto l_0x100a_20b6; /* jge 0x100a20b6 */
        l_0x100a_20b4:
            ii(0x100a_20b4, 2); jmp(0x100a_20c1, 0xb); goto l_0x100a_20c1; /* jmp 0x100a20c1 */
        l_0x100a_20b6:
            ii(0x100a_20b6, 7); movsx(eax, memw[ss, ebp - 0x360]);      /* movsx eax, word [ebp-0x360] */
            ii(0x100a_20bd, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_20bf, 2); if(jge(0x100a_20c3, 0x2)) goto l_0x100a_20c3; /* jge 0x100a20c3 */
        l_0x100a_20c1:
            ii(0x100a_20c1, 2); jmp(0x100a_20ce, 0xb); goto l_0x100a_20ce; /* jmp 0x100a20ce */
        l_0x100a_20c3:
            ii(0x100a_20c3, 7); movsx(eax, memw[ss, ebp - 0x35e]);      /* movsx eax, word [ebp-0x35e] */
            ii(0x100a_20ca, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_20cc, 2); if(jge(0x100a_20d0, 0x2)) goto l_0x100a_20d0; /* jge 0x100a20d0 */
        l_0x100a_20ce:
            ii(0x100a_20ce, 2); jmp(0x100a_20df, 0xf); goto l_0x100a_20df; /* jmp 0x100a20df */
        l_0x100a_20d0:
            ii(0x100a_20d0, 7); movsx(eax, memw[ss, ebp - 0x366]);      /* movsx eax, word [ebp-0x366] */
            ii(0x100a_20d7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_20d9, 6); if(jge(0x100a_2197, 0xb8)) goto l_0x100a_2197; /* jge 0x100a2197 */
        l_0x100a_20df:
            ii(0x100a_20df, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_20e1, 6); lea(eax, ebp - 0x34c);                  /* lea eax, [ebp-0x34c] */
            ii(0x100a_20e7, 5); call(0x1013_ad11, 0x9_8c25);            /* call 0x1013ad11 */
            ii(0x100a_20ec, 2); test(al, al);                           /* test al, al */
            ii(0x100a_20ee, 2); if(jnz(0x100a_2113, 0x23)) goto l_0x100a_2113; /* jnz 0x100a2113 */
            ii(0x100a_20f0, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100a_20f5, 6); lea(eax, ebp - 0x34c);                  /* lea eax, [ebp-0x34c] */
            ii(0x100a_20fb, 5); call(0x1007_65d0, -0x2_bb30);           /* call 0x100765d0 */
            ii(0x100a_2100, 6); lea(ecx, ebp - 0x390);                  /* lea ecx, [ebp-0x390] */
            ii(0x100a_2106, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_2108, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x100a_210a, 5); call(0x100a_1460, -0xcaf);              /* call 0x100a1460 */
            ii(0x100a_210f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_2111, 2); if(jnz(0x100a_212c, 0x19)) goto l_0x100a_212c; /* jnz 0x100a212c */
        l_0x100a_2113:
            ii(0x100a_2113, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100a_2118, 5); mov(edx, 0x1d);                         /* mov edx, 0x1d */
            ii(0x100a_211d, 6); lea(eax, ebp - 0x390);                  /* lea eax, [ebp-0x390] */
            ii(0x100a_2123, 5); call(0x100a_1c16, -0x512);              /* call 0x100a1c16 */
            ii(0x100a_2128, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_212a, 2); if(jz(0x100a_212e, 0x2)) goto l_0x100a_212e; /* jz 0x100a212e */
        l_0x100a_212c:
            ii(0x100a_212c, 2); jmp(0x100a_2147, 0x19); goto l_0x100a_2147; /* jmp 0x100a2147 */
        l_0x100a_212e:
            ii(0x100a_212e, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100a_2133, 5); mov(edx, 0x1e);                         /* mov edx, 0x1e */
            ii(0x100a_2138, 6); lea(eax, ebp - 0x390);                  /* lea eax, [ebp-0x390] */
            ii(0x100a_213e, 5); call(0x100a_1c16, -0x52d);              /* call 0x100a1c16 */
            ii(0x100a_2143, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_2145, 2); if(jz(0x100a_2149, 0x2)) goto l_0x100a_2149; /* jz 0x100a2149 */
        l_0x100a_2147:
            ii(0x100a_2147, 2); jmp(0x100a_215f, 0x16); goto l_0x100a_215f; /* jmp 0x100a215f */
        l_0x100a_2149:
            ii(0x100a_2149, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100a_214e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_2150, 6); lea(eax, ebp - 0x390);                  /* lea eax, [ebp-0x390] */
            ii(0x100a_2156, 5); call(0x100a_1c16, -0x545);              /* call 0x100a1c16 */
            ii(0x100a_215b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_215d, 2); if(jz(0x100a_2161, 0x2)) goto l_0x100a_2161; /* jz 0x100a2161 */
        l_0x100a_215f:
            ii(0x100a_215f, 2); jmp(0x100a_2175, 0x14); goto l_0x100a_2175; /* jmp 0x100a2175 */
        l_0x100a_2161:
            ii(0x100a_2161, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100a_2166, 6); lea(eax, ebp - 0x390);                  /* lea eax, [ebp-0x390] */
            ii(0x100a_216c, 5); call(0x100a_15dd, -0xb94);              /* call 0x100a15dd */
            ii(0x100a_2171, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_2173, 2); if(jz(0x100a_2177, 0x2)) goto l_0x100a_2177; /* jz 0x100a2177 */
        l_0x100a_2175:
            ii(0x100a_2175, 2); jmp(0x100a_2186, 0xf); goto l_0x100a_2186; /* jmp 0x100a2186 */
        l_0x100a_2177:
            ii(0x100a_2177, 6); lea(eax, ebp - 0x390);                  /* lea eax, [ebp-0x390] */
            ii(0x100a_217d, 5); call(0x100a_16dc, -0xaa6);              /* call 0x100a16dc */
            ii(0x100a_2182, 2); test(al, al);                           /* test al, al */
            ii(0x100a_2184, 2); if(jz(0x100a_2188, 0x2)) goto l_0x100a_2188; /* jz 0x100a2188 */
        l_0x100a_2186:
            ii(0x100a_2186, 2); jmp(0x100a_2197, 0xf); goto l_0x100a_2197; /* jmp 0x100a2197 */
        l_0x100a_2188:
            ii(0x100a_2188, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_218a, 6); lea(eax, ebp - 0x390);                  /* lea eax, [ebp-0x390] */
            ii(0x100a_2190, 5); call(0x100a_a698, 0x8503);              /* call 0x100aa698 */
            ii(0x100a_2195, 2); jmp(0x100a_21fe, 0x67); goto l_0x100a_21fe; /* jmp 0x100a21fe */
        l_0x100a_2197:
            ii(0x100a_2197, 5); jmp(0x100a_1f6f, -0x22d); goto l_0x100a_1f6f; /* jmp 0x100a1f6f */
        l_0x100a_219c:
            ii(0x100a_219c, 6); lea(eax, ebp - 0x390);                  /* lea eax, [ebp-0x390] */
            ii(0x100a_21a2, 5); call(0x100a_04b1, -0x1cf6);             /* call 0x100a04b1 */
            ii(0x100a_21a7, 6); lea(eax, ebp - 0x390);                  /* lea eax, [ebp-0x390] */
            ii(0x100a_21ad, 5); call(0x100a_08ce, -0x18e4);             /* call 0x100a08ce */
            ii(0x100a_21b2, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_21b5, 5); call(0x1007_35ac, -0x2_ec0e);           /* call 0x100735ac */
            ii(0x100a_21ba, 7); cmp(memd[ds, 0x101c_5624], 0);          /* cmp dword [0x101c5624], 0x0 */
            ii(0x100a_21c1, 2); if(jz(0x100a_21d2, 0xf)) goto l_0x100a_21d2; /* jz 0x100a21d2 */
            ii(0x100a_21c3, 4); movsx(edx, memw[ss, ebp - 0x8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100a_21c7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_21c9, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x100a_21ce, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100a_21d0, 2); if(jz(0x100a_21d4, 0x2)) goto l_0x100a_21d4; /* jz 0x100a21d4 */
        l_0x100a_21d2:
            ii(0x100a_21d2, 2); jmp(0x100a_21e0, 0xc); goto l_0x100a_21e0; /* jmp 0x100a21e0 */
        l_0x100a_21d4:
            ii(0x100a_21d4, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100a_21d7, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100a_21db, 5); call(0x1012_8d78, 0x8_6b98);            /* call 0x10128d78 */
        l_0x100a_21e0:
            ii(0x100a_21e0, 4); cmp(memb[ss, ebp - 0x4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100a_21e4, 2); if(jz(0x100a_21f1, 0xb)) goto l_0x100a_21f1; /* jz 0x100a21f1 */
            ii(0x100a_21e6, 6); lea(eax, ebp - 0x390);                  /* lea eax, [ebp-0x390] */
            ii(0x100a_21ec, 5); call(0x100a_1dca, -0x427);              /* call 0x100a1dca */
        l_0x100a_21f1:
            ii(0x100a_21f1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_21f3, 6); lea(eax, ebp - 0x390);                  /* lea eax, [ebp-0x390] */
            ii(0x100a_21f9, 5); call(0x100a_a698, 0x849a);              /* call 0x100aa698 */
        l_0x100a_21fe:
            ii(0x100a_21fe, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_2200, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_2201, 1); pop(edi);                               /* pop edi */
            ii(0x100a_2202, 1); pop(esi);                               /* pop esi */
            ii(0x100a_2203, 1); ret();                                  /* ret */
        }
    }
}
