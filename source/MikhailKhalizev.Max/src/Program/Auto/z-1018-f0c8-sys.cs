using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_f0c8-56712f8d")]
        public void /* sys */ Method_1018_f0c8()
        {
            ii(0x1018_f0c8, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1018_f0ca, 6);  lea(ecx, memd[ds, 0x101b_f110]);      /* lea ecx, [0x101bf110] */
            ii(0x1018_f0d0, 6);  lea(edx, memd[ds, /* sys_mve */ 0x1018_f1a2]);/* lea edx, [0x1018f1a2] */
            ii(0x1018_f0d6, 3);  mov(al, memb[ds, esi + 2]);           /* mov al, [esi+0x2] */
            ii(0x1018_f0d9, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f0dc, 2);  mov(memb[ds, edx], bl);               /* mov [edx], bl */
            ii(0x1018_f0de, 3);  mov(memb[ds, edx + 6], bh);           /* mov [edx+0x6], bh */
            ii(0x1018_f0e1, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_f0e4, 3);  mov(memb[ds, edx + 11], bl);          /* mov [edx+0xb], bl */
            ii(0x1018_f0e7, 3);  mov(memb[ds, edx + 17], bh);          /* mov [edx+0x11], bh */
            ii(0x1018_f0ea, 3);  mov(al, memb[ds, esi + 3]);           /* mov al, [esi+0x3] */
            ii(0x1018_f0ed, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f0f0, 3);  mov(memb[ds, edx + 25], bl);          /* mov [edx+0x19], bl */
            ii(0x1018_f0f3, 3);  mov(memb[ds, edx + 31], bh);          /* mov [edx+0x1f], bh */
            ii(0x1018_f0f6, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_f0f9, 3);  mov(memb[ds, edx + 36], bl);          /* mov [edx+0x24], bl */
            ii(0x1018_f0fc, 3);  mov(memb[ds, edx + 42], bh);          /* mov [edx+0x2a], bh */
            ii(0x1018_f0ff, 3);  mov(al, memb[ds, esi + 4]);           /* mov al, [esi+0x4] */
            ii(0x1018_f102, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f105, 3);  mov(memb[ds, edx + 50], bl);          /* mov [edx+0x32], bl */
            ii(0x1018_f108, 3);  mov(memb[ds, edx + 56], bh);          /* mov [edx+0x38], bh */
            ii(0x1018_f10b, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_f10e, 3);  mov(memb[ds, edx + 61], bl);          /* mov [edx+0x3d], bl */
            ii(0x1018_f111, 3);  mov(memb[ds, edx + 67], bh);          /* mov [edx+0x43], bh */
            ii(0x1018_f114, 3);  mov(al, memb[ds, esi + 5]);           /* mov al, [esi+0x5] */
            ii(0x1018_f117, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f11a, 3);  mov(memb[ds, edx + 75], bl);          /* mov [edx+0x4b], bl */
            ii(0x1018_f11d, 3);  mov(memb[ds, edx + 81], bh);          /* mov [edx+0x51], bh */
            ii(0x1018_f120, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_f123, 3);  mov(memb[ds, edx + 86], bl);          /* mov [edx+0x56], bl */
            ii(0x1018_f126, 3);  mov(memb[ds, edx + 92], bh);          /* mov [edx+0x5c], bh */
            ii(0x1018_f129, 6);  add(edx, 0x79);                       /* add edx, 0x79 */
            ii(0x1018_f12f, 3);  mov(al, memb[ds, esi + 8]);           /* mov al, [esi+0x8] */
            ii(0x1018_f132, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f135, 2);  mov(memb[ds, edx], bl);               /* mov [edx], bl */
            ii(0x1018_f137, 3);  mov(memb[ds, edx + 6], bh);           /* mov [edx+0x6], bh */
            ii(0x1018_f13a, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_f13d, 3);  mov(memb[ds, edx + 11], bl);          /* mov [edx+0xb], bl */
            ii(0x1018_f140, 3);  mov(memb[ds, edx + 17], bh);          /* mov [edx+0x11], bh */
            ii(0x1018_f143, 3);  mov(al, memb[ds, esi + 9]);           /* mov al, [esi+0x9] */
            ii(0x1018_f146, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f149, 3);  mov(memb[ds, edx + 25], bl);          /* mov [edx+0x19], bl */
            ii(0x1018_f14c, 3);  mov(memb[ds, edx + 31], bh);          /* mov [edx+0x1f], bh */
            ii(0x1018_f14f, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_f152, 3);  mov(memb[ds, edx + 36], bl);          /* mov [edx+0x24], bl */
            ii(0x1018_f155, 3);  mov(memb[ds, edx + 42], bh);          /* mov [edx+0x2a], bh */
            ii(0x1018_f158, 3);  mov(al, memb[ds, esi + 10]);          /* mov al, [esi+0xa] */
            ii(0x1018_f15b, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f15e, 3);  mov(memb[ds, edx + 50], bl);          /* mov [edx+0x32], bl */
            ii(0x1018_f161, 3);  mov(memb[ds, edx + 56], bh);          /* mov [edx+0x38], bh */
            ii(0x1018_f164, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_f167, 3);  mov(memb[ds, edx + 61], bl);          /* mov [edx+0x3d], bl */
            ii(0x1018_f16a, 3);  mov(memb[ds, edx + 67], bh);          /* mov [edx+0x43], bh */
            ii(0x1018_f16d, 3);  mov(al, memb[ds, esi + 11]);          /* mov al, [esi+0xb] */
            ii(0x1018_f170, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f173, 3);  mov(memb[ds, edx + 75], bl);          /* mov [edx+0x4b], bl */
            ii(0x1018_f176, 3);  mov(memb[ds, edx + 81], bh);          /* mov [edx+0x51], bh */
            ii(0x1018_f179, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_f17c, 3);  mov(memb[ds, edx + 86], bl);          /* mov [edx+0x56], bl */
            ii(0x1018_f17f, 3);  mov(memb[ds, edx + 92], bh);          /* mov [edx+0x5c], bh */
            ii(0x1018_f182, 1);  push(ebp);                            /* push ebp */
            ii(0x1018_f183, 1);  push(esi);                            /* push esi */
            ii(0x1018_f184, 3);  mov(cx, memw[ds, esi]);               /* mov cx, [esi] */
            ii(0x1018_f187, 6);  mov(esi, memd[ds, 0x1020_9cd0]);      /* mov esi, [0x10209cd0] */
            ii(0x1018_f18d, 2);  mov(bl, cl);                          /* mov bl, cl */
            ii(0x1018_f18f, 2);  mov(bh, cl);                          /* mov bh, cl */
            ii(0x1018_f191, 2);  mov(dl, ch);                          /* mov dl, ch */
            ii(0x1018_f193, 2);  mov(dh, cl);                          /* mov dh, cl */
            ii(0x1018_f195, 2);  mov(al, ch);                          /* mov al, ch */
            ii(0x1018_f197, 2);  mov(ah, ch);                          /* mov ah, ch */
            ii(0x1018_f199, 2);  mov(ebp, eax);                        /* mov ebp, eax */
            ii(0x1018_f19b, 2);  jmp_func(0x1018_f1a0, 3);             /* jmp 0x1018f1a0 */
        }
    }
}
