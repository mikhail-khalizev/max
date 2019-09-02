using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_2f2a-1ca7f938")]
        public void Method_100d_2f2a()
        {
            ii(0x100d_2f2a, 5); push(0xa0);                             /* push 0xa0 */
            ii(0x100d_2f2f, 5); call(Definitions.sys_check_available_stack_size, 0x9_2e1e); /* call 0x10165d52 */
            ii(0x100d_2f34, 1); push(ebx);                              /* push ebx */
            ii(0x100d_2f35, 1); push(ecx);                              /* push ecx */
            ii(0x100d_2f36, 1); push(edx);                              /* push edx */
            ii(0x100d_2f37, 1); push(esi);                              /* push esi */
            ii(0x100d_2f38, 1); push(edi);                              /* push edi */
            ii(0x100d_2f39, 1); push(ebp);                              /* push ebp */
            ii(0x100d_2f3a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_2f3c, 6); sub(esp, 0x6c);                         /* sub esp, 0x6c */
            ii(0x100d_2f42, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100d_2f45, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_2f48, 3); mov(eax, memd[ds, eax + 62]);           /* mov eax, [eax+0x3e] */
            ii(0x100d_2f4b, 5); call(0x100d_0149, -0x2e07);             /* call 0x100d0149 */
            ii(0x100d_2f50, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100d_2f53, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x100d_2f57, 5); call(0x100c_dec2, -0x509a);             /* call 0x100cdec2 */
            ii(0x100d_2f5c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_2f5e, 2); if(jnz(0x100d_2f8c, 0x2c)) goto l_0x100d_2f8c; /* jnz 0x100d2f8c */
            ii(0x100d_2f60, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x100d_2f65, 5); call(0x100e_0e00, 0xde96);              /* call 0x100e0e00 */
            ii(0x100d_2f6a, 3); lea(edx, memd[ss, ebp - 56]);           /* lea edx, [ebp-0x38] */
            ii(0x100d_2f6d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_2f70, 3); mov(eax, memd[ds, eax + 49]);           /* mov eax, [eax+0x31] */
            ii(0x100d_2f73, 5); call(0x1015_0a5f, 0x7_dae7);            /* call 0x10150a5f */
            ii(0x100d_2f78, 5); call(0x1009_caf8, -0x3_6485);           /* call 0x1009caf8 */
            ii(0x100d_2f7d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_2f7f, 3); lea(eax, memd[ss, ebp - 56]);           /* lea eax, [ebp-0x38] */
            ii(0x100d_2f82, 5); call(0x1008_8b04, -0x4_a483);           /* call 0x10088b04 */
            ii(0x100d_2f87, 5); jmp(0x100d_338c, 0x400); goto l_0x100d_338c; /* jmp 0x100d338c */
        l_0x100d_2f8c:
            ii(0x100d_2f8c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_2f8f, 4); mov(memb[ds, eax + 54], 1);             /* mov byte [eax+0x36], 0x1 */
            ii(0x100d_2f93, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_2f96, 3); mov(eax, memd[ds, eax + 49]);           /* mov eax, [eax+0x31] */
            ii(0x100d_2f99, 4); mov(ax, memw[ds, eax + 26]);            /* mov ax, [eax+0x1a] */
            ii(0x100d_2f9d, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x100d_2fa0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_2fa3, 3); mov(eax, memd[ds, eax + 49]);           /* mov eax, [eax+0x31] */
            ii(0x100d_2fa6, 4); mov(ax, memw[ds, eax + 28]);            /* mov ax, [eax+0x1c] */
            ii(0x100d_2faa, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x100d_2fad, 4); movsx(ecx, memw[ss, ebp - 12]);         /* movsx ecx, word [ebp-0xc] */
            ii(0x100d_2fb1, 3); lea(ebx, memd[ss, ebp - 20]);           /* lea ebx, [ebp-0x14] */
            ii(0x100d_2fb4, 3); lea(edx, memd[ss, ebp - 24]);           /* lea edx, [ebp-0x18] */
            ii(0x100d_2fb7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_2fba, 3); mov(eax, memd[ds, eax + 49]);           /* mov eax, [eax+0x31] */
            ii(0x100d_2fbd, 5); call(0x100c_e1a2, -0x4e20);             /* call 0x100ce1a2 */
            ii(0x100d_2fc2, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x100d_2fc5, 6); if(jnz(0x100d_3064, 0x99)) goto l_0x100d_3064; /* jnz 0x100d3064 */
            ii(0x100d_2fcb, 3); lea(edi, memd[ss, ebp - 68]);           /* lea edi, [ebp-0x44] */
            ii(0x100d_2fce, 5); mov(esi, 0x101b_7e48);                  /* mov esi, 0x101b7e48 */
            ii(0x100d_2fd3, 1); movsd();                                /* movsd */
            ii(0x100d_2fd4, 1); movsd();                                /* movsd */
            ii(0x100d_2fd5, 1); movsd();                                /* movsd */
            ii(0x100d_2fd6, 4); or(memb[ss, ebp - 8], 1);               /* or byte [ebp-0x8], 0x1 */
            ii(0x100d_2fda, 3); lea(eax, memd[ss, ebp - 72]);           /* lea eax, [ebp-0x48] */
            ii(0x100d_2fdd, 5); call(Definitions.my_string_ctor, 0x6_eb06); /* call 0x10141ae8 */
            ii(0x100d_2fe2, 3); mov(memd[ss, ebp - 76], eax);           /* mov [ebp-0x4c], eax */
            ii(0x100d_2fe5, 4); and(memb[ss, ebp - 8], -2 /* 0xfe */);  /* and byte [ebp-0x8], 0xfe */
            ii(0x100d_2fe9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_2fec, 3); mov(eax, memd[ds, eax + 49]);           /* mov eax, [eax+0x31] */
            ii(0x100d_2fef, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x100d_2ff2, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_2ff5, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100d_2ff8, 6); push(memd[ds, eax + 0x101c_81d7]);      /* push dword [eax+0x101c81d7] */
            ii(0x100d_2ffe, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_3001, 3); mov(eax, memd[ds, eax + 49]);           /* mov eax, [eax+0x31] */
            ii(0x100d_3004, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x100d_3007, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_300a, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100d_300d, 6); mov(eax, memd[ds, eax + 0x101c_81d3]);  /* mov eax, [eax+0x101c81d3] */
            ii(0x100d_3013, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x100d_3016, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100d_3019, 4); push(memd[ds, eax + ebp - 68]);         /* push dword [eax+ebp-0x44] */
            ii(0x100d_301d, 5); mov(eax, 0x96);                         /* mov eax, 0x96 */
            ii(0x100d_3022, 1); push(eax);                              /* push eax */
            ii(0x100d_3023, 3); lea(eax, memd[ss, ebp - 72]);           /* lea eax, [ebp-0x48] */
            ii(0x100d_3026, 1); push(eax);                              /* push eax */
            ii(0x100d_3027, 5); call(0x1014_2037, 0x6_f00b);            /* call 0x10142037 */
            ii(0x100d_302c, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x100d_302f, 5); call(0x100c_aa00, -0x8634);             /* call 0x100caa00 */
            ii(0x100d_3034, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100d_3039, 1); push(eax);                              /* push eax */
            ii(0x100d_303a, 5); call(0x100c_aa20, -0x861f);             /* call 0x100caa20 */
            ii(0x100d_303f, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100d_3041, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100d_3043, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100d_3048, 3); lea(eax, memd[ss, ebp - 72]);           /* lea eax, [ebp-0x48] */
            ii(0x100d_304b, 5); call(Definitions.my_strobj_c_str_v2, -0x4_9888); /* call 0x100897c8 */
            ii(0x100d_3050, 5); call(0x1011_5d23, 0x4_2cce);            /* call 0x10115d23 */
            ii(0x100d_3055, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_3057, 3); lea(eax, memd[ss, ebp - 72]);           /* lea eax, [ebp-0x48] */
            ii(0x100d_305a, 5); call(Definitions.my_string_dtor, 0x6_eacb); /* call 0x10141b2a */
            ii(0x100d_305f, 5); jmp(0x100d_338c, 0x328); goto l_0x100d_338c; /* jmp 0x100d338c */
        l_0x100d_3064:
            ii(0x100d_3064, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x100d_3068, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100d_306b, 5); mov(edx, 0x101c_81c0);                  /* mov edx, 0x101c81c0 */
            ii(0x100d_3070, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100d_3072, 3); mov(memd[ss, ebp - 40], edx);           /* mov [ebp-0x28], edx */
            ii(0x100d_3075, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_3078, 3); mov(memd[ss, ebp - 36], eax);           /* mov [ebp-0x24], eax */
            ii(0x100d_307b, 3); mov(eax, memd[ss, ebp - 36]);           /* mov eax, [ebp-0x24] */
            ii(0x100d_307e, 3); mov(ebx, memd[ds, eax + 19]);           /* mov ebx, [eax+0x13] */
            ii(0x100d_3081, 4); movsx(edx, memw[ss, ebp - 12]);         /* movsx edx, word [ebp-0xc] */
            ii(0x100d_3085, 3); mov(eax, memd[ss, ebp - 36]);           /* mov eax, [ebp-0x24] */
            ii(0x100d_3088, 3); call_abs(memd[ds, ebx + 16]);           /* call dword [ebx+0x10] */
            ii(0x100d_308b, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x100d_308e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_3091, 3); mov(ebx, memd[ds, eax + 49]);           /* mov ebx, [eax+0x31] */
            ii(0x100d_3094, 3); mov(ebx, memd[ds, ebx + 80]);           /* mov ebx, [ebx+0x50] */
            ii(0x100d_3097, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100d_309a, 4); movsx(edx, memw[ss, ebp - 28]);         /* movsx edx, word [ebp-0x1c] */
            ii(0x100d_309e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_30a1, 3); mov(eax, memd[ds, eax + 49]);           /* mov eax, [eax+0x31] */
            ii(0x100d_30a4, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x100d_30a7, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_30aa, 5); call(0x100d_4c69, 0x1bba);              /* call 0x100d4c69 */
            ii(0x100d_30af, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x100d_30b2, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_30b5, 4); mov(ax, memw[ds, eax + 56]);            /* mov ax, [eax+0x38] */
            ii(0x100d_30b9, 4); cmp(ax, memw[ss, ebp - 16]);            /* cmp ax, [ebp-0x10] */
            ii(0x100d_30bd, 2); if(jle(0x100d_30c9, 0xa)) goto l_0x100d_30c9; /* jle 0x100d30c9 */
            ii(0x100d_30bf, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100d_30c2, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100d_30c5, 4); mov(memw[ds, edx + 56], ax);            /* mov [edx+0x38], ax */
        l_0x100d_30c9:
            ii(0x100d_30c9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_30cc, 3); mov(eax, memd[ds, eax + 54]);           /* mov eax, [eax+0x36] */
            ii(0x100d_30cf, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_30d2, 3); cmp(eax, 1);                            /* cmp eax, 0x1 */
            ii(0x100d_30d5, 2); if(jnz(0x100d_3107, 0x30)) goto l_0x100d_3107; /* jnz 0x100d3107 */
            ii(0x100d_30d7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_30da, 3); mov(eax, memd[ds, eax + 49]);           /* mov eax, [eax+0x31] */
            ii(0x100d_30dd, 3); mov(ebx, memd[ds, eax + 80]);           /* mov ebx, [eax+0x50] */
            ii(0x100d_30e0, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100d_30e3, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100d_30e8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_30eb, 3); mov(eax, memd[ds, eax + 49]);           /* mov eax, [eax+0x31] */
            ii(0x100d_30ee, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x100d_30f1, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_30f4, 5); call(0x1007_1e00, -0x6_12f9);           /* call 0x10071e00 */
            ii(0x100d_30f9, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_30fc, 4); movsx(eax, memw[ss, ebp - 28]);         /* movsx eax, word [ebp-0x1c] */
            ii(0x100d_3100, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100d_3103, 2); cmp(ebx, eax);                          /* cmp ebx, eax */
            ii(0x100d_3105, 2); if(jl(0x100d_3109, 2)) goto l_0x100d_3109; /* jl 0x100d3109 */
        l_0x100d_3107:
            ii(0x100d_3107, 2); jmp(0x100d_3131, 0x28); goto l_0x100d_3131; /* jmp 0x100d3131 */
        l_0x100d_3109:
            ii(0x100d_3109, 5); call(0x100c_aa00, -0x870e);             /* call 0x100caa00 */
            ii(0x100d_310e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100d_3113, 1); push(eax);                              /* push eax */
            ii(0x100d_3114, 5); call(0x100c_aa20, -0x86f9);             /* call 0x100caa20 */
            ii(0x100d_3119, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100d_311b, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100d_311d, 5); mov(edx, 2);                            /* mov edx, 0x2 */
            ii(0x100d_3122, 5); mov(eax, StringDefinitions.WarningInsufficientMaterialInStorageToStartConstruction); /* mov eax, 0x101a14cb */
            ii(0x100d_3127, 5); call(0x1011_5d23, 0x4_2bf7);            /* call 0x10115d23 */
            ii(0x100d_312c, 5); jmp(0x100d_338c, 0x25b); goto l_0x100d_338c; /* jmp 0x100d338c */
        l_0x100d_3131:
            ii(0x100d_3131, 3); lea(ebx, memd[ss, ebp - 12]);           /* lea ebx, [ebp-0xc] */
            ii(0x100d_3134, 3); lea(edx, memd[ss, ebp - 32]);           /* lea edx, [ebp-0x20] */
            ii(0x100d_3137, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_313a, 3); mov(eax, memd[ds, eax + 49]);           /* mov eax, [eax+0x31] */
            ii(0x100d_313d, 5); call(0x1015_0a5f, 0x7_d91d);            /* call 0x10150a5f */
            ii(0x100d_3142, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100d_3144, 5); call(0x1008_b2a8, -0x4_7ea1);           /* call 0x1008b2a8 */
            ii(0x100d_3149, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_314b, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x100d_314e, 5); call(0x1008_8b04, -0x4_a64f);           /* call 0x10088b04 */
            ii(0x100d_3153, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_3156, 3); mov(edx, memd[ds, eax + 54]);           /* mov edx, [eax+0x36] */
            ii(0x100d_3159, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_315c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_315f, 3); mov(eax, memd[ds, eax + 49]);           /* mov eax, [eax+0x31] */
            ii(0x100d_3162, 5); call(0x1009_c970, -0x3_67f7);           /* call 0x1009c970 */
            ii(0x100d_3167, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_316a, 4); mov(memb[ds, eax + 53], 1);             /* mov byte [eax+0x35], 0x1 */
            ii(0x100d_316e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_3170, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_3173, 3); mov(eax, memd[ds, eax + 49]);           /* mov eax, [eax+0x31] */
            ii(0x100d_3176, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x100d_3179, 5); call(0x1007_6a34, -0x5_c74a);           /* call 0x10076a34 */
            ii(0x100d_317e, 7); cmp(memd[ds, 0x101c_5624], 0);          /* cmp dword [0x101c5624], 0x0 */
            ii(0x100d_3185, 2); if(jz(0x100d_3192, 0xb)) goto l_0x100d_3192; /* jz 0x100d3192 */
            ii(0x100d_3187, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_318a, 3); mov(eax, memd[ds, eax + 49]);           /* mov eax, [eax+0x31] */
            ii(0x100d_318d, 5); call(0x1012_ae8d, 0x5_7cfb);            /* call 0x1012ae8d */
        l_0x100d_3192:
            ii(0x100d_3192, 3); mov(eax, memd[ss, ebp - 40]);           /* mov eax, [ebp-0x28] */
            ii(0x100d_3195, 3); test(memb[ds, eax], 0x10);              /* test byte [eax], 0x10 */
            ii(0x100d_3198, 2); if(jnz(0x100d_31a7, 0xd)) goto l_0x100d_31a7; /* jnz 0x100d31a7 */
            ii(0x100d_319a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_319d, 4); cmp(memb[ds, eax + 55], 0);             /* cmp byte [eax+0x37], 0x0 */
            ii(0x100d_31a1, 6); if(jz(0x100d_3272, 0xcb)) goto l_0x100d_3272; /* jz 0x100d3272 */
        l_0x100d_31a7:
            ii(0x100d_31a7, 5); mov(ebx, 0x19);                         /* mov ebx, 0x19 */
            ii(0x100d_31ac, 5); mov(edx, 4);                            /* mov edx, 0x4 */
            ii(0x100d_31b1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_31b4, 3); mov(eax, memd[ds, eax + 49]);           /* mov eax, [eax+0x31] */
            ii(0x100d_31b7, 5); call(0x1016_2f96, 0x8_fdda);            /* call 0x10162f96 */
            ii(0x100d_31bc, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_31bf, 3); push(memd[ds, eax + 49]);               /* push dword [eax+0x31] */
            ii(0x100d_31c2, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x100d_31c6, 3); mov(memd[ss, ebp - 80], eax);           /* mov [ebp-0x50], eax */
            ii(0x100d_31c9, 3); push(memd[ss, ebp - 80]);               /* push dword [ebp-0x50] */
            ii(0x100d_31cc, 4); movsx(eax, memw[ss, ebp - 24]);         /* movsx eax, word [ebp-0x18] */
            ii(0x100d_31d0, 3); mov(memd[ss, ebp - 84], eax);           /* mov [ebp-0x54], eax */
            ii(0x100d_31d3, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_31d5, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x100d_31da, 1); cwde();                                 /* cwde */
            ii(0x100d_31db, 3); mov(memd[ss, ebp - 88], eax);           /* mov [ebp-0x58], eax */
            ii(0x100d_31de, 3); mov(eax, memd[ss, ebp - 40]);           /* mov eax, [ebp-0x28] */
            ii(0x100d_31e1, 3); test(memb[ds, eax], 0x10);              /* test byte [eax], 0x10 */
            ii(0x100d_31e4, 2); if(jz(0x100d_31ef, 9)) goto l_0x100d_31ef; /* jz 0x100d31ef */
            ii(0x100d_31e6, 7); mov(memd[ss, ebp - 92], 0xf);           /* mov dword [ebp-0x5c], 0xf */
            ii(0x100d_31ed, 2); jmp(0x100d_31f6, 7); goto l_0x100d_31f6; /* jmp 0x100d31f6 */
        l_0x100d_31ef:
            ii(0x100d_31ef, 7); mov(memd[ss, ebp - 92], 0x10);          /* mov dword [ebp-0x5c], 0x10 */
        l_0x100d_31f6:
            ii(0x100d_31f6, 3); mov(edx, memd[ss, ebp - 94]);           /* mov edx, [ebp-0x5e] */
            ii(0x100d_31f9, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_31fc, 3); lea(eax, memd[ss, ebp - 96]);           /* lea eax, [ebp-0x60] */
            ii(0x100d_31ff, 3); mov(ecx, memd[ss, ebp - 84]);           /* mov ecx, [ebp-0x54] */
            ii(0x100d_3202, 3); mov(ebx, memd[ss, ebp - 88]);           /* mov ebx, [ebp-0x58] */
            ii(0x100d_3205, 5); call(0x1015_a6aa, 0x8_74a0);            /* call 0x1015a6aa */
            ii(0x100d_320a, 5); mov(ecx, 0x101c_37c0);                  /* mov ecx, 0x101c37c0 */
            ii(0x100d_320f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_3211, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x100d_3213, 5); call(0x1008_ac18, -0x4_8600);           /* call 0x1008ac18 */
            ii(0x100d_3218, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_321a, 3); lea(eax, memd[ss, ebp - 96]);           /* lea eax, [ebp-0x60] */
            ii(0x100d_321d, 5); call(0x1007_5f2c, -0x5_d2f6);           /* call 0x10075f2c */
            ii(0x100d_3222, 5); call(0x100c_aa00, -0x8827);             /* call 0x100caa00 */
            ii(0x100d_3227, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100d_322c, 1); push(eax);                              /* push eax */
            ii(0x100d_322d, 5); call(0x100c_aa20, -0x8812);             /* call 0x100caa20 */
            ii(0x100d_3232, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100d_3234, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100d_3236, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_3238, 5); mov(eax, StringDefinitions.PositionTapeAndClickInsideItToBeginBuilding); /* mov eax, 0x101a150c */
            ii(0x100d_323d, 5); call(0x1011_5d23, 0x4_2ae1);            /* call 0x10115d23 */
            ii(0x100d_3242, 5); mov(eax, 0x3e);                         /* mov eax, 0x3e */
            ii(0x100d_3247, 5); call(0x1007_5fdc, -0x5_d270);           /* call 0x10075fdc */
            ii(0x100d_324c, 3); cmp(eax, 1);                            /* cmp eax, 0x1 */
            ii(0x100d_324f, 2); if(jnz(0x100d_326d, 0x1c)) goto l_0x100d_326d; /* jnz 0x100d326d */
            ii(0x100d_3251, 5); call(0x100d_5470, 0x221a);              /* call 0x100d5470 */
            ii(0x100d_3256, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100d_3259, 5); mov(ebx, 0x3e1);                        /* mov ebx, 0x3e1 */
            ii(0x100d_325e, 5); mov(edx, 0x3de);                        /* mov edx, 0x3de */
            ii(0x100d_3263, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100d_3268, 5); call(0x1013_daea, 0x6_a87d);            /* call 0x1013daea */
        l_0x100d_326d:
            ii(0x100d_326d, 5); jmp(0x100d_338c, 0x11a); goto l_0x100d_338c; /* jmp 0x100d338c */
        l_0x100d_3272:
            ii(0x100d_3272, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_3275, 3); mov(edx, memd[ds, eax + 49]);           /* mov edx, [eax+0x31] */
            ii(0x100d_3278, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x100d_327b, 4); mov(memw[ds, edx + 65], ax);            /* mov [edx+0x41], ax */
            ii(0x100d_327f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_3282, 3); mov(edx, memd[ds, eax + 49]);           /* mov edx, [eax+0x31] */
            ii(0x100d_3285, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100d_3288, 4); mov(memw[ds, edx + 67], ax);            /* mov [edx+0x43], ax */
            ii(0x100d_328c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_328f, 3); mov(eax, memd[ds, eax + 49]);           /* mov eax, [eax+0x31] */
            ii(0x100d_3292, 5); call(0x1015_2387, 0x7_f0f0);            /* call 0x10152387 */
            ii(0x100d_3297, 4); or(memb[ss, ebp - 8], 1);               /* or byte [ebp-0x8], 0x1 */
            ii(0x100d_329b, 3); lea(eax, memd[ss, ebp - 48]);           /* lea eax, [ebp-0x30] */
            ii(0x100d_329e, 5); call(Definitions.my_string_ctor, 0x6_e845); /* call 0x10141ae8 */
            ii(0x100d_32a3, 3); mov(memd[ss, ebp - 52], eax);           /* mov [ebp-0x34], eax */
            ii(0x100d_32a6, 4); and(memb[ss, ebp - 8], -2 /* 0xfe */);  /* and byte [ebp-0x8], 0xfe */
            ii(0x100d_32aa, 3); lea(edi, memd[ss, ebp - 108]);          /* lea edi, [ebp-0x6c] */
            ii(0x100d_32ad, 5); mov(esi, 0x101b_7e54);                  /* mov esi, 0x101b7e54 */
            ii(0x100d_32b2, 1); movsd();                                /* movsd */
            ii(0x100d_32b3, 1); movsd();                                /* movsd */
            ii(0x100d_32b4, 1); movsd();                                /* movsd */
            ii(0x100d_32b5, 3); lea(ecx, memd[ss, ebp - 28]);           /* lea ecx, [ebp-0x1c] */
            ii(0x100d_32b8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_32bb, 3); mov(ebx, memd[ds, eax + 54]);           /* mov ebx, [eax+0x36] */
            ii(0x100d_32be, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100d_32c1, 4); movsx(edx, memw[ss, ebp - 12]);         /* movsx edx, word [ebp-0xc] */
            ii(0x100d_32c5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_32c8, 3); mov(eax, memd[ds, eax + 49]);           /* mov eax, [eax+0x31] */
            ii(0x100d_32cb, 5); call(0x1015_4f88, 0x8_1cb8);            /* call 0x10154f88 */
            ii(0x100d_32d0, 4); movsx(eax, memw[ss, ebp - 28]);         /* movsx eax, word [ebp-0x1c] */
            ii(0x100d_32d4, 1); push(eax);                              /* push eax */
            ii(0x100d_32d5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_32d8, 3); mov(eax, memd[ds, eax + 49]);           /* mov eax, [eax+0x31] */
            ii(0x100d_32db, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_32dd, 3); mov(dl, memb[ds, eax + 38]);            /* mov dl, [eax+0x26] */
            ii(0x100d_32e0, 6); imul(edx, edx, 0x247);                  /* imul edx, edx, 0x247 */
            ii(0x100d_32e6, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x100d_32ea, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100d_32ec, 6); mov(al, memb[ds, eax + 0x101c_a492]);   /* mov al, [eax+0x101ca492] */
            ii(0x100d_32f2, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100d_32f7, 1); push(eax);                              /* push eax */
            ii(0x100d_32f8, 3); mov(eax, memd[ss, ebp - 40]);           /* mov eax, [ebp-0x28] */
            ii(0x100d_32fb, 3); push(memd[ds, eax + 23]);               /* push dword [eax+0x17] */
            ii(0x100d_32fe, 3); mov(eax, memd[ss, ebp - 40]);           /* mov eax, [ebp-0x28] */
            ii(0x100d_3301, 3); mov(eax, memd[ds, eax + 19]);           /* mov eax, [eax+0x13] */
            ii(0x100d_3304, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x100d_3307, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100d_330a, 4); push(memd[ds, eax + ebp - 108]);        /* push dword [eax+ebp-0x6c] */
            ii(0x100d_330e, 5); mov(eax, 0xfa);                         /* mov eax, 0xfa */
            ii(0x100d_3313, 1); push(eax);                              /* push eax */
            ii(0x100d_3314, 3); lea(eax, memd[ss, ebp - 48]);           /* lea eax, [ebp-0x30] */
            ii(0x100d_3317, 1); push(eax);                              /* push eax */
            ii(0x100d_3318, 5); call(0x1014_2037, 0x6_ed1a);            /* call 0x10142037 */
            ii(0x100d_331d, 3); add(esp, 0x18);                         /* add esp, 0x18 */
            ii(0x100d_3320, 5); mov(eax, memd[ds, 0x101c_3980]);        /* mov eax, [0x101c3980] */
            ii(0x100d_3325, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_3328, 3); cmp(eax, 1);                            /* cmp eax, 0x1 */
            ii(0x100d_332b, 2); if(jnz(0x100d_333c, 0xf)) goto l_0x100d_333c; /* jnz 0x100d333c */
            ii(0x100d_332d, 5); mov(eax, 0x3e);                         /* mov eax, 0x3e */
            ii(0x100d_3332, 5); call(0x1007_5fdc, -0x5_d35b);           /* call 0x10075fdc */
            ii(0x100d_3337, 3); cmp(eax, 1);                            /* cmp eax, 0x1 */
            ii(0x100d_333a, 2); if(jz(0x100d_333e, 2)) goto l_0x100d_333e; /* jz 0x100d333e */
        l_0x100d_333c:
            ii(0x100d_333c, 2); jmp(0x100d_334b, 0xd); goto l_0x100d_334b; /* jmp 0x100d334b */
        l_0x100d_333e:
            ii(0x100d_333e, 5); mov(edx, StringDefinitions.AtThisPointYouMightWishToClickTheEndTurnButtonSeveralTimesSoTheEngineerWillFinishBuilding); /* mov edx, 0x101a1541 */
            ii(0x100d_3343, 3); lea(eax, memd[ss, ebp - 48]);           /* lea eax, [ebp-0x30] */
            ii(0x100d_3346, 5); call(Definitions.my_string_append_char_ptr, 0x6_e9f4); /* call 0x10141d3f */
        l_0x100d_334b:
            ii(0x100d_334b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_334e, 3); mov(eax, memd[ds, eax + 49]);           /* mov eax, [eax+0x31] */
            ii(0x100d_3351, 3); mov(ebx, memd[ds, eax + 26]);           /* mov ebx, [eax+0x1a] */
            ii(0x100d_3354, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100d_3357, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_335a, 3); mov(eax, memd[ds, eax + 49]);           /* mov eax, [eax+0x31] */
            ii(0x100d_335d, 3); mov(edx, memd[ds, eax + 24]);           /* mov edx, [eax+0x18] */
            ii(0x100d_3360, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_3363, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x100d_3366, 5); call(0x1007_6aac, -0x5_c8bf);           /* call 0x10076aac */
            ii(0x100d_336b, 2); mov(ecx, memd[ds, eax]);                /* mov ecx, [eax] */
            ii(0x100d_336d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_3370, 3); mov(ebx, memd[ds, eax + 49]);           /* mov ebx, [eax+0x31] */
            ii(0x100d_3373, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_3375, 3); lea(eax, memd[ss, ebp - 48]);           /* lea eax, [ebp-0x30] */
            ii(0x100d_3378, 5); call(Definitions.my_strobj_c_str_v2, -0x4_9bb5); /* call 0x100897c8 */
            ii(0x100d_337d, 5); call(0x1011_5b60, 0x4_27de);            /* call 0x10115b60 */
            ii(0x100d_3382, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_3384, 3); lea(eax, memd[ss, ebp - 48]);           /* lea eax, [ebp-0x30] */
            ii(0x100d_3387, 5); call(Definitions.my_string_dtor, 0x6_e79e); /* call 0x10141b2a */
        l_0x100d_338c:
            ii(0x100d_338c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_338e, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_338f, 1); pop(edi);                               /* pop edi */
            ii(0x100d_3390, 1); pop(esi);                               /* pop esi */
            ii(0x100d_3391, 1); pop(edx);                               /* pop edx */
            ii(0x100d_3392, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_3393, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_3394, 1); ret();                                  /* ret */
        }
    }
}
