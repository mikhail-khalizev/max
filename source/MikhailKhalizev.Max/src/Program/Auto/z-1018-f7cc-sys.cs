using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_f7cc-47388230")]
        public void /* sys */ Method_1018_f7cc()
        {
            ii(0x1018_f7cc, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_f7ce, 6); lea(ecx, memd[ds, 0x101b_f510]);        /* lea ecx, [0x101bf510] */
            ii(0x1018_f7d4, 6); lea(edx, memd[ds, /* sys_mve */ 0x1018_f89d]); /* lea edx, [0x1018f89d] */
            ii(0x1018_f7da, 3); mov(al, memb[ds, esi + 4]);             /* mov al, [esi+0x4] */
            ii(0x1018_f7dd, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f7e0, 2); mov(memb[ds, edx], bl);                 /* mov [edx], bl */
            ii(0x1018_f7e2, 3); mov(memb[ds, edx + 2], bh);             /* mov [edx+0x2], bh */
            ii(0x1018_f7e5, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_f7e8, 3); mov(memb[ds, edx + 7], bl);             /* mov [edx+0x7], bl */
            ii(0x1018_f7eb, 3); mov(memb[ds, edx + 9], bh);             /* mov [edx+0x9], bh */
            ii(0x1018_f7ee, 3); mov(al, memb[ds, esi + 5]);             /* mov al, [esi+0x5] */
            ii(0x1018_f7f1, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f7f4, 3); mov(memb[ds, edx + 16], bl);            /* mov [edx+0x10], bl */
            ii(0x1018_f7f7, 3); mov(memb[ds, edx + 18], bh);            /* mov [edx+0x12], bh */
            ii(0x1018_f7fa, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_f7fd, 3); mov(memb[ds, edx + 23], bl);            /* mov [edx+0x17], bl */
            ii(0x1018_f800, 3); mov(memb[ds, edx + 25], bh);            /* mov [edx+0x19], bh */
            ii(0x1018_f803, 3); mov(al, memb[ds, esi + 6]);             /* mov al, [esi+0x6] */
            ii(0x1018_f806, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f809, 3); mov(memb[ds, edx + 37], bl);            /* mov [edx+0x25], bl */
            ii(0x1018_f80c, 3); mov(memb[ds, edx + 39], bh);            /* mov [edx+0x27], bh */
            ii(0x1018_f80f, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_f812, 3); mov(memb[ds, edx + 44], bl);            /* mov [edx+0x2c], bl */
            ii(0x1018_f815, 3); mov(memb[ds, edx + 46], bh);            /* mov [edx+0x2e], bh */
            ii(0x1018_f818, 3); mov(al, memb[ds, esi + 7]);             /* mov al, [esi+0x7] */
            ii(0x1018_f81b, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f81e, 3); mov(memb[ds, edx + 53], bl);            /* mov [edx+0x35], bl */
            ii(0x1018_f821, 3); mov(memb[ds, edx + 55], bh);            /* mov [edx+0x37], bh */
            ii(0x1018_f824, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_f827, 3); mov(memb[ds, edx + 60], bl);            /* mov [edx+0x3c], bl */
            ii(0x1018_f82a, 3); mov(memb[ds, edx + 62], bh);            /* mov [edx+0x3e], bh */
            ii(0x1018_f82d, 3); mov(al, memb[ds, esi + 8]);             /* mov al, [esi+0x8] */
            ii(0x1018_f830, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f833, 3); mov(memb[ds, edx + 74], bl);            /* mov [edx+0x4a], bl */
            ii(0x1018_f836, 3); mov(memb[ds, edx + 76], bh);            /* mov [edx+0x4c], bh */
            ii(0x1018_f839, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_f83c, 3); mov(memb[ds, edx + 81], bl);            /* mov [edx+0x51], bl */
            ii(0x1018_f83f, 3); mov(memb[ds, edx + 83], bh);            /* mov [edx+0x53], bh */
            ii(0x1018_f842, 3); mov(al, memb[ds, esi + 9]);             /* mov al, [esi+0x9] */
            ii(0x1018_f845, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f848, 3); mov(memb[ds, edx + 90], bl);            /* mov [edx+0x5a], bl */
            ii(0x1018_f84b, 3); mov(memb[ds, edx + 92], bh);            /* mov [edx+0x5c], bh */
            ii(0x1018_f84e, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_f851, 3); mov(memb[ds, edx + 97], bl);            /* mov [edx+0x61], bl */
            ii(0x1018_f854, 3); mov(memb[ds, edx + 99], bh);            /* mov [edx+0x63], bh */
            ii(0x1018_f857, 3); mov(al, memb[ds, esi + 10]);            /* mov al, [esi+0xa] */
            ii(0x1018_f85a, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f85d, 3); mov(memb[ds, edx + 111], bl);           /* mov [edx+0x6f], bl */
            ii(0x1018_f860, 3); mov(memb[ds, edx + 113], bh);           /* mov [edx+0x71], bh */
            ii(0x1018_f863, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_f866, 3); mov(memb[ds, edx + 118], bl);           /* mov [edx+0x76], bl */
            ii(0x1018_f869, 3); mov(memb[ds, edx + 120], bh);           /* mov [edx+0x78], bh */
            ii(0x1018_f86c, 3); mov(al, memb[ds, esi + 11]);            /* mov al, [esi+0xb] */
            ii(0x1018_f86f, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f872, 3); mov(memb[ds, edx + 127], bl);           /* mov [edx+0x7f], bl */
            ii(0x1018_f875, 6); mov(memb[ds, edx + 129], bh);           /* mov [edx+0x81], bh */
            ii(0x1018_f87b, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_f87e, 6); mov(memb[ds, edx + 134], bl);           /* mov [edx+0x86], bl */
            ii(0x1018_f884, 6); mov(memb[ds, edx + 136], bh);           /* mov [edx+0x88], bh */
            ii(0x1018_f88a, 3); mov(bx, memw[ds, esi]);                 /* mov bx, [esi] */
            ii(0x1018_f88d, 4); mov(cx, memw[ds, esi + 2]);             /* mov cx, [esi+0x2] */
            ii(0x1018_f891, 6); mov(edx, memd[ds, 0x1020_9cd0]);        /* mov edx, [0x10209cd0] */
            ii(0x1018_f897, 2); if(jmp_func(0x1018_f89c, 3)) return;    /* jmp 0x1018f89c */
        }
    }
}
