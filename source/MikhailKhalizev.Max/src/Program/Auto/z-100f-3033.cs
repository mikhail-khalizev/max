using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a72c3555-818a-408e-bfad-bc5ddf212965")]
        public void Method_100f_3033()
        {
            ii(0x100f_3033, 5); pushd(0x74);                            /* push 0x74 */
            ii(0x100f_3038, 5); calld(Definitions.sys_check_available_stack_size, 0x7_2d15); /* call 0x10165d52 */
            ii(0x100f_303d, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_303e, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_303f, 1); pushd(esi);                             /* push esi */
            ii(0x100f_3040, 1); pushd(edi);                             /* push edi */
            ii(0x100f_3041, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_3042, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_3044, 6); sub(esp, 0x44);                         /* sub esp, 0x44 */
            ii(0x100f_304a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100f_304d, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100f_3050, 7); mov(memd_a32[ss, ebp - 0x18], 0x20c);   /* mov dword [ebp-0x18], 0x20c */
            ii(0x100f_3057, 7); mov(memd_a32[ss, ebp - 0x14], 0xa);     /* mov dword [ebp-0x14], 0xa */
            ii(0x100f_305e, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100f_3061, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x100f_3064, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100f_3067, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100f_306a, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x100f_306d, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100f_3070, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x100f_3073, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100f_3076, 5); calld(/* sys */ 0x1016_7df0, 0x7_4d75); /* call 0x10167df0 */
            ii(0x100f_307b, 3); mov(memd_a32[ss, ebp - 0x22], eax);     /* mov [ebp-0x22], eax */
            ii(0x100f_307e, 3); mov(eax, memd_a32[ss, ebp - 0x22]);     /* mov eax, [ebp-0x22] */
            ii(0x100f_3081, 5); calld(/* sys */ 0x1016_7dd4, 0x7_4d4e); /* call 0x10167dd4 */
            ii(0x100f_3086, 3); mov(memd_a32[ss, ebp - 0x1e], eax);     /* mov [ebp-0x1e], eax */
            ii(0x100f_3089, 7); mov(memd_a32[ss, ebp - 0x34], 0);       /* mov dword [ebp-0x34], 0x0 */
            ii(0x100f_3090, 7); mov(memd_a32[ss, ebp - 0x30], 0);       /* mov dword [ebp-0x30], 0x0 */
            ii(0x100f_3097, 7); mov(memd_a32[ss, ebp - 0x2c], 0x280);   /* mov dword [ebp-0x2c], 0x280 */
            ii(0x100f_309e, 7); mov(memd_a32[ss, ebp - 0x28], 0x1e0);   /* mov dword [ebp-0x28], 0x1e0 */
            ii(0x100f_30a5, 6); mov(memw_a32[ss, ebp - 0x24], 0x280);   /* mov word [ebp-0x24], 0x280 */
            ii(0x100f_30ab, 7); cmp(memd_a32[ds, 0x101c_39ac], 0);      /* cmp dword [0x101c39ac], 0x0 */
            ii(0x100f_30b2, 2); if(jnzd(0x100f_3114, 0x60)) goto l_0x100f_3114; /* jnz 0x100f3114 */
            ii(0x100f_30b4, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100f_30b9, 5); calld(Definitions.sys_new, 0x7_2d42);   /* call 0x10165e00 */
            ii(0x100f_30be, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x100f_30c1, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x100f_30c4, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x100f_30c7, 4); cmp(memd_a32[ss, ebp - 0x3c], 0);       /* cmp dword [ebp-0x3c], 0x0 */
            ii(0x100f_30cb, 2); if(jzd(0x100f_30f9, 0x2c)) goto l_0x100f_30f9; /* jz 0x100f30f9 */
            ii(0x100f_30cd, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_30d0, 3); sub(eax, memd_a32[ss, ebp - 0x14]);     /* sub eax, [ebp-0x14] */
            ii(0x100f_30d3, 1); cwde();                                 /* cwde */
            ii(0x100f_30d4, 1); pushd(eax);                             /* push eax */
            ii(0x100f_30d5, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_30d8, 3); sub(eax, memd_a32[ss, ebp - 0x18]);     /* sub eax, [ebp-0x18] */
            ii(0x100f_30db, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100f_30de, 4); movsx(ebx, memw_a32[ss, ebp - 0x14]);   /* movsx ebx, word [ebp-0x14] */
            ii(0x100f_30e2, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x100f_30e6, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x100f_30e9, 5); calld(0x100d_7bdc, -0x1_b512);          /* call 0x100d7bdc */
            ii(0x100f_30ee, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x100f_30f1, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x100f_30f4, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x100f_30f7, 2); jmpd(0x100f_30ff, 0x6); goto l_0x100f_30ff; /* jmp 0x100f30ff */
        l_0x100f_30f9:
            ii(0x100f_30f9, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x100f_30fc, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
        l_0x100f_30ff:
            ii(0x100f_30ff, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x100f_3102, 5); mov(memd_a32[ds, 0x101c_39ac], eax);    /* mov [0x101c39ac], eax */
            ii(0x100f_3107, 3); lea(edx, ebp - 0x34);                   /* lea edx, [ebp-0x34] */
            ii(0x100f_310a, 5); mov(eax, memd_a32[ds, 0x101c_39ac]);    /* mov eax, [0x101c39ac] */
            ii(0x100f_310f, 5); calld(0x100d_7d74, -0x1_b3a0);          /* call 0x100d7d74 */
        l_0x100f_3114:
            ii(0x100f_3114, 3); lea(edx, ebp - 0x34);                   /* lea edx, [ebp-0x34] */
            ii(0x100f_3117, 5); mov(eax, memd_a32[ds, 0x101c_39ac]);    /* mov eax, [0x101c39ac] */
            ii(0x100f_311c, 5); calld(0x100d_7f6c, -0x1_b1b5);          /* call 0x100d7f6c */
            ii(0x100f_3121, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x100f_3126, 5); calld(/* sys */ 0x1016_a24c, 0x7_7121); /* call 0x1016a24c */
            ii(0x100f_312b, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100f_3130, 1); pushd(eax);                             /* push eax */
            ii(0x100f_3131, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100f_3136, 1); pushd(eax);                             /* push eax */
            ii(0x100f_3137, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_313a, 1); pushd(eax);                             /* push eax */
            ii(0x100f_313b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_313e, 3); sub(eax, memd_a32[ss, ebp - 0x14]);     /* sub eax, [ebp-0x14] */
            ii(0x100f_3141, 1); cwde();                                 /* cwde */
            ii(0x100f_3142, 1); pushd(eax);                             /* push eax */
            ii(0x100f_3143, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_3146, 3); sub(eax, memd_a32[ss, ebp - 0x18]);     /* sub eax, [ebp-0x18] */
            ii(0x100f_3149, 1); cwde();                                 /* cwde */
            ii(0x100f_314a, 1); pushd(eax);                             /* push eax */
            ii(0x100f_314b, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_314f, 1); pushd(eax);                             /* push eax */
            ii(0x100f_3150, 4); movsx(ecx, memw_a32[ss, ebp - 0x18]);   /* movsx ecx, word [ebp-0x18] */
            ii(0x100f_3154, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x100f_3157, 4); movsx(edx, memw_a32[ss, ebp - 0x24]);   /* movsx edx, word [ebp-0x24] */
            ii(0x100f_315b, 3); mov(eax, memd_a32[ss, ebp - 0x1e]);     /* mov eax, [ebp-0x1e] */
            ii(0x100f_315e, 5); calld(0x100e_9ae5, -0x967e);            /* call 0x100e9ae5 */
            ii(0x100f_3163, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x100f_3166, 3); mov(eax, memd_a32[ss, ebp - 0x22]);     /* mov eax, [ebp-0x22] */
            ii(0x100f_3169, 5); calld(Definitions.sys_display_draw_1, 0x7_433a); /* call 0x101674a8 */
            ii(0x100f_316e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_3170, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_3171, 1); popd(edi);                              /* pop edi */
            ii(0x100f_3172, 1); popd(esi);                              /* pop esi */
            ii(0x100f_3173, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_3174, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_3175, 1); retd(); return;                         /* ret */
        }
    }
}
