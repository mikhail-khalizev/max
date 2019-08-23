using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_2023-4ddee40d")]
        public void Method_1015_2023()
        {
            ii(0x1015_2023, 5); push(0x3c);                             /* push 0x3c */
            ii(0x1015_2028, 5); call(Definitions.sys_check_available_stack_size, 0x1_3d25); /* call 0x10165d52 */
            ii(0x1015_202d, 1); push(ebx);                              /* push ebx */
            ii(0x1015_202e, 1); push(ecx);                              /* push ecx */
            ii(0x1015_202f, 1); push(esi);                              /* push esi */
            ii(0x1015_2030, 1); push(edi);                              /* push edi */
            ii(0x1015_2031, 1); push(ebp);                              /* push ebp */
            ii(0x1015_2032, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_2034, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1015_203a, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1015_203d, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1015_2040, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x1015_2044, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_2046, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_2049, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1015_204c, 5); call(0x1013_ad11, -0x1_7340);           /* call 0x1013ad11 */
            ii(0x1015_2051, 2); test(al, al);                           /* test al, al */
            ii(0x1015_2053, 2); if(jz(0x1015_206f, 0x1a)) goto l_0x1015_206f; /* jz 0x1015206f */
            ii(0x1015_2055, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_2058, 3); mov(eax, memd[ds, eax + 0x50]);         /* mov eax, [eax+0x50] */
            ii(0x1015_205b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_205e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_2060, 2); if(jle(0x1015_206d, 0xb)) goto l_0x1015_206d; /* jle 0x1015206d */
            ii(0x1015_2062, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_2065, 4); dec(memw[ds, eax + 0x52]);              /* dec word [eax+0x52] */
            ii(0x1015_2069, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
        l_0x1015_206d:
            ii(0x1015_206d, 2); jmp(0x1015_20ba, 0x4b); goto l_0x1015_20ba; /* jmp 0x101520ba */
        l_0x1015_206f:
            ii(0x1015_206f, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1015_2072, 5); call(0x1007_20b1, -0xd_ffc6);           /* call 0x100720b1 */
            ii(0x1015_2077, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1015_207a, 5); call(0x1007_20b1, -0xd_ffce);           /* call 0x100720b1 */
            ii(0x1015_207f, 3); lea(ebx, ebp - 0x24);                   /* lea ebx, [ebp-0x24] */
            ii(0x1015_2082, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x1015_2085, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_2088, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1015_208b, 5); call(0x1015_5314, 0x3284);              /* call 0x10155314 */
            ii(0x1015_2090, 5); call(0x1014_3616, -0xea7f);             /* call 0x10143616 */
            ii(0x1015_2095, 4); movsx(eax, memw[ss, ebp - 0x16]);       /* movsx eax, word [ebp-0x16] */
            ii(0x1015_2099, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_209b, 2); if(jle(0x1015_20ba, 0x1d)) goto l_0x1015_20ba; /* jle 0x101520ba */
            ii(0x1015_209d, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
            ii(0x1015_20a1, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_20a3, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_20a5, 5); mov(edx, 0xffff_ffff);                  /* mov edx, 0xffffffff */
            ii(0x1015_20aa, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_20ad, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1015_20b0, 5); call(0x1015_5314, 0x325f);              /* call 0x10155314 */
            ii(0x1015_20b5, 5); call(0x100d_7a9c, -0x7_a61e);           /* call 0x100d7a9c */
        l_0x1015_20ba:
            ii(0x1015_20ba, 4); cmp(memb[ss, ebp - 0xc], 0);            /* cmp byte [ebp-0xc], 0x0 */
            ii(0x1015_20be, 2); if(jz(0x1015_20fc, 0x3c)) goto l_0x1015_20fc; /* jz 0x101520fc */
            ii(0x1015_20c0, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1015_20c5, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_20c8, 5); call(0x1007_6d98, -0xd_b335);           /* call 0x10076d98 */
            ii(0x1015_20cd, 2); test(al, al);                           /* test al, al */
            ii(0x1015_20cf, 2); if(jz(0x1015_20e8, 0x17)) goto l_0x1015_20e8; /* jz 0x101520e8 */
            ii(0x1015_20d1, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1015_20d6, 5); mov(ebx, 0xf);                          /* mov ebx, 0xf */
            ii(0x1015_20db, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1015_20de, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1015_20e3, 5); call(0x1013_d5c0, -0x1_4b28);           /* call 0x1013d5c0 */
        l_0x1015_20e8:
            ii(0x1015_20e8, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_20eb, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1015_20ee, 5); call(0x1007_6730, -0xd_b9c3);           /* call 0x10076730 */
            ii(0x1015_20f3, 3); mov(dl, memb[ds, eax + 0x1b]);          /* mov dl, [eax+0x1b] */
            ii(0x1015_20f6, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_20f9, 3); mov(memb[ds, eax + 0x54], dl);          /* mov [eax+0x54], dl */
        l_0x1015_20fc:
            ii(0x1015_20fc, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_20ff, 5); call(0x1014_f08b, -0x3079);             /* call 0x1014f08b */
            ii(0x1015_2104, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1015_2109, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_210c, 5); call(0x1007_6d98, -0xd_b379);           /* call 0x10076d98 */
            ii(0x1015_2111, 2); test(al, al);                           /* test al, al */
            ii(0x1015_2113, 2); if(jz(0x1015_211d, 0x8)) goto l_0x1015_211d; /* jz 0x1015211d */
            ii(0x1015_2115, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_2118, 5); call(0x1010_094d, -0x5_17d0);           /* call 0x1010094d */
        l_0x1015_211d:
            ii(0x1015_211d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_211f, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_2120, 1); pop(edi);                               /* pop edi */
            ii(0x1015_2121, 1); pop(esi);                               /* pop esi */
            ii(0x1015_2122, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_2123, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_2124, 1); ret();                                  /* ret */
        }
    }
}
