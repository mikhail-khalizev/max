using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("567a116c-cda5-4312-8a82-3005d0681969")]
        public void Method_1013_1eac()
        {
            ii(0x1013_1eac, 5); pushd(0xd8);                            /* push 0xd8 */
            ii(0x1013_1eb1, 5); calld(Definitions.sys_check_available_stack_size, 0x3_3e9c); /* call 0x10165d52 */
            ii(0x1013_1eb6, 1); pushd(esi);                             /* push esi */
            ii(0x1013_1eb7, 1); pushd(edi);                             /* push edi */
            ii(0x1013_1eb8, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_1eb9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_1ebb, 6); sub(esp, 0xb4);                         /* sub esp, 0xb4 */
            ii(0x1013_1ec1, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1013_1ec4, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1013_1ec7, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x1013_1eca, 3); mov(memd_a32[ss, ebp - 0x8], ecx);      /* mov [ebp-0x8], ecx */
            ii(0x1013_1ecd, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_1ed0, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1013_1ed3, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
            ii(0x1013_1ed5, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1013_1ed8, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1013_1edb, 3); mov(memb_a32[ds, edx + 0x4], al);       /* mov [edx+0x4], al */
            ii(0x1013_1ede, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_1ee1, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1013_1ee4, 4); mov(memw_a32[ds, edx + 0x5], ax);       /* mov [edx+0x5], ax */
            ii(0x1013_1ee8, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_1eeb, 5); movsx(ax, memb_a32[ds, eax + 0x4]);     /* movsx ax, byte [eax+0x4] */
            ii(0x1013_1ef0, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1013_1ef3, 5); add(eax, 0x46);                         /* add eax, 0x46 */
            ii(0x1013_1ef8, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1013_1efb, 3); lea(edx, ebp - 0x38);                   /* lea edx, [ebp-0x38] */
            ii(0x1013_1efe, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_1f01, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1013_1f03, 5); calld(0x100d_6a11, -0x5_b4f7);          /* call 0x100d6a11 */
            ii(0x1013_1f08, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1013_1f0d, 5); calld(Definitions.sys_new, 0x3_3eee);   /* call 0x10165e00 */
            ii(0x1013_1f12, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1013_1f15, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1013_1f18, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x1013_1f1b, 4); cmp(memd_a32[ss, ebp - 0x40], 0);       /* cmp dword [ebp-0x40], 0x0 */
            ii(0x1013_1f1f, 2); if(jzd(0x1013_1f48, 0x27)) goto l_0x1013_1f48; /* jz 0x10131f48 */
            ii(0x1013_1f21, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1013_1f25, 1); pushd(eax);                             /* push eax */
            ii(0x1013_1f26, 5); mov(ecx, 0x8f);                         /* mov ecx, 0x8f */
            ii(0x1013_1f2b, 5); mov(ebx, 0x13b);                        /* mov ebx, 0x13b */
            ii(0x1013_1f30, 5); mov(edx, 0x13a);                        /* mov edx, 0x13a */
            ii(0x1013_1f35, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1013_1f38, 5); calld(Definitions.my_ctor_c17, -0x6_3b2e); /* call 0x100ce40f */
            ii(0x1013_1f3d, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x1013_1f40, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1013_1f43, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x1013_1f46, 2); jmpd(0x1013_1f4e, 0x6); goto l_0x1013_1f4e; /* jmp 0x10131f4e */
        l_0x1013_1f48:
            ii(0x1013_1f48, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x1013_1f4b, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
        l_0x1013_1f4e:
            ii(0x1013_1f4e, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x1013_1f51, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1013_1f54, 3); mov(memd_a32[ds, edx + 0x7], eax);      /* mov [edx+0x7], eax */
            ii(0x1013_1f57, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1013_1f5c, 5); calld(Definitions.sys_new, 0x3_3e9f);   /* call 0x10165e00 */
            ii(0x1013_1f61, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
            ii(0x1013_1f64, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x1013_1f67, 3); mov(memd_a32[ss, ebp - 0x50], eax);     /* mov [ebp-0x50], eax */
            ii(0x1013_1f6a, 4); cmp(memd_a32[ss, ebp - 0x50], 0);       /* cmp dword [ebp-0x50], 0x0 */
            ii(0x1013_1f6e, 2); if(jzd(0x1013_1f97, 0x27)) goto l_0x1013_1f97; /* jz 0x10131f97 */
            ii(0x1013_1f70, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1013_1f74, 1); pushd(eax);                             /* push eax */
            ii(0x1013_1f75, 5); mov(ecx, 0x48);                         /* mov ecx, 0x48 */
            ii(0x1013_1f7a, 5); mov(ebx, 0x13e);                        /* mov ebx, 0x13e */
            ii(0x1013_1f7f, 5); mov(edx, 0x13d);                        /* mov edx, 0x13d */
            ii(0x1013_1f84, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x1013_1f87, 5); calld(Definitions.my_ctor_c17, -0x6_3b7d); /* call 0x100ce40f */
            ii(0x1013_1f8c, 3); mov(memd_a32[ss, ebp - 0x54], eax);     /* mov [ebp-0x54], eax */
            ii(0x1013_1f8f, 3); mov(eax, memd_a32[ss, ebp - 0x54]);     /* mov eax, [ebp-0x54] */
            ii(0x1013_1f92, 3); mov(memd_a32[ss, ebp - 0x58], eax);     /* mov [ebp-0x58], eax */
            ii(0x1013_1f95, 2); jmpd(0x1013_1f9d, 0x6); goto l_0x1013_1f9d; /* jmp 0x10131f9d */
        l_0x1013_1f97:
            ii(0x1013_1f97, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x1013_1f9a, 3); mov(memd_a32[ss, ebp - 0x58], eax);     /* mov [ebp-0x58], eax */
        l_0x1013_1f9d:
            ii(0x1013_1f9d, 3); mov(eax, memd_a32[ss, ebp - 0x58]);     /* mov eax, [ebp-0x58] */
            ii(0x1013_1fa0, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1013_1fa3, 3); mov(memd_a32[ds, edx + 0xb], eax);      /* mov [edx+0xb], eax */
            ii(0x1013_1fa6, 3); mov(ebx, memd_a32[ss, ebp - 0x10]);     /* mov ebx, [ebp-0x10] */
            ii(0x1013_1fa9, 5); mov(edx, 0x1013_27af);                  /* mov edx, 0x101327af */
            ii(0x1013_1fae, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_1fb1, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1013_1fb4, 5); calld(0x100c_f824, -0x6_2795);          /* call 0x100cf824 */
            ii(0x1013_1fb9, 5); mov(edx, 0x13c);                        /* mov edx, 0x13c */
            ii(0x1013_1fbe, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_1fc1, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1013_1fc4, 5); calld(0x100c_f2ba, -0x6_2d0f);          /* call 0x100cf2ba */
            ii(0x1013_1fc9, 3); mov(edx, memd_a32[ss, ebp - 0x26]);     /* mov edx, [ebp-0x26] */
            ii(0x1013_1fcc, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_1fcf, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1013_1fd2, 5); calld(0x100c_e92d, -0x6_36aa);          /* call 0x100ce92d */
            ii(0x1013_1fd7, 5); calld(0x100d_51e4, -0x5_cdf8);          /* call 0x100d51e4 */
            ii(0x1013_1fdc, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_1fe1, 3); mov(memd_a32[ss, ebp - 0x5c], eax);     /* mov [ebp-0x5c], eax */
            ii(0x1013_1fe4, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_1fe7, 5); calld(0x1013_3964, 0x1978);             /* call 0x10133964 */
            ii(0x1013_1fec, 1); cwde();                                 /* cwde */
            ii(0x1013_1fed, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_1fef, 2); if(jled(0x1013_1ff7, 0x6)) goto l_0x1013_1ff7; /* jle 0x10131ff7 */
            ii(0x1013_1ff1, 4); mov(memb_a32[ss, ebp - 0x14], 0x1);     /* mov byte [ebp-0x14], 0x1 */
            ii(0x1013_1ff5, 2); jmpd(0x1013_1ffb, 0x4); goto l_0x1013_1ffb; /* jmp 0x10131ffb */
        l_0x1013_1ff7:
            ii(0x1013_1ff7, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
        l_0x1013_1ffb:
            ii(0x1013_1ffb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_1ffd, 3); mov(dl, memb_a32[ss, ebp - 0x14]);      /* mov dl, [ebp-0x14] */
            ii(0x1013_2000, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_2003, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1013_2006, 3); mov(ebx, memd_a32[ss, ebp - 0x5c]);     /* mov ebx, [ebp-0x5c] */
            ii(0x1013_2009, 5); calld(0x100c_fa7c, -0x6_2592);          /* call 0x100cfa7c */
            ii(0x1013_200e, 3); mov(edx, memd_a32[ss, ebp - 0x26]);     /* mov edx, [ebp-0x26] */
            ii(0x1013_2011, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_2014, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1013_2017, 5); calld(0x100c_f85c, -0x6_27c0);          /* call 0x100cf85c */
            ii(0x1013_201c, 3); mov(ebx, memd_a32[ss, ebp - 0x10]);     /* mov ebx, [ebp-0x10] */
            ii(0x1013_201f, 5); mov(edx, 0x1013_27ed);                  /* mov edx, 0x101327ed */
            ii(0x1013_2024, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_2027, 3); mov(eax, memd_a32[ds, eax + 0xb]);      /* mov eax, [eax+0xb] */
            ii(0x1013_202a, 5); calld(0x100c_f824, -0x6_280b);          /* call 0x100cf824 */
            ii(0x1013_202f, 5); mov(edx, 0x13f);                        /* mov edx, 0x13f */
            ii(0x1013_2034, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_2037, 3); mov(eax, memd_a32[ds, eax + 0xb]);      /* mov eax, [eax+0xb] */
            ii(0x1013_203a, 5); calld(0x100c_f2ba, -0x6_2d85);          /* call 0x100cf2ba */
            ii(0x1013_203f, 3); mov(edx, memd_a32[ss, ebp - 0x26]);     /* mov edx, [ebp-0x26] */
            ii(0x1013_2042, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_2045, 3); mov(eax, memd_a32[ds, eax + 0xb]);      /* mov eax, [eax+0xb] */
            ii(0x1013_2048, 5); calld(0x100c_e92d, -0x6_3720);          /* call 0x100ce92d */
            ii(0x1013_204d, 5); calld(0x100d_51e4, -0x5_ce6e);          /* call 0x100d51e4 */
            ii(0x1013_2052, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_2057, 3); mov(memd_a32[ss, ebp - 0x60], eax);     /* mov [ebp-0x60], eax */
            ii(0x1013_205a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_205d, 3); mov(eax, memd_a32[ds, eax + 0x3]);      /* mov eax, [eax+0x3] */
            ii(0x1013_2060, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_2063, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_2065, 2); if(jled(0x1013_206d, 0x6)) goto l_0x1013_206d; /* jle 0x1013206d */
            ii(0x1013_2067, 4); mov(memb_a32[ss, ebp - 0x18], 0x1);     /* mov byte [ebp-0x18], 0x1 */
            ii(0x1013_206b, 2); jmpd(0x1013_2071, 0x4); goto l_0x1013_2071; /* jmp 0x10132071 */
        l_0x1013_206d:
            ii(0x1013_206d, 4); mov(memb_a32[ss, ebp - 0x18], 0);       /* mov byte [ebp-0x18], 0x0 */
        l_0x1013_2071:
            ii(0x1013_2071, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_2073, 3); mov(dl, memb_a32[ss, ebp - 0x18]);      /* mov dl, [ebp-0x18] */
            ii(0x1013_2076, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_2079, 3); mov(eax, memd_a32[ds, eax + 0xb]);      /* mov eax, [eax+0xb] */
            ii(0x1013_207c, 3); mov(ebx, memd_a32[ss, ebp - 0x60]);     /* mov ebx, [ebp-0x60] */
            ii(0x1013_207f, 5); calld(0x100c_fa7c, -0x6_2608);          /* call 0x100cfa7c */
            ii(0x1013_2084, 3); mov(edx, memd_a32[ss, ebp - 0x26]);     /* mov edx, [ebp-0x26] */
            ii(0x1013_2087, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_208a, 3); mov(eax, memd_a32[ds, eax + 0xb]);      /* mov eax, [eax+0xb] */
            ii(0x1013_208d, 5); calld(0x100c_f85c, -0x6_2836);          /* call 0x100cf85c */
            ii(0x1013_2092, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1013_2097, 5); calld(Definitions.sys_new, 0x3_3d64);   /* call 0x10165e00 */
            ii(0x1013_209c, 3); mov(memd_a32[ss, ebp - 0x64], eax);     /* mov [ebp-0x64], eax */
            ii(0x1013_209f, 3); mov(eax, memd_a32[ss, ebp - 0x64]);     /* mov eax, [ebp-0x64] */
            ii(0x1013_20a2, 3); mov(memd_a32[ss, ebp - 0x68], eax);     /* mov [ebp-0x68], eax */
            ii(0x1013_20a5, 4); cmp(memd_a32[ss, ebp - 0x68], 0);       /* cmp dword [ebp-0x68], 0x0 */
            ii(0x1013_20a9, 2); if(jzd(0x1013_20d2, 0x27)) goto l_0x1013_20d2; /* jz 0x101320d2 */
            ii(0x1013_20ab, 5); mov(eax, 0x11);                         /* mov eax, 0x11 */
            ii(0x1013_20b0, 1); pushd(eax);                             /* push eax */
            ii(0x1013_20b1, 5); mov(ecx, 0x38);                         /* mov ecx, 0x38 */
            ii(0x1013_20b6, 4); movsx(ebx, memw_a32[ss, ebp - 0x1c]);   /* movsx ebx, word [ebp-0x1c] */
            ii(0x1013_20ba, 5); mov(edx, 0x57);                         /* mov edx, 0x57 */
            ii(0x1013_20bf, 3); mov(eax, memd_a32[ss, ebp - 0x64]);     /* mov eax, [ebp-0x64] */
            ii(0x1013_20c2, 5); calld(0x100c_e39d, -0x6_3d2a);          /* call 0x100ce39d */
            ii(0x1013_20c7, 3); mov(memd_a32[ss, ebp - 0x6c], eax);     /* mov [ebp-0x6c], eax */
            ii(0x1013_20ca, 3); mov(eax, memd_a32[ss, ebp - 0x6c]);     /* mov eax, [ebp-0x6c] */
            ii(0x1013_20cd, 3); mov(memd_a32[ss, ebp - 0x70], eax);     /* mov [ebp-0x70], eax */
            ii(0x1013_20d0, 2); jmpd(0x1013_20d8, 0x6); goto l_0x1013_20d8; /* jmp 0x101320d8 */
        l_0x1013_20d2:
            ii(0x1013_20d2, 3); mov(eax, memd_a32[ss, ebp - 0x68]);     /* mov eax, [ebp-0x68] */
            ii(0x1013_20d5, 3); mov(memd_a32[ss, ebp - 0x70], eax);     /* mov [ebp-0x70], eax */
        l_0x1013_20d8:
            ii(0x1013_20d8, 3); mov(eax, memd_a32[ss, ebp - 0x70]);     /* mov eax, [ebp-0x70] */
            ii(0x1013_20db, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1013_20de, 3); mov(memd_a32[ds, edx + 0xf], eax);      /* mov [edx+0xf], eax */
            ii(0x1013_20e1, 3); mov(ebx, memd_a32[ss, ebp - 0x10]);     /* mov ebx, [ebp-0x10] */
            ii(0x1013_20e4, 5); mov(edx, 0x1013_282b);                  /* mov edx, 0x1013282b */
            ii(0x1013_20e9, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_20ec, 3); mov(eax, memd_a32[ds, eax + 0xf]);      /* mov eax, [eax+0xf] */
            ii(0x1013_20ef, 5); calld(0x100c_f7ec, -0x6_2908);          /* call 0x100cf7ec */
            ii(0x1013_20f4, 3); mov(edx, memd_a32[ss, ebp - 0x26]);     /* mov edx, [ebp-0x26] */
            ii(0x1013_20f7, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_20fa, 3); mov(eax, memd_a32[ds, eax + 0xf]);      /* mov eax, [eax+0xf] */
            ii(0x1013_20fd, 5); calld(0x100c_f85c, -0x6_28a6);          /* call 0x100cf85c */
            ii(0x1013_2102, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x1013_2107, 5); calld(Definitions.sys_new, 0x3_3cf4);   /* call 0x10165e00 */
            ii(0x1013_210c, 3); mov(memd_a32[ss, ebp - 0x74], eax);     /* mov [ebp-0x74], eax */
            ii(0x1013_210f, 3); mov(eax, memd_a32[ss, ebp - 0x74]);     /* mov eax, [ebp-0x74] */
            ii(0x1013_2112, 3); mov(memd_a32[ss, ebp - 0x78], eax);     /* mov [ebp-0x78], eax */
            ii(0x1013_2115, 4); cmp(memd_a32[ss, ebp - 0x78], 0);       /* cmp dword [ebp-0x78], 0x0 */
            ii(0x1013_2119, 2); if(jzd(0x1013_2149, 0x2e)) goto l_0x1013_2149; /* jz 0x10132149 */
            ii(0x1013_211b, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x1013_2120, 1); pushd(eax);                             /* push eax */
            ii(0x1013_2121, 5); mov(ecx, 0x15);                         /* mov ecx, 0x15 */
            ii(0x1013_2126, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1013_2129, 5); add(eax, 0x3);                          /* add eax, 0x3 */
            ii(0x1013_212e, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1013_2131, 5); mov(edx, 0x26);                         /* mov edx, 0x26 */
            ii(0x1013_2136, 3); mov(eax, memd_a32[ss, ebp - 0x74]);     /* mov eax, [ebp-0x74] */
            ii(0x1013_2139, 5); calld(0x100d_7bdc, -0x5_a562);          /* call 0x100d7bdc */
            ii(0x1013_213e, 3); mov(memd_a32[ss, ebp - 0x7c], eax);     /* mov [ebp-0x7c], eax */
            ii(0x1013_2141, 3); mov(eax, memd_a32[ss, ebp - 0x7c]);     /* mov eax, [ebp-0x7c] */
            ii(0x1013_2144, 3); mov(memd_a32[ss, ebp - 0x80], eax);     /* mov [ebp-0x80], eax */
            ii(0x1013_2147, 2); jmpd(0x1013_214f, 0x6); goto l_0x1013_214f; /* jmp 0x1013214f */
        l_0x1013_2149:
            ii(0x1013_2149, 3); mov(eax, memd_a32[ss, ebp - 0x78]);     /* mov eax, [ebp-0x78] */
            ii(0x1013_214c, 3); mov(memd_a32[ss, ebp - 0x80], eax);     /* mov [ebp-0x80], eax */
        l_0x1013_214f:
            ii(0x1013_214f, 3); mov(eax, memd_a32[ss, ebp - 0x80]);     /* mov eax, [ebp-0x80] */
            ii(0x1013_2152, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1013_2155, 3); mov(memd_a32[ds, edx + 0x13], eax);     /* mov [edx+0x13], eax */
            ii(0x1013_2158, 3); lea(edx, ebp - 0x38);                   /* lea edx, [ebp-0x38] */
            ii(0x1013_215b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_215e, 3); mov(eax, memd_a32[ds, eax + 0x13]);     /* mov eax, [eax+0x13] */
            ii(0x1013_2161, 5); calld(0x100d_7d74, -0x5_a3f2);          /* call 0x100d7d74 */
            ii(0x1013_2166, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x1013_216b, 5); calld(Definitions.sys_new, 0x3_3c90);   /* call 0x10165e00 */
            ii(0x1013_2170, 6); mov(memd_a32[ss, ebp - 0x84], eax);     /* mov [ebp-0x84], eax */
            ii(0x1013_2176, 6); mov(eax, memd_a32[ss, ebp - 0x84]);     /* mov eax, [ebp-0x84] */
            ii(0x1013_217c, 6); mov(memd_a32[ss, ebp - 0x88], eax);     /* mov [ebp-0x88], eax */
            ii(0x1013_2182, 7); cmp(memd_a32[ss, ebp - 0x88], 0);       /* cmp dword [ebp-0x88], 0x0 */
            ii(0x1013_2189, 2); if(jzd(0x1013_21c5, 0x3a)) goto l_0x1013_21c5; /* jz 0x101321c5 */
            ii(0x1013_218b, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x1013_2190, 1); pushd(eax);                             /* push eax */
            ii(0x1013_2191, 5); mov(ecx, 0x23);                         /* mov ecx, 0x23 */
            ii(0x1013_2196, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1013_2199, 5); add(eax, 0x3);                          /* add eax, 0x3 */
            ii(0x1013_219e, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1013_21a1, 5); mov(edx, 0x128);                        /* mov edx, 0x128 */
            ii(0x1013_21a6, 6); mov(eax, memd_a32[ss, ebp - 0x84]);     /* mov eax, [ebp-0x84] */
            ii(0x1013_21ac, 5); calld(0x100d_7bdc, -0x5_a5d5);          /* call 0x100d7bdc */
            ii(0x1013_21b1, 6); mov(memd_a32[ss, ebp - 0x8c], eax);     /* mov [ebp-0x8c], eax */
            ii(0x1013_21b7, 6); mov(eax, memd_a32[ss, ebp - 0x8c]);     /* mov eax, [ebp-0x8c] */
            ii(0x1013_21bd, 6); mov(memd_a32[ss, ebp - 0x90], eax);     /* mov [ebp-0x90], eax */
            ii(0x1013_21c3, 2); jmpd(0x1013_21d1, 0xc); goto l_0x1013_21d1; /* jmp 0x101321d1 */
        l_0x1013_21c5:
            ii(0x1013_21c5, 6); mov(eax, memd_a32[ss, ebp - 0x88]);     /* mov eax, [ebp-0x88] */
            ii(0x1013_21cb, 6); mov(memd_a32[ss, ebp - 0x90], eax);     /* mov [ebp-0x90], eax */
        l_0x1013_21d1:
            ii(0x1013_21d1, 6); mov(eax, memd_a32[ss, ebp - 0x90]);     /* mov eax, [ebp-0x90] */
            ii(0x1013_21d7, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1013_21da, 3); mov(memd_a32[ds, edx + 0x17], eax);     /* mov [edx+0x17], eax */
            ii(0x1013_21dd, 3); lea(edx, ebp - 0x38);                   /* lea edx, [ebp-0x38] */
            ii(0x1013_21e0, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_21e3, 3); mov(eax, memd_a32[ds, eax + 0x17]);     /* mov eax, [eax+0x17] */
            ii(0x1013_21e6, 5); calld(0x100d_7d74, -0x5_a477);          /* call 0x100d7d74 */
            ii(0x1013_21eb, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x1013_21f0, 5); calld(Definitions.sys_new, 0x3_3c0b);   /* call 0x10165e00 */
            ii(0x1013_21f5, 6); mov(memd_a32[ss, ebp - 0x94], eax);     /* mov [ebp-0x94], eax */
            ii(0x1013_21fb, 6); mov(eax, memd_a32[ss, ebp - 0x94]);     /* mov eax, [ebp-0x94] */
            ii(0x1013_2201, 6); mov(memd_a32[ss, ebp - 0x98], eax);     /* mov [ebp-0x98], eax */
            ii(0x1013_2207, 7); cmp(memd_a32[ss, ebp - 0x98], 0);       /* cmp dword [ebp-0x98], 0x0 */
            ii(0x1013_220e, 2); if(jzd(0x1013_2243, 0x33)) goto l_0x1013_2243; /* jz 0x10132243 */
            ii(0x1013_2210, 5); mov(eax, 0x11);                         /* mov eax, 0x11 */
            ii(0x1013_2215, 1); pushd(eax);                             /* push eax */
            ii(0x1013_2216, 5); mov(ecx, 0x30);                         /* mov ecx, 0x30 */
            ii(0x1013_221b, 4); movsx(ebx, memw_a32[ss, ebp - 0x1c]);   /* movsx ebx, word [ebp-0x1c] */
            ii(0x1013_221f, 5); mov(edx, 0x5b);                         /* mov edx, 0x5b */
            ii(0x1013_2224, 6); mov(eax, memd_a32[ss, ebp - 0x94]);     /* mov eax, [ebp-0x94] */
            ii(0x1013_222a, 5); calld(0x100d_7bdc, -0x5_a653);          /* call 0x100d7bdc */
            ii(0x1013_222f, 6); mov(memd_a32[ss, ebp - 0x9c], eax);     /* mov [ebp-0x9c], eax */
            ii(0x1013_2235, 6); mov(eax, memd_a32[ss, ebp - 0x9c]);     /* mov eax, [ebp-0x9c] */
            ii(0x1013_223b, 6); mov(memd_a32[ss, ebp - 0xa0], eax);     /* mov [ebp-0xa0], eax */
            ii(0x1013_2241, 2); jmpd(0x1013_224f, 0xc); goto l_0x1013_224f; /* jmp 0x1013224f */
        l_0x1013_2243:
            ii(0x1013_2243, 6); mov(eax, memd_a32[ss, ebp - 0x98]);     /* mov eax, [ebp-0x98] */
            ii(0x1013_2249, 6); mov(memd_a32[ss, ebp - 0xa0], eax);     /* mov [ebp-0xa0], eax */
        l_0x1013_224f:
            ii(0x1013_224f, 6); mov(eax, memd_a32[ss, ebp - 0xa0]);     /* mov eax, [ebp-0xa0] */
            ii(0x1013_2255, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1013_2258, 3); mov(memd_a32[ds, edx + 0x1b], eax);     /* mov [edx+0x1b], eax */
            ii(0x1013_225b, 3); lea(edx, ebp - 0x38);                   /* lea edx, [ebp-0x38] */
            ii(0x1013_225e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_2261, 3); mov(eax, memd_a32[ds, eax + 0x1b]);     /* mov eax, [eax+0x1b] */
            ii(0x1013_2264, 5); calld(0x100d_7d74, -0x5_a4f5);          /* call 0x100d7d74 */
            ii(0x1013_2269, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1013_226e, 5); calld(/* sys */ 0x1016_a24c, 0x3_7fd9); /* call 0x1016a24c */
            ii(0x1013_2273, 6); lea(eax, ebp - 0xa4);                   /* lea eax, [ebp-0xa4] */
            ii(0x1013_2279, 5); calld(0x1012_336c, -0xef12);            /* call 0x1012336c */
            ii(0x1013_227e, 1); pushd(eax);                             /* push eax */
            ii(0x1013_227f, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1013_2284, 1); pushd(eax);                             /* push eax */
            ii(0x1013_2285, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_2287, 1); pushd(eax);                             /* push eax */
            ii(0x1013_2288, 5); mov(eax, 0xf);                          /* mov eax, 0xf */
            ii(0x1013_228d, 1); pushd(eax);                             /* push eax */
            ii(0x1013_228e, 5); mov(eax, 0x31);                         /* mov eax, 0x31 */
            ii(0x1013_2293, 1); pushd(eax);                             /* push eax */
            ii(0x1013_2294, 4); movsx(ecx, memw_a32[ss, ebp - 0x1c]);   /* movsx ecx, word [ebp-0x1c] */
            ii(0x1013_2298, 5); mov(ebx, 0xb9);                         /* mov ebx, 0xb9 */
            ii(0x1013_229d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_22a0, 3); mov(edx, memd_a32[ds, eax + 0x1]);      /* mov edx, [eax+0x1] */
            ii(0x1013_22a3, 3); sar(edx, 0x18);                         /* sar edx, 0x18 */
            ii(0x1013_22a6, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1013_22a9, 6); mov(edx, memd_a32[ds, edx + 0x101b_b4b4]); /* mov edx, [edx+0x101bb4b4] */
            ii(0x1013_22af, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1013_22b2, 5); calld(0x100e_ab9d, -0x4_771a);          /* call 0x100eab9d */
            ii(0x1013_22b7, 7); or(memb_a32[ss, ebp - 0xa8], 0x1);      /* or byte [ebp-0xa8], 0x1 */
            ii(0x1013_22be, 6); lea(eax, ebp - 0xac);                   /* lea eax, [ebp-0xac] */
            ii(0x1013_22c4, 5); calld(Definitions.my_string_ctor, 0xf81f); /* call 0x10141ae8 */
            ii(0x1013_22c9, 6); mov(memd_a32[ss, ebp - 0xb0], eax);     /* mov [ebp-0xb0], eax */
            ii(0x1013_22cf, 7); and(memb_a32[ss, ebp - 0xa8], -0x2 /* 0xfe */); /* and byte [ebp-0xa8], 0xfe */
            ii(0x1013_22d6, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_22d9, 3); mov(eax, memd_a32[ds, eax + 0x1]);      /* mov eax, [eax+0x1] */
            ii(0x1013_22dc, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x1013_22df, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1013_22e1, 6); mov(eax, memd_a32[ds, eax + 0x101b_b4d2]); /* mov eax, [eax+0x101bb4d2] */
            ii(0x1013_22e7, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_22ea, 5); calld(Definitions.my_get_res_data_by_id, 0x1ce9); /* call 0x10133fd8 */
            ii(0x1013_22ef, 6); mov(memd_a32[ss, ebp - 0xb4], eax);     /* mov [ebp-0xb4], eax */
            ii(0x1013_22f5, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1013_22f8, 1); pushd(eax);                             /* push eax */
            ii(0x1013_22f9, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1013_22fe, 6); mov(edx, memd_a32[ss, ebp - 0xb4]);     /* mov edx, [ebp-0xb4] */
            ii(0x1013_2304, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x1013_2306, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_2309, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_230b, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_230e, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1013_2310, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1013_2312, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x1013_2316, 3); add(edx, 0x7);                          /* add edx, 0x7 */
            ii(0x1013_2319, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1013_231b, 3); movsx(ebx, dx);                         /* movsx ebx, dx */
            ii(0x1013_231e, 6); mov(edx, memd_a32[ss, ebp - 0xb4]);     /* mov edx, [ebp-0xb4] */
            ii(0x1013_2324, 3); movsx(edx, memw_a32[ds, edx]);          /* movsx edx, word [edx] */
            ii(0x1013_2327, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_2329, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_232c, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1013_232e, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1013_2330, 5); mov(edx, 0xaa);                         /* mov edx, 0xaa */
            ii(0x1013_2335, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1013_2337, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_2339, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1013_233c, 6); mov(eax, memd_a32[ss, ebp - 0xb4]);     /* mov eax, [ebp-0xb4] */
            ii(0x1013_2342, 5); calld(0x100e_8d1e, -0x4_9629);          /* call 0x100e8d1e */
            ii(0x1013_2347, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_234a, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1013_234c, 5); calld(0x1013_38fc, 0x15ab);             /* call 0x101338fc */
            ii(0x1013_2351, 1); cwde();                                 /* cwde */
            ii(0x1013_2352, 6); imul(edx, eax, 0x247);                  /* imul edx, eax, 0x247 */
            ii(0x1013_2358, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_235b, 3); mov(eax, memd_a32[ds, eax + 0x1]);      /* mov eax, [eax+0x1] */
            ii(0x1013_235e, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x1013_2361, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x1013_2364, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_2366, 7); imul(eax, memd_a32[ds, eax + 0x101c_a4f0], 0xa); /* imul eax, [eax+0x101ca4f0], 0xa */
            ii(0x1013_236d, 1); pushd(eax);                             /* push eax */
            ii(0x1013_236e, 5); mov(eax, StringDefinitions.I18);        /* mov eax, 0x101a890c */
            ii(0x1013_2373, 1); pushd(eax);                             /* push eax */
            ii(0x1013_2374, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x1013_2379, 1); pushd(eax);                             /* push eax */
            ii(0x1013_237a, 6); lea(eax, ebp - 0xac);                   /* lea eax, [ebp-0xac] */
            ii(0x1013_2380, 1); pushd(eax);                             /* push eax */
            ii(0x1013_2381, 5); calld(0x1014_2037, 0xfcb1);             /* call 0x10142037 */
            ii(0x1013_2386, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1013_2389, 5); pushd(0xa2);                            /* push 0xa2 */
            ii(0x1013_238e, 4); movsx(ecx, memw_a32[ss, ebp - 0x28]);   /* movsx ecx, word [ebp-0x28] */
            ii(0x1013_2392, 5); mov(ebx, 0x23);                         /* mov ebx, 0x23 */
            ii(0x1013_2397, 6); lea(eax, ebp - 0xac);                   /* lea eax, [ebp-0xac] */
            ii(0x1013_239d, 5); calld(Definitions.my_strobj_c_str_v2, -0xa_8bda); /* call 0x100897c8 */
            ii(0x1013_23a2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_23a4, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1013_23a8, 4); movsx(esi, memw_a32[ss, ebp - 0x28]);   /* movsx esi, word [ebp-0x28] */
            ii(0x1013_23ac, 3); add(eax, 0x3);                          /* add eax, 0x3 */
            ii(0x1013_23af, 3); imul(eax, esi);                         /* imul eax, esi */
            ii(0x1013_23b2, 3); mov(esi, memd_a32[ss, ebp - 0x22]);     /* mov esi, [ebp-0x22] */
            ii(0x1013_23b5, 6); add(esi, 0x114);                        /* add esi, 0x114 */
            ii(0x1013_23bb, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x1013_23bd, 6); lea(eax, ebp - 0xac);                   /* lea eax, [ebp-0xac] */
            ii(0x1013_23c3, 5); calld(Definitions.my_strobj_c_str_v2, -0xa_8c00); /* call 0x100897c8 */
            ii(0x1013_23c8, 6); calld_abs(memd_a32[ds, 0x101b_ddf4]);   /* call dword [0x101bddf4] */
            ii(0x1013_23ce, 2); sub(esi, eax);                          /* sub esi, eax */
            ii(0x1013_23d0, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1013_23d2, 6); calld_abs(memd_a32[ds, 0x101b_ddec]);   /* call dword [0x101bddec] */
            ii(0x1013_23d8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_23da, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_23dd, 5); calld(0x1013_2489, 0xa7);               /* call 0x10132489 */
            ii(0x1013_23e2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_23e4, 6); lea(eax, ebp - 0xac);                   /* lea eax, [ebp-0xac] */
            ii(0x1013_23ea, 5); calld(Definitions.my_string_dtor, 0xf73b); /* call 0x10141b2a */
            ii(0x1013_23ef, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_23f1, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_23f2, 1); popd(edi);                              /* pop edi */
            ii(0x1013_23f3, 1); popd(esi);                              /* pop esi */
            ii(0x1013_23f4, 1); retd(); return;                         /* ret */
        }
    }
}
