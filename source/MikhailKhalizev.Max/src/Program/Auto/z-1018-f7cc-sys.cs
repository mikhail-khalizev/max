using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_f7cc-32c4d6e6")]
        public void /* sys */ Method_1018_f7cc()
        {
            ii(0x1018_f7cc, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_f7ce, 6); lea(ecx, 0x101b_f510);                  /* lea ecx, [0x101bf510] */
            ii(0x1018_f7d4, 6); lea(edx, /* sys_mve */ 0x1018_f89d);    /* lea edx, [0x1018f89d] */
            ii(0x1018_f7da, 3); mov(al, memb_a32[ds, esi + 0x4]);       /* mov al, [esi+0x4] */
            ii(0x1018_f7dd, 3); mov(ebx, memd_a32[ds, ecx + eax * 4]);  /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f7e0, 2); mov(memb_a32[ds, edx], bl);             /* mov [edx], bl */
            ii(0x1018_f7e2, 3); mov(memb_a32[ds, edx + 0x2], bh);       /* mov [edx+0x2], bh */
            ii(0x1018_f7e5, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_f7e8, 3); mov(memb_a32[ds, edx + 0x7], bl);       /* mov [edx+0x7], bl */
            ii(0x1018_f7eb, 3); mov(memb_a32[ds, edx + 0x9], bh);       /* mov [edx+0x9], bh */
            ii(0x1018_f7ee, 3); mov(al, memb_a32[ds, esi + 0x5]);       /* mov al, [esi+0x5] */
            ii(0x1018_f7f1, 3); mov(ebx, memd_a32[ds, ecx + eax * 4]);  /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f7f4, 3); mov(memb_a32[ds, edx + 0x10], bl);      /* mov [edx+0x10], bl */
            ii(0x1018_f7f7, 3); mov(memb_a32[ds, edx + 0x12], bh);      /* mov [edx+0x12], bh */
            ii(0x1018_f7fa, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_f7fd, 3); mov(memb_a32[ds, edx + 0x17], bl);      /* mov [edx+0x17], bl */
            ii(0x1018_f800, 3); mov(memb_a32[ds, edx + 0x19], bh);      /* mov [edx+0x19], bh */
            ii(0x1018_f803, 3); mov(al, memb_a32[ds, esi + 0x6]);       /* mov al, [esi+0x6] */
            ii(0x1018_f806, 3); mov(ebx, memd_a32[ds, ecx + eax * 4]);  /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f809, 3); mov(memb_a32[ds, edx + 0x25], bl);      /* mov [edx+0x25], bl */
            ii(0x1018_f80c, 3); mov(memb_a32[ds, edx + 0x27], bh);      /* mov [edx+0x27], bh */
            ii(0x1018_f80f, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_f812, 3); mov(memb_a32[ds, edx + 0x2c], bl);      /* mov [edx+0x2c], bl */
            ii(0x1018_f815, 3); mov(memb_a32[ds, edx + 0x2e], bh);      /* mov [edx+0x2e], bh */
            ii(0x1018_f818, 3); mov(al, memb_a32[ds, esi + 0x7]);       /* mov al, [esi+0x7] */
            ii(0x1018_f81b, 3); mov(ebx, memd_a32[ds, ecx + eax * 4]);  /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f81e, 3); mov(memb_a32[ds, edx + 0x35], bl);      /* mov [edx+0x35], bl */
            ii(0x1018_f821, 3); mov(memb_a32[ds, edx + 0x37], bh);      /* mov [edx+0x37], bh */
            ii(0x1018_f824, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_f827, 3); mov(memb_a32[ds, edx + 0x3c], bl);      /* mov [edx+0x3c], bl */
            ii(0x1018_f82a, 3); mov(memb_a32[ds, edx + 0x3e], bh);      /* mov [edx+0x3e], bh */
            ii(0x1018_f82d, 3); mov(al, memb_a32[ds, esi + 0x8]);       /* mov al, [esi+0x8] */
            ii(0x1018_f830, 3); mov(ebx, memd_a32[ds, ecx + eax * 4]);  /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f833, 3); mov(memb_a32[ds, edx + 0x4a], bl);      /* mov [edx+0x4a], bl */
            ii(0x1018_f836, 3); mov(memb_a32[ds, edx + 0x4c], bh);      /* mov [edx+0x4c], bh */
            ii(0x1018_f839, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_f83c, 3); mov(memb_a32[ds, edx + 0x51], bl);      /* mov [edx+0x51], bl */
            ii(0x1018_f83f, 3); mov(memb_a32[ds, edx + 0x53], bh);      /* mov [edx+0x53], bh */
            ii(0x1018_f842, 3); mov(al, memb_a32[ds, esi + 0x9]);       /* mov al, [esi+0x9] */
            ii(0x1018_f845, 3); mov(ebx, memd_a32[ds, ecx + eax * 4]);  /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f848, 3); mov(memb_a32[ds, edx + 0x5a], bl);      /* mov [edx+0x5a], bl */
            ii(0x1018_f84b, 3); mov(memb_a32[ds, edx + 0x5c], bh);      /* mov [edx+0x5c], bh */
            ii(0x1018_f84e, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_f851, 3); mov(memb_a32[ds, edx + 0x61], bl);      /* mov [edx+0x61], bl */
            ii(0x1018_f854, 3); mov(memb_a32[ds, edx + 0x63], bh);      /* mov [edx+0x63], bh */
            ii(0x1018_f857, 3); mov(al, memb_a32[ds, esi + 0xa]);       /* mov al, [esi+0xa] */
            ii(0x1018_f85a, 3); mov(ebx, memd_a32[ds, ecx + eax * 4]);  /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f85d, 3); mov(memb_a32[ds, edx + 0x6f], bl);      /* mov [edx+0x6f], bl */
            ii(0x1018_f860, 3); mov(memb_a32[ds, edx + 0x71], bh);      /* mov [edx+0x71], bh */
            ii(0x1018_f863, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_f866, 3); mov(memb_a32[ds, edx + 0x76], bl);      /* mov [edx+0x76], bl */
            ii(0x1018_f869, 3); mov(memb_a32[ds, edx + 0x78], bh);      /* mov [edx+0x78], bh */
            ii(0x1018_f86c, 3); mov(al, memb_a32[ds, esi + 0xb]);       /* mov al, [esi+0xb] */
            ii(0x1018_f86f, 3); mov(ebx, memd_a32[ds, ecx + eax * 4]);  /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f872, 3); mov(memb_a32[ds, edx + 0x7f], bl);      /* mov [edx+0x7f], bl */
            ii(0x1018_f875, 6); mov(memb_a32[ds, edx + 0x81], bh);      /* mov [edx+0x81], bh */
            ii(0x1018_f87b, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_f87e, 6); mov(memb_a32[ds, edx + 0x86], bl);      /* mov [edx+0x86], bl */
            ii(0x1018_f884, 6); mov(memb_a32[ds, edx + 0x88], bh);      /* mov [edx+0x88], bh */
            ii(0x1018_f88a, 3); mov(bx, memw_a32[ds, esi]);             /* mov bx, [esi] */
            ii(0x1018_f88d, 4); mov(cx, memw_a32[ds, esi + 0x2]);       /* mov cx, [esi+0x2] */
            ii(0x1018_f891, 6); mov(edx, memd_a32[ds, 0x1020_9cd0]);    /* mov edx, [0x10209cd0] */
            ii(0x1018_f897, 2); jmpd(0x1018_f89c, 0x3); goto l_0x1018_f89c; /* jmp 0x1018f89c */
        //  ii(0x1018_f899, 3); mov(eax, eax);                          /* mov eax, eax */
        l_0x1018_f89c:
            ii(0x1018_f89c, 2); mov(al, bl);                            /* mov al, bl */
            ii(0x1018_f89e, 2); mov(ah, bl);                            /* mov ah, bl */
            ii(0x1018_f8a0, 3); shl(eax, 0x10);                         /* shl eax, 0x10 */
            ii(0x1018_f8a3, 2); mov(al, bl);                            /* mov al, bl */
            ii(0x1018_f8a5, 2); mov(ah, bl);                            /* mov ah, bl */
            ii(0x1018_f8a7, 2); mov(memd_a32[ds, edi], eax);            /* mov [edi], eax */
            ii(0x1018_f8a9, 3); mov(memd_a32[ds, edx + edi], eax);      /* mov [edx+edi], eax */
            ii(0x1018_f8ac, 2); mov(al, bl);                            /* mov al, bl */
            ii(0x1018_f8ae, 2); mov(ah, bl);                            /* mov ah, bl */
            ii(0x1018_f8b0, 3); shl(eax, 0x10);                         /* shl eax, 0x10 */
            ii(0x1018_f8b3, 2); mov(al, bl);                            /* mov al, bl */
            ii(0x1018_f8b5, 2); mov(ah, bl);                            /* mov ah, bl */
            ii(0x1018_f8b7, 3); mov(memd_a32[ds, edi + 0x4], eax);      /* mov [edi+0x4], eax */
            ii(0x1018_f8ba, 4); mov(memd_a32[ds, edx + edi + 0x4], eax); /* mov [edx+edi+0x4], eax */
            ii(0x1018_f8be, 3); lea(edi, edi + edx * 2);                /* lea edi, [edi+edx*2] */
            ii(0x1018_f8c1, 2); mov(al, bl);                            /* mov al, bl */
            ii(0x1018_f8c3, 2); mov(ah, bl);                            /* mov ah, bl */
            ii(0x1018_f8c5, 3); shl(eax, 0x10);                         /* shl eax, 0x10 */
            ii(0x1018_f8c8, 2); mov(al, bl);                            /* mov al, bl */
            ii(0x1018_f8ca, 2); mov(ah, bl);                            /* mov ah, bl */
            ii(0x1018_f8cc, 2); mov(memd_a32[ds, edi], eax);            /* mov [edi], eax */
            ii(0x1018_f8ce, 3); mov(memd_a32[ds, edx + edi], eax);      /* mov [edx+edi], eax */
            ii(0x1018_f8d1, 2); mov(al, bl);                            /* mov al, bl */
            ii(0x1018_f8d3, 2); mov(ah, bl);                            /* mov ah, bl */
            ii(0x1018_f8d5, 3); shl(eax, 0x10);                         /* shl eax, 0x10 */
            ii(0x1018_f8d8, 2); mov(al, bl);                            /* mov al, bl */
            ii(0x1018_f8da, 2); mov(ah, bl);                            /* mov ah, bl */
            ii(0x1018_f8dc, 3); mov(memd_a32[ds, edi + 0x4], eax);      /* mov [edi+0x4], eax */
            ii(0x1018_f8df, 4); mov(memd_a32[ds, edx + edi + 0x4], eax); /* mov [edx+edi+0x4], eax */
            ii(0x1018_f8e3, 3); lea(edi, edi + edx * 2);                /* lea edi, [edi+edx*2] */
            ii(0x1018_f8e6, 2); mov(al, bl);                            /* mov al, bl */
            ii(0x1018_f8e8, 2); mov(ah, bl);                            /* mov ah, bl */
            ii(0x1018_f8ea, 3); shl(eax, 0x10);                         /* shl eax, 0x10 */
            ii(0x1018_f8ed, 2); mov(al, bl);                            /* mov al, bl */
            ii(0x1018_f8ef, 2); mov(ah, bl);                            /* mov ah, bl */
            ii(0x1018_f8f1, 2); mov(memd_a32[ds, edi], eax);            /* mov [edi], eax */
            ii(0x1018_f8f3, 3); mov(memd_a32[ds, edx + edi], eax);      /* mov [edx+edi], eax */
            ii(0x1018_f8f6, 2); mov(al, bl);                            /* mov al, bl */
            ii(0x1018_f8f8, 2); mov(ah, bl);                            /* mov ah, bl */
            ii(0x1018_f8fa, 3); shl(eax, 0x10);                         /* shl eax, 0x10 */
            ii(0x1018_f8fd, 2); mov(al, bl);                            /* mov al, bl */
            ii(0x1018_f8ff, 2); mov(ah, bl);                            /* mov ah, bl */
            ii(0x1018_f901, 3); mov(memd_a32[ds, edi + 0x4], eax);      /* mov [edi+0x4], eax */
            ii(0x1018_f904, 4); mov(memd_a32[ds, edx + edi + 0x4], eax); /* mov [edx+edi+0x4], eax */
            ii(0x1018_f908, 3); lea(edi, edi + edx * 2);                /* lea edi, [edi+edx*2] */
            ii(0x1018_f90b, 2); mov(al, bl);                            /* mov al, bl */
            ii(0x1018_f90d, 2); mov(ah, bl);                            /* mov ah, bl */
            ii(0x1018_f90f, 3); shl(eax, 0x10);                         /* shl eax, 0x10 */
            ii(0x1018_f912, 2); mov(al, bl);                            /* mov al, bl */
            ii(0x1018_f914, 2); mov(ah, bl);                            /* mov ah, bl */
            ii(0x1018_f916, 2); mov(memd_a32[ds, edi], eax);            /* mov [edi], eax */
            ii(0x1018_f918, 3); mov(memd_a32[ds, edx + edi], eax);      /* mov [edx+edi], eax */
            ii(0x1018_f91b, 2); mov(al, bl);                            /* mov al, bl */
            ii(0x1018_f91d, 2); mov(ah, bl);                            /* mov ah, bl */
            ii(0x1018_f91f, 3); shl(eax, 0x10);                         /* shl eax, 0x10 */
            ii(0x1018_f922, 2); mov(al, bl);                            /* mov al, bl */
            ii(0x1018_f924, 2); mov(ah, bl);                            /* mov ah, bl */
            ii(0x1018_f926, 3); mov(memd_a32[ds, edi + 0x4], eax);      /* mov [edi+0x4], eax */
            ii(0x1018_f929, 4); mov(memd_a32[ds, edx + edi + 0x4], eax); /* mov [edx+edi+0x4], eax */
            ii(0x1018_f92d, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_f92f, 3); add(esi, 0xc);                          /* add esi, 0xc */
            ii(0x1018_f932, 3); sub(edi, memd_a32[ss, ebp - 0x10]);     /* sub edi, [ebp-0x10] */
            ii(0x1018_f935, 1); retd(); return;                         /* ret */
        }
    }
}
