using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_57c7-7379582d")]
        public void Method_1007_57c7()
        {
            ii(0x1007_57c7, 5); push(0x28);                             /* push 0x28 */
            ii(0x1007_57cc, 5); call(Definitions.sys_check_available_stack_size, 0xf_0581); /* call 0x10165d52 */
            ii(0x1007_57d1, 1); push(ebx);                              /* push ebx */
            ii(0x1007_57d2, 1); push(ecx);                              /* push ecx */
            ii(0x1007_57d3, 1); push(edx);                              /* push edx */
            ii(0x1007_57d4, 1); push(esi);                              /* push esi */
            ii(0x1007_57d5, 1); push(edi);                              /* push edi */
            ii(0x1007_57d6, 1); push(ebp);                              /* push ebp */
            ii(0x1007_57d7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_57d9, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_57df, 7); mov(memd[ss, ebp - 4], 5);              /* mov dword [ebp-0x4], 0x5 */
        l_0x1007_57e6:
            ii(0x1007_57e6, 3); dec(memd[ss, ebp - 4]);                 /* dec dword [ebp-0x4] */
            ii(0x1007_57e9, 5); cmp(memw[ss, ebp - 4], -1 /* 0xff */);  /* cmp word [ebp-0x4], 0xffff */
            ii(0x1007_57ee, 6); if(jz(0x1007_5a1d, 0x229)) goto l_0x1007_5a1d; /* jz 0x10075a1d */
            ii(0x1007_57f4, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1007_57f8, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1007_57fb, 6); mov(eax, memd[ds, eax + 0x101b_77a0]);  /* mov eax, [eax+0x101b77a0] */
            ii(0x1007_5801, 5); call(0x1007_6338, 0xb32);               /* call 0x10076338 */
            ii(0x1007_5806, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_5808, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1007_580b, 5); call(0x1007_64b8, 0xca8);               /* call 0x100764b8 */
        l_0x1007_5810:
            ii(0x1007_5810, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_5812, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1007_5815, 5); call(0x1013_ad71, 0xc_5557);            /* call 0x1013ad71 */
            ii(0x1007_581a, 2); test(al, al);                           /* test al, al */
            ii(0x1007_581c, 6); if(jz(0x1007_5a0e, 0x1ec)) goto l_0x1007_5a0e; /* jz 0x10075a0e */
            ii(0x1007_5822, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1007_5825, 5); call(0x1007_63a0, 0xb76);               /* call 0x100763a0 */
            ii(0x1007_582a, 4); cmp(memb[ds, eax + 61], 3);             /* cmp byte [eax+0x3d], 0x3 */
            ii(0x1007_582e, 2); if(jz(0x1007_583e, 0xe)) goto l_0x1007_583e; /* jz 0x1007583e */
            ii(0x1007_5830, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1007_5833, 5); call(0x1007_63a0, 0xb68);               /* call 0x100763a0 */
            ii(0x1007_5838, 4); cmp(memb[ds, eax + 61], 9);             /* cmp byte [eax+0x3d], 0x9 */
            ii(0x1007_583c, 2); if(jnz(0x1007_5840, 2)) goto l_0x1007_5840; /* jnz 0x10075840 */
        l_0x1007_583e:
            ii(0x1007_583e, 2); jmp(0x1007_584e, 0xe); goto l_0x1007_584e; /* jmp 0x1007584e */
        l_0x1007_5840:
            ii(0x1007_5840, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1007_5843, 5); call(0x1007_63a0, 0xb58);               /* call 0x100763a0 */
            ii(0x1007_5848, 4); cmp(memb[ds, eax + 61], 5);             /* cmp byte [eax+0x3d], 0x5 */
            ii(0x1007_584c, 2); if(jnz(0x1007_5850, 2)) goto l_0x1007_5850; /* jnz 0x10075850 */
        l_0x1007_584e:
            ii(0x1007_584e, 2); jmp(0x1007_585e, 0xe); goto l_0x1007_585e; /* jmp 0x1007585e */
        l_0x1007_5850:
            ii(0x1007_5850, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1007_5853, 5); call(0x1007_63a0, 0xb48);               /* call 0x100763a0 */
            ii(0x1007_5858, 4); cmp(memb[ds, eax + 61], 0x17);          /* cmp byte [eax+0x3d], 0x17 */
            ii(0x1007_585c, 2); if(jnz(0x1007_5860, 2)) goto l_0x1007_5860; /* jnz 0x10075860 */
        l_0x1007_585e:
            ii(0x1007_585e, 2); jmp(0x1007_586e, 0xe); goto l_0x1007_586e; /* jmp 0x1007586e */
        l_0x1007_5860:
            ii(0x1007_5860, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1007_5863, 5); call(0x1007_63a0, 0xb38);               /* call 0x100763a0 */
            ii(0x1007_5868, 4); cmp(memb[ds, eax + 61], 0x19);          /* cmp byte [eax+0x3d], 0x19 */
            ii(0x1007_586c, 2); if(jnz(0x1007_5870, 2)) goto l_0x1007_5870; /* jnz 0x10075870 */
        l_0x1007_586e:
            ii(0x1007_586e, 2); jmp(0x1007_587e, 0xe); goto l_0x1007_587e; /* jmp 0x1007587e */
        l_0x1007_5870:
            ii(0x1007_5870, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1007_5873, 5); call(0x1007_63a0, 0xb28);               /* call 0x100763a0 */
            ii(0x1007_5878, 4); cmp(memb[ds, eax + 61], 0x18);          /* cmp byte [eax+0x3d], 0x18 */
            ii(0x1007_587c, 2); if(jnz(0x1007_5880, 2)) goto l_0x1007_5880; /* jnz 0x10075880 */
        l_0x1007_587e:
            ii(0x1007_587e, 2); jmp(0x1007_588e, 0xe); goto l_0x1007_588e; /* jmp 0x1007588e */
        l_0x1007_5880:
            ii(0x1007_5880, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1007_5883, 5); call(0x1007_63a0, 0xb18);               /* call 0x100763a0 */
            ii(0x1007_5888, 4); cmp(memb[ds, eax + 61], 0x16);          /* cmp byte [eax+0x3d], 0x16 */
            ii(0x1007_588c, 2); if(jnz(0x1007_5890, 2)) goto l_0x1007_5890; /* jnz 0x10075890 */
        l_0x1007_588e:
            ii(0x1007_588e, 2); jmp(0x1007_589e, 0xe); goto l_0x1007_589e; /* jmp 0x1007589e */
        l_0x1007_5890:
            ii(0x1007_5890, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1007_5893, 5); call(0x1007_63a0, 0xb08);               /* call 0x100763a0 */
            ii(0x1007_5898, 4); cmp(memb[ds, eax + 62], 0xe);           /* cmp byte [eax+0x3e], 0xe */
            ii(0x1007_589c, 2); if(jnz(0x1007_58a0, 2)) goto l_0x1007_58a0; /* jnz 0x100758a0 */
        l_0x1007_589e:
            ii(0x1007_589e, 2); jmp(0x1007_58be, 0x1e); goto l_0x1007_58be; /* jmp 0x100758be */
        l_0x1007_58a0:
            ii(0x1007_58a0, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1007_58a3, 5); call(0x1007_63a0, 0xaf8);               /* call 0x100763a0 */
            ii(0x1007_58a8, 4); cmp(memb[ds, eax + 61], 2);             /* cmp byte [eax+0x3d], 0x2 */
            ii(0x1007_58ac, 2); if(jnz(0x1007_58bc, 0xe)) goto l_0x1007_58bc; /* jnz 0x100758bc */
            ii(0x1007_58ae, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1007_58b1, 5); call(0x1007_63a0, 0xaea);               /* call 0x100763a0 */
            ii(0x1007_58b6, 4); cmp(memb[ds, eax + 62], 1);             /* cmp byte [eax+0x3e], 0x1 */
            ii(0x1007_58ba, 2); if(jnz(0x1007_58be, 2)) goto l_0x1007_58be; /* jnz 0x100758be */
        l_0x1007_58bc:
            ii(0x1007_58bc, 2); jmp(0x1007_58c0, 2); goto l_0x1007_58c0; /* jmp 0x100758c0 */
        l_0x1007_58be:
            ii(0x1007_58be, 2); jmp(0x1007_58de, 0x1e); goto l_0x1007_58de; /* jmp 0x100758de */
        l_0x1007_58c0:
            ii(0x1007_58c0, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1007_58c3, 5); call(0x1007_63a0, 0xad8);               /* call 0x100763a0 */
            ii(0x1007_58c8, 4); cmp(memb[ds, eax + 61], 0x1b);          /* cmp byte [eax+0x3d], 0x1b */
            ii(0x1007_58cc, 2); if(jnz(0x1007_58dc, 0xe)) goto l_0x1007_58dc; /* jnz 0x100758dc */
            ii(0x1007_58ce, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1007_58d1, 5); call(0x1007_63a0, 0xaca);               /* call 0x100763a0 */
            ii(0x1007_58d6, 4); cmp(memb[ds, eax + 62], 1);             /* cmp byte [eax+0x3e], 0x1 */
            ii(0x1007_58da, 2); if(jnz(0x1007_58de, 2)) goto l_0x1007_58de; /* jnz 0x100758de */
        l_0x1007_58dc:
            ii(0x1007_58dc, 2); jmp(0x1007_58e0, 2); goto l_0x1007_58e0; /* jmp 0x100758e0 */
        l_0x1007_58de:
            ii(0x1007_58de, 2); jmp(0x1007_58fe, 0x1e); goto l_0x1007_58fe; /* jmp 0x100758fe */
        l_0x1007_58e0:
            ii(0x1007_58e0, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1007_58e3, 5); call(0x1007_63a0, 0xab8);               /* call 0x100763a0 */
            ii(0x1007_58e8, 4); cmp(memb[ds, eax + 61], 0x1e);          /* cmp byte [eax+0x3d], 0x1e */
            ii(0x1007_58ec, 2); if(jnz(0x1007_58fc, 0xe)) goto l_0x1007_58fc; /* jnz 0x100758fc */
            ii(0x1007_58ee, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1007_58f1, 5); call(0x1007_63a0, 0xaaa);               /* call 0x100763a0 */
            ii(0x1007_58f6, 4); cmp(memb[ds, eax + 62], 1);             /* cmp byte [eax+0x3e], 0x1 */
            ii(0x1007_58fa, 2); if(jnz(0x1007_58fe, 2)) goto l_0x1007_58fe; /* jnz 0x100758fe */
        l_0x1007_58fc:
            ii(0x1007_58fc, 2); jmp(0x1007_5900, 2); goto l_0x1007_5900; /* jmp 0x10075900 */
        l_0x1007_58fe:
            ii(0x1007_58fe, 2); jmp(0x1007_5912, 0x12); goto l_0x1007_5912; /* jmp 0x10075912 */
        l_0x1007_5900:
            ii(0x1007_5900, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1007_5903, 5); call(0x1007_63a0, 0xa98);               /* call 0x100763a0 */
            ii(0x1007_5908, 4); cmp(memb[ds, eax + 62], 0);             /* cmp byte [eax+0x3e], 0x0 */
            ii(0x1007_590c, 6); if(jnz(0x1007_5a01, 0xef)) goto l_0x1007_5a01; /* jnz 0x10075a01 */
        l_0x1007_5912:
            ii(0x1007_5912, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1007_5915, 5); call(0x1007_63a0, 0xa86);               /* call 0x100763a0 */
            ii(0x1007_591a, 4); cmp(memb[ds, eax + 62], 0x2a);          /* cmp byte [eax+0x3e], 0x2a */
            ii(0x1007_591e, 2); if(jnz(0x1007_5938, 0x18)) goto l_0x1007_5938; /* jnz 0x10075938 */
            ii(0x1007_5920, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1007_5923, 5); call(0x1007_63a0, 0xa78);               /* call 0x100763a0 */
            ii(0x1007_5928, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_592a, 3); mov(dl, memb[ds, eax + 38]);            /* mov dl, [eax+0x26] */
            ii(0x1007_592d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_592f, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x1007_5934, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_5936, 2); if(jz(0x1007_593d, 5)) goto l_0x1007_593d; /* jz 0x1007593d */
        l_0x1007_5938:
            ii(0x1007_5938, 5); jmp(0x1007_59eb, 0xae); goto l_0x1007_59eb; /* jmp 0x100759eb */
        l_0x1007_593d:
            ii(0x1007_593d, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1007_5940, 5); call(0x1007_63d4, 0xa8f);               /* call 0x100763d4 */
            ii(0x1007_5945, 5); call(0x1011_fc7b, 0xa_a331);            /* call 0x1011fc7b */
            ii(0x1007_594a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_594c, 6); if(jnz(0x1007_59eb, 0x99)) goto l_0x1007_59eb; /* jnz 0x100759eb */
            ii(0x1007_5952, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_5954, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1007_5957, 5); call(0x1007_63a0, 0xa44);               /* call 0x100763a0 */
            ii(0x1007_595c, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1007_595f, 5); call(0x1013_ad71, 0xc_540d);            /* call 0x1013ad71 */
            ii(0x1007_5964, 2); test(al, al);                           /* test al, al */
            ii(0x1007_5966, 2); if(jz(0x1007_59ac, 0x44)) goto l_0x1007_59ac; /* jz 0x100759ac */
            ii(0x1007_5968, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1007_596b, 5); call(0x1007_63a0, 0xa30);               /* call 0x100763a0 */
            ii(0x1007_5970, 5); call(0x1007_6188, 0x813);               /* call 0x10076188 */
            ii(0x1007_5975, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_5977, 2); if(jz(0x1007_5988, 0xf)) goto l_0x1007_5988; /* jz 0x10075988 */
            ii(0x1007_5979, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1007_597c, 5); call(0x1007_63d4, 0xa53);               /* call 0x100763d4 */
            ii(0x1007_5981, 5); call(0x1007_5a79, 0xf3);                /* call 0x10075a79 */
            ii(0x1007_5986, 2); jmp(0x1007_59aa, 0x22); goto l_0x1007_59aa; /* jmp 0x100759aa */
        l_0x1007_5988:
            ii(0x1007_5988, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1007_598b, 5); call(0x1007_63a0, 0xa10);               /* call 0x100763a0 */
            ii(0x1007_5990, 4); mov(memb[ds, eax + 62], 7);             /* mov byte [eax+0x3e], 0x7 */
            ii(0x1007_5994, 7); cmp(memd[ds, 0x101c_5624], 0);          /* cmp dword [0x101c5624], 0x0 */
            ii(0x1007_599b, 2); if(jz(0x1007_59aa, 0xd)) goto l_0x1007_59aa; /* jz 0x100759aa */
            ii(0x1007_599d, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1007_59a0, 5); call(0x1007_63d4, 0xa2f);               /* call 0x100763d4 */
            ii(0x1007_59a5, 5); call(0x1012_88e9, 0xb_2f3f);            /* call 0x101288e9 */
        l_0x1007_59aa:
            ii(0x1007_59aa, 2); jmp(0x1007_59eb, 0x3f); goto l_0x1007_59eb; /* jmp 0x100759eb */
        l_0x1007_59ac:
            ii(0x1007_59ac, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1007_59af, 5); call(0x1007_63a0, 0x9ec);               /* call 0x100763a0 */
            ii(0x1007_59b4, 4); test(memb[ds, eax + 18], 0x40);         /* test byte [eax+0x12], 0x40 */
            ii(0x1007_59b8, 2); if(jz(0x1007_59c8, 0xe)) goto l_0x1007_59c8; /* jz 0x100759c8 */
            ii(0x1007_59ba, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1007_59bd, 5); call(0x1007_63a0, 0x9de);               /* call 0x100763a0 */
            ii(0x1007_59c2, 4); cmp(memb[ds, eax + 61], 0x1e);          /* cmp byte [eax+0x3d], 0x1e */
            ii(0x1007_59c6, 2); if(jnz(0x1007_59ca, 2)) goto l_0x1007_59ca; /* jnz 0x100759ca */
        l_0x1007_59c8:
            ii(0x1007_59c8, 2); jmp(0x1007_59d9, 0xf); goto l_0x1007_59d9; /* jmp 0x100759d9 */
        l_0x1007_59ca:
            ii(0x1007_59ca, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1007_59cd, 5); call(0x1007_63d4, 0xa02);               /* call 0x100763d4 */
            ii(0x1007_59d2, 5); call(0x1007_5745, -0x292);              /* call 0x10075745 */
            ii(0x1007_59d7, 2); jmp(0x1007_59eb, 0x12); goto l_0x1007_59eb; /* jmp 0x100759eb */
        l_0x1007_59d9:
            ii(0x1007_59d9, 5); mov(edx, 2);                            /* mov edx, 0x2 */
            ii(0x1007_59de, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1007_59e1, 5); call(0x1007_63d4, 0x9ee);               /* call 0x100763d4 */
            ii(0x1007_59e6, 5); call(0x1011_b7de, 0xa_5df3);            /* call 0x1011b7de */
        l_0x1007_59eb:
            ii(0x1007_59eb, 7); mov(memd[ss, ebp - 8], 1);              /* mov dword [ebp-0x8], 0x1 */
            ii(0x1007_59f2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_59f4, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1007_59f7, 5); call(0x1007_5f6c, 0x570);               /* call 0x10075f6c */
            ii(0x1007_59fc, 5); jmp(0x1007_5a6d, 0x6c); goto l_0x1007_5a6d; /* jmp 0x10075a6d */
        l_0x1007_5a01:
            ii(0x1007_5a01, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1007_5a04, 5); call(0x1007_6bf8, 0x11ef);              /* call 0x10076bf8 */
            ii(0x1007_5a09, 5); jmp(0x1007_5810, -0x1fe); goto l_0x1007_5810; /* jmp 0x10075810 */
        l_0x1007_5a0e:
            ii(0x1007_5a0e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_5a10, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1007_5a13, 5); call(0x1007_5f6c, 0x554);               /* call 0x10075f6c */
            ii(0x1007_5a18, 5); jmp(0x1007_57e6, -0x237); goto l_0x1007_57e6; /* jmp 0x100757e6 */
        l_0x1007_5a1d:
            ii(0x1007_5a1d, 7); mov(memd[ss, ebp - 4], 0);              /* mov dword [ebp-0x4], 0x0 */
            ii(0x1007_5a24, 2); jmp(0x1007_5a2c, 6); goto l_0x1007_5a2c; /* jmp 0x10075a2c */
        l_0x1007_5a26:
            ii(0x1007_5a26, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_5a29, 3); inc(memd[ss, ebp - 4]);                 /* inc dword [ebp-0x4] */
        l_0x1007_5a2c:
            ii(0x1007_5a2c, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1007_5a30, 3); cmp(eax, 5);                            /* cmp eax, 0x5 */
            ii(0x1007_5a33, 2); if(jge(0x1007_5a58, 0x23)) goto l_0x1007_5a58; /* jge 0x10075a58 */
            ii(0x1007_5a35, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1007_5a39, 3); imul(edx, eax, 0xa);                    /* imul edx, eax, 0xa */
            ii(0x1007_5a3c, 5); mov(eax, 0x101c_9480);                  /* mov eax, 0x101c9480 */
            ii(0x1007_5a41, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_5a43, 5); call(0x1007_6b90, 0x1148);              /* call 0x10076b90 */
            ii(0x1007_5a48, 1); cwde();                                 /* cwde */
            ii(0x1007_5a49, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_5a4b, 2); if(jle(0x1007_5a56, 9)) goto l_0x1007_5a56; /* jle 0x10075a56 */
            ii(0x1007_5a4d, 7); mov(memd[ss, ebp - 8], 1);              /* mov dword [ebp-0x8], 0x1 */
            ii(0x1007_5a54, 2); jmp(0x1007_5a6d, 0x17); goto l_0x1007_5a6d; /* jmp 0x10075a6d */
        l_0x1007_5a56:
            ii(0x1007_5a56, 2); jmp(0x1007_5a26, -0x32); goto l_0x1007_5a26; /* jmp 0x10075a26 */
        l_0x1007_5a58:
            ii(0x1007_5a58, 7); cmp(memd[ds, 0x101c_5624], 0);          /* cmp dword [0x101c5624], 0x0 */
            ii(0x1007_5a5f, 2); if(jz(0x1007_5a66, 5)) goto l_0x1007_5a66; /* jz 0x10075a66 */
            ii(0x1007_5a61, 5); call(0x1012_989e, 0xb_3e38);            /* call 0x1012989e */
        l_0x1007_5a66:
            ii(0x1007_5a66, 7); mov(memd[ss, ebp - 8], 0);              /* mov dword [ebp-0x8], 0x0 */
        l_0x1007_5a6d:
            ii(0x1007_5a6d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_5a70, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_5a72, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_5a73, 1); pop(edi);                               /* pop edi */
            ii(0x1007_5a74, 1); pop(esi);                               /* pop esi */
            ii(0x1007_5a75, 1); pop(edx);                               /* pop edx */
            ii(0x1007_5a76, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_5a77, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_5a78, 1); ret();                                  /* ret */
        }
    }
}
