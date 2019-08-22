using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_f4f8-1204f80f")]
        public void /* sys */ Method_1018_f4f8()
        {
            ii(0x1018_f4f8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_f4fa, 6); lea(ecx, 0x101b_f510);                  /* lea ecx, [0x101bf510] */
            ii(0x1018_f500, 6); lea(edx, /* sys_mve */ 0x1018_f56d);    /* lea edx, [0x1018f56d] */
            ii(0x1018_f506, 3); mov(al, memb_a32[ds, esi + 0x4]);       /* mov al, [esi+0x4] */
            ii(0x1018_f509, 3); mov(ebx, memd_a32[ds, ecx + eax * 4]);  /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f50c, 3); mov(memb_a32[ds, edx + 0x17], bl);      /* mov [edx+0x17], bl */
            ii(0x1018_f50f, 3); mov(memb_a32[ds, edx + 0x10], bh);      /* mov [edx+0x10], bh */
            ii(0x1018_f512, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_f515, 3); mov(memb_a32[ds, edx + 0x7], bl);       /* mov [edx+0x7], bl */
            ii(0x1018_f518, 2); mov(memb_a32[ds, edx], bh);             /* mov [edx], bh */
            ii(0x1018_f51a, 3); mov(al, memb_a32[ds, esi + 0x5]);       /* mov al, [esi+0x5] */
            ii(0x1018_f51d, 3); mov(ebx, memd_a32[ds, ecx + eax * 4]);  /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f520, 3); mov(memb_a32[ds, edx + 0x3c], bl);      /* mov [edx+0x3c], bl */
            ii(0x1018_f523, 3); mov(memb_a32[ds, edx + 0x35], bh);      /* mov [edx+0x35], bh */
            ii(0x1018_f526, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_f529, 3); mov(memb_a32[ds, edx + 0x2c], bl);      /* mov [edx+0x2c], bl */
            ii(0x1018_f52c, 3); mov(memb_a32[ds, edx + 0x25], bh);      /* mov [edx+0x25], bh */
            ii(0x1018_f52f, 3); mov(al, memb_a32[ds, esi + 0x6]);       /* mov al, [esi+0x6] */
            ii(0x1018_f532, 3); mov(ebx, memd_a32[ds, ecx + eax * 4]);  /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f535, 3); mov(memb_a32[ds, edx + 0x61], bl);      /* mov [edx+0x61], bl */
            ii(0x1018_f538, 3); mov(memb_a32[ds, edx + 0x5a], bh);      /* mov [edx+0x5a], bh */
            ii(0x1018_f53b, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_f53e, 3); mov(memb_a32[ds, edx + 0x51], bl);      /* mov [edx+0x51], bl */
            ii(0x1018_f541, 3); mov(memb_a32[ds, edx + 0x4a], bh);      /* mov [edx+0x4a], bh */
            ii(0x1018_f544, 3); mov(al, memb_a32[ds, esi + 0x7]);       /* mov al, [esi+0x7] */
            ii(0x1018_f547, 3); mov(ebx, memd_a32[ds, ecx + eax * 4]);  /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f54a, 6); mov(memb_a32[ds, edx + 0x86], bl);      /* mov [edx+0x86], bl */
            ii(0x1018_f550, 3); mov(memb_a32[ds, edx + 0x7f], bh);      /* mov [edx+0x7f], bh */
            ii(0x1018_f553, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_f556, 3); mov(memb_a32[ds, edx + 0x76], bl);      /* mov [edx+0x76], bl */
            ii(0x1018_f559, 3); mov(memb_a32[ds, edx + 0x6f], bh);      /* mov [edx+0x6f], bh */
            ii(0x1018_f55c, 3); mov(bx, memw_a32[ds, esi]);             /* mov bx, [esi] */
            ii(0x1018_f55f, 4); mov(cx, memw_a32[ds, esi + 0x2]);       /* mov cx, [esi+0x2] */
            ii(0x1018_f563, 6); mov(edx, memd_a32[ds, 0x1020_9cd0]);    /* mov edx, [0x10209cd0] */
            ii(0x1018_f569, 2); if(jmpd_func(0x1018_f56c, 0x1)) return; /* jmp 0x1018f56c */
        }
    }
}