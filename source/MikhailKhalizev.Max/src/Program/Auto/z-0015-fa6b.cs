using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("fcc5e8a8-0c42-419d-a0c8-6c4c4a069416")]
        public void Method_0015_fa6b()
        {
            ii(0x15_fa6b, 4); enterw(0x8, 0);                           /* enter 0x8, 0x0 */
            ii(0x15_fa6f, 1); pushw(di);                                /* push di */
            ii(0x15_fa70, 1); pushw(si);                                /* push si */
            ii(0x15_fa71, 1); pushw(ds);                                /* push ds */
            ii(0x15_fa72, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x15_fa75, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_fa77, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x15_fa7a, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x15_fa7d, 3); callw(0x15_fa33, -0x4d);                  /* call 0xfa33 */
            ii(0x15_fa80, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_fa82, 2); if(jnzw(0x15_fa89, 0x5)) goto l_0x15_fa89; /* jnz 0xfa89 */
            ii(0x15_fa84, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x15_fa87, 2); jmpw(0x15_fac7, 0x3e); goto l_0x15_fac7;  /* jmp 0xfac7 */
        l_0x15_fa89:
            ii(0x15_fa89, 3); callw(0x15_fa18, -0x74);                  /* call 0xfa18 */
            ii(0x15_fa8c, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_fa8e, 2); if(jzw(0x15_faa1, 0x11)) goto l_0x15_faa1; /* jz 0xfaa1 */
            ii(0x15_fa90, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x15_fa93, 3); shr(ax, 0x3);                             /* shr ax, 0x3 */
            ii(0x15_fa96, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x15_fa98, 3); mov(cx, 0x50);                            /* mov cx, 0x50 */
            ii(0x15_fa9b, 2); mov(es, cx);                              /* mov es, cx */
            ii(0x15_fa9d, 4); or(memb_a16[es, bx], 0x40);               /* or byte [es:bx], 0x40 */
        l_0x15_faa1:
            ii(0x15_faa1, 1); pushw(di);                                /* push di */
            ii(0x15_faa2, 1); pushw(si);                                /* push si */
            ii(0x15_faa3, 3); mov(ax, 0x6);                             /* mov ax, 0x6 */
            ii(0x15_faa6, 3); mov(bx, memw_a16[ss, bp - 0x2]);          /* mov bx, [bp-0x2] */
            ii(0x15_faa9, 3); lsl(di, bx);                              /* lsl di, bx */
            ii(0x15_faac, 2); xor(si, si);                              /* xor si, si */
            ii(0x15_faae, 2); @int(0x31);                               /* int 0x31 */
            ii(0x15_fab0, 2); mov(bx, cx);                              /* mov bx, cx */
            ii(0x15_fab2, 2); mov(cx, dx);                              /* mov cx, dx */
            ii(0x15_fab4, 3); mov(ax, 0x600);                           /* mov ax, 0x600 */
            ii(0x15_fab7, 2); @int(0x31);                               /* int 0x31 */
            ii(0x15_fab9, 1); popw(si);                                 /* pop si */
            ii(0x15_faba, 1); popw(di);                                 /* pop di */
            ii(0x15_fabb, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x15_fabe, 1); cmc();                                    /* cmc */
            ii(0x15_fabf, 2); rcl(ax, 0x1);                             /* rcl ax, 1 */
            ii(0x15_fac1, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x15_fac4, 3); mov(ax, memw_a16[ss, bp - 0x8]);          /* mov ax, [bp-0x8] */
        l_0x15_fac7:
            ii(0x15_fac7, 1); popw(ds);                                 /* pop ds */
            ii(0x15_fac8, 1); popw(si);                                 /* pop si */
            ii(0x15_fac9, 1); popw(di);                                 /* pop di */
            ii(0x15_faca, 1); leavew();                                 /* leave */
            ii(0x15_facb, 3); retw(0x4); return;                        /* ret 0x4 */
        }
    }
}
