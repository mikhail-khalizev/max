using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_dad6-4007b599")]
        public void Method_0017_dad6()
        {
            ii(0x17_dad6, 1); pushw(bp);                                /* push bp */
            ii(0x17_dad7, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_dad9, 2); mov(dx, di);                              /* mov dx, di */
            ii(0x17_dadb, 2); mov(bx, si);                              /* mov bx, si */
            ii(0x17_dadd, 2); mov(ax, ds);                              /* mov ax, ds */
            ii(0x17_dadf, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x17_dae1, 3); mov(di, memw_a16[ss, bp + 0x6]);          /* mov di, [bp+0x6] */
            ii(0x17_dae4, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x17_dae6, 3); mov(cx, 0xffff);                          /* mov cx, 0xffff */
            ii(0x17_dae9, 2); repne_a16(() => scasb_a16());             /* repne scasb */
            ii(0x17_daeb, 3); lea(si, di - 0x1);                        /* lea si, [di-0x1] */
            ii(0x17_daee, 3); mov(di, memw_a16[ss, bp + 0x8]);          /* mov di, [bp+0x8] */
            ii(0x17_daf1, 3); mov(cx, 0xffff);                          /* mov cx, 0xffff */
            ii(0x17_daf4, 2); repne_a16(() => scasb_a16());             /* repne scasb */
            ii(0x17_daf6, 2); not(cx);                                  /* not cx */
            ii(0x17_daf8, 2); sub(di, cx);                              /* sub di, cx */
            ii(0x17_dafa, 2); xchg(si, di);                             /* xchg si, di */
            ii(0x17_dafc, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x17_daff, 4); test(si, 0x1);                            /* test si, 0x1 */
            ii(0x17_db03, 2); if(jzw(0x17_db07, 0x2)) goto l_0x17_db07; /* jz 0xdb07 */
            ii(0x17_db05, 1); movsb_a16();                              /* movsb */
            ii(0x17_db06, 1); dec(cx);                                  /* dec cx */
        l_0x17_db07:
            ii(0x17_db07, 2); shr(cx, 0x1);                             /* shr cx, 1 */
            ii(0x17_db09, 2); rep_a16(() => movsw_a16());               /* rep movsw */
            ii(0x17_db0b, 2); adc(cx, cx);                              /* adc cx, cx */
            ii(0x17_db0d, 2); rep_a16(() => movsb_a16());               /* rep movsb */
            ii(0x17_db0f, 2); mov(si, bx);                              /* mov si, bx */
            ii(0x17_db11, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x17_db13, 1); popw(bp);                                 /* pop bp */
            ii(0x17_db14, 1); retfw(); return;                          /* retf */
        //  ii(0x17_db15, 1); Недостижимый (и не декодированный) код.
        //    ii(0x17_db16, 1); pushw(bp);                                /* push bp */
        //    ii(0x17_db17, 2); mov(bp, sp);                              /* mov bp, sp */
        //    ii(0x17_db19, 2); mov(dx, di);                              /* mov dx, di */
        //    ii(0x17_db1b, 2); mov(ax, ds);                              /* mov ax, ds */
        //    ii(0x17_db1d, 2); mov(es, ax);                              /* mov es, ax */
        //    ii(0x17_db1f, 3); mov(di, memw_a16[ss, bp + 0x6]);          /* mov di, [bp+0x6] */
        //    ii(0x17_db22, 2); xor(ax, ax);                              /* xor ax, ax */
        //    ii(0x17_db24, 3); mov(cx, 0xffff);                          /* mov cx, 0xffff */
        //    ii(0x17_db27, 2); repne_a16(() => scasb_a16());             /* repne scasb */
        //    ii(0x17_db29, 2); not(cx);                                  /* not cx */
        //    ii(0x17_db2b, 1); dec(cx);                                  /* dec cx */
        //    ii(0x17_db2c, 1); xchg(cx, ax);                             /* xchg cx, ax */
        //    ii(0x17_db2d, 2); mov(di, dx);                              /* mov di, dx */
        //    ii(0x17_db2f, 1); popw(bp);                                 /* pop bp */
        //    ii(0x17_db30, 1); retfw(); return;                          /* retf */
        //  ii(0x17_db31, 1); Недостижимый (и не декодированный) код.
        //    ii(0x17_db32, 1); pushw(bp);                                /* push bp */
        //    ii(0x17_db33, 2); mov(bp, sp);                              /* mov bp, sp */
        //    ii(0x17_db35, 1); pushw(di);                                /* push di */
        //    ii(0x17_db36, 1); pushw(si);                                /* push si */
        //    ii(0x17_db37, 4); mov(si, memw_a16[ds, 0x1c75]);            /* mov si, [0x1c75] */
        //    ii(0x17_db3b, 2); or(si, si);                               /* or si, si */
        //    ii(0x17_db3d, 2); if(jzw(0x17_db89, 0x4a)) goto l_0x17_db89; /* jz 0xdb89 */
        //    ii(0x17_db3f, 4); cmp(memw_a16[ss, bp + 0x6], 0);           /* cmp word [bp+0x6], 0x0 */
        //    ii(0x17_db43, 2); if(jzw(0x17_db89, 0x44)) goto l_0x17_db89; /* jz 0xdb89 */
        //    ii(0x17_db45, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
        //    ii(0x17_db48, 1); nop();                                    /* nop */
        //    ii(0x17_db49, 1); pushw(cs);                                /* push cs */
        //    ii(0x17_db4a, 3); callw(0x17_db16, -0x37);                  /* call 0xdb16 */
        //    ii(0x17_db4d, 3); add(sp, 0x2);                             /* add sp, 0x2 */
        //    ii(0x17_db50, 2); mov(di, ax);                              /* mov di, ax */
        //    ii(0x17_db52, 2); jmpw(0x17_db84, 0x30); goto l_0x17_db84;  /* jmp 0xdb84 */
        l_0x17_db54:
            ii(0x17_db54, 2); pushw(memw_a16[ds, si]);                  /* push word [si] */
            ii(0x17_db56, 1); nop();                                    /* nop */
            ii(0x17_db57, 1); pushw(cs);                                /* push cs */
            ii(0x17_db58, 3); callw(0x17_db16, -0x45);                  /* call 0xdb16 */
            ii(0x17_db5b, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x17_db5e, 2); cmp(ax, di);                              /* cmp ax, di */
            ii(0x17_db60, 2); if(jlew(0x17_db82, 0x20)) goto l_0x17_db82; /* jle 0xdb82 */
            ii(0x17_db62, 2); mov(bx, memw_a16[ds, si]);                /* mov bx, [si] */
            ii(0x17_db64, 3); cmp(memb_a16[ds, bx + di], 0x3d);         /* cmp byte [bx+di], 0x3d */
            ii(0x17_db67, 2); if(jnzw(0x17_db82, 0x19)) goto l_0x17_db82; /* jnz 0xdb82 */
            ii(0x17_db69, 1); pushw(di);                                /* push di */
            ii(0x17_db6a, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x17_db6d, 1); pushw(bx);                                /* push bx */
            ii(0x17_db6e, 1); nop();                                    /* nop */
            ii(0x17_db6f, 1); pushw(cs);                                /* push cs */
            ii(0x17_db70, 3); callw(0x17_e276, 0x703);                  /* call 0xe276 */
            ii(0x17_db73, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x17_db76, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_db78, 2); if(jnzw(0x17_db82, 0x8)) goto l_0x17_db82; /* jnz 0xdb82 */
            ii(0x17_db7a, 2); mov(ax, memw_a16[ds, si]);                /* mov ax, [si] */
            ii(0x17_db7c, 2); add(ax, di);                              /* add ax, di */
            ii(0x17_db7e, 1); inc(ax);                                  /* inc ax */
            ii(0x17_db7f, 2); jmpw(0x17_db8b, 0xa); goto l_0x17_db8b;   /* jmp 0xdb8b */
        //    ii(0x17_db81, 1); nop();                                    /* nop */
        l_0x17_db82:
            ii(0x17_db82, 1); inc(si);                                  /* inc si */
            ii(0x17_db83, 1); inc(si);                                  /* inc si */
        l_0x17_db84:
            ii(0x17_db84, 3); cmp(memw_a16[ds, si], 0);                 /* cmp word [si], 0x0 */
            ii(0x17_db87, 2); if(jnzw(0x17_db54, -0x35)) goto l_0x17_db54; /* jnz 0xdb54 */
        l_0x17_db89:
            ii(0x17_db89, 2); sub(ax, ax);                              /* sub ax, ax */
        l_0x17_db8b:
            ii(0x17_db8b, 1); popw(si);                                 /* pop si */
            ii(0x17_db8c, 1); popw(di);                                 /* pop di */
            ii(0x17_db8d, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x17_db8f, 1); popw(bp);                                 /* pop bp */
            ii(0x17_db90, 1); retfw(); return;                          /* retf */
        }
    }
}
