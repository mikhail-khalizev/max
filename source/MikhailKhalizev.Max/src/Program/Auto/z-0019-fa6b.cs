using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_fa6b-81d0c1a5")]
        public void Method_0019_fa6b()
        {
            ii(0x19_fa6b, 4); enter(8, 0);                              /* enter 0x8, 0x0 */
            ii(0x19_fa6f, 1); push(di);                                 /* push di */
            ii(0x19_fa70, 1); push(si);                                 /* push si */
            ii(0x19_fa71, 1); push(ds);                                 /* push ds */
            ii(0x19_fa72, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_fa75, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_fa77, 3); mov(ax, memw[ss, bp + 6]);                /* mov ax, [bp+0x6] */
            ii(0x19_fa7a, 3); mov(memw[ss, bp - 2], ax);                /* mov [bp-0x2], ax */
            ii(0x19_fa7d, 3); call(0x19_fa33, -0x4d);                   /* call 0xfa33 */
            ii(0x19_fa80, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_fa82, 2); if(jnz(0x19_fa89, 5)) goto l_0x19_fa89;   /* jnz 0xfa89 */
            ii(0x19_fa84, 3); mov(ax, 1);                               /* mov ax, 0x1 */
            ii(0x19_fa87, 2); jmp(0x19_fac7, 0x3e); goto l_0x19_fac7;   /* jmp 0xfac7 */
        l_0x19_fa89:
            ii(0x19_fa89, 3); call(0x19_fa18, -0x74);                   /* call 0xfa18 */
            ii(0x19_fa8c, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_fa8e, 2); if(jz(0x19_faa1, 0x11)) goto l_0x19_faa1; /* jz 0xfaa1 */
            ii(0x19_fa90, 3); mov(ax, memw[ss, bp - 2]);                /* mov ax, [bp-0x2] */
            ii(0x19_fa93, 3); shr(ax, 3);                               /* shr ax, 0x3 */
            ii(0x19_fa96, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x19_fa98, 3); mov(cx, 0x50);                            /* mov cx, 0x50 */
            ii(0x19_fa9b, 2); mov(es, cx);                              /* mov es, cx */
            ii(0x19_fa9d, 4); or(memb[es, bx], 0x40);                   /* or byte [es:bx], 0x40 */
        l_0x19_faa1:
            ii(0x19_faa1, 1); push(di);                                 /* push di */
            ii(0x19_faa2, 1); push(si);                                 /* push si */
            ii(0x19_faa3, 3); mov(ax, 6);                               /* mov ax, 0x6 */
            ii(0x19_faa6, 3); mov(bx, memw[ss, bp - 2]);                /* mov bx, [bp-0x2] */
            ii(0x19_faa9, 3); lsl(di, bx);                              /* lsl di, bx */
            ii(0x19_faac, 2); xor(si, si);                              /* xor si, si */
            ii(0x19_faae, 2); @int(0x31);                               /* int 0x31 */
            ii(0x19_fab0, 2); mov(bx, cx);                              /* mov bx, cx */
            ii(0x19_fab2, 2); mov(cx, dx);                              /* mov cx, dx */
            ii(0x19_fab4, 3); mov(ax, 0x600);                           /* mov ax, 0x600 */
            ii(0x19_fab7, 2); @int(0x31);                               /* int 0x31 */
            ii(0x19_fab9, 1); pop(si);                                  /* pop si */
            ii(0x19_faba, 1); pop(di);                                  /* pop di */
            ii(0x19_fabb, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_fabe, 1); cmc();                                    /* cmc */
            ii(0x19_fabf, 2); rcl(ax, 1);                               /* rcl ax, 1 */
            ii(0x19_fac1, 3); mov(memw[ss, bp - 8], ax);                /* mov [bp-0x8], ax */
            ii(0x19_fac4, 3); mov(ax, memw[ss, bp - 8]);                /* mov ax, [bp-0x8] */
        l_0x19_fac7:
            ii(0x19_fac7, 1); pop(ds);                                  /* pop ds */
            ii(0x19_fac8, 1); pop(si);                                  /* pop si */
            ii(0x19_fac9, 1); pop(di);                                  /* pop di */
            ii(0x19_faca, 1); leave();                                  /* leave */
            ii(0x19_facb, 3); ret(4);                                   /* ret 0x4 */
        }
    }
}
