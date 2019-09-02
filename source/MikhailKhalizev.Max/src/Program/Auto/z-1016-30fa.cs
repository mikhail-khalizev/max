using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_30fa-acfae59d")]
        public void Method_1016_30fa()
        {
            ii(0x1016_30fa, 5); push(0x38);                             /* push 0x38 */
            ii(0x1016_30ff, 5); call(Definitions.sys_check_available_stack_size, 0x2c4e); /* call 0x10165d52 */
            ii(0x1016_3104, 1); push(ecx);                              /* push ecx */
            ii(0x1016_3105, 1); push(esi);                              /* push esi */
            ii(0x1016_3106, 1); push(edi);                              /* push edi */
            ii(0x1016_3107, 1); push(ebp);                              /* push ebp */
            ii(0x1016_3108, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_310a, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1016_3110, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1016_3113, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1016_3116, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x1016_3119, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1016_311c, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x1016_311f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1016_3122, 3); imul(edx, eax, 0x33);                   /* imul edx, eax, 0x33 */
            ii(0x1016_3125, 5); mov(eax, 0x101c_81c0);                  /* mov eax, 0x101c81c0 */
            ii(0x1016_312a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1016_312c, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1016_312f, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1016_3132, 4); mov(ax, memw[ds, eax + 8]);             /* mov ax, [eax+0x8] */
            ii(0x1016_3136, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1016_3139, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1016_313c, 5); call(0x1007_611c, -0xe_d025);           /* call 0x1007611c */
            ii(0x1016_3141, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_3143, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1016_3146, 5); call(0x1007_66ac, -0xe_ca9f);           /* call 0x100766ac */
            ii(0x1016_314b, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1016_314e, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1016_3153, 5); call(0x1010_3752, -0x5_fa06);           /* call 0x10103752 */
            ii(0x1016_3158, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_315a, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1016_315d, 5); call(0x1013_ad71, -0x2_83f1);           /* call 0x1013ad71 */
            ii(0x1016_3162, 2); test(al, al);                           /* test al, al */
            ii(0x1016_3164, 2); if(jz(0x1016_318a, 0x24)) goto l_0x1016_318a; /* jz 0x1016318a */
            ii(0x1016_3166, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1016_3169, 5); call(0x1007_6600, -0xe_cb6e);           /* call 0x10076600 */
            ii(0x1016_316e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_3170, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1016_3175, 5); call(0x1010_3752, -0x5_fa28);           /* call 0x10103752 */
            ii(0x1016_317a, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1016_317d, 5); call(0x1007_6574, -0xe_cc0e);           /* call 0x10076574 */
            ii(0x1016_3182, 5); call(0x1015_0a9e, -0x1_26e9);           /* call 0x10150a9e */
            ii(0x1016_3187, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
        l_0x1016_318a:
            ii(0x1016_318a, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1016_318d, 3); test(memb[ds, eax], 0x10);              /* test byte [eax], 0x10 */
            ii(0x1016_3190, 2); if(jz(0x1016_31b6, 0x24)) goto l_0x1016_31b6; /* jz 0x101631b6 */
            ii(0x1016_3192, 4); movsx(ecx, memw[ss, ebp - 4]);          /* movsx ecx, word [ebp-0x4] */
            ii(0x1016_3196, 4); movsx(ebx, memw[ss, ebp - 8]);          /* movsx ebx, word [ebp-0x8] */
            ii(0x1016_319a, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1016_319e, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1016_31a1, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1016_31a4, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1016_31a6, 1); cwde();                                 /* cwde */
            ii(0x1016_31a7, 5); call(0x100c_e099, -0x9_5113);           /* call 0x100ce099 */
            ii(0x1016_31ac, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_31b1, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1016_31b4, 2); jmp(0x1016_31fc, 0x46); goto l_0x1016_31fc; /* jmp 0x101631fc */
        l_0x1016_31b6:
            ii(0x1016_31b6, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x1016_31ba, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1016_31be, 5); call(0x1007_3d48, -0xe_f47b);           /* call 0x10073d48 */
            ii(0x1016_31c3, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1016_31c8, 3); cmp(eax, 8);                            /* cmp eax, 0x8 */
            ii(0x1016_31cb, 2); if(jz(0x1016_31f5, 0x28)) goto l_0x1016_31f5; /* jz 0x101631f5 */
            ii(0x1016_31cd, 5); mov(eax, 2);                            /* mov eax, 0x2 */
            ii(0x1016_31d2, 1); push(eax);                              /* push eax */
            ii(0x1016_31d3, 4); movsx(ecx, memw[ss, ebp - 4]);          /* movsx ecx, word [ebp-0x4] */
            ii(0x1016_31d7, 4); movsx(ebx, memw[ss, ebp - 8]);          /* movsx ebx, word [ebp-0x8] */
            ii(0x1016_31db, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1016_31de, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1016_31e1, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1016_31e3, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1016_31e6, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1016_31ea, 5); call(0x1007_02b9, -0xf_2f36);           /* call 0x100702b9 */
            ii(0x1016_31ef, 1); cwde();                                 /* cwde */
            ii(0x1016_31f0, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1016_31f3, 2); jmp(0x1016_31fc, 7); goto l_0x1016_31fc; /* jmp 0x101631fc */
        l_0x1016_31f5:
            ii(0x1016_31f5, 7); mov(memd[ss, ebp - 0x1c], 0);           /* mov dword [ebp-0x1c], 0x0 */
        l_0x1016_31fc:
            ii(0x1016_31fc, 5); call(0x100d_53f0, -0x8_de11);           /* call 0x100d53f0 */
            ii(0x1016_3201, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_3203, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1016_3205, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1016_3208, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1016_320d, 5); call(0x1010_346f, -0x5_fda3);           /* call 0x1010346f */
            ii(0x1016_3212, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_3214, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1016_3217, 5); call(0x1013_ad71, -0x2_84ab);           /* call 0x1013ad71 */
            ii(0x1016_321c, 2); test(al, al);                           /* test al, al */
            ii(0x1016_321e, 2); if(jz(0x1016_323d, 0x1d)) goto l_0x1016_323d; /* jz 0x1016323d */
            ii(0x1016_3220, 5); call(0x100d_53f0, -0x8_de35);           /* call 0x100d53f0 */
            ii(0x1016_3225, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_3227, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1016_3229, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1016_322c, 5); call(0x1007_6600, -0xe_cc31);           /* call 0x10076600 */
            ii(0x1016_3231, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_3233, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1016_3238, 5); call(0x1010_346f, -0x5_fdce);           /* call 0x1010346f */
        l_0x1016_323d:
            ii(0x1016_323d, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1016_3240, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1016_3243, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_3245, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1016_3248, 5); call(0x1007_5f2c, -0xe_d321);           /* call 0x10075f2c */
            ii(0x1016_324d, 2); jmp(0x1016_3259, 0xa); goto l_0x1016_3259; /* jmp 0x10163259 */
        //  ii(0x1016_324f, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1016_3251, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
        //  ii(0x1016_3254, 5); call(0x1007_5f2c, -0xe_d32d);           /* call 0x10075f2c */
        l_0x1016_3259:
            ii(0x1016_3259, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1016_325c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_325e, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_325f, 1); pop(edi);                               /* pop edi */
            ii(0x1016_3260, 1); pop(esi);                               /* pop esi */
            ii(0x1016_3261, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_3262, 1); ret();                                  /* ret */
        }
    }
}
