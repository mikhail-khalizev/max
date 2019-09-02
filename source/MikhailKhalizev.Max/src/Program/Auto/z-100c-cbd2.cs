using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_cbd2-56433ede")]
        public void Method_100c_cbd2()
        {
            ii(0x100c_cbd2, 5); push(0x30);                             /* push 0x30 */
            ii(0x100c_cbd7, 5); call(Definitions.sys_check_available_stack_size, 0x9_9176); /* call 0x10165d52 */
            ii(0x100c_cbdc, 1); push(ebx);                              /* push ebx */
            ii(0x100c_cbdd, 1); push(ecx);                              /* push ecx */
            ii(0x100c_cbde, 1); push(edx);                              /* push edx */
            ii(0x100c_cbdf, 1); push(esi);                              /* push esi */
            ii(0x100c_cbe0, 1); push(edi);                              /* push edi */
            ii(0x100c_cbe1, 1); push(ebp);                              /* push ebp */
            ii(0x100c_cbe2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_cbe4, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100c_cbea, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100c_cbed, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100c_cbf2, 5); call(0x1007_6338, -0x5_68bf);           /* call 0x10076338 */
            ii(0x100c_cbf7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_cbf9, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100c_cbfc, 5); call(0x1007_64b8, -0x5_6749);           /* call 0x100764b8 */
            ii(0x100c_cc01, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
            ii(0x100c_cc08, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_cc0b, 5); call(0x100c_bb8b, -0x1085);             /* call 0x100cbb8b */
            ii(0x100c_cc10, 4); cmp(ax, 9);                             /* cmp ax, 0x9 */
            ii(0x100c_cc14, 2); if(jz(0x100c_cc25, 0xf)) goto l_0x100c_cc25; /* jz 0x100ccc25 */
            ii(0x100c_cc16, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_cc18, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100c_cc1b, 5); call(0x1007_5f6c, -0x5_6cb4);           /* call 0x10075f6c */
            ii(0x100c_cc20, 5); jmp(0x100c_cd5f, 0x13a); goto l_0x100c_cd5f; /* jmp 0x100ccd5f */
        l_0x100c_cc25:
            ii(0x100c_cc25, 2); jmp(0x100c_cc2f, 8); goto l_0x100c_cc2f; /* jmp 0x100ccc2f */
        l_0x100c_cc27:
            ii(0x100c_cc27, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100c_cc2a, 5); call(0x1007_6bf8, -0x5_6037);           /* call 0x10076bf8 */
        l_0x100c_cc2f:
            ii(0x100c_cc2f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_cc31, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100c_cc34, 5); call(0x1013_ad71, 0x6_e138);            /* call 0x1013ad71 */
            ii(0x100c_cc39, 2); test(al, al);                           /* test al, al */
            ii(0x100c_cc3b, 6); if(jz(0x100c_cd47, 0x106)) goto l_0x100c_cd47; /* jz 0x100ccd47 */
            ii(0x100c_cc41, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100c_cc44, 5); call(0x1007_63a0, -0x5_68a9);           /* call 0x100763a0 */
            ii(0x100c_cc49, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_cc4b, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x100c_cc4e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_cc51, 3); mov(eax, memd[ds, eax + 7]);            /* mov eax, [eax+0x7] */
            ii(0x100c_cc54, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_cc57, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_cc59, 2); if(jnz(0x100c_cc6a, 0xf)) goto l_0x100c_cc6a; /* jnz 0x100ccc6a */
            ii(0x100c_cc5b, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100c_cc5e, 5); call(0x1007_63a0, -0x5_68c3);           /* call 0x100763a0 */
            ii(0x100c_cc63, 5); cmp(memw[ds, eax + 8], 0x3f);           /* cmp word [eax+0x8], 0x3f */
            ii(0x100c_cc68, 2); if(jz(0x100c_cc6c, 2)) goto l_0x100c_cc6c; /* jz 0x100ccc6c */
        l_0x100c_cc6a:
            ii(0x100c_cc6a, 2); jmp(0x100c_cc80, 0x14); goto l_0x100c_cc80; /* jmp 0x100ccc80 */
        l_0x100c_cc6c:
            ii(0x100c_cc6c, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100c_cc6f, 5); call(0x1007_63a0, -0x5_68d4);           /* call 0x100763a0 */
            ii(0x100c_cc74, 3); mov(al, memb[ds, eax + 0x4d]);          /* mov al, [eax+0x4d] */
            ii(0x100c_cc77, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100c_cc7c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_cc7e, 2); if(jg(0x100c_cc82, 2)) goto l_0x100c_cc82; /* jg 0x100ccc82 */
        l_0x100c_cc80:
            ii(0x100c_cc80, 2); jmp(0x100c_ccb6, 0x34); goto l_0x100c_ccb6; /* jmp 0x100cccb6 */
        l_0x100c_cc82:
            ii(0x100c_cc82, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100c_cc85, 5); call(0x1007_63a0, -0x5_68ea);           /* call 0x100763a0 */
            ii(0x100c_cc8a, 4); cmp(memb[ds, eax + 0x3d], 0);           /* cmp byte [eax+0x3d], 0x0 */
            ii(0x100c_cc8e, 2); if(jz(0x100c_ccb4, 0x24)) goto l_0x100c_ccb4; /* jz 0x100cccb4 */
            ii(0x100c_cc90, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100c_cc93, 5); call(0x1007_63a0, -0x5_68f8);           /* call 0x100763a0 */
            ii(0x100c_cc98, 4); cmp(memb[ds, eax + 0x3d], 2);           /* cmp byte [eax+0x3d], 0x2 */
            ii(0x100c_cc9c, 2); if(jnz(0x100c_ccb2, 0x14)) goto l_0x100c_ccb2; /* jnz 0x100cccb2 */
            ii(0x100c_cc9e, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100c_cca1, 5); call(0x1007_63a0, -0x5_6906);           /* call 0x100763a0 */
            ii(0x100c_cca6, 3); mov(al, memb[ds, eax + 0x4e]);          /* mov al, [eax+0x4e] */
            ii(0x100c_cca9, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100c_ccae, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_ccb0, 2); if(jz(0x100c_ccb4, 2)) goto l_0x100c_ccb4; /* jz 0x100cccb4 */
        l_0x100c_ccb2:
            ii(0x100c_ccb2, 2); jmp(0x100c_ccb6, 2); goto l_0x100c_ccb6; /* jmp 0x100cccb6 */
        l_0x100c_ccb4:
            ii(0x100c_ccb4, 2); jmp(0x100c_ccb8, 2); goto l_0x100c_ccb8; /* jmp 0x100cccb8 */
        l_0x100c_ccb6:
            ii(0x100c_ccb6, 2); jmp(0x100c_cccf, 0x17); goto l_0x100c_cccf; /* jmp 0x100ccccf */
        l_0x100c_ccb8:
            ii(0x100c_ccb8, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100c_ccbb, 3); add(edx, 0x13);                         /* add edx, 0x13 */
            ii(0x100c_ccbe, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100c_ccc1, 5); call(0x1007_6408, -0x5_68be);           /* call 0x10076408 */
            ii(0x100c_ccc6, 5); call(0x1008_b4b4, -0x4_1817);           /* call 0x1008b4b4 */
            ii(0x100c_cccb, 2); test(al, al);                           /* test al, al */
            ii(0x100c_cccd, 2); if(jnz(0x100c_ccd4, 5)) goto l_0x100c_ccd4; /* jnz 0x100cccd4 */
        l_0x100c_cccf:
            ii(0x100c_cccf, 5); jmp(0x100c_cd42, 0x6e); goto l_0x100c_cd42; /* jmp 0x100ccd42 */
        l_0x100c_ccd4:
            ii(0x100c_ccd4, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100c_ccd7, 5); call(0x1007_63a0, -0x5_693c);           /* call 0x100763a0 */
            ii(0x100c_ccdc, 5); call(0x1015_26ac, 0x8_59cb);            /* call 0x101526ac */
            ii(0x100c_cce1, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_cce3, 2); if(jz(0x100c_cd05, 0x20)) goto l_0x100c_cd05; /* jz 0x100ccd05 */
            ii(0x100c_cce5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_cce8, 3); mov(edx, memd[ds, eax + 0xb]);          /* mov edx, [eax+0xb] */
            ii(0x100c_cceb, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_ccee, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100c_ccf1, 5); call(0x1007_63a0, -0x5_6956);           /* call 0x100763a0 */
            ii(0x100c_ccf6, 5); call(0x1015_26ac, 0x8_59b1);            /* call 0x101526ac */
            ii(0x100c_ccfb, 5); call(0x100a_2bc4, -0x2_a13c);           /* call 0x100a2bc4 */
            ii(0x100c_cd00, 1); cwde();                                 /* cwde */
            ii(0x100c_cd01, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_cd03, 2); if(jle(0x100c_cd42, 0x3d)) goto l_0x100c_cd42; /* jle 0x100ccd42 */
        l_0x100c_cd05:
            ii(0x100c_cd05, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_cd08, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_cd0b, 5); call(0x1008_abbc, -0x4_2154);           /* call 0x1008abbc */
            ii(0x100c_cd10, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_cd12, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100c_cd15, 5); call(0x1007_636c, -0x5_69ae);           /* call 0x1007636c */
            ii(0x100c_cd1a, 5); call(0x100a_601a, -0x2_6d05);           /* call 0x100a601a */
            ii(0x100c_cd1f, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100c_cd22, 4); cmp(memd[ss, ebp - 0xc], 0);            /* cmp dword [ebp-0xc], 0x0 */
            ii(0x100c_cd26, 2); if(jz(0x100c_cd31, 9)) goto l_0x100c_cd31; /* jz 0x100ccd31 */
            ii(0x100c_cd28, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_cd2b, 4); cmp(ax, memw[ss, ebp - 8]);             /* cmp ax, [ebp-0x8] */
            ii(0x100c_cd2f, 2); if(jge(0x100c_cd42, 0x11)) goto l_0x100c_cd42; /* jge 0x100ccd42 */
        l_0x100c_cd31:
            ii(0x100c_cd31, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_cd34, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_cd37, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100c_cd3a, 5); call(0x1007_6408, -0x5_6937);           /* call 0x10076408 */
            ii(0x100c_cd3f, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
        l_0x100c_cd42:
            ii(0x100c_cd42, 5); jmp(0x100c_cc27, -0x120); goto l_0x100c_cc27; /* jmp 0x100ccc27 */
        l_0x100c_cd47:
            ii(0x100c_cd47, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100c_cd4a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_cd4d, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100c_cd50, 5); call(0x1007_6630, -0x5_6725);           /* call 0x10076630 */
            ii(0x100c_cd55, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_cd57, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100c_cd5a, 5); call(0x1007_5f6c, -0x5_6df3);           /* call 0x10075f6c */
        l_0x100c_cd5f:
            ii(0x100c_cd5f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_cd61, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_cd62, 1); pop(edi);                               /* pop edi */
            ii(0x100c_cd63, 1); pop(esi);                               /* pop esi */
            ii(0x100c_cd64, 1); pop(edx);                               /* pop edx */
            ii(0x100c_cd65, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_cd66, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_cd67, 1); ret();                                  /* ret */
        }
    }
}
