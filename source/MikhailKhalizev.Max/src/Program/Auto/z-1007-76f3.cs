using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_76f3-90c2525e")]
        public void Method_1007_76f3()
        {
            ii(0x1007_76f3, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1007_76f8, 5); calld(Definitions.sys_check_available_stack_size, 0xe_e655); /* call 0x10165d52 */
            ii(0x1007_76fd, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_76fe, 1); pushd(esi);                             /* push esi */
            ii(0x1007_76ff, 1); pushd(edi);                             /* push edi */
            ii(0x1007_7700, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_7701, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_7703, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1007_7709, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_770c, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_770f, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1007_7712, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1007_7717, 5); calld(0x1007_6338, -0x13e4);            /* call 0x10076338 */
            ii(0x1007_771c, 3); lea(ebx, ebp - 0x14);                   /* lea ebx, [ebp-0x14] */
            ii(0x1007_771f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_7721, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1007_7723, 5); calld(0x1007_64b8, -0x1270);            /* call 0x100764b8 */
            ii(0x1007_7728, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_772b, 5); calld(0x1007_623c, -0x14f4);            /* call 0x1007623c */
            ii(0x1007_7730, 4); mov(ax, memw_a32[ds, eax + 0x12]);      /* mov ax, [eax+0x12] */
            ii(0x1007_7734, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1007_7737, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1007_773a, 5); calld(Definitions.my_ctor_0x101b_4184, -0xc4f); /* call 0x10076af0 */
            ii(0x1007_773f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_7742, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1007_7745, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_774a, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1007_774d, 2); if(jnzd(0x1007_7762, 0x13)) goto l_0x1007_7762; /* jnz 0x10077762 */
            ii(0x1007_774f, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
            ii(0x1007_7753, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_7755, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_7758, 5); calld(0x1007_5f6c, -0x17f1);            /* call 0x10075f6c */
            ii(0x1007_775d, 5); jmpd(0x1007_789b, 0x139); goto l_0x1007_789b; /* jmp 0x1007789b */
        l_0x1007_7762:
            ii(0x1007_7762, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_7765, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1007_7768, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_776d, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1007_7770, 3); cmp(memb_a32[ds, eax], 0);              /* cmp byte [eax], 0x0 */
            ii(0x1007_7773, 2); if(jnzd(0x1007_7788, 0x13)) goto l_0x1007_7788; /* jnz 0x10077788 */
            ii(0x1007_7775, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
            ii(0x1007_7779, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_777b, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_777e, 5); calld(0x1007_5f6c, -0x1817);            /* call 0x10075f6c */
            ii(0x1007_7783, 5); jmpd(0x1007_789b, 0x113); goto l_0x1007_789b; /* jmp 0x1007789b */
        l_0x1007_7788:
            ii(0x1007_7788, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_778b, 5); calld(0x1007_623c, -0x1554);            /* call 0x1007623c */
            ii(0x1007_7790, 4); cmp(memb_a32[ds, eax + 0x16], 0);       /* cmp byte [eax+0x16], 0x0 */
            ii(0x1007_7794, 2); if(jzd(0x1007_77a5, 0xf)) goto l_0x1007_77a5; /* jz 0x100777a5 */
            ii(0x1007_7796, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_7799, 5); calld(0x1007_623c, -0x1562);            /* call 0x1007623c */
            ii(0x1007_779e, 4); mov(ax, memw_a32[ds, eax + 0x10]);      /* mov ax, [eax+0x10] */
            ii(0x1007_77a2, 3); add(memd_a32[ss, ebp - 0x18], eax);     /* add [ebp-0x18], eax */
        l_0x1007_77a5:
            ii(0x1007_77a5, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_77a8, 5); calld(0x1007_623c, -0x1571);            /* call 0x1007623c */
            ii(0x1007_77ad, 4); mov(ax, memw_a32[ds, eax + 0x17]);      /* mov ax, [eax+0x17] */
            ii(0x1007_77b1, 4); cmp(ax, memw_a32[ss, ebp - 0x18]);      /* cmp ax, [ebp-0x18] */
            ii(0x1007_77b5, 2); if(jled(0x1007_77c6, 0xf)) goto l_0x1007_77c6; /* jle 0x100777c6 */
            ii(0x1007_77b7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_77ba, 5); calld(0x1007_623c, -0x1583);            /* call 0x1007623c */
            ii(0x1007_77bf, 4); mov(ax, memw_a32[ds, eax + 0x17]);      /* mov ax, [eax+0x17] */
            ii(0x1007_77c3, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
        l_0x1007_77c6:
            ii(0x1007_77c6, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1007_77c9, 4); imul(eax, memd_a32[ss, ebp - 0x18]);    /* imul eax, [ebp-0x18] */
            ii(0x1007_77cd, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1007_77d0, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1007_77d4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_77d6, 2); if(jnzd(0x1007_77eb, 0x13)) goto l_0x1007_77eb; /* jnz 0x100777eb */
            ii(0x1007_77d8, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
            ii(0x1007_77dc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_77de, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_77e1, 5); calld(0x1007_5f6c, -0x187a);            /* call 0x10075f6c */
            ii(0x1007_77e6, 5); jmpd(0x1007_789b, 0xb0); goto l_0x1007_789b; /* jmp 0x1007789b */
        l_0x1007_77eb:
            ii(0x1007_77eb, 2); jmpd(0x1007_77f5, 0x8); goto l_0x1007_77f5; /* jmp 0x100777f5 */
        l_0x1007_77ed:
            ii(0x1007_77ed, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_77f0, 5); calld(0x1007_6bf8, -0xbfd);             /* call 0x10076bf8 */
        l_0x1007_77f5:
            ii(0x1007_77f5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_77f7, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_77fa, 5); calld(0x1013_ad71, 0xc_3572);           /* call 0x1013ad71 */
            ii(0x1007_77ff, 2); test(al, al);                           /* test al, al */
            ii(0x1007_7801, 6); if(jzd(0x1007_7881, 0x7a)) goto l_0x1007_7881; /* jz 0x10077881 */
            ii(0x1007_7807, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_780a, 5); calld(0x1007_63a0, -0x146f);            /* call 0x100763a0 */
            ii(0x1007_780f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_7811, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1007_7814, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1007_7818, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_781a, 2); if(jnzd(0x1007_787c, 0x60)) goto l_0x1007_787c; /* jnz 0x1007787c */
            ii(0x1007_781c, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_781f, 5); calld(0x1007_63a0, -0x1484);            /* call 0x100763a0 */
            ii(0x1007_7824, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1007_7827, 4); mov(dx, memw_a32[ds, edx + 0x1a]);      /* mov dx, [edx+0x1a] */
            ii(0x1007_782b, 4); sub(dx, memw_a32[ds, eax + 0x1a]);      /* sub dx, [eax+0x1a] */
            ii(0x1007_782f, 4); mov(memw_a32[ss, ebp - 0x1c], dx);      /* mov [ebp-0x1c], dx */
            ii(0x1007_7833, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_7836, 5); calld(0x1007_63a0, -0x149b);            /* call 0x100763a0 */
            ii(0x1007_783b, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1007_783e, 4); mov(dx, memw_a32[ds, edx + 0x1c]);      /* mov dx, [edx+0x1c] */
            ii(0x1007_7842, 4); sub(dx, memw_a32[ds, eax + 0x1c]);      /* sub dx, [eax+0x1c] */
            ii(0x1007_7846, 4); mov(memw_a32[ss, ebp - 0x1a], dx);      /* mov [ebp-0x1a], dx */
            ii(0x1007_784a, 4); movsx(edx, memw_a32[ss, ebp - 0x1a]);   /* movsx edx, word [ebp-0x1a] */
            ii(0x1007_784e, 4); movsx(eax, memw_a32[ss, ebp - 0x1a]);   /* movsx eax, word [ebp-0x1a] */
            ii(0x1007_7852, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1007_7855, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1007_7857, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x1007_785b, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1007_785f, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1007_7862, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x1007_7864, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1007_7868, 2); cmp(ebx, eax);                          /* cmp ebx, eax */
            ii(0x1007_786a, 2); if(jgd(0x1007_787c, 0x10)) goto l_0x1007_787c; /* jg 0x1007787c */
            ii(0x1007_786c, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x1007_7870, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_7872, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_7875, 5); calld(0x1007_5f6c, -0x190e);            /* call 0x10075f6c */
            ii(0x1007_787a, 2); jmpd(0x1007_789b, 0x1f); goto l_0x1007_789b; /* jmp 0x1007789b */
        l_0x1007_787c:
            ii(0x1007_787c, 5); jmpd(0x1007_77ed, -0x94); goto l_0x1007_77ed; /* jmp 0x100777ed */
        l_0x1007_7881:
            ii(0x1007_7881, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
            ii(0x1007_7885, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_7887, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1007_788a, 5); calld(0x1007_5f6c, -0x1923);            /* call 0x10075f6c */
            ii(0x1007_788f, 2); jmpd(0x1007_789b, 0xa); goto l_0x1007_789b; /* jmp 0x1007789b */
        //  ii(0x1007_7891, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1007_7893, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
        //  ii(0x1007_7896, 5); calld(0x1007_5f6c, -0x192f);            /* call 0x10075f6c */
        l_0x1007_789b:
            ii(0x1007_789b, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x1007_789e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_78a0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_78a1, 1); popd(edi);                              /* pop edi */
            ii(0x1007_78a2, 1); popd(esi);                              /* pop esi */
            ii(0x1007_78a3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_78a4, 1); retd();                                 /* ret */
        }
    }
}
