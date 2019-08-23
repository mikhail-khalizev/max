using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_b040-9a3fc8b0")]
        public void Method_0017_b040()
        {
            ii(0x17_b040, 4); enterw(0x20, 0);                          /* enter 0x20, 0x0 */
            ii(0x17_b044, 1); pushw(si);                                /* push si */
            ii(0x17_b045, 1); pushw(ds);                                /* push ds */
            ii(0x17_b046, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_b049, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_b04b, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_b04e, 4); mov(ax, memw_a16[es, bx + 0x8]);          /* mov ax, [es:bx+0x8] */
            ii(0x17_b052, 2); sub(cx, cx);                              /* sub cx, cx */
            ii(0x17_b054, 4); mov(dx, memw_a16[es, bx + 0x4]);          /* mov dx, [es:bx+0x4] */
            ii(0x17_b058, 2); add(cx, dx);                              /* add cx, dx */
            ii(0x17_b05a, 3); adc(ax, 0);                               /* adc ax, 0x0 */
            ii(0x17_b05d, 3); mov(memw_a16[ss, bp - 0x1e], cx);         /* mov [bp-0x1e], cx */
            ii(0x17_b060, 3); mov(memw_a16[ss, bp - 0x1c], ax);         /* mov [bp-0x1c], ax */
            ii(0x17_b063, 2); mov(bx, cx);                              /* mov bx, cx */
            ii(0x17_b065, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x17_b067, 2); mov(cx, dx);                              /* mov cx, dx */
            ii(0x17_b069, 2); mov(ax, bx);                              /* mov ax, bx */
            ii(0x17_b06b, 2); mov(dx, si);                              /* mov dx, si */
            ii(0x17_b06d, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x17_b06f, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x17_b071, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x17_b073, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_b075, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_b077, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_b079, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_b07b, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_b07d, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_b07f, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_b081, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_b083, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_b085, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x17_b088, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x17_b08b, 4); test(cx, 0xfff);                          /* test cx, 0xfff */
            ii(0x17_b08f, 2); if(jzw(0x17_b09d, 0xc)) goto l_0x17_b09d; /* jz 0xb09d */
            ii(0x17_b091, 3); add(ax, 0x1);                             /* add ax, 0x1 */
            ii(0x17_b094, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x17_b097, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x17_b09a, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
        l_0x17_b09d:
            ii(0x17_b09d, 3); mov(bx, memw_a16[ss, bp + 0x6]);          /* mov bx, [bp+0x6] */
            ii(0x17_b0a0, 4); mov(ax, memw_a16[es, bx + 0x14]);         /* mov ax, [es:bx+0x14] */
            ii(0x17_b0a4, 2); sub(cx, cx);                              /* sub cx, cx */
            ii(0x17_b0a6, 4); add(cx, memw_a16[es, bx + 0x1c]);         /* add cx, [es:bx+0x1c] */
            ii(0x17_b0aa, 3); adc(ax, 0);                               /* adc ax, 0x0 */
            ii(0x17_b0ad, 3); mov(memw_a16[ss, bp - 0x8], cx);          /* mov [bp-0x8], cx */
            ii(0x17_b0b0, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x17_b0b3, 1); pushw(ax);                                /* push ax */
            ii(0x17_b0b4, 1); pushw(cx);                                /* push cx */
            ii(0x17_b0b5, 1); pushw(dx);                                /* push dx */
            ii(0x17_b0b6, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x17_b0b9, 1); pushw(ds);                                /* push ds */
            ii(0x17_b0ba, 3); pushw(0x1391);                            /* push 0x1391 */
            ii(0x17_b0bd, 1); nop();                                    /* nop */
            ii(0x17_b0be, 1); pushw(cs);                                /* push cs */
            ii(0x17_b0bf, 3); callw(0x18_104f, 0x5f8d);                 /* call 0x104f */
            ii(0x17_b0c2, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x17_b0c5, 5); cmp(memw_a16[ss, bp - 0x6], 0x1000);      /* cmp word [bp-0x6], 0x1000 */
            ii(0x17_b0ca, 2); if(jbw(0x17_b0e8, 0x1c)) goto l_0x17_b0e8; /* jb 0xb0e8 */
            ii(0x17_b0cc, 2); if(jaw(0x17_b0ce, 0)) goto l_0x17_b0ce;   /* ja 0xb0ce */
        l_0x17_b0ce:
            ii(0x17_b0ce, 3); mov(ax, memw_a16[ss, bp - 0x8]);          /* mov ax, [bp-0x8] */
            ii(0x17_b0d1, 3); mov(dx, memw_a16[ss, bp - 0x6]);          /* mov dx, [bp-0x6] */
            ii(0x17_b0d4, 3); add(ax, memw_a16[ss, bp - 0x1e]);         /* add ax, [bp-0x1e] */
            ii(0x17_b0d7, 3); adc(dx, memw_a16[ss, bp - 0x1c]);         /* adc dx, [bp-0x1c] */
            ii(0x17_b0da, 4); cmp(dx, memw_a16[ds, 0x4fda]);            /* cmp dx, [0x4fda] */
            ii(0x17_b0de, 2); if(jbw(0x17_b100, 0x20)) goto l_0x17_b100; /* jb 0xb100 */
            ii(0x17_b0e0, 2); if(jaw(0x17_b0e8, 0x6)) goto l_0x17_b0e8; /* ja 0xb0e8 */
            ii(0x17_b0e2, 4); cmp(ax, memw_a16[ds, 0x4fd8]);            /* cmp ax, [0x4fd8] */
            ii(0x17_b0e6, 2); if(jbew(0x17_b100, 0x18)) goto l_0x17_b100; /* jbe 0xb100 */
        l_0x17_b0e8:
            ii(0x17_b0e8, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_b0eb, 5); or(memb_a16[es, bx + 0x2c], 0x1);         /* or byte [es:bx+0x2c], 0x1 */
            ii(0x17_b0f0, 6); mov(memw_a16[es, bx + 0x20], 0x8025);     /* mov word [es:bx+0x20], 0x8025 */
            ii(0x17_b0f6, 6); mov(memw_a16[es, bx + 0x22], 0);          /* mov word [es:bx+0x22], 0x0 */
            ii(0x17_b0fc, 1); popw(ds);                                 /* pop ds */
            ii(0x17_b0fd, 1); popw(si);                                 /* pop si */
            ii(0x17_b0fe, 1); leavew();                                 /* leave */
            ii(0x17_b0ff, 1); retfw(); return;                          /* retf */
        l_0x17_b100:
            ii(0x17_b100, 3); mov(ax, memw_a16[ss, bp - 0x8]);          /* mov ax, [bp-0x8] */
            ii(0x17_b103, 3); mov(dx, memw_a16[ss, bp - 0x6]);          /* mov dx, [bp-0x6] */
            ii(0x17_b106, 3); sub(ax, 0);                               /* sub ax, 0x0 */
            ii(0x17_b109, 4); sbb(dx, 0x1000);                          /* sbb dx, 0x1000 */
            ii(0x17_b10d, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x17_b10f, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x17_b111, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x17_b113, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_b115, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_b117, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_b119, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_b11b, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_b11d, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_b11f, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_b121, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_b123, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_b125, 3); mov(memw_a16[ss, bp - 0x14], ax);         /* mov [bp-0x14], ax */
            ii(0x17_b128, 3); mov(memw_a16[ss, bp - 0x12], dx);         /* mov [bp-0x12], dx */
            ii(0x17_b12b, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_b12d, 3); mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x17_b130, 3); mov(memw_a16[ss, bp - 0x18], ax);         /* mov [bp-0x18], ax */
            ii(0x17_b133, 2); jmpw(0x17_b146, 0x11); goto l_0x17_b146;  /* jmp 0xb146 */
        //  ii(0x17_b135, 1); nop();                                    /* nop */
        l_0x17_b136:
            ii(0x17_b136, 4); add(memw_a16[ss, bp - 0x18], 0x1);        /* add word [bp-0x18], 0x1 */
            ii(0x17_b13a, 4); adc(memw_a16[ss, bp - 0x16], 0);          /* adc word [bp-0x16], 0x0 */
            ii(0x17_b13e, 4); add(memw_a16[ss, bp - 0x14], 0x1);        /* add word [bp-0x14], 0x1 */
            ii(0x17_b142, 4); adc(memw_a16[ss, bp - 0x12], 0);          /* adc word [bp-0x12], 0x0 */
        l_0x17_b146:
            ii(0x17_b146, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x17_b149, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x17_b14c, 3); cmp(memw_a16[ss, bp - 0x16], dx);         /* cmp [bp-0x16], dx */
            ii(0x17_b14f, 2); if(jbew(0x17_b154, 0x3)) goto l_0x17_b154; /* jbe 0xb154 */
            ii(0x17_b151, 3); jmpw(0x17_b200, 0xac); goto l_0x17_b200;  /* jmp 0xb200 */
        l_0x17_b154:
            ii(0x17_b154, 2); if(jbw(0x17_b15e, 0x8)) goto l_0x17_b15e; /* jb 0xb15e */
            ii(0x17_b156, 3); cmp(memw_a16[ss, bp - 0x18], ax);         /* cmp [bp-0x18], ax */
            ii(0x17_b159, 2); if(jbw(0x17_b15e, 0x3)) goto l_0x17_b15e; /* jb 0xb15e */
            ii(0x17_b15b, 3); jmpw(0x17_b200, 0xa2); goto l_0x17_b200;  /* jmp 0xb200 */
        l_0x17_b15e:
            ii(0x17_b15e, 3); mov(ax, memw_a16[ss, bp - 0x14]);         /* mov ax, [bp-0x14] */
            ii(0x17_b161, 3); mov(dx, memw_a16[ss, bp - 0x12]);         /* mov dx, [bp-0x12] */
            ii(0x17_b164, 3); add(ax, 0);                               /* add ax, 0x0 */
            ii(0x17_b167, 3); adc(dx, 0x1);                             /* adc dx, 0x1 */
            ii(0x17_b16a, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x17_b16d, 3); mov(memw_a16[ss, bp - 0xe], dx);          /* mov [bp-0xe], dx */
            ii(0x17_b170, 3); pushw(memw_a16[ss, bp - 0x12]);           /* push word [bp-0x12] */
            ii(0x17_b173, 3); pushw(memw_a16[ss, bp - 0x14]);           /* push word [bp-0x14] */
            ii(0x17_b176, 4); pushw(memw_a16[ds, 0x4ff6]);              /* push word [0x4ff6] */
            ii(0x17_b17a, 4); pushw(memw_a16[ds, 0x4ff4]);              /* push word [0x4ff4] */
            ii(0x17_b17e, 3); callw(0x17_90c4, -0x20bd);                /* call 0x90c4 */
            ii(0x17_b181, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_b184, 3); mov(memw_a16[ss, bp - 0x20], ax);         /* mov [bp-0x20], ax */
            ii(0x17_b187, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_b189, 2); if(jzw(0x17_b1e4, 0x59)) goto l_0x17_b1e4; /* jz 0xb1e4 */
            ii(0x17_b18b, 4); mov(cl, memb_a16[ds, 0x51a6]);            /* mov cl, [0x51a6] */
            ii(0x17_b18f, 2); sub(ch, ch);                              /* sub ch, ch */
            ii(0x17_b191, 2); cmp(ax, cx);                              /* cmp ax, cx */
            ii(0x17_b193, 2); if(jzw(0x17_b1e4, 0x4f)) goto l_0x17_b1e4; /* jz 0xb1e4 */
            ii(0x17_b195, 4); mov(cl, memb_a16[ds, 0x51b5]);            /* mov cl, [0x51b5] */
            ii(0x17_b199, 2); cmp(ax, cx);                              /* cmp ax, cx */
            ii(0x17_b19b, 2); if(jzw(0x17_b1e4, 0x47)) goto l_0x17_b1e4; /* jz 0xb1e4 */
            ii(0x17_b19d, 3); pushw(memw_a16[ss, bp - 0x12]);           /* push word [bp-0x12] */
            ii(0x17_b1a0, 3); pushw(memw_a16[ss, bp - 0x14]);           /* push word [bp-0x14] */
            ii(0x17_b1a3, 4); pushw(memw_a16[ds, 0x4f8e]);              /* push word [0x4f8e] */
            ii(0x17_b1a7, 4); pushw(memw_a16[ds, 0x4f8c]);              /* push word [0x4f8c] */
            ii(0x17_b1ab, 3); callw(0x17_9208, -0x1fa6);                /* call 0x9208 */
            ii(0x17_b1ae, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_b1b1, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x17_b1b4, 3); mov(memw_a16[ss, bp - 0xa], dx);          /* mov [bp-0xa], dx */
            ii(0x17_b1b7, 4); test(memb_a16[ss, bp - 0xc], 0x1);        /* test byte [bp-0xc], 0x1 */
            ii(0x17_b1bb, 2); if(jzw(0x17_b1e2, 0x25)) goto l_0x17_b1e2; /* jz 0xb1e2 */
            ii(0x17_b1bd, 3); pushw(memw_a16[ss, bp - 0xe]);            /* push word [bp-0xe] */
            ii(0x17_b1c0, 3); pushw(memw_a16[ss, bp - 0x10]);           /* push word [bp-0x10] */
            ii(0x17_b1c3, 1); nop();                                    /* nop */
            ii(0x17_b1c4, 1); pushw(cs);                                /* push cs */
            ii(0x17_b1c5, 3); callw(0x17_901a, -0x21ae);                /* call 0x901a */
            ii(0x17_b1c8, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_b1cb, 3); mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x17_b1ce, 4); les(bx, ds, 0x4f9c);                      /* les bx, [0x4f9c] */
            ii(0x17_b1d2, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x17_b1d4, 3); mov(al, memb_a16[es, bx + si]);           /* mov al, [es:bx+si] */
            ii(0x17_b1d7, 2); and(al, 0x80);                            /* and al, 0x80 */
            ii(0x17_b1d9, 2); if(jnzw(0x17_b1e2, 0x7)) goto l_0x17_b1e2; /* jnz 0xb1e2 */
            ii(0x17_b1db, 3); mov(memb_a16[es, bx + si], al);           /* mov [es:bx+si], al */
            ii(0x17_b1de, 4); and(memb_a16[ss, bp - 0xc], -0x21 /* 0xdf */); /* and byte [bp-0xc], 0xdf */
        l_0x17_b1e2:
            ii(0x17_b1e2, 2); jmpw(0x17_b1fc, 0x18); goto l_0x17_b1fc;  /* jmp 0xb1fc */
        l_0x17_b1e4:
            ii(0x17_b1e4, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_b1e7, 5); or(memb_a16[es, bx + 0x2c], 0x1);         /* or byte [es:bx+0x2c], 0x1 */
            ii(0x17_b1ec, 6); mov(memw_a16[es, bx + 0x20], 0x8025);     /* mov word [es:bx+0x20], 0x8025 */
            ii(0x17_b1f2, 6); mov(memw_a16[es, bx + 0x22], 0);          /* mov word [es:bx+0x22], 0x0 */
            ii(0x17_b1f8, 1); popw(ds);                                 /* pop ds */
            ii(0x17_b1f9, 1); popw(si);                                 /* pop si */
            ii(0x17_b1fa, 1); leavew();                                 /* leave */
            ii(0x17_b1fb, 1); retfw(); return;                          /* retf */
        l_0x17_b1fc:
            ii(0x17_b1fc, 3); jmpw(0x17_b136, -0xc9); goto l_0x17_b136; /* jmp 0xb136 */
        //  ii(0x17_b1ff, 1); nop();                                    /* nop */
        l_0x17_b200:
            ii(0x17_b200, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_b203, 5); and(memb_a16[es, bx + 0x2c], -0x2 /* 0xfe */); /* and byte [es:bx+0x2c], 0xfe */
            ii(0x17_b208, 1); popw(ds);                                 /* pop ds */
            ii(0x17_b209, 1); popw(si);                                 /* pop si */
            ii(0x17_b20a, 1); leavew();                                 /* leave */
            ii(0x17_b20b, 1); retfw();                                  /* retf */
        }
    }
}
