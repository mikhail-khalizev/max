using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_f284-c01d96f1")]
        public void /* sys */ mve_3()
        {
            ii(0x1018_f284, 2);  mov(eax, memd[ds, esi]);              /* mov eax, [esi] */
            ii(0x1018_f286, 2);  cmp(al, ah);                          /* cmp al, ah */
            ii(0x1018_f288, 6);  if(ja_func(0x1018_f608, 0x37a)) return;/* ja 0x1018f608 */
            ii(0x1018_f28e, 3);  shr(eax, 0x10);                       /* shr eax, 0x10 */
            ii(0x1018_f291, 2);  cmp(al, ah);                          /* cmp al, ah */
            ii(0x1018_f293, 6);  if(ja_func(0x1018_f4f8, 0x25f)) return;/* ja 0x1018f4f8 */
            ii(0x1018_f299, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1018_f29b, 6);  lea(ecx, memd[ds, 0x101b_f510]);      /* lea ecx, [0x101bf510] */
            ii(0x1018_f2a1, 6);  lea(edx, memd[ds, /* sys_mve */ 0x1018_f409]);/* lea edx, [0x1018f409] */
            ii(0x1018_f2a7, 3);  mov(al, memb[ds, esi + 4]);           /* mov al, [esi+0x4] */
            ii(0x1018_f2aa, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f2ad, 2);  mov(memb[ds, edx], bl);               /* mov [edx], bl */
            ii(0x1018_f2af, 3);  mov(memb[ds, edx + 2], bh);           /* mov [edx+0x2], bh */
            ii(0x1018_f2b2, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_f2b5, 3);  mov(memb[ds, edx + 7], bl);           /* mov [edx+0x7], bl */
            ii(0x1018_f2b8, 3);  mov(memb[ds, edx + 9], bh);           /* mov [edx+0x9], bh */
            ii(0x1018_f2bb, 3);  mov(al, memb[ds, esi + 5]);           /* mov al, [esi+0x5] */
            ii(0x1018_f2be, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f2c1, 3);  mov(memb[ds, edx + 13], bl);          /* mov [edx+0xd], bl */
            ii(0x1018_f2c4, 3);  mov(memb[ds, edx + 15], bh);          /* mov [edx+0xf], bh */
            ii(0x1018_f2c7, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_f2ca, 3);  mov(memb[ds, edx + 20], bl);          /* mov [edx+0x14], bl */
            ii(0x1018_f2cd, 3);  mov(memb[ds, edx + 22], bh);          /* mov [edx+0x16], bh */
            ii(0x1018_f2d0, 3);  mov(al, memb[ds, esi + 6]);           /* mov al, [esi+0x6] */
            ii(0x1018_f2d3, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f2d6, 3);  mov(memb[ds, edx + 29], bl);          /* mov [edx+0x1d], bl */
            ii(0x1018_f2d9, 3);  mov(memb[ds, edx + 31], bh);          /* mov [edx+0x1f], bh */
            ii(0x1018_f2dc, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_f2df, 3);  mov(memb[ds, edx + 36], bl);          /* mov [edx+0x24], bl */
            ii(0x1018_f2e2, 3);  mov(memb[ds, edx + 38], bh);          /* mov [edx+0x26], bh */
            ii(0x1018_f2e5, 3);  mov(al, memb[ds, esi + 7]);           /* mov al, [esi+0x7] */
            ii(0x1018_f2e8, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f2eb, 3);  mov(memb[ds, edx + 42], bl);          /* mov [edx+0x2a], bl */
            ii(0x1018_f2ee, 3);  mov(memb[ds, edx + 44], bh);          /* mov [edx+0x2c], bh */
            ii(0x1018_f2f1, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_f2f4, 3);  mov(memb[ds, edx + 49], bl);          /* mov [edx+0x31], bl */
            ii(0x1018_f2f7, 3);  mov(memb[ds, edx + 51], bh);          /* mov [edx+0x33], bh */
            ii(0x1018_f2fa, 3);  mov(al, memb[ds, esi + 8]);           /* mov al, [esi+0x8] */
            ii(0x1018_f2fd, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f300, 3);  mov(memb[ds, edx + 58], bl);          /* mov [edx+0x3a], bl */
            ii(0x1018_f303, 3);  mov(memb[ds, edx + 60], bh);          /* mov [edx+0x3c], bh */
            ii(0x1018_f306, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_f309, 3);  mov(memb[ds, edx + 65], bl);          /* mov [edx+0x41], bl */
            ii(0x1018_f30c, 3);  mov(memb[ds, edx + 67], bh);          /* mov [edx+0x43], bh */
            ii(0x1018_f30f, 3);  mov(al, memb[ds, esi + 9]);           /* mov al, [esi+0x9] */
            ii(0x1018_f312, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f315, 3);  mov(memb[ds, edx + 71], bl);          /* mov [edx+0x47], bl */
            ii(0x1018_f318, 3);  mov(memb[ds, edx + 73], bh);          /* mov [edx+0x49], bh */
            ii(0x1018_f31b, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_f31e, 3);  mov(memb[ds, edx + 78], bl);          /* mov [edx+0x4e], bl */
            ii(0x1018_f321, 3);  mov(memb[ds, edx + 80], bh);          /* mov [edx+0x50], bh */
            ii(0x1018_f324, 3);  mov(al, memb[ds, esi + 10]);          /* mov al, [esi+0xa] */
            ii(0x1018_f327, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f32a, 3);  mov(memb[ds, edx + 87], bl);          /* mov [edx+0x57], bl */
            ii(0x1018_f32d, 3);  mov(memb[ds, edx + 89], bh);          /* mov [edx+0x59], bh */
            ii(0x1018_f330, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_f333, 3);  mov(memb[ds, edx + 94], bl);          /* mov [edx+0x5e], bl */
            ii(0x1018_f336, 3);  mov(memb[ds, edx + 96], bh);          /* mov [edx+0x60], bh */
            ii(0x1018_f339, 3);  mov(al, memb[ds, esi + 11]);          /* mov al, [esi+0xb] */
            ii(0x1018_f33c, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f33f, 3);  mov(memb[ds, edx + 100], bl);         /* mov [edx+0x64], bl */
            ii(0x1018_f342, 3);  mov(memb[ds, edx + 102], bh);         /* mov [edx+0x66], bh */
            ii(0x1018_f345, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_f348, 3);  mov(memb[ds, edx + 107], bl);         /* mov [edx+0x6b], bl */
            ii(0x1018_f34b, 3);  mov(memb[ds, edx + 109], bh);         /* mov [edx+0x6d], bh */
            ii(0x1018_f34e, 3);  lea(edx, memd[ds, edx + 116]);        /* lea edx, [edx+0x74] */
            ii(0x1018_f351, 3);  mov(al, memb[ds, esi + 12]);          /* mov al, [esi+0xc] */
            ii(0x1018_f354, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f357, 2);  mov(memb[ds, edx], bl);               /* mov [edx], bl */
            ii(0x1018_f359, 3);  mov(memb[ds, edx + 2], bh);           /* mov [edx+0x2], bh */
            ii(0x1018_f35c, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_f35f, 3);  mov(memb[ds, edx + 7], bl);           /* mov [edx+0x7], bl */
            ii(0x1018_f362, 3);  mov(memb[ds, edx + 9], bh);           /* mov [edx+0x9], bh */
            ii(0x1018_f365, 3);  mov(al, memb[ds, esi + 13]);          /* mov al, [esi+0xd] */
            ii(0x1018_f368, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f36b, 3);  mov(memb[ds, edx + 13], bl);          /* mov [edx+0xd], bl */
            ii(0x1018_f36e, 3);  mov(memb[ds, edx + 15], bh);          /* mov [edx+0xf], bh */
            ii(0x1018_f371, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_f374, 3);  mov(memb[ds, edx + 20], bl);          /* mov [edx+0x14], bl */
            ii(0x1018_f377, 3);  mov(memb[ds, edx + 22], bh);          /* mov [edx+0x16], bh */
            ii(0x1018_f37a, 3);  mov(al, memb[ds, esi + 14]);          /* mov al, [esi+0xe] */
            ii(0x1018_f37d, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f380, 3);  mov(memb[ds, edx + 29], bl);          /* mov [edx+0x1d], bl */
            ii(0x1018_f383, 3);  mov(memb[ds, edx + 31], bh);          /* mov [edx+0x1f], bh */
            ii(0x1018_f386, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_f389, 3);  mov(memb[ds, edx + 36], bl);          /* mov [edx+0x24], bl */
            ii(0x1018_f38c, 3);  mov(memb[ds, edx + 38], bh);          /* mov [edx+0x26], bh */
            ii(0x1018_f38f, 3);  mov(al, memb[ds, esi + 15]);          /* mov al, [esi+0xf] */
            ii(0x1018_f392, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f395, 3);  mov(memb[ds, edx + 42], bl);          /* mov [edx+0x2a], bl */
            ii(0x1018_f398, 3);  mov(memb[ds, edx + 44], bh);          /* mov [edx+0x2c], bh */
            ii(0x1018_f39b, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_f39e, 3);  mov(memb[ds, edx + 49], bl);          /* mov [edx+0x31], bl */
            ii(0x1018_f3a1, 3);  mov(memb[ds, edx + 51], bh);          /* mov [edx+0x33], bh */
            ii(0x1018_f3a4, 3);  mov(al, memb[ds, esi + 16]);          /* mov al, [esi+0x10] */
            ii(0x1018_f3a7, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f3aa, 3);  mov(memb[ds, edx + 58], bl);          /* mov [edx+0x3a], bl */
            ii(0x1018_f3ad, 3);  mov(memb[ds, edx + 60], bh);          /* mov [edx+0x3c], bh */
            ii(0x1018_f3b0, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_f3b3, 3);  mov(memb[ds, edx + 65], bl);          /* mov [edx+0x41], bl */
            ii(0x1018_f3b6, 3);  mov(memb[ds, edx + 67], bh);          /* mov [edx+0x43], bh */
            ii(0x1018_f3b9, 3);  mov(al, memb[ds, esi + 17]);          /* mov al, [esi+0x11] */
            ii(0x1018_f3bc, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f3bf, 3);  mov(memb[ds, edx + 71], bl);          /* mov [edx+0x47], bl */
            ii(0x1018_f3c2, 3);  mov(memb[ds, edx + 73], bh);          /* mov [edx+0x49], bh */
            ii(0x1018_f3c5, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_f3c8, 3);  mov(memb[ds, edx + 78], bl);          /* mov [edx+0x4e], bl */
            ii(0x1018_f3cb, 3);  mov(memb[ds, edx + 80], bh);          /* mov [edx+0x50], bh */
            ii(0x1018_f3ce, 3);  mov(al, memb[ds, esi + 18]);          /* mov al, [esi+0x12] */
            ii(0x1018_f3d1, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f3d4, 3);  mov(memb[ds, edx + 87], bl);          /* mov [edx+0x57], bl */
            ii(0x1018_f3d7, 3);  mov(memb[ds, edx + 89], bh);          /* mov [edx+0x59], bh */
            ii(0x1018_f3da, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_f3dd, 3);  mov(memb[ds, edx + 94], bl);          /* mov [edx+0x5e], bl */
            ii(0x1018_f3e0, 3);  mov(memb[ds, edx + 96], bh);          /* mov [edx+0x60], bh */
            ii(0x1018_f3e3, 3);  mov(al, memb[ds, esi + 19]);          /* mov al, [esi+0x13] */
            ii(0x1018_f3e6, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f3e9, 3);  mov(memb[ds, edx + 100], bl);         /* mov [edx+0x64], bl */
            ii(0x1018_f3ec, 3);  mov(memb[ds, edx + 102], bh);         /* mov [edx+0x66], bh */
            ii(0x1018_f3ef, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_f3f2, 3);  mov(memb[ds, edx + 107], bl);         /* mov [edx+0x6b], bl */
            ii(0x1018_f3f5, 3);  mov(memb[ds, edx + 109], bh);         /* mov [edx+0x6d], bh */
            ii(0x1018_f3f8, 3);  mov(bx, memw[ds, esi]);               /* mov bx, [esi] */
            ii(0x1018_f3fb, 4);  mov(cx, memw[ds, esi + 2]);           /* mov cx, [esi+0x2] */
            ii(0x1018_f3ff, 6);  mov(edx, memd[ds, 0x1020_9cd0]);      /* mov edx, [0x10209cd0] */
            ii(0x1018_f405, 2);  jmp_func(0x1018_f408, 1);             /* jmp 0x1018f408 */
        }
    }
}
