using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6a9fd3db-7425-4aee-8d57-492a99c86a6a")]
        public void Method_0013_a688()
        {
            ii(0x13_a688, 4); enterw(0x2a, 0);                          /* enter 0x2a, 0x0 */
            ii(0x13_a68c, 1); pushw(di);                                /* push di */
            ii(0x13_a68d, 1); pushw(si);                                /* push si */
            ii(0x13_a68e, 1); pushw(ds);                                /* push ds */
            ii(0x13_a68f, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_a692, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_a694, 5); mov(memw_a16[ss, bp - 0xe], 0);           /* mov word [bp-0xe], 0x0 */
            ii(0x13_a699, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x13_a69c, 4); mov(ax, memw_a16[es, bx + 0x14]);         /* mov ax, [es:bx+0x14] */
            ii(0x13_a6a0, 4); mov(dx, memw_a16[es, bx + 0x16]);         /* mov dx, [es:bx+0x16] */
            ii(0x13_a6a4, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x13_a6a7, 3); mov(memw_a16[ss, bp - 0xa], dx);          /* mov [bp-0xa], dx */
            ii(0x13_a6aa, 4); mov(ax, memw_a16[es, bx + 0x1c]);         /* mov ax, [es:bx+0x1c] */
            ii(0x13_a6ae, 4); mov(dx, memw_a16[es, bx + 0x1e]);         /* mov dx, [es:bx+0x1e] */
            ii(0x13_a6b2, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x13_a6b5, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x13_a6b8, 6); test(memw_a16[es, bx + 0xa], 0xffff);     /* test word [es:bx+0xa], 0xffff */
            ii(0x13_a6be, 2); if(jzw(0x13_a6c8, 0x8)) goto l_0x13_a6c8; /* jz 0xa6c8 */
            ii(0x13_a6c0, 5); mov(memw_a16[ss, bp - 0xe], 0x8023);      /* mov word [bp-0xe], 0x8023 */
            ii(0x13_a6c5, 3); jmpw(0x13_a8cc, 0x204); goto l_0x13_a8cc; /* jmp 0xa8cc */
        l_0x13_a6c8:
            ii(0x13_a6c8, 4); mov(ax, memw_a16[es, bx + 0x8]);          /* mov ax, [es:bx+0x8] */
            ii(0x13_a6cc, 3); mov(memw_a16[ss, bp - 0x28], ax);         /* mov [bp-0x28], ax */
            ii(0x13_a6cf, 1); pushw(ax);                                /* push ax */
            ii(0x13_a6d0, 1); pushw(cs);                                /* push cs */
            ii(0x13_a6d1, 3); callw(0x13_c79c, 0x20c8);                 /* call 0xc79c */
            ii(0x13_a6d4, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x13_a6d7, 3); mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0x13_a6da, 3); mov(memw_a16[ss, bp - 0x10], dx);         /* mov [bp-0x10], dx */
            ii(0x13_a6dd, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x13_a6e0, 2); if(jnzw(0x13_a6ee, 0xc)) goto l_0x13_a6ee; /* jnz 0xa6ee */
            ii(0x13_a6e2, 2); cmp(dx, ax);                              /* cmp dx, ax */
            ii(0x13_a6e4, 2); if(jnzw(0x13_a6ee, 0x8)) goto l_0x13_a6ee; /* jnz 0xa6ee */
            ii(0x13_a6e6, 5); mov(memw_a16[ss, bp - 0xe], 0x8023);      /* mov word [bp-0xe], 0x8023 */
            ii(0x13_a6eb, 3); jmpw(0x13_a8cc, 0x1de); goto l_0x13_a8cc; /* jmp 0xa8cc */
        l_0x13_a6ee:
            ii(0x13_a6ee, 3); mov(ax, memw_a16[ss, bp - 0xc]);          /* mov ax, [bp-0xc] */
            ii(0x13_a6f1, 3); mov(dx, memw_a16[ss, bp - 0xa]);          /* mov dx, [bp-0xa] */
            ii(0x13_a6f4, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x13_a6f6, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x13_a6f8, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x13_a6fa, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x13_a6fc, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_a6fe, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_a700, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_a702, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_a704, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_a706, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_a708, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_a70a, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_a70c, 3); add(memw_a16[ss, bp - 0x12], ax);         /* add [bp-0x12], ax */
            ii(0x13_a70f, 3); adc(memw_a16[ss, bp - 0x10], dx);         /* adc [bp-0x10], dx */
            ii(0x13_a712, 3); mov(ax, memw_a16[ss, bp - 0x12]);         /* mov ax, [bp-0x12] */
            ii(0x13_a715, 3); mov(dx, memw_a16[ss, bp - 0x10]);         /* mov dx, [bp-0x10] */
            ii(0x13_a718, 3); add(ax, 0);                               /* add ax, 0x0 */
            ii(0x13_a71b, 3); adc(dx, 0x1);                             /* adc dx, 0x1 */
            ii(0x13_a71e, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x13_a720, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x13_a722, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x13_a724, 2); sub(al, al);                              /* sub al, al */
            ii(0x13_a726, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_a728, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_a72a, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_a72c, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_a72e, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_a730, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_a732, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_a734, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_a736, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x13_a739, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x13_a73c, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x13_a73f, 4); mov(cx, memw_a16[es, bx + 0x18]);         /* mov cx, [es:bx+0x18] */
            ii(0x13_a743, 4); mov(si, memw_a16[es, bx + 0x1a]);         /* mov si, [es:bx+0x1a] */
            ii(0x13_a747, 3); mov(memw_a16[ss, bp - 0x22], cx);         /* mov [bp-0x22], cx */
            ii(0x13_a74a, 3); mov(memw_a16[ss, bp - 0x20], si);         /* mov [bp-0x20], si */
            ii(0x13_a74d, 2); mov(di, ax);                              /* mov di, ax */
            ii(0x13_a74f, 2); mov(bx, dx);                              /* mov bx, dx */
            ii(0x13_a751, 2); mov(ax, cx);                              /* mov ax, cx */
            ii(0x13_a753, 2); mov(dx, si);                              /* mov dx, si */
            ii(0x13_a755, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x13_a757, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x13_a759, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x13_a75b, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x13_a75d, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_a75f, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_a761, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_a763, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_a765, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_a767, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_a769, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_a76b, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_a76d, 3); mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x13_a770, 3); mov(memw_a16[ss, bp - 0x14], dx);         /* mov [bp-0x14], dx */
            ii(0x13_a773, 3); add(di, memw_a16[ss, bp - 0xc]);          /* add di, [bp-0xc] */
            ii(0x13_a776, 3); adc(bx, memw_a16[ss, bp - 0xa]);          /* adc bx, [bp-0xa] */
            ii(0x13_a779, 1); pushw(bx);                                /* push bx */
            ii(0x13_a77a, 1); pushw(di);                                /* push di */
            ii(0x13_a77b, 1); pushw(si);                                /* push si */
            ii(0x13_a77c, 1); pushw(cx);                                /* push cx */
            ii(0x13_a77d, 1); pushw(ds);                                /* push ds */
            ii(0x13_a77e, 3); pushw(0x133f);                            /* push 0x133f */
            ii(0x13_a781, 1); nop();                                    /* nop */
            ii(0x13_a782, 1); pushw(cs);                                /* push cs */
            ii(0x13_a783, 3); callw(0x14_104f, 0x68c9);                 /* call 0x104f */
            ii(0x13_a786, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x13_a789, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x13_a78c, 5); and(memb_a16[es, bx + 0x2c], -0x2 /* 0xfe */); /* and byte [es:bx+0x2c], 0xfe */
            ii(0x13_a791, 3); mov(ax, memw_a16[ss, bp - 0x12]);         /* mov ax, [bp-0x12] */
            ii(0x13_a794, 3); mov(dx, memw_a16[ss, bp - 0x10]);         /* mov dx, [bp-0x10] */
            ii(0x13_a797, 3); mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x13_a79a, 3); mov(memw_a16[ss, bp - 0x18], dx);         /* mov [bp-0x18], dx */
            ii(0x13_a79d, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x13_a79f, 3); mov(memw_a16[ss, bp - 0x1c], ax);         /* mov [bp-0x1c], ax */
            ii(0x13_a7a2, 3); mov(memw_a16[ss, bp - 0x1e], ax);         /* mov [bp-0x1e], ax */
            ii(0x13_a7a5, 2); jmpw(0x13_a7b8, 0x11); goto l_0x13_a7b8;  /* jmp 0xa7b8 */
        //  ii(0x13_a7a7, 1); Недостижимый код.
