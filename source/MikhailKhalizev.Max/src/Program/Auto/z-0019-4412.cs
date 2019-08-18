using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("087c6e6e-4065-4568-8370-49009c80cb02")]
        public void Method_0019_4412()
        {
            ii(0x19_4412, 4); enterw(0x1c, 0);                          /* enter 0x1c, 0x0 */
            ii(0x19_4416, 1); pushw(di);                                /* push di */
            ii(0x19_4417, 1); pushw(si);                                /* push si */
            ii(0x19_4418, 1); pushw(ds);                                /* push ds */
            ii(0x19_4419, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_441c, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_441e, 1); nop();                                    /* nop */
            ii(0x19_441f, 1); pushw(cs);                                /* push cs */
            ii(0x19_4420, 3); callw(0x19_4638, 0x215);                  /* call 0x4638 */
            ii(0x19_4423, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_4425, 2); if(jzw(0x19_4446, 0x1f)) goto l_0x19_4446; /* jz 0x4446 */
            ii(0x19_4427, 3); mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x19_442a, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x19_442d, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x19_4430, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_4432, 3); lea(ax, bp - 0x14);                       /* lea ax, [bp-0x14] */
            ii(0x19_4435, 1); pushw(ss);                                /* push ss */
            ii(0x19_4436, 1); pushw(ax);                                /* push ax */
            ii(0x19_4437, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_443a, 2); pushw(0xb);                               /* push 0xb */
            ii(0x19_443c, 1); nop();                                    /* nop */
            ii(0x19_443d, 1); pushw(cs);                                /* push cs */
            ii(0x19_443e, 3); callw(0x19_41fd, -0x244);                 /* call 0x41fd */
            ii(0x19_4441, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x19_4444, 2); jmpw(0x19_447c, 0x36); goto l_0x19_447c;  /* jmp 0x447c */
        l_0x19_4446:
            ii(0x19_4446, 3); mov(ax, memw_a16[ds, 0x3b72]);            /* mov ax, [0x3b72] */
            ii(0x19_4449, 3); mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x19_444c, 5); mov(memw_a16[ss, bp - 0x1c], 0);          /* mov word [bp-0x1c], 0x0 */
            ii(0x19_4451, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x19_4454, 2); and(al, 0xf8);                            /* and al, 0xf8 */
            ii(0x19_4456, 3); add(ax, memw_a16[ss, bp - 0x1c]);         /* add ax, [bp-0x1c] */
            ii(0x19_4459, 3); mov(dx, memw_a16[ss, bp - 0x1a]);         /* mov dx, [bp-0x1a] */
            ii(0x19_445c, 3); mov(memw_a16[ss, bp - 0x18], ax);         /* mov [bp-0x18], ax */
            ii(0x19_445f, 3); mov(memw_a16[ss, bp - 0x16], dx);         /* mov [bp-0x16], dx */
            ii(0x19_4462, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x19_4465, 2); mov(di, bx);                              /* mov di, bx */
            ii(0x19_4467, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x19_4469, 1); pushw(ds);                                /* push ds */
            ii(0x19_446a, 2); mov(ds, dx);                              /* mov ds, dx */
            ii(0x19_446c, 1); movsw_a16();                              /* movsw */
            ii(0x19_446d, 1); movsw_a16();                              /* movsw */
            ii(0x19_446e, 1); movsw_a16();                              /* movsw */
            ii(0x19_446f, 1); movsw_a16();                              /* movsw */
            ii(0x19_4470, 1); popw(ds);                                 /* pop ds */
            ii(0x19_4471, 3); les(bx, ss, bp - 0x18);                   /* les bx, [bp-0x18] */
            ii(0x19_4474, 5); cmp(memb_a16[es, bx + 0x5], 0x1);         /* cmp byte [es:bx+0x5], 0x1 */
            ii(0x19_4479, 2); sbb(ax, ax);                              /* sbb ax, ax */
            ii(0x19_447b, 1); inc(ax);                                  /* inc ax */
        l_0x19_447c:
            ii(0x19_447c, 3); mov(memw_a16[ss, bp + 0x6], ax);          /* mov [bp+0x6], ax */
            ii(0x19_447f, 1); popw(ds);                                 /* pop ds */
            ii(0x19_4480, 1); popw(si);                                 /* pop si */
            ii(0x19_4481, 1); popw(di);                                 /* pop di */
            ii(0x19_4482, 1); leavew();                                 /* leave */
            ii(0x19_4483, 1); retfw(); return;                          /* retf */
        }
    }
}
