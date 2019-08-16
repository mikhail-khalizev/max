using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f3b75840-cbd4-48ff-861e-5741b332ef22")]
        public void Method_0015_2f2a()
        {
            ii(0x15_2f2a, 1); pushw(bp);                                /* push bp */
            ii(0x15_2f2b, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x15_2f2d, 3); sub(sp, 0x2);                             /* sub sp, 0x2 */
            ii(0x15_2f30, 1); pushw(di);                                /* push di */
            ii(0x15_2f31, 1); pushw(si);                                /* push si */
            ii(0x15_2f32, 3); mov(si, 0x3c68);                          /* mov si, 0x3c68 */
            ii(0x15_2f35, 2); sub(di, di);                              /* sub di, di */
            ii(0x15_2f37, 3); mov(memw_a16[ss, bp - 0x2], di);          /* mov [bp-0x2], di */
            ii(0x15_2f3a, 2); jmpw(0x15_2f44, 0x8); goto l_0x15_2f44;   /* jmp 0x2f44 */
        l_0x15_2f3c:
            ii(0x15_2f3c, 5); mov(memw_a16[ss, bp - 0x2], 0xffff);      /* mov word [bp-0x2], 0xffff */
        l_0x15_2f41:
            ii(0x15_2f41, 3); add(si, 0xc);                             /* add si, 0xc */
        l_0x15_2f44:
            ii(0x15_2f44, 4); cmp(memw_a16[ds, 0x3e48], si);            /* cmp [0x3e48], si */
            ii(0x15_2f48, 2); if(jbw(0x15_2f60, 0x16)) goto l_0x15_2f60; /* jb 0x2f60 */
            ii(0x15_2f4a, 4); test(memb_a16[ds, si + 0xa], 0x83);       /* test byte [si+0xa], 0x83 */
            ii(0x15_2f4e, 2); if(jzw(0x15_2f41, -0xf)) goto l_0x15_2f41; /* jz 0x2f41 */
            ii(0x15_2f50, 1); pushw(ds);                                /* push ds */
            ii(0x15_2f51, 1); pushw(si);                                /* push si */
            ii(0x15_2f52, 1); nop();                                    /* nop */
            ii(0x15_2f53, 1); pushw(cs);                                /* push cs */
            ii(0x15_2f54, 3); callw(0x15_2ea2, -0xb5);                  /* call 0x2ea2 */
            ii(0x15_2f57, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x15_2f5a, 1); inc(ax);                                  /* inc ax */
            ii(0x15_2f5b, 2); if(jzw(0x15_2f3c, -0x21)) goto l_0x15_2f3c; /* jz 0x2f3c */
            ii(0x15_2f5d, 1); inc(di);                                  /* inc di */
            ii(0x15_2f5e, 2); jmpw(0x15_2f41, -0x1f); goto l_0x15_2f41; /* jmp 0x2f41 */
        l_0x15_2f60:
            ii(0x15_2f60, 4); cmp(memw_a16[ss, bp + 0x4], 0x1);         /* cmp word [bp+0x4], 0x1 */
            ii(0x15_2f64, 2); if(jnzw(0x15_2f6a, 0x4)) goto l_0x15_2f6a; /* jnz 0x2f6a */
            ii(0x15_2f66, 2); mov(ax, di);                              /* mov ax, di */
            ii(0x15_2f68, 2); jmpw(0x15_2f6d, 0x3); goto l_0x15_2f6d;   /* jmp 0x2f6d */
        l_0x15_2f6a:
            ii(0x15_2f6a, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
        l_0x15_2f6d:
            ii(0x15_2f6d, 1); popw(si);                                 /* pop si */
            ii(0x15_2f6e, 1); popw(di);                                 /* pop di */
            ii(0x15_2f6f, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x15_2f71, 1); popw(bp);                                 /* pop bp */
            ii(0x15_2f72, 3); retw(0x2); return;                        /* ret 0x2 */
        }
    }
}
