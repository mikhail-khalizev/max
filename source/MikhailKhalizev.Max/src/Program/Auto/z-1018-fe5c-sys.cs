using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_fe5c-f6b03a25")]
        public void /* sys */ Method_1018_fe5c()
        {
            ii(0x1018_fe5c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_fe5e, 6); lea(ecx, 0x101b_f510);                  /* lea ecx, [0x101bf510] */
            ii(0x1018_fe64, 6); lea(edx, /* sys_mve */ 0x1018_ffcd);    /* lea edx, [0x1018ffcd] */
            ii(0x1018_fe6a, 3); mov(al, memb[ds, esi + 0x4]);           /* mov al, [esi+0x4] */
            ii(0x1018_fe6d, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_fe70, 2); mov(memb[ds, edx], bl);                 /* mov [edx], bl */
            ii(0x1018_fe72, 3); mov(memb[ds, edx + 0x2], bh);           /* mov [edx+0x2], bh */
            ii(0x1018_fe75, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_fe78, 3); mov(memb[ds, edx + 0x7], bl);           /* mov [edx+0x7], bl */
            ii(0x1018_fe7b, 3); mov(memb[ds, edx + 0x9], bh);           /* mov [edx+0x9], bh */
            ii(0x1018_fe7e, 3); mov(al, memb[ds, esi + 0x5]);           /* mov al, [esi+0x5] */
            ii(0x1018_fe81, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_fe84, 3); mov(memb[ds, edx + 0xd], bl);           /* mov [edx+0xd], bl */
            ii(0x1018_fe87, 3); mov(memb[ds, edx + 0xf], bh);           /* mov [edx+0xf], bh */
            ii(0x1018_fe8a, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_fe8d, 3); mov(memb[ds, edx + 0x14], bl);          /* mov [edx+0x14], bl */
            ii(0x1018_fe90, 3); mov(memb[ds, edx + 0x16], bh);          /* mov [edx+0x16], bh */
            ii(0x1018_fe93, 3); mov(al, memb[ds, esi + 0x6]);           /* mov al, [esi+0x6] */
            ii(0x1018_fe96, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_fe99, 3); mov(memb[ds, edx + 0x1d], bl);          /* mov [edx+0x1d], bl */
            ii(0x1018_fe9c, 3); mov(memb[ds, edx + 0x1f], bh);          /* mov [edx+0x1f], bh */
            ii(0x1018_fe9f, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_fea2, 3); mov(memb[ds, edx + 0x24], bl);          /* mov [edx+0x24], bl */
            ii(0x1018_fea5, 3); mov(memb[ds, edx + 0x26], bh);          /* mov [edx+0x26], bh */
            ii(0x1018_fea8, 3); mov(al, memb[ds, esi + 0x7]);           /* mov al, [esi+0x7] */
            ii(0x1018_feab, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_feae, 3); mov(memb[ds, edx + 0x2a], bl);          /* mov [edx+0x2a], bl */
            ii(0x1018_feb1, 3); mov(memb[ds, edx + 0x2c], bh);          /* mov [edx+0x2c], bh */
            ii(0x1018_feb4, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_feb7, 3); mov(memb[ds, edx + 0x31], bl);          /* mov [edx+0x31], bl */
            ii(0x1018_feba, 3); mov(memb[ds, edx + 0x33], bh);          /* mov [edx+0x33], bh */
            ii(0x1018_febd, 3); mov(al, memb[ds, esi + 0x8]);           /* mov al, [esi+0x8] */
            ii(0x1018_fec0, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_fec3, 3); mov(memb[ds, edx + 0x3a], bl);          /* mov [edx+0x3a], bl */
            ii(0x1018_fec6, 3); mov(memb[ds, edx + 0x3c], bh);          /* mov [edx+0x3c], bh */
            ii(0x1018_fec9, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_fecc, 3); mov(memb[ds, edx + 0x41], bl);          /* mov [edx+0x41], bl */
            ii(0x1018_fecf, 3); mov(memb[ds, edx + 0x43], bh);          /* mov [edx+0x43], bh */
            ii(0x1018_fed2, 3); mov(al, memb[ds, esi + 0x9]);           /* mov al, [esi+0x9] */
            ii(0x1018_fed5, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_fed8, 3); mov(memb[ds, edx + 0x47], bl);          /* mov [edx+0x47], bl */
            ii(0x1018_fedb, 3); mov(memb[ds, edx + 0x49], bh);          /* mov [edx+0x49], bh */
            ii(0x1018_fede, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_fee1, 3); mov(memb[ds, edx + 0x4e], bl);          /* mov [edx+0x4e], bl */
            ii(0x1018_fee4, 3); mov(memb[ds, edx + 0x50], bh);          /* mov [edx+0x50], bh */
            ii(0x1018_fee7, 3); mov(al, memb[ds, esi + 0xa]);           /* mov al, [esi+0xa] */
            ii(0x1018_feea, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_feed, 3); mov(memb[ds, edx + 0x57], bl);          /* mov [edx+0x57], bl */
            ii(0x1018_fef0, 3); mov(memb[ds, edx + 0x59], bh);          /* mov [edx+0x59], bh */
            ii(0x1018_fef3, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_fef6, 3); mov(memb[ds, edx + 0x5e], bl);          /* mov [edx+0x5e], bl */
            ii(0x1018_fef9, 3); mov(memb[ds, edx + 0x60], bh);          /* mov [edx+0x60], bh */
            ii(0x1018_fefc, 3); mov(al, memb[ds, esi + 0xb]);           /* mov al, [esi+0xb] */
            ii(0x1018_feff, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_ff02, 3); mov(memb[ds, edx + 0x64], bl);          /* mov [edx+0x64], bl */
            ii(0x1018_ff05, 3); mov(memb[ds, edx + 0x66], bh);          /* mov [edx+0x66], bh */
            ii(0x1018_ff08, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_ff0b, 3); mov(memb[ds, edx + 0x6b], bl);          /* mov [edx+0x6b], bl */
            ii(0x1018_ff0e, 3); mov(memb[ds, edx + 0x6d], bh);          /* mov [edx+0x6d], bh */
            ii(0x1018_ff11, 3); lea(edx, edx + 0x7c);                   /* lea edx, [edx+0x7c] */
            ii(0x1018_ff14, 3); mov(al, memb[ds, esi + 0x10]);          /* mov al, [esi+0x10] */
            ii(0x1018_ff17, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_ff1a, 2); mov(memb[ds, edx], bl);                 /* mov [edx], bl */
            ii(0x1018_ff1c, 3); mov(memb[ds, edx + 0x2], bh);           /* mov [edx+0x2], bh */
            ii(0x1018_ff1f, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_ff22, 3); mov(memb[ds, edx + 0x7], bl);           /* mov [edx+0x7], bl */
            ii(0x1018_ff25, 3); mov(memb[ds, edx + 0x9], bh);           /* mov [edx+0x9], bh */
            ii(0x1018_ff28, 3); mov(al, memb[ds, esi + 0x11]);          /* mov al, [esi+0x11] */
            ii(0x1018_ff2b, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_ff2e, 3); mov(memb[ds, edx + 0xd], bl);           /* mov [edx+0xd], bl */
            ii(0x1018_ff31, 3); mov(memb[ds, edx + 0xf], bh);           /* mov [edx+0xf], bh */
            ii(0x1018_ff34, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_ff37, 3); mov(memb[ds, edx + 0x14], bl);          /* mov [edx+0x14], bl */
            ii(0x1018_ff3a, 3); mov(memb[ds, edx + 0x16], bh);          /* mov [edx+0x16], bh */
            ii(0x1018_ff3d, 3); mov(al, memb[ds, esi + 0x12]);          /* mov al, [esi+0x12] */
            ii(0x1018_ff40, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_ff43, 3); mov(memb[ds, edx + 0x1d], bl);          /* mov [edx+0x1d], bl */
            ii(0x1018_ff46, 3); mov(memb[ds, edx + 0x1f], bh);          /* mov [edx+0x1f], bh */
            ii(0x1018_ff49, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_ff4c, 3); mov(memb[ds, edx + 0x24], bl);          /* mov [edx+0x24], bl */
            ii(0x1018_ff4f, 3); mov(memb[ds, edx + 0x26], bh);          /* mov [edx+0x26], bh */
            ii(0x1018_ff52, 3); mov(al, memb[ds, esi + 0x13]);          /* mov al, [esi+0x13] */
            ii(0x1018_ff55, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_ff58, 3); mov(memb[ds, edx + 0x2a], bl);          /* mov [edx+0x2a], bl */
            ii(0x1018_ff5b, 3); mov(memb[ds, edx + 0x2c], bh);          /* mov [edx+0x2c], bh */
            ii(0x1018_ff5e, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_ff61, 3); mov(memb[ds, edx + 0x31], bl);          /* mov [edx+0x31], bl */
            ii(0x1018_ff64, 3); mov(memb[ds, edx + 0x33], bh);          /* mov [edx+0x33], bh */
            ii(0x1018_ff67, 3); mov(al, memb[ds, esi + 0x14]);          /* mov al, [esi+0x14] */
            ii(0x1018_ff6a, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_ff6d, 3); mov(memb[ds, edx + 0x3a], bl);          /* mov [edx+0x3a], bl */
            ii(0x1018_ff70, 3); mov(memb[ds, edx + 0x3c], bh);          /* mov [edx+0x3c], bh */
            ii(0x1018_ff73, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_ff76, 3); mov(memb[ds, edx + 0x41], bl);          /* mov [edx+0x41], bl */
            ii(0x1018_ff79, 3); mov(memb[ds, edx + 0x43], bh);          /* mov [edx+0x43], bh */
            ii(0x1018_ff7c, 3); mov(al, memb[ds, esi + 0x15]);          /* mov al, [esi+0x15] */
            ii(0x1018_ff7f, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_ff82, 3); mov(memb[ds, edx + 0x47], bl);          /* mov [edx+0x47], bl */
            ii(0x1018_ff85, 3); mov(memb[ds, edx + 0x49], bh);          /* mov [edx+0x49], bh */
            ii(0x1018_ff88, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_ff8b, 3); mov(memb[ds, edx + 0x4e], bl);          /* mov [edx+0x4e], bl */
            ii(0x1018_ff8e, 3); mov(memb[ds, edx + 0x50], bh);          /* mov [edx+0x50], bh */
            ii(0x1018_ff91, 3); mov(al, memb[ds, esi + 0x16]);          /* mov al, [esi+0x16] */
            ii(0x1018_ff94, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_ff97, 3); mov(memb[ds, edx + 0x57], bl);          /* mov [edx+0x57], bl */
            ii(0x1018_ff9a, 3); mov(memb[ds, edx + 0x59], bh);          /* mov [edx+0x59], bh */
            ii(0x1018_ff9d, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_ffa0, 3); mov(memb[ds, edx + 0x5e], bl);          /* mov [edx+0x5e], bl */
            ii(0x1018_ffa3, 3); mov(memb[ds, edx + 0x60], bh);          /* mov [edx+0x60], bh */
            ii(0x1018_ffa6, 3); mov(al, memb[ds, esi + 0x17]);          /* mov al, [esi+0x17] */
            ii(0x1018_ffa9, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_ffac, 3); mov(memb[ds, edx + 0x64], bl);          /* mov [edx+0x64], bl */
            ii(0x1018_ffaf, 3); mov(memb[ds, edx + 0x66], bh);          /* mov [edx+0x66], bh */
            ii(0x1018_ffb2, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_ffb5, 3); mov(memb[ds, edx + 0x6b], bl);          /* mov [edx+0x6b], bl */
            ii(0x1018_ffb8, 3); mov(memb[ds, edx + 0x6d], bh);          /* mov [edx+0x6d], bh */
            ii(0x1018_ffbb, 3); mov(bx, memw[ds, esi]);                 /* mov bx, [esi] */
            ii(0x1018_ffbe, 4); mov(cx, memw[ds, esi + 0x2]);           /* mov cx, [esi+0x2] */
            ii(0x1018_ffc2, 6); mov(edx, memd[ds, 0x1020_9cd0]);        /* mov edx, [0x10209cd0] */
            ii(0x1018_ffc8, 2); if(jmp_func(0x1018_ffcc, 0x2)) return;  /* jmp 0x1018ffcc */
        }
    }
}
