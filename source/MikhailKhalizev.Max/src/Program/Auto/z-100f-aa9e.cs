using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_aa9e-b9cf642a")]
        public void Method_100f_aa9e()
        {
            ii(0x100f_aa9e, 5); push(0xcc);                             /* push 0xcc */
            ii(0x100f_aaa3, 5); call(Definitions.sys_check_available_stack_size, 0x6_b2aa); /* call 0x10165d52 */
            ii(0x100f_aaa8, 1); push(ebx);                              /* push ebx */
            ii(0x100f_aaa9, 1); push(ecx);                              /* push ecx */
            ii(0x100f_aaaa, 1); push(edx);                              /* push edx */
            ii(0x100f_aaab, 1); push(esi);                              /* push esi */
            ii(0x100f_aaac, 1); push(edi);                              /* push edi */
            ii(0x100f_aaad, 1); push(ebp);                              /* push ebp */
            ii(0x100f_aaae, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_aab0, 6); sub(esp, 0x98);                         /* sub esp, 0x98 */
            ii(0x100f_aab6, 7); cmp(memd[ds, 0x101c_9450], 0);          /* cmp dword [0x101c9450], 0x0 */
            ii(0x100f_aabd, 2); if(jz(0x100f_aac8, 0x9)) goto l_0x100f_aac8; /* jz 0x100faac8 */
            ii(0x100f_aabf, 7); cmp(memb[ds, 0x101c_3888], 0);          /* cmp byte [0x101c3888], 0x0 */
            ii(0x100f_aac6, 2); if(jz(0x100f_aacd, 0x5)) goto l_0x100f_aacd; /* jz 0x100faacd */
        l_0x100f_aac8:
            ii(0x100f_aac8, 5); jmp(0x100f_b433, 0x966); goto l_0x100f_b433; /* jmp 0x100fb433 */
        l_0x100f_aacd:
            ii(0x100f_aacd, 5); call(0x1014_82f4, 0x4_d822);            /* call 0x101482f4 */
            ii(0x100f_aad2, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100f_aad5, 6); mov(edx, memd[ds, 0x101c_3984]);        /* mov edx, [0x101c3984] */
            ii(0x100f_aadb, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_aade, 5); mov(eax, memd[ds, 0x101c_3986]);        /* mov eax, [0x101c3986] */
            ii(0x100f_aae3, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_aae6, 2); or(eax, edx);                           /* or eax, edx */
            ii(0x100f_aae8, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_aaea, 2); if(jz(0x100f_ab28, 0x3c)) goto l_0x100f_ab28; /* jz 0x100fab28 */
            ii(0x100f_aaec, 5); call(0x1010_2acc, 0x7fdb);              /* call 0x10102acc */
            ii(0x100f_aaf1, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100f_aaf3, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x100f_aaf5, 6); mov(ebx, memd[ds, 0x101c_3986]);        /* mov ebx, [0x101c3986] */
            ii(0x100f_aafb, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_aafe, 6); mov(edx, memd[ds, 0x101c_3984]);        /* mov edx, [0x101c3984] */
            ii(0x100f_ab04, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_ab07, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x100f_ab0c, 5); call(0x1010_1620, 0x6b0f);              /* call 0x10101620 */
            ii(0x100f_ab11, 9); mov(memw[ds, 0x101c_3988], 0);          /* mov word [0x101c3988], 0x0 */
            ii(0x100f_ab1a, 6); mov(ax, memw[ds, 0x101c_3988]);         /* mov ax, [0x101c3988] */
            ii(0x100f_ab20, 6); mov(memw[ds, 0x101c_3986], ax);         /* mov [0x101c3986], ax */
            ii(0x100f_ab26, 2); jmp(0x100f_ab3d, 0x15); goto l_0x100f_ab3d; /* jmp 0x100fab3d */
        l_0x100f_ab28:
            ii(0x100f_ab28, 6); mov(ax, memw[ds, 0x101c_398a]);         /* mov ax, [0x101c398a] */
            ii(0x100f_ab2e, 6); mov(memw[ds, 0x101c_398c], ax);         /* mov [0x101c398c], ax */
            ii(0x100f_ab34, 9); mov(memw[ds, 0x101c_398e], 0);          /* mov word [0x101c398e], 0x0 */
        l_0x100f_ab3d:
            ii(0x100f_ab3d, 5); call(0x100e_6236, -0x1_490c);           /* call 0x100e6236 */
            ii(0x100f_ab42, 7); cmp(memb[ds, 0x101c_391a], 0);          /* cmp byte [0x101c391a], 0x0 */
            ii(0x100f_ab49, 6); if(jz(0x100f_b433, 0x8e4)) goto l_0x100f_b433; /* jz 0x100fb433 */
            ii(0x100f_ab4f, 7); cmp(memb[ds, 0x101c_391b], 0);          /* cmp byte [0x101c391b], 0x0 */
            ii(0x100f_ab56, 2); if(jz(0x100f_abaa, 0x52)) goto l_0x100f_abaa; /* jz 0x100fabaa */
            ii(0x100f_ab58, 7); cmp(memb[ds, 0x101c_391e], 0x7);        /* cmp byte [0x101c391e], 0x7 */
            ii(0x100f_ab5f, 2); if(jz(0x100f_ab6a, 0x9)) goto l_0x100f_ab6a; /* jz 0x100fab6a */
            ii(0x100f_ab61, 7); cmp(memb[ds, 0x101c_391e], 0xc);        /* cmp byte [0x101c391e], 0xc */
            ii(0x100f_ab68, 2); if(jnz(0x100f_ab6c, 0x2)) goto l_0x100f_ab6c; /* jnz 0x100fab6c */
        l_0x100f_ab6a:
            ii(0x100f_ab6a, 2); jmp(0x100f_ab75, 0x9); goto l_0x100f_ab75; /* jmp 0x100fab75 */
        l_0x100f_ab6c:
            ii(0x100f_ab6c, 7); cmp(memb[ds, 0x101c_391e], 0xd);        /* cmp byte [0x101c391e], 0xd */
            ii(0x100f_ab73, 2); if(jnz(0x100f_ab7e, 0x9)) goto l_0x100f_ab7e; /* jnz 0x100fab7e */
        l_0x100f_ab75:
            ii(0x100f_ab75, 7); mov(memb[ds, 0x101c_391b], 0);          /* mov byte [0x101c391b], 0x0 */
            ii(0x100f_ab7c, 2); jmp(0x100f_abaa, 0x2c); goto l_0x100f_abaa; /* jmp 0x100fabaa */
        l_0x100f_ab7e:
            ii(0x100f_ab7e, 5); mov(eax, 0x23);                         /* mov eax, 0x23 */
            ii(0x100f_ab83, 5); call(0x100e_883d, -0x1_234b);           /* call 0x100e883d */
            ii(0x100f_ab88, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100f_ab8b, 5); push(0x280);                            /* push 0x280 */
            ii(0x100f_ab90, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100f_ab93, 3); push(memd[ds, eax + 0x16]);             /* push dword [eax+0x16] */
            ii(0x100f_ab96, 2); push(0x70);                             /* push 0x70 */
            ii(0x100f_ab98, 2); push(0x70);                             /* push 0x70 */
            ii(0x100f_ab9a, 2); push(0x70);                             /* push 0x70 */
            ii(0x100f_ab9c, 6); push(memd[ds, 0x101c_70e0]);            /* push dword [0x101c70e0] */
            ii(0x100f_aba2, 5); call(/* sys */ 0x1016_abbc, 0x7_0015);  /* call 0x1016abbc */
            ii(0x100f_aba7, 3); add(esp, 0x18);                         /* add esp, 0x18 */
        l_0x100f_abaa:
            ii(0x100f_abaa, 7); cmp(memb[ds, 0x101c_38a3], 0);          /* cmp byte [0x101c38a3], 0x0 */
            ii(0x100f_abb1, 6); if(jz(0x100f_accf, 0x118)) goto l_0x100f_accf; /* jz 0x100faccf */
            ii(0x100f_abb7, 5); mov(eax, memd[ds, 0x101c_38a4]);        /* mov eax, [0x101c38a4] */
            ii(0x100f_abbc, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x100f_abbf, 5); mov(eax, memd[ds, 0x101c_38a8]);        /* mov eax, [0x101c38a8] */
            ii(0x100f_abc4, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100f_abc7, 5); mov(eax, memd[ds, 0x101c_38ac]);        /* mov eax, [0x101c38ac] */
            ii(0x100f_abcc, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100f_abcf, 5); mov(eax, memd[ds, 0x101c_38b0]);        /* mov eax, [0x101c38b0] */
            ii(0x100f_abd4, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100f_abd7, 5); mov(eax, 0x26);                         /* mov eax, 0x26 */
            ii(0x100f_abdc, 5); call(0x100e_883d, -0x1_23a4);           /* call 0x100e883d */
            ii(0x100f_abe1, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100f_abe4, 6); mov(edx, memd[ds, 0x101c_3898]);        /* mov edx, [0x101c3898] */
            ii(0x100f_abea, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_abed, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100f_abf0, 2); sub(edx, memd[ds, eax]);                /* sub edx, [eax] */
            ii(0x100f_abf2, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_abf4, 7); imul(eax, memd[ds, 0x101c_38c4]);       /* imul eax, [0x101c38c4] */
            ii(0x100f_abfb, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_abfe, 6); add(eax, memd[ds, 0x101c_38ec]);        /* add eax, [0x101c38ec] */
            ii(0x100f_ac04, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x100f_ac07, 5); mov(eax, memd[ds, 0x101c_389a]);        /* mov eax, [0x101c389a] */
            ii(0x100f_ac0c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_ac0f, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100f_ac12, 3); sub(eax, memd[ds, edx + 0x4]);          /* sub eax, [edx+0x4] */
            ii(0x100f_ac15, 7); imul(eax, memd[ds, 0x101c_38c4]);       /* imul eax, [0x101c38c4] */
            ii(0x100f_ac1c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_ac1f, 6); add(eax, memd[ds, 0x101c_38f0]);        /* add eax, [0x101c38f0] */
            ii(0x100f_ac25, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x100f_ac28, 4); movsx(edx, memw[ss, ebp - 0x24]);       /* movsx edx, word [ebp-0x24] */
            ii(0x100f_ac2c, 5); mov(eax, memd[ds, 0x101c_389c]);        /* mov eax, [0x101c389c] */
            ii(0x100f_ac31, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_ac34, 5); call(Definitions.my_min, -0x7_14b5);    /* call 0x10089784 */
            ii(0x100f_ac39, 5); mov(memd[ds, 0x101c_38a4], eax);        /* mov [0x101c38a4], eax */
            ii(0x100f_ac3e, 4); movsx(edx, memw[ss, ebp - 0x28]);       /* movsx edx, word [ebp-0x28] */
            ii(0x100f_ac42, 5); mov(eax, memd[ds, 0x101c_389e]);        /* mov eax, [0x101c389e] */
            ii(0x100f_ac47, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_ac4a, 5); call(Definitions.my_min, -0x7_14cb);    /* call 0x10089784 */
            ii(0x100f_ac4f, 5); mov(memd[ds, 0x101c_38a8], eax);        /* mov [0x101c38a8], eax */
            ii(0x100f_ac54, 4); movsx(edx, memw[ss, ebp - 0x24]);       /* movsx edx, word [ebp-0x24] */
            ii(0x100f_ac58, 5); mov(eax, memd[ds, 0x101c_389c]);        /* mov eax, [0x101c389c] */
            ii(0x100f_ac5d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_ac60, 5); call(0x1007_6e7c, -0x8_3de9);           /* call 0x10076e7c */
            ii(0x100f_ac65, 5); mov(memd[ds, 0x101c_38ac], eax);        /* mov [0x101c38ac], eax */
            ii(0x100f_ac6a, 4); movsx(edx, memw[ss, ebp - 0x28]);       /* movsx edx, word [ebp-0x28] */
            ii(0x100f_ac6e, 5); mov(eax, memd[ds, 0x101c_389e]);        /* mov eax, [0x101c389e] */
            ii(0x100f_ac73, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_ac76, 5); call(0x1007_6e7c, -0x8_3dff);           /* call 0x10076e7c */
            ii(0x100f_ac7b, 5); mov(memd[ds, 0x101c_38b0], eax);        /* mov [0x101c38b0], eax */
            ii(0x100f_ac80, 3); mov(edx, memd[ss, ebp - 0x20]);         /* mov edx, [ebp-0x20] */
            ii(0x100f_ac83, 5); mov(eax, memd[ds, 0x101c_38a4]);        /* mov eax, [0x101c38a4] */
            ii(0x100f_ac88, 5); call(Definitions.my_min, -0x7_1509);    /* call 0x10089784 */
            ii(0x100f_ac8d, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x100f_ac90, 3); mov(edx, memd[ss, ebp - 0x1c]);         /* mov edx, [ebp-0x1c] */
            ii(0x100f_ac93, 5); mov(eax, memd[ds, 0x101c_38a8]);        /* mov eax, [0x101c38a8] */
            ii(0x100f_ac98, 5); call(Definitions.my_min, -0x7_1519);    /* call 0x10089784 */
            ii(0x100f_ac9d, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100f_aca0, 3); mov(edx, memd[ss, ebp - 0x18]);         /* mov edx, [ebp-0x18] */
            ii(0x100f_aca3, 5); mov(eax, memd[ds, 0x101c_38ac]);        /* mov eax, [0x101c38ac] */
            ii(0x100f_aca8, 5); call(0x1007_6e7c, -0x8_3e31);           /* call 0x10076e7c */
            ii(0x100f_acad, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100f_acb0, 3); mov(edx, memd[ss, ebp - 0x14]);         /* mov edx, [ebp-0x14] */
            ii(0x100f_acb3, 5); mov(eax, memd[ds, 0x101c_38b0]);        /* mov eax, [0x101c38b0] */
            ii(0x100f_acb8, 5); call(0x1007_6e7c, -0x8_3e41);           /* call 0x10076e7c */
            ii(0x100f_acbd, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100f_acc0, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100f_acc3, 5); call(0x100f_f562, 0x489a);              /* call 0x100ff562 */
            ii(0x100f_acc8, 7); mov(memb[ds, 0x101c_38a3], 0);          /* mov byte [0x101c38a3], 0x0 */
        l_0x100f_accf:
            ii(0x100f_accf, 5); mov(al, memb[ds, 0x101c_391d]);         /* mov al, [0x101c391d] */
            ii(0x100f_acd4, 3); mov(memb[ss, ebp - 0x10], al);          /* mov [ebp-0x10], al */
            ii(0x100f_acd7, 4); cmp(memb[ss, ebp - 0x10], 0);           /* cmp byte [ebp-0x10], 0x0 */
            ii(0x100f_acdb, 2); if(jz(0x100f_acff, 0x22)) goto l_0x100f_acff; /* jz 0x100facff */
            ii(0x100f_acdd, 3); lea(eax, memd[ss, ebp - 0x38]);         /* lea eax, [ebp-0x38] */
            ii(0x100f_ace0, 5); call(0x100f_a9fd, -0x2e8);              /* call 0x100fa9fd */
            ii(0x100f_ace5, 3); lea(eax, memd[ss, ebp - 0x38]);         /* lea eax, [ebp-0x38] */
            ii(0x100f_ace8, 5); call(0x100e_800c, -0x1_2ce1);           /* call 0x100e800c */
            ii(0x100f_aced, 2); test(al, al);                           /* test al, al */
            ii(0x100f_acef, 2); if(jz(0x100f_acfb, 0xa)) goto l_0x100f_acfb; /* jz 0x100facfb */
            ii(0x100f_acf1, 3); lea(eax, memd[ss, ebp - 0x38]);         /* lea eax, [ebp-0x38] */
            ii(0x100f_acf4, 5); call(0x100f_f562, 0x4869);              /* call 0x100ff562 */
            ii(0x100f_acf9, 2); jmp(0x100f_acff, 0x4); goto l_0x100f_acff; /* jmp 0x100facff */
        l_0x100f_acfb:
            ii(0x100f_acfb, 4); mov(memb[ss, ebp - 0x10], 0);           /* mov byte [ebp-0x10], 0x0 */
        l_0x100f_acff:
            ii(0x100f_acff, 4); or(memb[ss, ebp - 0x4], 0x1);           /* or byte [ebp-0x4], 0x1 */
            ii(0x100f_ad03, 3); lea(eax, memd[ss, ebp - 0x4c]);         /* lea eax, [ebp-0x4c] */
            ii(0x100f_ad06, 5); call(0x100e_7e34, -0x1_2ed7);           /* call 0x100e7e34 */
            ii(0x100f_ad0b, 3); mov(memd[ss, ebp - 0x50], eax);         /* mov [ebp-0x50], eax */
            ii(0x100f_ad0e, 4); and(memb[ss, ebp - 0x4], -0x2 /* 0xfe */); /* and byte [ebp-0x4], 0xfe */
            ii(0x100f_ad12, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_ad14, 6); mov(dl, memb[ds, 0x101c_388d]);         /* mov dl, [0x101c388d] */
            ii(0x100f_ad1a, 3); lea(eax, memd[ss, ebp - 0x4c]);         /* lea eax, [ebp-0x4c] */
            ii(0x100f_ad1d, 5); call(0x100e_779e, -0x1_3584);           /* call 0x100e779e */
            ii(0x100f_ad22, 5); mov(eax, 0x26);                         /* mov eax, 0x26 */
            ii(0x100f_ad27, 5); call(0x100e_883d, -0x1_24ef);           /* call 0x100e883d */
            ii(0x100f_ad2c, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100f_ad2f, 7); cmp(memb[ds, 0x101c_388b], 0);          /* cmp byte [0x101c388b], 0x0 */
            ii(0x100f_ad36, 2); if(jz(0x100f_ad41, 0x9)) goto l_0x100f_ad41; /* jz 0x100fad41 */
            ii(0x100f_ad38, 7); cmp(memb[ds, 0x101c_391e], 0xb);        /* cmp byte [0x101c391e], 0xb */
            ii(0x100f_ad3f, 2); if(jz(0x100f_ad43, 0x2)) goto l_0x100f_ad43; /* jz 0x100fad43 */
        l_0x100f_ad41:
            ii(0x100f_ad41, 2); jmp(0x100f_ad50, 0xd); goto l_0x100f_ad50; /* jmp 0x100fad50 */
        l_0x100f_ad43:
            ii(0x100f_ad43, 5); mov(al, memb[ds, 0x101c_37c8]);         /* mov al, [0x101c37c8] */
            ii(0x100f_ad48, 6); cmp(al, memb[ds, 0x101c_37da]);         /* cmp al, [0x101c37da] */
            ii(0x100f_ad4e, 2); if(jnz(0x100f_ad52, 0x2)) goto l_0x100f_ad52; /* jnz 0x100fad52 */
        l_0x100f_ad50:
            ii(0x100f_ad50, 2); jmp(0x100f_ad81, 0x2f); goto l_0x100f_ad81; /* jmp 0x100fad81 */
        l_0x100f_ad52:
            ii(0x100f_ad52, 5); call(0x100e_7c7b, -0x1_30dc);           /* call 0x100e7c7b */
            ii(0x100f_ad57, 7); mov(memb[ds, 0x101c_391b], 0);          /* mov byte [0x101c391b], 0x0 */
            ii(0x100f_ad5e, 5); mov(al, memb[ds, 0x101c_391b]);         /* mov al, [0x101c391b] */
            ii(0x100f_ad63, 5); mov(memb[ds, 0x101c_391a], al);         /* mov [0x101c391a], al */
            ii(0x100f_ad68, 5); mov(al, memb[ds, 0x101c_391a]);         /* mov al, [0x101c391a] */
            ii(0x100f_ad6d, 5); mov(memb[ds, 0x101c_391c], al);         /* mov [0x101c391c], al */
            ii(0x100f_ad72, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_ad74, 3); lea(eax, memd[ss, ebp - 0x4c]);         /* lea eax, [ebp-0x4c] */
            ii(0x100f_ad77, 5); call(0x100e_7e92, -0x1_2eea);           /* call 0x100e7e92 */
            ii(0x100f_ad7c, 5); jmp(0x100f_b433, 0x6b2); goto l_0x100f_b433; /* jmp 0x100fb433 */
        l_0x100f_ad81:
            ii(0x100f_ad81, 6); dec(memb[ds, 0x101b_8746]);             /* dec byte [0x101b8746] */
            ii(0x100f_ad87, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_ad89, 5); mov(al, memb[ds, 0x101b_8746]);         /* mov al, [0x101b8746] */
            ii(0x100f_ad8e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_ad90, 2); if(jnz(0x100f_ada0, 0xe)) goto l_0x100f_ada0; /* jnz 0x100fada0 */
            ii(0x100f_ad92, 7); xor(memb[ds, 0x101b_8745], -0x1 /* 0xff */); /* xor byte [0x101b8745], 0xff */
            ii(0x100f_ad99, 7); mov(memb[ds, 0x101b_8746], 0x5);        /* mov byte [0x101b8746], 0x5 */
        l_0x100f_ada0:
            ii(0x100f_ada0, 5); call(0x100e_7640, -0x1_3765);           /* call 0x100e7640 */
            ii(0x100f_ada5, 7); cmp(memb[ds, 0x101c_388e], 0);          /* cmp byte [0x101c388e], 0x0 */
            ii(0x100f_adac, 2); if(jnz(0x100f_adb7, 0x9)) goto l_0x100f_adb7; /* jnz 0x100fadb7 */
            ii(0x100f_adae, 7); cmp(memb[ds, 0x101c_3912], 0);          /* cmp byte [0x101c3912], 0x0 */
            ii(0x100f_adb5, 2); if(jz(0x100f_adbf, 0x8)) goto l_0x100f_adbf; /* jz 0x100fadbf */
        l_0x100f_adb7:
            ii(0x100f_adb7, 3); lea(eax, memd[ss, ebp - 0x4c]);         /* lea eax, [ebp-0x4c] */
            ii(0x100f_adba, 5); call(0x100e_7b4a, -0x1_3275);           /* call 0x100e7b4a */
        l_0x100f_adbf:
            ii(0x100f_adbf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_adc1, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_adc6, 5); call(0x1013_ad71, 0x3_ffa6);            /* call 0x1013ad71 */
            ii(0x100f_adcb, 2); test(al, al);                           /* test al, al */
            ii(0x100f_adcd, 6); if(jz(0x100f_b07c, 0x2a9)) goto l_0x100f_b07c; /* jz 0x100fb07c */
            ii(0x100f_add3, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_add8, 5); call(0x1007_6574, -0x8_4869);           /* call 0x10076574 */
            ii(0x100f_addd, 5); call(0x1007_623c, -0x8_4ba6);           /* call 0x1007623c */
            ii(0x100f_ade2, 3); lea(ebx, memd[ss, ebp - 0x54]);         /* lea ebx, [ebp-0x54] */
            ii(0x100f_ade5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_ade7, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100f_ade9, 5); call(0x1007_6800, -0x8_45ee);           /* call 0x10076800 */
            ii(0x100f_adee, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_adf3, 5); call(0x1007_6574, -0x8_4884);           /* call 0x10076574 */
            ii(0x100f_adf8, 4); cmp(memb[ds, eax + 0x3e], 0x1);         /* cmp byte [eax+0x3e], 0x1 */
            ii(0x100f_adfc, 2); if(jz(0x100f_ae0e, 0x10)) goto l_0x100f_ae0e; /* jz 0x100fae0e */
            ii(0x100f_adfe, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_ae03, 5); call(0x1007_6574, -0x8_4894);           /* call 0x10076574 */
            ii(0x100f_ae08, 4); cmp(memb[ds, eax + 0x3e], 0x1d);        /* cmp byte [eax+0x3e], 0x1d */
            ii(0x100f_ae0c, 2); if(jnz(0x100f_ae10, 0x2)) goto l_0x100f_ae10; /* jnz 0x100fae10 */
        l_0x100f_ae0e:
            ii(0x100f_ae0e, 2); jmp(0x100f_ae20, 0x10); goto l_0x100f_ae20; /* jmp 0x100fae20 */
        l_0x100f_ae10:
            ii(0x100f_ae10, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_ae15, 5); call(0x1007_6574, -0x8_48a6);           /* call 0x10076574 */
            ii(0x100f_ae1a, 4); cmp(memb[ds, eax + 0x3e], 0x2);         /* cmp byte [eax+0x3e], 0x2 */
            ii(0x100f_ae1e, 2); if(jnz(0x100f_ae22, 0x2)) goto l_0x100f_ae22; /* jnz 0x100fae22 */
        l_0x100f_ae20:
            ii(0x100f_ae20, 2); jmp(0x100f_ae32, 0x10); goto l_0x100f_ae32; /* jmp 0x100fae32 */
        l_0x100f_ae22:
            ii(0x100f_ae22, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_ae27, 5); call(0x1007_6574, -0x8_48b8);           /* call 0x10076574 */
            ii(0x100f_ae2c, 4); cmp(memb[ds, eax + 0x3d], 0x4);         /* cmp byte [eax+0x3d], 0x4 */
            ii(0x100f_ae30, 2); if(jnz(0x100f_ae4f, 0x1d)) goto l_0x100f_ae4f; /* jnz 0x100fae4f */
        l_0x100f_ae32:
            ii(0x100f_ae32, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_ae34, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x100f_ae39, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100f_ae3c, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_ae41, 5); call(0x1007_6574, -0x8_48d2);           /* call 0x10076574 */
            ii(0x100f_ae46, 5); call(0x1007_6074, -0x8_4dd7);           /* call 0x10076074 */
            ii(0x100f_ae4b, 2); test(al, al);                           /* test al, al */
            ii(0x100f_ae4d, 2); if(jnz(0x100f_ae54, 0x5)) goto l_0x100f_ae54; /* jnz 0x100fae54 */
        l_0x100f_ae4f:
            ii(0x100f_ae4f, 5); jmp(0x100f_af14, 0xc0); goto l_0x100f_af14; /* jmp 0x100faf14 */
        l_0x100f_ae54:
            ii(0x100f_ae54, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_ae59, 5); call(0x1007_6600, -0x8_485e);           /* call 0x10076600 */
            ii(0x100f_ae5e, 3); mov(memd[ss, ebp - 0x58], eax);         /* mov [ebp-0x58], eax */
            ii(0x100f_ae61, 3); mov(eax, memd[ss, ebp - 0x58]);         /* mov eax, [ebp-0x58] */
            ii(0x100f_ae64, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_ae66, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x100f_ae69, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_ae6b, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x100f_ae70, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_ae72, 2); if(jnz(0x100f_ae85, 0x11)) goto l_0x100f_ae85; /* jnz 0x100fae85 */
            ii(0x100f_ae74, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_ae76, 3); mov(eax, memd[ss, ebp - 0x58]);         /* mov eax, [ebp-0x58] */
            ii(0x100f_ae79, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x100f_ae7c, 5); call(0x1013_ad71, 0x3_fef0);            /* call 0x1013ad71 */
            ii(0x100f_ae81, 2); test(al, al);                           /* test al, al */
            ii(0x100f_ae83, 2); if(jnz(0x100f_ae87, 0x2)) goto l_0x100f_ae87; /* jnz 0x100fae87 */
        l_0x100f_ae85:
            ii(0x100f_ae85, 2); jmp(0x100f_aea7, 0x20); goto l_0x100f_aea7; /* jmp 0x100faea7 */
        l_0x100f_ae87:
            ii(0x100f_ae87, 3); mov(eax, memd[ss, ebp - 0x58]);         /* mov eax, [ebp-0x58] */
            ii(0x100f_ae8a, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x100f_ae8d, 5); call(0x1007_69d8, -0x8_44ba);           /* call 0x100769d8 */
            ii(0x100f_ae92, 3); mov(memd[ss, ebp - 0x5c], eax);         /* mov [ebp-0x5c], eax */
            ii(0x100f_ae95, 3); mov(eax, memd[ss, ebp - 0x5c]);         /* mov eax, [ebp-0x5c] */
            ii(0x100f_ae98, 3); mov(ecx, memd[ds, eax + 0x2]);          /* mov ecx, [eax+0x2] */
            ii(0x100f_ae9b, 3); mov(ebx, memd[ss, ebp - 0xc]);          /* mov ebx, [ebp-0xc] */
            ii(0x100f_ae9e, 3); mov(edx, memd[ss, ebp - 0x58]);         /* mov edx, [ebp-0x58] */
            ii(0x100f_aea1, 3); mov(eax, memd[ss, ebp - 0x5c]);         /* mov eax, [ebp-0x5c] */
            ii(0x100f_aea4, 3); call_abs(memd[ds, ecx + 0x34]);         /* call dword [ecx+0x34] */
        l_0x100f_aea7:
            ii(0x100f_aea7, 7); cmp(memb[ds, 0x101c_3889], 0);          /* cmp byte [0x101c3889], 0x0 */
            ii(0x100f_aeae, 2); if(jz(0x100f_aeed, 0x3d)) goto l_0x100f_aeed; /* jz 0x100faeed */
            ii(0x100f_aeb0, 7); mov(memd[ss, ebp - 0x60], 0x1);         /* mov dword [ebp-0x60], 0x1 */
            ii(0x100f_aeb7, 3); mov(eax, memd[ss, ebp - 0x58]);         /* mov eax, [ebp-0x58] */
            ii(0x100f_aeba, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x100f_aebd, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_aec0, 5); call(0x1007_4705, -0x8_67c0);           /* call 0x10074705 */
            ii(0x100f_aec5, 2); test(al, 0x40);                         /* test al, 0x40 */
            ii(0x100f_aec7, 2); if(jz(0x100f_aed0, 0x7)) goto l_0x100f_aed0; /* jz 0x100faed0 */
            ii(0x100f_aec9, 7); mov(memd[ss, ebp - 0x60], 0x5);         /* mov dword [ebp-0x60], 0x5 */
        l_0x100f_aed0:
            ii(0x100f_aed0, 4); movsx(ecx, memw[ss, ebp - 0x60]);       /* movsx ecx, word [ebp-0x60] */
            ii(0x100f_aed4, 3); lea(eax, memd[ss, ebp - 0x54]);         /* lea eax, [ebp-0x54] */
            ii(0x100f_aed7, 5); call(0x1007_6730, -0x8_47ac);           /* call 0x10076730 */
            ii(0x100f_aedc, 3); mov(ebx, memd[ds, eax + 0x10]);         /* mov ebx, [eax+0x10] */
            ii(0x100f_aedf, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_aee2, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100f_aee5, 3); mov(eax, memd[ss, ebp - 0x58]);         /* mov eax, [ebp-0x58] */
            ii(0x100f_aee8, 5); call(0x100f_a87b, -0x672);              /* call 0x100fa87b */
        l_0x100f_aeed:
            ii(0x100f_aeed, 7); cmp(memb[ds, 0x101c_388a], 0);          /* cmp byte [0x101c388a], 0x0 */
            ii(0x100f_aef4, 2); if(jz(0x100f_af14, 0x1e)) goto l_0x100f_af14; /* jz 0x100faf14 */
            ii(0x100f_aef6, 5); mov(ecx, 0x4);                          /* mov ecx, 0x4 */
            ii(0x100f_aefb, 3); lea(eax, memd[ss, ebp - 0x54]);         /* lea eax, [ebp-0x54] */
            ii(0x100f_aefe, 5); call(0x1007_6730, -0x8_47d3);           /* call 0x10076730 */
            ii(0x100f_af03, 3); mov(ebx, memd[ds, eax + 0x15]);         /* mov ebx, [eax+0x15] */
            ii(0x100f_af06, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_af09, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100f_af0c, 3); mov(eax, memd[ss, ebp - 0x58]);         /* mov eax, [ebp-0x58] */
            ii(0x100f_af0f, 5); call(0x100f_a87b, -0x699);              /* call 0x100fa87b */
        l_0x100f_af14:
            ii(0x100f_af14, 7); cmp(memb[ds, 0x101c_388c], 0);          /* cmp byte [0x101c388c], 0x0 */
            ii(0x100f_af1b, 2); if(jz(0x100f_af32, 0x15)) goto l_0x100f_af32; /* jz 0x100faf32 */
            ii(0x100f_af1d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_af1f, 6); mov(dl, memb[ds, 0x101c_3889]);         /* mov dl, [0x101c3889] */
            ii(0x100f_af25, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_af27, 5); mov(al, memb[ds, 0x101c_388a]);         /* mov al, [0x101c388a] */
            ii(0x100f_af2c, 2); or(eax, edx);                           /* or eax, edx */
            ii(0x100f_af2e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_af30, 2); if(jnz(0x100f_af34, 0x2)) goto l_0x100f_af34; /* jnz 0x100faf34 */
        l_0x100f_af32:
            ii(0x100f_af32, 2); jmp(0x100f_af43, 0xf); goto l_0x100f_af43; /* jmp 0x100faf43 */
        l_0x100f_af34:
            ii(0x100f_af34, 5); mov(eax, 0x101c_3924);                  /* mov eax, 0x101c3924 */
            ii(0x100f_af39, 5); call(0x1007_6b90, -0x8_43ae);           /* call 0x10076b90 */
            ii(0x100f_af3e, 1); cwde();                                 /* cwde */
            ii(0x100f_af3f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_af41, 2); if(jnz(0x100f_af48, 0x5)) goto l_0x100f_af48; /* jnz 0x100faf48 */
        l_0x100f_af43:
            ii(0x100f_af43, 5); jmp(0x100f_b072, 0x12a); goto l_0x100f_b072; /* jmp 0x100fb072 */
        l_0x100f_af48:
            ii(0x100f_af48, 5); mov(eax, 0x101c_3924);                  /* mov eax, 0x101c3924 */
            ii(0x100f_af4d, 5); call(0x1007_6338, -0x8_4c1a);           /* call 0x10076338 */
            ii(0x100f_af52, 3); lea(ebx, memd[ss, ebp - 0x64]);         /* lea ebx, [ebp-0x64] */
            ii(0x100f_af55, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_af57, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100f_af59, 5); call(0x1007_64b8, -0x8_4aa6);           /* call 0x100764b8 */
        l_0x100f_af5e:
            ii(0x100f_af5e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_af60, 3); lea(eax, memd[ss, ebp - 0x64]);         /* lea eax, [ebp-0x64] */
            ii(0x100f_af63, 5); call(0x1013_ad71, 0x3_fe09);            /* call 0x1013ad71 */
            ii(0x100f_af68, 2); test(al, al);                           /* test al, al */
            ii(0x100f_af6a, 6); if(jz(0x100f_b068, 0xf8)) goto l_0x100f_b068; /* jz 0x100fb068 */
            ii(0x100f_af70, 3); lea(eax, memd[ss, ebp - 0x64]);         /* lea eax, [ebp-0x64] */
            ii(0x100f_af73, 5); call(0x1007_63a0, -0x8_4bd8);           /* call 0x100763a0 */
            ii(0x100f_af78, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_af7a, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x100f_af7d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_af7f, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x100f_af84, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_af86, 2); if(jz(0x100f_afa6, 0x1e)) goto l_0x100f_afa6; /* jz 0x100fafa6 */
            ii(0x100f_af88, 3); lea(eax, memd[ss, ebp - 0x64]);         /* lea eax, [ebp-0x64] */
            ii(0x100f_af8b, 5); call(0x1007_63a0, -0x8_4bf0);           /* call 0x100763a0 */
            ii(0x100f_af90, 4); cmp(memb[ds, eax + 0x3e], 0x1);         /* cmp byte [eax+0x3e], 0x1 */
            ii(0x100f_af94, 2); if(jz(0x100f_afa4, 0xe)) goto l_0x100f_afa4; /* jz 0x100fafa4 */
            ii(0x100f_af96, 3); lea(eax, memd[ss, ebp - 0x64]);         /* lea eax, [ebp-0x64] */
            ii(0x100f_af99, 5); call(0x1007_63a0, -0x8_4bfe);           /* call 0x100763a0 */
            ii(0x100f_af9e, 4); cmp(memb[ds, eax + 0x3e], 0x2);         /* cmp byte [eax+0x3e], 0x2 */
            ii(0x100f_afa2, 2); if(jnz(0x100f_afa6, 0x2)) goto l_0x100f_afa6; /* jnz 0x100fafa6 */
        l_0x100f_afa4:
            ii(0x100f_afa4, 2); jmp(0x100f_afa8, 0x2); goto l_0x100f_afa8; /* jmp 0x100fafa8 */
        l_0x100f_afa6:
            ii(0x100f_afa6, 2); jmp(0x100f_afc3, 0x1b); goto l_0x100f_afc3; /* jmp 0x100fafc3 */
        l_0x100f_afa8:
            ii(0x100f_afa8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_afaa, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x100f_afaf, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100f_afb2, 3); lea(eax, memd[ss, ebp - 0x64]);         /* lea eax, [ebp-0x64] */
            ii(0x100f_afb5, 5); call(0x1007_63a0, -0x8_4c1a);           /* call 0x100763a0 */
            ii(0x100f_afba, 5); call(0x1007_6074, -0x8_4f4b);           /* call 0x10076074 */
            ii(0x100f_afbf, 2); test(al, al);                           /* test al, al */
            ii(0x100f_afc1, 2); if(jnz(0x100f_afc8, 0x5)) goto l_0x100f_afc8; /* jnz 0x100fafc8 */
        l_0x100f_afc3:
            ii(0x100f_afc3, 5); jmp(0x100f_b05b, 0x93); goto l_0x100f_b05b; /* jmp 0x100fb05b */
        l_0x100f_afc8:
            ii(0x100f_afc8, 3); lea(eax, memd[ss, ebp - 0x64]);         /* lea eax, [ebp-0x64] */
            ii(0x100f_afcb, 5); call(0x1007_63a0, -0x8_4c30);           /* call 0x100763a0 */
            ii(0x100f_afd0, 5); call(0x1007_623c, -0x8_4d99);           /* call 0x1007623c */
            ii(0x100f_afd5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_afd7, 3); lea(eax, memd[ss, ebp - 0x54]);         /* lea eax, [ebp-0x54] */
            ii(0x100f_afda, 5); call(0x100c_b77c, -0x2_f863);           /* call 0x100cb77c */
            ii(0x100f_afdf, 7); cmp(memb[ds, 0x101c_3889], 0);          /* cmp byte [0x101c3889], 0x0 */
            ii(0x100f_afe6, 2); if(jz(0x100f_b02f, 0x47)) goto l_0x100f_b02f; /* jz 0x100fb02f */
            ii(0x100f_afe8, 7); mov(memd[ss, ebp - 0x68], 0x1);         /* mov dword [ebp-0x68], 0x1 */
            ii(0x100f_afef, 3); lea(eax, memd[ss, ebp - 0x64]);         /* lea eax, [ebp-0x64] */
            ii(0x100f_aff2, 5); call(0x1007_63a0, -0x8_4c57);           /* call 0x100763a0 */
            ii(0x100f_aff7, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x100f_affa, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_affd, 5); call(0x1007_4705, -0x8_68fd);           /* call 0x10074705 */
            ii(0x100f_b002, 2); test(al, 0x40);                         /* test al, 0x40 */
            ii(0x100f_b004, 2); if(jz(0x100f_b00d, 0x7)) goto l_0x100f_b00d; /* jz 0x100fb00d */
            ii(0x100f_b006, 7); mov(memd[ss, ebp - 0x68], 0x5);         /* mov dword [ebp-0x68], 0x5 */
        l_0x100f_b00d:
            ii(0x100f_b00d, 4); movsx(ecx, memw[ss, ebp - 0x68]);       /* movsx ecx, word [ebp-0x68] */
            ii(0x100f_b011, 3); lea(eax, memd[ss, ebp - 0x54]);         /* lea eax, [ebp-0x54] */
            ii(0x100f_b014, 5); call(0x1007_6730, -0x8_48e9);           /* call 0x10076730 */
            ii(0x100f_b019, 3); mov(ebx, memd[ds, eax + 0x10]);         /* mov ebx, [eax+0x10] */
            ii(0x100f_b01c, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_b01f, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100f_b022, 3); lea(eax, memd[ss, ebp - 0x64]);         /* lea eax, [ebp-0x64] */
            ii(0x100f_b025, 5); call(0x1007_6408, -0x8_4c22);           /* call 0x10076408 */
            ii(0x100f_b02a, 5); call(0x100f_a87b, -0x7b4);              /* call 0x100fa87b */
        l_0x100f_b02f:
            ii(0x100f_b02f, 7); cmp(memb[ds, 0x101c_388a], 0);          /* cmp byte [0x101c388a], 0x0 */
            ii(0x100f_b036, 2); if(jz(0x100f_b05b, 0x23)) goto l_0x100f_b05b; /* jz 0x100fb05b */
            ii(0x100f_b038, 5); mov(ecx, 0x4);                          /* mov ecx, 0x4 */
            ii(0x100f_b03d, 3); lea(eax, memd[ss, ebp - 0x54]);         /* lea eax, [ebp-0x54] */
            ii(0x100f_b040, 5); call(0x1007_6730, -0x8_4915);           /* call 0x10076730 */
            ii(0x100f_b045, 3); mov(ebx, memd[ds, eax + 0x15]);         /* mov ebx, [eax+0x15] */
            ii(0x100f_b048, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_b04b, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100f_b04e, 3); lea(eax, memd[ss, ebp - 0x64]);         /* lea eax, [ebp-0x64] */
            ii(0x100f_b051, 5); call(0x1007_6408, -0x8_4c4e);           /* call 0x10076408 */
            ii(0x100f_b056, 5); call(0x100f_a87b, -0x7e0);              /* call 0x100fa87b */
        l_0x100f_b05b:
            ii(0x100f_b05b, 3); lea(eax, memd[ss, ebp - 0x64]);         /* lea eax, [ebp-0x64] */
            ii(0x100f_b05e, 5); call(0x1007_6bf8, -0x8_446b);           /* call 0x10076bf8 */
            ii(0x100f_b063, 5); jmp(0x100f_af5e, -0x10a); goto l_0x100f_af5e; /* jmp 0x100faf5e */
        l_0x100f_b068:
            ii(0x100f_b068, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_b06a, 3); lea(eax, memd[ss, ebp - 0x64]);         /* lea eax, [ebp-0x64] */
            ii(0x100f_b06d, 5); call(0x1007_5f6c, -0x8_5106);           /* call 0x10075f6c */
        l_0x100f_b072:
            ii(0x100f_b072, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_b074, 3); lea(eax, memd[ss, ebp - 0x54]);         /* lea eax, [ebp-0x54] */
            ii(0x100f_b077, 5); call(0x1007_5eec, -0x8_5190);           /* call 0x10075eec */
        l_0x100f_b07c:
            ii(0x100f_b07c, 4); cmp(memb[ss, ebp - 0x10], 0);           /* cmp byte [ebp-0x10], 0x0 */
            ii(0x100f_b080, 2); if(jz(0x100f_b087, 0x5)) goto l_0x100f_b087; /* jz 0x100fb087 */
            ii(0x100f_b082, 5); call(0x1011_5f9e, 0x1_af17);            /* call 0x10115f9e */
        l_0x100f_b087:
            ii(0x100f_b087, 7); cmp(memb[ds, 0x101c_38a2], 0x2);        /* cmp byte [0x101c38a2], 0x2 */
            ii(0x100f_b08e, 6); if(jnz(0x100f_b2b5, 0x221)) goto l_0x100f_b2b5; /* jnz 0x100fb2b5 */
            ii(0x100f_b094, 6); mov(edx, memd[ds, 0x101c_38a4]);        /* mov edx, [0x101c38a4] */
            ii(0x100f_b09a, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x100f_b09d, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_b09f, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_b0a2, 6); idiv(memd[ds, 0x101c_38c4]);            /* idiv dword [0x101c38c4] */
            ii(0x100f_b0a8, 6); mov(edx, memd[ds, 0x101c_38fa]);        /* mov edx, [0x101c38fa] */
            ii(0x100f_b0ae, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_b0b1, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100f_b0b3, 3); mov(memd[ss, ebp - 0x6c], eax);         /* mov [ebp-0x6c], eax */
            ii(0x100f_b0b6, 6); mov(edx, memd[ds, 0x101c_38a8]);        /* mov edx, [0x101c38a8] */
            ii(0x100f_b0bc, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x100f_b0bf, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_b0c1, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_b0c4, 6); idiv(memd[ds, 0x101c_38c4]);            /* idiv dword [0x101c38c4] */
            ii(0x100f_b0ca, 6); mov(edx, memd[ds, 0x101c_38fc]);        /* mov edx, [0x101c38fc] */
            ii(0x100f_b0d0, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_b0d3, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100f_b0d5, 3); mov(memd[ss, ebp - 0x70], eax);         /* mov [ebp-0x70], eax */
            ii(0x100f_b0d8, 6); mov(edx, memd[ds, 0x101c_38ac]);        /* mov edx, [0x101c38ac] */
            ii(0x100f_b0de, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x100f_b0e1, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_b0e3, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_b0e6, 6); idiv(memd[ds, 0x101c_38c4]);            /* idiv dword [0x101c38c4] */
            ii(0x100f_b0ec, 6); mov(edx, memd[ds, 0x101c_38fa]);        /* mov edx, [0x101c38fa] */
            ii(0x100f_b0f2, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_b0f5, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100f_b0f7, 3); mov(memd[ss, ebp - 0x74], eax);         /* mov [ebp-0x74], eax */
            ii(0x100f_b0fa, 6); mov(edx, memd[ds, 0x101c_38b0]);        /* mov edx, [0x101c38b0] */
            ii(0x100f_b100, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x100f_b103, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_b105, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_b108, 6); idiv(memd[ds, 0x101c_38c4]);            /* idiv dword [0x101c38c4] */
            ii(0x100f_b10e, 6); mov(edx, memd[ds, 0x101c_38fc]);        /* mov edx, [0x101c38fc] */
            ii(0x100f_b114, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_b117, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100f_b119, 3); mov(memd[ss, ebp - 0x78], eax);         /* mov [ebp-0x78], eax */
            ii(0x100f_b11c, 5); mov(eax, memd[ds, 0x101c_38a4]);        /* mov eax, [0x101c38a4] */
            ii(0x100f_b121, 6); cmp(eax, memd[ds, 0x101c_38f4]);        /* cmp eax, [0x101c38f4] */
            ii(0x100f_b127, 2); if(jg(0x100f_b136, 0xd)) goto l_0x100f_b136; /* jg 0x100fb136 */
            ii(0x100f_b129, 5); mov(eax, memd[ds, 0x101c_38ac]);        /* mov eax, [0x101c38ac] */
            ii(0x100f_b12e, 6); cmp(eax, memd[ds, 0x101c_38ec]);        /* cmp eax, [0x101c38ec] */
            ii(0x100f_b134, 2); if(jge(0x100f_b138, 0x2)) goto l_0x100f_b138; /* jge 0x100fb138 */
        l_0x100f_b136:
            ii(0x100f_b136, 2); jmp(0x100f_b145, 0xd); goto l_0x100f_b145; /* jmp 0x100fb145 */
        l_0x100f_b138:
            ii(0x100f_b138, 5); mov(eax, memd[ds, 0x101c_38a8]);        /* mov eax, [0x101c38a8] */
            ii(0x100f_b13d, 6); cmp(eax, memd[ds, 0x101c_38f8]);        /* cmp eax, [0x101c38f8] */
            ii(0x100f_b143, 2); if(jle(0x100f_b147, 0x2)) goto l_0x100f_b147; /* jle 0x100fb147 */
        l_0x100f_b145:
            ii(0x100f_b145, 2); jmp(0x100f_b154, 0xd); goto l_0x100f_b154; /* jmp 0x100fb154 */
        l_0x100f_b147:
            ii(0x100f_b147, 5); mov(eax, memd[ds, 0x101c_38b0]);        /* mov eax, [0x101c38b0] */
            ii(0x100f_b14c, 6); cmp(eax, memd[ds, 0x101c_38f0]);        /* cmp eax, [0x101c38f0] */
            ii(0x100f_b152, 2); if(jge(0x100f_b159, 0x5)) goto l_0x100f_b159; /* jge 0x100fb159 */
        l_0x100f_b154:
            ii(0x100f_b154, 5); jmp(0x100f_b2b5, 0x15c); goto l_0x100f_b2b5; /* jmp 0x100fb2b5 */
        l_0x100f_b159:
            ii(0x100f_b159, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_b15b, 4); movsx(eax, memw[ss, ebp - 0x6c]);       /* movsx eax, word [ebp-0x6c] */
            ii(0x100f_b15f, 5); call(0x1007_6e7c, -0x8_42e8);           /* call 0x10076e7c */
            ii(0x100f_b164, 3); mov(memd[ss, ebp - 0x7c], eax);         /* mov [ebp-0x7c], eax */
            ii(0x100f_b167, 5); mov(eax, memd[ds, 0x101b_8746]);        /* mov eax, [0x101b8746] */
            ii(0x100f_b16c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_b16f, 3); lea(edx, memd[ds, eax - 0x1]);          /* lea edx, [eax-0x1] */
            ii(0x100f_b172, 4); movsx(eax, memw[ss, ebp - 0x74]);       /* movsx eax, word [ebp-0x74] */
            ii(0x100f_b176, 5); call(Definitions.my_min, -0x7_19f7);    /* call 0x10089784 */
            ii(0x100f_b17b, 3); mov(memd[ss, ebp - 0x80], eax);         /* mov [ebp-0x80], eax */
            ii(0x100f_b17e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_b180, 4); movsx(eax, memw[ss, ebp - 0x70]);       /* movsx eax, word [ebp-0x70] */
            ii(0x100f_b184, 5); call(0x1007_6e7c, -0x8_430d);           /* call 0x10076e7c */
            ii(0x100f_b189, 6); mov(memd[ss, ebp - 0x84], eax);         /* mov [ebp-0x84], eax */
            ii(0x100f_b18f, 5); mov(eax, memd[ds, 0x101b_8748]);        /* mov eax, [0x101b8748] */
            ii(0x100f_b194, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_b197, 3); lea(edx, memd[ds, eax - 0x1]);          /* lea edx, [eax-0x1] */
            ii(0x100f_b19a, 4); movsx(eax, memw[ss, ebp - 0x78]);       /* movsx eax, word [ebp-0x78] */
            ii(0x100f_b19e, 5); call(Definitions.my_min, -0x7_1a1f);    /* call 0x10089784 */
            ii(0x100f_b1a3, 6); mov(memd[ss, ebp - 0x88], eax);         /* mov [ebp-0x88], eax */
            ii(0x100f_b1a9, 5); mov(eax, memd[ds, 0x101c_38a8]);        /* mov eax, [0x101c38a8] */
            ii(0x100f_b1ae, 6); cmp(eax, memd[ds, 0x101c_38f0]);        /* cmp eax, [0x101c38f0] */
            ii(0x100f_b1b4, 2); if(jl(0x100f_b1c3, 0xd)) goto l_0x100f_b1c3; /* jl 0x100fb1c3 */
            ii(0x100f_b1b6, 5); mov(eax, memd[ds, 0x101c_38a8]);        /* mov eax, [0x101c38a8] */
            ii(0x100f_b1bb, 6); cmp(eax, memd[ds, 0x101c_38f8]);        /* cmp eax, [0x101c38f8] */
            ii(0x100f_b1c1, 2); if(jle(0x100f_b1c5, 0x2)) goto l_0x100f_b1c5; /* jle 0x100fb1c5 */
        l_0x100f_b1c3:
            ii(0x100f_b1c3, 2); jmp(0x100f_b1e9, 0x24); goto l_0x100f_b1e9; /* jmp 0x100fb1e9 */
        l_0x100f_b1c5:
            ii(0x100f_b1c5, 2); push(0x4);                              /* push 0x4 */
            ii(0x100f_b1c7, 4); movsx(eax, memw[ss, ebp - 0x70]);       /* movsx eax, word [ebp-0x70] */
            ii(0x100f_b1cb, 1); push(eax);                              /* push eax */
            ii(0x100f_b1cc, 4); movsx(eax, memw[ss, ebp - 0x80]);       /* movsx eax, word [ebp-0x80] */
            ii(0x100f_b1d0, 1); push(eax);                              /* push eax */
            ii(0x100f_b1d1, 4); movsx(ecx, memw[ss, ebp - 0x70]);       /* movsx ecx, word [ebp-0x70] */
            ii(0x100f_b1d5, 4); movsx(ebx, memw[ss, ebp - 0x7c]);       /* movsx ebx, word [ebp-0x7c] */
            ii(0x100f_b1d9, 5); mov(edx, 0x280);                        /* mov edx, 0x280 */
            ii(0x100f_b1de, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100f_b1e1, 3); mov(eax, memd[ds, eax + 0x16]);         /* mov eax, [eax+0x16] */
            ii(0x100f_b1e4, 5); call(/* sys */ 0x1016_a5a0, 0x6_f3b7);  /* call 0x1016a5a0 */
        l_0x100f_b1e9:
            ii(0x100f_b1e9, 5); mov(eax, memd[ds, 0x101c_38ac]);        /* mov eax, [0x101c38ac] */
            ii(0x100f_b1ee, 6); cmp(eax, memd[ds, 0x101c_38ec]);        /* cmp eax, [0x101c38ec] */
            ii(0x100f_b1f4, 2); if(jl(0x100f_b203, 0xd)) goto l_0x100f_b203; /* jl 0x100fb203 */
            ii(0x100f_b1f6, 5); mov(eax, memd[ds, 0x101c_38ac]);        /* mov eax, [0x101c38ac] */
            ii(0x100f_b1fb, 6); cmp(eax, memd[ds, 0x101c_38f4]);        /* cmp eax, [0x101c38f4] */
            ii(0x100f_b201, 2); if(jle(0x100f_b205, 0x2)) goto l_0x100f_b205; /* jle 0x100fb205 */
        l_0x100f_b203:
            ii(0x100f_b203, 2); jmp(0x100f_b22f, 0x2a); goto l_0x100f_b22f; /* jmp 0x100fb22f */
        l_0x100f_b205:
            ii(0x100f_b205, 2); push(0x4);                              /* push 0x4 */
            ii(0x100f_b207, 7); movsx(eax, memw[ss, ebp - 0x88]);       /* movsx eax, word [ebp-0x88] */
            ii(0x100f_b20e, 1); push(eax);                              /* push eax */
            ii(0x100f_b20f, 4); movsx(eax, memw[ss, ebp - 0x74]);       /* movsx eax, word [ebp-0x74] */
            ii(0x100f_b213, 1); push(eax);                              /* push eax */
            ii(0x100f_b214, 7); movsx(ecx, memw[ss, ebp - 0x84]);       /* movsx ecx, word [ebp-0x84] */
            ii(0x100f_b21b, 4); movsx(ebx, memw[ss, ebp - 0x74]);       /* movsx ebx, word [ebp-0x74] */
            ii(0x100f_b21f, 5); mov(edx, 0x280);                        /* mov edx, 0x280 */
            ii(0x100f_b224, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100f_b227, 3); mov(eax, memd[ds, eax + 0x16]);         /* mov eax, [eax+0x16] */
            ii(0x100f_b22a, 5); call(/* sys */ 0x1016_a5a0, 0x6_f371);  /* call 0x1016a5a0 */
        l_0x100f_b22f:
            ii(0x100f_b22f, 5); mov(eax, memd[ds, 0x101c_38b0]);        /* mov eax, [0x101c38b0] */
            ii(0x100f_b234, 6); cmp(eax, memd[ds, 0x101c_38f0]);        /* cmp eax, [0x101c38f0] */
            ii(0x100f_b23a, 2); if(jl(0x100f_b249, 0xd)) goto l_0x100f_b249; /* jl 0x100fb249 */
            ii(0x100f_b23c, 5); mov(eax, memd[ds, 0x101c_38b0]);        /* mov eax, [0x101c38b0] */
            ii(0x100f_b241, 6); cmp(eax, memd[ds, 0x101c_38f8]);        /* cmp eax, [0x101c38f8] */
            ii(0x100f_b247, 2); if(jle(0x100f_b24b, 0x2)) goto l_0x100f_b24b; /* jle 0x100fb24b */
        l_0x100f_b249:
            ii(0x100f_b249, 2); jmp(0x100f_b26f, 0x24); goto l_0x100f_b26f; /* jmp 0x100fb26f */
        l_0x100f_b24b:
            ii(0x100f_b24b, 2); push(0x4);                              /* push 0x4 */
            ii(0x100f_b24d, 4); movsx(eax, memw[ss, ebp - 0x78]);       /* movsx eax, word [ebp-0x78] */
            ii(0x100f_b251, 1); push(eax);                              /* push eax */
            ii(0x100f_b252, 4); movsx(eax, memw[ss, ebp - 0x80]);       /* movsx eax, word [ebp-0x80] */
            ii(0x100f_b256, 1); push(eax);                              /* push eax */
            ii(0x100f_b257, 4); movsx(ecx, memw[ss, ebp - 0x78]);       /* movsx ecx, word [ebp-0x78] */
            ii(0x100f_b25b, 4); movsx(ebx, memw[ss, ebp - 0x7c]);       /* movsx ebx, word [ebp-0x7c] */
            ii(0x100f_b25f, 5); mov(edx, 0x280);                        /* mov edx, 0x280 */
            ii(0x100f_b264, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100f_b267, 3); mov(eax, memd[ds, eax + 0x16]);         /* mov eax, [eax+0x16] */
            ii(0x100f_b26a, 5); call(/* sys */ 0x1016_a5a0, 0x6_f331);  /* call 0x1016a5a0 */
        l_0x100f_b26f:
            ii(0x100f_b26f, 5); mov(eax, memd[ds, 0x101c_38a4]);        /* mov eax, [0x101c38a4] */
            ii(0x100f_b274, 6); cmp(eax, memd[ds, 0x101c_38ec]);        /* cmp eax, [0x101c38ec] */
            ii(0x100f_b27a, 2); if(jl(0x100f_b289, 0xd)) goto l_0x100f_b289; /* jl 0x100fb289 */
            ii(0x100f_b27c, 5); mov(eax, memd[ds, 0x101c_38a4]);        /* mov eax, [0x101c38a4] */
            ii(0x100f_b281, 6); cmp(eax, memd[ds, 0x101c_38f4]);        /* cmp eax, [0x101c38f4] */
            ii(0x100f_b287, 2); if(jle(0x100f_b28b, 0x2)) goto l_0x100f_b28b; /* jle 0x100fb28b */
        l_0x100f_b289:
            ii(0x100f_b289, 2); jmp(0x100f_b2b5, 0x2a); goto l_0x100f_b2b5; /* jmp 0x100fb2b5 */
        l_0x100f_b28b:
            ii(0x100f_b28b, 2); push(0x4);                              /* push 0x4 */
            ii(0x100f_b28d, 7); movsx(eax, memw[ss, ebp - 0x88]);       /* movsx eax, word [ebp-0x88] */
            ii(0x100f_b294, 1); push(eax);                              /* push eax */
            ii(0x100f_b295, 4); movsx(eax, memw[ss, ebp - 0x6c]);       /* movsx eax, word [ebp-0x6c] */
            ii(0x100f_b299, 1); push(eax);                              /* push eax */
            ii(0x100f_b29a, 7); movsx(ecx, memw[ss, ebp - 0x84]);       /* movsx ecx, word [ebp-0x84] */
            ii(0x100f_b2a1, 4); movsx(ebx, memw[ss, ebp - 0x6c]);       /* movsx ebx, word [ebp-0x6c] */
            ii(0x100f_b2a5, 5); mov(edx, 0x280);                        /* mov edx, 0x280 */
            ii(0x100f_b2aa, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100f_b2ad, 3); mov(eax, memd[ds, eax + 0x16]);         /* mov eax, [eax+0x16] */
            ii(0x100f_b2b0, 5); call(/* sys */ 0x1016_a5a0, 0x6_f2eb);  /* call 0x1016a5a0 */
        l_0x100f_b2b5:
            ii(0x100f_b2b5, 5); call(0x100e_7c7b, -0x1_363f);           /* call 0x100e7c7b */
            ii(0x100f_b2ba, 7); mov(memb[ds, 0x101c_391a], 0);          /* mov byte [0x101c391a], 0x0 */
            ii(0x100f_b2c1, 5); mov(al, memb[ds, 0x101c_391a]);         /* mov al, [0x101c391a] */
            ii(0x100f_b2c6, 5); mov(memb[ds, 0x101c_391c], al);         /* mov [0x101c391c], al */
            ii(0x100f_b2cb, 7); cmp(memb[ds, 0x101c_391b], 0);          /* cmp byte [0x101c391b], 0x0 */
            ii(0x100f_b2d2, 6); if(jz(0x100f_b429, 0x151)) goto l_0x100f_b429; /* jz 0x100fb429 */
            ii(0x100f_b2d8, 5); mov(eax, 0x23);                         /* mov eax, 0x23 */
            ii(0x100f_b2dd, 5); call(0x100e_883d, -0x1_2aa5);           /* call 0x100e883d */
            ii(0x100f_b2e2, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100f_b2e5, 2); push(0x1);                              /* push 0x1 */
            ii(0x100f_b2e7, 5); mov(eax, memd[ds, 0x101c_38de]);        /* mov eax, [0x101c38de] */
            ii(0x100f_b2ec, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_b2ef, 1); push(eax);                              /* push eax */
            ii(0x100f_b2f0, 5); mov(eax, memd[ds, 0x101c_38dc]);        /* mov eax, [0x101c38dc] */
            ii(0x100f_b2f5, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_b2f8, 1); push(eax);                              /* push eax */
            ii(0x100f_b2f9, 6); mov(ecx, memd[ds, 0x101c_38da]);        /* mov ecx, [0x101c38da] */
            ii(0x100f_b2ff, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100f_b302, 6); mov(ebx, memd[ds, 0x101c_38d8]);        /* mov ebx, [0x101c38d8] */
            ii(0x100f_b308, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_b30b, 5); mov(edx, 0x280);                        /* mov edx, 0x280 */
            ii(0x100f_b310, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100f_b313, 3); mov(eax, memd[ds, eax + 0x16]);         /* mov eax, [eax+0x16] */
            ii(0x100f_b316, 5); call(/* sys */ 0x1016_a68c, 0x6_f371);  /* call 0x1016a68c */
            ii(0x100f_b31b, 7); cmp(memb[ds, 0x101c_37d0], 0);          /* cmp byte [0x101c37d0], 0x0 */
            ii(0x100f_b322, 6); if(jz(0x100f_b414, 0xec)) goto l_0x100f_b414; /* jz 0x100fb414 */
            ii(0x100f_b328, 5); mov(eax, memd[ds, 0x101c_70e4]);        /* mov eax, [0x101c70e4] */
            ii(0x100f_b32d, 6); mov(memd[ss, ebp - 0x8c], eax);         /* mov [ebp-0x8c], eax */
            ii(0x100f_b333, 6); mov(edx, memd[ds, 0x101c_38e4]);        /* mov edx, [0x101c38e4] */
            ii(0x100f_b339, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_b33c, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100f_b33f, 3); mov(eax, memd[ds, eax + 0x16]);         /* mov eax, [eax+0x16] */
            ii(0x100f_b342, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100f_b344, 5); mov(eax, memd[ds, 0x101c_38e6]);        /* mov eax, [0x101c38e6] */
            ii(0x100f_b349, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_b34c, 6); imul(eax, eax, 0x280);                  /* imul eax, eax, 0x280 */
            ii(0x100f_b352, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100f_b354, 6); mov(memd[ss, ebp - 0x90], edx);         /* mov [ebp-0x90], edx */
            ii(0x100f_b35a, 10); mov(memd[ss, ebp - 0x94], 0x38);       /* mov dword [ebp-0x94], 0x38 */
        l_0x100f_b364:
            ii(0x100f_b364, 6); dec(memd[ss, ebp - 0x94]);              /* dec dword [ebp-0x94] */
            ii(0x100f_b36a, 8); cmp(memw[ss, ebp - 0x94], -0x1 /* 0xff */); /* cmp word [ebp-0x94], 0xffff */
            ii(0x100f_b372, 6); if(jz(0x100f_b3f5, 0x7d)) goto l_0x100f_b3f5; /* jz 0x100fb3f5 */
            ii(0x100f_b378, 10); mov(memd[ss, ebp - 0x98], 0x38);       /* mov dword [ebp-0x98], 0x38 */
        l_0x100f_b382:
            ii(0x100f_b382, 6); dec(memd[ss, ebp - 0x98]);              /* dec dword [ebp-0x98] */
            ii(0x100f_b388, 8); cmp(memw[ss, ebp - 0x98], -0x1 /* 0xff */); /* cmp word [ebp-0x98], 0xffff */
            ii(0x100f_b390, 2); if(jz(0x100f_b3c6, 0x34)) goto l_0x100f_b3c6; /* jz 0x100fb3c6 */
            ii(0x100f_b392, 6); mov(edx, memd[ss, ebp - 0x8c]);         /* mov edx, [ebp-0x8c] */
            ii(0x100f_b398, 6); inc(memd[ss, ebp - 0x8c]);              /* inc dword [ebp-0x8c] */
            ii(0x100f_b39e, 6); mov(eax, memd[ss, ebp - 0x90]);         /* mov eax, [ebp-0x90] */
            ii(0x100f_b3a4, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x100f_b3a6, 2); mov(memb[ds, edx], al);                 /* mov [edx], al */
            ii(0x100f_b3a8, 6); mov(eax, memd[ss, ebp - 0x90]);         /* mov eax, [ebp-0x90] */
            ii(0x100f_b3ae, 6); inc(memd[ss, ebp - 0x90]);              /* inc dword [ebp-0x90] */
            ii(0x100f_b3b4, 6); mov(edx, memd[ss, ebp - 0x8c]);         /* mov edx, [ebp-0x8c] */
            ii(0x100f_b3ba, 6); inc(memd[ss, ebp - 0x8c]);              /* inc dword [ebp-0x8c] */
            ii(0x100f_b3c0, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x100f_b3c2, 2); mov(memb[ds, edx], al);                 /* mov [edx], al */
            ii(0x100f_b3c4, 2); jmp(0x100f_b382, -0x44); goto l_0x100f_b382; /* jmp 0x100fb382 */
        l_0x100f_b3c6:
            ii(0x100f_b3c6, 5); mov(ebx, 0x70);                         /* mov ebx, 0x70 */
            ii(0x100f_b3cb, 6); mov(edx, memd[ss, ebp - 0x8c]);         /* mov edx, [ebp-0x8c] */
            ii(0x100f_b3d1, 3); sub(edx, 0x70);                         /* sub edx, 0x70 */
            ii(0x100f_b3d4, 6); mov(eax, memd[ss, ebp - 0x8c]);         /* mov eax, [ebp-0x8c] */
            ii(0x100f_b3da, 5); call(Definitions.sys_memcpy, 0x6_aa6c); /* call 0x10165e4b */
            ii(0x100f_b3df, 10); add(memd[ss, ebp - 0x90], 0x248);      /* add dword [ebp-0x90], 0x248 */
            ii(0x100f_b3e9, 7); add(memd[ss, ebp - 0x8c], 0x70);        /* add dword [ebp-0x8c], 0x70 */
            ii(0x100f_b3f0, 5); jmp(0x100f_b364, -0x91); goto l_0x100f_b364; /* jmp 0x100fb364 */
        l_0x100f_b3f5:
            ii(0x100f_b3f5, 5); push(0x280);                            /* push 0x280 */
            ii(0x100f_b3fa, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100f_b3fd, 3); push(memd[ds, eax + 0x16]);             /* push dword [eax+0x16] */
            ii(0x100f_b400, 2); push(0x70);                             /* push 0x70 */
            ii(0x100f_b402, 2); push(0x70);                             /* push 0x70 */
            ii(0x100f_b404, 2); push(0x70);                             /* push 0x70 */
            ii(0x100f_b406, 6); push(memd[ds, 0x101c_70e4]);            /* push dword [0x101c70e4] */
            ii(0x100f_b40c, 5); call(/* sys */ 0x1016_abbc, 0x6_f7ab);  /* call 0x1016abbc */
            ii(0x100f_b411, 3); add(esp, 0x18);                         /* add esp, 0x18 */
        l_0x100f_b414:
            ii(0x100f_b414, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100f_b417, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100f_b41a, 3); mov(eax, memd[ds, eax + 0x12]);         /* mov eax, [eax+0x12] */
            ii(0x100f_b41d, 5); call(Definitions.sys_display_draw_1, 0x6_c086); /* call 0x101674a8 */
            ii(0x100f_b422, 7); mov(memb[ds, 0x101c_391b], 0);          /* mov byte [0x101c391b], 0x0 */
        l_0x100f_b429:
            ii(0x100f_b429, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_b42b, 3); lea(eax, memd[ss, ebp - 0x4c]);         /* lea eax, [ebp-0x4c] */
            ii(0x100f_b42e, 5); call(0x100e_7e92, -0x1_35a1);           /* call 0x100e7e92 */
        l_0x100f_b433:
            ii(0x100f_b433, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_b435, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_b436, 1); pop(edi);                               /* pop edi */
            ii(0x100f_b437, 1); pop(esi);                               /* pop esi */
            ii(0x100f_b438, 1); pop(edx);                               /* pop edx */
            ii(0x100f_b439, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_b43a, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_b43b, 1); ret();                                  /* ret */
        }
    }
}
