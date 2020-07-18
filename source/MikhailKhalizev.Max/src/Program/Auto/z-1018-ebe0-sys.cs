using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_ebe0-dd56c7b7")]
        public void /* sys */ Method_1018_ebe0()
        {
            ii(0x1018_ebe0, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1018_ebe2, 6);  lea(ecx, memd[ds, 0x101b_f0d0]);      /* lea ecx, [0x101bf0d0] */
            ii(0x1018_ebe8, 6);  lea(edx, memd[ds, /* sys_mve */ 0x1018_ec5e]);/* lea edx, [0x1018ec5e] */
            ii(0x1018_ebee, 3);  mov(al, memb[ds, esi + 2]);           /* mov al, [esi+0x2] */
            ii(0x1018_ebf1, 2);  and(al, 0xf);                         /* and al, 0xf */
            ii(0x1018_ebf3, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_ebf6, 2);  mov(memb[ds, edx], bl);               /* mov [edx], bl */
            ii(0x1018_ebf8, 3);  mov(memb[ds, edx + 6], bh);           /* mov [edx+0x6], bh */
            ii(0x1018_ebfb, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_ebfe, 3);  mov(memb[ds, edx + 14], bl);          /* mov [edx+0xe], bl */
            ii(0x1018_ec01, 3);  mov(memb[ds, edx + 20], bh);          /* mov [edx+0x14], bh */
            ii(0x1018_ec04, 3);  mov(al, memb[ds, esi + 2]);           /* mov al, [esi+0x2] */
            ii(0x1018_ec07, 3);  shr(al, 4);                           /* shr al, 0x4 */
            ii(0x1018_ec0a, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_ec0d, 3);  mov(memb[ds, edx + 33], bl);          /* mov [edx+0x21], bl */
            ii(0x1018_ec10, 3);  mov(memb[ds, edx + 39], bh);          /* mov [edx+0x27], bh */
            ii(0x1018_ec13, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_ec16, 3);  mov(memb[ds, edx + 47], bl);          /* mov [edx+0x2f], bl */
            ii(0x1018_ec19, 3);  mov(memb[ds, edx + 53], bh);          /* mov [edx+0x35], bh */
            ii(0x1018_ec1c, 3);  mov(al, memb[ds, esi + 3]);           /* mov al, [esi+0x3] */
            ii(0x1018_ec1f, 2);  and(al, 0xf);                         /* and al, 0xf */
            ii(0x1018_ec21, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_ec24, 3);  mov(memb[ds, edx + 66], bl);          /* mov [edx+0x42], bl */
            ii(0x1018_ec27, 3);  mov(memb[ds, edx + 72], bh);          /* mov [edx+0x48], bh */
            ii(0x1018_ec2a, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_ec2d, 3);  mov(memb[ds, edx + 80], bl);          /* mov [edx+0x50], bl */
            ii(0x1018_ec30, 3);  mov(memb[ds, edx + 86], bh);          /* mov [edx+0x56], bh */
            ii(0x1018_ec33, 3);  mov(al, memb[ds, esi + 3]);           /* mov al, [esi+0x3] */
            ii(0x1018_ec36, 3);  shr(al, 4);                           /* shr al, 0x4 */
            ii(0x1018_ec39, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_ec3c, 3);  mov(memb[ds, edx + 99], bl);          /* mov [edx+0x63], bl */
            ii(0x1018_ec3f, 3);  mov(memb[ds, edx + 105], bh);         /* mov [edx+0x69], bh */
            ii(0x1018_ec42, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_ec45, 3);  mov(memb[ds, edx + 113], bl);         /* mov [edx+0x71], bl */
            ii(0x1018_ec48, 3);  mov(memb[ds, edx + 119], bh);         /* mov [edx+0x77], bh */
            ii(0x1018_ec4b, 6);  mov(edx, memd[ds, 0x1020_9cd0]);      /* mov edx, [0x10209cd0] */
            ii(0x1018_ec51, 3);  mov(bx, memw[ds, esi]);               /* mov bx, [esi] */
            ii(0x1018_ec54, 2);  mov(cl, bh);                          /* mov cl, bh */
            ii(0x1018_ec56, 2);  mov(bh, bl);                          /* mov bh, bl */
            ii(0x1018_ec58, 2);  mov(ch, cl);                          /* mov ch, cl */
            ii(0x1018_ec5a, 2);  jmp_func(0x1018_ec5c, 0);             /* jmp 0x1018ec5c */
        }
    }
}
