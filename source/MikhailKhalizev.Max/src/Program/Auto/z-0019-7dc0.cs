using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_7dc0-8c3521ec")]
        public void Method_0019_7dc0()
        {
            ii(0x19_7dc0, 4); enterw(0x6, 0);                           /* enter 0x6, 0x0 */
            ii(0x19_7dc4, 1); pushw(di);                                /* push di */
            ii(0x19_7dc5, 1); pushw(si);                                /* push si */
            ii(0x19_7dc6, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
            ii(0x19_7dcb, 4); cmp(memw_a16[ss, bp + 0x8], 0x1);         /* cmp word [bp+0x8], 0x1 */
            ii(0x19_7dcf, 2); if(jzw(0x19_7dd4, 0x3)) goto l_0x19_7dd4; /* jz 0x7dd4 */
            ii(0x19_7dd1, 3); jmpw(0x19_7de4, 0x10); goto l_0x19_7de4;  /* jmp 0x7de4 */
        l_0x19_7dd4:
            ii(0x19_7dd4, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_7dd6, 3); mov(al, memb_a16[ss, bp + 0x6]);          /* mov al, [bp+0x6] */
            ii(0x19_7dd9, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x19_7ddb, 1); pushw(ax);                                /* push ax */
            ii(0x19_7ddc, 1); nop();                                    /* nop */
            ii(0x19_7ddd, 1); pushw(cs);                                /* push cs */
            ii(0x19_7dde, 3); callw(0x19_606f, -0x1d72);                /* call 0x606f */
            ii(0x19_7de1, 3); add(sp, 0x4);                             /* add sp, 0x4 */
        l_0x19_7de4:
            ii(0x19_7de4, 4); mov(es, memw_a16[ds, 0x3faa]);            /* mov es, [0x3faa] */
            ii(0x19_7de8, 3); mov(bx, memw_a16[ss, bp + 0x6]);          /* mov bx, [bp+0x6] */
            ii(0x19_7deb, 5); mov(al, memb_a16[es, bx + 0x2]);          /* mov al, [es:bx+0x2] */
            ii(0x19_7df0, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x19_7df2, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x19_7df4, 3); mov(al, memb_a16[ss, bp + 0x8]);          /* mov al, [bp+0x8] */
            ii(0x19_7df7, 3); mov(bx, memw_a16[ss, bp + 0x6]);          /* mov bx, [bp+0x6] */
            ii(0x19_7dfa, 5); mov(memb_a16[es, bx + 0x2], al);          /* mov [es:bx+0x2], al */
            ii(0x19_7dff, 3); jmpw(0x19_7e10, 0xe); goto l_0x19_7e10;   /* jmp 0x7e10 */
        l_0x19_7e02:
            ii(0x19_7e02, 3); les(bx, ss, bp - 0x6);                    /* les bx, [bp-0x6] */
            ii(0x19_7e05, 4); mov(al, memb_a16[es, bx + 0x1]);          /* mov al, [es:bx+0x1] */
            ii(0x19_7e09, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x19_7e0b, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x19_7e0d, 3); inc(memw_a16[ss, bp - 0x2]);              /* inc word [bp-0x2] */
        l_0x19_7e10:
            ii(0x19_7e10, 3); cmp(memw_a16[ss, bp + 0x8], si);          /* cmp [bp+0x8], si */
            ii(0x19_7e13, 2); if(jnzw(0x19_7e18, 0x3)) goto l_0x19_7e18; /* jnz 0x7e18 */
            ii(0x19_7e15, 3); jmpw(0x19_7e40, 0x28); goto l_0x19_7e40;  /* jmp 0x7e40 */
        l_0x19_7e18:
            ii(0x19_7e18, 4); mov(es, memw_a16[ds, 0x3fa2]);            /* mov es, [0x3fa2] */
            ii(0x19_7e1c, 4); mov(ax, memw_a16[es, 0x122]);             /* mov ax, [es:0x122] */
            ii(0x19_7e20, 5); mov(dx, memw_a16[es, 0x124]);             /* mov dx, [es:0x124] */
            ii(0x19_7e25, 2); mov(cx, si);                              /* mov cx, si */
            ii(0x19_7e27, 3); shl(cx, 0x3);                             /* shl cx, 0x3 */
            ii(0x19_7e2a, 2); add(ax, cx);                              /* add ax, cx */
            ii(0x19_7e2c, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x19_7e2f, 3); mov(memw_a16[ss, bp - 0x4], dx);          /* mov [bp-0x4], dx */
            ii(0x19_7e32, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x19_7e35, 5); callw_far_abs(0x80, 0xce0);               /* call word 0x80:0xce0 */
            ii(0x19_7e3a, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x19_7e3d, 3); jmpw(0x19_7e02, -0x3e); goto l_0x19_7e02; /* jmp 0x7e02 */
        l_0x19_7e40:
            ii(0x19_7e40, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x19_7e43, 3); jmpw(0x19_7e46, 0); goto l_0x19_7e46;     /* jmp 0x7e46 */
        l_0x19_7e46:
            ii(0x19_7e46, 1); popw(si);                                 /* pop si */
            ii(0x19_7e47, 1); popw(di);                                 /* pop di */
            ii(0x19_7e48, 1); leavew();                                 /* leave */
            ii(0x19_7e49, 1); retfw(); return;                          /* retf */
        }
    }
}
