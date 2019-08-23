using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_ece8-edbe6e9b")]
        public void /* sys */ mve_2()
        {
            ii(0x1018_ece8, 3); mov(ax, memw[ds, esi]);                 /* mov ax, [esi] */
            ii(0x1018_eceb, 2); cmp(al, ah);                            /* cmp al, ah */
            ii(0x1018_eced, 6); if(ja_func(0x1018_eeec, 0x1f9)) return; /* ja 0x1018eeec */
            ii(0x1018_ecf3, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_ecf5, 6); lea(ecx, memd[ds, 0x101b_f110]);        /* lea ecx, [0x101bf110] */
            ii(0x1018_ecfb, 6); lea(edx, memd[ds, /* sys_mve */ 0x1018_edca]); /* lea edx, [0x1018edca] */
            ii(0x1018_ed01, 3); mov(al, memb[ds, esi + 0x2]);           /* mov al, [esi+0x2] */
            ii(0x1018_ed04, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_ed07, 2); mov(memb[ds, edx], bl);                 /* mov [edx], bl */
            ii(0x1018_ed09, 3); mov(memb[ds, edx + 0x6], bh);           /* mov [edx+0x6], bh */
            ii(0x1018_ed0c, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_ed0f, 3); mov(memb[ds, edx + 0xd], bl);           /* mov [edx+0xd], bl */
            ii(0x1018_ed12, 3); mov(memb[ds, edx + 0x13], bh);          /* mov [edx+0x13], bh */
            ii(0x1018_ed15, 3); mov(al, memb[ds, esi + 0x3]);           /* mov al, [esi+0x3] */
            ii(0x1018_ed18, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_ed1b, 3); mov(memb[ds, edx + 0x1a], bl);          /* mov [edx+0x1a], bl */
            ii(0x1018_ed1e, 3); mov(memb[ds, edx + 0x20], bh);          /* mov [edx+0x20], bh */
            ii(0x1018_ed21, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_ed24, 3); mov(memb[ds, edx + 0x27], bl);          /* mov [edx+0x27], bl */
            ii(0x1018_ed27, 3); mov(memb[ds, edx + 0x2d], bh);          /* mov [edx+0x2d], bh */
            ii(0x1018_ed2a, 3); mov(al, memb[ds, esi + 0x6]);           /* mov al, [esi+0x6] */
            ii(0x1018_ed2d, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_ed30, 3); mov(memb[ds, edx + 0x49], bl);          /* mov [edx+0x49], bl */
            ii(0x1018_ed33, 3); mov(memb[ds, edx + 0x4f], bh);          /* mov [edx+0x4f], bh */
            ii(0x1018_ed36, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_ed39, 3); mov(memb[ds, edx + 0x56], bl);          /* mov [edx+0x56], bl */
            ii(0x1018_ed3c, 3); mov(memb[ds, edx + 0x5c], bh);          /* mov [edx+0x5c], bh */
            ii(0x1018_ed3f, 3); mov(al, memb[ds, esi + 0x7]);           /* mov al, [esi+0x7] */
            ii(0x1018_ed42, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_ed45, 3); mov(memb[ds, edx + 0x63], bl);          /* mov [edx+0x63], bl */
            ii(0x1018_ed48, 3); mov(memb[ds, edx + 0x69], bh);          /* mov [edx+0x69], bh */
            ii(0x1018_ed4b, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_ed4e, 3); mov(memb[ds, edx + 0x70], bl);          /* mov [edx+0x70], bl */
            ii(0x1018_ed51, 3); mov(memb[ds, edx + 0x76], bh);          /* mov [edx+0x76], bh */
            ii(0x1018_ed54, 6); add(edx, 0x9b);                         /* add edx, 0x9b */
            ii(0x1018_ed5a, 3); mov(al, memb[ds, esi + 0xa]);           /* mov al, [esi+0xa] */
            ii(0x1018_ed5d, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_ed60, 2); mov(memb[ds, edx], bl);                 /* mov [edx], bl */
            ii(0x1018_ed62, 3); mov(memb[ds, edx + 0x6], bh);           /* mov [edx+0x6], bh */
            ii(0x1018_ed65, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_ed68, 3); mov(memb[ds, edx + 0xd], bl);           /* mov [edx+0xd], bl */
            ii(0x1018_ed6b, 3); mov(memb[ds, edx + 0x13], bh);          /* mov [edx+0x13], bh */
            ii(0x1018_ed6e, 3); mov(al, memb[ds, esi + 0xb]);           /* mov al, [esi+0xb] */
            ii(0x1018_ed71, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_ed74, 3); mov(memb[ds, edx + 0x1a], bl);          /* mov [edx+0x1a], bl */
            ii(0x1018_ed77, 3); mov(memb[ds, edx + 0x20], bh);          /* mov [edx+0x20], bh */
            ii(0x1018_ed7a, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_ed7d, 3); mov(memb[ds, edx + 0x27], bl);          /* mov [edx+0x27], bl */
            ii(0x1018_ed80, 3); mov(memb[ds, edx + 0x2d], bh);          /* mov [edx+0x2d], bh */
            ii(0x1018_ed83, 3); mov(al, memb[ds, esi + 0xe]);           /* mov al, [esi+0xe] */
            ii(0x1018_ed86, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_ed89, 3); mov(memb[ds, edx + 0x49], bl);          /* mov [edx+0x49], bl */
            ii(0x1018_ed8c, 3); mov(memb[ds, edx + 0x4f], bh);          /* mov [edx+0x4f], bh */
            ii(0x1018_ed8f, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_ed92, 3); mov(memb[ds, edx + 0x56], bl);          /* mov [edx+0x56], bl */
            ii(0x1018_ed95, 3); mov(memb[ds, edx + 0x5c], bh);          /* mov [edx+0x5c], bh */
            ii(0x1018_ed98, 3); mov(al, memb[ds, esi + 0xf]);           /* mov al, [esi+0xf] */
            ii(0x1018_ed9b, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_ed9e, 3); mov(memb[ds, edx + 0x63], bl);          /* mov [edx+0x63], bl */
            ii(0x1018_eda1, 3); mov(memb[ds, edx + 0x69], bh);          /* mov [edx+0x69], bh */
            ii(0x1018_eda4, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_eda7, 3); mov(memb[ds, edx + 0x70], bl);          /* mov [edx+0x70], bl */
            ii(0x1018_edaa, 3); mov(memb[ds, edx + 0x76], bh);          /* mov [edx+0x76], bh */
            ii(0x1018_edad, 1); push(ebp);                              /* push ebp */
            ii(0x1018_edae, 1); push(esi);                              /* push esi */
            ii(0x1018_edaf, 3); mov(cx, memw[ds, esi]);                 /* mov cx, [esi] */
            ii(0x1018_edb2, 6); mov(esi, memd[ds, 0x1020_9cd0]);        /* mov esi, [0x10209cd0] */
            ii(0x1018_edb8, 2); mov(bl, cl);                            /* mov bl, cl */
            ii(0x1018_edba, 2); mov(bh, cl);                            /* mov bh, cl */
            ii(0x1018_edbc, 2); mov(dl, ch);                            /* mov dl, ch */
            ii(0x1018_edbe, 2); mov(dh, cl);                            /* mov dh, cl */
            ii(0x1018_edc0, 2); mov(al, ch);                            /* mov al, ch */
            ii(0x1018_edc2, 2); mov(ah, ch);                            /* mov ah, ch */
            ii(0x1018_edc4, 2); mov(ebp, eax);                          /* mov ebp, eax */
            ii(0x1018_edc6, 2); if(jmp_func(0x1018_edc8, 0)) return;    /* jmp 0x1018edc8 */
        }
    }
}
