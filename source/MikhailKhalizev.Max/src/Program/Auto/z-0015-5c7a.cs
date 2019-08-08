using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3efed14f-757c-435f-8811-5373cb457e75")]
        public void Method_0015_5c7a()
        {
            ii(0x15_5c7a, 4); enterw(0x14, 0);                          /* enter 0x14, 0x0 */
            ii(0x15_5c7e, 1); pushw(di);                                /* push di */
            ii(0x15_5c7f, 1); pushw(si);                                /* push si */
            ii(0x15_5c80, 3); lea(ax, bp - 0x10);                       /* lea ax, [bp-0x10] */
            ii(0x15_5c83, 1); pushw(ss);                                /* push ss */
            ii(0x15_5c84, 1); pushw(ax);                                /* push ax */
            ii(0x15_5c85, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x15_5c88, 5); callw_far_abs(0x80, 0x4f82);              /* call word 0x80:0x4f82 */
            ii(0x15_5c8d, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_5c90, 3); mov(al, memb_a16[ss, bp - 0xc]);          /* mov al, [bp-0xc] */
            ii(0x15_5c93, 3); mov(ah, memb_a16[ss, bp - 0x9]);          /* mov ah, [bp-0x9] */
            ii(0x15_5c96, 3); mov(cx, memw_a16[ss, bp - 0xe]);          /* mov cx, [bp-0xe] */
            ii(0x15_5c99, 3); mov(memw_a16[ss, bp - 0x8], cx);          /* mov [bp-0x8], cx */
            ii(0x15_5c9c, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x15_5c9f, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x15_5ca2, 1); nop();                                    /* nop */
            ii(0x15_5ca3, 1); pushw(cs);                                /* push cs */
            ii(0x15_5ca4, 3); callw(0x15_100b, -0x4c9c);                /* call 0x100b */
            ii(0x15_5ca7, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x15_5caa, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x15_5cad, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x15_5cb0, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x15_5cb3, 1); nop();                                    /* nop */
            ii(0x15_5cb4, 1); pushw(cs);                                /* push cs */
            ii(0x15_5cb5, 3); callw(0x15_1029, -0x4c8f);                /* call 0x1029 */
            ii(0x15_5cb8, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x15_5cbb, 3); mov(memw_a16[ss, bp - 0x14], ax);         /* mov [bp-0x14], ax */
            ii(0x15_5cbe, 3); mov(memw_a16[ss, bp - 0x12], dx);         /* mov [bp-0x12], dx */
            ii(0x15_5cc1, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x15_5cc4, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x15_5cc7, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x15_5cc9, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x15_5ccb, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x15_5ccd, 2); shl(dh, 0x1);                             /* shl dh, 1 */
            ii(0x15_5ccf, 2); sbb(dh, dh);                              /* sbb dh, dh */
            ii(0x15_5cd1, 1); pushw(ax);                                /* push ax */
            ii(0x15_5cd2, 1); pushw(ds);                                /* push ds */
            ii(0x15_5cd3, 3); pushw(0x1092);                            /* push 0x1092 */
            ii(0x15_5cd6, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x15_5cd9, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x15_5cdc, 1); pushw(ds);                                /* push ds */
            ii(0x15_5cdd, 3); pushw(0x1099);                            /* push 0x1099 */
            ii(0x15_5ce0, 3); pushw(memw_a16[ss, bp - 0x12]);           /* push word [bp-0x12] */
            ii(0x15_5ce3, 3); pushw(memw_a16[ss, bp - 0x14]);           /* push word [bp-0x14] */
            ii(0x15_5ce6, 5); test(memw_a16[ss, bp - 0x2], 0x80);       /* test word [bp-0x2], 0x80 */
            ii(0x15_5ceb, 2); if(jnzw(0x15_5cf0, 0x3)) goto l_0x15_5cf0; /* jnz 0x5cf0 */
            ii(0x15_5ced, 3); jmpw(0x15_5cf6, 0x6); goto l_0x15_5cf6;   /* jmp 0x5cf6 */
        l_0x15_5cf0:
            ii(0x15_5cf0, 3); mov(ax, 0x10a1);                          /* mov ax, 0x10a1 */
            ii(0x15_5cf3, 3); jmpw(0x15_5cf9, 0x3); goto l_0x15_5cf9;   /* jmp 0x5cf9 */
        l_0x15_5cf6:
            ii(0x15_5cf6, 3); mov(ax, 0x10a6);                          /* mov ax, 0x10a6 */
        l_0x15_5cf9:
            ii(0x15_5cf9, 1); pushw(ds);                                /* push ds */
            ii(0x15_5cfa, 1); pushw(ax);                                /* push ax */
            ii(0x15_5cfb, 5); test(memw_a16[ss, bp - 0x2], 0x40);       /* test word [bp-0x2], 0x40 */
            ii(0x15_5d00, 2); if(jnzw(0x15_5d05, 0x3)) goto l_0x15_5d05; /* jnz 0x5d05 */
            ii(0x15_5d02, 3); jmpw(0x15_5d0b, 0x6); goto l_0x15_5d0b;   /* jmp 0x5d0b */
        l_0x15_5d05:
            ii(0x15_5d05, 3); mov(ax, 0x10ab);                          /* mov ax, 0x10ab */
            ii(0x15_5d08, 3); jmpw(0x15_5d0e, 0x3); goto l_0x15_5d0e;   /* jmp 0x5d0e */
        l_0x15_5d0b:
            ii(0x15_5d0b, 3); mov(ax, 0x10b5);                          /* mov ax, 0x10b5 */
        l_0x15_5d0e:
            ii(0x15_5d0e, 1); pushw(ds);                                /* push ds */
            ii(0x15_5d0f, 1); pushw(ax);                                /* push ax */
            ii(0x15_5d10, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x15_5d13, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_5d16, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_5d19, 1); pushw(ds);                                /* push ds */
            ii(0x15_5d1a, 3); pushw(0x10bf);                            /* push 0x10bf */
            ii(0x15_5d1d, 3); callw(0x15_105e, -0x4cc2);                /* call 0x105e */
            ii(0x15_5d20, 3); add(sp, 0x24);                            /* add sp, 0x24 */
            ii(0x15_5d23, 4); cmp(memw_a16[ss, bp + 0x4], 0x34);        /* cmp word [bp+0x4], 0x34 */
            ii(0x15_5d27, 2); if(jzw(0x15_5d2c, 0x3)) goto l_0x15_5d2c; /* jz 0x5d2c */
            ii(0x15_5d29, 3); jmpw(0x15_5d36, 0xa); goto l_0x15_5d36;   /* jmp 0x5d36 */
        l_0x15_5d2c:
            ii(0x15_5d2c, 1); pushw(ds);                                /* push ds */
            ii(0x15_5d2d, 3); pushw(0x10eb);                            /* push 0x10eb */
            ii(0x15_5d30, 3); callw(0x15_105e, -0x4cd5);                /* call 0x105e */
            ii(0x15_5d33, 3); add(sp, 0x4);                             /* add sp, 0x4 */
        l_0x15_5d36:
            ii(0x15_5d36, 1); popw(si);                                 /* pop si */
            ii(0x15_5d37, 1); popw(di);                                 /* pop di */
            ii(0x15_5d38, 1); leavew();                                 /* leave */
            ii(0x15_5d39, 3); retw(0x6); return;                        /* ret 0x6 */
        }
    }
}
