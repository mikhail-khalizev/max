using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_30e6-878696ef")]
        public void Method_100e_30e6()
        {
            ii(0x100e_30e6, 5); push(0x3c);                             /* push 0x3c */
            ii(0x100e_30eb, 5); call(Definitions.sys_check_available_stack_size, 0x8_2c62); /* call 0x10165d52 */
            ii(0x100e_30f0, 1); push(ebx);                              /* push ebx */
            ii(0x100e_30f1, 1); push(ecx);                              /* push ecx */
            ii(0x100e_30f2, 1); push(esi);                              /* push esi */
            ii(0x100e_30f3, 1); push(edi);                              /* push edi */
            ii(0x100e_30f4, 1); push(ebp);                              /* push ebp */
            ii(0x100e_30f5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_30f7, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100e_30fd, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100e_3100, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100e_3103, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_3106, 5); call(0x100e_3b27, 0xa1c);               /* call 0x100e3b27 */
            ii(0x100e_310b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_310e, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x100e_3111, 5); call(0x1007_6574, -0x6_cba2);           /* call 0x10076574 */
            ii(0x100e_3116, 5); cmp(memw[ds, eax + 8], 0x4e);           /* cmp word [eax+0x8], 0x4e */
            ii(0x100e_311b, 6); if(jnz(0x100e_31de, 0xbd)) goto l_0x100e_31de; /* jnz 0x100e31de */
            ii(0x100e_3121, 5); mov(eax, 2);                            /* mov eax, 0x2 */
            ii(0x100e_3126, 1); push(eax);                              /* push eax */
            ii(0x100e_3127, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_312a, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x100e_312d, 5); call(0x1007_6574, -0x6_cbbe);           /* call 0x10076574 */
            ii(0x100e_3132, 3); mov(ecx, memd[ds, eax + 0x1a]);         /* mov ecx, [eax+0x1a] */
            ii(0x100e_3135, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100e_3138, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_313b, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x100e_313e, 5); call(0x1007_6574, -0x6_cbcf);           /* call 0x10076574 */
            ii(0x100e_3143, 3); mov(ebx, memd[ds, eax + 0x18]);         /* mov ebx, [eax+0x18] */
            ii(0x100e_3146, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100e_3149, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_314c, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x100e_314f, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100e_3151, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_3154, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_3157, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x100e_315a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_315d, 5); call(0x1007_02b9, -0x7_2ea9);           /* call 0x100702b9 */
            ii(0x100e_3162, 1); cwde();                                 /* cwde */
            ii(0x100e_3163, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_3165, 2); if(jnz(0x100e_319f, 0x38)) goto l_0x100e_319f; /* jnz 0x100e319f */
            ii(0x100e_3167, 5); call(0x100c_aa00, -0x1_876c);           /* call 0x100caa00 */
            ii(0x100e_316c, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_3171, 1); push(eax);                              /* push eax */
            ii(0x100e_3172, 5); call(0x100c_aa20, -0x1_8757);           /* call 0x100caa20 */
            ii(0x100e_3177, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100e_3179, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_317b, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100e_3180, 5); mov(eax, StringDefinitions.UnableToActivateUnitAtThisSite); /* mov eax, 0x101a1be7 */
            ii(0x100e_3185, 5); call(0x1011_5d23, 0x3_2b99);            /* call 0x10115d23 */
            ii(0x100e_318a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_318d, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x100e_3190, 5); call(0x1007_65d0, -0x6_cbc5);           /* call 0x100765d0 */
            ii(0x100e_3195, 5); call(0x100f_fa70, 0x1_c8d6);            /* call 0x100ffa70 */
            ii(0x100e_319a, 5); jmp(0x100e_32ba, 0x11b); goto l_0x100e_32ba; /* jmp 0x100e32ba */
        l_0x100e_319f:
            ii(0x100e_319f, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100e_31a2, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_31a5, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x100e_31a8, 5); call(0x1007_6574, -0x6_cc39);           /* call 0x10076574 */
            ii(0x100e_31ad, 5); call(0x1008_a998, -0x5_881a);           /* call 0x1008a998 */
            ii(0x100e_31b2, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_31b4, 5); mov(edx, 0xa);                          /* mov edx, 0xa */
            ii(0x100e_31b9, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_31bc, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x100e_31bf, 5); call(0x1007_65d0, -0x6_cbf4);           /* call 0x100765d0 */
            ii(0x100e_31c4, 5); call(0x1016_3053, 0x7_fe8a);            /* call 0x10163053 */
            ii(0x100e_31c9, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_31cc, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x100e_31cf, 5); call(0x1007_65d0, -0x6_cc04);           /* call 0x100765d0 */
            ii(0x100e_31d4, 5); call(0x100f_fa70, 0x1_c897);            /* call 0x100ffa70 */
            ii(0x100e_31d9, 5); jmp(0x100e_32ba, 0xdc); goto l_0x100e_32ba; /* jmp 0x100e32ba */
        l_0x100e_31de:
            ii(0x100e_31de, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_31e1, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x100e_31e4, 5); call(0x1007_6574, -0x6_cc75);           /* call 0x10076574 */
            ii(0x100e_31e9, 4); test(memb[ds, eax + 0x12], 0x10);       /* test byte [eax+0x12], 0x10 */
            ii(0x100e_31ed, 2); if(jz(0x100e_31f8, 9)) goto l_0x100e_31f8; /* jz 0x100e31f8 */
            ii(0x100e_31ef, 7); mov(memd[ss, ebp - 0x18], 1);           /* mov dword [ebp-0x18], 0x1 */
            ii(0x100e_31f6, 2); jmp(0x100e_31ff, 7); goto l_0x100e_31ff; /* jmp 0x100e31ff */
        l_0x100e_31f8:
            ii(0x100e_31f8, 7); mov(memd[ss, ebp - 0x18], 0);           /* mov dword [ebp-0x18], 0x0 */
        l_0x100e_31ff:
            ii(0x100e_31ff, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100e_3202, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100e_3205, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_3208, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x100e_320b, 5); call(0x1007_6574, -0x6_cc9c);           /* call 0x10076574 */
            ii(0x100e_3210, 4); mov(ax, memw[ds, eax + 0x1a]);          /* mov ax, [eax+0x1a] */
            ii(0x100e_3214, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100e_3217, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_321a, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x100e_321d, 5); call(0x1007_6574, -0x6_ccae);           /* call 0x10076574 */
            ii(0x100e_3222, 4); mov(ax, memw[ds, eax + 0x1c]);          /* mov ax, [eax+0x1c] */
            ii(0x100e_3226, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100e_3229, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_322b, 1); push(eax);                              /* push eax */
            ii(0x100e_322c, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100e_3230, 1); push(eax);                              /* push eax */
            ii(0x100e_3231, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x100e_3236, 1); push(eax);                              /* push eax */
            ii(0x100e_3237, 3); lea(ecx, memd[ss, ebp - 0x14]);         /* lea ecx, [ebp-0x14] */
            ii(0x100e_323a, 3); lea(ebx, memd[ss, ebp - 0xc]);          /* lea ebx, [ebp-0xc] */
            ii(0x100e_323d, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100e_3240, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_3243, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x100e_3246, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_3249, 5); call(0x1007_0efa, -0x7_2354);           /* call 0x10070efa */
            ii(0x100e_324e, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x100e_3251, 2); if(jnz(0x100e_3288, 0x35)) goto l_0x100e_3288; /* jnz 0x100e3288 */
            ii(0x100e_3253, 5); call(0x100c_aa00, -0x1_8858);           /* call 0x100caa00 */
            ii(0x100e_3258, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_325d, 1); push(eax);                              /* push eax */
            ii(0x100e_325e, 5); call(0x100c_aa20, -0x1_8843);           /* call 0x100caa20 */
            ii(0x100e_3263, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100e_3265, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_3267, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100e_326c, 5); mov(eax, StringDefinitions.UnableToActivateUnitAtThisSite2); /* mov eax, 0x101a1c0d */
            ii(0x100e_3271, 5); call(0x1011_5d23, 0x3_2aad);            /* call 0x10115d23 */
            ii(0x100e_3276, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_3279, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x100e_327c, 5); call(0x1007_65d0, -0x6_ccb1);           /* call 0x100765d0 */
            ii(0x100e_3281, 5); call(0x100f_fa70, 0x1_c7ea);            /* call 0x100ffa70 */
            ii(0x100e_3286, 2); jmp(0x100e_32ba, 0x32); goto l_0x100e_32ba; /* jmp 0x100e32ba */
        l_0x100e_3288:
            ii(0x100e_3288, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_328b, 5); call(0x1014_f12b, 0x6_be9b);            /* call 0x1014f12b */
            ii(0x100e_3290, 5); call(0x100c_aa00, -0x1_8895);           /* call 0x100caa00 */
            ii(0x100e_3295, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_329a, 1); push(eax);                              /* push eax */
            ii(0x100e_329b, 5); call(0x100c_aa20, -0x1_8880);           /* call 0x100caa20 */
            ii(0x100e_32a0, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100e_32a2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_32a4, 5); mov(esi, StringDefinitions.SelectAnOpenSquareToPlaceUnit); /* mov esi, 0x101a1c33 */
            ii(0x100e_32a9, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100e_32ab, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x100e_32ad, 5); call(0x1011_5d23, 0x3_2a71);            /* call 0x10115d23 */
            ii(0x100e_32b2, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_32b5, 5); call(0x100f_fa70, 0x1_c7b6);            /* call 0x100ffa70 */
        l_0x100e_32ba:
            ii(0x100e_32ba, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_32bc, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_32bd, 1); pop(edi);                               /* pop edi */
            ii(0x100e_32be, 1); pop(esi);                               /* pop esi */
            ii(0x100e_32bf, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_32c0, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_32c1, 1); ret();                                  /* ret */
        }
    }
}
