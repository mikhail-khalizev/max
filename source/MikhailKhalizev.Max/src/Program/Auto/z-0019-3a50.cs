using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_3a50-b7da27f1")]
        public void Method_0019_3a50()
        {
            ii(0x19_3a50, 1); pushw(bp);                                /* push bp */
            ii(0x19_3a51, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_3a53, 3); sub(sp, 0x2);                             /* sub sp, 0x2 */
            ii(0x19_3a56, 1); pushw(si);                                /* push si */
            ii(0x19_3a57, 1); pushw(di);                                /* push di */
            ii(0x19_3a58, 1); pushw(ds);                                /* push ds */
            ii(0x19_3a59, 3); les(di, ss, bp + 0xa);                    /* les di, [bp+0xa] */
            ii(0x19_3a5c, 1); pushw(es);                                /* push es */
            ii(0x19_3a5d, 1); popw(ds);                                 /* pop ds */
            ii(0x19_3a5e, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x19_3a60, 3); mov(cx, 0xffff);                          /* mov cx, 0xffff */
            ii(0x19_3a63, 2); repne_a16(() => scasb_a16());             /* repne scasb */
            ii(0x19_3a65, 2); not(cx);                                  /* not cx */
            ii(0x19_3a67, 1); dec(cx);                                  /* dec cx */
            ii(0x19_3a68, 2); if(jcxzw(0x19_3aa6, 0x3c)) goto l_0x19_3aa6; /* jcxz 0x3aa6 */
            ii(0x19_3a6a, 1); dec(cx);                                  /* dec cx */
            ii(0x19_3a6b, 3); mov(memw_a16[ss, bp - 0x2], cx);          /* mov [bp-0x2], cx */
            ii(0x19_3a6e, 3); les(di, ss, bp + 0x6);                    /* les di, [bp+0x6] */
            ii(0x19_3a71, 2); mov(bx, di);                              /* mov bx, di */
            ii(0x19_3a73, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x19_3a75, 3); mov(cx, 0xffff);                          /* mov cx, 0xffff */
            ii(0x19_3a78, 2); repne_a16(() => scasb_a16());             /* repne scasb */
            ii(0x19_3a7a, 2); not(cx);                                  /* not cx */
            ii(0x19_3a7c, 1); dec(cx);                                  /* dec cx */
            ii(0x19_3a7d, 2); mov(dx, cx);                              /* mov dx, cx */
            ii(0x19_3a7f, 3); sub(dx, memw_a16[ss, bp - 0x2]);          /* sub dx, [bp-0x2] */
            ii(0x19_3a82, 2); if(jbew(0x19_3aad, 0x29)) goto l_0x19_3aad; /* jbe 0x3aad */
            ii(0x19_3a84, 2); mov(di, bx);                              /* mov di, bx */
        l_0x19_3a86:
            ii(0x19_3a86, 3); mov(si, memw_a16[ss, bp + 0xa]);          /* mov si, [bp+0xa] */
            ii(0x19_3a89, 1); lodsb_a16();                              /* lodsb */
            ii(0x19_3a8a, 2); mov(di, bx);                              /* mov di, bx */
            ii(0x19_3a8c, 2); mov(cx, dx);                              /* mov cx, dx */
            ii(0x19_3a8e, 2); repne_a16(() => scasb_a16());             /* repne scasb */
            ii(0x19_3a90, 2); if(jnzw(0x19_3aad, 0x1b)) goto l_0x19_3aad; /* jnz 0x3aad */
            ii(0x19_3a92, 2); mov(dx, cx);                              /* mov dx, cx */
            ii(0x19_3a94, 2); mov(bx, di);                              /* mov bx, di */
            ii(0x19_3a96, 3); mov(cx, memw_a16[ss, bp - 0x2]);          /* mov cx, [bp-0x2] */
            ii(0x19_3a99, 2); if(jcxzw(0x19_3a9f, 0x4)) goto l_0x19_3a9f; /* jcxz 0x3a9f */
            ii(0x19_3a9b, 2); repe_a16(() => cmpsb_a16());              /* repe cmpsb */
            ii(0x19_3a9d, 2); if(jnzw(0x19_3a86, -0x19)) goto l_0x19_3a86; /* jnz 0x3a86 */
        l_0x19_3a9f:
            ii(0x19_3a9f, 3); lea(ax, bx - 0x1);                        /* lea ax, [bx-0x1] */
            ii(0x19_3aa2, 2); mov(dx, es);                              /* mov dx, es */
            ii(0x19_3aa4, 2); jmpw(0x19_3ab0, 0xa); goto l_0x19_3ab0;   /* jmp 0x3ab0 */
        l_0x19_3aa6:
            ii(0x19_3aa6, 3); les(ax, ss, bp + 0x6);                    /* les ax, [bp+0x6] */
            ii(0x19_3aa9, 2); mov(dx, es);                              /* mov dx, es */
            ii(0x19_3aab, 2); jmpw(0x19_3ab0, 0x3); goto l_0x19_3ab0;   /* jmp 0x3ab0 */
        l_0x19_3aad:
            ii(0x19_3aad, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x19_3aaf, 1); cwd();                                    /* cwd */
        l_0x19_3ab0:
            ii(0x19_3ab0, 1); popw(ds);                                 /* pop ds */
            ii(0x19_3ab1, 1); popw(di);                                 /* pop di */
            ii(0x19_3ab2, 1); popw(si);                                 /* pop si */
            ii(0x19_3ab3, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x19_3ab5, 1); popw(bp);                                 /* pop bp */
            ii(0x19_3ab6, 1); retfw(); return;                          /* retf */
        }
    }
}
