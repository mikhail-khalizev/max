using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_04d0-b0c63359")]
        public void Method_0019_04d0()
        {
            ii(0x19_04d0, 4); enter(0, 0);                              /* enter 0x0, 0x0 */
            ii(0x19_04d4, 1); push(di);                                 /* push di */
            ii(0x19_04d5, 1); push(si);                                 /* push si */
            ii(0x19_04d6, 4); mov(es, memw[ds, 0x3f9c]);                /* mov es, [0x3f9c] */
            ii(0x19_04da, 3); mov(bx, memw[ss, bp + 0x6]);              /* mov bx, [bp+0x6] */
            ii(0x19_04dd, 5); mov(al, memb[es, bx + 0x2]);              /* mov al, [es:bx+0x2] */
            ii(0x19_04e2, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x19_04e4, 2); mov(si, ax);                              /* mov si, ax */
        l_0x19_04e6:
            ii(0x19_04e6, 2); mov(di, si);                              /* mov di, si */
            ii(0x19_04e8, 3); shl(di, 0x3);                             /* shl di, 0x3 */
            ii(0x19_04eb, 4); mov(es, memw[ds, 0x3f9e]);                /* mov es, [0x3f9e] */
            ii(0x19_04ef, 5); les(bx, memw[es, 0x122]);                 /* les bx, [es:0x122] */
            ii(0x19_04f4, 4); cmp(memb[es, bx + di], 0x1);              /* cmp byte [es:bx+di], 0x1 */
            ii(0x19_04f8, 2); if(jnz(0x19_04fd, 0x3)) goto l_0x19_04fd; /* jnz 0x4fd */
            ii(0x19_04fa, 3); jmp(0x19_0516, 0x19); goto l_0x19_0516;   /* jmp 0x516 */
        l_0x19_04fd:
            ii(0x19_04fd, 2); mov(bx, si);                              /* mov bx, si */
            ii(0x19_04ff, 3); shl(bx, 0x3);                             /* shl bx, 0x3 */
            ii(0x19_0502, 4); mov(es, memw[ds, 0x3f9e]);                /* mov es, [0x3f9e] */
            ii(0x19_0506, 5); les(di, memw[es, 0x122]);                 /* les di, [es:0x122] */
            ii(0x19_050b, 4); mov(al, memb[es, bx + di + 0x1]);         /* mov al, [es:bx+di+0x1] */
            ii(0x19_050f, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x19_0511, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x19_0513, 3); jmp(0x19_04e6, -0x30); goto l_0x19_04e6;  /* jmp 0x4e6 */
        l_0x19_0516:
            ii(0x19_0516, 2); mov(ax, si);                              /* mov ax, si */
            ii(0x19_0518, 3); jmp(0x19_051b, 0); goto l_0x19_051b;      /* jmp 0x51b */
        l_0x19_051b:
            ii(0x19_051b, 1); pop(si);                                  /* pop si */
            ii(0x19_051c, 1); pop(di);                                  /* pop di */
            ii(0x19_051d, 1); leave();                                  /* leave */
            ii(0x19_051e, 1); retf();                                   /* retf */
        }
    }
}
