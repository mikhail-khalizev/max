using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_0809-fd94ea11")]
        public void Method_001a_0809()
        {
            ii(0x1a_0809, 4); enterw(0x8, 0);                           /* enter 0x8, 0x0 */
            ii(0x1a_080d, 1); pushw(ds);                                /* push ds */
            ii(0x1a_080e, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x1a_0811, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x1a_0813, 1); pushw(ds);                                /* push ds */
            ii(0x1a_0814, 3); pushw(0x378d);                            /* push 0x378d */
            ii(0x1a_0817, 1); pushw(ds);                                /* push ds */
            ii(0x1a_0818, 3); pushw(0x33b4);                            /* push 0x33b4 */
            ii(0x1a_081b, 1); pushw(ds);                                /* push ds */
            ii(0x1a_081c, 3); pushw(0x3795);                            /* push 0x3795 */
            ii(0x1a_081f, 1); pushw(ds);                                /* push ds */
            ii(0x1a_0820, 3); pushw(0x379d);                            /* push 0x379d */
            ii(0x1a_0823, 1); pushw(cs);                                /* push cs */
            ii(0x1a_0824, 3); callw(0x1a_06c5, -0x162);                 /* call 0x6c5 */
            ii(0x1a_0827, 3); add(sp, 0x10);                            /* add sp, 0x10 */
            ii(0x1a_082a, 1); pushw(ds);                                /* push ds */
            ii(0x1a_082b, 3); pushw(0x37a4);                            /* push 0x37a4 */
            ii(0x1a_082e, 1); pushw(ds);                                /* push ds */
            ii(0x1a_082f, 3); pushw(0x34b4);                            /* push 0x34b4 */
            ii(0x1a_0832, 1); pushw(ds);                                /* push ds */
            ii(0x1a_0833, 3); pushw(0x37af);                            /* push 0x37af */
            ii(0x1a_0836, 1); pushw(ds);                                /* push ds */
            ii(0x1a_0837, 3); pushw(0x37b9);                            /* push 0x37b9 */
            ii(0x1a_083a, 1); pushw(cs);                                /* push cs */
            ii(0x1a_083b, 3); callw(0x1a_06c5, -0x179);                 /* call 0x6c5 */
            ii(0x1a_083e, 3); add(sp, 0x10);                            /* add sp, 0x10 */
            ii(0x1a_0841, 1); pushw(ds);                                /* push ds */
            ii(0x1a_0842, 3); pushw(0x32b4);                            /* push 0x32b4 */
            ii(0x1a_0845, 1); pushw(ds);                                /* push ds */
            ii(0x1a_0846, 3); pushw(0x37c0);                            /* push 0x37c0 */
            ii(0x1a_0849, 3); callw(0x19_ff6c, -0x8e0);                 /* call 0xff6c */
            ii(0x1a_084c, 1); pushw(ds);                                /* push ds */
            ii(0x1a_084d, 3); pushw(0x37c2);                            /* push 0x37c2 */
            ii(0x1a_0850, 1); pushw(cs);                                /* push cs */
            ii(0x1a_0851, 3); callw(0x1a_0409, -0x44b);                 /* call 0x409 */
            ii(0x1a_0854, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x1a_0857, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x1a_085a, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x1a_085c, 2); if(jzw(0x1a_0869, 0xb)) goto l_0x1a_0869; /* jz 0x869 */
            ii(0x1a_085e, 1); pushw(ds);                                /* push ds */
            ii(0x1a_085f, 3); pushw(0x35b4);                            /* push 0x35b4 */
            ii(0x1a_0862, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x1a_0865, 1); pushw(ax);                                /* push ax */
            ii(0x1a_0866, 3); callw(0x19_ff6c, -0x8fd);                 /* call 0xff6c */
        l_0x1a_0869:
            ii(0x1a_0869, 1); pushw(ds);                                /* push ds */
            ii(0x1a_086a, 3); pushw(0x37c7);                            /* push 0x37c7 */
            ii(0x1a_086d, 1); pushw(cs);                                /* push cs */
            ii(0x1a_086e, 3); callw(0x1a_0409, -0x468);                 /* call 0x409 */
            ii(0x1a_0871, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x1a_0874, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x1a_0877, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x1a_0879, 2); if(jzw(0x1a_08be, 0x43)) goto l_0x1a_08be; /* jz 0x8be */
            ii(0x1a_087b, 1); pushw(ds);                                /* push ds */
            ii(0x1a_087c, 3); pushw(0x36b4);                            /* push 0x36b4 */
            ii(0x1a_087f, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x1a_0882, 1); pushw(ax);                                /* push ax */
            ii(0x1a_0883, 3); callw(0x19_ff6c, -0x91a);                 /* call 0xff6c */
            ii(0x1a_0886, 1); pushw(ds);                                /* push ds */
            ii(0x1a_0887, 3); pushw(0x36b4);                            /* push 0x36b4 */
            ii(0x1a_088a, 1); pushw(cs);                                /* push cs */
            ii(0x1a_088b, 3); callw(0x1a_0330, -0x55e);                 /* call 0x330 */
            ii(0x1a_088e, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x1a_0891, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x1a_0894, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x1a_0896, 2); if(jzw(0x1a_08be, 0x26)) goto l_0x1a_08be; /* jz 0x8be */
            ii(0x1a_0898, 5); mov(memw_a16[ss, bp - 0x8], 0x36f3);      /* mov word [bp-0x8], 0x36f3 */
            ii(0x1a_089d, 3); mov(memw_a16[ss, bp - 0x6], ds);          /* mov [bp-0x6], ds */
            ii(0x1a_08a0, 2); jmpw(0x1a_08af, 0xd); goto l_0x1a_08af;   /* jmp 0x8af */
        l_0x1a_08a2:
            ii(0x1a_08a2, 3); les(bx, ss, bp - 0x8);                    /* les bx, [bp-0x8] */
            ii(0x1a_08a5, 3); mov(al, memb_a16[es, bx]);                /* mov al, [es:bx] */
            ii(0x1a_08a8, 4); mov(memb_a16[es, bx + 0x1], al);          /* mov [es:bx+0x1], al */
            ii(0x1a_08ac, 3); dec(memw_a16[ss, bp - 0x8]);              /* dec word [bp-0x8] */
        l_0x1a_08af:
            ii(0x1a_08af, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x1a_08b2, 3); cmp(memw_a16[ss, bp - 0x8], ax);          /* cmp [bp-0x8], ax */
            ii(0x1a_08b5, 2); if(jaew(0x1a_08a2, -0x15)) goto l_0x1a_08a2; /* jae 0x8a2 */
            ii(0x1a_08b7, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x1a_08ba, 4); mov(memb_a16[es, bx], 0);                 /* mov byte [es:bx], 0x0 */
        l_0x1a_08be:
            ii(0x1a_08be, 1); popw(ds);                                 /* pop ds */
            ii(0x1a_08bf, 1); leavew();                                 /* leave */
            ii(0x1a_08c0, 1); retfw();                                  /* retf */
        }
    }
}
