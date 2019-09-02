using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_1077-9654aa5f")]
        public void /* sys */ Method_1018_1077()
        {
            ii(0x1018_1077, 2); or(ecx, ecx);                           /* or ecx, ecx */
            ii(0x1018_1079, 2); if(jz(0x1018_10e2, 0x67)) goto l_0x1018_10e2; /* jz 0x101810e2 */
        l_0x1018_107b:
            ii(0x1018_107b, 2); test(al, 0x1f);                         /* test al, 0x1f */
            ii(0x1018_107d, 2); if(jz(0x1018_1087, 8)) goto l_0x1018_1087; /* jz 0x10181087 */
            ii(0x1018_107f, 2); mov(memd[ds, eax], edx);                /* mov [eax], edx */
            ii(0x1018_1081, 3); lea(eax, memd[ds, eax + 4]);            /* lea eax, [eax+0x4] */
            ii(0x1018_1084, 1); dec(ecx);                               /* dec ecx */
            ii(0x1018_1085, 2); if(jnz(0x1018_107b, -0xc)) goto l_0x1018_107b; /* jnz 0x1018107b */
        l_0x1018_1087:
            ii(0x1018_1087, 1); push(ecx);                              /* push ecx */
            ii(0x1018_1088, 3); shr(ecx, 2);                            /* shr ecx, 0x2 */
            ii(0x1018_108b, 2); if(jz(0x1018_10c7, 0x3a)) goto l_0x1018_10c7; /* jz 0x101810c7 */
            ii(0x1018_108d, 1); dec(ecx);                               /* dec ecx */
            ii(0x1018_108e, 2); if(jz(0x1018_10b9, 0x29)) goto l_0x1018_10b9; /* jz 0x101810b9 */
        l_0x1018_1090:
            ii(0x1018_1090, 2); mov(memd[ds, eax], edx);                /* mov [eax], edx */
            ii(0x1018_1092, 3); mov(memd[ds, eax + 4], edx);            /* mov [eax+0x4], edx */
            ii(0x1018_1095, 1); dec(ecx);                               /* dec ecx */
            ii(0x1018_1096, 3); mov(memd[ds, eax + 8], edx);            /* mov [eax+0x8], edx */
            ii(0x1018_1099, 3); mov(memd[ds, eax + 0xc], edx);          /* mov [eax+0xc], edx */
            ii(0x1018_109c, 2); if(jz(0x1018_10b6, 0x18)) goto l_0x1018_10b6; /* jz 0x101810b6 */
            ii(0x1018_109e, 3); cmp(memb[ds, eax + 0x20], dl);          /* cmp [eax+0x20], dl */
            ii(0x1018_10a1, 3); mov(memd[ds, eax + 0x10], edx);         /* mov [eax+0x10], edx */
            ii(0x1018_10a4, 3); mov(memd[ds, eax + 0x14], edx);         /* mov [eax+0x14], edx */
            ii(0x1018_10a7, 1); dec(ecx);                               /* dec ecx */
            ii(0x1018_10a8, 3); mov(memd[ds, eax + 0x18], edx);         /* mov [eax+0x18], edx */
            ii(0x1018_10ab, 3); mov(memd[ds, eax + 0x1c], edx);         /* mov [eax+0x1c], edx */
            ii(0x1018_10ae, 3); lea(eax, memd[ds, eax + 0x20]);         /* lea eax, [eax+0x20] */
            ii(0x1018_10b1, 2); if(jnz(0x1018_1090, -0x23)) goto l_0x1018_1090; /* jnz 0x10181090 */
            ii(0x1018_10b3, 3); lea(eax, memd[ds, eax - 0x10]);         /* lea eax, [eax-0x10] */
        l_0x1018_10b6:
            ii(0x1018_10b6, 3); lea(eax, memd[ds, eax + 0x10]);         /* lea eax, [eax+0x10] */
        l_0x1018_10b9:
            ii(0x1018_10b9, 2); mov(memd[ds, eax], edx);                /* mov [eax], edx */
            ii(0x1018_10bb, 3); mov(memd[ds, eax + 4], edx);            /* mov [eax+0x4], edx */
            ii(0x1018_10be, 3); mov(memd[ds, eax + 8], edx);            /* mov [eax+0x8], edx */
            ii(0x1018_10c1, 3); mov(memd[ds, eax + 0xc], edx);          /* mov [eax+0xc], edx */
            ii(0x1018_10c4, 3); lea(eax, memd[ds, eax + 0x10]);         /* lea eax, [eax+0x10] */
        l_0x1018_10c7:
            ii(0x1018_10c7, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_10c8, 3); and(ecx, 3);                            /* and ecx, 0x3 */
            ii(0x1018_10cb, 2); if(jz(0x1018_10e2, 0x15)) goto l_0x1018_10e2; /* jz 0x101810e2 */
            ii(0x1018_10cd, 2); mov(memd[ds, eax], edx);                /* mov [eax], edx */
            ii(0x1018_10cf, 3); lea(eax, memd[ds, eax + 4]);            /* lea eax, [eax+0x4] */
            ii(0x1018_10d2, 1); dec(ecx);                               /* dec ecx */
            ii(0x1018_10d3, 2); if(jz(0x1018_10e2, 0xd)) goto l_0x1018_10e2; /* jz 0x101810e2 */
            ii(0x1018_10d5, 2); mov(memd[ds, eax], edx);                /* mov [eax], edx */
            ii(0x1018_10d7, 3); lea(eax, memd[ds, eax + 4]);            /* lea eax, [eax+0x4] */
            ii(0x1018_10da, 1); dec(ecx);                               /* dec ecx */
            ii(0x1018_10db, 2); if(jz(0x1018_10e2, 5)) goto l_0x1018_10e2; /* jz 0x101810e2 */
            ii(0x1018_10dd, 2); mov(memd[ds, eax], edx);                /* mov [eax], edx */
            ii(0x1018_10df, 3); lea(eax, memd[ds, eax + 4]);            /* lea eax, [eax+0x4] */
        l_0x1018_10e2:
            ii(0x1018_10e2, 1); ret();                                  /* ret */
        }
    }
}
