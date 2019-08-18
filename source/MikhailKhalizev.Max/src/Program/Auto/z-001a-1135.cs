using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d3d8f7ed-c2bb-4b65-9270-308dd5f6981e")]
        public void Method_001a_1135()
        {
            ii(0x1a_1135, 4); enterw(0x14, 0);                          /* enter 0x14, 0x0 */
            ii(0x1a_1139, 1); pushw(ds);                                /* push ds */
            ii(0x1a_113a, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x1a_113d, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x1a_113f, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x1a_1141, 3); mov(memw_a16[ss, bp - 0x14], ax);         /* mov [bp-0x14], ax */
            ii(0x1a_1144, 3); mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0x1a_1147, 3); mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0x1a_114a, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x1a_114d, 3); mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x1a_1150, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x1a_1153, 3); mov(ax, memw_a16[ss, bp + 0xc]);          /* mov ax, [bp+0xc] */
            ii(0x1a_1156, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x1a_1159, 3); lea(ax, bp - 0x14);                       /* lea ax, [bp-0x14] */
            ii(0x1a_115c, 1); pushw(ss);                                /* push ss */
            ii(0x1a_115d, 1); pushw(ax);                                /* push ax */
            ii(0x1a_115e, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x1a_1161, 3); or(ah, 0x42);                             /* or ah, 0x42 */
            ii(0x1a_1164, 1); pushw(ax);                                /* push ax */
            ii(0x1a_1165, 5); callw_far_abs(0x80, 0x4c9f);              /* call word 0x80:0x4c9f */
            ii(0x1a_116a, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x1a_116d, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x1a_116f, 2); if(jzw(0x1a_1179, 0x8)) goto l_0x1a_1179; /* jz 0x1179 */
            ii(0x1a_1171, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x1a_1174, 3); mov(dx, memw_a16[ss, bp - 0x6]);          /* mov dx, [bp-0x6] */
            ii(0x1a_1177, 2); jmpw(0x1a_117d, 0x4); goto l_0x1a_117d;   /* jmp 0x117d */
        l_0x1a_1179:
            ii(0x1a_1179, 3); mov(ax, 0xffff);                          /* mov ax, 0xffff */
            ii(0x1a_117c, 1); cwd();                                    /* cwd */
        l_0x1a_117d:
            ii(0x1a_117d, 1); popw(ds);                                 /* pop ds */
            ii(0x1a_117e, 1); leavew();                                 /* leave */
            ii(0x1a_117f, 3); retfw(0x8); return;                       /* retf 0x8 */
        }
    }
}
