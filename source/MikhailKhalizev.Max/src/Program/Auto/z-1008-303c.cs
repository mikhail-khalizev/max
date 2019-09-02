using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_303c-db348371")]
        public void Method_1008_303c()
        {
            ii(0x1008_303c, 5); push(0x28);                             /* push 0x28 */
            ii(0x1008_3041, 5); call(Definitions.sys_check_available_stack_size, 0xe_2d0c); /* call 0x10165d52 */
            ii(0x1008_3046, 1); push(ebx);                              /* push ebx */
            ii(0x1008_3047, 1); push(ecx);                              /* push ecx */
            ii(0x1008_3048, 1); push(edx);                              /* push edx */
            ii(0x1008_3049, 1); push(esi);                              /* push esi */
            ii(0x1008_304a, 1); push(edi);                              /* push edi */
            ii(0x1008_304b, 1); push(ebp);                              /* push ebp */
            ii(0x1008_304c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_304e, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_3054, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1008_3057, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_3059, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_305c, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_305f, 5); call(0x1013_ad11, 0xb_7cad);            /* call 0x1013ad11 */
            ii(0x1008_3064, 2); test(al, al);                           /* test al, al */
            ii(0x1008_3066, 6); if(jnz(0x1008_31e6, 0x17a)) goto l_0x1008_31e6; /* jnz 0x100831e6 */
            ii(0x1008_306c, 3); lea(ebx, memd[ss, ebp - 8]);            /* lea ebx, [ebp-0x8] */
            ii(0x1008_306f, 3); lea(edx, memd[ss, ebp - 12]);           /* lea edx, [ebp-0xc] */
            ii(0x1008_3072, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_3075, 5); call(0x1008_2de2, -0x298);              /* call 0x10082de2 */
            ii(0x1008_307a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_307c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_307f, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1008_3082, 5); call(0x1013_ad71, 0xb_7cea);            /* call 0x1013ad71 */
            ii(0x1008_3087, 2); test(al, al);                           /* test al, al */
            ii(0x1008_3089, 2); if(jz(0x1008_30db, 0x50)) goto l_0x1008_30db; /* jz 0x100830db */
            ii(0x1008_308b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_308e, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1008_3091, 5); call(0x1007_6574, -0xcb22);             /* call 0x10076574 */
            ii(0x1008_3096, 5); cmp(memw[ds, eax + 8], 0x4f);           /* cmp word [eax+0x8], 0x4f */
            ii(0x1008_309b, 2); if(jnz(0x1008_30bd, 0x20)) goto l_0x1008_30bd; /* jnz 0x100830bd */
            ii(0x1008_309d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_30a0, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1008_30a3, 5); call(0x1007_6574, -0xcb34);             /* call 0x10076574 */
            ii(0x1008_30a8, 5); call(0x1007_623c, -0xce71);             /* call 0x1007623c */
            ii(0x1008_30ad, 4); mov(ax, memw[ds, eax + 23]);            /* mov ax, [eax+0x17] */
            ii(0x1008_30b1, 4); cmp(ax, memw[ss, ebp - 12]);            /* cmp ax, [ebp-0xc] */
            ii(0x1008_30b5, 6); if(jge(0x1008_31e6, 0x12b)) goto l_0x1008_31e6; /* jge 0x100831e6 */
            ii(0x1008_30bb, 2); jmp(0x1008_30db, 0x1e); goto l_0x1008_30db; /* jmp 0x100830db */
        l_0x1008_30bd:
            ii(0x1008_30bd, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_30c0, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1008_30c3, 5); call(0x1007_6574, -0xcb54);             /* call 0x10076574 */
            ii(0x1008_30c8, 5); call(0x1007_623c, -0xce91);             /* call 0x1007623c */
            ii(0x1008_30cd, 4); mov(ax, memw[ds, eax + 23]);            /* mov ax, [eax+0x17] */
            ii(0x1008_30d1, 4); cmp(ax, memw[ss, ebp - 8]);             /* cmp ax, [ebp-0x8] */
            ii(0x1008_30d5, 6); if(jge(0x1008_31e6, 0x10b)) goto l_0x1008_31e6; /* jge 0x100831e6 */
        l_0x1008_30db:
            ii(0x1008_30db, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_30de, 4); test(memb[ds, eax + 58], 0x80);         /* test byte [eax+0x3a], 0x80 */
            ii(0x1008_30e2, 2); if(jz(0x1008_3137, 0x53)) goto l_0x1008_3137; /* jz 0x10083137 */
            ii(0x1008_30e4, 4); movsx(ebx, memw[ss, ebp - 8]);          /* movsx ebx, word [ebp-0x8] */
            ii(0x1008_30e8, 5); mov(edx, 0x44);                         /* mov edx, 0x44 */
            ii(0x1008_30ed, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_30f0, 5); call(0x1008_288a, -0x86b);              /* call 0x1008288a */
            ii(0x1008_30f5, 2); test(al, al);                           /* test al, al */
            ii(0x1008_30f7, 2); if(jnz(0x1008_310e, 0x15)) goto l_0x1008_310e; /* jnz 0x1008310e */
            ii(0x1008_30f9, 4); movsx(ebx, memw[ss, ebp - 12]);         /* movsx ebx, word [ebp-0xc] */
            ii(0x1008_30fd, 5); mov(edx, 0x4f);                         /* mov edx, 0x4f */
            ii(0x1008_3102, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_3105, 5); call(0x1008_288a, -0x880);              /* call 0x1008288a */
            ii(0x1008_310a, 2); test(al, al);                           /* test al, al */
            ii(0x1008_310c, 2); if(jz(0x1008_3110, 2)) goto l_0x1008_3110; /* jz 0x10083110 */
        l_0x1008_310e:
            ii(0x1008_310e, 2); jmp(0x1008_3132, 0x22); goto l_0x1008_3132; /* jmp 0x10083132 */
        l_0x1008_3110:
            ii(0x1008_3110, 4); movsx(ebx, memw[ss, ebp - 8]);          /* movsx ebx, word [ebp-0x8] */
            ii(0x1008_3114, 5); mov(edx, 0x44);                         /* mov edx, 0x44 */
            ii(0x1008_3119, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_311c, 5); call(0x1008_2593, -0xb8e);              /* call 0x10082593 */
            ii(0x1008_3121, 4); movsx(ebx, memw[ss, ebp - 12]);         /* movsx ebx, word [ebp-0xc] */
            ii(0x1008_3125, 5); mov(edx, 0x4f);                         /* mov edx, 0x4f */
            ii(0x1008_312a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_312d, 5); call(0x1008_2593, -0xb9f);              /* call 0x10082593 */
        l_0x1008_3132:
            ii(0x1008_3132, 5); jmp(0x1008_31e6, 0xaf); goto l_0x1008_31e6; /* jmp 0x100831e6 */
        l_0x1008_3137:
            ii(0x1008_3137, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_313a, 4); test(memb[ds, eax + 59], 1);            /* test byte [eax+0x3b], 0x1 */
            ii(0x1008_313e, 6); if(jz(0x1008_31c2, 0x7e)) goto l_0x1008_31c2; /* jz 0x100831c2 */
            ii(0x1008_3144, 4); movsx(ebx, memw[ss, ebp - 8]);          /* movsx ebx, word [ebp-0x8] */
            ii(0x1008_3148, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x1008_314d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_3150, 5); call(0x1008_288a, -0x8cb);              /* call 0x1008288a */
            ii(0x1008_3155, 2); test(al, al);                           /* test al, al */
            ii(0x1008_3157, 2); if(jnz(0x1008_316e, 0x15)) goto l_0x1008_316e; /* jnz 0x1008316e */
            ii(0x1008_3159, 4); movsx(ebx, memw[ss, ebp - 8]);          /* movsx ebx, word [ebp-0x8] */
            ii(0x1008_315d, 5); mov(edx, 0x3a);                         /* mov edx, 0x3a */
            ii(0x1008_3162, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_3165, 5); call(0x1008_288a, -0x8e0);              /* call 0x1008288a */
            ii(0x1008_316a, 2); test(al, al);                           /* test al, al */
            ii(0x1008_316c, 2); if(jz(0x1008_3170, 2)) goto l_0x1008_3170; /* jz 0x10083170 */
        l_0x1008_316e:
            ii(0x1008_316e, 2); jmp(0x1008_3185, 0x15); goto l_0x1008_3185; /* jmp 0x10083185 */
        l_0x1008_3170:
            ii(0x1008_3170, 4); movsx(ebx, memw[ss, ebp - 12]);         /* movsx ebx, word [ebp-0xc] */
            ii(0x1008_3174, 5); mov(edx, 0x4f);                         /* mov edx, 0x4f */
            ii(0x1008_3179, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_317c, 5); call(0x1008_288a, -0x8f7);              /* call 0x1008288a */
            ii(0x1008_3181, 2); test(al, al);                           /* test al, al */
            ii(0x1008_3183, 2); if(jz(0x1008_3187, 2)) goto l_0x1008_3187; /* jz 0x10083187 */
        l_0x1008_3185:
            ii(0x1008_3185, 2); jmp(0x1008_319c, 0x15); goto l_0x1008_319c; /* jmp 0x1008319c */
        l_0x1008_3187:
            ii(0x1008_3187, 4); movsx(ebx, memw[ss, ebp - 8]);          /* movsx ebx, word [ebp-0x8] */
            ii(0x1008_318b, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x1008_3190, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_3193, 5); call(0x1008_2593, -0xc05);              /* call 0x10082593 */
            ii(0x1008_3198, 2); test(al, al);                           /* test al, al */
            ii(0x1008_319a, 2); if(jz(0x1008_319e, 2)) goto l_0x1008_319e; /* jz 0x1008319e */
        l_0x1008_319c:
            ii(0x1008_319c, 2); jmp(0x1008_31c0, 0x22); goto l_0x1008_31c0; /* jmp 0x100831c0 */
        l_0x1008_319e:
            ii(0x1008_319e, 4); movsx(ebx, memw[ss, ebp - 8]);          /* movsx ebx, word [ebp-0x8] */
            ii(0x1008_31a2, 5); mov(edx, 0x3a);                         /* mov edx, 0x3a */
            ii(0x1008_31a7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_31aa, 5); call(0x1008_2593, -0xc1c);              /* call 0x10082593 */
            ii(0x1008_31af, 4); movsx(ebx, memw[ss, ebp - 12]);         /* movsx ebx, word [ebp-0xc] */
            ii(0x1008_31b3, 5); mov(edx, 0x4f);                         /* mov edx, 0x4f */
            ii(0x1008_31b8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_31bb, 5); call(0x1008_2593, -0xc2d);              /* call 0x10082593 */
        l_0x1008_31c0:
            ii(0x1008_31c0, 2); jmp(0x1008_31e6, 0x24); goto l_0x1008_31e6; /* jmp 0x100831e6 */
        l_0x1008_31c2:
            ii(0x1008_31c2, 4); movsx(ebx, memw[ss, ebp - 12]);         /* movsx ebx, word [ebp-0xc] */
            ii(0x1008_31c6, 5); mov(edx, 0x4f);                         /* mov edx, 0x4f */
            ii(0x1008_31cb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_31ce, 5); call(0x1008_288a, -0x949);              /* call 0x1008288a */
            ii(0x1008_31d3, 2); test(al, al);                           /* test al, al */
            ii(0x1008_31d5, 2); if(jnz(0x1008_31e6, 0xf)) goto l_0x1008_31e6; /* jnz 0x100831e6 */
            ii(0x1008_31d7, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1008_31d9, 5); mov(edx, 0x4f);                         /* mov edx, 0x4f */
            ii(0x1008_31de, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_31e1, 5); call(0x1008_2593, -0xc53);              /* call 0x10082593 */
        l_0x1008_31e6:
            ii(0x1008_31e6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_31e8, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_31e9, 1); pop(edi);                               /* pop edi */
            ii(0x1008_31ea, 1); pop(esi);                               /* pop esi */
            ii(0x1008_31eb, 1); pop(edx);                               /* pop edx */
            ii(0x1008_31ec, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_31ed, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_31ee, 1); ret();                                  /* ret */
        }
    }
}
