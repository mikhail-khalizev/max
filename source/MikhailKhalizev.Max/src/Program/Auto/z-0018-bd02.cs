using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_bd02-38e6a69")]
        public void Method_0018_bd02()
        {
            ii(0x18_bd02, 4); enter(0xc, 0);                            /* enter 0xc, 0x0 */
            ii(0x18_bd06, 1); push(si);                                 /* push si */
            ii(0x18_bd07, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x18_bd09, 3); mov(memw[ss, bp - 10], ax);               /* mov [bp-0xa], ax */
            ii(0x18_bd0c, 3); mov(memw[ss, bp - 12], ax);               /* mov [bp-0xc], ax */
            ii(0x18_bd0f, 2); sub(si, si);                              /* sub si, si */
            ii(0x18_bd11, 1); cli();                                    /* cli */
            ii(0x18_bd12, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x18_bd14, 3); mov(memw[ds, 0x11fc], ax);                /* mov [0x11fc], ax */
            ii(0x18_bd17, 3); mov(memw[ds, 0x11fa], ax);                /* mov [0x11fa], ax */
            ii(0x18_bd1a, 3); mov(ax, memw[ds, 0x98]);                  /* mov ax, [0x98] */
            ii(0x18_bd1d, 4); mov(dx, memw[ds, 0x9a]);                  /* mov dx, [0x9a] */
            ii(0x18_bd21, 3); mov(memw[ss, bp - 4], ax);                /* mov [bp-0x4], ax */
            ii(0x18_bd24, 3); mov(memw[ss, bp - 2], dx);                /* mov [bp-0x2], dx */
            ii(0x18_bd27, 4); cmp(dx, memw[ds, 0x9e]);                  /* cmp dx, [0x9e] */
            ii(0x18_bd2b, 2); if(ja(0x18_bd98, 0x6b)) goto l_0x18_bd98; /* ja 0xbd98 */
            ii(0x18_bd2d, 2); if(jb(0x18_bd35, 6)) goto l_0x18_bd35;    /* jb 0xbd35 */
            ii(0x18_bd2f, 4); cmp(ax, memw[ds, 0x9c]);                  /* cmp ax, [0x9c] */
            ii(0x18_bd33, 2); if(jae(0x18_bd98, 0x63)) goto l_0x18_bd98; /* jae 0xbd98 */
        l_0x18_bd35:
            ii(0x18_bd35, 3); mov(ax, memw[ss, bp - 2]);                /* mov ax, [bp-0x2] */
            ii(0x18_bd38, 3); or(ax, memw[ss, bp - 4]);                 /* or ax, [bp-0x4] */
            ii(0x18_bd3b, 2); if(jz(0x18_bd98, 0x5b)) goto l_0x18_bd98; /* jz 0xbd98 */
            ii(0x18_bd3d, 2); push(4);                                  /* push 0x4 */
            ii(0x18_bd3f, 3); push(memw[ss, bp - 2]);                   /* push word [bp-0x2] */
            ii(0x18_bd42, 3); push(memw[ss, bp - 4]);                   /* push word [bp-0x4] */
            ii(0x18_bd45, 3); call(0x18_db51, 0x1e09);                  /* call 0xdb51 */
            ii(0x18_bd48, 3); add(sp, 6);                               /* add sp, 0x6 */
            ii(0x18_bd4b, 3); mov(memw[ss, bp - 8], ax);                /* mov [bp-0x8], ax */
            ii(0x18_bd4e, 3); mov(memw[ss, bp - 6], dx);                /* mov [bp-0x6], dx */
            ii(0x18_bd51, 3); add(memw[ss, bp - 12], ax);               /* add [bp-0xc], ax */
            ii(0x18_bd54, 3); adc(memw[ss, bp - 10], dx);               /* adc [bp-0xa], dx */
            ii(0x18_bd57, 4); cmp(dx, memw[ds, 0x11fc]);                /* cmp dx, [0x11fc] */
            ii(0x18_bd5b, 2); if(jb(0x18_bd6c, 0xf)) goto l_0x18_bd6c;  /* jb 0xbd6c */
            ii(0x18_bd5d, 2); if(ja(0x18_bd65, 6)) goto l_0x18_bd65;    /* ja 0xbd65 */
            ii(0x18_bd5f, 4); cmp(ax, memw[ds, 0x11fa]);                /* cmp ax, [0x11fa] */
            ii(0x18_bd63, 2); if(jbe(0x18_bd6c, 7)) goto l_0x18_bd6c;   /* jbe 0xbd6c */
        l_0x18_bd65:
            ii(0x18_bd65, 3); mov(memw[ds, 0x11fa], ax);                /* mov [0x11fa], ax */
            ii(0x18_bd68, 4); mov(memw[ds, 0x11fc], dx);                /* mov [0x11fc], dx */
        l_0x18_bd6c:
            ii(0x18_bd6c, 1); dec(si);                                  /* dec si */
            ii(0x18_bd6d, 2); if(jz(0x18_bd7c, 0xd)) goto l_0x18_bd7c;  /* jz 0xbd7c */
            ii(0x18_bd6f, 3); push(memw[ss, bp - 2]);                   /* push word [bp-0x2] */
            ii(0x18_bd72, 3); push(memw[ss, bp - 4]);                   /* push word [bp-0x4] */
            ii(0x18_bd75, 3); call(0x18_bcce, -0xaa);                   /* call 0xbcce */
            ii(0x18_bd78, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x18_bd7a, 2); if(jnz(0x18_bd82, 6)) goto l_0x18_bd82;   /* jnz 0xbd82 */
        l_0x18_bd7c:
            ii(0x18_bd7c, 2); push(0x1c);                               /* push 0x1c */
            ii(0x18_bd7e, 3); call(0x18_d9c5, 0x1c44);                  /* call 0xd9c5 */
            ii(0x18_bd81, 1); pop(bx);                                  /* pop bx */
        l_0x18_bd82:
            ii(0x18_bd82, 2); push(0);                                  /* push 0x0 */
            ii(0x18_bd84, 3); push(memw[ss, bp - 2]);                   /* push word [bp-0x2] */
            ii(0x18_bd87, 3); push(memw[ss, bp - 4]);                   /* push word [bp-0x4] */
            ii(0x18_bd8a, 3); call(0x18_db51, 0x1dc4);                  /* call 0xdb51 */
            ii(0x18_bd8d, 3); add(sp, 6);                               /* add sp, 0x6 */
            ii(0x18_bd90, 3); mov(memw[ss, bp - 4], ax);                /* mov [bp-0x4], ax */
            ii(0x18_bd93, 3); mov(memw[ss, bp - 2], dx);                /* mov [bp-0x2], dx */
            ii(0x18_bd96, 2); jmp(0x18_bd35, -0x63); goto l_0x18_bd35;  /* jmp 0xbd35 */
        l_0x18_bd98:
            ii(0x18_bd98, 1); sti();                                    /* sti */
            ii(0x18_bd99, 3); mov(ax, memw[ss, bp - 12]);               /* mov ax, [bp-0xc] */
            ii(0x18_bd9c, 3); mov(dx, memw[ss, bp - 10]);               /* mov dx, [bp-0xa] */
            ii(0x18_bd9f, 1); pop(si);                                  /* pop si */
            ii(0x18_bda0, 1); leave();                                  /* leave */
            ii(0x18_bda1, 1); ret();                                    /* ret */
        }
    }
}
