using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5e6b3187-970b-481b-89a9-cb32aaae119f")]
        public void Method_0014_e958()
        {
            ii(0x14_e958, 5); cmp(memw_a16[ds, 0x4d76], 0);             /* cmp word [0x4d76], 0x0 */
            ii(0x14_e95d, 2); if(jnzw(0x14_e9ac, 0x4d)) goto l_0x14_e9ac; /* jnz 0xe9ac */
            ii(0x14_e95f, 1); pushw(ds);                                /* push ds */
            ii(0x14_e960, 2); pushw(0x20);                              /* push 0x20 */
            ii(0x14_e962, 1); popw(ds);                                 /* pop ds */
            ii(0x14_e963, 2); mov(cl, 0);                               /* mov cl, 0x0 */
            ii(0x14_e965, 4); xchg(memb_a16[ds, 0x980], cl);            /* xchg [0x980], cl */
            ii(0x14_e969, 2); mov(ah, 0x48);                            /* mov ah, 0x48 */
            ii(0x14_e96b, 3); mov(bx, 0x400);                           /* mov bx, 0x400 */
            ii(0x14_e96e, 3); callw(0x14_e450, -0x521);                 /* call 0xe450 */
            ii(0x14_e971, 4); mov(memb_a16[ds, 0x980], cl);             /* mov [0x980], cl */
            ii(0x14_e975, 1); pushw(ds);                                /* push ds */
            ii(0x14_e976, 1); popw(es);                                 /* pop es */
            ii(0x14_e977, 1); popw(ds);                                 /* pop ds */
            ii(0x14_e978, 2); if(jbw_func(0x14_e9ad, 0x33)) return;     /* jb 0xe9ad */
            ii(0x14_e97a, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x14_e97c, 5); mov(di, memw_a16[es, 0xc14]);             /* mov di, [es:0xc14] */
            ii(0x14_e981, 3); add(di, 0x10);                            /* add di, 0x10 */
            ii(0x14_e984, 4); mov(memw_a16[ds, 0x4d76], di);            /* mov [0x4d76], di */
            ii(0x14_e988, 2); pushw(0x8);                               /* push 0x8 */
            ii(0x14_e98a, 1); popw(es);                                 /* pop es */
            ii(0x14_e98b, 3); mov(cx, 0x4);                             /* mov cx, 0x4 */
            ii(0x14_e98e, 3); rep_a16(() => movsw_a16(es));             /* es rep movsw */
            ii(0x14_e991, 5); or(memb_a16[es, di - 0x2], 0x40);         /* or byte [es:di-0x2], 0x40 */
            ii(0x14_e996, 2); mov(cl, 0x8);                             /* mov cl, 0x8 */
            ii(0x14_e998, 2); sub(si, cx);                              /* sub si, cx */
            ii(0x14_e99a, 3); rep_a16(() => movsb_a16(es));             /* es rep movsb */
            ii(0x14_e99d, 4); mov(memb_a16[es, si - 0x3], cl);          /* mov [es:si-0x3], cl */
            ii(0x14_e9a1, 2); pushw(0x50);                              /* push 0x50 */
            ii(0x14_e9a3, 1); popw(es);                                 /* pop es */
            ii(0x14_e9a4, 3); shr(di, 0x3);                             /* shr di, 0x3 */
            ii(0x14_e9a7, 5); mov(memb_a16[es, di - 0x1], 0xe1);        /* mov byte [es:di-0x1], 0xe1 */
        l_0x14_e9ac:
            ii(0x14_e9ac, 1); retw(); return;                           /* ret */
        }
    }
}
