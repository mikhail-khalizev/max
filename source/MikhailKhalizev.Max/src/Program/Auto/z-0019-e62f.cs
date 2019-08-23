using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_e62f-3421403b")]
        public void Method_0019_e62f()
        {
            ii(0x19_e62f, 4); enterw(0x80, 0);                          /* enter 0x80, 0x0 */
            ii(0x19_e633, 1); pushw(di);                                /* push di */
            ii(0x19_e634, 1); pushw(si);                                /* push si */
            ii(0x19_e635, 4); mov(es, memw_a16[ds, 0x3fd0]);            /* mov es, [0x3fd0] */
            ii(0x19_e639, 6); cmp(memb_a16[es, 0x3c1a], 0x3);           /* cmp byte [es:0x3c1a], 0x3 */
            ii(0x19_e63f, 2); if(jbw(0x19_e644, 0x3)) goto l_0x19_e644; /* jb 0xe644 */
            ii(0x19_e641, 3); jmpw(0x19_e647, 0x3); goto l_0x19_e647;   /* jmp 0xe647 */
        l_0x19_e644:
            ii(0x19_e644, 3); jmpw(0x19_e864, 0x21d); goto l_0x19_e864; /* jmp 0xe864 */
        l_0x19_e647:
            ii(0x19_e647, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x19_e64a, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_e64d, 3); lea(ax, bp - 0x62);                       /* lea ax, [bp-0x62] */
            ii(0x19_e650, 3); mov(memw_a16[ss, bp - 0x7c], ax);         /* mov [bp-0x7c], ax */
            ii(0x19_e653, 3); mov(memw_a16[ss, bp - 0x7a], ss);         /* mov [bp-0x7a], ss */
            ii(0x19_e656, 1); pushw(ss);                                /* push ss */
            ii(0x19_e657, 1); pushw(ax);                                /* push ax */
            ii(0x19_e658, 1); nop();                                    /* nop */
            ii(0x19_e659, 1); pushw(cs);                                /* push cs */
            ii(0x19_e65a, 3); callw(0x1a_01ed, 0x1b90);                 /* call 0x1ed */
        l_0x19_e65d:
            ii(0x19_e65d, 4); mov(es, memw_a16[ds, 0x3fce]);            /* mov es, [0x3fce] */
            ii(0x19_e661, 4); mov(ax, memw_a16[es, 0x3b7c]);            /* mov ax, [es:0x3b7c] */
            ii(0x19_e665, 2); sub(cx, cx);                              /* sub cx, cx */
            ii(0x19_e667, 1); pushw(ax);                                /* push ax */
            ii(0x19_e668, 1); pushw(cx);                                /* push cx */
            ii(0x19_e669, 5); callw_far_abs(0x80, 0x55dc);              /* call word 0x80:0x55dc */
            ii(0x19_e66e, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x19_e671, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x19_e673, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x19_e675, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x19_e677, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x19_e679, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x19_e67b, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x19_e67d, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x19_e67f, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x19_e681, 3); mov(memw_a16[ss, bp - 0x6c], ax);         /* mov [bp-0x6c], ax */
            ii(0x19_e684, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_e686, 3); mov(ax, memw_a16[ss, bp - 0x6c]);         /* mov ax, [bp-0x6c] */
            ii(0x19_e689, 1); dec(ax);                                  /* dec ax */
            ii(0x19_e68a, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x19_e68c, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x19_e68e, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x19_e690, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x19_e692, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x19_e694, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x19_e696, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x19_e698, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x19_e69a, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x19_e69c, 1); pushw(dx);                                /* push dx */
            ii(0x19_e69d, 1); pushw(ax);                                /* push ax */
            ii(0x19_e69e, 5); callw_far_abs(0x80, 0x562c);              /* call word 0x80:0x562c */
            ii(0x19_e6a3, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_e6a6, 3); mov(memw_a16[ss, bp - 0x76], ax);         /* mov [bp-0x76], ax */
            ii(0x19_e6a9, 3); mov(memw_a16[ss, bp - 0x74], dx);         /* mov [bp-0x74], dx */
            ii(0x19_e6ac, 3); les(bx, ss, bp - 0x76);                   /* les bx, [bp-0x76] */
            ii(0x19_e6af, 4); mov(ax, memw_a16[es, bx + 0x3]);          /* mov ax, [es:bx+0x3] */
            ii(0x19_e6b3, 3); mov(memw_a16[ss, bp - 0x1c], ax);         /* mov [bp-0x1c], ax */
            ii(0x19_e6b6, 3); pushw(memw_a16[ss, bp - 0x74]);           /* push word [bp-0x74] */
            ii(0x19_e6b9, 3); pushw(memw_a16[ss, bp - 0x76]);           /* push word [bp-0x76] */
            ii(0x19_e6bc, 5); callw_far_abs(0x80, 0x4f60);              /* call word 0x80:0x4f60 */
            ii(0x19_e6c1, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x19_e6c4, 3); mov(si, memw_a16[ss, bp - 0x1c]);         /* mov si, [bp-0x1c] */
            ii(0x19_e6c7, 3); shl(si, 0x4);                             /* shl si, 0x4 */
            ii(0x19_e6ca, 3); sub(si, 0x6);                             /* sub si, 0x6 */
            ii(0x19_e6cd, 4); mov(es, memw_a16[ds, 0x3fce]);            /* mov es, [0x3fce] */
            ii(0x19_e6d1, 4); mov(ax, memw_a16[es, 0x3b7c]);            /* mov ax, [es:0x3b7c] */
            ii(0x19_e6d5, 5); mov(memw_a16[ss, bp - 0x1a], 0);          /* mov word [bp-0x1a], 0x0 */
            ii(0x19_e6da, 3); mov(memw_a16[ss, bp - 0x18], ax);         /* mov [bp-0x18], ax */
        l_0x19_e6dd:
            ii(0x19_e6dd, 3); les(bx, ss, bp - 0x1a);                   /* les bx, [bp-0x1a] */
            ii(0x19_e6e0, 4); cmp(memw_a16[es, bx], 0);                 /* cmp word [es:bx], 0x0 */
            ii(0x19_e6e4, 2); if(jnzw(0x19_e6e9, 0x3)) goto l_0x19_e6e9; /* jnz 0xe6e9 */
            ii(0x19_e6e6, 3); jmpw(0x19_e6f0, 0x7); goto l_0x19_e6f0;   /* jmp 0xe6f0 */
        l_0x19_e6e9:
            ii(0x19_e6e9, 3); inc(memw_a16[ss, bp - 0x1a]);             /* inc word [bp-0x1a] */
            ii(0x19_e6ec, 1); dec(si);                                  /* dec si */
            ii(0x19_e6ed, 3); jmpw(0x19_e6dd, -0x13); goto l_0x19_e6dd; /* jmp 0xe6dd */
        l_0x19_e6f0:
            ii(0x19_e6f0, 3); pushw(memw_a16[ss, bp - 0x7a]);           /* push word [bp-0x7a] */
            ii(0x19_e6f3, 3); pushw(memw_a16[ss, bp - 0x7c]);           /* push word [bp-0x7c] */
            ii(0x19_e6f6, 3); callw(0x19_ff2f, 0x1836);                 /* call 0xff2f */
            ii(0x19_e6f9, 2); mov(cx, si);                              /* mov cx, si */
            ii(0x19_e6fb, 2); sub(cx, ax);                              /* sub cx, ax */
            ii(0x19_e6fd, 3); mov(memw_a16[ss, bp - 0x6e], cx);         /* mov [bp-0x6e], cx */
            ii(0x19_e700, 3); cmp(cx, 0);                               /* cmp cx, 0x0 */
            ii(0x19_e703, 2); if(jlw(0x19_e708, 0x3)) goto l_0x19_e708; /* jl 0xe708 */
            ii(0x19_e705, 3); jmpw(0x19_e827, 0x11f); goto l_0x19_e827; /* jmp 0xe827 */
        l_0x19_e708:
            ii(0x19_e708, 2); pushw(0x3);                               /* push 0x3 */
            ii(0x19_e70a, 5); callw_far_abs(0x80, 0x51ba);              /* call word 0x80:0x51ba */
            ii(0x19_e70f, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x19_e712, 3); mov(memw_a16[ss, bp - 0x78], ax);         /* mov [bp-0x78], ax */
            ii(0x19_e715, 5); mov(memw_a16[ss, bp - 0x2], 0x4800);      /* mov word [bp-0x2], 0x4800 */
            ii(0x19_e71a, 3); mov(ax, 0xf);                             /* mov ax, 0xf */
            ii(0x19_e71d, 3); sub(ax, memw_a16[ss, bp - 0x6e]);         /* sub ax, [bp-0x6e] */
            ii(0x19_e720, 3); sar(ax, 0x4);                             /* sar ax, 0x4 */
            ii(0x19_e723, 3); add(ax, memw_a16[ss, bp - 0x1c]);         /* add ax, [bp-0x1c] */
            ii(0x19_e726, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x19_e729, 3); mov(ax, memw_a16[ss, bp - 0x8]);          /* mov ax, [bp-0x8] */
            ii(0x19_e72c, 3); shl(ax, 0x4);                             /* shl ax, 0x4 */
            ii(0x19_e72f, 3); mov(memw_a16[ss, bp - 0x6e], ax);         /* mov [bp-0x6e], ax */
            ii(0x19_e732, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_e734, 3); mov(memw_a16[ss, bp - 0x18], ax);         /* mov [bp-0x18], ax */
            ii(0x19_e737, 3); mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x19_e73a, 3); lea(ax, bp - 0x14);                       /* lea ax, [bp-0x14] */
            ii(0x19_e73d, 1); pushw(ss);                                /* push ss */
            ii(0x19_e73e, 1); pushw(ax);                                /* push ax */
            ii(0x19_e73f, 1); pushw(ss);                                /* push ss */
            ii(0x19_e740, 1); pushw(ax);                                /* push ax */
            ii(0x19_e741, 2); pushw(0x21);                              /* push 0x21 */
            ii(0x19_e743, 5); callw_far_abs(0x80, 0x570e);              /* call word 0x80:0x570e */
            ii(0x19_e748, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x19_e74b, 2); test(al, 0x1);                            /* test al, 0x1 */
            ii(0x19_e74d, 2); if(jzw(0x19_e752, 0x3)) goto l_0x19_e752; /* jz 0xe752 */
            ii(0x19_e74f, 3); jmpw(0x19_e780, 0x2e); goto l_0x19_e780;  /* jmp 0xe780 */
        l_0x19_e752:
            ii(0x19_e752, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x19_e755, 3); mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x19_e758, 3); pushw(memw_a16[ss, bp - 0x6e]);           /* push word [bp-0x6e] */
            ii(0x19_e75b, 3); mov(ax, memw_a16[ss, bp - 0x16]);         /* mov ax, [bp-0x16] */
            ii(0x19_e75e, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x19_e760, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x19_e762, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x19_e764, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x19_e766, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x19_e768, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x19_e76a, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x19_e76c, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x19_e76e, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x19_e770, 1); pushw(dx);                                /* push dx */
            ii(0x19_e771, 1); pushw(ax);                                /* push ax */
            ii(0x19_e772, 5); callw_far_abs(0x80, 0x562c);              /* call word 0x80:0x562c */
            ii(0x19_e777, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_e77a, 3); mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x19_e77d, 3); mov(memw_a16[ss, bp - 0x18], dx);         /* mov [bp-0x18], dx */
        l_0x19_e780:
            ii(0x19_e780, 3); pushw(memw_a16[ss, bp - 0x78]);           /* push word [bp-0x78] */
            ii(0x19_e783, 5); callw_far_abs(0x80, 0x51ba);              /* call word 0x80:0x51ba */
            ii(0x19_e788, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x19_e78b, 3); mov(ax, memw_a16[ss, bp - 0x18]);         /* mov ax, [bp-0x18] */
            ii(0x19_e78e, 3); or(ax, memw_a16[ss, bp - 0x1a]);          /* or ax, [bp-0x1a] */
            ii(0x19_e791, 2); if(jzw(0x19_e796, 0x3)) goto l_0x19_e796; /* jz 0xe796 */
            ii(0x19_e793, 3); jmpw(0x19_e799, 0x3); goto l_0x19_e799;   /* jmp 0xe799 */
        l_0x19_e796:
            ii(0x19_e796, 3); jmpw(0x19_e864, 0xcb); goto l_0x19_e864;  /* jmp 0xe864 */
        l_0x19_e799:
            ii(0x19_e799, 3); mov(ax, memw_a16[ss, bp - 0x1c]);         /* mov ax, [bp-0x1c] */
            ii(0x19_e79c, 3); shl(ax, 0x4);                             /* shl ax, 0x4 */
            ii(0x19_e79f, 1); pushw(ax);                                /* push ax */
            ii(0x19_e7a0, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_e7a2, 3); pushw(memw_a16[ss, bp - 0x18]);           /* push word [bp-0x18] */
            ii(0x19_e7a5, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_e7a7, 4); mov(es, memw_a16[ds, 0x3fce]);            /* mov es, [0x3fce] */
            ii(0x19_e7ab, 5); pushw(memw_a16[es, 0x3b7c]);              /* push word [es:0x3b7c] */
            ii(0x19_e7b0, 5); callw_far_abs(0x80, 0x3efa);              /* call word 0x80:0x3efa */
            ii(0x19_e7b5, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x19_e7b8, 3); lea(ax, bp - 0x6a);                       /* lea ax, [bp-0x6a] */
            ii(0x19_e7bb, 1); pushw(ss);                                /* push ss */
            ii(0x19_e7bc, 1); pushw(ax);                                /* push ax */
            ii(0x19_e7bd, 3); pushw(memw_a16[ss, bp - 0x18]);           /* push word [bp-0x18] */
            ii(0x19_e7c0, 5); callw_far_abs(0x80, 0x4f82);              /* call word 0x80:0x4f82 */
            ii(0x19_e7c5, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_e7c8, 3); pushw(memw_a16[ss, bp - 0x18]);           /* push word [bp-0x18] */
            ii(0x19_e7cb, 3); pushw(memw_a16[ss, bp - 0x1a]);           /* push word [bp-0x1a] */
            ii(0x19_e7ce, 5); callw_far_abs(0x80, 0x4f60);              /* call word 0x80:0x4f60 */
            ii(0x19_e7d3, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x19_e7d6, 3); lea(ax, bp - 0x6a);                       /* lea ax, [bp-0x6a] */
            ii(0x19_e7d9, 1); pushw(ss);                                /* push ss */
            ii(0x19_e7da, 1); pushw(ax);                                /* push ax */
            ii(0x19_e7db, 4); mov(es, memw_a16[ds, 0x3fce]);            /* mov es, [0x3fce] */
            ii(0x19_e7df, 5); pushw(memw_a16[es, 0x3b7c]);              /* push word [es:0x3b7c] */
            ii(0x19_e7e4, 5); callw_far_abs(0x80, 0x4ff4);              /* call word 0x80:0x4ff4 */
            ii(0x19_e7e9, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_e7ec, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x19_e7ef, 2); if(jnzw(0x19_e7f4, 0x3)) goto l_0x19_e7f4; /* jnz 0xe7f4 */
            ii(0x19_e7f1, 3); jmpw(0x19_e7fa, 0x6); goto l_0x19_e7fa;   /* jmp 0xe7fa */
        l_0x19_e7f4:
            ii(0x19_e7f4, 3); mov(ax, memw_a16[ss, bp - 0x6c]);         /* mov ax, [bp-0x6c] */
            ii(0x19_e7f7, 3); jmpw(0x19_e7fd, 0x3); goto l_0x19_e7fd;   /* jmp 0xe7fd */
        l_0x19_e7fa:
            ii(0x19_e7fa, 3); mov(ax, memw_a16[ss, bp - 0x16]);         /* mov ax, [bp-0x16] */
        l_0x19_e7fd:
            ii(0x19_e7fd, 3); mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0x19_e800, 5); mov(memw_a16[ss, bp - 0x2], 0x4900);      /* mov word [bp-0x2], 0x4900 */
            ii(0x19_e805, 3); lea(ax, bp - 0x14);                       /* lea ax, [bp-0x14] */
            ii(0x19_e808, 1); pushw(ss);                                /* push ss */
            ii(0x19_e809, 1); pushw(ax);                                /* push ax */
            ii(0x19_e80a, 1); pushw(ss);                                /* push ss */
            ii(0x19_e80b, 1); pushw(ax);                                /* push ax */
            ii(0x19_e80c, 2); pushw(0x21);                              /* push 0x21 */
            ii(0x19_e80e, 5); callw_far_abs(0x80, 0x570e);              /* call word 0x80:0x570e */
            ii(0x19_e813, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x19_e816, 3); mov(ax, memw_a16[ss, bp - 0x12]);         /* mov ax, [bp-0x12] */
            ii(0x19_e819, 3); cmp(memw_a16[ss, bp - 0x16], ax);         /* cmp [bp-0x16], ax */
            ii(0x19_e81c, 2); if(jzw(0x19_e821, 0x3)) goto l_0x19_e821; /* jz 0xe821 */
            ii(0x19_e81e, 3); jmpw(0x19_e824, 0x3); goto l_0x19_e824;   /* jmp 0xe824 */
        l_0x19_e821:
            ii(0x19_e821, 3); jmpw(0x19_e864, 0x40); goto l_0x19_e864;  /* jmp 0xe864 */
        l_0x19_e824:
            ii(0x19_e824, 3); jmpw(0x19_e65d, -0x1ca); goto l_0x19_e65d; /* jmp 0xe65d */
        l_0x19_e827:
            ii(0x19_e827, 4); add(memw_a16[ss, bp - 0x1a], 0x2);        /* add word [bp-0x1a], 0x2 */
            ii(0x19_e82b, 3); les(bx, ss, bp - 0x1a);                   /* les bx, [bp-0x1a] */
            ii(0x19_e82e, 4); add(memw_a16[ss, bp - 0x1a], 0x2);        /* add word [bp-0x1a], 0x2 */
            ii(0x19_e832, 5); mov(memw_a16[es, bx], 0x1);               /* mov word [es:bx], 0x1 */
        l_0x19_e837:
            ii(0x19_e837, 3); les(bx, ss, bp - 0x7c);                   /* les bx, [bp-0x7c] */
            ii(0x19_e83a, 3); inc(memw_a16[ss, bp - 0x7c]);             /* inc word [bp-0x7c] */
            ii(0x19_e83d, 3); mov(al, memb_a16[es, bx]);                /* mov al, [es:bx] */
            ii(0x19_e840, 3); les(bx, ss, bp - 0x1a);                   /* les bx, [bp-0x1a] */
            ii(0x19_e843, 3); inc(memw_a16[ss, bp - 0x1a]);             /* inc word [bp-0x1a] */
            ii(0x19_e846, 3); mov(memb_a16[es, bx], al);                /* mov [es:bx], al */
            ii(0x19_e849, 2); cmp(al, 0);                               /* cmp al, 0x0 */
            ii(0x19_e84b, 2); if(jnzw(0x19_e850, 0x3)) goto l_0x19_e850; /* jnz 0xe850 */
            ii(0x19_e84d, 3); jmpw(0x19_e85c, 0xc); goto l_0x19_e85c;   /* jmp 0xe85c */
        l_0x19_e850:
            ii(0x19_e850, 1); dec(si);                                  /* dec si */
            ii(0x19_e851, 3); cmp(si, 0);                               /* cmp si, 0x0 */
            ii(0x19_e854, 2); if(jaw(0x19_e859, 0x3)) goto l_0x19_e859; /* ja 0xe859 */
            ii(0x19_e856, 3); jmpw(0x19_e85c, 0x3); goto l_0x19_e85c;   /* jmp 0xe85c */
        l_0x19_e859:
            ii(0x19_e859, 3); jmpw(0x19_e837, -0x25); goto l_0x19_e837; /* jmp 0xe837 */
        l_0x19_e85c:
            ii(0x19_e85c, 3); les(bx, ss, bp - 0x1a);                   /* les bx, [bp-0x1a] */
            ii(0x19_e85f, 5); mov(memw_a16[es, bx], 0);                 /* mov word [es:bx], 0x0 */
        l_0x19_e864:
            ii(0x19_e864, 1); popw(si);                                 /* pop si */
            ii(0x19_e865, 1); popw(di);                                 /* pop di */
            ii(0x19_e866, 1); leavew();                                 /* leave */
            ii(0x19_e867, 1); retfw();                                  /* retf */
        }
    }
}
