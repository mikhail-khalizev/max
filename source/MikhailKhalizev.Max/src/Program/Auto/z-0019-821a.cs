using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ead3b77d-eecc-49e7-ba17-27174e427159")]
        public void Method_0019_821a()
        {
            ii(0x19_821a, 4); enterw(0x4, 0);                           /* enter 0x4, 0x0 */
            ii(0x19_821e, 1); pushw(di);                                /* push di */
            ii(0x19_821f, 1); pushw(si);                                /* push si */
            ii(0x19_8220, 5); cmp(memw_a16[ds, 0x16d8], 0);             /* cmp word [0x16d8], 0x0 */
            ii(0x19_8225, 2); if(jzw(0x19_822a, 0x3)) goto l_0x19_822a; /* jz 0x822a */
            ii(0x19_8227, 3); jmpw(0x19_825b, 0x31); goto l_0x19_825b;  /* jmp 0x825b */
        l_0x19_822a:
            ii(0x19_822a, 6); mov(memw_a16[ds, 0x16d8], 0x1);           /* mov word [0x16d8], 0x1 */
            ii(0x19_8230, 1); pushw(ds);                                /* push ds */
            ii(0x19_8231, 3); pushw(0x16b3);                            /* push 0x16b3 */
            ii(0x19_8234, 1); pushw(ds);                                /* push ds */
            ii(0x19_8235, 3); pushw(0x16aa);                            /* push 0x16aa */
            ii(0x19_8238, 3); callw(0x19_fcad, 0x7a72);                 /* call 0xfcad */
            ii(0x19_823b, 3); mov(memw_a16[ds, 0x16d4], ax);            /* mov [0x16d4], ax */
            ii(0x19_823e, 4); mov(memw_a16[ds, 0x16d6], dx);            /* mov [0x16d6], dx */
            ii(0x19_8242, 3); mov(ax, memw_a16[ds, 0x16d6]);            /* mov ax, [0x16d6] */
            ii(0x19_8245, 4); or(ax, memw_a16[ds, 0x16d4]);             /* or ax, [0x16d4] */
            ii(0x19_8249, 2); if(jzw(0x19_824e, 0x3)) goto l_0x19_824e; /* jz 0x824e */
            ii(0x19_824b, 3); jmpw(0x19_825b, 0xd); goto l_0x19_825b;   /* jmp 0x825b */
        l_0x19_824e:
            ii(0x19_824e, 3); jmpw(0x19_825b, 0xa); goto l_0x19_825b;   /* jmp 0x825b */
        //    ii(0x19_8251, 1); pushw(ds);                                /* push ds */
        //    ii(0x19_8252, 3); pushw(0x16bc);                            /* push 0x16bc */
        //    ii(0x19_8255, 3); callw(0x19_1066, -0x71f2);                /* call 0x1066 */
        //    ii(0x19_8258, 3); add(sp, 0x4);                             /* add sp, 0x4 */
        l_0x19_825b:
            ii(0x19_825b, 3); mov(ax, memw_a16[ds, 0x16d6]);            /* mov ax, [0x16d6] */
            ii(0x19_825e, 4); or(ax, memw_a16[ds, 0x16d4]);             /* or ax, [0x16d4] */
            ii(0x19_8262, 2); if(jnzw(0x19_8267, 0x3)) goto l_0x19_8267; /* jnz 0x8267 */
            ii(0x19_8264, 3); jmpw(0x19_826d, 0x6); goto l_0x19_826d;   /* jmp 0x826d */
        l_0x19_8267:
            ii(0x19_8267, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x19_826a, 3); jmpw(0x19_8270, 0x3); goto l_0x19_8270;   /* jmp 0x8270 */
        l_0x19_826d:
            ii(0x19_826d, 3); mov(ax, 0);                               /* mov ax, 0x0 */
        l_0x19_8270:
            ii(0x19_8270, 3); jmpw(0x19_8273, 0); goto l_0x19_8273;     /* jmp 0x8273 */
        l_0x19_8273:
            ii(0x19_8273, 1); popw(si);                                 /* pop si */
            ii(0x19_8274, 1); popw(di);                                 /* pop di */
            ii(0x19_8275, 1); leavew();                                 /* leave */
            ii(0x19_8276, 1); retfw(); return;                          /* retf */
        }
    }
}
