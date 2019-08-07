using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2406b598-0041-4269-bfda-1a2b96ce91cb")]
        public void Method_0013_dbe0()
        {
            ii(0x13_dbe0, 1); pushw(bp);                                /* push bp */
            ii(0x13_dbe1, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x13_dbe3, 3); sub(sp, 0x2);                             /* sub sp, 0x2 */
            ii(0x13_dbe6, 1); pushw(si);                                /* push si */
            ii(0x13_dbe7, 1); pushw(di);                                /* push di */
            ii(0x13_dbe8, 1); pushw(ds);                                /* push ds */
            ii(0x13_dbe9, 1); popw(es);                                 /* pop es */
            ii(0x13_dbea, 3); mov(di, memw_a16[ss, bp + 0x8]);          /* mov di, [bp+0x8] */
            ii(0x13_dbed, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x13_dbef, 3); mov(cx, 0xffff);                          /* mov cx, 0xffff */
            ii(0x13_dbf2, 2); repne_a16(() => scasb_a16());             /* repne scasb */
            ii(0x13_dbf4, 2); not(cx);                                  /* not cx */
            ii(0x13_dbf6, 1); dec(cx);                                  /* dec cx */
            ii(0x13_dbf7, 2); if(jcxzw(0x13_dc33, 0x3a)) goto l_0x13_dc33; /* jcxz 0xdc33 */
            ii(0x13_dbf9, 1); dec(cx);                                  /* dec cx */
            ii(0x13_dbfa, 3); mov(memw_a16[ss, bp - 0x2], cx);          /* mov [bp-0x2], cx */
            ii(0x13_dbfd, 3); mov(di, memw_a16[ss, bp + 0x6]);          /* mov di, [bp+0x6] */
            ii(0x13_dc00, 2); mov(bx, di);                              /* mov bx, di */
            ii(0x13_dc02, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x13_dc04, 3); mov(cx, 0xffff);                          /* mov cx, 0xffff */
            ii(0x13_dc07, 2); repne_a16(() => scasb_a16());             /* repne scasb */
            ii(0x13_dc09, 2); not(cx);                                  /* not cx */
            ii(0x13_dc0b, 1); dec(cx);                                  /* dec cx */
            ii(0x13_dc0c, 2); mov(dx, cx);                              /* mov dx, cx */
            ii(0x13_dc0e, 3); sub(dx, memw_a16[ss, bp - 0x2]);          /* sub dx, [bp-0x2] */
            ii(0x13_dc11, 2); if(jbew(0x13_dc38, 0x25)) goto l_0x13_dc38; /* jbe 0xdc38 */
            ii(0x13_dc13, 2); mov(di, bx);                              /* mov di, bx */
        l_0x13_dc15:
            ii(0x13_dc15, 3); mov(si, memw_a16[ss, bp + 0x8]);          /* mov si, [bp+0x8] */
            ii(0x13_dc18, 1); lodsb_a16();                              /* lodsb */
            ii(0x13_dc19, 2); mov(di, bx);                              /* mov di, bx */
            ii(0x13_dc1b, 2); mov(cx, dx);                              /* mov cx, dx */
            ii(0x13_dc1d, 2); repne_a16(() => scasb_a16());             /* repne scasb */
            ii(0x13_dc1f, 2); if(jnzw(0x13_dc38, 0x17)) goto l_0x13_dc38; /* jnz 0xdc38 */
            ii(0x13_dc21, 2); mov(dx, cx);                              /* mov dx, cx */
            ii(0x13_dc23, 2); mov(bx, di);                              /* mov bx, di */
            ii(0x13_dc25, 3); mov(cx, memw_a16[ss, bp - 0x2]);          /* mov cx, [bp-0x2] */
            ii(0x13_dc28, 2); if(jcxzw(0x13_dc2e, 0x4)) goto l_0x13_dc2e; /* jcxz 0xdc2e */
            ii(0x13_dc2a, 2); repe_a16(() => cmpsb_a16());              /* repe cmpsb */
            ii(0x13_dc2c, 2); if(jnzw(0x13_dc15, -0x19)) goto l_0x13_dc15; /* jnz 0xdc15 */
        l_0x13_dc2e:
            ii(0x13_dc2e, 3); lea(ax, bx - 0x1);                        /* lea ax, [bx-0x1] */
            ii(0x13_dc31, 2); jmpw(0x13_dc3a, 0x7); goto l_0x13_dc3a;   /* jmp 0xdc3a */
        l_0x13_dc33:
            ii(0x13_dc33, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x13_dc36, 2); jmpw(0x13_dc3a, 0x2); goto l_0x13_dc3a;   /* jmp 0xdc3a */
        l_0x13_dc38:
            ii(0x13_dc38, 2); xor(ax, ax);                              /* xor ax, ax */
        l_0x13_dc3a:
            ii(0x13_dc3a, 1); popw(di);                                 /* pop di */
            ii(0x13_dc3b, 1); popw(si);                                 /* pop si */
            ii(0x13_dc3c, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x13_dc3e, 1); popw(bp);                                 /* pop bp */
            ii(0x13_dc3f, 1); retfw(); return;                          /* retf */
        }
    }
}