l_0x13_a7a8:
            ii(0x13_a7a8, 4); add(memw_a16[ss, bp - 0x1e], 0x1);        /* add word [bp-0x1e], 0x1 */
            ii(0x13_a7ac, 4); adc(memw_a16[ss, bp - 0x1c], 0);          /* adc word [bp-0x1c], 0x0 */
            ii(0x13_a7b0, 4); add(memw_a16[ss, bp - 0x1a], 0x1);        /* add word [bp-0x1a], 0x1 */
            ii(0x13_a7b4, 4); adc(memw_a16[ss, bp - 0x18], 0);          /* adc word [bp-0x18], 0x0 */
        l_0x13_a7b8:
            ii(0x13_a7b8, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x13_a7bb, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x13_a7be, 3); cmp(memw_a16[ss, bp - 0x1c], dx);         /* cmp [bp-0x1c], dx */
            ii(0x13_a7c1, 2); if(jaw(0x13_a816, 0x53)) goto l_0x13_a816; /* ja 0xa816 */
            ii(0x13_a7c3, 2); if(jbw(0x13_a7ca, 0x5)) goto l_0x13_a7ca; /* jb 0xa7ca */
            ii(0x13_a7c5, 3); cmp(memw_a16[ss, bp - 0x1e], ax);         /* cmp [bp-0x1e], ax */
            ii(0x13_a7c8, 2); if(jaew(0x13_a816, 0x4c)) goto l_0x13_a816; /* jae 0xa816 */
        l_0x13_a7ca:
            ii(0x13_a7ca, 3); pushw(memw_a16[ss, bp - 0x18]);           /* push word [bp-0x18] */
            ii(0x13_a7cd, 3); pushw(memw_a16[ss, bp - 0x1a]);           /* push word [bp-0x1a] */
            ii(0x13_a7d0, 4); pushw(memw_a16[ds, 0x1fa6]);              /* push word [0x1fa6] */
            ii(0x13_a7d4, 4); pushw(memw_a16[ds, 0x1fa4]);              /* push word [0x1fa4] */
            ii(0x13_a7d8, 3); callw(0x13_90c4, -0x1717);                /* call 0x90c4 */
            ii(0x13_a7db, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_a7de, 3); mov(memw_a16[ss, bp - 0x2a], ax);         /* mov [bp-0x2a], ax */
            ii(0x13_a7e1, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x13_a7e3, 2); if(jnzw(0x13_a7f0, 0xb)) goto l_0x13_a7f0; /* jnz 0xa7f0 */
            ii(0x13_a7e5, 5); mov(memw_a16[ss, bp - 0xe], 0x8002);      /* mov word [bp-0xe], 0x8002 */
            ii(0x13_a7ea, 3); jmpw(0x13_a8cc, 0xdf); goto l_0x13_a8cc;  /* jmp 0xa8cc */
        //  ii(0x13_a7ed, 3); Недостижимый код.
