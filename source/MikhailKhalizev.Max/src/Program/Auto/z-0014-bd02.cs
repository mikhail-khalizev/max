using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1cd2f10f-6143-46f8-af87-e1fc45571f21")]
        public void Method_0014_bd02()
        {
            ii(0x14_bd02, 4); enterw(0xc, 0);                           /* enter 0xc, 0x0 */
            ii(0x14_bd06, 1); pushw(si);                                /* push si */
            ii(0x14_bd07, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x14_bd09, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x14_bd0c, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x14_bd0f, 2); sub(si, si);                              /* sub si, si */
            ii(0x14_bd11, 1); cli();                                    /* cli */
            ii(0x14_bd12, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x14_bd14, 3); mov(memw_a16[ds, 0x11fc], ax);            /* mov [0x11fc], ax */
            ii(0x14_bd17, 3); mov(memw_a16[ds, 0x11fa], ax);            /* mov [0x11fa], ax */
            ii(0x14_bd1a, 3); mov(ax, memw_a16[ds, 0x98]);              /* mov ax, [0x98] */
            ii(0x14_bd1d, 4); mov(dx, memw_a16[ds, 0x9a]);              /* mov dx, [0x9a] */
            ii(0x14_bd21, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x14_bd24, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x14_bd27, 4); cmp(dx, memw_a16[ds, 0x9e]);              /* cmp dx, [0x9e] */
            ii(0x14_bd2b, 2); if(jaw(0x14_bd98, 0x6b)) goto l_0x14_bd98; /* ja 0xbd98 */
            ii(0x14_bd2d, 2); if(jbw(0x14_bd35, 0x6)) goto l_0x14_bd35; /* jb 0xbd35 */
            ii(0x14_bd2f, 4); cmp(ax, memw_a16[ds, 0x9c]);              /* cmp ax, [0x9c] */
            ii(0x14_bd33, 2); if(jaew(0x14_bd98, 0x63)) goto l_0x14_bd98; /* jae 0xbd98 */
        l_0x14_bd35:
            ii(0x14_bd35, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x14_bd38, 3); or(ax, memw_a16[ss, bp - 0x4]);           /* or ax, [bp-0x4] */
            ii(0x14_bd3b, 2); if(jzw(0x14_bd98, 0x5b)) goto l_0x14_bd98; /* jz 0xbd98 */
            ii(0x14_bd3d, 2); pushw(0x4);                               /* push 0x4 */
            ii(0x14_bd3f, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x14_bd42, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x14_bd45, 3); callw(0x14_db51, 0x1e09);                 /* call 0xdb51 */
            ii(0x14_bd48, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x14_bd4b, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x14_bd4e, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x14_bd51, 3); add(memw_a16[ss, bp - 0xc], ax);          /* add [bp-0xc], ax */
            ii(0x14_bd54, 3); adc(memw_a16[ss, bp - 0xa], dx);          /* adc [bp-0xa], dx */
            ii(0x14_bd57, 4); cmp(dx, memw_a16[ds, 0x11fc]);            /* cmp dx, [0x11fc] */
            ii(0x14_bd5b, 2); if(jbw(0x14_bd6c, 0xf)) goto l_0x14_bd6c; /* jb 0xbd6c */
            ii(0x14_bd5d, 2); if(jaw(0x14_bd65, 0x6)) goto l_0x14_bd65; /* ja 0xbd65 */
            ii(0x14_bd5f, 4); cmp(ax, memw_a16[ds, 0x11fa]);            /* cmp ax, [0x11fa] */
            ii(0x14_bd63, 2); if(jbew(0x14_bd6c, 0x7)) goto l_0x14_bd6c; /* jbe 0xbd6c */
        l_0x14_bd65:
            ii(0x14_bd65, 3); mov(memw_a16[ds, 0x11fa], ax);            /* mov [0x11fa], ax */
            ii(0x14_bd68, 4); mov(memw_a16[ds, 0x11fc], dx);            /* mov [0x11fc], dx */
        l_0x14_bd6c:
            ii(0x14_bd6c, 1); dec(si);                                  /* dec si */
            ii(0x14_bd6d, 2); if(jzw(0x14_bd7c, 0xd)) goto l_0x14_bd7c; /* jz 0xbd7c */
            ii(0x14_bd6f, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x14_bd72, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x14_bd75, 3); callw(0x14_bcce, -0xaa);                  /* call 0xbcce */
            ii(0x14_bd78, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x14_bd7a, 2); if(jnzw(0x14_bd82, 0x6)) goto l_0x14_bd82; /* jnz 0xbd82 */
        l_0x14_bd7c:
            ii(0x14_bd7c, 2); pushw(0x1c);                              /* push 0x1c */
            ii(0x14_bd7e, 3); callw(0x14_d9c5, 0x1c44);                 /* call 0xd9c5 */
            ii(0x14_bd81, 1); popw(bx);                                 /* pop bx */
        l_0x14_bd82:
            ii(0x14_bd82, 2); pushw(0);                                 /* push 0x0 */
            ii(0x14_bd84, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x14_bd87, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x14_bd8a, 3); callw(0x14_db51, 0x1dc4);                 /* call 0xdb51 */
            ii(0x14_bd8d, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x14_bd90, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x14_bd93, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x14_bd96, 2); jmpw(0x14_bd35, -0x63); goto l_0x14_bd35; /* jmp 0xbd35 */
        l_0x14_bd98:
            ii(0x14_bd98, 1); sti();                                    /* sti */
            ii(0x14_bd99, 3); mov(ax, memw_a16[ss, bp - 0xc]);          /* mov ax, [bp-0xc] */
            ii(0x14_bd9c, 3); mov(dx, memw_a16[ss, bp - 0xa]);          /* mov dx, [bp-0xa] */
            ii(0x14_bd9f, 1); popw(si);                                 /* pop si */
            ii(0x14_bda0, 1); leavew();                                 /* leave */
            ii(0x14_bda1, 1); retw(); return;                           /* ret */
        }
    }
}
