using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_d945-d80f3ec5")]
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
        //  ii(0x18_d97a, 36); Недостижимый код.
        l_0x18_d99e:
            ii(0x18_d99e, 1); cwd();                                    /* cwd */
            ii(0x18_d99f, 1); popw(si);                                 /* pop si */
            ii(0x18_d9a0, 1); retw(); return;                           /* ret */
        }
    }
}
