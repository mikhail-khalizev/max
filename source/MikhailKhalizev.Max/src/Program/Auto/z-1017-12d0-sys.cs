using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_12d0-f68f08bc")]
        public void /* sys */ Method_1017_12d0()
        {
            ii(0x1017_12d0, 1); push(esi);                              /* push esi */
            ii(0x1017_12d1, 1); push(edi);                              /* push edi */
            ii(0x1017_12d2, 4); mov(edi, memd[ss, esp + 0x1c]);         /* mov edi, [esp+0x1c] */
            ii(0x1017_12d6, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1017_12d8, 4); mov(eax, memd[ss, esp + 0x18]);         /* mov eax, [esp+0x18] */
            ii(0x1017_12dc, 6); mov(memd[ds, 0x1020_8928], edx);        /* mov [0x10208928], edx */
            ii(0x1017_12e2, 6); mov(memd[ds, 0x1020_8920], edx);        /* mov [0x10208920], edx */
            ii(0x1017_12e8, 4); mov(edx, memd[ss, esp + 0xc]);          /* mov edx, [esp+0xc] */
            ii(0x1017_12ec, 6); mov(memd[ds, 0x1020_891c], esi);        /* mov [0x1020891c], esi */
            ii(0x1017_12f2, 6); mov(memd[ds, Definitions.video_win_start_v2], edx); /* mov [0x10208918], edx */
            ii(0x1017_12f8, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1017_12fa, 6); mov(memd[ds, 0x1020_8924], esi);        /* mov [0x10208924], esi */
            ii(0x1017_1300, 6); mov(memd[ds, 0x1020_8910], edx);        /* mov [0x10208910], edx */
            ii(0x1017_1306, 4); mov(edx, memd[ss, esp + 0x10]);         /* mov edx, [esp+0x10] */
            ii(0x1017_130a, 6); mov(memd[ds, 0x1020_88f8], ebx);        /* mov [0x102088f8], ebx */
            ii(0x1017_1310, 6); mov(memd[ds, 0x1020_8904], edx);        /* mov [0x10208904], edx */
            ii(0x1017_1316, 4); mov(edx, memd[ss, esp + 0x14]);         /* mov edx, [esp+0x14] */
            ii(0x1017_131a, 6); mov(memd[ds, 0x1020_8900], ecx);        /* mov [0x10208900], ecx */
            ii(0x1017_1320, 6); mov(memd[ds, 0x1020_890c], edx);        /* mov [0x1020890c], edx */
            ii(0x1017_1326, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1017_1328, 5); mov(memd[ds, 0x1020_8914], eax);        /* mov [0x10208914], eax */
            ii(0x1017_132d, 6); mov(memd[ds, 0x1020_88f4], edx);        /* mov [0x102088f4], edx */
            ii(0x1017_1333, 4); mov(edx, memd[ss, esp + 0x20]);         /* mov edx, [esp+0x20] */
            ii(0x1017_1337, 6); mov(memd[ds, 0x1020_8908], edi);        /* mov [0x10208908], edi */
            ii(0x1017_133d, 6); mov(memd[ds, 0x1020_88fc], edx);        /* mov [0x102088fc], edx */
            ii(0x1017_1343, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1017_1345, 2); if(jz(0x1017_134f, 0x8)) goto l_0x1017_134f; /* jz 0x1017134f */
            ii(0x1017_1347, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_1349, 2); div(edi);                               /* div edi */
            ii(0x1017_134b, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_134d, 2); jmp(0x1017_1354, 0x5); goto l_0x1017_1354; /* jmp 0x10171354 */
        l_0x1017_134f:
            ii(0x1017_134f, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
        l_0x1017_1354:
            ii(0x1017_1354, 6); mov(memd[ds, 0x1020_88f0], ebx);        /* mov [0x102088f0], ebx */
            ii(0x1017_135a, 1); pop(edi);                               /* pop edi */
            ii(0x1017_135b, 1); pop(esi);                               /* pop esi */
            ii(0x1017_135c, 3); ret(0x18);                              /* ret 0x18 */
        }
    }
}
