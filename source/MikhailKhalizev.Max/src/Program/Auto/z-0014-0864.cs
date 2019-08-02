using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c5ebb6fd-b5d2-40b6-93b7-c014defaf071")]
        public void Method_0014_0864()
        {
            ii(0x14_0864, 4); enterw(0x14, 0);                          /* enter 0x14, 0x0 */
            ii(0x14_0868, 1); pushw(ds);                                /* push ds */
            ii(0x14_0869, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x14_086c, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x14_086e, 5); mov(memw_a16[ss, bp - 0x12], 0);          /* mov word [bp-0x12], 0x0 */
            ii(0x14_0873, 3); mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0x14_0876, 3); mov(memw_a16[ss, bp - 0x14], ax);         /* mov [bp-0x14], ax */
            ii(0x14_0879, 3); mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x14_087c, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x14_087f, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x14_0882, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x14_0885, 3); mov(ax, memw_a16[ss, bp + 0xc]);          /* mov ax, [bp+0xc] */
            ii(0x14_0888, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x14_088b, 3); lea(ax, bp - 0x14);                       /* lea ax, [bp-0x14] */
            ii(0x14_088e, 1); pushw(ss);                                /* push ss */
            ii(0x14_088f, 1); pushw(ax);                                /* push ax */
            ii(0x14_0890, 3); pushw(0x4000);                            /* push 0x4000 */
            ii(0x14_0893, 1); nop();                                    /* nop */
            ii(0x14_0894, 1); pushw(cs);                                /* push cs */
            ii(0x14_0895, 3); callw(0x13_eaed, -0x1dab);                /* call 0xeaed */
            ii(0x14_0898, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x14_089b, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x14_089d, 2); if(jzw(0x14_08a4, 0x5)) goto l_0x14_08a4; /* jz 0x8a4 */
            ii(0x14_089f, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x14_08a2, 2); jmpw(0x14_08a7, 0x3); goto l_0x14_08a7;   /* jmp 0x8a7 */
        l_0x14_08a4:
            ii(0x14_08a4, 3); mov(ax, 0xffff);                          /* mov ax, 0xffff */
        l_0x14_08a7:
            ii(0x14_08a7, 1); popw(ds);                                 /* pop ds */
            ii(0x14_08a8, 1); leavew();                                 /* leave */
            ii(0x14_08a9, 3); retfw(0x8); return;                       /* retf 0x8 */
        }
    }
}