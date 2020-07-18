using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_fbd0-dce83cda")]
        public void /* sys */ Method_1018_fbd0()
        {
            ii(0x1018_fbd0, 4);  mov(ax, memw[ds, esi + 12]);          /* mov ax, [esi+0xc] */
            ii(0x1018_fbd4, 2);  cmp(al, ah);                          /* cmp al, ah */
            ii(0x1018_fbd6, 6);  if(ja_func(0x1018_fe5c, 0x280)) return;/* ja 0x1018fe5c */
            ii(0x1018_fbdc, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1018_fbde, 6);  lea(ecx, memd[ds, 0x101b_f510]);      /* lea ecx, [0x101bf510] */
            ii(0x1018_fbe4, 6);  lea(edx, memd[ds, /* sys_mve */ 0x1018_fd51]);/* lea edx, [0x1018fd51] */
            ii(0x1018_fbea, 3);  mov(al, memb[ds, esi + 4]);           /* mov al, [esi+0x4] */
            ii(0x1018_fbed, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_fbf0, 2);  mov(memb[ds, edx], bl);               /* mov [edx], bl */
            ii(0x1018_fbf2, 3);  mov(memb[ds, edx + 2], bh);           /* mov [edx+0x2], bh */
            ii(0x1018_fbf5, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_fbf8, 3);  mov(memb[ds, edx + 7], bl);           /* mov [edx+0x7], bl */
            ii(0x1018_fbfb, 3);  mov(memb[ds, edx + 9], bh);           /* mov [edx+0x9], bh */
            ii(0x1018_fbfe, 3);  mov(al, memb[ds, esi + 5]);           /* mov al, [esi+0x5] */
            ii(0x1018_fc01, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_fc04, 3);  mov(memb[ds, edx + 15], bl);          /* mov [edx+0xf], bl */
            ii(0x1018_fc07, 3);  mov(memb[ds, edx + 17], bh);          /* mov [edx+0x11], bh */
            ii(0x1018_fc0a, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_fc0d, 3);  mov(memb[ds, edx + 22], bl);          /* mov [edx+0x16], bl */
            ii(0x1018_fc10, 3);  mov(memb[ds, edx + 24], bh);          /* mov [edx+0x18], bh */
            ii(0x1018_fc13, 3);  mov(al, memb[ds, esi + 6]);           /* mov al, [esi+0x6] */
            ii(0x1018_fc16, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_fc19, 3);  mov(memb[ds, edx + 30], bl);          /* mov [edx+0x1e], bl */
            ii(0x1018_fc1c, 3);  mov(memb[ds, edx + 32], bh);          /* mov [edx+0x20], bh */
            ii(0x1018_fc1f, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_fc22, 3);  mov(memb[ds, edx + 37], bl);          /* mov [edx+0x25], bl */
            ii(0x1018_fc25, 3);  mov(memb[ds, edx + 39], bh);          /* mov [edx+0x27], bh */
            ii(0x1018_fc28, 3);  mov(al, memb[ds, esi + 7]);           /* mov al, [esi+0x7] */
            ii(0x1018_fc2b, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_fc2e, 3);  mov(memb[ds, edx + 45], bl);          /* mov [edx+0x2d], bl */
            ii(0x1018_fc31, 3);  mov(memb[ds, edx + 47], bh);          /* mov [edx+0x2f], bh */
            ii(0x1018_fc34, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_fc37, 3);  mov(memb[ds, edx + 52], bl);          /* mov [edx+0x34], bl */
            ii(0x1018_fc3a, 3);  mov(memb[ds, edx + 54], bh);          /* mov [edx+0x36], bh */
            ii(0x1018_fc3d, 3);  mov(al, memb[ds, esi + 8]);           /* mov al, [esi+0x8] */
            ii(0x1018_fc40, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_fc43, 3);  mov(memb[ds, edx + 60], bl);          /* mov [edx+0x3c], bl */
            ii(0x1018_fc46, 3);  mov(memb[ds, edx + 62], bh);          /* mov [edx+0x3e], bh */
            ii(0x1018_fc49, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_fc4c, 3);  mov(memb[ds, edx + 67], bl);          /* mov [edx+0x43], bl */
            ii(0x1018_fc4f, 3);  mov(memb[ds, edx + 69], bh);          /* mov [edx+0x45], bh */
            ii(0x1018_fc52, 3);  mov(al, memb[ds, esi + 9]);           /* mov al, [esi+0x9] */
            ii(0x1018_fc55, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_fc58, 3);  mov(memb[ds, edx + 75], bl);          /* mov [edx+0x4b], bl */
            ii(0x1018_fc5b, 3);  mov(memb[ds, edx + 77], bh);          /* mov [edx+0x4d], bh */
            ii(0x1018_fc5e, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_fc61, 3);  mov(memb[ds, edx + 82], bl);          /* mov [edx+0x52], bl */
            ii(0x1018_fc64, 3);  mov(memb[ds, edx + 84], bh);          /* mov [edx+0x54], bh */
            ii(0x1018_fc67, 3);  mov(al, memb[ds, esi + 10]);          /* mov al, [esi+0xa] */
            ii(0x1018_fc6a, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_fc6d, 3);  mov(memb[ds, edx + 90], bl);          /* mov [edx+0x5a], bl */
            ii(0x1018_fc70, 3);  mov(memb[ds, edx + 92], bh);          /* mov [edx+0x5c], bh */
            ii(0x1018_fc73, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_fc76, 3);  mov(memb[ds, edx + 97], bl);          /* mov [edx+0x61], bl */
            ii(0x1018_fc79, 3);  mov(memb[ds, edx + 99], bh);          /* mov [edx+0x63], bh */
            ii(0x1018_fc7c, 3);  mov(al, memb[ds, esi + 11]);          /* mov al, [esi+0xb] */
            ii(0x1018_fc7f, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_fc82, 3);  mov(memb[ds, edx + 105], bl);         /* mov [edx+0x69], bl */
            ii(0x1018_fc85, 3);  mov(memb[ds, edx + 107], bh);         /* mov [edx+0x6b], bh */
            ii(0x1018_fc88, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_fc8b, 3);  mov(memb[ds, edx + 112], bl);         /* mov [edx+0x70], bl */
            ii(0x1018_fc8e, 3);  mov(memb[ds, edx + 114], bh);         /* mov [edx+0x72], bh */
            ii(0x1018_fc91, 6);  lea(edx, memd[ds, edx + 137]);        /* lea edx, [edx+0x89] */
            ii(0x1018_fc97, 3);  mov(al, memb[ds, esi + 16]);          /* mov al, [esi+0x10] */
            ii(0x1018_fc9a, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_fc9d, 2);  mov(memb[ds, edx], bl);               /* mov [edx], bl */
            ii(0x1018_fc9f, 3);  mov(memb[ds, edx + 2], bh);           /* mov [edx+0x2], bh */
            ii(0x1018_fca2, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_fca5, 3);  mov(memb[ds, edx + 7], bl);           /* mov [edx+0x7], bl */
            ii(0x1018_fca8, 3);  mov(memb[ds, edx + 9], bh);           /* mov [edx+0x9], bh */
            ii(0x1018_fcab, 3);  mov(al, memb[ds, esi + 17]);          /* mov al, [esi+0x11] */
            ii(0x1018_fcae, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_fcb1, 3);  mov(memb[ds, edx + 15], bl);          /* mov [edx+0xf], bl */
            ii(0x1018_fcb4, 3);  mov(memb[ds, edx + 17], bh);          /* mov [edx+0x11], bh */
            ii(0x1018_fcb7, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_fcba, 3);  mov(memb[ds, edx + 22], bl);          /* mov [edx+0x16], bl */
            ii(0x1018_fcbd, 3);  mov(memb[ds, edx + 24], bh);          /* mov [edx+0x18], bh */
            ii(0x1018_fcc0, 3);  mov(al, memb[ds, esi + 18]);          /* mov al, [esi+0x12] */
            ii(0x1018_fcc3, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_fcc6, 3);  mov(memb[ds, edx + 30], bl);          /* mov [edx+0x1e], bl */
            ii(0x1018_fcc9, 3);  mov(memb[ds, edx + 32], bh);          /* mov [edx+0x20], bh */
            ii(0x1018_fccc, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_fccf, 3);  mov(memb[ds, edx + 37], bl);          /* mov [edx+0x25], bl */
            ii(0x1018_fcd2, 3);  mov(memb[ds, edx + 39], bh);          /* mov [edx+0x27], bh */
            ii(0x1018_fcd5, 3);  mov(al, memb[ds, esi + 19]);          /* mov al, [esi+0x13] */
            ii(0x1018_fcd8, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_fcdb, 3);  mov(memb[ds, edx + 45], bl);          /* mov [edx+0x2d], bl */
            ii(0x1018_fcde, 3);  mov(memb[ds, edx + 47], bh);          /* mov [edx+0x2f], bh */
            ii(0x1018_fce1, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_fce4, 3);  mov(memb[ds, edx + 52], bl);          /* mov [edx+0x34], bl */
            ii(0x1018_fce7, 3);  mov(memb[ds, edx + 54], bh);          /* mov [edx+0x36], bh */
            ii(0x1018_fcea, 3);  mov(al, memb[ds, esi + 20]);          /* mov al, [esi+0x14] */
            ii(0x1018_fced, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_fcf0, 3);  mov(memb[ds, edx + 60], bl);          /* mov [edx+0x3c], bl */
            ii(0x1018_fcf3, 3);  mov(memb[ds, edx + 62], bh);          /* mov [edx+0x3e], bh */
            ii(0x1018_fcf6, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_fcf9, 3);  mov(memb[ds, edx + 67], bl);          /* mov [edx+0x43], bl */
            ii(0x1018_fcfc, 3);  mov(memb[ds, edx + 69], bh);          /* mov [edx+0x45], bh */
            ii(0x1018_fcff, 3);  mov(al, memb[ds, esi + 21]);          /* mov al, [esi+0x15] */
            ii(0x1018_fd02, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_fd05, 3);  mov(memb[ds, edx + 75], bl);          /* mov [edx+0x4b], bl */
            ii(0x1018_fd08, 3);  mov(memb[ds, edx + 77], bh);          /* mov [edx+0x4d], bh */
            ii(0x1018_fd0b, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_fd0e, 3);  mov(memb[ds, edx + 82], bl);          /* mov [edx+0x52], bl */
            ii(0x1018_fd11, 3);  mov(memb[ds, edx + 84], bh);          /* mov [edx+0x54], bh */
            ii(0x1018_fd14, 3);  mov(al, memb[ds, esi + 22]);          /* mov al, [esi+0x16] */
            ii(0x1018_fd17, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_fd1a, 3);  mov(memb[ds, edx + 90], bl);          /* mov [edx+0x5a], bl */
            ii(0x1018_fd1d, 3);  mov(memb[ds, edx + 92], bh);          /* mov [edx+0x5c], bh */
            ii(0x1018_fd20, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_fd23, 3);  mov(memb[ds, edx + 97], bl);          /* mov [edx+0x61], bl */
            ii(0x1018_fd26, 3);  mov(memb[ds, edx + 99], bh);          /* mov [edx+0x63], bh */
            ii(0x1018_fd29, 3);  mov(al, memb[ds, esi + 23]);          /* mov al, [esi+0x17] */
            ii(0x1018_fd2c, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_fd2f, 3);  mov(memb[ds, edx + 105], bl);         /* mov [edx+0x69], bl */
            ii(0x1018_fd32, 3);  mov(memb[ds, edx + 107], bh);         /* mov [edx+0x6b], bh */
            ii(0x1018_fd35, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_fd38, 3);  mov(memb[ds, edx + 112], bl);         /* mov [edx+0x70], bl */
            ii(0x1018_fd3b, 3);  mov(memb[ds, edx + 114], bh);         /* mov [edx+0x72], bh */
            ii(0x1018_fd3e, 3);  mov(bx, memw[ds, esi]);               /* mov bx, [esi] */
            ii(0x1018_fd41, 4);  mov(cx, memw[ds, esi + 2]);           /* mov cx, [esi+0x2] */
            ii(0x1018_fd45, 6);  mov(edx, memd[ds, 0x1020_9cd0]);      /* mov edx, [0x10209cd0] */
            ii(0x1018_fd4b, 2);  jmp_func(0x1018_fd50, 3);             /* jmp 0x1018fd50 */
        }
    }
}
