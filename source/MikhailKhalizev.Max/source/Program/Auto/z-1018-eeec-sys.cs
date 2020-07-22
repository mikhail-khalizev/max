using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_eeec-c7e10770")]
        public void /* sys */ Method_1018_eeec()
        {
            ii(0x1018_eeec, 4);  mov(ax, memw[ds, esi + 6]);           /* mov ax, [esi+0x6] */
            ii(0x1018_eef0, 2);  cmp(al, ah);                          /* cmp al, ah */
            ii(0x1018_eef2, 6);  if(ja_func(0x1018_f0c8, 0x1d0)) return;/* ja 0x1018f0c8 */
            ii(0x1018_eef8, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1018_eefa, 6);  lea(ecx, memd[ds, 0x101b_f110]);      /* lea ecx, [0x101bf110] */
            ii(0x1018_ef00, 6);  lea(edx, memd[ds, /* sys_mve */ 0x1018_efd2]);/* lea edx, [0x1018efd2] */
            ii(0x1018_ef06, 3);  mov(al, memb[ds, esi + 2]);           /* mov al, [esi+0x2] */
            ii(0x1018_ef09, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_ef0c, 2);  mov(memb[ds, edx], bl);               /* mov [edx], bl */
            ii(0x1018_ef0e, 3);  mov(memb[ds, edx + 6], bh);           /* mov [edx+0x6], bh */
            ii(0x1018_ef11, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_ef14, 3);  mov(memb[ds, edx + 13], bl);          /* mov [edx+0xd], bl */
            ii(0x1018_ef17, 3);  mov(memb[ds, edx + 19], bh);          /* mov [edx+0x13], bh */
            ii(0x1018_ef1a, 3);  mov(al, memb[ds, esi + 3]);           /* mov al, [esi+0x3] */
            ii(0x1018_ef1d, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_ef20, 3);  mov(memb[ds, edx + 26], bl);          /* mov [edx+0x1a], bl */
            ii(0x1018_ef23, 3);  mov(memb[ds, edx + 32], bh);          /* mov [edx+0x20], bh */
            ii(0x1018_ef26, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_ef29, 3);  mov(memb[ds, edx + 39], bl);          /* mov [edx+0x27], bl */
            ii(0x1018_ef2c, 3);  mov(memb[ds, edx + 45], bh);          /* mov [edx+0x2d], bh */
            ii(0x1018_ef2f, 3);  mov(al, memb[ds, esi + 4]);           /* mov al, [esi+0x4] */
            ii(0x1018_ef32, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_ef35, 3);  mov(memb[ds, edx + 52], bl);          /* mov [edx+0x34], bl */
            ii(0x1018_ef38, 3);  mov(memb[ds, edx + 58], bh);          /* mov [edx+0x3a], bh */
            ii(0x1018_ef3b, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_ef3e, 3);  mov(memb[ds, edx + 65], bl);          /* mov [edx+0x41], bl */
            ii(0x1018_ef41, 3);  mov(memb[ds, edx + 71], bh);          /* mov [edx+0x47], bh */
            ii(0x1018_ef44, 3);  mov(al, memb[ds, esi + 5]);           /* mov al, [esi+0x5] */
            ii(0x1018_ef47, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_ef4a, 3);  mov(memb[ds, edx + 78], bl);          /* mov [edx+0x4e], bl */
            ii(0x1018_ef4d, 3);  mov(memb[ds, edx + 84], bh);          /* mov [edx+0x54], bh */
            ii(0x1018_ef50, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_ef53, 3);  mov(memb[ds, edx + 91], bl);          /* mov [edx+0x5b], bl */
            ii(0x1018_ef56, 3);  mov(memb[ds, edx + 97], bh);          /* mov [edx+0x61], bh */
            ii(0x1018_ef59, 6);  add(edx, 0x86);                       /* add edx, 0x86 */
            ii(0x1018_ef5f, 3);  mov(al, memb[ds, esi + 8]);           /* mov al, [esi+0x8] */
            ii(0x1018_ef62, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_ef65, 2);  mov(memb[ds, edx], bl);               /* mov [edx], bl */
            ii(0x1018_ef67, 3);  mov(memb[ds, edx + 6], bh);           /* mov [edx+0x6], bh */
            ii(0x1018_ef6a, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_ef6d, 3);  mov(memb[ds, edx + 13], bl);          /* mov [edx+0xd], bl */
            ii(0x1018_ef70, 3);  mov(memb[ds, edx + 19], bh);          /* mov [edx+0x13], bh */
            ii(0x1018_ef73, 3);  mov(al, memb[ds, esi + 9]);           /* mov al, [esi+0x9] */
            ii(0x1018_ef76, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_ef79, 3);  mov(memb[ds, edx + 26], bl);          /* mov [edx+0x1a], bl */
            ii(0x1018_ef7c, 3);  mov(memb[ds, edx + 32], bh);          /* mov [edx+0x20], bh */
            ii(0x1018_ef7f, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_ef82, 3);  mov(memb[ds, edx + 39], bl);          /* mov [edx+0x27], bl */
            ii(0x1018_ef85, 3);  mov(memb[ds, edx + 45], bh);          /* mov [edx+0x2d], bh */
            ii(0x1018_ef88, 3);  mov(al, memb[ds, esi + 10]);          /* mov al, [esi+0xa] */
            ii(0x1018_ef8b, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_ef8e, 3);  mov(memb[ds, edx + 52], bl);          /* mov [edx+0x34], bl */
            ii(0x1018_ef91, 3);  mov(memb[ds, edx + 58], bh);          /* mov [edx+0x3a], bh */
            ii(0x1018_ef94, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_ef97, 3);  mov(memb[ds, edx + 65], bl);          /* mov [edx+0x41], bl */
            ii(0x1018_ef9a, 3);  mov(memb[ds, edx + 71], bh);          /* mov [edx+0x47], bh */
            ii(0x1018_ef9d, 3);  mov(al, memb[ds, esi + 11]);          /* mov al, [esi+0xb] */
            ii(0x1018_efa0, 3);  mov(ebx, memd[ds, ecx + eax * 4]);    /* mov ebx, [ecx+eax*4] */
            ii(0x1018_efa3, 3);  mov(memb[ds, edx + 78], bl);          /* mov [edx+0x4e], bl */
            ii(0x1018_efa6, 3);  mov(memb[ds, edx + 84], bh);          /* mov [edx+0x54], bh */
            ii(0x1018_efa9, 3);  shr(ebx, 0x10);                       /* shr ebx, 0x10 */
            ii(0x1018_efac, 3);  mov(memb[ds, edx + 91], bl);          /* mov [edx+0x5b], bl */
            ii(0x1018_efaf, 3);  mov(memb[ds, edx + 97], bh);          /* mov [edx+0x61], bh */
            ii(0x1018_efb2, 1);  push(ebp);                            /* push ebp */
            ii(0x1018_efb3, 1);  push(esi);                            /* push esi */
            ii(0x1018_efb4, 3);  mov(cx, memw[ds, esi]);               /* mov cx, [esi] */
            ii(0x1018_efb7, 6);  mov(esi, memd[ds, 0x1020_9cd0]);      /* mov esi, [0x10209cd0] */
            ii(0x1018_efbd, 2);  mov(bl, cl);                          /* mov bl, cl */
            ii(0x1018_efbf, 2);  mov(bh, cl);                          /* mov bh, cl */
            ii(0x1018_efc1, 2);  mov(dl, ch);                          /* mov dl, ch */
            ii(0x1018_efc3, 2);  mov(dh, cl);                          /* mov dh, cl */
            ii(0x1018_efc5, 2);  mov(al, ch);                          /* mov al, ch */
            ii(0x1018_efc7, 2);  mov(ah, ch);                          /* mov ah, ch */
            ii(0x1018_efc9, 2);  mov(ebp, eax);                        /* mov ebp, eax */
            ii(0x1018_efcb, 2);  jmp_func(0x1018_efd0, 3);             /* jmp 0x1018efd0 */
        }
    }
}
