using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_00c4-14d3947b")]
        public void /* sys */ Method_1019_00c4()
        {
            ii(0x1019_00c4, 6); mov(edx, memd[ds, 0x1020_9cd0]);        /* mov edx, [0x10209cd0] */
            ii(0x1019_00ca, 2); mov(eax, memd[ds, esi]);                /* mov eax, [esi] */
            ii(0x1019_00cc, 2); mov(memd[ds, edi], eax);                /* mov [edi], eax */
            ii(0x1019_00ce, 3); mov(eax, memd[ds, esi + 4]);            /* mov eax, [esi+0x4] */
            ii(0x1019_00d1, 3); mov(memd[ds, edi + 4], eax);            /* mov [edi+0x4], eax */
            ii(0x1019_00d4, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_00d6, 3); mov(eax, memd[ds, esi + 8]);            /* mov eax, [esi+0x8] */
            ii(0x1019_00d9, 2); mov(memd[ds, edi], eax);                /* mov [edi], eax */
            ii(0x1019_00db, 3); mov(eax, memd[ds, esi + 0xc]);          /* mov eax, [esi+0xc] */
            ii(0x1019_00de, 3); mov(memd[ds, edi + 4], eax);            /* mov [edi+0x4], eax */
            ii(0x1019_00e1, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_00e3, 3); mov(eax, memd[ds, esi + 0x10]);         /* mov eax, [esi+0x10] */
            ii(0x1019_00e6, 2); mov(memd[ds, edi], eax);                /* mov [edi], eax */
            ii(0x1019_00e8, 3); mov(eax, memd[ds, esi + 0x14]);         /* mov eax, [esi+0x14] */
            ii(0x1019_00eb, 3); mov(memd[ds, edi + 4], eax);            /* mov [edi+0x4], eax */
            ii(0x1019_00ee, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_00f0, 3); mov(eax, memd[ds, esi + 0x18]);         /* mov eax, [esi+0x18] */
            ii(0x1019_00f3, 2); mov(memd[ds, edi], eax);                /* mov [edi], eax */
            ii(0x1019_00f5, 3); mov(eax, memd[ds, esi + 0x1c]);         /* mov eax, [esi+0x1c] */
            ii(0x1019_00f8, 3); mov(memd[ds, edi + 4], eax);            /* mov [edi+0x4], eax */
            ii(0x1019_00fb, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_00fd, 3); mov(eax, memd[ds, esi + 0x20]);         /* mov eax, [esi+0x20] */
            ii(0x1019_0100, 2); mov(memd[ds, edi], eax);                /* mov [edi], eax */
            ii(0x1019_0102, 3); mov(eax, memd[ds, esi + 0x24]);         /* mov eax, [esi+0x24] */
            ii(0x1019_0105, 3); mov(memd[ds, edi + 4], eax);            /* mov [edi+0x4], eax */
            ii(0x1019_0108, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_010a, 3); mov(eax, memd[ds, esi + 0x28]);         /* mov eax, [esi+0x28] */
            ii(0x1019_010d, 2); mov(memd[ds, edi], eax);                /* mov [edi], eax */
            ii(0x1019_010f, 3); mov(eax, memd[ds, esi + 0x2c]);         /* mov eax, [esi+0x2c] */
            ii(0x1019_0112, 3); mov(memd[ds, edi + 4], eax);            /* mov [edi+0x4], eax */
            ii(0x1019_0115, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_0117, 3); mov(eax, memd[ds, esi + 0x30]);         /* mov eax, [esi+0x30] */
            ii(0x1019_011a, 2); mov(memd[ds, edi], eax);                /* mov [edi], eax */
            ii(0x1019_011c, 3); mov(eax, memd[ds, esi + 0x34]);         /* mov eax, [esi+0x34] */
            ii(0x1019_011f, 3); mov(memd[ds, edi + 4], eax);            /* mov [edi+0x4], eax */
            ii(0x1019_0122, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_0124, 3); mov(eax, memd[ds, esi + 0x38]);         /* mov eax, [esi+0x38] */
            ii(0x1019_0127, 2); mov(memd[ds, edi], eax);                /* mov [edi], eax */
            ii(0x1019_0129, 3); mov(eax, memd[ds, esi + 0x3c]);         /* mov eax, [esi+0x3c] */
            ii(0x1019_012c, 3); mov(memd[ds, edi + 4], eax);            /* mov [edi+0x4], eax */
            ii(0x1019_012f, 3); add(esi, 0x40);                         /* add esi, 0x40 */
            ii(0x1019_0132, 3); sub(edi, memd[ss, ebp - 0x10]);         /* sub edi, [ebp-0x10] */
            ii(0x1019_0135, 1); ret();                                  /* ret */
        }
    }
}
