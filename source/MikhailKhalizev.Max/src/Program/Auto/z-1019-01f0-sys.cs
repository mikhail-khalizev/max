using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_01f0-2ffbe259")]
        public void /* sys */ Method_1019_01f0()
        {
            ii(0x1019_01f0, 6); mov(edx, memd_a32[ds, 0x1020_9cd0]);    /* mov edx, [0x10209cd0] */
            ii(0x1019_01f6, 2); mov(cl, memb_a32[ds, esi]);             /* mov cl, [esi] */
            ii(0x1019_01f8, 2); mov(ch, cl);                            /* mov ch, cl */
            ii(0x1019_01fa, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1019_01fc, 3); shl(eax, 0x10);                         /* shl eax, 0x10 */
            ii(0x1019_01ff, 3); mov(ax, cx);                            /* mov ax, cx */
            ii(0x1019_0202, 3); mov(cl, memb_a32[ds, esi + 0x1]);       /* mov cl, [esi+0x1] */
            ii(0x1019_0205, 2); mov(ch, cl);                            /* mov ch, cl */
            ii(0x1019_0207, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
            ii(0x1019_0209, 3); shl(ebx, 0x10);                         /* shl ebx, 0x10 */
            ii(0x1019_020c, 3); mov(bx, cx);                            /* mov bx, cx */
            ii(0x1019_020f, 2); mov(memd_a32[ds, edi], eax);            /* mov [edi], eax */
            ii(0x1019_0211, 3); mov(memd_a32[ds, edi + 0x4], ebx);      /* mov [edi+0x4], ebx */
            ii(0x1019_0214, 3); mov(memd_a32[ds, edx + edi], eax);      /* mov [edx+edi], eax */
            ii(0x1019_0217, 4); mov(memd_a32[ds, edx + edi + 0x4], ebx); /* mov [edx+edi+0x4], ebx */
            ii(0x1019_021b, 3); lea(edi, edi + edx * 2);                /* lea edi, [edi+edx*2] */
            ii(0x1019_021e, 2); mov(memd_a32[ds, edi], eax);            /* mov [edi], eax */
            ii(0x1019_0220, 3); mov(memd_a32[ds, edi + 0x4], ebx);      /* mov [edi+0x4], ebx */
            ii(0x1019_0223, 3); mov(memd_a32[ds, edx + edi], eax);      /* mov [edx+edi], eax */
            ii(0x1019_0226, 4); mov(memd_a32[ds, edx + edi + 0x4], ebx); /* mov [edx+edi+0x4], ebx */
            ii(0x1019_022a, 3); lea(edi, edi + edx * 2);                /* lea edi, [edi+edx*2] */
            ii(0x1019_022d, 3); mov(cl, memb_a32[ds, esi + 0x2]);       /* mov cl, [esi+0x2] */
            ii(0x1019_0230, 2); mov(ch, cl);                            /* mov ch, cl */
            ii(0x1019_0232, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1019_0234, 3); shl(eax, 0x10);                         /* shl eax, 0x10 */
            ii(0x1019_0237, 3); mov(ax, cx);                            /* mov ax, cx */
            ii(0x1019_023a, 3); mov(cl, memb_a32[ds, esi + 0x3]);       /* mov cl, [esi+0x3] */
            ii(0x1019_023d, 2); mov(ch, cl);                            /* mov ch, cl */
            ii(0x1019_023f, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
            ii(0x1019_0241, 3); shl(ebx, 0x10);                         /* shl ebx, 0x10 */
            ii(0x1019_0244, 3); mov(bx, cx);                            /* mov bx, cx */
            ii(0x1019_0247, 2); mov(memd_a32[ds, edi], eax);            /* mov [edi], eax */
            ii(0x1019_0249, 3); mov(memd_a32[ds, edi + 0x4], ebx);      /* mov [edi+0x4], ebx */
            ii(0x1019_024c, 3); mov(memd_a32[ds, edx + edi], eax);      /* mov [edx+edi], eax */
            ii(0x1019_024f, 4); mov(memd_a32[ds, edx + edi + 0x4], ebx); /* mov [edx+edi+0x4], ebx */
            ii(0x1019_0253, 3); lea(edi, edi + edx * 2);                /* lea edi, [edi+edx*2] */
            ii(0x1019_0256, 2); mov(memd_a32[ds, edi], eax);            /* mov [edi], eax */
            ii(0x1019_0258, 3); mov(memd_a32[ds, edi + 0x4], ebx);      /* mov [edi+0x4], ebx */
            ii(0x1019_025b, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_025d, 2); mov(memd_a32[ds, edi], eax);            /* mov [edi], eax */
            ii(0x1019_025f, 3); mov(memd_a32[ds, edi + 0x4], ebx);      /* mov [edi+0x4], ebx */
            ii(0x1019_0262, 3); sub(edi, memd_a32[ss, ebp - 0x10]);     /* sub edi, [ebp-0x10] */
            ii(0x1019_0265, 3); add(esi, 0x4);                          /* add esi, 0x4 */
            ii(0x1019_0268, 1); retd();                                 /* ret */
        }
    }
}