l_0x13_a7f0:
            ii(0x13_a7f0, 3); mov(al, memb_a16[ds, 0x51a6]);            /* mov al, [0x51a6] */
            ii(0x13_a7f3, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x13_a7f5, 3); cmp(ax, memw_a16[ss, bp - 0x2a]);         /* cmp ax, [bp-0x2a] */
            ii(0x13_a7f8, 2); if(jzw(0x13_a813, 0x19)) goto l_0x13_a813; /* jz 0xa813 */
            ii(0x13_a7fa, 3); mov(al, memb_a16[ds, 0x51b5]);            /* mov al, [0x51b5] */
            ii(0x13_a7fd, 3); cmp(ax, memw_a16[ss, bp - 0x2a]);         /* cmp ax, [bp-0x2a] */
            ii(0x13_a800, 2); if(jzw(0x13_a813, 0x11)) goto l_0x13_a813; /* jz 0xa813 */
            ii(0x13_a802, 2); pushw(0);                                 /* push 0x0 */
            ii(0x13_a804, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x13_a806, 3); pushw(memw_a16[ss, bp - 0x18]);           /* push word [bp-0x18] */
            ii(0x13_a809, 3); pushw(memw_a16[ss, bp - 0x1a]);           /* push word [bp-0x1a] */
            ii(0x13_a80c, 1); pushw(cs);                                /* push cs */
            ii(0x13_a80d, 3); callw(0x13_c560, 0x1d50);                 /* call 0xc560 */
            ii(0x13_a810, 3); add(sp, 0x8);                             /* add sp, 0x8 */
        l_0x13_a813:
            ii(0x13_a813, 2); jmpw(0x13_a7a8, -0x6d); goto l_0x13_a7a8; /* jmp 0xa7a8 */
        //  ii(0x13_a815, 1); Недостижимый код.
