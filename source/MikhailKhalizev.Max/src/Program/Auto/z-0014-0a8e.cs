using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d570230d-bd23-46c1-966f-379335583a03")]
        public void Method_0014_0a8e()
        {
            ii(0x14_0a8e, 4); enterw(0x8, 0);                           /* enter 0x8, 0x0 */
            ii(0x14_0a92, 1); pushw(di);                                /* push di */
            ii(0x14_0a93, 1); pushw(si);                                /* push si */
            ii(0x14_0a94, 1); pushw(ds);                                /* push ds */
            ii(0x14_0a95, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x14_0a98, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x14_0a9a, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x14_0a9d, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x14_0aa0, 3); callw(0x14_0a56, -0x4d);                  /* call 0xa56 */
            ii(0x14_0aa3, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x14_0aa5, 2); if(jnzw(0x14_0aac, 0x5)) goto l_0x14_0aac; /* jnz 0xaac */
            ii(0x14_0aa7, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x14_0aaa, 2); jmpw(0x14_0aea, 0x3e); goto l_0x14_0aea;  /* jmp 0xaea */
        l_0x14_0aac:
            ii(0x14_0aac, 3); callw(0x14_0a40, -0x6f);                  /* call 0xa40 */
            ii(0x14_0aaf, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x14_0ab1, 2); if(jzw(0x14_0ac4, 0x11)) goto l_0x14_0ac4; /* jz 0xac4 */
            ii(0x14_0ab3, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x14_0ab6, 3); shr(ax, 0x3);                             /* shr ax, 0x3 */
            ii(0x14_0ab9, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x14_0abb, 3); mov(cx, 0x50);                            /* mov cx, 0x50 */
            ii(0x14_0abe, 2); mov(es, cx);                              /* mov es, cx */
            ii(0x14_0ac0, 4); or(memb_a16[es, bx], 0x40);               /* or byte [es:bx], 0x40 */
        l_0x14_0ac4:
            ii(0x14_0ac4, 1); pushw(di);                                /* push di */
            ii(0x14_0ac5, 1); pushw(si);                                /* push si */
            ii(0x14_0ac6, 3); mov(ax, 0x6);                             /* mov ax, 0x6 */
            ii(0x14_0ac9, 3); mov(bx, memw_a16[ss, bp - 0x2]);          /* mov bx, [bp-0x2] */
            ii(0x14_0acc, 3); lsl(di, bx);                              /* lsl di, bx */
            ii(0x14_0acf, 2); xor(si, si);                              /* xor si, si */
            ii(0x14_0ad1, 2); @int(0x31);                               /* int 0x31 */
            ii(0x14_0ad3, 2); mov(bx, cx);                              /* mov bx, cx */
            ii(0x14_0ad5, 2); mov(cx, dx);                              /* mov cx, dx */
            ii(0x14_0ad7, 3); mov(ax, 0x600);                           /* mov ax, 0x600 */
            ii(0x14_0ada, 2); @int(0x31);                               /* int 0x31 */
            ii(0x14_0adc, 1); popw(si);                                 /* pop si */
            ii(0x14_0add, 1); popw(di);                                 /* pop di */
            ii(0x14_0ade, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x14_0ae1, 1); cmc();                                    /* cmc */
            ii(0x14_0ae2, 2); rcl(ax, 0x1);                             /* rcl ax, 1 */
            ii(0x14_0ae4, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x14_0ae7, 3); mov(ax, memw_a16[ss, bp - 0x8]);          /* mov ax, [bp-0x8] */
        l_0x14_0aea:
            ii(0x14_0aea, 1); popw(ds);                                 /* pop ds */
            ii(0x14_0aeb, 1); popw(si);                                 /* pop si */
            ii(0x14_0aec, 1); popw(di);                                 /* pop di */
            ii(0x14_0aed, 1); leavew();                                 /* leave */
            ii(0x14_0aee, 3); retw(0x4); return;                        /* ret 0x4 */
        }
    }
}
