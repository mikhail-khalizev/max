using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_d945-1c1980c5")]
        public void Method_0018_d945()
        {
            ii(0x18_d945, 1); pushw(si);                                /* push si */
            ii(0x18_d946, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x18_d948, 5); test(memb_a16[ds, 0x1582], 0x1);          /* test byte [0x1582], 0x1 */
            ii(0x18_d94d, 2); if(jnzw(0x18_d99e, 0x4f)) goto l_0x18_d99e; /* jnz 0xd99e */
            ii(0x18_d94f, 5); cmp(memb_a16[ds, 0x2e], 0xb);             /* cmp byte [0x2e], 0xb */
            ii(0x18_d954, 2); if(jnzw(0x18_d95c, 0x6)) goto l_0x18_d95c; /* jnz 0xd95c */
            ii(0x18_d956, 3); callw(0x18_f455, 0x1afc);                 /* call 0xf455 */
            ii(0x18_d959, 3); mov(memw_a16[ds, 0xaf0], ax);             /* mov [0xaf0], ax */
        l_0x18_d95c:
            ii(0x18_d95c, 2); xor(dx, dx);                              /* xor dx, dx */
        l_0x18_d95e:
            ii(0x18_d95e, 2); mov(ax, sp);                              /* mov ax, sp */
            ii(0x18_d960, 2); mov(bx, ss);                              /* mov bx, ss */
            ii(0x18_d962, 6); sub(memw_a16[ds, 0x996], 0x180);          /* sub word [0x996], 0x180 */
            ii(0x18_d968, 2); pushw(0x20);                              /* push 0x20 */
            ii(0x18_d96a, 1); popw(ss);                                 /* pop ss */
            ii(0x18_d96b, 4); mov(sp, memw_a16[ds, 0x996]);             /* mov sp, [0x996] */
            ii(0x18_d96f, 3); sub(sp, 0x10);                            /* sub sp, 0x10 */
            ii(0x18_d972, 1); pushw(bx);                                /* push bx */
            ii(0x18_d973, 1); pushw(ax);                                /* push ax */
            ii(0x18_d974, 1); pushw(dx);                                /* push dx */
            ii(0x18_d975, 5); if(jmpw_far_abs(0x18, 0x1e22)) return;    /* jmp word 0x18:0x1e22 */
            ii(0x18_d97a, 1); pushw(si);                                /* push si */
            ii(0x18_d97b, 3); mov(si, 0xada);                           /* mov si, 0xada */
            ii(0x18_d97e, 2); xor(ax, ax);                              /* xor ax, ax */
        l_0x18_d980:
            ii(0x18_d980, 1); inc(si);                                  /* inc si */
            ii(0x18_d981, 1); inc(si);                                  /* inc si */
            ii(0x18_d982, 4); cmp(si, 0xaec);                           /* cmp si, 0xaec */
            ii(0x18_d986, 2); if(jaew(0x18_d99e, 0x16)) goto l_0x18_d99e; /* jae 0xd99e */
            ii(0x18_d988, 2); cmp(memw_a16[ds, si], ax);                /* cmp [si], ax */
            ii(0x18_d98a, 2); if(jnzw(0x18_d980, -0xc)) goto l_0x18_d980; /* jnz 0xd980 */
            ii(0x18_d98c, 1); pushw(bp);                                /* push bp */
            ii(0x18_d98d, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x18_d98f, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x18_d992, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x18_d995, 1); popw(bp);                                 /* pop bp */
            ii(0x18_d996, 3); mov(cx, 0x400);                           /* mov cx, 0x400 */
            ii(0x18_d999, 2); div(cx);                                  /* div cx */
            ii(0x18_d99b, 1); xchg(dx, ax);                             /* xchg dx, ax */
            ii(0x18_d99c, 2); jmpw(0x18_d95e, -0x40); goto l_0x18_d95e; /* jmp 0xd95e */
        l_0x18_d99e:
            ii(0x18_d99e, 1); cwd();                                    /* cwd */
            ii(0x18_d99f, 1); popw(si);                                 /* pop si */
            ii(0x18_d9a0, 1); retw(); return;                           /* ret */
        //  ii(0x18_d9a1, 36); Недостижимый (и не декодированный) код.
        //    ii(0x18_d9c5, 5); if(jmpw_far_abs(0x18, 0x22ad)) return;    /* jmp word 0x18:0x22ad */
        }
    }
}
