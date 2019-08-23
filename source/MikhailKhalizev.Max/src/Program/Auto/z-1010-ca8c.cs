using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_ca8c-d4a561da")]
        public void Method_1010_ca8c()
        {
            ii(0x1010_ca8c, 5); push(0x64);                             /* push 0x64 */
            ii(0x1010_ca91, 5); call(Definitions.sys_check_available_stack_size, 0x5_92bc); /* call 0x10165d52 */
            ii(0x1010_ca96, 1); push(ebx);                              /* push ebx */
            ii(0x1010_ca97, 1); push(ecx);                              /* push ecx */
            ii(0x1010_ca98, 1); push(esi);                              /* push esi */
            ii(0x1010_ca99, 1); push(edi);                              /* push edi */
            ii(0x1010_ca9a, 1); push(ebp);                              /* push ebp */
            ii(0x1010_ca9b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_ca9d, 6); sub(esp, 0x40);                         /* sub esp, 0x40 */
            ii(0x1010_caa3, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_caa6, 3); mov(memb[ss, ebp - 0x4], dl);           /* mov [ebp-0x4], dl */
            ii(0x1010_caa9, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1010_caac, 3); mov(edx, memd[ds, edx + 0xa]);          /* mov edx, [edx+0xa] */
            ii(0x1010_caaf, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_cab2, 5); mov(ebx, 0x6);                          /* mov ebx, 0x6 */
            ii(0x1010_cab7, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1010_cab9, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1010_cabc, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1010_cabe, 3); imul(eax, eax, 0x6);                    /* imul eax, eax, 0x6 */
            ii(0x1010_cac1, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1010_cac4, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1010_cac7, 5); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1010_cacc, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1010_cacf, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_cad2, 6); mov(memw[ds, eax + 0xe], 0);            /* mov word [eax+0xe], 0x0 */
            ii(0x1010_cad8, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1010_cadb, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1010_cade, 2); jmp(0x1010_cae6, 0x6); goto l_0x1010_cae6; /* jmp 0x1010cae6 */
        l_0x1010_cae0:
            ii(0x1010_cae0, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1010_cae3, 3); inc(memd[ss, ebp - 0x14]);              /* inc dword [ebp-0x14] */
        l_0x1010_cae6:
            ii(0x1010_cae6, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1010_cae9, 4); cmp(ax, memw[ss, ebp - 0x10]);          /* cmp ax, [ebp-0x10] */
            ii(0x1010_caed, 6); if(jge(0x1010_cbca, 0xd7)) goto l_0x1010_cbca; /* jge 0x1010cbca */
            ii(0x1010_caf3, 5); call(/* sys */ 0x1016_b258, 0x5_e760);  /* call 0x1016b258 */
            ii(0x1010_caf8, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_cafb, 4); mov(ax, memw[ds, eax + 0xe]);           /* mov ax, [eax+0xe] */
            ii(0x1010_caff, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1010_cb02, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1010_cb06, 3); imul(eax, eax, 0x18);                   /* imul eax, eax, 0x18 */
            ii(0x1010_cb09, 6); mov(edx, memd[ds, eax + 0x101b_9830]);  /* mov edx, [eax+0x101b9830] */
            ii(0x1010_cb0f, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_cb12, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_cb15, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1010_cb17, 3); mov(eax, memd[ds, eax + 0xe]);          /* mov eax, [eax+0xe] */
            ii(0x1010_cb1a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_cb1d, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1010_cb20, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1010_cb22, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1010_cb26, 3); imul(eax, eax, 0x18);                   /* imul eax, eax, 0x18 */
            ii(0x1010_cb29, 6); mov(edx, memd[ds, eax + 0x101b_982e]);  /* mov edx, [eax+0x101b982e] */
            ii(0x1010_cb2f, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_cb32, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_cb35, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1010_cb37, 3); mov(eax, memd[ds, eax + 0x16]);         /* mov eax, [eax+0x16] */
            ii(0x1010_cb3a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_cb3c, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1010_cb3e, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1010_cb41, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_cb44, 2); mov(ebx, memd[ds, eax]);                /* mov ebx, [eax] */
            ii(0x1010_cb46, 3); mov(ebx, memd[ds, ebx + 0xe]);          /* mov ebx, [ebx+0xe] */
            ii(0x1010_cb49, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1010_cb4c, 3); mov(edx, memd[ss, ebp - 0x1c]);         /* mov edx, [ebp-0x1c] */
            ii(0x1010_cb4f, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1010_cb53, 5); call(0x1010_c7dd, -0x37b);              /* call 0x1010c7dd */
            ii(0x1010_cb58, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_cb5a, 2); if(jz(0x1010_cbc5, 0x69)) goto l_0x1010_cbc5; /* jz 0x1010cbc5 */
            ii(0x1010_cb5c, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_cb5f, 4); inc(memw[ds, eax + 0xe]);               /* inc word [eax+0xe] */
            ii(0x1010_cb63, 4); cmp(memb[ss, ebp - 0x4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1010_cb67, 2); if(jz(0x1010_cbc5, 0x5c)) goto l_0x1010_cbc5; /* jz 0x1010cbc5 */
            ii(0x1010_cb69, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1010_cb6d, 3); imul(eax, eax, 0x18);                   /* imul eax, eax, 0x18 */
            ii(0x1010_cb70, 6); mov(eax, memd[ds, eax + 0x101b_982e]);  /* mov eax, [eax+0x101b982e] */
            ii(0x1010_cb76, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_cb79, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1010_cb7c, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1010_cb80, 3); imul(eax, eax, 0x18);                   /* imul eax, eax, 0x18 */
            ii(0x1010_cb83, 6); mov(eax, memd[ds, eax + 0x101b_9830]);  /* mov eax, [eax+0x101b9830] */
            ii(0x1010_cb89, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_cb8c, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x1010_cb8f, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1010_cb93, 3); imul(eax, eax, 0x18);                   /* imul eax, eax, 0x18 */
            ii(0x1010_cb96, 6); mov(eax, memd[ds, eax + 0x101b_9832]);  /* mov eax, [eax+0x101b9832] */
            ii(0x1010_cb9c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_cb9f, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1010_cba2, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1010_cba6, 3); imul(eax, eax, 0x18);                   /* imul eax, eax, 0x18 */
            ii(0x1010_cba9, 6); mov(eax, memd[ds, eax + 0x101b_9834]);  /* mov eax, [eax+0x101b9834] */
            ii(0x1010_cbaf, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_cbb2, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1010_cbb5, 3); lea(edx, ebp - 0x2c);                   /* lea edx, [ebp-0x2c] */
            ii(0x1010_cbb8, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_cbbb, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1010_cbbd, 3); mov(eax, memd[ds, eax + 0x12]);         /* mov eax, [eax+0x12] */
            ii(0x1010_cbc0, 5); call(Definitions.sys_display_draw_1, 0x5_a8e3); /* call 0x101674a8 */
        l_0x1010_cbc5:
            ii(0x1010_cbc5, 5); jmp(0x1010_cae0, -0xea); goto l_0x1010_cae0; /* jmp 0x1010cae0 */
        l_0x1010_cbca:
            ii(0x1010_cbca, 5); call(0x100d_533c, -0x3_7893);           /* call 0x100d533c */
            ii(0x1010_cbcf, 1); cwde();                                 /* cwde */
            ii(0x1010_cbd0, 1); push(eax);                              /* push eax */
            ii(0x1010_cbd1, 5); call(0x100d_5360, -0x3_7876);           /* call 0x100d5360 */
            ii(0x1010_cbd6, 1); cwde();                                 /* cwde */
            ii(0x1010_cbd7, 1); push(eax);                              /* push eax */
            ii(0x1010_cbd8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_cbda, 1); push(eax);                              /* push eax */
            ii(0x1010_cbdb, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_cbdd, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1010_cbe0, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x1010_cbe2, 3); mov(ebx, memd[ds, edx + 0xe]);          /* mov ebx, [edx+0xe] */
            ii(0x1010_cbe5, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1010_cbe8, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1010_cbeb, 2); mov(esi, memd[ds, edx]);                /* mov esi, [edx] */
            ii(0x1010_cbed, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1010_cbf0, 3); mov(edx, memd[ds, edx + 0xa]);          /* mov edx, [edx+0xa] */
            ii(0x1010_cbf3, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_cbf6, 5); mov(edi, 0x6);                          /* mov edi, 0x6 */
            ii(0x1010_cbfb, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1010_cbfd, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1010_cc00, 2); idiv(edi);                              /* idiv edi */
            ii(0x1010_cc02, 5); add(eax, 0x768);                        /* add eax, 0x768 */
            ii(0x1010_cc07, 1); cwde();                                 /* cwde */
            ii(0x1010_cc08, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1010_cc0a, 5); call(0x100e_8c51, -0x2_3fbe);           /* call 0x100e8c51 */
            ii(0x1010_cc0f, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1010_cc12, 4); cmp(memd[ds, edx + 0x1c], 0);           /* cmp dword [edx+0x1c], 0x0 */
            ii(0x1010_cc16, 6); if(jnz(0x1010_cc9d, 0x81)) goto l_0x1010_cc9d; /* jnz 0x1010cc9d */
            ii(0x1010_cc1c, 7); mov(memd[ss, ebp - 0x30], 0x101b_981c); /* mov dword [ebp-0x30], 0x101b981c */
            ii(0x1010_cc23, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x1010_cc28, 5); call(Definitions.sys_new, 0x5_91d3);    /* call 0x10165e00 */
            ii(0x1010_cc2d, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x1010_cc30, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1010_cc33, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
            ii(0x1010_cc36, 4); cmp(memd[ss, ebp - 0x38], 0);           /* cmp dword [ebp-0x38], 0x0 */
            ii(0x1010_cc3a, 2); if(jz(0x1010_cc7e, 0x42)) goto l_0x1010_cc7e; /* jz 0x1010cc7e */
            ii(0x1010_cc3c, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1010_cc3f, 4); mov(ax, memw[ds, eax + 0xc]);           /* mov ax, [eax+0xc] */
            ii(0x1010_cc43, 3); mov(edx, memd[ss, ebp - 0x30]);         /* mov edx, [ebp-0x30] */
            ii(0x1010_cc46, 4); sub(ax, memw[ds, edx + 0x4]);           /* sub ax, [edx+0x4] */
            ii(0x1010_cc4a, 1); cwde();                                 /* cwde */
            ii(0x1010_cc4b, 1); push(eax);                              /* push eax */
            ii(0x1010_cc4c, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1010_cc4f, 4); mov(ax, memw[ds, eax + 0x8]);           /* mov ax, [eax+0x8] */
            ii(0x1010_cc53, 3); mov(edx, memd[ss, ebp - 0x30]);         /* mov edx, [ebp-0x30] */
            ii(0x1010_cc56, 3); sub(ax, memw[ds, edx]);                 /* sub ax, [edx] */
            ii(0x1010_cc59, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1010_cc5c, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1010_cc5f, 3); mov(ebx, memd[ds, eax + 0x2]);          /* mov ebx, [eax+0x2] */
            ii(0x1010_cc62, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1010_cc65, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1010_cc68, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x1010_cc6b, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1010_cc6e, 5); call(0x100d_7bdc, -0x3_5097);           /* call 0x100d7bdc */
            ii(0x1010_cc73, 3); mov(memd[ss, ebp - 0x3c], eax);         /* mov [ebp-0x3c], eax */
            ii(0x1010_cc76, 3); mov(eax, memd[ss, ebp - 0x3c]);         /* mov eax, [ebp-0x3c] */
            ii(0x1010_cc79, 3); mov(memd[ss, ebp - 0x40], eax);         /* mov [ebp-0x40], eax */
            ii(0x1010_cc7c, 2); jmp(0x1010_cc84, 0x6); goto l_0x1010_cc84; /* jmp 0x1010cc84 */
        l_0x1010_cc7e:
            ii(0x1010_cc7e, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x1010_cc81, 3); mov(memd[ss, ebp - 0x40], eax);         /* mov [ebp-0x40], eax */
        l_0x1010_cc84:
            ii(0x1010_cc84, 3); mov(eax, memd[ss, ebp - 0x40]);         /* mov eax, [ebp-0x40] */
            ii(0x1010_cc87, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1010_cc8a, 3); mov(memd[ds, edx + 0x1c], eax);         /* mov [edx+0x1c], eax */
            ii(0x1010_cc8d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_cc90, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1010_cc92, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_cc95, 3); mov(eax, memd[ds, eax + 0x1c]);         /* mov eax, [eax+0x1c] */
            ii(0x1010_cc98, 5); call(0x100d_7d74, -0x3_4f29);           /* call 0x100d7d74 */
        l_0x1010_cc9d:
            ii(0x1010_cc9d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_cc9f, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_cca0, 1); pop(edi);                               /* pop edi */
            ii(0x1010_cca1, 1); pop(esi);                               /* pop esi */
            ii(0x1010_cca2, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_cca3, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_cca4, 1); ret();                                  /* ret */
        }
    }
}
