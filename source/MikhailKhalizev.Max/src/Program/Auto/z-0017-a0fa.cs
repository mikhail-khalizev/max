using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_a0fa-11c7b922")]
        public void Method_0017_a0fa()
        {
            ii(0x17_a0fa, 4); enterw(0x26, 0);                          /* enter 0x26, 0x0 */
            ii(0x17_a0fe, 1); pushw(si);                                /* push si */
            ii(0x17_a0ff, 1); pushw(ds);                                /* push ds */
            ii(0x17_a100, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_a103, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_a105, 5); mov(memw_a16[ss, bp - 0xa], 0);           /* mov word [bp-0xa], 0x0 */
            ii(0x17_a10a, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_a10d, 4); mov(ax, memw_a16[es, bx + 0x14]);         /* mov ax, [es:bx+0x14] */
            ii(0x17_a111, 4); mov(dx, memw_a16[es, bx + 0x16]);         /* mov dx, [es:bx+0x16] */
            ii(0x17_a115, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x17_a118, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x17_a11b, 4); mov(ax, memw_a16[es, bx + 0x1c]);         /* mov ax, [es:bx+0x1c] */
            ii(0x17_a11f, 4); mov(dx, memw_a16[es, bx + 0x1e]);         /* mov dx, [es:bx+0x1e] */
            ii(0x17_a123, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x17_a126, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x17_a129, 6); test(memw_a16[es, bx + 0xa], 0xffff);     /* test word [es:bx+0xa], 0xffff */
            ii(0x17_a12f, 2); if(jzw(0x17_a13a, 0x9)) goto l_0x17_a13a; /* jz 0xa13a */
            ii(0x17_a131, 5); mov(memw_a16[ss, bp - 0xa], 0x8023);      /* mov word [bp-0xa], 0x8023 */
            ii(0x17_a136, 3); jmpw(0x17_a262, 0x129); goto l_0x17_a262; /* jmp 0xa262 */
        //    ii(0x17_a139, 1); nop();                                    /* nop */
        l_0x17_a13a:
            ii(0x17_a13a, 4); mov(ax, memw_a16[es, bx + 0x8]);          /* mov ax, [es:bx+0x8] */
            ii(0x17_a13e, 3); mov(memw_a16[ss, bp - 0x20], ax);         /* mov [bp-0x20], ax */
            ii(0x17_a141, 1); pushw(ax);                                /* push ax */
            ii(0x17_a142, 1); pushw(cs);                                /* push cs */
            ii(0x17_a143, 3); callw(0x17_c79c, 0x2656);                 /* call 0xc79c */
            ii(0x17_a146, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x17_a149, 3); mov(memw_a16[ss, bp - 0xe], ax);          /* mov [bp-0xe], ax */
            ii(0x17_a14c, 3); mov(memw_a16[ss, bp - 0xc], dx);          /* mov [bp-0xc], dx */
            ii(0x17_a14f, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x17_a152, 2); if(jnzw(0x17_a160, 0xc)) goto l_0x17_a160; /* jnz 0xa160 */
            ii(0x17_a154, 2); cmp(dx, ax);                              /* cmp dx, ax */
            ii(0x17_a156, 2); if(jnzw(0x17_a160, 0x8)) goto l_0x17_a160; /* jnz 0xa160 */
            ii(0x17_a158, 5); mov(memw_a16[ss, bp - 0xa], 0x8023);      /* mov word [bp-0xa], 0x8023 */
            ii(0x17_a15d, 3); jmpw(0x17_a262, 0x102); goto l_0x17_a262; /* jmp 0xa262 */
        l_0x17_a160:
            ii(0x17_a160, 3); mov(ax, memw_a16[ss, bp - 0x8]);          /* mov ax, [bp-0x8] */
            ii(0x17_a163, 3); mov(dx, memw_a16[ss, bp - 0x6]);          /* mov dx, [bp-0x6] */
            ii(0x17_a166, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x17_a168, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x17_a16a, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x17_a16c, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_a16e, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_a170, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_a172, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_a174, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_a176, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_a178, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_a17a, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_a17c, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_a17e, 3); add(memw_a16[ss, bp - 0xe], ax);          /* add [bp-0xe], ax */
            ii(0x17_a181, 3); adc(memw_a16[ss, bp - 0xc], dx);          /* adc [bp-0xc], dx */
            ii(0x17_a184, 3); mov(ax, memw_a16[ss, bp - 0xe]);          /* mov ax, [bp-0xe] */
            ii(0x17_a187, 3); mov(dx, memw_a16[ss, bp - 0xc]);          /* mov dx, [bp-0xc] */
            ii(0x17_a18a, 3); add(ax, 0);                               /* add ax, 0x0 */
            ii(0x17_a18d, 3); adc(dx, 0x1);                             /* adc dx, 0x1 */
            ii(0x17_a190, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x17_a192, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x17_a194, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x17_a196, 2); sub(al, al);                              /* sub al, al */
            ii(0x17_a198, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_a19a, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_a19c, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_a19e, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_a1a0, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_a1a2, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_a1a4, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_a1a6, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_a1a8, 3); mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0x17_a1ab, 3); mov(memw_a16[ss, bp - 0x10], dx);         /* mov [bp-0x10], dx */
            ii(0x17_a1ae, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_a1b1, 5); and(memb_a16[es, bx + 0x2c], -0x2 /* 0xfe */); /* and byte [es:bx+0x2c], 0xfe */
            ii(0x17_a1b6, 4); pushw(memw_a16[es, bx + 0x1a]);           /* push word [es:bx+0x1a] */
            ii(0x17_a1ba, 4); pushw(memw_a16[es, bx + 0x18]);           /* push word [es:bx+0x18] */
            ii(0x17_a1be, 4); pushw(memw_a16[es, bx + 0x2]);            /* push word [es:bx+0x2] */
            ii(0x17_a1c2, 1); nop();                                    /* nop */
            ii(0x17_a1c3, 1); pushw(cs);                                /* push cs */
            ii(0x17_a1c4, 3); callw(0x17_4860, -0x5967);                /* call 0x4860 */
            ii(0x17_a1c7, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x17_a1ca, 5); mov(memw_a16[ss, bp - 0x1e], 0);          /* mov word [bp-0x1e], 0x0 */
            ii(0x17_a1cf, 3); mov(memw_a16[ss, bp - 0x1c], ax);         /* mov [bp-0x1c], ax */
        l_0x17_a1d2:
            ii(0x17_a1d2, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x17_a1d5, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x17_a1d8, 4); sub(memw_a16[ss, bp - 0x4], 0x1);         /* sub word [bp-0x4], 0x1 */
            ii(0x17_a1dc, 4); sbb(memw_a16[ss, bp - 0x2], 0);           /* sbb word [bp-0x2], 0x0 */
            ii(0x17_a1e0, 2); or(dx, dx);                               /* or dx, dx */
            ii(0x17_a1e2, 2); if(jnzw(0x17_a1e8, 0x4)) goto l_0x17_a1e8; /* jnz 0xa1e8 */
            ii(0x17_a1e4, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_a1e6, 2); if(jzw(0x17_a262, 0x7a)) goto l_0x17_a262; /* jz 0xa262 */
        l_0x17_a1e8:
            ii(0x17_a1e8, 3); pushw(memw_a16[ss, bp - 0xc]);            /* push word [bp-0xc] */
            ii(0x17_a1eb, 3); pushw(memw_a16[ss, bp - 0xe]);            /* push word [bp-0xe] */
            ii(0x17_a1ee, 4); pushw(memw_a16[ds, 0x4f8e]);              /* push word [0x4f8e] */
            ii(0x17_a1f2, 4); pushw(memw_a16[ds, 0x4f8c]);              /* push word [0x4f8c] */
            ii(0x17_a1f6, 3); callw(0x17_9208, -0xff1);                 /* call 0x9208 */
            ii(0x17_a1f9, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_a1fc, 3); mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x17_a1ff, 3); mov(memw_a16[ss, bp - 0x18], dx);         /* mov [bp-0x18], dx */
            ii(0x17_a202, 3); mov(si, 0x18);                            /* mov si, 0x18 */
            ii(0x17_a205, 3); pushw(memw_a16[ss, bp - 0xc]);            /* push word [bp-0xc] */
            ii(0x17_a208, 3); pushw(memw_a16[ss, bp - 0xe]);            /* push word [bp-0xe] */
            ii(0x17_a20b, 4); pushw(memw_a16[ds, 0x1fa6]);              /* push word [0x1fa6] */
            ii(0x17_a20f, 4); pushw(memw_a16[ds, 0x1fa4]);              /* push word [0x1fa4] */
            ii(0x17_a213, 3); callw(0x17_90c4, -0x1152);                /* call 0x90c4 */
            ii(0x17_a216, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_a219, 3); mov(memw_a16[ss, bp - 0x22], ax);         /* mov [bp-0x22], ax */
            ii(0x17_a21c, 3); mov(al, memb_a16[ds, 0x51a6]);            /* mov al, [0x51a6] */
            ii(0x17_a21f, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x17_a221, 3); cmp(ax, memw_a16[ss, bp - 0x22]);         /* cmp ax, [bp-0x22] */
            ii(0x17_a224, 2); if(jnzw(0x17_a22c, 0x6)) goto l_0x17_a22c; /* jnz 0xa22c */
            ii(0x17_a226, 3); mov(si, 0x1a);                            /* mov si, 0x1a */
            ii(0x17_a229, 2); jmpw(0x17_a23b, 0x10); goto l_0x17_a23b;  /* jmp 0xa23b */
        //    ii(0x17_a22b, 1); nop();                                    /* nop */
        l_0x17_a22c:
            ii(0x17_a22c, 3); mov(al, memb_a16[ds, 0x51b5]);            /* mov al, [0x51b5] */
            ii(0x17_a22f, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x17_a231, 3); cmp(ax, memw_a16[ss, bp - 0x22]);         /* cmp ax, [bp-0x22] */
            ii(0x17_a234, 2); if(jnzw(0x17_a238, 0x2)) goto l_0x17_a238; /* jnz 0xa238 */
            ii(0x17_a236, 2); jmpw(0x17_a23b, 0x3); goto l_0x17_a23b;   /* jmp 0xa23b */
        l_0x17_a238:
            ii(0x17_a238, 3); or(si, 0x1);                              /* or si, 0x1 */
        l_0x17_a23b:
            ii(0x17_a23b, 4); test(memb_a16[ss, bp - 0x1a], 0x40);      /* test byte [bp-0x1a], 0x40 */
            ii(0x17_a23f, 2); if(jzw(0x17_a244, 0x3)) goto l_0x17_a244; /* jz 0xa244 */
            ii(0x17_a241, 3); or(si, 0x20);                             /* or si, 0x20 */
        l_0x17_a244:
            ii(0x17_a244, 4); test(memb_a16[ss, bp - 0x1a], 0x20);      /* test byte [bp-0x1a], 0x20 */
            ii(0x17_a248, 2); if(jzw(0x17_a24d, 0x3)) goto l_0x17_a24d; /* jz 0xa24d */
            ii(0x17_a24a, 3); or(si, 0x40);                             /* or si, 0x40 */
        l_0x17_a24d:
            ii(0x17_a24d, 3); les(bx, ss, bp - 0x1e);                   /* les bx, [bp-0x1e] */
            ii(0x17_a250, 4); add(memw_a16[ss, bp - 0x1e], 0x2);        /* add word [bp-0x1e], 0x2 */
            ii(0x17_a254, 3); mov(memw_a16[es, bx], si);                /* mov [es:bx], si */
            ii(0x17_a257, 4); add(memw_a16[ss, bp - 0x16], 0x1);        /* add word [bp-0x16], 0x1 */
            ii(0x17_a25b, 4); adc(memw_a16[ss, bp - 0x14], 0);          /* adc word [bp-0x14], 0x0 */
            ii(0x17_a25f, 3); jmpw(0x17_a1d2, -0x90); goto l_0x17_a1d2; /* jmp 0xa1d2 */
        l_0x17_a262:
            ii(0x17_a262, 4); cmp(memw_a16[ss, bp - 0xa], 0);           /* cmp word [bp-0xa], 0x0 */
            ii(0x17_a266, 2); if(jzw(0x17_a27c, 0x14)) goto l_0x17_a27c; /* jz 0xa27c */
            ii(0x17_a268, 3); mov(ax, memw_a16[ss, bp - 0xa]);          /* mov ax, [bp-0xa] */
            ii(0x17_a26b, 1); cwd();                                    /* cwd */
            ii(0x17_a26c, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_a26f, 4); mov(memw_a16[es, bx + 0x20], ax);         /* mov [es:bx+0x20], ax */
            ii(0x17_a273, 4); mov(memw_a16[es, bx + 0x22], dx);         /* mov [es:bx+0x22], dx */
            ii(0x17_a277, 5); or(memb_a16[es, bx + 0x2c], 0x1);         /* or byte [es:bx+0x2c], 0x1 */
        l_0x17_a27c:
            ii(0x17_a27c, 1); nop();                                    /* nop */
            ii(0x17_a27d, 1); pushw(cs);                                /* push cs */
            ii(0x17_a27e, 3); callw(0x17_488e, -0x59f3);                /* call 0x488e */
            ii(0x17_a281, 1); popw(ds);                                 /* pop ds */
            ii(0x17_a282, 1); popw(si);                                 /* pop si */
            ii(0x17_a283, 1); leavew();                                 /* leave */
            ii(0x17_a284, 1); retfw(); return;                          /* retf */
        }
    }
}
