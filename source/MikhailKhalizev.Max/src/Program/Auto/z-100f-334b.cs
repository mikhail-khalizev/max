using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3807d877-d56d-4ed8-bdec-665709a5dabd")]
        public void Method_100f_334b()
        {
            ii(0x100f_334b, 5); pushd(0x40);                            /* push 0x40 */
            ii(0x100f_3350, 5); calld(Definitions.sys_check_available_stack_size, 0x729fd); /* call 0x10165d52 */
            ii(0x100f_3355, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_3356, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_3357, 1); pushd(esi);                             /* push esi */
            ii(0x100f_3358, 1); pushd(edi);                             /* push edi */
            ii(0x100f_3359, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_335a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_335c, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100f_3362, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100f_3365, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x100f_3368, 7); mov(memd_a32[ss, ebp - 0xc], 0xa2);     /* mov dword [ebp-0xc], 0xa2 */
            ii(0x100f_336f, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100f_3373, 3); cmp(eax, 0x14);                         /* cmp eax, 0x14 */
            ii(0x100f_3376, 6); if(jgd(0x100f_3431, 0xb5)) goto l_0x100f_3431; /* jg 0x100f3431 */
            ii(0x100f_337c, 7); cmp(memb_a32[ds, 0x101c_37d3], 0);      /* cmp byte [0x101c37d3], 0x0 */
            ii(0x100f_3383, 2); if(jzd(0x100f_3392, 0xd)) goto l_0x100f_3392; /* jz 0x100f3392 */
            ii(0x100f_3385, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_338a, 6); cmp(al, memb_a32[ds, 0x101c_37c8]);     /* cmp al, [0x101c37c8] */
            ii(0x100f_3390, 2); if(jzd(0x100f_3397, 0x5)) goto l_0x100f_3397; /* jz 0x100f3397 */
        l_0x100f_3392:
            ii(0x100f_3392, 5); jmpd(0x100f_342a, 0x93); goto l_0x100f_342a; /* jmp 0x100f342a */
        l_0x100f_3397:
            ii(0x100f_3397, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100f_339b, 3); cmp(eax, 0x14);                         /* cmp eax, 0x14 */
            ii(0x100f_339e, 2); if(jnzd(0x100f_33af, 0xf)) goto l_0x100f_33af; /* jnz 0x100f33af */
            ii(0x100f_33a0, 5); mov(eax, 0x46);                         /* mov eax, 0x46 */
            ii(0x100f_33a5, 5); calld(0x1007_5fdc, -0x7d3ce);           /* call 0x10075fdc */
            ii(0x100f_33aa, 3); cmp(eax, 0x14);                         /* cmp eax, 0x14 */
            ii(0x100f_33ad, 2); if(jgd(0x100f_33b1, 0x2)) goto l_0x100f_33b1; /* jg 0x100f33b1 */
        l_0x100f_33af:
            ii(0x100f_33af, 2); jmpd(0x100f_33cf, 0x1e); goto l_0x100f_33cf; /* jmp 0x100f33cf */
        l_0x100f_33b1:
            ii(0x100f_33b1, 5); calld(0x100d_5470, -0x1df46);           /* call 0x100d5470 */
            ii(0x100f_33b6, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100f_33b9, 5); mov(ebx, 0x459);                        /* mov ebx, 0x459 */
            ii(0x100f_33be, 5); mov(edx, 0x456);                        /* mov edx, 0x456 */
            ii(0x100f_33c3, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_33c8, 5); calld(0x1013_daea, 0x4a71d);            /* call 0x1013daea */
            ii(0x100f_33cd, 2); jmpd(0x100f_3423, 0x54); goto l_0x100f_3423; /* jmp 0x100f3423 */
        l_0x100f_33cf:
            ii(0x100f_33cf, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_33d1, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_33d6, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_33dc, 6); mov(al, memb_a32[ds, eax + 0x101c_a491]); /* mov al, [eax+0x101ca491] */
            ii(0x100f_33e2, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_33e7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_33e9, 2); if(jnzd(0x100f_33fa, 0xf)) goto l_0x100f_33fa; /* jnz 0x100f33fa */
            ii(0x100f_33eb, 5); mov(eax, 0x46);                         /* mov eax, 0x46 */
            ii(0x100f_33f0, 5); calld(0x1007_5fdc, -0x7d419);           /* call 0x10075fdc */
            ii(0x100f_33f5, 3); cmp(eax, 0x14);                         /* cmp eax, 0x14 */
            ii(0x100f_33f8, 2); if(jgd(0x100f_33fc, 0x2)) goto l_0x100f_33fc; /* jg 0x100f33fc */
        l_0x100f_33fa:
            ii(0x100f_33fa, 2); jmpd(0x100f_3405, 0x9); goto l_0x100f_3405; /* jmp 0x100f3405 */
        l_0x100f_33fc:
            ii(0x100f_33fc, 7); cmp(memb_a32[ds, 0x101c_3970], 0);      /* cmp byte [0x101c3970], 0x0 */
            ii(0x100f_3403, 2); if(jnzd(0x100f_3407, 0x2)) goto l_0x100f_3407; /* jnz 0x100f3407 */
        l_0x100f_3405:
            ii(0x100f_3405, 2); jmpd(0x100f_3423, 0x1c); goto l_0x100f_3423; /* jmp 0x100f3423 */
        l_0x100f_3407:
            ii(0x100f_3407, 5); calld(0x100d_5470, -0x1df9c);           /* call 0x100d5470 */
            ii(0x100f_340c, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100f_340f, 5); mov(ebx, 0x45b);                        /* mov ebx, 0x45b */
            ii(0x100f_3414, 5); mov(edx, 0x45a);                        /* mov edx, 0x45a */
            ii(0x100f_3419, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_341e, 5); calld(0x1013_daea, 0x4a6c7);            /* call 0x1013daea */
        l_0x100f_3423:
            ii(0x100f_3423, 7); mov(memb_a32[ds, 0x101c_37d3], 0);      /* mov byte [0x101c37d3], 0x0 */
        l_0x100f_342a:
            ii(0x100f_342a, 7); mov(memd_a32[ss, ebp - 0xc], 0x1);      /* mov dword [ebp-0xc], 0x1 */
        l_0x100f_3431:
            ii(0x100f_3431, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100f_3435, 5); mov(ebx, 0x3c);                         /* mov ebx, 0x3c */
            ii(0x100f_343a, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_343c, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_343f, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100f_3441, 1); pushd(edx);                             /* push edx */
            ii(0x100f_3442, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100f_3446, 5); mov(ebx, 0x3c);                         /* mov ebx, 0x3c */
            ii(0x100f_344b, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_344d, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_3450, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100f_3452, 1); pushd(eax);                             /* push eax */
            ii(0x100f_3453, 5); mov(eax, StringDefinitions._22i22i);    /* mov eax, 0x101a2478 */
            ii(0x100f_3458, 1); pushd(eax);                             /* push eax */
            ii(0x100f_3459, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100f_345c, 1); pushd(eax);                             /* push eax */
            ii(0x100f_345d, 5); calld(Definitions.sys_sprintf, 0x72a9f); /* call 0x10165f01 */
            ii(0x100f_3462, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x100f_3465, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100f_3469, 2); if(jzd(0x100f_3478, 0xd)) goto l_0x100f_3478; /* jz 0x100f3478 */
            ii(0x100f_346b, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100f_346e, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100f_3471, 5); calld(0x100f_3033, -0x443);             /* call 0x100f3033 */
            ii(0x100f_3476, 2); jmpd(0x100f_3491, 0x19); goto l_0x100f_3491; /* jmp 0x100f3491 */
        l_0x100f_3478:
            ii(0x100f_3478, 5); calld(0x1010_2a34, 0xf5b7);             /* call 0x10102a34 */
            ii(0x100f_347d, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x100f_3480, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x100f_3483, 5); mov(esi, 0x3);                          /* mov esi, 0x3 */
            ii(0x100f_3488, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100f_348a, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x100f_348c, 5); calld(0x100f_3176, -0x31b);             /* call 0x100f3176 */
        l_0x100f_3491:
            ii(0x100f_3491, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_3493, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_3494, 1); popd(edi);                              /* pop edi */
            ii(0x100f_3495, 1); popd(esi);                              /* pop esi */
            ii(0x100f_3496, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_3497, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_3498, 1); retd(); return;                         /* ret */
        }
    }
}
