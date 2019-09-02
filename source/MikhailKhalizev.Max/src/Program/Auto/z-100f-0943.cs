using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_0943-566add8e")]
        public void Method_100f_0943()
        {
            ii(0x100f_0943, 5); push(0x84);                             /* push 0x84 */
            ii(0x100f_0948, 5); call(Definitions.sys_check_available_stack_size, 0x7_5405); /* call 0x10165d52 */
            ii(0x100f_094d, 1); push(ebx);                              /* push ebx */
            ii(0x100f_094e, 1); push(ecx);                              /* push ecx */
            ii(0x100f_094f, 1); push(esi);                              /* push esi */
            ii(0x100f_0950, 1); push(edi);                              /* push edi */
            ii(0x100f_0951, 1); push(ebp);                              /* push ebp */
            ii(0x100f_0952, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_0954, 6); sub(esp, 0x54);                         /* sub esp, 0x54 */
            ii(0x100f_095a, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100f_095d, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100f_0960, 7); cmp(memd[ds, 0x101c_3940], 0);          /* cmp dword [0x101c3940], 0x0 */
            ii(0x100f_0967, 2); if(jnz(0x100f_0979, 0x10)) goto l_0x100f_0979; /* jnz 0x100f0979 */
            ii(0x100f_0969, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_096b, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_0970, 5); call(0x1013_ad71, 0x4_a3fc);            /* call 0x1013ad71 */
            ii(0x100f_0975, 2); test(al, al);                           /* test al, al */
            ii(0x100f_0977, 2); if(jnz(0x100f_097b, 2)) goto l_0x100f_097b; /* jnz 0x100f097b */
        l_0x100f_0979:
            ii(0x100f_0979, 2); jmp(0x100f_0995, 0x1a); goto l_0x100f_0995; /* jmp 0x100f0995 */
        l_0x100f_097b:
            ii(0x100f_097b, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_0980, 5); call(0x1007_6574, -0x7_a411);           /* call 0x10076574 */
            ii(0x100f_0985, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_0987, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x100f_098a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_098c, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x100f_0991, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_0993, 2); if(jz(0x100f_0997, 2)) goto l_0x100f_0997; /* jz 0x100f0997 */
        l_0x100f_0995:
            ii(0x100f_0995, 2); jmp(0x100f_09b4, 0x1d); goto l_0x100f_09b4; /* jmp 0x100f09b4 */
        l_0x100f_0997:
            ii(0x100f_0997, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_0999, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x100f_099e, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_09a4, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x100f_09aa, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_09af, 3); cmp(eax, 1);                            /* cmp eax, 0x1 */
            ii(0x100f_09b2, 2); if(jz(0x100f_09b9, 5)) goto l_0x100f_09b9; /* jz 0x100f09b9 */
        l_0x100f_09b4:
            ii(0x100f_09b4, 5); jmp(0x100f_0b13, 0x15a); goto l_0x100f_0b13; /* jmp 0x100f0b13 */
        l_0x100f_09b9:
            ii(0x100f_09b9, 5); mov(eax, 6);                            /* mov eax, 0x6 */
            ii(0x100f_09be, 5); call(0x100e_883d, -0x8186);             /* call 0x100e883d */
            ii(0x100f_09c3, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100f_09c6, 5); mov(edx, 0x101c_3944);                  /* mov edx, 0x101c3944 */
            ii(0x100f_09cb, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_09d0, 5); call(0x1007_6574, -0x7_a461);           /* call 0x10076574 */
            ii(0x100f_09d5, 5); call(0x1014_f9cf, 0x5_eff5);            /* call 0x1014f9cf */
            ii(0x100f_09da, 3); lea(edx, memd[ss, ebp - 0x34]);         /* lea edx, [ebp-0x34] */
            ii(0x100f_09dd, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_09e2, 5); call(0x1007_6574, -0x7_a473);           /* call 0x10076574 */
            ii(0x100f_09e7, 5); call(0x1014_fa43, 0x5_f057);            /* call 0x1014fa43 */
            ii(0x100f_09ec, 5); mov(eax, 2);                            /* mov eax, 0x2 */
            ii(0x100f_09f1, 5); call(/* sys */ 0x1016_a24c, 0x7_9856);  /* call 0x1016a24c */
            ii(0x100f_09f6, 3); lea(eax, memd[ss, ebp - 0x34]);         /* lea eax, [ebp-0x34] */
            ii(0x100f_09f9, 6); call_abs(memd[ds, 0x101b_ddf4]);        /* call dword [0x101bddf4] */
            ii(0x100f_09ff, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_0a01, 5); mov(eax, 0x101c_3944);                  /* mov eax, 0x101c3944 */
            ii(0x100f_0a06, 6); call_abs(memd[ds, 0x101b_ddf4]);        /* call dword [0x101bddf4] */
            ii(0x100f_0a0c, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100f_0a0e, 3); mov(memd[ss, ebp - 0x44], edx);         /* mov [ebp-0x44], edx */
            ii(0x100f_0a11, 7); mov(memd[ss, ebp - 0x40], 0);           /* mov dword [ebp-0x40], 0x0 */
            ii(0x100f_0a18, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100f_0a1b, 3); mov(eax, memd[ds, eax + 8]);            /* mov eax, [eax+0x8] */
            ii(0x100f_0a1e, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100f_0a21, 2); sub(eax, memd[ds, edx]);                /* sub eax, [edx] */
            ii(0x100f_0a23, 3); mov(memd[ss, ebp - 0x3c], eax);         /* mov [ebp-0x3c], eax */
            ii(0x100f_0a26, 6); call_abs(memd[ds, 0x101b_ddf0]);        /* call dword [0x101bddf0] */
            ii(0x100f_0a2c, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
            ii(0x100f_0a2f, 3); lea(ebx, memd[ss, ebp - 0x44]);         /* lea ebx, [ebp-0x44] */
            ii(0x100f_0a32, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100f_0a35, 5); mov(eax, memd[ds, 0x101b_8962]);        /* mov eax, [0x101b8962] */
            ii(0x100f_0a3a, 5); call(0x100d_7ff1, -0x1_8a4e);           /* call 0x100d7ff1 */
            ii(0x100f_0a3f, 5); mov(eax, 0x3a);                         /* mov eax, 0x3a */
            ii(0x100f_0a44, 5); call(Definitions.sys_new, 0x7_53b7);    /* call 0x10165e00 */
            ii(0x100f_0a49, 3); mov(memd[ss, ebp - 0x48], eax);         /* mov [ebp-0x48], eax */
            ii(0x100f_0a4c, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x100f_0a4f, 3); mov(memd[ss, ebp - 0x4c], eax);         /* mov [ebp-0x4c], eax */
            ii(0x100f_0a52, 4); cmp(memd[ss, ebp - 0x4c], 0);           /* cmp dword [ebp-0x4c], 0x0 */
            ii(0x100f_0a56, 2); if(jz(0x100f_0a9c, 0x44)) goto l_0x100f_0a9c; /* jz 0x100f0a9c */
            ii(0x100f_0a58, 5); mov(eax, 2);                            /* mov eax, 0x2 */
            ii(0x100f_0a5d, 1); push(eax);                              /* push eax */
            ii(0x100f_0a5e, 5); mov(eax, 2);                            /* mov eax, 0x2 */
            ii(0x100f_0a63, 1); push(eax);                              /* push eax */
            ii(0x100f_0a64, 6); call_abs(memd[ds, 0x101b_ddf0]);        /* call dword [0x101bddf0] */
            ii(0x100f_0a6a, 1); cwde();                                 /* cwde */
            ii(0x100f_0a6b, 1); push(eax);                              /* push eax */
            ii(0x100f_0a6c, 3); mov(eax, memd[ss, ebp - 0x3c]);         /* mov eax, [ebp-0x3c] */
            ii(0x100f_0a6f, 3); sub(eax, memd[ss, ebp - 0x44]);         /* sub eax, [ebp-0x44] */
            ii(0x100f_0a72, 1); cwde();                                 /* cwde */
            ii(0x100f_0a73, 1); push(eax);                              /* push eax */
            ii(0x100f_0a74, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_0a76, 1); push(eax);                              /* push eax */
            ii(0x100f_0a77, 4); movsx(eax, memw[ss, ebp - 0x44]);       /* movsx eax, word [ebp-0x44] */
            ii(0x100f_0a7b, 1); push(eax);                              /* push eax */
            ii(0x100f_0a7c, 5); mov(ecx, 0x1e);                         /* mov ecx, 0x1e */
            ii(0x100f_0a81, 5); mov(ebx, 0x101c_3944);                  /* mov ebx, 0x101c3944 */
            ii(0x100f_0a86, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100f_0a89, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x100f_0a8c, 5); call(0x100e_af58, -0x5b39);             /* call 0x100eaf58 */
            ii(0x100f_0a91, 3); mov(memd[ss, ebp - 0x50], eax);         /* mov [ebp-0x50], eax */
            ii(0x100f_0a94, 3); mov(eax, memd[ss, ebp - 0x50]);         /* mov eax, [ebp-0x50] */
            ii(0x100f_0a97, 3); mov(memd[ss, ebp - 0x54], eax);         /* mov [ebp-0x54], eax */
            ii(0x100f_0a9a, 2); jmp(0x100f_0aa2, 6); goto l_0x100f_0aa2; /* jmp 0x100f0aa2 */
        l_0x100f_0a9c:
            ii(0x100f_0a9c, 3); mov(eax, memd[ss, ebp - 0x4c]);         /* mov eax, [ebp-0x4c] */
            ii(0x100f_0a9f, 3); mov(memd[ss, ebp - 0x54], eax);         /* mov [ebp-0x54], eax */
        l_0x100f_0aa2:
            ii(0x100f_0aa2, 3); mov(eax, memd[ss, ebp - 0x54]);         /* mov eax, [ebp-0x54] */
            ii(0x100f_0aa5, 5); mov(memd[ds, 0x101c_3940], eax);        /* mov [0x101c3940], eax */
            ii(0x100f_0aaa, 5); mov(eax, memd[ds, 0x101c_3940]);        /* mov eax, [0x101c3940] */
            ii(0x100f_0aaf, 5); call(0x100e_b180, -0x5934);             /* call 0x100eb180 */
            ii(0x100f_0ab4, 2); push(2);                                /* push 0x2 */
            ii(0x100f_0ab6, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100f_0ab9, 3); mov(ecx, memd[ds, eax + 0xe]);          /* mov ecx, [eax+0xe] */
            ii(0x100f_0abc, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100f_0abf, 3); mov(ebx, memd[ss, ebp - 0x3c]);         /* mov ebx, [ebp-0x3c] */
            ii(0x100f_0ac2, 3); sub(ebx, memd[ss, ebp - 0x44]);         /* sub ebx, [ebp-0x44] */
            ii(0x100f_0ac5, 5); mov(edx, 0x101c_3944);                  /* mov edx, 0x101c3944 */
            ii(0x100f_0aca, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100f_0acd, 3); mov(eax, memd[ds, eax + 0x16]);         /* mov eax, [eax+0x16] */
            ii(0x100f_0ad0, 3); add(eax, memd[ss, ebp - 0x44]);         /* add eax, [ebp-0x44] */
            ii(0x100f_0ad3, 6); call_abs(memd[ds, 0x101b_ddec]);        /* call dword [0x101bddec] */
            ii(0x100f_0ad9, 5); mov(eax, memd[ds, 0x101c_3940]);        /* mov eax, [0x101c3940] */
            ii(0x100f_0ade, 5); call(0x100e_b1b2, -0x5931);             /* call 0x100eb1b2 */
            ii(0x100f_0ae3, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100f_0ae6, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100f_0ae8, 3); add(memd[ss, ebp - 0x44], eax);         /* add [ebp-0x44], eax */
            ii(0x100f_0aeb, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100f_0aee, 3); mov(eax, memd[ds, eax + 4]);            /* mov eax, [eax+0x4] */
            ii(0x100f_0af1, 3); add(memd[ss, ebp - 0x40], eax);         /* add [ebp-0x40], eax */
            ii(0x100f_0af4, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100f_0af7, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100f_0af9, 3); add(memd[ss, ebp - 0x3c], eax);         /* add [ebp-0x3c], eax */
            ii(0x100f_0afc, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100f_0aff, 3); mov(eax, memd[ds, eax + 4]);            /* mov eax, [eax+0x4] */
            ii(0x100f_0b02, 3); add(memd[ss, ebp - 0x38], eax);         /* add [ebp-0x38], eax */
            ii(0x100f_0b05, 3); lea(edx, memd[ss, ebp - 0x44]);         /* lea edx, [ebp-0x44] */
            ii(0x100f_0b08, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100f_0b0b, 3); mov(eax, memd[ds, eax + 0x12]);         /* mov eax, [eax+0x12] */
            ii(0x100f_0b0e, 5); call(Definitions.sys_display_draw_1, 0x7_6995); /* call 0x101674a8 */
        l_0x100f_0b13:
            ii(0x100f_0b13, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_0b15, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_0b16, 1); pop(edi);                               /* pop edi */
            ii(0x100f_0b17, 1); pop(esi);                               /* pop esi */
            ii(0x100f_0b18, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_0b19, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_0b1a, 1); ret();                                  /* ret */
        }
    }
}
