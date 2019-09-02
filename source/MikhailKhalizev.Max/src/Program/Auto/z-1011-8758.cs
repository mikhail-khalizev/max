using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_8758-82dd2e9c")]
        public void Method_1011_8758()
        {
            ii(0x1011_8758, 5); push(0x30);                             /* push 0x30 */
            ii(0x1011_875d, 5); call(Definitions.sys_check_available_stack_size, 0x4_d5f0); /* call 0x10165d52 */
            ii(0x1011_8762, 1); push(ebx);                              /* push ebx */
            ii(0x1011_8763, 1); push(ecx);                              /* push ecx */
            ii(0x1011_8764, 1); push(edx);                              /* push edx */
            ii(0x1011_8765, 1); push(esi);                              /* push esi */
            ii(0x1011_8766, 1); push(edi);                              /* push edi */
            ii(0x1011_8767, 1); push(ebp);                              /* push ebp */
            ii(0x1011_8768, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_876a, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1011_8770, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1011_8773, 7); mov(memb[ds, 0x101c_391b], 1);          /* mov byte [0x101c391b], 0x1 */
            ii(0x1011_877a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_877d, 4); mov(ax, memw[ds, eax + 26]);            /* mov ax, [eax+0x1a] */
            ii(0x1011_8781, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1011_8784, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_8787, 4); mov(ax, memw[ds, eax + 28]);            /* mov ax, [eax+0x1c] */
            ii(0x1011_878b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1011_878e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_8791, 4); test(memb[ds, eax + 18], 0x20);         /* test byte [eax+0x12], 0x20 */
            ii(0x1011_8795, 2); if(jz(0x1011_87d7, 0x40)) goto l_0x1011_87d7; /* jz 0x101187d7 */
            ii(0x1011_8797, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_879a, 5); call(0x1007_611c, -0xa_2683);           /* call 0x1007611c */
            ii(0x1011_879f, 3); lea(ebx, memd[ss, ebp - 16]);           /* lea ebx, [ebp-0x10] */
            ii(0x1011_87a2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_87a4, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1011_87a6, 5); call(0x1007_66ac, -0xa_20ff);           /* call 0x100766ac */
            ii(0x1011_87ab, 4); movsx(ebx, memw[ss, ebp - 8]);          /* movsx ebx, word [ebp-0x8] */
            ii(0x1011_87af, 4); movsx(edx, memw[ss, ebp - 12]);         /* movsx edx, word [ebp-0xc] */
            ii(0x1011_87b3, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1011_87b6, 5); call(0x1007_6574, -0xa_2247);           /* call 0x10076574 */
            ii(0x1011_87bb, 5); call(0x1014_eb48, 0x3_6388);            /* call 0x1014eb48 */
            ii(0x1011_87c0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_87c3, 5); call(0x1015_f2cc, 0x4_6b04);            /* call 0x1015f2cc */
            ii(0x1011_87c8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_87ca, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1011_87cd, 5); call(0x1007_5f2c, -0xa_28a6);           /* call 0x10075f2c */
            ii(0x1011_87d2, 5); jmp(0x1011_8904, 0x12d); goto l_0x1011_8904; /* jmp 0x10118904 */
        l_0x1011_87d7:
            ii(0x1011_87d7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_87da, 5); call(0x1015_48ba, 0x3_c0db);            /* call 0x101548ba */
            ii(0x1011_87df, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_87e2, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1011_87e5, 5); call(0x1007_69d8, -0xa_1e12);           /* call 0x100769d8 */
            ii(0x1011_87ea, 5); call(0x1012_0c30, 0x8441);              /* call 0x10120c30 */
            ii(0x1011_87ef, 4); cmp(ax, memw[ss, ebp - 12]);            /* cmp ax, [ebp-0xc] */
            ii(0x1011_87f3, 2); if(jnz(0x1011_880b, 0x16)) goto l_0x1011_880b; /* jnz 0x1011880b */
            ii(0x1011_87f5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_87f8, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1011_87fb, 5); call(0x1007_69d8, -0xa_1e28);           /* call 0x100769d8 */
            ii(0x1011_8800, 5); call(0x1012_0bfc, 0x83f7);              /* call 0x10120bfc */
            ii(0x1011_8805, 4); cmp(ax, memw[ss, ebp - 8]);             /* cmp ax, [ebp-0x8] */
            ii(0x1011_8809, 2); if(jz(0x1011_883f, 0x34)) goto l_0x1011_883f; /* jz 0x1011883f */
        l_0x1011_880b:
            ii(0x1011_880b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_880e, 4); mov(memb[ds, eax + 62], 1);             /* mov byte [eax+0x3e], 0x1 */
            ii(0x1011_8812, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_8815, 5); call(0x1011_9138, 0x91e);               /* call 0x10119138 */
            ii(0x1011_881a, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1011_881d, 3); add(ebx, 0x65);                         /* add ebx, 0x65 */
            ii(0x1011_8820, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_8822, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1011_8824, 5); call(0x1007_6a34, -0xa_1df5);           /* call 0x10076a34 */
            ii(0x1011_8829, 5); call(0x1012_0ab0, 0x8282);              /* call 0x10120ab0 */
            ii(0x1011_882e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_8830, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1011_8832, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_8835, 5); call(0x1014_eea8, 0x3_666e);            /* call 0x1014eea8 */
            ii(0x1011_883a, 5); jmp(0x1011_8904, 0xc5); goto l_0x1011_8904; /* jmp 0x10118904 */
        l_0x1011_883f:
            ii(0x1011_883f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_8841, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_8844, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1011_8847, 5); call(0x1013_ad71, 0x2_2525);            /* call 0x1013ad71 */
            ii(0x1011_884c, 2); test(al, al);                           /* test al, al */
            ii(0x1011_884e, 2); if(jz(0x1011_886f, 0x1f)) goto l_0x1011_886f; /* jz 0x1011886f */
            ii(0x1011_8850, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1011_8853, 5); call(0x1012_0d24, 0x84cc);              /* call 0x10120d24 */
            ii(0x1011_8858, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_885a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_885d, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1011_8860, 5); call(0x1012_0c64, 0x83ff);              /* call 0x10120c64 */
            ii(0x1011_8865, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_8867, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1011_886a, 5); call(0x1012_030c, 0x7a9d);              /* call 0x1012030c */
        l_0x1011_886f:
            ii(0x1011_886f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_8872, 5); call(0x1011_85f1, -0x286);              /* call 0x101185f1 */
            ii(0x1011_8877, 2); test(al, al);                           /* test al, al */
            ii(0x1011_8879, 6); if(jnz(0x1011_8904, 0x85)) goto l_0x1011_8904; /* jnz 0x10118904 */
            ii(0x1011_887f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_8882, 5); cmp(memw[ds, eax + 8], 0x4e);           /* cmp word [eax+0x8], 0x4e */
            ii(0x1011_8887, 2); if(jnz(0x1011_8895, 0xc)) goto l_0x1011_8895; /* jnz 0x10118895 */
            ii(0x1011_8889, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_888c, 5); call(0x1007_611c, -0xa_2775);           /* call 0x1007611c */
            ii(0x1011_8891, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_8893, 2); if(jnz(0x1011_8897, 2)) goto l_0x1011_8897; /* jnz 0x10118897 */
        l_0x1011_8895:
            ii(0x1011_8895, 2); jmp(0x1011_88f3, 0x5c); goto l_0x1011_88f3; /* jmp 0x101188f3 */
        l_0x1011_8897:
            ii(0x1011_8897, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_889a, 5); call(0x1007_623c, -0xa_2663);           /* call 0x1007623c */
            ii(0x1011_889f, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1011_88a2, 4); mov(dx, memw[ds, edx + 82]);            /* mov dx, [edx+0x52] */
            ii(0x1011_88a6, 4); cmp(dx, memw[ds, eax + 25]);            /* cmp dx, [eax+0x19] */
            ii(0x1011_88aa, 2); if(jl(0x1011_88b8, 0xc)) goto l_0x1011_88b8; /* jl 0x101188b8 */
            ii(0x1011_88ac, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_88ae, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_88b1, 5); call(0x1008_a998, -0x8_df1e);           /* call 0x1008a998 */
            ii(0x1011_88b6, 2); jmp(0x1011_88f3, 0x3b); goto l_0x1011_88f3; /* jmp 0x101188f3 */
        l_0x1011_88b8:
            ii(0x1011_88b8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_88bb, 5); call(0x1007_611c, -0xa_27a4);           /* call 0x1007611c */
            ii(0x1011_88c0, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1011_88c2, 5); mov(ecx, 0x100);                        /* mov ecx, 0x100 */
            ii(0x1011_88c7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_88ca, 3); mov(al, memb[ds, eax + 38]);            /* mov al, [eax+0x26] */
            ii(0x1011_88cd, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1011_88cf, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1011_88d2, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x1011_88d6, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x1011_88da, 5); call(0x1007_388b, -0xa_5054);           /* call 0x1007388b */
            ii(0x1011_88df, 2); cmp(esi, eax);                          /* cmp esi, eax */
            ii(0x1011_88e1, 2); if(jnz(0x1011_88f3, 0x10)) goto l_0x1011_88f3; /* jnz 0x101188f3 */
            ii(0x1011_88e3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_88e6, 4); mov(memb[ds, eax + 61], 0xf);           /* mov byte [eax+0x3d], 0xf */
            ii(0x1011_88ea, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_88ed, 4); mov(memb[ds, eax + 62], 0);             /* mov byte [eax+0x3e], 0x0 */
            ii(0x1011_88f1, 2); jmp(0x1011_8904, 0x11); goto l_0x1011_8904; /* jmp 0x10118904 */
        l_0x1011_88f3:
            ii(0x1011_88f3, 5); call(0x1012_0a90, 0x8198);              /* call 0x10120a90 */
            ii(0x1011_88f8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_88fa, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1011_88fc, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_88ff, 5); call(0x1014_f017, 0x3_6713);            /* call 0x1014f017 */
        l_0x1011_8904:
            ii(0x1011_8904, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_8906, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_8907, 1); pop(edi);                               /* pop edi */
            ii(0x1011_8908, 1); pop(esi);                               /* pop esi */
            ii(0x1011_8909, 1); pop(edx);                               /* pop edx */
            ii(0x1011_890a, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_890b, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_890c, 1); ret();                                  /* ret */
        }
    }
}
