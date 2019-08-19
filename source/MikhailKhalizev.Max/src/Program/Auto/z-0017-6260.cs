using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_6260-d30d5c27")]
        public void Method_0017_6260()
        {
            ii(0x17_6260, 4); enterw(0x30, 0);                          /* enter 0x30, 0x0 */
            ii(0x17_6264, 1); pushw(si);                                /* push si */
            ii(0x17_6265, 1); pushw(ds);                                /* push ds */
            ii(0x17_6266, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_6269, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_626b, 5); mov(memw_a16[ss, bp - 0x14], 0);          /* mov word [bp-0x14], 0x0 */
            ii(0x17_6270, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x17_6273, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x17_6276, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x17_6278, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x17_627a, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x17_627c, 2); sub(al, al);                              /* sub al, al */
            ii(0x17_627e, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_6280, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_6282, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_6284, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_6286, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_6288, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_628a, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_628c, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_628e, 3); mov(memw_a16[ss, bp - 0xe], ax);          /* mov [bp-0xe], ax */
            ii(0x17_6291, 3); mov(memw_a16[ss, bp - 0xc], dx);          /* mov [bp-0xc], dx */
            ii(0x17_6294, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x17_6297, 3); shl(ax, 0x2);                             /* shl ax, 0x2 */
            ii(0x17_629a, 1); pushw(ax);                                /* push ax */
            ii(0x17_629b, 1); nop();                                    /* nop */
            ii(0x17_629c, 1); pushw(cs);                                /* push cs */
            ii(0x17_629d, 3); callw(0x16_e7a8, -0x7af8);                /* call 0xe7a8 */
            ii(0x17_62a0, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x17_62a3, 3); mov(memw_a16[ds, 0x4fa0], ax);            /* mov [0x4fa0], ax */
            ii(0x17_62a6, 4); mov(memw_a16[ds, 0x4fa2], dx);            /* mov [0x4fa2], dx */
            ii(0x17_62aa, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x17_62ac, 4); or(ax, memw_a16[ds, 0x4fa0]);             /* or ax, [0x4fa0] */
            ii(0x17_62b0, 2); if(jnzw(0x17_62c8, 0x16)) goto l_0x17_62c8; /* jnz 0x62c8 */
        l_0x17_62b2:
            ii(0x17_62b2, 1); pushw(ds);                                /* push ds */
            ii(0x17_62b3, 3); pushw(0x37a);                             /* push 0x37a */
            ii(0x17_62b6, 3); pushw(0x90a);                             /* push 0x90a */
            ii(0x17_62b9, 1); pushw(cs);                                /* push cs */
            ii(0x17_62ba, 3); callw(0x17_75b4, 0x12f7);                 /* call 0x75b4 */
            ii(0x17_62bd, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x17_62c0, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x17_62c3, 1); popw(ds);                                 /* pop ds */
            ii(0x17_62c4, 1); popw(si);                                 /* pop si */
            ii(0x17_62c5, 1); leavew();                                 /* leave */
            ii(0x17_62c6, 1); retfw(); return;                          /* retf */
        //  ii(0x17_62c7, 1); Недостижимый код.
        l_0x17_62c8:
            ii(0x17_62c8, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x17_62cb, 3); shl(ax, 0x2);                             /* shl ax, 0x2 */
            ii(0x17_62ce, 1); pushw(ax);                                /* push ax */
            ii(0x17_62cf, 1); pushw(dx);                                /* push dx */
            ii(0x17_62d0, 4); pushw(memw_a16[ds, 0x4fa0]);              /* push word [0x4fa0] */
            ii(0x17_62d4, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x17_62d6, 1); nop();                                    /* nop */
            ii(0x17_62d7, 1); pushw(cs);                                /* push cs */
            ii(0x17_62d8, 3); callw(0x17_8ed0, 0x2bf5);                 /* call 0x8ed0 */
            ii(0x17_62db, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x17_62de, 1); pushw(si);                                /* push si */
            ii(0x17_62df, 1); nop();                                    /* nop */
            ii(0x17_62e0, 1); pushw(cs);                                /* push cs */
            ii(0x17_62e1, 3); callw(0x16_e7a8, -0x7b3c);                /* call 0xe7a8 */
            ii(0x17_62e4, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x17_62e7, 3); mov(memw_a16[ds, 0x4fa4], ax);            /* mov [0x4fa4], ax */
            ii(0x17_62ea, 4); mov(memw_a16[ds, 0x4fa6], dx);            /* mov [0x4fa6], dx */
            ii(0x17_62ee, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x17_62f0, 4); or(ax, memw_a16[ds, 0x4fa4]);             /* or ax, [0x4fa4] */
            ii(0x17_62f4, 2); if(jnzw(0x17_62f8, 0x2)) goto l_0x17_62f8; /* jnz 0x62f8 */
            ii(0x17_62f6, 2); jmpw(0x17_62b2, -0x46); goto l_0x17_62b2; /* jmp 0x62b2 */
        l_0x17_62f8:
            ii(0x17_62f8, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x17_62fb, 3); shl(ax, 0x2);                             /* shl ax, 0x2 */
            ii(0x17_62fe, 1); pushw(ax);                                /* push ax */
            ii(0x17_62ff, 1); pushw(dx);                                /* push dx */
            ii(0x17_6300, 4); pushw(memw_a16[ds, 0x4fa4]);              /* push word [0x4fa4] */
            ii(0x17_6304, 1); nop();                                    /* nop */
            ii(0x17_6305, 1); pushw(cs);                                /* push cs */
            ii(0x17_6306, 3); callw(0x17_8ed0, 0x2bc7);                 /* call 0x8ed0 */
            ii(0x17_6309, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x17_630c, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x17_630f, 1); nop();                                    /* nop */
            ii(0x17_6310, 1); pushw(cs);                                /* push cs */
            ii(0x17_6311, 3); callw(0x16_e7a8, -0x7b6c);                /* call 0xe7a8 */
            ii(0x17_6314, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x17_6317, 3); mov(memw_a16[ds, 0x4f9c], ax);            /* mov [0x4f9c], ax */
            ii(0x17_631a, 4); mov(memw_a16[ds, 0x4f9e], dx);            /* mov [0x4f9e], dx */
            ii(0x17_631e, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x17_6320, 4); or(ax, memw_a16[ds, 0x4f9c]);             /* or ax, [0x4f9c] */
            ii(0x17_6324, 2); if(jnzw(0x17_6328, 0x2)) goto l_0x17_6328; /* jnz 0x6328 */
            ii(0x17_6326, 2); jmpw(0x17_62b2, -0x76); goto l_0x17_62b2; /* jmp 0x62b2 */
        l_0x17_6328:
            ii(0x17_6328, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x17_632b, 1); pushw(dx);                                /* push dx */
            ii(0x17_632c, 4); pushw(memw_a16[ds, 0x4f9c]);              /* push word [0x4f9c] */
            ii(0x17_6330, 1); nop();                                    /* nop */
            ii(0x17_6331, 1); pushw(cs);                                /* push cs */
            ii(0x17_6332, 3); callw(0x17_8ed0, 0x2b9b);                 /* call 0x8ed0 */
            ii(0x17_6335, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x17_6338, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_633a, 3); mov(memw_a16[ds, 0x5198], ax);            /* mov [0x5198], ax */
            ii(0x17_633d, 3); mov(memw_a16[ds, 0x519e], ax);            /* mov [0x519e], ax */
            ii(0x17_6340, 4); les(bx, ds, 0x2018);                      /* les bx, [0x2018] */
            ii(0x17_6344, 3); mov(ax, memw_a16[es, bx]);                /* mov ax, [es:bx] */
            ii(0x17_6347, 4); mov(dx, memw_a16[es, bx + 0x2]);          /* mov dx, [es:bx+0x2] */
            ii(0x17_634b, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_634d, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_634f, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_6351, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_6353, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_6355, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_6357, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_6359, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_635b, 3); mov(memw_a16[ss, bp - 0x18], ax);         /* mov [bp-0x18], ax */
            ii(0x17_635e, 3); mov(memw_a16[ss, bp - 0x16], dx);         /* mov [bp-0x16], dx */
            ii(0x17_6361, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x17_6363, 2); mov(bx, dx);                              /* mov bx, dx */
            ii(0x17_6365, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x17_6367, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x17_6369, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x17_636b, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_636d, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_636f, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_6371, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_6373, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_6375, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_6377, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_6379, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_637b, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_637d, 3); mov(memw_a16[ss, bp - 0x30], ax);         /* mov [bp-0x30], ax */
            ii(0x17_6380, 3); mov(memw_a16[ss, bp - 0x2e], dx);         /* mov [bp-0x2e], dx */
            ii(0x17_6383, 2); pushw(0x10);                              /* push 0x10 */
            ii(0x17_6385, 1); pushw(bx);                                /* push bx */
            ii(0x17_6386, 1); pushw(cx);                                /* push cx */
            ii(0x17_6387, 1); nop();                                    /* nop */
            ii(0x17_6388, 1); pushw(cs);                                /* push cs */
            ii(0x17_6389, 3); callw(0x16_e96a, -0x7a22);                /* call 0xe96a */
            ii(0x17_638c, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x17_638f, 3); mov(memw_a16[ss, bp - 0x20], ax);         /* mov [bp-0x20], ax */
            ii(0x17_6392, 3); mov(memw_a16[ss, bp - 0x1e], dx);         /* mov [bp-0x1e], dx */
            ii(0x17_6395, 1); pushw(cs);                                /* push cs */
            ii(0x17_6396, 3); callw(0x17_7458, 0x10bf);                 /* call 0x7458 */
            ii(0x17_6399, 3); mov(memw_a16[ss, bp - 0x2c], ax);         /* mov [bp-0x2c], ax */
            ii(0x17_639c, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
            ii(0x17_63a1, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x17_63a4, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x17_63a7, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_63a9, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_63ab, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_63ad, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_63af, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_63b1, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_63b3, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_63b5, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_63b7, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_63b9, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_63bb, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_63bd, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_63bf, 3); mov(cx, memw_a16[ss, bp + 0x6]);          /* mov cx, [bp+0x6] */
            ii(0x17_63c2, 3); mov(bx, memw_a16[ss, bp + 0x8]);          /* mov bx, [bp+0x8] */
            ii(0x17_63c5, 2); sub(cx, ax);                              /* sub cx, ax */
            ii(0x17_63c7, 2); sbb(bx, dx);                              /* sbb bx, dx */
            ii(0x17_63c9, 3); mov(memw_a16[ss, bp - 0xe], cx);          /* mov [bp-0xe], cx */
            ii(0x17_63cc, 3); mov(memw_a16[ss, bp - 0xc], bx);          /* mov [bp-0xc], bx */
        l_0x17_63cf:
            ii(0x17_63cf, 4); cmp(memw_a16[ss, bp + 0x8], 0);           /* cmp word [bp+0x8], 0x0 */
            ii(0x17_63d3, 2); if(jnzw(0x17_63de, 0x9)) goto l_0x17_63de; /* jnz 0x63de */
            ii(0x17_63d5, 4); cmp(memw_a16[ss, bp + 0x6], 0);           /* cmp word [bp+0x6], 0x0 */
            ii(0x17_63d9, 2); if(jnzw(0x17_63de, 0x3)) goto l_0x17_63de; /* jnz 0x63de */
            ii(0x17_63db, 3); jmpw(0x17_64fc, 0x11e); goto l_0x17_64fc; /* jmp 0x64fc */
        l_0x17_63de:
            ii(0x17_63de, 4); cmp(memw_a16[ss, bp - 0x2], 0x4);         /* cmp word [bp-0x2], 0x4 */
            ii(0x17_63e2, 2); if(jlw(0x17_63e7, 0x3)) goto l_0x17_63e7; /* jl 0x63e7 */
            ii(0x17_63e4, 3); jmpw(0x17_64fc, 0x115); goto l_0x17_64fc; /* jmp 0x64fc */
        l_0x17_63e7:
            ii(0x17_63e7, 3); pushw(memw_a16[ss, bp - 0xe]);            /* push word [bp-0xe] */
            ii(0x17_63ea, 1); pushw(cs);                                /* push cs */
            ii(0x17_63eb, 3); callw(0x17_7476, 0x1088);                 /* call 0x7476 */
            ii(0x17_63ee, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x17_63f1, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x17_63f4, 3); mov(memw_a16[ss, bp - 0x4], dx);          /* mov [bp-0x4], dx */
            ii(0x17_63f7, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x17_63f9, 2); if(jnzw(0x17_640c, 0x11)) goto l_0x17_640c; /* jnz 0x640c */
            ii(0x17_63fb, 2); pushw(0);                                 /* push 0x0 */
            ii(0x17_63fd, 2); pushw(0x2);                               /* push 0x2 */
            ii(0x17_63ff, 3); lea(ax, bp - 0xe);                        /* lea ax, [bp-0xe] */
            ii(0x17_6402, 1); pushw(ss);                                /* push ss */
            ii(0x17_6403, 1); pushw(ax);                                /* push ax */
            ii(0x17_6404, 1); nop();                                    /* nop */
            ii(0x17_6405, 1); pushw(cs);                                /* push cs */
            ii(0x17_6406, 3); callw(0x17_dd7a, 0x7971);                 /* call 0xdd7a */
            ii(0x17_6409, 2); jmpw(0x17_63e7, -0x24); goto l_0x17_63e7; /* jmp 0x63e7 */
        //  ii(0x17_640b, 1); Недостижимый код.
        l_0x17_640c:
            ii(0x17_640c, 3); mov(dx, memw_a16[ss, bp - 0x4]);          /* mov dx, [bp-0x4] */
            ii(0x17_640f, 3); mov(bx, memw_a16[ss, bp - 0x2]);          /* mov bx, [bp-0x2] */
            ii(0x17_6412, 3); shl(bx, 0x3);                             /* shl bx, 0x3 */
            ii(0x17_6415, 4); mov(memw_a16[ds, bx + 0xba], ax);         /* mov [bx+0xba], ax */
            ii(0x17_6419, 4); mov(memw_a16[ds, bx + 0xbc], dx);         /* mov [bx+0xbc], dx */
            ii(0x17_641d, 3); mov(cx, memw_a16[ss, bp - 0xe]);          /* mov cx, [bp-0xe] */
            ii(0x17_6420, 4); mov(memw_a16[ds, bx + 0xb8], cx);         /* mov [bx+0xb8], cx */
            ii(0x17_6424, 3); mov(cx, memw_a16[ss, bp - 0x14]);         /* mov cx, [bp-0x14] */
            ii(0x17_6427, 4); mov(memw_a16[ds, bx + 0xbe], cx);         /* mov [bx+0xbe], cx */
            ii(0x17_642b, 1); pushw(dx);                                /* push dx */
            ii(0x17_642c, 1); pushw(ax);                                /* push ax */
            ii(0x17_642d, 3); pushw(memw_a16[ss, bp - 0xc]);            /* push word [bp-0xc] */
            ii(0x17_6430, 3); pushw(memw_a16[ss, bp - 0xe]);            /* push word [bp-0xe] */
            ii(0x17_6433, 1); pushw(ds);                                /* push ds */
            ii(0x17_6434, 3); pushw(0x390);                             /* push 0x390 */
            ii(0x17_6437, 1); nop();                                    /* nop */
            ii(0x17_6438, 1); pushw(cs);                                /* push cs */
            ii(0x17_6439, 3); callw(0x17_104f, -0x53ed);                /* call 0x104f */
            ii(0x17_643c, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x17_643f, 5); mov(memw_a16[ss, bp - 0x2a], 0);          /* mov word [bp-0x2a], 0x0 */
            ii(0x17_6444, 2); jmpw(0x17_6452, 0xc); goto l_0x17_6452;   /* jmp 0x6452 */
        l_0x17_6446:
            ii(0x17_6446, 3); inc(memw_a16[ss, bp - 0x2a]);             /* inc word [bp-0x2a] */
            ii(0x17_6449, 5); add(memw_a16[ss, bp - 0x6], 0x1000);      /* add word [bp-0x6], 0x1000 */
            ii(0x17_644e, 4); adc(memw_a16[ss, bp - 0x4], 0);           /* adc word [bp-0x4], 0x0 */
        l_0x17_6452:
            ii(0x17_6452, 3); mov(ax, memw_a16[ss, bp - 0x2a]);         /* mov ax, [bp-0x2a] */
            ii(0x17_6455, 1); cwd();                                    /* cwd */
            ii(0x17_6456, 3); cmp(dx, memw_a16[ss, bp - 0xc]);          /* cmp dx, [bp-0xc] */
            ii(0x17_6459, 2); if(jgw(0x17_64d2, 0x77)) goto l_0x17_64d2; /* jg 0x64d2 */
            ii(0x17_645b, 2); if(jlw(0x17_6462, 0x5)) goto l_0x17_6462; /* jl 0x6462 */
            ii(0x17_645d, 3); cmp(ax, memw_a16[ss, bp - 0xe]);          /* cmp ax, [bp-0xe] */
            ii(0x17_6460, 2); if(jaew(0x17_64d2, 0x70)) goto l_0x17_64d2; /* jae 0x64d2 */
        l_0x17_6462:
            ii(0x17_6462, 4); cmp(memw_a16[ss, bp - 0x2c], 0);          /* cmp word [bp-0x2c], 0x0 */
            ii(0x17_6466, 2); if(jzw(0x17_6496, 0x2e)) goto l_0x17_6496; /* jz 0x6496 */
            ii(0x17_6468, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x17_646b, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x17_646e, 1); pushw(cs);                                /* push cs */
            ii(0x17_646f, 3); callw(0x17_567a, -0xdf8);                 /* call 0x567a */
            ii(0x17_6472, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_6475, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x17_6477, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x17_6479, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x17_647b, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_647d, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_647f, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_6481, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_6483, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_6485, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_6487, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_6489, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_648b, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_648d, 3); mov(memw_a16[ss, bp - 0x30], ax);         /* mov [bp-0x30], ax */
            ii(0x17_6490, 3); mov(memw_a16[ss, bp - 0x2e], dx);         /* mov [bp-0x2e], dx */
            ii(0x17_6493, 2); jmpw(0x17_64ba, 0x25); goto l_0x17_64ba;  /* jmp 0x64ba */
        //  ii(0x17_6495, 1); Недостижимый код.
        l_0x17_6496:
            ii(0x17_6496, 3); mov(ax, memw_a16[ss, bp - 0x6]);          /* mov ax, [bp-0x6] */
            ii(0x17_6499, 3); mov(dx, memw_a16[ss, bp - 0x4]);          /* mov dx, [bp-0x4] */
            ii(0x17_649c, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x17_649e, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x17_64a0, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x17_64a2, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_64a4, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_64a6, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_64a8, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_64aa, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_64ac, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_64ae, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_64b0, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_64b2, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_64b4, 3); mov(memw_a16[ss, bp - 0x30], ax);         /* mov [bp-0x30], ax */
            ii(0x17_64b7, 3); mov(memw_a16[ss, bp - 0x2e], dx);         /* mov [bp-0x2e], dx */
        l_0x17_64ba:
            ii(0x17_64ba, 3); mov(bx, memw_a16[ss, bp - 0x14]);         /* mov bx, [bp-0x14] */
            ii(0x17_64bd, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x17_64c0, 4); les(si, ds, 0x4fa0);                      /* les si, [0x4fa0] */
            ii(0x17_64c4, 3); mov(memw_a16[es, bx + si], ax);           /* mov [es:bx+si], ax */
            ii(0x17_64c7, 4); mov(memw_a16[es, bx + si + 0x2], dx);     /* mov [es:bx+si+0x2], dx */
            ii(0x17_64cb, 3); inc(memw_a16[ss, bp - 0x14]);             /* inc word [bp-0x14] */
            ii(0x17_64ce, 3); jmpw(0x17_6446, -0x8b); goto l_0x17_6446; /* jmp 0x6446 */
        //  ii(0x17_64d1, 1); Недостижимый код.
        l_0x17_64d2:
            ii(0x17_64d2, 3); mov(ax, memw_a16[ss, bp - 0xe]);          /* mov ax, [bp-0xe] */
            ii(0x17_64d5, 4); add(memw_a16[ds, 0x519e], ax);            /* add [0x519e], ax */
            ii(0x17_64d9, 3); mov(dx, memw_a16[ss, bp - 0xc]);          /* mov dx, [bp-0xc] */
            ii(0x17_64dc, 4); add(memw_a16[ds, 0x1fc0], ax);            /* add [0x1fc0], ax */
            ii(0x17_64e0, 4); adc(memw_a16[ds, 0x1fc2], dx);            /* adc [0x1fc2], dx */
            ii(0x17_64e4, 3); sub(memw_a16[ss, bp + 0x6], ax);          /* sub [bp+0x6], ax */
            ii(0x17_64e7, 3); sbb(memw_a16[ss, bp + 0x8], dx);          /* sbb [bp+0x8], dx */
            ii(0x17_64ea, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x17_64ed, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x17_64f0, 3); mov(memw_a16[ss, bp - 0xe], ax);          /* mov [bp-0xe], ax */
            ii(0x17_64f3, 3); mov(memw_a16[ss, bp - 0xc], dx);          /* mov [bp-0xc], dx */
            ii(0x17_64f6, 3); inc(memw_a16[ss, bp - 0x2]);              /* inc word [bp-0x2] */
            ii(0x17_64f9, 3); jmpw(0x17_63cf, -0x12d); goto l_0x17_63cf; /* jmp 0x63cf */
        l_0x17_64fc:
            ii(0x17_64fc, 1); pushw(ds);                                /* push ds */
            ii(0x17_64fd, 3); pushw(0x3aa);                             /* push 0x3aa */
            ii(0x17_6500, 1); nop();                                    /* nop */
            ii(0x17_6501, 1); pushw(cs);                                /* push cs */
            ii(0x17_6502, 3); callw(0x17_104f, -0x54b6);                /* call 0x104f */
            ii(0x17_6505, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_6508, 3); mov(bx, memw_a16[ss, bp - 0x2]);          /* mov bx, [bp-0x2] */
            ii(0x17_650b, 3); shl(bx, 0x3);                             /* shl bx, 0x3 */
            ii(0x17_650e, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_6510, 4); mov(memw_a16[ds, bx + 0xbc], ax);         /* mov [bx+0xbc], ax */
            ii(0x17_6514, 4); mov(memw_a16[ds, bx + 0xba], ax);         /* mov [bx+0xba], ax */
            ii(0x17_6518, 3); mov(ax, memw_a16[ds, 0x519e]);            /* mov ax, [0x519e] */
            ii(0x17_651b, 3); mov(memw_a16[ds, 0x50bc], ax);            /* mov [0x50bc], ax */
            ii(0x17_651e, 2); pushw(0);                                 /* push 0x0 */
            ii(0x17_6520, 2); pushw(0x4);                               /* push 0x4 */
            ii(0x17_6522, 4); pushw(memw_a16[ds, 0x36]);                /* push word [0x36] */
            ii(0x17_6526, 4); pushw(memw_a16[ds, 0x34]);                /* push word [0x34] */
            ii(0x17_652a, 1); nop();                                    /* nop */
            ii(0x17_652b, 1); pushw(cs);                                /* push cs */
            ii(0x17_652c, 3); callw(0x17_dddc, 0x78ad);                 /* call 0xdddc */
            ii(0x17_652f, 4); mov(cx, memw_a16[ds, 0x50bc]);            /* mov cx, [0x50bc] */
            ii(0x17_6533, 2); sub(bx, bx);                              /* sub bx, bx */
            ii(0x17_6535, 2); cmp(bx, dx);                              /* cmp bx, dx */
            ii(0x17_6537, 2); if(jgw(0x17_6550, 0x17)) goto l_0x17_6550; /* jg 0x6550 */
            ii(0x17_6539, 2); if(jlw(0x17_653f, 0x4)) goto l_0x17_653f; /* jl 0x653f */
            ii(0x17_653b, 2); cmp(cx, ax);                              /* cmp cx, ax */
            ii(0x17_653d, 2); if(jaew(0x17_6550, 0x11)) goto l_0x17_6550; /* jae 0x6550 */
        l_0x17_653f:
            ii(0x17_653f, 3); pushw(0x90e);                             /* push 0x90e */
            ii(0x17_6542, 1); pushw(cs);                                /* push cs */
            ii(0x17_6543, 3); callw(0x17_75b4, 0x106e);                 /* call 0x75b4 */
            ii(0x17_6546, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x17_6549, 3); mov(ax, 0xffff);                          /* mov ax, 0xffff */
            ii(0x17_654c, 1); popw(ds);                                 /* pop ds */
            ii(0x17_654d, 1); popw(si);                                 /* pop si */
            ii(0x17_654e, 1); leavew();                                 /* leave */
            ii(0x17_654f, 1); retfw(); return;                          /* retf */
        l_0x17_6550:
            ii(0x17_6550, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_6552, 1); popw(ds);                                 /* pop ds */
            ii(0x17_6553, 1); popw(si);                                 /* pop si */
            ii(0x17_6554, 1); leavew();                                 /* leave */
            ii(0x17_6555, 1); retfw(); return;                          /* retf */
        }
    }
}
