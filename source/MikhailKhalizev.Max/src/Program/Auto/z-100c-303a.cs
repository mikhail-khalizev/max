using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_303a-e1a6da0f")]
        public void Method_100c_303a()
        {
            ii(0x100c_303a, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x100c_303f, 5); calld(Definitions.sys_check_available_stack_size, 0xa_2d0e); /* call 0x10165d52 */
            ii(0x100c_3044, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_3045, 1); pushd(esi);                             /* push esi */
            ii(0x100c_3046, 1); pushd(edi);                             /* push edi */
            ii(0x100c_3047, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_3048, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_304a, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x100c_3050, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_3053, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_3056, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100c_3059, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x100c_305e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_3061, 3); mov(ebx, memd_a32[ds, eax + 0x6]);      /* mov ebx, [eax+0x6] */
            ii(0x100c_3064, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100c_3067, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x100c_306a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_306d, 5); calld(0x100c_27f0, -0x882);             /* call 0x100c27f0 */
            ii(0x100c_3072, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_3075, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x100c_3078, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100c_307b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_307e, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x100c_3081, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_3084, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100c_3087, 5); calld(0x1007_6aac, -0x4_c5e0);          /* call 0x10076aac */
            ii(0x100c_308c, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100c_3090, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_3093, 5); calld(0x100b_87da, -0xa8be);            /* call 0x100b87da */
            ii(0x100c_3098, 1); cwde();                                 /* cwde */
            ii(0x100c_3099, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_309b, 2); if(jnzd(0x100c_30b0, 0x13)) goto l_0x100c_30b0; /* jnz 0x100c30b0 */
            ii(0x100c_309d, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
            ii(0x100c_30a1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_30a3, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_30a6, 5); calld(0x1008_8dcc, -0x3_a2df);          /* call 0x10088dcc */
            ii(0x100c_30ab, 5); jmpd(0x100c_3172, 0xc2); goto l_0x100c_3172; /* jmp 0x100c3172 */
        l_0x100c_30b0:
            ii(0x100c_30b0, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100c_30b4, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100c_30b7, 6); mov(al, memb_a32[ds, eax + 0x101c_81d4]); /* mov al, [eax+0x101c81d4] */
            ii(0x100c_30bd, 3); mov(memb_a32[ss, ebp - 0x14], al);      /* mov [ebp-0x14], al */
            ii(0x100c_30c0, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100c_30c4, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_30c7, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100c_30ca, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100c_30d0, 6); mov(eax, memd_a32[ds, eax + 0x101c_a562]); /* mov eax, [eax+0x101ca562] */
            ii(0x100c_30d6, 5); calld(0x1008_b104, -0x3_7fd7);          /* call 0x1008b104 */
            ii(0x100c_30db, 4); mov(ax, memw_a32[ds, eax + 0x12]);      /* mov ax, [eax+0x12] */
            ii(0x100c_30df, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100c_30e2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_30e4, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x100c_30e7, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100c_30ea, 2); if(jnzd(0x100c_310b, 0x1f)) goto l_0x100c_310b; /* jnz 0x100c310b */
            ii(0x100c_30ec, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100c_30f1, 4); movsx(ecx, memw_a32[ss, ebp - 0x20]);   /* movsx ecx, word [ebp-0x20] */
            ii(0x100c_30f5, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x100c_30f8, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100c_30fb, 5); calld(0x1007_5e64, -0x4_d29c);          /* call 0x10075e64 */
            ii(0x100c_3100, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x100c_3102, 5); calld(0x100c_2fc1, -0x146);             /* call 0x100c2fc1 */
            ii(0x100c_3107, 2); test(al, al);                           /* test al, al */
            ii(0x100c_3109, 2); if(jzd(0x100c_310d, 0x2)) goto l_0x100c_310d; /* jz 0x100c310d */
        l_0x100c_310b:
            ii(0x100c_310b, 2); jmpd(0x100c_311d, 0x10); goto l_0x100c_311d; /* jmp 0x100c311d */
        l_0x100c_310d:
            ii(0x100c_310d, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
            ii(0x100c_3111, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_3113, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_3116, 5); calld(0x1008_8dcc, -0x3_a34f);          /* call 0x10088dcc */
            ii(0x100c_311b, 2); jmpd(0x100c_3172, 0x55); goto l_0x100c_3172; /* jmp 0x100c3172 */
        l_0x100c_311d:
            ii(0x100c_311d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_311f, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x100c_3122, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100c_3125, 2); if(jnzd(0x100c_3146, 0x1f)) goto l_0x100c_3146; /* jnz 0x100c3146 */
            ii(0x100c_3127, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x100c_312c, 4); movsx(ecx, memw_a32[ss, ebp - 0x20]);   /* movsx ecx, word [ebp-0x20] */
            ii(0x100c_3130, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x100c_3133, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100c_3136, 5); calld(0x1007_5e64, -0x4_d2d7);          /* call 0x10075e64 */
            ii(0x100c_313b, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x100c_313d, 5); calld(0x100c_2fc1, -0x181);             /* call 0x100c2fc1 */
            ii(0x100c_3142, 2); test(al, al);                           /* test al, al */
            ii(0x100c_3144, 2); if(jzd(0x100c_3148, 0x2)) goto l_0x100c_3148; /* jz 0x100c3148 */
        l_0x100c_3146:
            ii(0x100c_3146, 2); jmpd(0x100c_3158, 0x10); goto l_0x100c_3158; /* jmp 0x100c3158 */
        l_0x100c_3148:
            ii(0x100c_3148, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
            ii(0x100c_314c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_314e, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_3151, 5); calld(0x1008_8dcc, -0x3_a38a);          /* call 0x10088dcc */
            ii(0x100c_3156, 2); jmpd(0x100c_3172, 0x1a); goto l_0x100c_3172; /* jmp 0x100c3172 */
        l_0x100c_3158:
            ii(0x100c_3158, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x100c_315c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_315e, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_3161, 5); calld(0x1008_8dcc, -0x3_a39a);          /* call 0x10088dcc */
            ii(0x100c_3166, 2); jmpd(0x100c_3172, 0xa); goto l_0x100c_3172; /* jmp 0x100c3172 */
        //    ii(0x100c_3168, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x100c_316a, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
        //    ii(0x100c_316d, 5); calld(0x1008_8dcc, -0x3_a3a6);          /* call 0x10088dcc */
        l_0x100c_3172:
            ii(0x100c_3172, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x100c_3175, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_3177, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_3178, 1); popd(edi);                              /* pop edi */
            ii(0x100c_3179, 1); popd(esi);                              /* pop esi */
            ii(0x100c_317a, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_317b, 1); retd(); return;                         /* ret */
        }
    }
}
