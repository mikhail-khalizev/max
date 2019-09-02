using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_e8c5-8f7768cd")]
        public void Method_1007_e8c5()
        {
            ii(0x1007_e8c5, 5); push(0x118);                            /* push 0x118 */
            ii(0x1007_e8ca, 5); call(Definitions.sys_check_available_stack_size, 0xe_7483); /* call 0x10165d52 */
            ii(0x1007_e8cf, 1); push(ebx);                              /* push ebx */
            ii(0x1007_e8d0, 1); push(ecx);                              /* push ecx */
            ii(0x1007_e8d1, 1); push(edx);                              /* push edx */
            ii(0x1007_e8d2, 1); push(esi);                              /* push esi */
            ii(0x1007_e8d3, 1); push(edi);                              /* push edi */
            ii(0x1007_e8d4, 1); push(ebp);                              /* push ebp */
            ii(0x1007_e8d5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_e8d7, 6); sub(esp, 0xfc);                         /* sub esp, 0xfc */
            ii(0x1007_e8dd, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1007_e8e0, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x1007_e8e5, 5); call(0x1007_6338, -0x85b2);             /* call 0x10076338 */
            ii(0x1007_e8ea, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_e8ec, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x1007_e8ef, 5); call(0x1007_64b8, -0x843c);             /* call 0x100764b8 */
            ii(0x1007_e8f4, 4); or(memb[ss, ebp - 8], 1);               /* or byte [ebp-0x8], 0x1 */
            ii(0x1007_e8f8, 3); lea(eax, memd[ss, ebp - 0x38]);         /* lea eax, [ebp-0x38] */
            ii(0x1007_e8fb, 5); call(0x1008_a958, 0xc058);              /* call 0x1008a958 */
            ii(0x1007_e900, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x1007_e903, 4); and(memb[ss, ebp - 8], -2 /* 0xfe */);  /* and byte [ebp-0x8], 0xfe */
            ii(0x1007_e907, 5); mov(ebx, 0xba);                         /* mov ebx, 0xba */
            ii(0x1007_e90c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_e90e, 6); lea(eax, memd[ss, ebp - 0xf8]);         /* lea eax, [ebp-0xf8] */
            ii(0x1007_e914, 5); call(Definitions.sys_memset, 0xe_74c7); /* call 0x10165de0 */
            ii(0x1007_e919, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_e91c, 3); mov(eax, memd[ds, eax + 7]);            /* mov eax, [eax+0x7] */
            ii(0x1007_e91f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_e922, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x1007_e928, 5); mov(edx, 0x101c_31c4);                  /* mov edx, 0x101c31c4 */
            ii(0x1007_e92d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_e92f, 5); call(0x1008_a094, 0xb760);              /* call 0x1008a094 */
            ii(0x1007_e934, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1007_e937, 7); mov(memd[ss, ebp - 0x24], 0);           /* mov dword [ebp-0x24], 0x0 */
            ii(0x1007_e93e, 2); jmp(0x1007_e946, 6); goto l_0x1007_e946; /* jmp 0x1007e946 */
        l_0x1007_e940:
            ii(0x1007_e940, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1007_e943, 3); inc(memd[ss, ebp - 0x24]);              /* inc dword [ebp-0x24] */
        l_0x1007_e946:
            ii(0x1007_e946, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1007_e94a, 3); cmp(eax, 8);                            /* cmp eax, 0x8 */
            ii(0x1007_e94d, 2); if(jge(0x1007_e968, 0x19)) goto l_0x1007_e968; /* jge 0x1007e968 */
            ii(0x1007_e94f, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1007_e952, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1007_e956, 3); imul(eax, eax, 0x16);                   /* imul eax, eax, 0x16 */
            ii(0x1007_e959, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1007_e95c, 3); add(ebx, 0x21);                         /* add ebx, 0x21 */
            ii(0x1007_e95f, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1007_e961, 5); call(0x1007_d3e6, -0x1580);             /* call 0x1007d3e6 */
            ii(0x1007_e966, 2); jmp(0x1007_e940, -0x28); goto l_0x1007_e940; /* jmp 0x1007e940 */
        l_0x1007_e968:
            ii(0x1007_e968, 5); mov(eax, 0x1d);                         /* mov eax, 0x1d */
            ii(0x1007_e96d, 5); call(Definitions.sys_new, 0xe_748e);    /* call 0x10165e00 */
            ii(0x1007_e972, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x1007_e975, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_e978, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1007_e97b, 4); cmp(memd[ss, ebp - 0x2c], 0);           /* cmp dword [ebp-0x2c], 0x0 */
            ii(0x1007_e97f, 2); if(jz(0x1007_e9a0, 0x1f)) goto l_0x1007_e9a0; /* jz 0x1007e9a0 */
            ii(0x1007_e981, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1007_e984, 3); add(ebx, 0x1d);                         /* add ebx, 0x1d */
            ii(0x1007_e987, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1007_e98a, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_e98d, 5); call(Definitions.my_ctor_c12, 0x2_76da); /* call 0x100a606c */
            ii(0x1007_e992, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x1007_e995, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1007_e998, 6); mov(memd[ss, ebp - 0xfc], eax);         /* mov [ebp-0xfc], eax */
            ii(0x1007_e99e, 2); jmp(0x1007_e9a9, 9); goto l_0x1007_e9a9; /* jmp 0x1007e9a9 */
        l_0x1007_e9a0:
            ii(0x1007_e9a0, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x1007_e9a3, 6); mov(memd[ss, ebp - 0xfc], eax);         /* mov [ebp-0xfc], eax */
        l_0x1007_e9a9:
            ii(0x1007_e9a9, 6); mov(edx, memd[ss, ebp - 0xfc]);         /* mov edx, [ebp-0xfc] */
            ii(0x1007_e9af, 3); lea(eax, memd[ss, ebp - 0x38]);         /* lea eax, [ebp-0x38] */
            ii(0x1007_e9b2, 5); call(0x1008_a898, 0xbee1);              /* call 0x1008a898 */
            ii(0x1007_e9b7, 7); mov(memd[ss, ebp - 0x14], 0);           /* mov dword [ebp-0x14], 0x0 */
            ii(0x1007_e9be, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1007_e9c5, 2); jmp(0x1007_e9cf, 8); goto l_0x1007_e9cf; /* jmp 0x1007e9cf */
        l_0x1007_e9c7:
            ii(0x1007_e9c7, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x1007_e9ca, 5); call(0x1007_6bf8, -0x7dd7);             /* call 0x10076bf8 */
        l_0x1007_e9cf:
            ii(0x1007_e9cf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_e9d1, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x1007_e9d4, 5); call(0x1013_ad71, 0xb_c398);            /* call 0x1013ad71 */
            ii(0x1007_e9d9, 2); test(al, al);                           /* test al, al */
            ii(0x1007_e9db, 2); if(jz(0x1007_ea3c, 0x5f)) goto l_0x1007_ea3c; /* jz 0x1007ea3c */
            ii(0x1007_e9dd, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x1007_e9e0, 5); call(0x1007_63a0, -0x8645);             /* call 0x100763a0 */
            ii(0x1007_e9e5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_e9e7, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x1007_e9ea, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_e9ed, 3); mov(eax, memd[ds, eax + 7]);            /* mov eax, [eax+0x7] */
            ii(0x1007_e9f0, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_e9f3, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_e9f5, 2); if(jnz(0x1007_ea05, 0xe)) goto l_0x1007_ea05; /* jnz 0x1007ea05 */
            ii(0x1007_e9f7, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x1007_e9fa, 5); call(0x1007_63a0, -0x865f);             /* call 0x100763a0 */
            ii(0x1007_e9ff, 4); test(memb[ds, eax + 0x12], 0x10);       /* test byte [eax+0x12], 0x10 */
            ii(0x1007_ea03, 2); if(jnz(0x1007_ea07, 2)) goto l_0x1007_ea07; /* jnz 0x1007ea07 */
        l_0x1007_ea05:
            ii(0x1007_ea05, 2); jmp(0x1007_ea3a, 0x33); goto l_0x1007_ea3a; /* jmp 0x1007ea3a */
        l_0x1007_ea07:
            ii(0x1007_ea07, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x1007_ea0a, 5); call(0x1007_63d4, -0x863b);             /* call 0x100763d4 */
            ii(0x1007_ea0f, 5); call(0x1007_e344, -0x6d0);              /* call 0x1007e344 */
            ii(0x1007_ea14, 2); test(al, al);                           /* test al, al */
            ii(0x1007_ea16, 2); if(jz(0x1007_ea2a, 0x12)) goto l_0x1007_ea2a; /* jz 0x1007ea2a */
            ii(0x1007_ea18, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x1007_ea1b, 5); call(0x1007_63a0, -0x8680);             /* call 0x100763a0 */
            ii(0x1007_ea20, 5); call(0x1015_09a6, 0xd_1f81);            /* call 0x101509a6 */
            ii(0x1007_ea25, 3); add(memd[ss, ebp - 0x10], eax);         /* add [ebp-0x10], eax */
            ii(0x1007_ea28, 2); jmp(0x1007_ea3a, 0x10); goto l_0x1007_ea3a; /* jmp 0x1007ea3a */
        l_0x1007_ea2a:
            ii(0x1007_ea2a, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x1007_ea2d, 5); call(0x1007_63a0, -0x8692);             /* call 0x100763a0 */
            ii(0x1007_ea32, 5); call(0x1015_09a6, 0xd_1f6f);            /* call 0x101509a6 */
            ii(0x1007_ea37, 3); add(memd[ss, ebp - 0x14], eax);         /* add [ebp-0x14], eax */
        l_0x1007_ea3a:
            ii(0x1007_ea3a, 2); jmp(0x1007_e9c7, -0x75); goto l_0x1007_e9c7; /* jmp 0x1007e9c7 */
        l_0x1007_ea3c:
            ii(0x1007_ea3c, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1007_ea41, 5); call(0x1007_6338, -0x870e);             /* call 0x10076338 */
            ii(0x1007_ea46, 3); lea(ebx, memd[ss, ebp - 0x3c]);         /* lea ebx, [ebp-0x3c] */
            ii(0x1007_ea49, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_ea4b, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1007_ea4d, 5); call(0x1007_643c, -0x8616);             /* call 0x1007643c */
            ii(0x1007_ea52, 2); jmp(0x1007_ea5c, 8); goto l_0x1007_ea5c; /* jmp 0x1007ea5c */
        l_0x1007_ea54:
            ii(0x1007_ea54, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x1007_ea57, 5); call(0x1007_6bf8, -0x7e64);             /* call 0x10076bf8 */
        l_0x1007_ea5c:
            ii(0x1007_ea5c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_ea5e, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x1007_ea61, 5); call(0x1013_ad71, 0xb_c30b);            /* call 0x1013ad71 */
            ii(0x1007_ea66, 2); test(al, al);                           /* test al, al */
            ii(0x1007_ea68, 2); if(jz(0x1007_ea9e, 0x34)) goto l_0x1007_ea9e; /* jz 0x1007ea9e */
            ii(0x1007_ea6a, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x1007_ea6d, 5); call(0x1007_63a0, -0x86d2);             /* call 0x100763a0 */
            ii(0x1007_ea72, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_ea74, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x1007_ea77, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_ea7a, 3); mov(eax, memd[ds, eax + 7]);            /* mov eax, [eax+0x7] */
            ii(0x1007_ea7d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_ea80, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_ea82, 2); if(jnz(0x1007_ea9c, 0x18)) goto l_0x1007_ea9c; /* jnz 0x1007ea9c */
            ii(0x1007_ea84, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x1007_ea87, 5); call(0x1007_63a0, -0x86ec);             /* call 0x100763a0 */
            ii(0x1007_ea8c, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x1007_ea8f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_ea92, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1007_ea94, 8); inc(memw[ds, eax + ebp - 0xf8]);        /* inc word [eax+ebp-0xf8] */
        l_0x1007_ea9c:
            ii(0x1007_ea9c, 2); jmp(0x1007_ea54, -0x4a); goto l_0x1007_ea54; /* jmp 0x1007ea54 */
        l_0x1007_ea9e:
            ii(0x1007_ea9e, 6); mov(eax, memd[ss, ebp - 0xc2]);         /* mov eax, [ebp-0xc2] */
            ii(0x1007_eaa4, 7); inc(memw[ss, ebp - 0xc2]);              /* inc word [ebp-0xc2] */
            ii(0x1007_eaab, 6); mov(eax, memd[ss, ebp - 0xc6]);         /* mov eax, [ebp-0xc6] */
            ii(0x1007_eab1, 7); inc(memw[ss, ebp - 0xc6]);              /* inc word [ebp-0xc6] */
            ii(0x1007_eab8, 6); mov(eax, memd[ss, ebp - 0xc8]);         /* mov eax, [ebp-0xc8] */
            ii(0x1007_eabe, 7); inc(memw[ss, ebp - 0xc8]);              /* inc word [ebp-0xc8] */
            ii(0x1007_eac5, 6); mov(eax, memd[ss, ebp - 0xca]);         /* mov eax, [ebp-0xca] */
            ii(0x1007_eacb, 7); inc(memw[ss, ebp - 0xca]);              /* inc word [ebp-0xca] */
            ii(0x1007_ead2, 6); mov(eax, memd[ss, ebp - 0xb8]);         /* mov eax, [ebp-0xb8] */
            ii(0x1007_ead8, 7); inc(memw[ss, ebp - 0xb8]);              /* inc word [ebp-0xb8] */
            ii(0x1007_eadf, 7); mov(memd[ss, ebp - 0x24], 0);           /* mov dword [ebp-0x24], 0x0 */
            ii(0x1007_eae6, 2); jmp(0x1007_eaee, 6); goto l_0x1007_eaee; /* jmp 0x1007eaee */
        l_0x1007_eae8:
            ii(0x1007_eae8, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1007_eaeb, 3); inc(memd[ss, ebp - 0x24]);              /* inc dword [ebp-0x24] */
        l_0x1007_eaee:
            ii(0x1007_eaee, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1007_eaf2, 3); cmp(eax, 8);                            /* cmp eax, 0x8 */
            ii(0x1007_eaf5, 2); if(jge(0x1007_eb13, 0x1c)) goto l_0x1007_eb13; /* jge 0x1007eb13 */
            ii(0x1007_eaf7, 6); lea(edx, memd[ss, ebp - 0xf8]);         /* lea edx, [ebp-0xf8] */
            ii(0x1007_eafd, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1007_eb01, 3); imul(ebx, eax, 0x16);                   /* imul ebx, eax, 0x16 */
            ii(0x1007_eb04, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_eb07, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1007_eb0a, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1007_eb0c, 5); call(0x1007_d63e, -0x14d3);             /* call 0x1007d63e */
            ii(0x1007_eb11, 2); jmp(0x1007_eae8, -0x2b); goto l_0x1007_eae8; /* jmp 0x1007eae8 */
        l_0x1007_eb13:
            ii(0x1007_eb13, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1007_eb17, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1007_eb1b, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_eb1d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_eb1f, 6); if(jle(0x1007_ec10, 0xeb)) goto l_0x1007_ec10; /* jle 0x1007ec10 */
            ii(0x1007_eb25, 7); mov(memd[ss, ebp - 0x20], 0);           /* mov dword [ebp-0x20], 0x0 */
            ii(0x1007_eb2c, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x1007_eb31, 5); call(0x1007_6338, -0x87fe);             /* call 0x10076338 */
            ii(0x1007_eb36, 3); lea(ebx, memd[ss, ebp - 0x3c]);         /* lea ebx, [ebp-0x3c] */
            ii(0x1007_eb39, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_eb3b, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1007_eb3d, 5); call(0x1007_643c, -0x8706);             /* call 0x1007643c */
            ii(0x1007_eb42, 2); jmp(0x1007_eb4c, 8); goto l_0x1007_eb4c; /* jmp 0x1007eb4c */
        l_0x1007_eb44:
            ii(0x1007_eb44, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x1007_eb47, 5); call(0x1007_6bf8, -0x7f54);             /* call 0x10076bf8 */
        l_0x1007_eb4c:
            ii(0x1007_eb4c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_eb4e, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x1007_eb51, 5); call(0x1013_ad71, 0xb_c21b);            /* call 0x1013ad71 */
            ii(0x1007_eb56, 2); test(al, al);                           /* test al, al */
            ii(0x1007_eb58, 2); if(jz(0x1007_eb9a, 0x40)) goto l_0x1007_eb9a; /* jz 0x1007eb9a */
            ii(0x1007_eb5a, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x1007_eb5d, 5); call(0x1007_63a0, -0x87c2);             /* call 0x100763a0 */
            ii(0x1007_eb62, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_eb64, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x1007_eb67, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1007_eb6b, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_eb6d, 2); if(jnz(0x1007_eb86, 0x17)) goto l_0x1007_eb86; /* jnz 0x1007eb86 */
            ii(0x1007_eb6f, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x1007_eb72, 5); call(0x1007_63a0, -0x87d7);             /* call 0x100763a0 */
            ii(0x1007_eb77, 5); call(0x1007_623c, -0x8940);             /* call 0x1007623c */
            ii(0x1007_eb7c, 3); mov(eax, memd[ds, eax + 0xc]);          /* mov eax, [eax+0xc] */
            ii(0x1007_eb7f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_eb82, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_eb84, 2); if(jg(0x1007_eb88, 2)) goto l_0x1007_eb88; /* jg 0x1007eb88 */
        l_0x1007_eb86:
            ii(0x1007_eb86, 2); jmp(0x1007_eb98, 0x10); goto l_0x1007_eb98; /* jmp 0x1007eb98 */
        l_0x1007_eb88:
            ii(0x1007_eb88, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x1007_eb8b, 5); call(0x1007_63a0, -0x87f0);             /* call 0x100763a0 */
            ii(0x1007_eb90, 5); call(0x1015_09a6, 0xd_1e11);            /* call 0x101509a6 */
            ii(0x1007_eb95, 3); add(memd[ss, ebp - 0x20], eax);         /* add [ebp-0x20], eax */
        l_0x1007_eb98:
            ii(0x1007_eb98, 2); jmp(0x1007_eb44, -0x56); goto l_0x1007_eb44; /* jmp 0x1007eb44 */
        l_0x1007_eb9a:
            ii(0x1007_eb9a, 6); lea(ecx, memd[ss, ebp - 0xf8]);         /* lea ecx, [ebp-0xf8] */
            ii(0x1007_eba0, 3); lea(eax, memd[ss, ebp - 0x38]);         /* lea eax, [ebp-0x38] */
            ii(0x1007_eba3, 5); call(0x1008_a838, 0xbc90);              /* call 0x1008a838 */
            ii(0x1007_eba8, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1007_ebaa, 4); movsx(eax, memw[ss, ebp - 0x20]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1007_ebae, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1007_ebb2, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1007_ebb5, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1007_ebb9, 4); movsx(esi, memw[ss, ebp - 0x10]);       /* movsx esi, word [ebp-0x10] */
            ii(0x1007_ebbd, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x1007_ebbf, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1007_ebc1, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1007_ebc4, 2); idiv(esi);                              /* idiv esi */
            ii(0x1007_ebc6, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1007_ebc9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_ebcc, 3); add(eax, 0x4d);                         /* add eax, 0x4d */
            ii(0x1007_ebcf, 5); call(0x1007_d6bb, -0x1519);             /* call 0x1007d6bb */
            ii(0x1007_ebd4, 6); lea(ecx, memd[ss, ebp - 0xf8]);         /* lea ecx, [ebp-0xf8] */
            ii(0x1007_ebda, 3); lea(eax, memd[ss, ebp - 0x38]);         /* lea eax, [ebp-0x38] */
            ii(0x1007_ebdd, 5); call(0x1008_a838, 0xbc56);              /* call 0x1008a838 */
            ii(0x1007_ebe2, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1007_ebe4, 4); movsx(eax, memw[ss, ebp - 0x20]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1007_ebe8, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1007_ebec, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1007_ebef, 4); movsx(esi, memw[ss, ebp - 0x14]);       /* movsx esi, word [ebp-0x14] */
            ii(0x1007_ebf3, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1007_ebf7, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x1007_ebf9, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1007_ebfb, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1007_ebfe, 2); idiv(esi);                              /* idiv esi */
            ii(0x1007_ec00, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1007_ec03, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_ec06, 5); add(eax, 0xbb);                         /* add eax, 0xbb */
            ii(0x1007_ec0b, 5); call(0x1007_d6bb, -0x1555);             /* call 0x1007d6bb */
        l_0x1007_ec10:
            ii(0x1007_ec10, 7); mov(memd[ss, ebp - 0x14], 0);           /* mov dword [ebp-0x14], 0x0 */
            ii(0x1007_ec17, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1007_ec1e, 7); mov(memd[ss, ebp - 0x1c], 0);           /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1007_ec25, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
            ii(0x1007_ec2c, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x1007_ec31, 5); call(0x1007_6338, -0x88fe);             /* call 0x10076338 */
            ii(0x1007_ec36, 3); lea(ebx, memd[ss, ebp - 0x3c]);         /* lea ebx, [ebp-0x3c] */
            ii(0x1007_ec39, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_ec3b, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1007_ec3d, 5); call(0x1007_643c, -0x8806);             /* call 0x1007643c */
            ii(0x1007_ec42, 2); jmp(0x1007_ec4c, 8); goto l_0x1007_ec4c; /* jmp 0x1007ec4c */
        l_0x1007_ec44:
            ii(0x1007_ec44, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x1007_ec47, 5); call(0x1007_6bf8, -0x8054);             /* call 0x10076bf8 */
        l_0x1007_ec4c:
            ii(0x1007_ec4c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_ec4e, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x1007_ec51, 5); call(0x1013_ad71, 0xb_c11b);            /* call 0x1013ad71 */
            ii(0x1007_ec56, 2); test(al, al);                           /* test al, al */
            ii(0x1007_ec58, 6); if(jz(0x1007_ed06, 0xa8)) goto l_0x1007_ed06; /* jz 0x1007ed06 */
            ii(0x1007_ec5e, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x1007_ec61, 5); call(0x1007_63a0, -0x88c6);             /* call 0x100763a0 */
            ii(0x1007_ec66, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_ec68, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x1007_ec6b, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1007_ec6f, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_ec71, 2); if(jnz(0x1007_ec8a, 0x17)) goto l_0x1007_ec8a; /* jnz 0x1007ec8a */
            ii(0x1007_ec73, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x1007_ec76, 5); call(0x1007_63a0, -0x88db);             /* call 0x100763a0 */
            ii(0x1007_ec7b, 5); call(0x1007_623c, -0x8a44);             /* call 0x1007623c */
            ii(0x1007_ec80, 3); mov(eax, memd[ds, eax + 0xc]);          /* mov eax, [eax+0xc] */
            ii(0x1007_ec83, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_ec86, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_ec88, 2); if(jg(0x1007_ec8f, 5)) goto l_0x1007_ec8f; /* jg 0x1007ec8f */
        l_0x1007_ec8a:
            ii(0x1007_ec8a, 5); jmp(0x1007_ed01, 0x72); goto l_0x1007_ed01; /* jmp 0x1007ed01 */
        l_0x1007_ec8f:
            ii(0x1007_ec8f, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x1007_ec92, 5); call(0x1007_63a0, -0x88f7);             /* call 0x100763a0 */
            ii(0x1007_ec97, 5); cmp(memw[ds, eax + 8], 0x42);           /* cmp word [eax+0x8], 0x42 */
            ii(0x1007_ec9c, 2); if(jnz(0x1007_ecb0, 0x12)) goto l_0x1007_ecb0; /* jnz 0x1007ecb0 */
            ii(0x1007_ec9e, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x1007_eca1, 5); call(0x1007_63a0, -0x8906);             /* call 0x100763a0 */
            ii(0x1007_eca6, 5); call(0x1015_09a6, 0xd_1cfb);            /* call 0x101509a6 */
            ii(0x1007_ecab, 3); add(memd[ss, ebp - 0x1c], eax);         /* add [ebp-0x1c], eax */
            ii(0x1007_ecae, 2); jmp(0x1007_ed01, 0x51); goto l_0x1007_ed01; /* jmp 0x1007ed01 */
        l_0x1007_ecb0:
            ii(0x1007_ecb0, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x1007_ecb3, 5); call(0x1007_63a0, -0x8918);             /* call 0x100763a0 */
            ii(0x1007_ecb8, 5); cmp(memw[ds, eax + 8], 0x47);           /* cmp word [eax+0x8], 0x47 */
            ii(0x1007_ecbd, 2); if(jnz(0x1007_ecd1, 0x12)) goto l_0x1007_ecd1; /* jnz 0x1007ecd1 */
            ii(0x1007_ecbf, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x1007_ecc2, 5); call(0x1007_63a0, -0x8927);             /* call 0x100763a0 */
            ii(0x1007_ecc7, 5); call(0x1015_09a6, 0xd_1cda);            /* call 0x101509a6 */
            ii(0x1007_eccc, 3); add(memd[ss, ebp - 0xc], eax);          /* add [ebp-0xc], eax */
            ii(0x1007_eccf, 2); jmp(0x1007_ed01, 0x30); goto l_0x1007_ed01; /* jmp 0x1007ed01 */
        l_0x1007_ecd1:
            ii(0x1007_ecd1, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x1007_ecd4, 5); call(0x1007_63a0, -0x8939);             /* call 0x100763a0 */
            ii(0x1007_ecd9, 4); test(memb[ds, eax + 0x12], 0x80);       /* test byte [eax+0x12], 0x80 */
            ii(0x1007_ecdd, 2); if(jz(0x1007_ecf1, 0x12)) goto l_0x1007_ecf1; /* jz 0x1007ecf1 */
            ii(0x1007_ecdf, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x1007_ece2, 5); call(0x1007_63a0, -0x8947);             /* call 0x100763a0 */
            ii(0x1007_ece7, 5); call(0x1015_09a6, 0xd_1cba);            /* call 0x101509a6 */
            ii(0x1007_ecec, 3); add(memd[ss, ebp - 0x10], eax);         /* add [ebp-0x10], eax */
            ii(0x1007_ecef, 2); jmp(0x1007_ed01, 0x10); goto l_0x1007_ed01; /* jmp 0x1007ed01 */
        l_0x1007_ecf1:
            ii(0x1007_ecf1, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x1007_ecf4, 5); call(0x1007_63a0, -0x8959);             /* call 0x100763a0 */
            ii(0x1007_ecf9, 5); call(0x1015_09a6, 0xd_1ca8);            /* call 0x101509a6 */
            ii(0x1007_ecfe, 3); add(memd[ss, ebp - 0x14], eax);         /* add [ebp-0x14], eax */
        l_0x1007_ed01:
            ii(0x1007_ed01, 5); jmp(0x1007_ec44, -0xc2); goto l_0x1007_ec44; /* jmp 0x1007ec44 */
        l_0x1007_ed06:
            ii(0x1007_ed06, 6); lea(ecx, memd[ss, ebp - 0xf8]);         /* lea ecx, [ebp-0xf8] */
            ii(0x1007_ed0c, 3); lea(eax, memd[ss, ebp - 0x38]);         /* lea eax, [ebp-0x38] */
            ii(0x1007_ed0f, 5); call(0x1008_a838, 0xbb24);              /* call 0x1008a838 */
            ii(0x1007_ed14, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1007_ed16, 4); movsx(edx, memw[ss, ebp - 0x1c]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x1007_ed1a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_ed1d, 3); add(eax, 0x63);                         /* add eax, 0x63 */
            ii(0x1007_ed20, 5); call(0x1007_d6bb, -0x166a);             /* call 0x1007d6bb */
            ii(0x1007_ed25, 6); lea(ecx, memd[ss, ebp - 0xf8]);         /* lea ecx, [ebp-0xf8] */
            ii(0x1007_ed2b, 3); lea(eax, memd[ss, ebp - 0x38]);         /* lea eax, [ebp-0x38] */
            ii(0x1007_ed2e, 5); call(0x1008_a838, 0xbb05);              /* call 0x1008a838 */
            ii(0x1007_ed33, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1007_ed35, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1007_ed39, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1007_ed3b, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1007_ed3e, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1007_ed40, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x1007_ed42, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1007_ed45, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_ed48, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1007_ed4b, 5); call(0x1007_d6bb, -0x1695);             /* call 0x1007d6bb */
            ii(0x1007_ed50, 6); lea(ecx, memd[ss, ebp - 0xf8]);         /* lea ecx, [ebp-0xf8] */
            ii(0x1007_ed56, 3); lea(eax, memd[ss, ebp - 0x38]);         /* lea eax, [ebp-0x38] */
            ii(0x1007_ed59, 5); call(0x1008_a838, 0xbada);              /* call 0x1008a838 */
            ii(0x1007_ed5e, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1007_ed60, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1007_ed64, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1007_ed66, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1007_ed69, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1007_ed6b, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x1007_ed6d, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1007_ed70, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_ed73, 3); add(eax, 0x37);                         /* add eax, 0x37 */
            ii(0x1007_ed76, 5); call(0x1007_d6bb, -0x16c0);             /* call 0x1007d6bb */
            ii(0x1007_ed7b, 6); lea(ecx, memd[ss, ebp - 0xf8]);         /* lea ecx, [ebp-0xf8] */
            ii(0x1007_ed81, 3); lea(eax, memd[ss, ebp - 0x38]);         /* lea eax, [ebp-0x38] */
            ii(0x1007_ed84, 5); call(0x1008_a838, 0xbaaf);              /* call 0x1008a838 */
            ii(0x1007_ed89, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1007_ed8b, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1007_ed8f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_ed92, 3); add(eax, 0x79);                         /* add eax, 0x79 */
            ii(0x1007_ed95, 5); call(0x1007_d6bb, -0x16df);             /* call 0x1007d6bb */
            ii(0x1007_ed9a, 6); lea(ecx, memd[ss, ebp - 0xf8]);         /* lea ecx, [ebp-0xf8] */
            ii(0x1007_eda0, 3); lea(eax, memd[ss, ebp - 0x38]);         /* lea eax, [ebp-0x38] */
            ii(0x1007_eda3, 5); call(0x1008_a838, 0xba90);              /* call 0x1008a838 */
            ii(0x1007_eda8, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1007_edaa, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1007_edae, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1007_edb0, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1007_edb3, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1007_edb5, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x1007_edb7, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1007_edba, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_edbd, 5); add(eax, 0x8f);                         /* add eax, 0x8f */
            ii(0x1007_edc2, 5); call(0x1007_d6bb, -0x170c);             /* call 0x1007d6bb */
            ii(0x1007_edc7, 6); lea(ecx, memd[ss, ebp - 0xf8]);         /* lea ecx, [ebp-0xf8] */
            ii(0x1007_edcd, 3); lea(eax, memd[ss, ebp - 0x38]);         /* lea eax, [ebp-0x38] */
            ii(0x1007_edd0, 5); call(0x1008_a838, 0xba63);              /* call 0x1008a838 */
            ii(0x1007_edd5, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1007_edd7, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1007_eddb, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1007_eddd, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1007_ede0, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1007_ede2, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x1007_ede4, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1007_ede7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_edea, 5); add(eax, 0xa5);                         /* add eax, 0xa5 */
            ii(0x1007_edef, 5); call(0x1007_d6bb, -0x1739);             /* call 0x1007d6bb */
            ii(0x1007_edf4, 3); lea(eax, memd[ss, ebp - 0x38]);         /* lea eax, [ebp-0x38] */
            ii(0x1007_edf7, 5); call(0x1008_a838, 0xba3c);              /* call 0x1008a838 */
            ii(0x1007_edfc, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_edfe, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1007_ee03, 5); call(0x100a_4d50, 0x2_5f48);            /* call 0x100a4d50 */
            ii(0x1007_ee08, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_ee0a, 3); lea(eax, memd[ss, ebp - 0x38]);         /* lea eax, [ebp-0x38] */
            ii(0x1007_ee0d, 5); call(0x1008_8cbc, 0x9eaa);              /* call 0x10088cbc */
            ii(0x1007_ee12, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_ee14, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x1007_ee17, 5); call(0x1007_5f6c, -0x8eb0);             /* call 0x10075f6c */
            ii(0x1007_ee1c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_ee1e, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_ee1f, 1); pop(edi);                               /* pop edi */
            ii(0x1007_ee20, 1); pop(esi);                               /* pop esi */
            ii(0x1007_ee21, 1); pop(edx);                               /* pop edx */
            ii(0x1007_ee22, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_ee23, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_ee24, 1); ret();                                  /* ret */
        }
    }
}
