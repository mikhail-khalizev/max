using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("23698019-0787-49e5-91aa-2e33f46e03ad")]
        public void Method_0016_01ed()
        {
            ii(0x16_01ed, 4); enterw(0x24, 0);                          /* enter 0x24, 0x0 */
            ii(0x16_01f1, 1); pushw(si);                                /* push si */
            ii(0x16_01f2, 1); pushw(ds);                                /* push ds */
            ii(0x16_01f3, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x16_01f6, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x16_01f8, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x16_01fb, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x16_01fe, 3); mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x16_0201, 3); mov(memw_a16[ss, bp - 0x14], dx);         /* mov [bp-0x14], dx */
            ii(0x16_0204, 3); les(bx, ss, bp + 0xa);                    /* les bx, [bp+0xa] */
            ii(0x16_0207, 3); mov(memw_a16[ss, bp - 0x12], bx);         /* mov [bp-0x12], bx */
            ii(0x16_020a, 3); mov(memw_a16[ss, bp - 0x10], es);         /* mov [bp-0x10], es */
            ii(0x16_020d, 4); cmp(memb_a16[es, bx], 0);                 /* cmp byte [es:bx], 0x0 */
            ii(0x16_0211, 2); if(jzw(0x16_0231, 0x1e)) goto l_0x16_0231; /* jz 0x231 */
            ii(0x16_0213, 5); cmp(memb_a16[es, bx + 0x1], 0x3a);        /* cmp byte [es:bx+0x1], 0x3a */
            ii(0x16_0218, 2); if(jnzw(0x16_0231, 0x17)) goto l_0x16_0231; /* jnz 0x231 */
            ii(0x16_021a, 3); mov(cl, memb_a16[es, bx]);                /* mov cl, [es:bx] */
            ii(0x16_021d, 2); mov(es, dx);                              /* mov es, dx */
            ii(0x16_021f, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x16_0221, 3); mov(memb_a16[es, bx], cl);                /* mov [es:bx], cl */
            ii(0x16_0224, 3); mov(ax, memw_a16[ss, bp - 0x12]);         /* mov ax, [bp-0x12] */
            ii(0x16_0227, 3); mov(dx, memw_a16[ss, bp - 0x10]);         /* mov dx, [bp-0x10] */
            ii(0x16_022a, 1); inc(ax);                                  /* inc ax */
            ii(0x16_022b, 1); inc(ax);                                  /* inc ax */
            ii(0x16_022c, 3); mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0x16_022f, 2); jmpw(0x16_0243, 0x12); goto l_0x16_0243;  /* jmp 0x243 */
        l_0x16_0231:
            ii(0x16_0231, 2); mov(ah, 0x19);                            /* mov ah, 0x19 */
            ii(0x16_0233, 2); @int(0x21);                               /* int 0x21 */
            ii(0x16_0235, 3); mov(memb_a16[ss, bp - 0xe], al);          /* mov [bp-0xe], al */
            ii(0x16_0238, 3); mov(al, memb_a16[ss, bp - 0xe]);          /* mov al, [bp-0xe] */
            ii(0x16_023b, 2); add(al, 0x41);                            /* add al, 0x41 */
            ii(0x16_023d, 3); les(bx, ss, bp - 0x16);                   /* les bx, [bp-0x16] */
            ii(0x16_0240, 3); mov(memb_a16[es, bx], al);                /* mov [es:bx], al */
        l_0x16_0243:
            ii(0x16_0243, 3); mov(al, memb_a16[es, bx]);                /* mov al, [es:bx] */
            ii(0x16_0246, 1); cbw();                                    /* cbw */
            ii(0x16_0247, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x16_0249, 3); mov(memw_a16[ss, bp - 0x1c], bx);         /* mov [bp-0x1c], bx */
            ii(0x16_024c, 5); test(memb_a16[ds, bx + 0x3e4d], 0x2);     /* test byte [bx+0x3e4d], 0x2 */
            ii(0x16_0251, 2); if(jzw(0x16_025a, 0x7)) goto l_0x16_025a; /* jz 0x25a */
            ii(0x16_0253, 3); mov(al, memb_a16[ss, bp - 0x1c]);         /* mov al, [bp-0x1c] */
            ii(0x16_0256, 2); sub(al, 0x20);                            /* sub al, 0x20 */
            ii(0x16_0258, 2); jmpw(0x16_0260, 0x6); goto l_0x16_0260;   /* jmp 0x260 */
        l_0x16_025a:
            ii(0x16_025a, 3); mov(bx, memw_a16[ss, bp - 0x16]);         /* mov bx, [bp-0x16] */
            ii(0x16_025d, 3); mov(al, memb_a16[es, bx]);                /* mov al, [es:bx] */
        l_0x16_0260:
            ii(0x16_0260, 2); sub(al, 0x40);                            /* sub al, 0x40 */
            ii(0x16_0262, 3); mov(memb_a16[ss, bp - 0x8], al);          /* mov [bp-0x8], al */
            ii(0x16_0265, 3); inc(memw_a16[ss, bp - 0x16]);             /* inc word [bp-0x16] */
            ii(0x16_0268, 3); mov(bx, memw_a16[ss, bp - 0x16]);         /* mov bx, [bp-0x16] */
            ii(0x16_026b, 4); mov(memb_a16[es, bx], 0x3a);              /* mov byte [es:bx], 0x3a */
            ii(0x16_026f, 3); lea(ax, bx + 0x1);                        /* lea ax, [bx+0x1] */
            ii(0x16_0272, 3); mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x16_0275, 3); les(bx, ss, bp - 0x12);                   /* les bx, [bp-0x12] */
            ii(0x16_0278, 4); cmp(memb_a16[es, bx], 0x5c);              /* cmp byte [es:bx], 0x5c */
            ii(0x16_027c, 2); if(jnzw(0x16_0281, 0x3)) goto l_0x16_0281; /* jnz 0x281 */
            ii(0x16_027e, 3); jmpw(0x16_0314, 0x93); goto l_0x16_0314;  /* jmp 0x314 */
        l_0x16_0281:
            ii(0x16_0281, 3); les(bx, ss, bp - 0x16);                   /* les bx, [bp-0x16] */
            ii(0x16_0284, 3); inc(memw_a16[ss, bp - 0x16]);             /* inc word [bp-0x16] */
            ii(0x16_0287, 4); mov(memb_a16[es, bx], 0x5c);              /* mov byte [es:bx], 0x5c */
            ii(0x16_028b, 1); pushw(ds);                                /* push ds */
            ii(0x16_028c, 3); mov(ax, memw_a16[ss, bp - 0x14]);         /* mov ax, [bp-0x14] */
            ii(0x16_028f, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x16_0291, 3); mov(si, memw_a16[ss, bp - 0x16]);         /* mov si, [bp-0x16] */
            ii(0x16_0294, 2); mov(ah, 0x47);                            /* mov ah, 0x47 */
            ii(0x16_0296, 3); mov(dl, memb_a16[ss, bp - 0x8]);          /* mov dl, [bp-0x8] */
            ii(0x16_0299, 2); @int(0x21);                               /* int 0x21 */
            ii(0x16_029b, 1); popw(ds);                                 /* pop ds */
            ii(0x16_029c, 3); pushw(memw_a16[ss, bp - 0x14]);           /* push word [bp-0x14] */
            ii(0x16_029f, 3); pushw(memw_a16[ss, bp - 0x16]);           /* push word [bp-0x16] */
            ii(0x16_02a2, 3); callw(0x15_ff2f, -0x376);                 /* call 0xff2f */
            ii(0x16_02a5, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x16_02a7, 2); if(jzw(0x16_0314, 0x6b)) goto l_0x16_0314; /* jz 0x314 */
            ii(0x16_02a9, 3); add(memw_a16[ss, bp - 0x16], ax);         /* add [bp-0x16], ax */
            ii(0x16_02ac, 3); les(bx, ss, bp - 0x16);                   /* les bx, [bp-0x16] */
            ii(0x16_02af, 4); mov(memb_a16[es, bx], 0x5c);              /* mov byte [es:bx], 0x5c */
            ii(0x16_02b3, 3); lea(ax, bx + 0x1);                        /* lea ax, [bx+0x1] */
            ii(0x16_02b6, 3); mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x16_02b9, 3); mov(memw_a16[ss, bp - 0x14], es);         /* mov [bp-0x14], es */
            ii(0x16_02bc, 2); jmpw(0x16_0314, 0x56); goto l_0x16_0314;  /* jmp 0x314 */
        l_0x16_02be:
            ii(0x16_02be, 3); mov(ax, memw_a16[ss, bp - 0x12]);         /* mov ax, [bp-0x12] */
            ii(0x16_02c1, 3); mov(dx, memw_a16[ss, bp - 0x10]);         /* mov dx, [bp-0x10] */
            ii(0x16_02c4, 3); mov(memw_a16[ss, bp - 0x24], ax);         /* mov [bp-0x24], ax */
            ii(0x16_02c7, 3); mov(memw_a16[ss, bp - 0x22], dx);         /* mov [bp-0x22], dx */
            ii(0x16_02ca, 3); inc(memw_a16[ss, bp - 0x12]);             /* inc word [bp-0x12] */
            ii(0x16_02cd, 3); les(bx, ss, bp - 0x24);                   /* les bx, [bp-0x24] */
            ii(0x16_02d0, 4); cmp(memb_a16[es, bx], 0x2e);              /* cmp byte [es:bx], 0x2e */
            ii(0x16_02d4, 2); if(jnzw(0x16_0314, 0x3e)) goto l_0x16_0314; /* jnz 0x314 */
            ii(0x16_02d6, 3); les(bx, ss, bp - 0x12);                   /* les bx, [bp-0x12] */
            ii(0x16_02d9, 4); cmp(memb_a16[es, bx], 0x5c);              /* cmp byte [es:bx], 0x5c */
            ii(0x16_02dd, 2); if(jnzw(0x16_02e7, 0x8)) goto l_0x16_02e7; /* jnz 0x2e7 */
            ii(0x16_02df, 3); inc(memw_a16[ss, bp - 0x12]);             /* inc word [bp-0x12] */
            ii(0x16_02e2, 3); dec(memw_a16[ss, bp - 0x16]);             /* dec word [bp-0x16] */
            ii(0x16_02e5, 2); jmpw(0x16_0314, 0x2d); goto l_0x16_0314;  /* jmp 0x314 */
        l_0x16_02e7:
            ii(0x16_02e7, 4); cmp(memb_a16[es, bx], 0x2e);              /* cmp byte [es:bx], 0x2e */
            ii(0x16_02eb, 2); if(jnzw(0x16_0314, 0x27)) goto l_0x16_0314; /* jnz 0x314 */
            ii(0x16_02ed, 3); inc(memw_a16[ss, bp - 0x12]);             /* inc word [bp-0x12] */
            ii(0x16_02f0, 3); mov(bx, memw_a16[ss, bp - 0x12]);         /* mov bx, [bp-0x12] */
            ii(0x16_02f3, 4); cmp(memb_a16[es, bx], 0x5c);              /* cmp byte [es:bx], 0x5c */
            ii(0x16_02f7, 2); if(jnzw(0x16_0314, 0x1b)) goto l_0x16_0314; /* jnz 0x314 */
            ii(0x16_02f9, 4); sub(memw_a16[ss, bp - 0x16], 0x3);        /* sub word [bp-0x16], 0x3 */
            ii(0x16_02fd, 2); jmpw(0x16_0308, 0x9); goto l_0x16_0308;   /* jmp 0x308 */
        l_0x16_02ff:
            ii(0x16_02ff, 3); cmp(bx, memw_a16[ss, bp + 0x6]);          /* cmp bx, [bp+0x6] */
            ii(0x16_0302, 2); if(jaw(0x16_0308, 0x4)) goto l_0x16_0308; /* ja 0x308 */
            ii(0x16_0304, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x16_0306, 2); jmpw(0x16_032a, 0x22); goto l_0x16_032a;  /* jmp 0x32a */
        l_0x16_0308:
            ii(0x16_0308, 3); dec(memw_a16[ss, bp - 0x16]);             /* dec word [bp-0x16] */
            ii(0x16_030b, 3); les(bx, ss, bp - 0x16);                   /* les bx, [bp-0x16] */
            ii(0x16_030e, 4); cmp(memb_a16[es, bx], 0x5c);              /* cmp byte [es:bx], 0x5c */
            ii(0x16_0312, 2); if(jnzw(0x16_02ff, -0x15)) goto l_0x16_02ff; /* jnz 0x2ff */
        l_0x16_0314:
            ii(0x16_0314, 3); les(bx, ss, bp - 0x12);                   /* les bx, [bp-0x12] */
            ii(0x16_0317, 3); mov(al, memb_a16[es, bx]);                /* mov al, [es:bx] */
            ii(0x16_031a, 3); les(si, ss, bp - 0x16);                   /* les si, [bp-0x16] */
            ii(0x16_031d, 3); inc(memw_a16[ss, bp - 0x16]);             /* inc word [bp-0x16] */
            ii(0x16_0320, 3); mov(memb_a16[es, si], al);                /* mov [es:si], al */
            ii(0x16_0323, 2); or(al, al);                               /* or al, al */
            ii(0x16_0325, 2); if(jnzw(0x16_02be, -0x69)) goto l_0x16_02be; /* jnz 0x2be */
            ii(0x16_0327, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
        l_0x16_032a:
            ii(0x16_032a, 1); popw(ds);                                 /* pop ds */
            ii(0x16_032b, 1); popw(si);                                 /* pop si */
            ii(0x16_032c, 1); leavew();                                 /* leave */
            ii(0x16_032d, 3); retfw(0x8); return;                       /* retf 0x8 */
        }
    }
}
