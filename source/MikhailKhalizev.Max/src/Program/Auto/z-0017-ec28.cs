using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_ec28-44edcb47")]
        public void Method_0017_ec28()
        {
            ii(0x17_ec28, 1); push(bp);                                 /* push bp */
            ii(0x17_ec29, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_ec2b, 1); push(si);                                 /* push si */
            ii(0x17_ec2c, 2); jmp(0x17_ec4d, 0x1f); goto l_0x17_ec4d;   /* jmp 0xec4d */
        l_0x17_ec2e:
            ii(0x17_ec2e, 2); mov(ax, es);                              /* mov ax, es */
            ii(0x17_ec30, 3); les(si, ss, bp + 0xa);                    /* les si, [bp+0xa] */
            ii(0x17_ec33, 4); cmp(memb[es, si], 0);                     /* cmp byte [es:si], 0x0 */
            ii(0x17_ec37, 2); if(jz(0x17_ec56, 0x1d)) goto l_0x17_ec56; /* jz 0xec56 */
            ii(0x17_ec39, 2); mov(cx, es);                              /* mov cx, es */
            ii(0x17_ec3b, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x17_ec3d, 3); mov(al, memb[es, bx]);                    /* mov al, [es:bx] */
            ii(0x17_ec40, 2); mov(es, cx);                              /* mov es, cx */
            ii(0x17_ec42, 3); cmp(memb[es, si], al);                    /* cmp [es:si], al */
            ii(0x17_ec45, 2); if(jnz(0x17_ec56, 0xf)) goto l_0x17_ec56; /* jnz 0xec56 */
            ii(0x17_ec47, 3); inc(memw[ss, bp + 0x6]);                  /* inc word [bp+0x6] */
            ii(0x17_ec4a, 3); inc(memw[ss, bp + 0xa]);                  /* inc word [bp+0xa] */
        l_0x17_ec4d:
            ii(0x17_ec4d, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_ec50, 4); cmp(memb[es, bx], 0);                     /* cmp byte [es:bx], 0x0 */
            ii(0x17_ec54, 2); if(jnz(0x17_ec2e, -0x28)) goto l_0x17_ec2e; /* jnz 0xec2e */
        l_0x17_ec56:
            ii(0x17_ec56, 3); mov(es, memw[ss, bp + 0x8]);              /* mov es, [bp+0x8] */
            ii(0x17_ec59, 3); mov(al, memb[es, bx]);                    /* mov al, [es:bx] */
            ii(0x17_ec5c, 3); les(bx, ss, bp + 0xa);                    /* les bx, [bp+0xa] */
            ii(0x17_ec5f, 3); cmp(memb[es, bx], al);                    /* cmp [es:bx], al */
            ii(0x17_ec62, 2); if(jnz(0x17_ec6a, 0x6)) goto l_0x17_ec6a; /* jnz 0xec6a */
            ii(0x17_ec64, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x17_ec67, 1); pop(si);                                  /* pop si */
            ii(0x17_ec68, 1); leave();                                  /* leave */
            ii(0x17_ec69, 1); retf(); return;                           /* retf */
        l_0x17_ec6a:
            ii(0x17_ec6a, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_ec6c, 1); pop(si);                                  /* pop si */
            ii(0x17_ec6d, 1); leave();                                  /* leave */
            ii(0x17_ec6e, 1); retf();                                   /* retf */
        }
    }
}
