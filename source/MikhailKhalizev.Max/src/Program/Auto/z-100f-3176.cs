using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_3176-406fad3d")]
        public void Method_100f_3176()
        {
            ii(0x100f_3176, 5); push(0x40);                             /* push 0x40 */
            ii(0x100f_317b, 5); call(Definitions.sys_check_available_stack_size, 0x7_2bd2); /* call 0x10165d52 */
            ii(0x100f_3180, 1); push(esi);                              /* push esi */
            ii(0x100f_3181, 1); push(edi);                              /* push edi */
            ii(0x100f_3182, 1); push(ebp);                              /* push ebp */
            ii(0x100f_3183, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_3185, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100f_318b, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100f_318e, 3); mov(memd[ss, ebp - 12], edx);           /* mov [ebp-0xc], edx */
            ii(0x100f_3191, 3); mov(memd[ss, ebp - 16], ebx);           /* mov [ebp-0x10], ebx */
            ii(0x100f_3194, 3); mov(memd[ss, ebp - 8], ecx);            /* mov [ebp-0x8], ecx */
            ii(0x100f_3197, 7); cmp(memb[ds, 0x101c_3919], 0);          /* cmp byte [0x101c3919], 0x0 */
            ii(0x100f_319e, 6); if(jz(0x100f_329c, 0xf8)) goto l_0x100f_329c; /* jz 0x100f329c */
            ii(0x100f_31a4, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100f_31a8, 3); imul(eax, eax, 0x12);                   /* imul eax, eax, 0x12 */
            ii(0x100f_31ab, 6); mov(eax, memd[ds, eax + 0x101b_890b]);  /* mov eax, [eax+0x101b890b] */
            ii(0x100f_31b1, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_31b4, 5); call(Definitions.my_get_res_data_by_id, 0x4_0e1f); /* call 0x10133fd8 */
            ii(0x100f_31b9, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x100f_31bc, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100f_31c0, 3); imul(eax, eax, 0x12);                   /* imul eax, eax, 0x12 */
            ii(0x100f_31c3, 6); mov(eax, memd[ds, eax + 0x101b_891a]);  /* mov eax, [eax+0x101b891a] */
            ii(0x100f_31c9, 5); call(0x100d_4e8c, -0x1_e342);           /* call 0x100d4e8c */
            ii(0x100f_31ce, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x100f_31d1, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100f_31d4, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100f_31d7, 1); push(eax);                              /* push eax */
            ii(0x100f_31d8, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x100f_31db, 1); push(eax);                              /* push eax */
            ii(0x100f_31dc, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100f_31df, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100f_31e2, 1); push(eax);                              /* push eax */
            ii(0x100f_31e3, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100f_31e6, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100f_31e8, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_31eb, 1); push(eax);                              /* push eax */
            ii(0x100f_31ec, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100f_31ef, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100f_31f2, 1); push(eax);                              /* push eax */
            ii(0x100f_31f3, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100f_31f6, 3); add(eax, 8);                            /* add eax, 0x8 */
            ii(0x100f_31f9, 1); push(eax);                              /* push eax */
            ii(0x100f_31fa, 5); call(/* sys */ 0x1016_abbc, 0x7_79bd);  /* call 0x1016abbc */
            ii(0x100f_31ff, 3); add(esp, 0x18);                         /* add esp, 0x18 */
            ii(0x100f_3202, 5); mov(eax, 5);                            /* mov eax, 0x5 */
            ii(0x100f_3207, 5); call(/* sys */ 0x1016_a24c, 0x7_7040);  /* call 0x1016a24c */
            ii(0x100f_320c, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x100f_3211, 1); push(eax);                              /* push eax */
            ii(0x100f_3212, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x100f_3217, 1); push(eax);                              /* push eax */
            ii(0x100f_3218, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100f_321b, 1); push(eax);                              /* push eax */
            ii(0x100f_321c, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100f_321f, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100f_3221, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_3224, 1); push(eax);                              /* push eax */
            ii(0x100f_3225, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100f_3228, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x100f_322b, 3); sub(eax, memd[ss, ebp - 8]);            /* sub eax, [ebp-0x8] */
            ii(0x100f_322e, 1); cwde();                                 /* cwde */
            ii(0x100f_322f, 1); push(eax);                              /* push eax */
            ii(0x100f_3230, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_3232, 1); push(eax);                              /* push eax */
            ii(0x100f_3233, 4); movsx(ecx, memw[ss, ebp - 8]);          /* movsx ecx, word [ebp-0x8] */
            ii(0x100f_3237, 3); mov(ebx, memd[ss, ebp - 12]);           /* mov ebx, [ebp-0xc] */
            ii(0x100f_323a, 3); mov(edx, memd[ss, ebp - 20]);           /* mov edx, [ebp-0x14] */
            ii(0x100f_323d, 3); movsx(edx, memw[ds, edx]);              /* movsx edx, word [edx] */
            ii(0x100f_3240, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x100f_3243, 5); call(0x100e_9ae5, -0x9763);             /* call 0x100e9ae5 */
            ii(0x100f_3248, 3); mov(edx, memd[ss, ebp - 24]);           /* mov edx, [ebp-0x18] */
            ii(0x100f_324b, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100f_324f, 3); imul(eax, eax, 0x12);                   /* imul eax, eax, 0x12 */
            ii(0x100f_3252, 6); mov(eax, memd[ds, eax + 0x101b_8913]);  /* mov eax, [eax+0x101b8913] */
            ii(0x100f_3258, 5); call(0x100c_f40c, -0x2_3e51);           /* call 0x100cf40c */
            ii(0x100f_325d, 5); call(0x100d_51c4, -0x1_e09e);           /* call 0x100d51c4 */
            ii(0x100f_3262, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_3264, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100f_3266, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100f_326a, 3); imul(eax, eax, 0x12);                   /* imul eax, eax, 0x12 */
            ii(0x100f_326d, 6); mov(eax, memd[ds, eax + 0x101b_8913]);  /* mov eax, [eax+0x101b8913] */
            ii(0x100f_3273, 5); call(0x100c_fb06, -0x2_3772);           /* call 0x100cfb06 */
            ii(0x100f_3278, 5); call(0x100d_51e4, -0x1_e099);           /* call 0x100d51e4 */
            ii(0x100f_327d, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_327f, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100f_3281, 5); call(0x100d_5204, -0x1_e082);           /* call 0x100d5204 */
            ii(0x100f_3286, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_3288, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100f_328a, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100f_328e, 3); imul(eax, eax, 0x12);                   /* imul eax, eax, 0x12 */
            ii(0x100f_3291, 6); mov(eax, memd[ds, eax + 0x101b_8913]);  /* mov eax, [eax+0x101b8913] */
            ii(0x100f_3297, 5); call(0x100c_fa7c, -0x2_3820);           /* call 0x100cfa7c */
        l_0x100f_329c:
            ii(0x100f_329c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_329e, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_329f, 1); pop(edi);                               /* pop edi */
            ii(0x100f_32a0, 1); pop(esi);                               /* pop esi */
            ii(0x100f_32a1, 1); ret();                                  /* ret */
        }
    }
}
