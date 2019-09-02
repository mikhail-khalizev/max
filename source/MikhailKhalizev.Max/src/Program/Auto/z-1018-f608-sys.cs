using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_f608-3f0204e4")]
        public void /* sys */ Method_1018_f608()
        {
            ii(0x1018_f608, 3); shr(eax, 0x10);                         /* shr eax, 0x10 */
            ii(0x1018_f60b, 2); cmp(al, ah);                            /* cmp al, ah */
            ii(0x1018_f60d, 6); if(ja_func(0x1018_f7cc, 0x1b9)) return; /* ja 0x1018f7cc */
            ii(0x1018_f613, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_f615, 6); lea(ecx, memd[ds, 0x101b_f510]);        /* lea ecx, [0x101bf510] */
            ii(0x1018_f61b, 6); lea(edx, memd[ds, /* sys_mve */ 0x1018_f6dd]); /* lea edx, [0x1018f6dd] */
            ii(0x1018_f621, 3); mov(al, memb[ds, esi + 4]);             /* mov al, [esi+0x4] */
            ii(0x1018_f624, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f627, 3); mov(memb[ds, edx + 20], bl);            /* mov [edx+0x14], bl */
            ii(0x1018_f62a, 3); mov(memb[ds, edx + 13], bh);            /* mov [edx+0xd], bh */
            ii(0x1018_f62d, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_f630, 3); mov(memb[ds, edx + 7], bl);             /* mov [edx+0x7], bl */
            ii(0x1018_f633, 2); mov(memb[ds, edx], bh);                 /* mov [edx], bh */
            ii(0x1018_f635, 3); mov(al, memb[ds, esi + 5]);             /* mov al, [esi+0x5] */
            ii(0x1018_f638, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f63b, 3); mov(memb[ds, edx + 49], bl);            /* mov [edx+0x31], bl */
            ii(0x1018_f63e, 3); mov(memb[ds, edx + 42], bh);            /* mov [edx+0x2a], bh */
            ii(0x1018_f641, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_f644, 3); mov(memb[ds, edx + 36], bl);            /* mov [edx+0x24], bl */
            ii(0x1018_f647, 3); mov(memb[ds, edx + 29], bh);            /* mov [edx+0x1d], bh */
            ii(0x1018_f64a, 3); mov(al, memb[ds, esi + 6]);             /* mov al, [esi+0x6] */
            ii(0x1018_f64d, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f650, 3); mov(memb[ds, edx + 78], bl);            /* mov [edx+0x4e], bl */
            ii(0x1018_f653, 3); mov(memb[ds, edx + 71], bh);            /* mov [edx+0x47], bh */
            ii(0x1018_f656, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_f659, 3); mov(memb[ds, edx + 65], bl);            /* mov [edx+0x41], bl */
            ii(0x1018_f65c, 3); mov(memb[ds, edx + 58], bh);            /* mov [edx+0x3a], bh */
            ii(0x1018_f65f, 3); mov(al, memb[ds, esi + 7]);             /* mov al, [esi+0x7] */
            ii(0x1018_f662, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f665, 3); mov(memb[ds, edx + 107], bl);           /* mov [edx+0x6b], bl */
            ii(0x1018_f668, 3); mov(memb[ds, edx + 100], bh);           /* mov [edx+0x64], bh */
            ii(0x1018_f66b, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_f66e, 3); mov(memb[ds, edx + 94], bl);            /* mov [edx+0x5e], bl */
            ii(0x1018_f671, 3); mov(memb[ds, edx + 87], bh);            /* mov [edx+0x57], bh */
            ii(0x1018_f674, 3); lea(edx, memd[ds, edx + 116]);          /* lea edx, [edx+0x74] */
            ii(0x1018_f677, 3); mov(al, memb[ds, esi + 8]);             /* mov al, [esi+0x8] */
            ii(0x1018_f67a, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f67d, 3); mov(memb[ds, edx + 20], bl);            /* mov [edx+0x14], bl */
            ii(0x1018_f680, 3); mov(memb[ds, edx + 13], bh);            /* mov [edx+0xd], bh */
            ii(0x1018_f683, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_f686, 3); mov(memb[ds, edx + 7], bl);             /* mov [edx+0x7], bl */
            ii(0x1018_f689, 2); mov(memb[ds, edx], bh);                 /* mov [edx], bh */
            ii(0x1018_f68b, 3); mov(al, memb[ds, esi + 9]);             /* mov al, [esi+0x9] */
            ii(0x1018_f68e, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f691, 3); mov(memb[ds, edx + 49], bl);            /* mov [edx+0x31], bl */
            ii(0x1018_f694, 3); mov(memb[ds, edx + 42], bh);            /* mov [edx+0x2a], bh */
            ii(0x1018_f697, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_f69a, 3); mov(memb[ds, edx + 36], bl);            /* mov [edx+0x24], bl */
            ii(0x1018_f69d, 3); mov(memb[ds, edx + 29], bh);            /* mov [edx+0x1d], bh */
            ii(0x1018_f6a0, 3); mov(al, memb[ds, esi + 10]);            /* mov al, [esi+0xa] */
            ii(0x1018_f6a3, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f6a6, 3); mov(memb[ds, edx + 78], bl);            /* mov [edx+0x4e], bl */
            ii(0x1018_f6a9, 3); mov(memb[ds, edx + 71], bh);            /* mov [edx+0x47], bh */
            ii(0x1018_f6ac, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_f6af, 3); mov(memb[ds, edx + 65], bl);            /* mov [edx+0x41], bl */
            ii(0x1018_f6b2, 3); mov(memb[ds, edx + 58], bh);            /* mov [edx+0x3a], bh */
            ii(0x1018_f6b5, 3); mov(al, memb[ds, esi + 11]);            /* mov al, [esi+0xb] */
            ii(0x1018_f6b8, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f6bb, 3); mov(memb[ds, edx + 107], bl);           /* mov [edx+0x6b], bl */
            ii(0x1018_f6be, 3); mov(memb[ds, edx + 100], bh);           /* mov [edx+0x64], bh */
            ii(0x1018_f6c1, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_f6c4, 3); mov(memb[ds, edx + 94], bl);            /* mov [edx+0x5e], bl */
            ii(0x1018_f6c7, 3); mov(memb[ds, edx + 87], bh);            /* mov [edx+0x57], bh */
            ii(0x1018_f6ca, 3); mov(bx, memw[ds, esi]);                 /* mov bx, [esi] */
            ii(0x1018_f6cd, 4); mov(cx, memw[ds, esi + 2]);             /* mov cx, [esi+0x2] */
            ii(0x1018_f6d1, 6); mov(edx, memd[ds, 0x1020_9cd0]);        /* mov edx, [0x10209cd0] */
            ii(0x1018_f6d7, 2); if(jmp_func(0x1018_f6dc, 3)) return;    /* jmp 0x1018f6dc */
        }
    }
}
