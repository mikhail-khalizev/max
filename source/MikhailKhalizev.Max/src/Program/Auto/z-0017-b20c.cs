using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_b20c-99ee7ab5")]
        public void Method_0017_b20c()
        {
            ii(0x17_b20c, 4); enterw(0x22, 0);                          /* enter 0x22, 0x0 */
            ii(0x17_b210, 1); pushw(di);                                /* push di */
            ii(0x17_b211, 1); pushw(si);                                /* push si */
            ii(0x17_b212, 1); pushw(ds);                                /* push ds */
            ii(0x17_b213, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_b216, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_b218, 5); mov(memw_a16[ss, bp - 0x20], 0);          /* mov word [bp-0x20], 0x0 */
            ii(0x17_b21d, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_b220, 4); mov(ax, memw_a16[es, bx + 0x8]);          /* mov ax, [es:bx+0x8] */
            ii(0x17_b224, 4); mov(cx, memw_a16[es, bx + 0x4]);          /* mov cx, [es:bx+0x4] */
            ii(0x17_b228, 2); mov(dx, cx);                              /* mov dx, cx */
            ii(0x17_b22a, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x17_b22c, 3); mov(memw_a16[ss, bp - 0x1e], dx);         /* mov [bp-0x1e], dx */
            ii(0x17_b22f, 3); mov(memw_a16[ss, bp - 0x1c], bx);         /* mov [bp-0x1c], bx */
            ii(0x17_b232, 2); mov(si, dx);                              /* mov si, dx */
            ii(0x17_b234, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x17_b236, 2); mov(dx, bx);                              /* mov dx, bx */
            ii(0x17_b238, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x17_b23a, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x17_b23c, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x17_b23e, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_b240, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_b242, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_b244, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_b246, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_b248, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_b24a, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_b24c, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_b24e, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_b250, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x17_b253, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x17_b256, 4); test(cx, 0xfff);                          /* test cx, 0xfff */
            ii(0x17_b25a, 2); if(jzw(0x17_b268, 0xc)) goto l_0x17_b268; /* jz 0xb268 */
            ii(0x17_b25c, 3); add(ax, 0x1);                             /* add ax, 0x1 */
            ii(0x17_b25f, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x17_b262, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x17_b265, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
        l_0x17_b268:
            ii(0x17_b268, 3); mov(bx, memw_a16[ss, bp + 0x6]);          /* mov bx, [bp+0x6] */
            ii(0x17_b26b, 4); mov(ax, memw_a16[es, bx + 0x14]);         /* mov ax, [es:bx+0x14] */
            ii(0x17_b26f, 2); sub(cx, cx);                              /* sub cx, cx */
            ii(0x17_b271, 4); add(cx, memw_a16[es, bx + 0x1c]);         /* add cx, [es:bx+0x1c] */
            ii(0x17_b275, 3); adc(ax, 0);                               /* adc ax, 0x0 */
            ii(0x17_b278, 3); mov(memw_a16[ss, bp - 0x8], cx);          /* mov [bp-0x8], cx */
            ii(0x17_b27b, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x17_b27e, 1); pushw(ax);                                /* push ax */
            ii(0x17_b27f, 1); pushw(cx);                                /* push cx */
            ii(0x17_b280, 1); pushw(dx);                                /* push dx */
            ii(0x17_b281, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x17_b284, 1); pushw(ds);                                /* push ds */
            ii(0x17_b285, 3); pushw(0x13b3);                            /* push 0x13b3 */
            ii(0x17_b288, 1); nop();                                    /* nop */
            ii(0x17_b289, 1); pushw(cs);                                /* push cs */
            ii(0x17_b28a, 3); callw(0x18_104f, 0x5dc2);                 /* call 0x104f */
            ii(0x17_b28d, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x17_b290, 5); cmp(memw_a16[ss, bp - 0x6], 0x1000);      /* cmp word [bp-0x6], 0x1000 */
            ii(0x17_b295, 2); if(jbw(0x17_b2b3, 0x1c)) goto l_0x17_b2b3; /* jb 0xb2b3 */
            ii(0x17_b297, 2); if(jaw(0x17_b299, 0)) goto l_0x17_b299;   /* ja 0xb299 */
        l_0x17_b299:
            ii(0x17_b299, 3); mov(ax, memw_a16[ss, bp - 0x8]);          /* mov ax, [bp-0x8] */
            ii(0x17_b29c, 3); mov(dx, memw_a16[ss, bp - 0x6]);          /* mov dx, [bp-0x6] */
            ii(0x17_b29f, 3); add(ax, memw_a16[ss, bp - 0x1e]);         /* add ax, [bp-0x1e] */
            ii(0x17_b2a2, 3); adc(dx, memw_a16[ss, bp - 0x1c]);         /* adc dx, [bp-0x1c] */
            ii(0x17_b2a5, 4); cmp(dx, memw_a16[ds, 0x4fda]);            /* cmp dx, [0x4fda] */
            ii(0x17_b2a9, 2); if(jbw(0x17_b2cc, 0x21)) goto l_0x17_b2cc; /* jb 0xb2cc */
            ii(0x17_b2ab, 2); if(jaw(0x17_b2b3, 0x6)) goto l_0x17_b2b3; /* ja 0xb2b3 */
            ii(0x17_b2ad, 4); cmp(ax, memw_a16[ds, 0x4fd8]);            /* cmp ax, [0x4fd8] */
            ii(0x17_b2b1, 2); if(jbew(0x17_b2cc, 0x19)) goto l_0x17_b2cc; /* jbe 0xb2cc */
        l_0x17_b2b3:
            ii(0x17_b2b3, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_b2b6, 5); or(memb_a16[es, bx + 0x2c], 0x1);         /* or byte [es:bx+0x2c], 0x1 */
            ii(0x17_b2bb, 6); mov(memw_a16[es, bx + 0x20], 0x8025);     /* mov word [es:bx+0x20], 0x8025 */
            ii(0x17_b2c1, 6); mov(memw_a16[es, bx + 0x22], 0);          /* mov word [es:bx+0x22], 0x0 */
            ii(0x17_b2c7, 1); popw(ds);                                 /* pop ds */
            ii(0x17_b2c8, 1); popw(si);                                 /* pop si */
            ii(0x17_b2c9, 1); popw(di);                                 /* pop di */
            ii(0x17_b2ca, 1); leavew();                                 /* leave */
            ii(0x17_b2cb, 1); retfw(); return;                          /* retf */
        l_0x17_b2cc:
            ii(0x17_b2cc, 3); mov(ax, memw_a16[ss, bp - 0x8]);          /* mov ax, [bp-0x8] */
            ii(0x17_b2cf, 3); mov(dx, memw_a16[ss, bp - 0x6]);          /* mov dx, [bp-0x6] */
            ii(0x17_b2d2, 3); sub(ax, 0);                               /* sub ax, 0x0 */
            ii(0x17_b2d5, 4); sbb(dx, 0x1000);                          /* sbb dx, 0x1000 */
            ii(0x17_b2d9, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x17_b2db, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x17_b2dd, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x17_b2df, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_b2e1, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_b2e3, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_b2e5, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_b2e7, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_b2e9, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_b2eb, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_b2ed, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_b2ef, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_b2f1, 3); mov(memw_a16[ss, bp - 0x14], ax);         /* mov [bp-0x14], ax */
            ii(0x17_b2f4, 3); mov(memw_a16[ss, bp - 0x12], dx);         /* mov [bp-0x12], dx */
            ii(0x17_b2f7, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_b2f9, 3); mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x17_b2fc, 3); mov(memw_a16[ss, bp - 0x18], ax);         /* mov [bp-0x18], ax */
            ii(0x17_b2ff, 2); jmpw(0x17_b312, 0x11); goto l_0x17_b312;  /* jmp 0xb312 */
        //  ii(0x17_b301, 1); Недостижимый код.
        l_0x17_b302:
            ii(0x17_b302, 4); add(memw_a16[ss, bp - 0x18], 0x1);        /* add word [bp-0x18], 0x1 */
            ii(0x17_b306, 4); adc(memw_a16[ss, bp - 0x16], 0);          /* adc word [bp-0x16], 0x0 */
            ii(0x17_b30a, 4); add(memw_a16[ss, bp - 0x14], 0x1);        /* add word [bp-0x14], 0x1 */
            ii(0x17_b30e, 4); adc(memw_a16[ss, bp - 0x12], 0);          /* adc word [bp-0x12], 0x0 */
        l_0x17_b312:
            ii(0x17_b312, 3); mov(ax, memw_a16[ss, bp - 0x18]);         /* mov ax, [bp-0x18] */
            ii(0x17_b315, 3); mov(dx, memw_a16[ss, bp - 0x16]);         /* mov dx, [bp-0x16] */
            ii(0x17_b318, 3); cmp(memw_a16[ss, bp - 0x2], dx);          /* cmp [bp-0x2], dx */
            ii(0x17_b31b, 2); if(jaew(0x17_b320, 0x3)) goto l_0x17_b320; /* jae 0xb320 */
            ii(0x17_b31d, 3); jmpw(0x17_b42e, 0x10e); goto l_0x17_b42e; /* jmp 0xb42e */
        l_0x17_b320:
            ii(0x17_b320, 2); if(jaw(0x17_b32a, 0x8)) goto l_0x17_b32a; /* ja 0xb32a */
            ii(0x17_b322, 3); cmp(memw_a16[ss, bp - 0x4], ax);          /* cmp [bp-0x4], ax */
            ii(0x17_b325, 2); if(jaw(0x17_b32a, 0x3)) goto l_0x17_b32a; /* ja 0xb32a */
            ii(0x17_b327, 3); jmpw(0x17_b42e, 0x104); goto l_0x17_b42e; /* jmp 0xb42e */
        l_0x17_b32a:
            ii(0x17_b32a, 3); mov(ax, memw_a16[ss, bp - 0x14]);         /* mov ax, [bp-0x14] */
            ii(0x17_b32d, 3); mov(dx, memw_a16[ss, bp - 0x12]);         /* mov dx, [bp-0x12] */
            ii(0x17_b330, 3); add(ax, 0);                               /* add ax, 0x0 */
            ii(0x17_b333, 3); adc(dx, 0x1);                             /* adc dx, 0x1 */
            ii(0x17_b336, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x17_b339, 3); mov(memw_a16[ss, bp - 0xe], dx);          /* mov [bp-0xe], dx */
            ii(0x17_b33c, 3); pushw(memw_a16[ss, bp - 0x12]);           /* push word [bp-0x12] */
            ii(0x17_b33f, 3); pushw(memw_a16[ss, bp - 0x14]);           /* push word [bp-0x14] */
            ii(0x17_b342, 4); pushw(memw_a16[ds, 0x4ff6]);              /* push word [0x4ff6] */
            ii(0x17_b346, 4); pushw(memw_a16[ds, 0x4ff4]);              /* push word [0x4ff4] */
            ii(0x17_b34a, 3); callw(0x17_90c4, -0x2289);                /* call 0x90c4 */
            ii(0x17_b34d, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_b350, 3); mov(memw_a16[ss, bp - 0x22], ax);         /* mov [bp-0x22], ax */
            ii(0x17_b353, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_b355, 2); if(jnzw(0x17_b35a, 0x3)) goto l_0x17_b35a; /* jnz 0xb35a */
            ii(0x17_b357, 3); jmpw(0x17_b410, 0xb6); goto l_0x17_b410;  /* jmp 0xb410 */
        l_0x17_b35a:
            ii(0x17_b35a, 4); mov(cl, memb_a16[ds, 0x51a6]);            /* mov cl, [0x51a6] */
            ii(0x17_b35e, 2); sub(ch, ch);                              /* sub ch, ch */
            ii(0x17_b360, 2); cmp(ax, cx);                              /* cmp ax, cx */
            ii(0x17_b362, 2); if(jnzw(0x17_b367, 0x3)) goto l_0x17_b367; /* jnz 0xb367 */
            ii(0x17_b364, 3); jmpw(0x17_b410, 0xa9); goto l_0x17_b410;  /* jmp 0xb410 */
        l_0x17_b367:
            ii(0x17_b367, 4); mov(cl, memb_a16[ds, 0x51b5]);            /* mov cl, [0x51b5] */
            ii(0x17_b36b, 2); cmp(ax, cx);                              /* cmp ax, cx */
            ii(0x17_b36d, 2); if(jnzw(0x17_b372, 0x3)) goto l_0x17_b372; /* jnz 0xb372 */
            ii(0x17_b36f, 3); jmpw(0x17_b410, 0x9e); goto l_0x17_b410;  /* jmp 0xb410 */
        l_0x17_b372:
            ii(0x17_b372, 3); pushw(memw_a16[ss, bp - 0x12]);           /* push word [bp-0x12] */
            ii(0x17_b375, 3); pushw(memw_a16[ss, bp - 0x14]);           /* push word [bp-0x14] */
            ii(0x17_b378, 4); pushw(memw_a16[ds, 0x4f8e]);              /* push word [0x4f8e] */
            ii(0x17_b37c, 4); pushw(memw_a16[ds, 0x4f8c]);              /* push word [0x4f8c] */
            ii(0x17_b380, 3); callw(0x17_9208, -0x217b);                /* call 0x9208 */
            ii(0x17_b383, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_b386, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x17_b389, 3); mov(memw_a16[ss, bp - 0xa], dx);          /* mov [bp-0xa], dx */
            ii(0x17_b38c, 4); test(memb_a16[ss, bp - 0xc], 0x1);        /* test byte [bp-0xc], 0x1 */
            ii(0x17_b390, 2); if(jzw(0x17_b40d, 0x7b)) goto l_0x17_b40d; /* jz 0xb40d */
            ii(0x17_b392, 3); pushw(memw_a16[ss, bp - 0xe]);            /* push word [bp-0xe] */
            ii(0x17_b395, 3); pushw(memw_a16[ss, bp - 0x10]);           /* push word [bp-0x10] */
            ii(0x17_b398, 1); nop();                                    /* nop */
            ii(0x17_b399, 1); pushw(cs);                                /* push cs */
            ii(0x17_b39a, 3); callw(0x17_901a, -0x2383);                /* call 0x901a */
            ii(0x17_b39d, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_b3a0, 3); mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x17_b3a3, 4); les(bx, ds, 0x4f9c);                      /* les bx, [0x4f9c] */
            ii(0x17_b3a7, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x17_b3a9, 4); test(memb_a16[es, bx + si], 0x80);        /* test byte [es:bx+si], 0x80 */
            ii(0x17_b3ad, 2); if(jnzw(0x17_b40d, 0x5e)) goto l_0x17_b40d; /* jnz 0xb40d */
            ii(0x17_b3af, 3); mov(ax, memw_a16[ss, bp - 0xc]);          /* mov ax, [bp-0xc] */
            ii(0x17_b3b2, 3); mov(dx, memw_a16[ss, bp - 0xa]);          /* mov dx, [bp-0xa] */
            ii(0x17_b3b5, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x17_b3b7, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x17_b3b9, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x17_b3bb, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_b3bd, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_b3bf, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_b3c1, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_b3c3, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_b3c5, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_b3c7, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_b3c9, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_b3cb, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_b3cd, 1); pushw(dx);                                /* push dx */
            ii(0x17_b3ce, 1); pushw(ax);                                /* push ax */
            ii(0x17_b3cf, 1); nop();                                    /* nop */
            ii(0x17_b3d0, 1); pushw(cs);                                /* push cs */
            ii(0x17_b3d1, 3); callw(0x17_7f3a, -0x349a);                /* call 0x7f3a */
            ii(0x17_b3d4, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_b3d7, 4); and(memb_a16[ss, bp - 0xc], -0x2 /* 0xfe */); /* and byte [bp-0xc], 0xfe */
            ii(0x17_b3db, 3); mov(ax, memw_a16[ss, bp - 0xc]);          /* mov ax, [bp-0xc] */
            ii(0x17_b3de, 3); and(ah, 0xf);                             /* and ah, 0xf */
            ii(0x17_b3e1, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x17_b3e4, 5); mov(memw_a16[ss, bp - 0xa], 0);           /* mov word [bp-0xa], 0x0 */
            ii(0x17_b3e9, 4); and(memb_a16[ss, bp - 0xb], -0xf /* 0xf1 */); /* and byte [bp-0xb], 0xf1 */
            ii(0x17_b3ed, 2); mov(dx, di);                              /* mov dx, di */
            ii(0x17_b3ef, 4); mov(es, memw_a16[ds, 0xaa]);              /* mov es, [0xaa] */
            ii(0x17_b3f3, 5); mov(edi, memd_a16[ds, 0x4f8c]);           /* mov edi, [0x4f8c] */
            ii(0x17_b3f8, 4); mov(ebx, memd_a16[ss, bp - 0x14]);        /* mov ebx, [bp-0x14] */
            ii(0x17_b3fc, 4); mov(eax, memd_a16[ss, bp - 0xc]);         /* mov eax, [bp-0xc] */
            ii(0x17_b400, 6); mov(memd_a32[es, edi + ebx * 4], eax);    /* mov [es:edi+ebx*4], eax */
            ii(0x17_b406, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x17_b408, 5); mov(memw_a16[ss, bp - 0x20], 0x1);        /* mov word [bp-0x20], 0x1 */
        l_0x17_b40d:
            ii(0x17_b40d, 2); jmpw(0x17_b42a, 0x1b); goto l_0x17_b42a;  /* jmp 0xb42a */
        //  ii(0x17_b40f, 1); Недостижимый код.
        l_0x17_b410:
            ii(0x17_b410, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_b413, 5); or(memb_a16[es, bx + 0x2c], 0x1);         /* or byte [es:bx+0x2c], 0x1 */
            ii(0x17_b418, 6); mov(memw_a16[es, bx + 0x20], 0x8025);     /* mov word [es:bx+0x20], 0x8025 */
            ii(0x17_b41e, 6); mov(memw_a16[es, bx + 0x22], 0);          /* mov word [es:bx+0x22], 0x0 */
            ii(0x17_b424, 1); popw(ds);                                 /* pop ds */
            ii(0x17_b425, 1); popw(si);                                 /* pop si */
            ii(0x17_b426, 1); popw(di);                                 /* pop di */
            ii(0x17_b427, 1); leavew();                                 /* leave */
            ii(0x17_b428, 1); retfw(); return;                          /* retf */
        //  ii(0x17_b429, 1); Недостижимый код.
        l_0x17_b42a:
            ii(0x17_b42a, 3); jmpw(0x17_b302, -0x12b); goto l_0x17_b302; /* jmp 0xb302 */
        //  ii(0x17_b42d, 1); Недостижимый код.
        l_0x17_b42e:
            ii(0x17_b42e, 4); cmp(memw_a16[ss, bp - 0x20], 0);          /* cmp word [bp-0x20], 0x0 */
            ii(0x17_b432, 2); if(jzw(0x17_b43a, 0x6)) goto l_0x17_b43a; /* jz 0xb43a */
            ii(0x17_b434, 3); mov(eax, cr3);                            /* mov eax, cr3 */
            ii(0x17_b437, 3); mov(cr3, eax);                            /* mov cr3, eax */
        l_0x17_b43a:
            ii(0x17_b43a, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_b43d, 5); and(memb_a16[es, bx + 0x2c], -0x2 /* 0xfe */); /* and byte [es:bx+0x2c], 0xfe */
            ii(0x17_b442, 1); popw(ds);                                 /* pop ds */
            ii(0x17_b443, 1); popw(si);                                 /* pop si */
            ii(0x17_b444, 1); popw(di);                                 /* pop di */
            ii(0x17_b445, 1); leavew();                                 /* leave */
            ii(0x17_b446, 1); retfw(); return;                          /* retf */
        }
    }
}
