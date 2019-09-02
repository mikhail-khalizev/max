using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_0138-959644ed")]
        public void /* sys */ Method_1019_0138()
        {
            ii(0x1019_0138, 6); mov(edx, memd[ds, 0x1020_9cd0]);        /* mov edx, [0x10209cd0] */
            ii(0x1019_013e, 2); mov(eax, memd[ds, esi]);                /* mov eax, [esi] */
            ii(0x1019_0140, 2); mov(bl, ah);                            /* mov bl, ah */
            ii(0x1019_0142, 2); mov(bh, ah);                            /* mov bh, ah */
            ii(0x1019_0144, 3); shl(ebx, 0x10);                         /* shl ebx, 0x10 */
            ii(0x1019_0147, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1019_0149, 2); mov(bh, al);                            /* mov bh, al */
            ii(0x1019_014b, 2); mov(memd[ds, edi], ebx);                /* mov [edi], ebx */
            ii(0x1019_014d, 3); mov(memd[ds, edx + edi], ebx);          /* mov [edx+edi], ebx */
            ii(0x1019_0150, 3); shr(eax, 0x10);                         /* shr eax, 0x10 */
            ii(0x1019_0153, 2); mov(bl, ah);                            /* mov bl, ah */
            ii(0x1019_0155, 2); mov(bh, ah);                            /* mov bh, ah */
            ii(0x1019_0157, 3); shl(ebx, 0x10);                         /* shl ebx, 0x10 */
            ii(0x1019_015a, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1019_015c, 2); mov(bh, al);                            /* mov bh, al */
            ii(0x1019_015e, 3); mov(memd[ds, edi + 4], ebx);            /* mov [edi+0x4], ebx */
            ii(0x1019_0161, 4); mov(memd[ds, edx + edi + 4], ebx);      /* mov [edx+edi+0x4], ebx */
            ii(0x1019_0165, 3); lea(edi, memd[ds, edi + edx * 2]);      /* lea edi, [edi+edx*2] */
            ii(0x1019_0168, 3); mov(eax, memd[ds, esi + 4]);            /* mov eax, [esi+0x4] */
            ii(0x1019_016b, 2); mov(bl, ah);                            /* mov bl, ah */
            ii(0x1019_016d, 2); mov(bh, ah);                            /* mov bh, ah */
            ii(0x1019_016f, 3); shl(ebx, 0x10);                         /* shl ebx, 0x10 */
            ii(0x1019_0172, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1019_0174, 2); mov(bh, al);                            /* mov bh, al */
            ii(0x1019_0176, 2); mov(memd[ds, edi], ebx);                /* mov [edi], ebx */
            ii(0x1019_0178, 3); mov(memd[ds, edx + edi], ebx);          /* mov [edx+edi], ebx */
            ii(0x1019_017b, 3); shr(eax, 0x10);                         /* shr eax, 0x10 */
            ii(0x1019_017e, 2); mov(bl, ah);                            /* mov bl, ah */
            ii(0x1019_0180, 2); mov(bh, ah);                            /* mov bh, ah */
            ii(0x1019_0182, 3); shl(ebx, 0x10);                         /* shl ebx, 0x10 */
            ii(0x1019_0185, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1019_0187, 2); mov(bh, al);                            /* mov bh, al */
            ii(0x1019_0189, 3); mov(memd[ds, edi + 4], ebx);            /* mov [edi+0x4], ebx */
            ii(0x1019_018c, 4); mov(memd[ds, edx + edi + 4], ebx);      /* mov [edx+edi+0x4], ebx */
            ii(0x1019_0190, 3); lea(edi, memd[ds, edi + edx * 2]);      /* lea edi, [edi+edx*2] */
            ii(0x1019_0193, 3); mov(eax, memd[ds, esi + 8]);            /* mov eax, [esi+0x8] */
            ii(0x1019_0196, 2); mov(bl, ah);                            /* mov bl, ah */
            ii(0x1019_0198, 2); mov(bh, ah);                            /* mov bh, ah */
            ii(0x1019_019a, 3); shl(ebx, 0x10);                         /* shl ebx, 0x10 */
            ii(0x1019_019d, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1019_019f, 2); mov(bh, al);                            /* mov bh, al */
            ii(0x1019_01a1, 2); mov(memd[ds, edi], ebx);                /* mov [edi], ebx */
            ii(0x1019_01a3, 3); mov(memd[ds, edx + edi], ebx);          /* mov [edx+edi], ebx */
            ii(0x1019_01a6, 3); shr(eax, 0x10);                         /* shr eax, 0x10 */
            ii(0x1019_01a9, 2); mov(bl, ah);                            /* mov bl, ah */
            ii(0x1019_01ab, 2); mov(bh, ah);                            /* mov bh, ah */
            ii(0x1019_01ad, 3); shl(ebx, 0x10);                         /* shl ebx, 0x10 */
            ii(0x1019_01b0, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1019_01b2, 2); mov(bh, al);                            /* mov bh, al */
            ii(0x1019_01b4, 3); mov(memd[ds, edi + 4], ebx);            /* mov [edi+0x4], ebx */
            ii(0x1019_01b7, 4); mov(memd[ds, edx + edi + 4], ebx);      /* mov [edx+edi+0x4], ebx */
            ii(0x1019_01bb, 3); lea(edi, memd[ds, edi + edx * 2]);      /* lea edi, [edi+edx*2] */
            ii(0x1019_01be, 3); mov(eax, memd[ds, esi + 0xc]);          /* mov eax, [esi+0xc] */
            ii(0x1019_01c1, 2); mov(bl, ah);                            /* mov bl, ah */
            ii(0x1019_01c3, 2); mov(bh, ah);                            /* mov bh, ah */
            ii(0x1019_01c5, 3); shl(ebx, 0x10);                         /* shl ebx, 0x10 */
            ii(0x1019_01c8, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1019_01ca, 2); mov(bh, al);                            /* mov bh, al */
            ii(0x1019_01cc, 2); mov(memd[ds, edi], ebx);                /* mov [edi], ebx */
            ii(0x1019_01ce, 3); mov(memd[ds, edx + edi], ebx);          /* mov [edx+edi], ebx */
            ii(0x1019_01d1, 3); shr(eax, 0x10);                         /* shr eax, 0x10 */
            ii(0x1019_01d4, 2); mov(bl, ah);                            /* mov bl, ah */
            ii(0x1019_01d6, 2); mov(bh, ah);                            /* mov bh, ah */
            ii(0x1019_01d8, 3); shl(ebx, 0x10);                         /* shl ebx, 0x10 */
            ii(0x1019_01db, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1019_01dd, 2); mov(bh, al);                            /* mov bh, al */
            ii(0x1019_01df, 3); mov(memd[ds, edi + 4], ebx);            /* mov [edi+0x4], ebx */
            ii(0x1019_01e2, 4); mov(memd[ds, edx + edi + 4], ebx);      /* mov [edx+edi+0x4], ebx */
            ii(0x1019_01e6, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_01e8, 3); sub(edi, memd[ss, ebp - 0x10]);         /* sub edi, [ebp-0x10] */
            ii(0x1019_01eb, 3); add(esi, 0x10);                         /* add esi, 0x10 */
            ii(0x1019_01ee, 1); ret();                                  /* ret */
        }
    }
}
