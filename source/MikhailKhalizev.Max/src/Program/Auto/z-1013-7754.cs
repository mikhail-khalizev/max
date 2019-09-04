using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_7754-8fbf733e")]
        public void Method_1013_7754()
        {
            ii(0x1013_7754, 5); push(0x40);                             /* push 0x40 */
            ii(0x1013_7759, 5); call(Definitions.sys_check_available_stack_size, 0x2_e5f4); /* call 0x10165d52 */
            ii(0x1013_775e, 1); push(esi);                              /* push esi */
            ii(0x1013_775f, 1); push(edi);                              /* push edi */
            ii(0x1013_7760, 1); push(ebp);                              /* push ebp */
            ii(0x1013_7761, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_7763, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1013_7769, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1013_776c, 3); mov(memd[ss, ebp - 12], edx);           /* mov [ebp-0xc], edx */
            ii(0x1013_776f, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x1013_7772, 3); mov(memd[ss, ebp - 8], ecx);            /* mov [ebp-0x8], ecx */
            ii(0x1013_7775, 3); mov(eax, memd[ss, ebp + 16]);           /* mov eax, [ebp+0x10] */
            ii(0x1013_7778, 5); call(/* sys */ 0x1016_a24c, 0x3_2acf);  /* call 0x1016a24c */
            ii(0x1013_777d, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1013_7781, 5); call(Definitions.my_get_res_data_by_id_malloc, -0x359b); /* call 0x101341eb */
            ii(0x1013_7786, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1013_7789, 3); mov(edx, memd[ss, ebp - 20]);           /* mov edx, [ebp-0x14] */
            ii(0x1013_778c, 3); mov(eax, memd[ds, edx + 4]);            /* mov eax, [edx+0x4] */
            ii(0x1013_778f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_7792, 3); mov(ebx, memd[ss, ebp - 12]);           /* mov ebx, [ebp-0xc] */
            ii(0x1013_7795, 3); imul(ebx, eax);                         /* imul ebx, eax */
            ii(0x1013_7798, 3); mov(edx, memd[ss, ebp - 20]);           /* mov edx, [ebp-0x14] */
            ii(0x1013_779b, 3); mov(eax, memd[ds, edx + 2]);            /* mov eax, [edx+0x2] */
            ii(0x1013_779e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_77a1, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1013_77a3, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1013_77a6, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1013_77a9, 1); push(eax);                              /* push eax */
            ii(0x1013_77aa, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1013_77ad, 3); add(eax, memd[ss, ebp - 24]);           /* add eax, [ebp-0x18] */
            ii(0x1013_77b0, 1); push(eax);                              /* push eax */
            ii(0x1013_77b1, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1013_77b4, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1013_77b7, 1); push(eax);                              /* push eax */
            ii(0x1013_77b8, 3); mov(edx, memd[ss, ebp - 20]);           /* mov edx, [ebp-0x14] */
            ii(0x1013_77bb, 2); mov(eax, memd[ds, edx]);                /* mov eax, [edx] */
            ii(0x1013_77bd, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_77c0, 1); push(eax);                              /* push eax */
            ii(0x1013_77c1, 3); mov(edx, memd[ss, ebp - 20]);           /* mov edx, [ebp-0x14] */
            ii(0x1013_77c4, 3); movsx(eax, memw[ds, edx]);              /* movsx eax, word [edx] */
            ii(0x1013_77c7, 1); push(eax);                              /* push eax */
            ii(0x1013_77c8, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1013_77cb, 3); add(eax, 8);                            /* add eax, 0x8 */
            ii(0x1013_77ce, 1); push(eax);                              /* push eax */
            ii(0x1013_77cf, 5); call(/* sys */ 0x1016_abbc, 0x3_33e8);  /* call 0x1016abbc */
            ii(0x1013_77d4, 3); add(esp, 0x18);                         /* add esp, 0x18 */
            ii(0x1013_77d7, 3); mov(edx, memd[ss, ebp - 20]);           /* mov edx, [ebp-0x14] */
            ii(0x1013_77da, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x1013_77dc, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_77df, 6); call_abs(memd[ds, 0x101b_ddf0]);        /* call dword [0x101bddf0] */
            ii(0x1013_77e5, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1013_77e7, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_77e9, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_77ec, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1013_77ee, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x1013_77f0, 4); imul(eax, memd[ss, ebp - 12]);          /* imul eax, [ebp-0xc] */
            ii(0x1013_77f4, 3); add(memd[ss, ebp - 24], eax);           /* add [ebp-0x18], eax */
            ii(0x1013_77f7, 4); cmp(memd[ss, ebp + 16], 2);             /* cmp dword [ebp+0x10], 0x2 */
            ii(0x1013_77fb, 2); if(jnz(0x1013_781c, 0x1f)) goto l_0x1013_781c; /* jnz 0x1013781c */
            ii(0x1013_77fd, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_7800, 6); call_abs(memd[ds, 0x101b_ddf4]);        /* call dword [0x101bddf4] */
            ii(0x1013_7806, 3); mov(edx, memd[ss, ebp - 20]);           /* mov edx, [ebp-0x14] */
            ii(0x1013_7809, 3); movsx(edx, memw[ds, edx]);              /* movsx edx, word [edx] */
            ii(0x1013_780c, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1013_780e, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_7810, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_7813, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1013_7815, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x1013_7817, 3); add(memd[ss, ebp - 24], eax);           /* add [ebp-0x18], eax */
            ii(0x1013_781a, 2); jmp(0x1013_7820, 4); goto l_0x1013_7820; /* jmp 0x10137820 */
        l_0x1013_781c:
            ii(0x1013_781c, 4); add(memd[ss, ebp - 24], 5);             /* add dword [ebp-0x18], 0x5 */
        l_0x1013_7820:
            ii(0x1013_7820, 2); push(2);                                /* push 0x2 */
            ii(0x1013_7822, 3); mov(ecx, memd[ss, ebp - 12]);           /* mov ecx, [ebp-0xc] */
            ii(0x1013_7825, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1013_7828, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1013_782b, 3); lea(ebx, memd[ds, eax - 10]);           /* lea ebx, [eax-0xa] */
            ii(0x1013_782e, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1013_7831, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1013_7834, 3); add(eax, memd[ss, ebp - 24]);           /* add eax, [ebp-0x18] */
            ii(0x1013_7837, 6); call_abs(memd[ds, 0x101b_ddec]);        /* call dword [0x101bddec] */
            ii(0x1013_783d, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1013_7840, 5); call(Definitions.sys_delete, 0x2_e71f); /* call 0x10165f64 */
            ii(0x1013_7845, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_7847, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_7848, 1); pop(edi);                               /* pop edi */
            ii(0x1013_7849, 1); pop(esi);                               /* pop esi */
            ii(0x1013_784a, 3); ret(4);                                 /* ret 0x4 */
        }
    }
}
