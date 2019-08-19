using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_7f8a-418b256")]
        public void Method_0017_7f8a()
        {
            ii(0x17_7f8a, 4); enterw(0x8, 0);                           /* enter 0x8, 0x0 */
            ii(0x17_7f8e, 1); pushw(di);                                /* push di */
            ii(0x17_7f8f, 1); pushw(si);                                /* push si */
            ii(0x17_7f90, 1); pushw(ds);                                /* push ds */
            ii(0x17_7f91, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_7f94, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_7f96, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x17_7f99, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x17_7f9c, 3); sub(ax, 0);                               /* sub ax, 0x0 */
            ii(0x17_7f9f, 3); sbb(dx, 0x1);                             /* sbb dx, 0x1 */
            ii(0x17_7fa2, 1); pushw(dx);                                /* push dx */
            ii(0x17_7fa3, 1); pushw(ax);                                /* push ax */
            ii(0x17_7fa4, 4); pushw(memw_a16[ds, 0x4f8e]);              /* push word [0x4f8e] */
            ii(0x17_7fa8, 4); pushw(memw_a16[ds, 0x4f8c]);              /* push word [0x4f8c] */
            ii(0x17_7fac, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x17_7fae, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x17_7fb0, 3); callw(0x17_9208, 0x1255);                 /* call 0x9208 */
            ii(0x17_7fb3, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_7fb6, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x17_7fb9, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x17_7fbc, 4); and(memb_a16[ss, bp - 0x4], -0x2 /* 0xfe */); /* and byte [bp-0x4], 0xfe */
            ii(0x17_7fc0, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x17_7fc3, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x17_7fc6, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x17_7fc8, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x17_7fca, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x17_7fcc, 2); sub(al, al);                              /* sub al, al */
            ii(0x17_7fce, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_7fd0, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_7fd2, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_7fd4, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_7fd6, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_7fd8, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_7fda, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_7fdc, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_7fde, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x17_7fe1, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x17_7fe4, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x17_7fe7, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x17_7fea, 1); pushw(di);                                /* push di */
            ii(0x17_7feb, 1); pushw(si);                                /* push si */
            ii(0x17_7fec, 4); pushw(memw_a16[ds, 0x4f8e]);              /* push word [0x4f8e] */
            ii(0x17_7ff0, 4); pushw(memw_a16[ds, 0x4f8c]);              /* push word [0x4f8c] */
            ii(0x17_7ff4, 3); callw(0x17_9235, 0x123e);                 /* call 0x9235 */
            ii(0x17_7ff7, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x17_7ffa, 5); cmp(memb_a16[ds, 0x9c], 0);               /* cmp byte [0x9c], 0x0 */
            ii(0x17_7fff, 2); if(jzw(0x17_800e, 0xd)) goto l_0x17_800e; /* jz 0x800e */
            ii(0x17_8001, 4); mov(eax, memd_a16[ss, bp - 0x8]);         /* mov eax, [bp-0x8] */
            ii(0x17_8005, 3); invlpg(memw_a16[ds, bx + si]);            /* invlpg [bx+si] */
            ii(0x17_8008, 1); popw(ds);                                 /* pop ds */
            ii(0x17_8009, 1); popw(si);                                 /* pop si */
            ii(0x17_800a, 1); popw(di);                                 /* pop di */
            ii(0x17_800b, 1); leavew();                                 /* leave */
            ii(0x17_800c, 1); retfw(); return;                          /* retf */
        //  ii(0x17_800d, 1); Недостижимый код.
        l_0x17_800e:
            ii(0x17_800e, 1); nop();                                    /* nop */
            ii(0x17_800f, 1); pushw(cs);                                /* push cs */
            ii(0x17_8010, 3); callw(0x17_8e97, 0xe84);                  /* call 0x8e97 */
            ii(0x17_8013, 1); popw(ds);                                 /* pop ds */
            ii(0x17_8014, 1); popw(si);                                 /* pop si */
            ii(0x17_8015, 1); popw(di);                                 /* pop di */
            ii(0x17_8016, 1); leavew();                                 /* leave */
            ii(0x17_8017, 1); retfw(); return;                          /* retf */
        }
    }
}