l_0x13_a816:
            ii(0x13_a816, 3); mov(ax, memw_a16[ss, bp - 0x12]);         /* mov ax, [bp-0x12] */
            ii(0x13_a819, 3); mov(dx, memw_a16[ss, bp - 0x10]);         /* mov dx, [bp-0x10] */
            ii(0x13_a81c, 3); mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x13_a81f, 3); mov(memw_a16[ss, bp - 0x18], dx);         /* mov [bp-0x18], dx */
            ii(0x13_a822, 4); or(memb_a16[ss, bp - 0x26], 0x7);         /* or byte [bp-0x26], 0x7 */
            ii(0x13_a826, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x13_a828, 3); mov(memw_a16[ss, bp - 0x1c], ax);         /* mov [bp-0x1c], ax */
            ii(0x13_a82b, 3); mov(memw_a16[ss, bp - 0x1e], ax);         /* mov [bp-0x1e], ax */
            ii(0x13_a82e, 2); jmpw(0x13_a848, 0x18); goto l_0x13_a848;  /* jmp 0xa848 */
        l_0x13_a830:
            ii(0x13_a830, 4); add(memw_a16[ss, bp - 0x1e], 0x1);        /* add word [bp-0x1e], 0x1 */
            ii(0x13_a834, 4); adc(memw_a16[ss, bp - 0x1c], 0);          /* adc word [bp-0x1c], 0x0 */
            ii(0x13_a838, 4); add(memw_a16[ss, bp - 0x1a], 0x1);        /* add word [bp-0x1a], 0x1 */
            ii(0x13_a83c, 4); adc(memw_a16[ss, bp - 0x18], 0);          /* adc word [bp-0x18], 0x0 */
            ii(0x13_a840, 4); add(memw_a16[ss, bp - 0x16], 0x1);        /* add word [bp-0x16], 0x1 */
            ii(0x13_a844, 4); adc(memw_a16[ss, bp - 0x14], 0);          /* adc word [bp-0x14], 0x0 */
        l_0x13_a848:
            ii(0x13_a848, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x13_a84b, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x13_a84e, 3); cmp(memw_a16[ss, bp - 0x1c], dx);         /* cmp [bp-0x1c], dx */
            ii(0x13_a851, 2); if(jaw(0x13_a8c6, 0x73)) goto l_0x13_a8c6; /* ja 0xa8c6 */
            ii(0x13_a853, 2); if(jbw(0x13_a85a, 0x5)) goto l_0x13_a85a; /* jb 0xa85a */
            ii(0x13_a855, 3); cmp(memw_a16[ss, bp - 0x1e], ax);         /* cmp [bp-0x1e], ax */
            ii(0x13_a858, 2); if(jaew(0x13_a8c6, 0x6c)) goto l_0x13_a8c6; /* jae 0xa8c6 */
        l_0x13_a85a:
            ii(0x13_a85a, 3); mov(al, memb_a16[ds, 0x51a6]);            /* mov al, [0x51a6] */
            ii(0x13_a85d, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x13_a85f, 1); pushw(ax);                                /* push ax */
            ii(0x13_a860, 3); pushw(memw_a16[ss, bp - 0x18]);           /* push word [bp-0x18] */
            ii(0x13_a863, 3); pushw(memw_a16[ss, bp - 0x1a]);           /* push word [bp-0x1a] */
            ii(0x13_a866, 4); pushw(memw_a16[ds, 0x1fa6]);              /* push word [0x1fa6] */
            ii(0x13_a86a, 4); pushw(memw_a16[ds, 0x1fa4]);              /* push word [0x1fa4] */
            ii(0x13_a86e, 3); callw(0x13_91e3, -0x168e);                /* call 0x91e3 */
            ii(0x13_a871, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x13_a874, 3); mov(ax, memw_a16[ss, bp - 0x16]);         /* mov ax, [bp-0x16] */
            ii(0x13_a877, 3); mov(dx, memw_a16[ss, bp - 0x14]);         /* mov dx, [bp-0x14] */
            ii(0x13_a87a, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x13_a87c, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x13_a87e, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x13_a880, 2); sub(al, al);                              /* sub al, al */
            ii(0x13_a882, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_a884, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_a886, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_a888, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_a88a, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_a88c, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_a88e, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_a890, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_a892, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x13_a894, 2); mov(bx, dx);                              /* mov bx, dx */
            ii(0x13_a896, 3); xor(ax, memw_a16[ss, bp - 0x26]);         /* xor ax, [bp-0x26] */
            ii(0x13_a899, 3); and(ah, 0xf);                             /* and ah, 0xf */
            ii(0x13_a89c, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x13_a89e, 2); xor(cx, ax);                              /* xor cx, ax */
            ii(0x13_a8a0, 2); xor(bx, dx);                              /* xor bx, dx */
            ii(0x13_a8a2, 3); mov(memw_a16[ss, bp - 0x26], cx);         /* mov [bp-0x26], cx */
            ii(0x13_a8a5, 3); mov(memw_a16[ss, bp - 0x24], bx);         /* mov [bp-0x24], bx */
            ii(0x13_a8a8, 2); mov(dx, di);                              /* mov dx, di */
            ii(0x13_a8aa, 4); mov(es, memw_a16[ds, 0xaa]);              /* mov es, [0xaa] */
            ii(0x13_a8ae, 5); mov(edi, memd_a16[ds, 0x4f8c]);           /* mov edi, [0x4f8c] */
            ii(0x13_a8b3, 4); mov(ebx, memd_a16[ss, bp - 0x1a]);        /* mov ebx, [bp-0x1a] */
            ii(0x13_a8b7, 4); mov(eax, memd_a16[ss, bp - 0x26]);        /* mov eax, [bp-0x26] */
            ii(0x13_a8bb, 6); mov(memd_a32[es, edi + ebx * 4], eax);    /* mov [es:edi+ebx*4], eax */
            ii(0x13_a8c1, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x13_a8c3, 3); jmpw(0x13_a830, -0x96); goto l_0x13_a830; /* jmp 0xa830 */
        l_0x13_a8c6:
            ii(0x13_a8c6, 3); mov(eax, cr3);                            /* mov eax, cr3 */
            ii(0x13_a8c9, 3); mov(cr3, eax);                            /* mov cr3, eax */
        l_0x13_a8cc:
            ii(0x13_a8cc, 4); cmp(memw_a16[ss, bp - 0xe], 0);           /* cmp word [bp-0xe], 0x0 */
            ii(0x13_a8d0, 2); if(jzw(0x13_a8e6, 0x14)) goto l_0x13_a8e6; /* jz 0xa8e6 */
            ii(0x13_a8d2, 3); mov(ax, memw_a16[ss, bp - 0xe]);          /* mov ax, [bp-0xe] */
            ii(0x13_a8d5, 1); cwd();                                    /* cwd */
            ii(0x13_a8d6, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x13_a8d9, 4); mov(memw_a16[es, bx + 0x20], ax);         /* mov [es:bx+0x20], ax */
            ii(0x13_a8dd, 4); mov(memw_a16[es, bx + 0x22], dx);         /* mov [es:bx+0x22], dx */
            ii(0x13_a8e1, 5); or(memb_a16[es, bx + 0x2c], 0x1);         /* or byte [es:bx+0x2c], 0x1 */
        l_0x13_a8e6:
            ii(0x13_a8e6, 1); popw(ds);                                 /* pop ds */
            ii(0x13_a8e7, 1); popw(si);                                 /* pop si */
            ii(0x13_a8e8, 1); popw(di);                                 /* pop di */
            ii(0x13_a8e9, 1); leavew();                                 /* leave */
            ii(0x13_a8ea, 1); retfw(); return;                          /* retf */
        }
    }
}
