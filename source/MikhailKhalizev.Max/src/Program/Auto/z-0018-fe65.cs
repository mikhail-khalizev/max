using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_fe65-67c544cf")]
        public void Method_0018_fe65()
        {
            ii(0x18_fe65, 4); enterw(0, 0);                             /* enter 0x0, 0x0 */
            ii(0x18_fe69, 4); movzx(eax, sp);                           /* movzx eax, sp */
            ii(0x18_fe6d, 3); sub(ax, 0x60c);                           /* sub ax, 0x60c */
            ii(0x18_fe70, 3); and(ax, 0xfffc);                          /* and ax, 0xfffc */
            ii(0x18_fe73, 4); mov(memd_a16[ds, 0xa42], eax);            /* mov [0xa42], eax */
            ii(0x18_fe77, 4); mov(memd_a16[ds, 0xa46], eax);            /* mov [0xa46], eax */
            ii(0x18_fe7b, 1); pushw(ds);                                /* push ds */
            ii(0x18_fe7c, 3); mov(ax, 0xff80);                          /* mov ax, 0xff80 */
            ii(0x18_fe7f, 3); mov(dx, 0x1301);                          /* mov dx, 0x1301 */
            ii(0x18_fe82, 2); mov(cx, cs);                              /* mov cx, cs */
            ii(0x18_fe84, 2); mov(ds, cx);                              /* mov ds, cx */
            ii(0x18_fe86, 2); mov(es, cx);                              /* mov es, cx */
            ii(0x18_fe88, 2); @int(0x21);                               /* int 0x21 */
            ii(0x18_fe8a, 1); popw(ds);                                 /* pop ds */
            ii(0x18_fe8b, 2); xor(si, si);                              /* xor si, si */
            ii(0x18_fe8d, 1); cli();                                    /* cli */
        l_0x18_fe8e:
            ii(0x18_fe8e, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x18_fe91, 1); pushw(si);                                /* push si */
            ii(0x18_fe92, 1); nop();                                    /* nop */
            ii(0x18_fe93, 1); pushw(cs);                                /* push cs */
            ii(0x18_fe94, 3); callw(0x18_fef0, 0x59);                   /* call 0xfef0 */
            ii(0x18_fe97, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x18_fe99, 1); popw(si);                                 /* pop si */
            ii(0x18_fe9a, 1); popw(ax);                                 /* pop ax */
            ii(0x18_fe9b, 4); if(jzw(0x18_feb9, 0x1a)) goto l_0x18_feb9; /* jz 0xfeb9 */
            ii(0x18_fe9f, 1); inc(si);                                  /* inc si */
            ii(0x18_fea0, 4); cmp(si, 0x120);                           /* cmp si, 0x120 */
            ii(0x18_fea4, 2); if(jbw(0x18_fe8e, -0x18)) goto l_0x18_fe8e; /* jb 0xfe8e */
            ii(0x18_fea6, 3); mov(ax, 0x205);                           /* mov ax, 0x205 */
            ii(0x18_fea9, 2); mov(bl, 0xfc);                            /* mov bl, 0xfc */
            ii(0x18_feab, 2); mov(cx, cs);                              /* mov cx, cs */
            ii(0x18_fead, 3); sub(edx, edx);                            /* sub edx, edx */
            ii(0x18_feb0, 3); mov(dx, 0xa2e);                           /* mov dx, 0xa2e */
            ii(0x18_feb3, 2); @int(0x31);                               /* int 0x31 */
            ii(0x18_feb5, 4); if(jaew(0x18_febb, 0x2)) goto l_0x18_febb; /* jae 0xfebb */
        l_0x18_feb9:
            ii(0x18_feb9, 2); sub(ax, ax);                              /* sub ax, ax */
        l_0x18_febb:
            ii(0x18_febb, 1); sti();                                    /* sti */
            ii(0x18_febc, 1); popw(bp);                                 /* pop bp */
            ii(0x18_febd, 1); retfw(); return;                          /* retf */
        }
    }
}
