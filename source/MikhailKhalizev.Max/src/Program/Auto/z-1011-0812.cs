using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_0812-6f633371")]
        public void Method_1011_0812()
        {
            ii(0x1011_0812, 5); push(0xe4);                             /* push 0xe4 */
            ii(0x1011_0817, 5); call(Definitions.sys_check_available_stack_size, 0x5_5536); /* call 0x10165d52 */
            ii(0x1011_081c, 1); push(ebx);                              /* push ebx */
            ii(0x1011_081d, 1); push(ecx);                              /* push ecx */
            ii(0x1011_081e, 1); push(edx);                              /* push edx */
            ii(0x1011_081f, 1); push(esi);                              /* push esi */
            ii(0x1011_0820, 1); push(edi);                              /* push edi */
            ii(0x1011_0821, 1); push(ebp);                              /* push ebp */
            ii(0x1011_0822, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_0824, 6); sub(esp, 0xbc);                         /* sub esp, 0xbc */
            ii(0x1011_082a, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1011_082d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_0830, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1011_0832, 5); call(0x1010_9688, -0x71af);             /* call 0x10109688 */
            ii(0x1011_0837, 7); mov(memd[ss, ebp - 0x8], 0xc);          /* mov dword [ebp-0x8], 0xc */
            ii(0x1011_083e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_0841, 7); mov(memb[ds, eax + 0x141], 0);          /* mov byte [eax+0x141], 0x0 */
        l_0x1011_0848:
            ii(0x1011_0848, 3); dec(memd[ss, ebp - 0x8]);               /* dec dword [ebp-0x8] */
            ii(0x1011_084b, 5); cmp(memw[ss, ebp - 0x8], -0x1 /* 0xff */); /* cmp word [ebp-0x8], 0xffff */
            ii(0x1011_0850, 6); if(jz(0x1011_09e7, 0x191)) goto l_0x1011_09e7; /* jz 0x101109e7 */
            ii(0x1011_0856, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1011_085a, 3); imul(eax, eax, 0x18);                   /* imul eax, eax, 0x18 */
            ii(0x1011_085d, 5); mov(edx, 0x101b_ad94);                  /* mov edx, 0x101bad94 */
            ii(0x1011_0862, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_0864, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x1011_0867, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1011_086b, 3); cmp(eax, 0xb);                          /* cmp eax, 0xb */
            ii(0x1011_086e, 2); if(jge(0x1011_08a7, 0x37)) goto l_0x1011_08a7; /* jge 0x101108a7 */
            ii(0x1011_0870, 2); push(0x2);                              /* push 0x2 */
            ii(0x1011_0872, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_0875, 3); mov(eax, memd[ds, eax + 0x4]);          /* mov eax, [eax+0x4] */
            ii(0x1011_0878, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_087b, 1); push(eax);                              /* push eax */
            ii(0x1011_087c, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_087f, 3); mov(eax, memd[ds, eax + 0x2]);          /* mov eax, [eax+0x2] */
            ii(0x1011_0882, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_0885, 1); push(eax);                              /* push eax */
            ii(0x1011_0886, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_0889, 3); mov(ecx, memd[ds, eax + 0x4]);          /* mov ecx, [eax+0x4] */
            ii(0x1011_088c, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1011_088f, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_0892, 3); movsx(ebx, memw[ds, eax]);              /* movsx ebx, word [eax] */
            ii(0x1011_0895, 5); mov(edx, 0x280);                        /* mov edx, 0x280 */
            ii(0x1011_089a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_089d, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1011_089f, 3); mov(eax, memd[ds, eax + 0x16]);         /* mov eax, [eax+0x16] */
            ii(0x1011_08a2, 5); call(/* sys */ 0x1016_a5a0, 0x5_9cf9);  /* call 0x1016a5a0 */
        l_0x1011_08a7:
            ii(0x1011_08a7, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1011_08ab, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_08ae, 7); cmp(memd[ds, eax + 0x101c_4df4], 0);    /* cmp dword [eax+0x101c4df4], 0x0 */
            ii(0x1011_08b5, 2); if(jz(0x1011_08c9, 0x12)) goto l_0x1011_08c9; /* jz 0x101108c9 */
            ii(0x1011_08b7, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1011_08bb, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_08be, 6); mov(eax, memd[ds, eax + 0x101c_4df4]);  /* mov eax, [eax+0x101c4df4] */
            ii(0x1011_08c4, 5); call(Definitions.sys_delete, 0x5_569b); /* call 0x10165f64 */
        l_0x1011_08c9:
            ii(0x1011_08c9, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1011_08cd, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_08d0, 10); mov(memd[ds, eax + 0x101c_4df4], 0);   /* mov dword [eax+0x101c4df4], 0x0 */
            ii(0x1011_08da, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_08dd, 7); cmp(memb[ds, eax + 0x143], 0x2);        /* cmp byte [eax+0x143], 0x2 */
            ii(0x1011_08e4, 2); if(jnz(0x1011_0925, 0x3f)) goto l_0x1011_0925; /* jnz 0x10110925 */
            ii(0x1011_08e6, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_08e9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_08eb, 6); mov(dl, memb[ds, eax + 0x140]);         /* mov dl, [eax+0x140] */
            ii(0x1011_08f1, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1011_08f5, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_08f7, 5); mov(eax, 0x41);                         /* mov eax, 0x41 */
            ii(0x1011_08fc, 5); call(0x1007_5fdc, -0x9_a925);           /* call 0x10075fdc */
            ii(0x1011_0901, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1011_0903, 2); if(jle(0x1011_0925, 0x20)) goto l_0x1011_0925; /* jle 0x10110925 */
            ii(0x1011_0905, 5); call(0x100d_51c4, -0x3_b746);           /* call 0x100d51c4 */
            ii(0x1011_090a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_090c, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1011_090e, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1011_0912, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_0915, 3); add(eax, memd[ss, ebp - 0x4]);          /* add eax, [ebp-0x4] */
            ii(0x1011_0918, 3); mov(eax, memd[ds, eax + 0x10]);         /* mov eax, [eax+0x10] */
            ii(0x1011_091b, 5); call(0x100c_fb06, -0x4_0e1a);           /* call 0x100cfb06 */
            ii(0x1011_0920, 5); jmp(0x1011_09e2, 0xbd); goto l_0x1011_09e2; /* jmp 0x101109e2 */
        l_0x1011_0925:
            ii(0x1011_0925, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1011_0927, 6); lea(ebx, ebp - 0xbc);                   /* lea ebx, [ebp-0xbc] */
            ii(0x1011_092d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_0930, 8); movsx(ax, memb[ds, eax + 0x143]);       /* movsx ax, byte [eax+0x143] */
            ii(0x1011_0938, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_093b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_093e, 6); mov(al, memb[ds, eax + 0x140]);         /* mov al, [eax+0x140] */
            ii(0x1011_0944, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1011_0946, 3); add(eax, memd[ss, ebp - 0x8]);          /* add eax, [ebp-0x8] */
            ii(0x1011_0949, 1); cwde();                                 /* cwde */
            ii(0x1011_094a, 5); call(0x1013_9ade, 0x2_918f);            /* call 0x10139ade */
            ii(0x1011_094f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_0951, 2); if(jnz(0x1011_0970, 0x1d)) goto l_0x1011_0970; /* jnz 0x10110970 */
            ii(0x1011_0953, 5); call(0x100d_51c4, -0x3_b794);           /* call 0x100d51c4 */
            ii(0x1011_0958, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_095a, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1011_095c, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1011_0960, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_0963, 3); add(eax, memd[ss, ebp - 0x4]);          /* add eax, [ebp-0x4] */
            ii(0x1011_0966, 3); mov(eax, memd[ds, eax + 0x10]);         /* mov eax, [eax+0x10] */
            ii(0x1011_0969, 5); call(0x100c_fb06, -0x4_0e68);           /* call 0x100cfb06 */
            ii(0x1011_096e, 2); jmp(0x1011_09e2, 0x72); goto l_0x1011_09e2; /* jmp 0x101109e2 */
        l_0x1011_0970:
            ii(0x1011_0970, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_0973, 6); inc(memb[ds, eax + 0x141]);             /* inc byte [eax+0x141] */
            ii(0x1011_0979, 5); mov(eax, 0x1e);                         /* mov eax, 0x1e */
            ii(0x1011_097e, 5); call(Definitions.sys_new_arr, 0x5_568d); /* call 0x10166010 */
            ii(0x1011_0983, 4); movsx(edx, memw[ss, ebp - 0x8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1011_0987, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1011_098a, 6); mov(memd[ds, edx + 0x101c_4df4], eax);  /* mov [edx+0x101c4df4], eax */
            ii(0x1011_0990, 6); lea(edx, ebp - 0xb9);                   /* lea edx, [ebp-0xb9] */
            ii(0x1011_0996, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1011_099a, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_099d, 6); mov(eax, memd[ds, eax + 0x101c_4df4]);  /* mov eax, [eax+0x101c4df4] */
            ii(0x1011_09a3, 5); call(Definitions.sys_strcpy, 0x5_5527); /* call 0x10165ecf */
            ii(0x1011_09a8, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x1011_09ad, 4); movsx(edx, memw[ss, ebp - 0x8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1011_09b1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_09b4, 5); call(0x1011_0296, -0x723);              /* call 0x10110296 */
            ii(0x1011_09b9, 5); call(0x100d_51e4, -0x3_b7da);           /* call 0x100d51e4 */
            ii(0x1011_09be, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_09c0, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1011_09c2, 5); call(0x100d_5204, -0x3_b7c3);           /* call 0x100d5204 */
            ii(0x1011_09c7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_09c9, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1011_09cb, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1011_09cf, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_09d2, 3); add(eax, memd[ss, ebp - 0x4]);          /* add eax, [ebp-0x4] */
            ii(0x1011_09d5, 3); mov(eax, memd[ds, eax + 0x10]);         /* mov eax, [eax+0x10] */
            ii(0x1011_09d8, 5); call(0x100c_fa7c, -0x4_0f61);           /* call 0x100cfa7c */
            ii(0x1011_09dd, 5); call(/* sys */ 0x1016_b258, 0x5_a876);  /* call 0x1016b258 */
        l_0x1011_09e2:
            ii(0x1011_09e2, 5); jmp(0x1011_0848, -0x19f); goto l_0x1011_0848; /* jmp 0x10110848 */
        l_0x1011_09e7:
            ii(0x1011_09e7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_09e9, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_09ea, 1); pop(edi);                               /* pop edi */
            ii(0x1011_09eb, 1); pop(esi);                               /* pop esi */
            ii(0x1011_09ec, 1); pop(edx);                               /* pop edx */
            ii(0x1011_09ed, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_09ee, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_09ef, 1); ret();                                  /* ret */
        }
    }
}
