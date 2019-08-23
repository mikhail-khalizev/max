using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_330b-5cc04bfb")]
        public void Method_1010_330b()
        {
            ii(0x1010_330b, 5); push(0x3c);                             /* push 0x3c */
            ii(0x1010_3310, 5); call(Definitions.sys_check_available_stack_size, 0x6_2a3d); /* call 0x10165d52 */
            ii(0x1010_3315, 1); push(esi);                              /* push esi */
            ii(0x1010_3316, 1); push(edi);                              /* push edi */
            ii(0x1010_3317, 1); push(ebp);                              /* push ebp */
            ii(0x1010_3318, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_331a, 6); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x1010_3320, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1010_3323, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x1010_3326, 3); mov(memd[ss, ebp - 0x4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1010_3329, 3); mov(memd[ss, ebp - 0x8], ecx);          /* mov [ebp-0x8], ecx */
            ii(0x1010_332c, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1010_332f, 2); mov(ecx, memd[ds, edx]);                /* mov ecx, [edx] */
            ii(0x1010_3331, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1010_3334, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1010_3338, 2); shl(edx, cl);                           /* shl edx, cl */
            ii(0x1010_333a, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1010_333e, 2); xor(edx, eax);                          /* xor edx, eax */
            ii(0x1010_3340, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_3343, 3); movsx(ecx, memw[ds, eax]);              /* movsx ecx, word [eax] */
            ii(0x1010_3346, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1010_3348, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1010_334b, 2); idiv(ecx);                              /* idiv ecx */
            ii(0x1010_334d, 3); mov(memd[ss, ebp - 0x14], edx);         /* mov [ebp-0x14], edx */
            ii(0x1010_3350, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1010_3354, 3); imul(eax, eax, 0xa);                    /* imul eax, eax, 0xa */
            ii(0x1010_3357, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1010_335a, 3); mov(edx, memd[ds, edx + 0x4]);          /* mov edx, [edx+0x4] */
            ii(0x1010_335d, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_335f, 3); mov(memd[ss, ebp - 0x18], edx);         /* mov [ebp-0x18], edx */
            ii(0x1010_3362, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1010_3365, 5); call(0x1010_46a4, 0x133a);              /* call 0x101046a4 */
            ii(0x1010_336a, 3); lea(ecx, memd[ss, ebp - 0x1c]);         /* lea ecx, [ebp-0x1c] */
            ii(0x1010_336d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_336f, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1010_3371, 5); call(0x1010_4590, 0x121a);              /* call 0x10104590 */
        l_0x1010_3376:
            ii(0x1010_3376, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_3378, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1010_337b, 5); call(0x1013_ad71, 0x3_79f1);            /* call 0x1013ad71 */
            ii(0x1010_3380, 2); test(al, al);                           /* test al, al */
            ii(0x1010_3382, 2); if(jz(0x1010_33ac, 0x28)) goto l_0x1010_33ac; /* jz 0x101033ac */
            ii(0x1010_3384, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1010_3387, 5); call(0x1010_44b0, 0x1124);              /* call 0x101044b0 */
            ii(0x1010_338c, 5); call(0x1010_4790, 0x13ff);              /* call 0x10104790 */
            ii(0x1010_3391, 4); cmp(ax, memw[ss, ebp - 0x4]);           /* cmp ax, [ebp-0x4] */
            ii(0x1010_3395, 2); if(jnz(0x1010_33aa, 0x13)) goto l_0x1010_33aa; /* jnz 0x101033aa */
            ii(0x1010_3397, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1010_339a, 5); call(0x1010_44b0, 0x1111);              /* call 0x101044b0 */
            ii(0x1010_339f, 5); call(0x1010_475c, 0x13b8);              /* call 0x1010475c */
            ii(0x1010_33a4, 4); cmp(ax, memw[ss, ebp - 0x8]);           /* cmp ax, [ebp-0x8] */
            ii(0x1010_33a8, 2); if(jz(0x1010_33ac, 0x2)) goto l_0x1010_33ac; /* jz 0x101033ac */
        l_0x1010_33aa:
            ii(0x1010_33aa, 2); jmp(0x1010_33ae, 0x2); goto l_0x1010_33ae; /* jmp 0x101033ae */
        l_0x1010_33ac:
            ii(0x1010_33ac, 2); jmp(0x1010_33b8, 0xa); goto l_0x1010_33b8; /* jmp 0x101033b8 */
        l_0x1010_33ae:
            ii(0x1010_33ae, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1010_33b1, 5); call(0x1007_6bf8, -0x8_c7be);           /* call 0x10076bf8 */
            ii(0x1010_33b6, 2); jmp(0x1010_3376, -0x42); goto l_0x1010_3376; /* jmp 0x10103376 */
        l_0x1010_33b8:
            ii(0x1010_33b8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_33ba, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1010_33bd, 5); call(0x1013_ad11, 0x3_794f);            /* call 0x1013ad11 */
            ii(0x1010_33c2, 2); test(al, al);                           /* test al, al */
            ii(0x1010_33c4, 2); if(jz(0x1010_341d, 0x57)) goto l_0x1010_341d; /* jz 0x1010341d */
            ii(0x1010_33c6, 5); mov(eax, 0x14);                         /* mov eax, 0x14 */
            ii(0x1010_33cb, 5); call(Definitions.sys_new, 0x6_2a30);    /* call 0x10165e00 */
            ii(0x1010_33d0, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1010_33d3, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1010_33d6, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1010_33d9, 4); cmp(memd[ss, ebp - 0x24], 0);           /* cmp dword [ebp-0x24], 0x0 */
            ii(0x1010_33dd, 2); if(jz(0x1010_33fa, 0x1b)) goto l_0x1010_33fa; /* jz 0x101033fa */
            ii(0x1010_33df, 4); movsx(ebx, memw[ss, ebp - 0x8]);        /* movsx ebx, word [ebp-0x8] */
            ii(0x1010_33e3, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1010_33e7, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1010_33ea, 5); call(0x1010_3069, -0x386);              /* call 0x10103069 */
            ii(0x1010_33ef, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x1010_33f2, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1010_33f5, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1010_33f8, 2); jmp(0x1010_3400, 0x6); goto l_0x1010_3400; /* jmp 0x10103400 */
        l_0x1010_33fa:
            ii(0x1010_33fa, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1010_33fd, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
        l_0x1010_3400:
            ii(0x1010_3400, 3); mov(edx, memd[ss, ebp - 0x2c]);         /* mov edx, [ebp-0x2c] */
            ii(0x1010_3403, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1010_3406, 5); call(0x1010_4644, 0x1239);              /* call 0x10104644 */
            ii(0x1010_340b, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1010_340e, 5); call(0x1010_46a4, 0x1291);              /* call 0x101046a4 */
            ii(0x1010_3413, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_3415, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1010_3418, 5); call(0x1010_4514, 0x10f7);              /* call 0x10104514 */
        l_0x1010_341d:
            ii(0x1010_341d, 4); cmp(memb[ss, ebp + 0x10], 0);           /* cmp byte [ebp+0x10], 0x0 */
            ii(0x1010_3421, 2); if(jz(0x1010_342d, 0xa)) goto l_0x1010_342d; /* jz 0x1010342d */
            ii(0x1010_3423, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1010_3426, 5); cmp(memw[ds, eax + 0x8], 0xf);          /* cmp word [eax+0x8], 0xf */
            ii(0x1010_342b, 2); if(jnz(0x1010_342f, 0x2)) goto l_0x1010_342f; /* jnz 0x1010342f */
        l_0x1010_342d:
            ii(0x1010_342d, 2); jmp(0x1010_3439, 0xa); goto l_0x1010_3439; /* jmp 0x10103439 */
        l_0x1010_342f:
            ii(0x1010_342f, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1010_3432, 5); cmp(memw[ds, eax + 0x8], 0x10);         /* cmp word [eax+0x8], 0x10 */
            ii(0x1010_3437, 2); if(jnz(0x1010_343b, 0x2)) goto l_0x1010_343b; /* jnz 0x1010343b */
        l_0x1010_3439:
            ii(0x1010_3439, 2); jmp(0x1010_344d, 0x12); goto l_0x1010_344d; /* jmp 0x1010344d */
        l_0x1010_343b:
            ii(0x1010_343b, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1010_343e, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1010_3441, 5); call(0x1010_44b0, 0x106a);              /* call 0x101044b0 */
            ii(0x1010_3446, 5); call(0x1010_4828, 0x13dd);              /* call 0x10104828 */
            ii(0x1010_344b, 2); jmp(0x1010_345d, 0x10); goto l_0x1010_345d; /* jmp 0x1010345d */
        l_0x1010_344d:
            ii(0x1010_344d, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1010_3450, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1010_3453, 5); call(0x1010_44b0, 0x1058);              /* call 0x101044b0 */
            ii(0x1010_3458, 5); call(0x1010_485c, 0x13ff);              /* call 0x1010485c */
        l_0x1010_345d:
            ii(0x1010_345d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_345f, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1010_3462, 5); call(0x1010_4470, 0x1009);              /* call 0x10104470 */
            ii(0x1010_3467, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_3469, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_346a, 1); pop(edi);                               /* pop edi */
            ii(0x1010_346b, 1); pop(esi);                               /* pop esi */
            ii(0x1010_346c, 3); ret(0x4);                               /* ret 0x4 */
        }
    }
}
