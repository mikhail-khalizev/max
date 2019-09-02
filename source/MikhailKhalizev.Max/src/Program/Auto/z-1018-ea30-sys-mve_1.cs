using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_ea30-f5340d99")]
        public void /* sys */ mve_1()
        {
            ii(0x1018_ea30, 3); mov(ax, memw[ds, esi]);                 /* mov ax, [esi] */
            ii(0x1018_ea33, 2); cmp(al, ah);                            /* cmp al, ah */
            ii(0x1018_ea35, 6); if(ja_func(0x1018_ebe0, 0x1a5)) return; /* ja 0x1018ebe0 */
            ii(0x1018_ea3b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_ea3d, 6); lea(ecx, memd[ds, 0x101b_f110]);        /* lea ecx, [0x101bf110] */
            ii(0x1018_ea43, 6); lea(edx, memd[ds, /* sys_mve */ 0x1018_eb12]); /* lea edx, [0x1018eb12] */
            ii(0x1018_ea49, 3); mov(al, memb[ds, esi + 2]);             /* mov al, [esi+0x2] */
            ii(0x1018_ea4c, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_ea4f, 2); mov(memb[ds, edx], bl);                 /* mov [edx], bl */
            ii(0x1018_ea51, 3); mov(memb[ds, edx + 6], bh);             /* mov [edx+0x6], bh */
            ii(0x1018_ea54, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_ea57, 3); mov(memb[ds, edx + 0xb], bl);           /* mov [edx+0xb], bl */
            ii(0x1018_ea5a, 3); mov(memb[ds, edx + 0x11], bh);          /* mov [edx+0x11], bh */
            ii(0x1018_ea5d, 3); mov(al, memb[ds, esi + 3]);             /* mov al, [esi+0x3] */
            ii(0x1018_ea60, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_ea63, 3); mov(memb[ds, edx + 0x19], bl);          /* mov [edx+0x19], bl */
            ii(0x1018_ea66, 3); mov(memb[ds, edx + 0x1f], bh);          /* mov [edx+0x1f], bh */
            ii(0x1018_ea69, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_ea6c, 3); mov(memb[ds, edx + 0x24], bl);          /* mov [edx+0x24], bl */
            ii(0x1018_ea6f, 3); mov(memb[ds, edx + 0x2a], bh);          /* mov [edx+0x2a], bh */
            ii(0x1018_ea72, 3); mov(al, memb[ds, esi + 4]);             /* mov al, [esi+0x4] */
            ii(0x1018_ea75, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_ea78, 3); mov(memb[ds, edx + 0x32], bl);          /* mov [edx+0x32], bl */
            ii(0x1018_ea7b, 3); mov(memb[ds, edx + 0x38], bh);          /* mov [edx+0x38], bh */
            ii(0x1018_ea7e, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_ea81, 3); mov(memb[ds, edx + 0x3d], bl);          /* mov [edx+0x3d], bl */
            ii(0x1018_ea84, 3); mov(memb[ds, edx + 0x43], bh);          /* mov [edx+0x43], bh */
            ii(0x1018_ea87, 3); mov(al, memb[ds, esi + 5]);             /* mov al, [esi+0x5] */
            ii(0x1018_ea8a, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_ea8d, 3); mov(memb[ds, edx + 0x4b], bl);          /* mov [edx+0x4b], bl */
            ii(0x1018_ea90, 3); mov(memb[ds, edx + 0x51], bh);          /* mov [edx+0x51], bh */
            ii(0x1018_ea93, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_ea96, 3); mov(memb[ds, edx + 0x56], bl);          /* mov [edx+0x56], bl */
            ii(0x1018_ea99, 3); mov(memb[ds, edx + 0x5c], bh);          /* mov [edx+0x5c], bh */
            ii(0x1018_ea9c, 3); lea(edx, memd[ds, edx + 0x64]);         /* lea edx, [edx+0x64] */
            ii(0x1018_ea9f, 3); mov(al, memb[ds, esi + 6]);             /* mov al, [esi+0x6] */
            ii(0x1018_eaa2, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_eaa5, 2); mov(memb[ds, edx], bl);                 /* mov [edx], bl */
            ii(0x1018_eaa7, 3); mov(memb[ds, edx + 6], bh);             /* mov [edx+0x6], bh */
            ii(0x1018_eaaa, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_eaad, 3); mov(memb[ds, edx + 0xb], bl);           /* mov [edx+0xb], bl */
            ii(0x1018_eab0, 3); mov(memb[ds, edx + 0x11], bh);          /* mov [edx+0x11], bh */
            ii(0x1018_eab3, 3); mov(al, memb[ds, esi + 7]);             /* mov al, [esi+0x7] */
            ii(0x1018_eab6, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_eab9, 3); mov(memb[ds, edx + 0x19], bl);          /* mov [edx+0x19], bl */
            ii(0x1018_eabc, 3); mov(memb[ds, edx + 0x1f], bh);          /* mov [edx+0x1f], bh */
            ii(0x1018_eabf, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_eac2, 3); mov(memb[ds, edx + 0x24], bl);          /* mov [edx+0x24], bl */
            ii(0x1018_eac5, 3); mov(memb[ds, edx + 0x2a], bh);          /* mov [edx+0x2a], bh */
            ii(0x1018_eac8, 3); mov(al, memb[ds, esi + 8]);             /* mov al, [esi+0x8] */
            ii(0x1018_eacb, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_eace, 3); mov(memb[ds, edx + 0x32], bl);          /* mov [edx+0x32], bl */
            ii(0x1018_ead1, 3); mov(memb[ds, edx + 0x38], bh);          /* mov [edx+0x38], bh */
            ii(0x1018_ead4, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_ead7, 3); mov(memb[ds, edx + 0x3d], bl);          /* mov [edx+0x3d], bl */
            ii(0x1018_eada, 3); mov(memb[ds, edx + 0x43], bh);          /* mov [edx+0x43], bh */
            ii(0x1018_eadd, 3); mov(al, memb[ds, esi + 9]);             /* mov al, [esi+0x9] */
            ii(0x1018_eae0, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_eae3, 3); mov(memb[ds, edx + 0x4b], bl);          /* mov [edx+0x4b], bl */
            ii(0x1018_eae6, 3); mov(memb[ds, edx + 0x51], bh);          /* mov [edx+0x51], bh */
            ii(0x1018_eae9, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_eaec, 3); mov(memb[ds, edx + 0x56], bl);          /* mov [edx+0x56], bl */
            ii(0x1018_eaef, 3); mov(memb[ds, edx + 0x5c], bh);          /* mov [edx+0x5c], bh */
            ii(0x1018_eaf2, 1); push(ebp);                              /* push ebp */
            ii(0x1018_eaf3, 1); push(esi);                              /* push esi */
            ii(0x1018_eaf4, 3); mov(cx, memw[ds, esi]);                 /* mov cx, [esi] */
            ii(0x1018_eaf7, 6); mov(esi, memd[ds, 0x1020_9cd0]);        /* mov esi, [0x10209cd0] */
            ii(0x1018_eafd, 2); mov(bl, cl);                            /* mov bl, cl */
            ii(0x1018_eaff, 2); mov(bh, cl);                            /* mov bh, cl */
            ii(0x1018_eb01, 2); mov(dl, ch);                            /* mov dl, ch */
            ii(0x1018_eb03, 2); mov(dh, cl);                            /* mov dh, cl */
            ii(0x1018_eb05, 2); mov(al, ch);                            /* mov al, ch */
            ii(0x1018_eb07, 2); mov(ah, ch);                            /* mov ah, ch */
            ii(0x1018_eb09, 2); mov(ebp, eax);                          /* mov ebp, eax */
            ii(0x1018_eb0b, 2); if(jmp_func(0x1018_eb10, 3)) return;    /* jmp 0x1018eb10 */
        }
    }
}
