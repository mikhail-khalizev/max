using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3a3e2308-b00e-46dd-affc-488870e572f4")]
        public void Method_0013_db32()
        {
            ii(0x13_db32, 1); pushw(bp);                                /* push bp */
            ii(0x13_db33, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x13_db35, 1); pushw(di);                                /* push di */
            ii(0x13_db36, 1); pushw(si);                                /* push si */
            ii(0x13_db37, 4); mov(si, memw_a16[ds, 0x1c75]);            /* mov si, [0x1c75] */
            ii(0x13_db3b, 2); or(si, si);                               /* or si, si */
            ii(0x13_db3d, 2); if(jzw(0x13_db89, 0x4a)) goto l_0x13_db89; /* jz 0xdb89 */
            ii(0x13_db3f, 4); cmp(memw_a16[ss, bp + 0x6], 0);           /* cmp word [bp+0x6], 0x0 */
            ii(0x13_db43, 2); if(jzw(0x13_db89, 0x44)) goto l_0x13_db89; /* jz 0xdb89 */
            ii(0x13_db45, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x13_db48, 1); nop();                                    /* nop */
            ii(0x13_db49, 1); pushw(cs);                                /* push cs */
            ii(0x13_db4a, 3); callw(0x13_db16, -0x37);                  /* call 0xdb16 */
            ii(0x13_db4d, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x13_db50, 2); mov(di, ax);                              /* mov di, ax */
            ii(0x13_db52, 2); jmpw(0x13_db84, 0x30); goto l_0x13_db84;  /* jmp 0xdb84 */
        l_0x13_db54:
            ii(0x13_db54, 2); pushw(memw_a16[ds, si]);                  /* push word [si] */
            ii(0x13_db56, 1); nop();                                    /* nop */
            ii(0x13_db57, 1); pushw(cs);                                /* push cs */
            ii(0x13_db58, 3); callw(0x13_db16, -0x45);                  /* call 0xdb16 */
            ii(0x13_db5b, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x13_db5e, 2); cmp(ax, di);                              /* cmp ax, di */
            ii(0x13_db60, 2); if(jlew(0x13_db82, 0x20)) goto l_0x13_db82; /* jle 0xdb82 */
            ii(0x13_db62, 2); mov(bx, memw_a16[ds, si]);                /* mov bx, [si] */
            ii(0x13_db64, 3); cmp(memb_a16[ds, bx + di], 0x3d);         /* cmp byte [bx+di], 0x3d */
            ii(0x13_db67, 2); if(jnzw(0x13_db82, 0x19)) goto l_0x13_db82; /* jnz 0xdb82 */
            ii(0x13_db69, 1); pushw(di);                                /* push di */
            ii(0x13_db6a, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x13_db6d, 1); pushw(bx);                                /* push bx */
            ii(0x13_db6e, 1); nop();                                    /* nop */
            ii(0x13_db6f, 1); pushw(cs);                                /* push cs */
            ii(0x13_db70, 3); callw(0x13_e276, 0x703);                  /* call 0xe276 */
            ii(0x13_db73, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x13_db76, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x13_db78, 2); if(jnzw(0x13_db82, 0x8)) goto l_0x13_db82; /* jnz 0xdb82 */
            ii(0x13_db7a, 2); mov(ax, memw_a16[ds, si]);                /* mov ax, [si] */
            ii(0x13_db7c, 2); add(ax, di);                              /* add ax, di */
            ii(0x13_db7e, 1); inc(ax);                                  /* inc ax */
            ii(0x13_db7f, 2); jmpw(0x13_db8b, 0xa); goto l_0x13_db8b;   /* jmp 0xdb8b */
        //  ii(0x13_db81, 1); Недостижимый код.
l_0x13_db82:
            ii(0x13_db82, 1); inc(si);                                  /* inc si */
            ii(0x13_db83, 1); inc(si);                                  /* inc si */
        l_0x13_db84:
            ii(0x13_db84, 3); cmp(memw_a16[ds, si], 0);                 /* cmp word [si], 0x0 */
            ii(0x13_db87, 2); if(jnzw(0x13_db54, -0x35)) goto l_0x13_db54; /* jnz 0xdb54 */
        l_0x13_db89:
            ii(0x13_db89, 2); sub(ax, ax);                              /* sub ax, ax */
        l_0x13_db8b:
            ii(0x13_db8b, 1); popw(si);                                 /* pop si */
            ii(0x13_db8c, 1); popw(di);                                 /* pop di */
            ii(0x13_db8d, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x13_db8f, 1); popw(bp);                                 /* pop bp */
            ii(0x13_db90, 1); retfw(); return;                          /* retf */
        }
    }
}
