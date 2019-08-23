using MikhailKhalizev.Max.Dos;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        private bool mve_4_intro;

        [MethodInfo("0x1018_f938-ee784a23")]
        public void /* sys */ mve_4()
        {
            if (!mve_4_intro)
            {
                mve_4_intro = true;
                // Выход из вступительного видео.
                RawProgramMain.DosPort.key_pressed = DosPort.kbd_keys.esc;
                RawProgramMain.DosPic.activate_irq(1);
            }

            ii(0x1018_f938, 3); mov(ax, memw[ds, esi]);                 /* mov ax, [esi] */
            ii(0x1018_f93b, 2); cmp(al, ah);                            /* cmp al, ah */
            ii(0x1018_f93d, 6); if(ja_func(0x1018_fbd0, 0x28d)) return; /* ja 0x1018fbd0 */
            ii(0x1018_f943, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_f945, 6); lea(ecx, memd[ds, 0x101b_f510]);        /* lea ecx, [0x101bf510] */
            ii(0x1018_f94b, 6); lea(edx, memd[ds, /* sys_mve */ 0x1018_fab5]); /* lea edx, [0x1018fab5] */
            ii(0x1018_f951, 3); mov(al, memb[ds, esi + 0x4]);           /* mov al, [esi+0x4] */
            ii(0x1018_f954, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f957, 2); mov(memb[ds, edx], bl);                 /* mov [edx], bl */
            ii(0x1018_f959, 3); mov(memb[ds, edx + 0x2], bh);           /* mov [edx+0x2], bh */
            ii(0x1018_f95c, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_f95f, 3); mov(memb[ds, edx + 0x7], bl);           /* mov [edx+0x7], bl */
            ii(0x1018_f962, 3); mov(memb[ds, edx + 0x9], bh);           /* mov [edx+0x9], bh */
            ii(0x1018_f965, 3); mov(al, memb[ds, esi + 0x5]);           /* mov al, [esi+0x5] */
            ii(0x1018_f968, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f96b, 3); mov(memb[ds, edx + 0xf], bl);           /* mov [edx+0xf], bl */
            ii(0x1018_f96e, 3); mov(memb[ds, edx + 0x11], bh);          /* mov [edx+0x11], bh */
            ii(0x1018_f971, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_f974, 3); mov(memb[ds, edx + 0x16], bl);          /* mov [edx+0x16], bl */
            ii(0x1018_f977, 3); mov(memb[ds, edx + 0x18], bh);          /* mov [edx+0x18], bh */
            ii(0x1018_f97a, 3); mov(al, memb[ds, esi + 0x6]);           /* mov al, [esi+0x6] */
            ii(0x1018_f97d, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f980, 3); mov(memb[ds, edx + 0x1e], bl);          /* mov [edx+0x1e], bl */
            ii(0x1018_f983, 3); mov(memb[ds, edx + 0x20], bh);          /* mov [edx+0x20], bh */
            ii(0x1018_f986, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_f989, 3); mov(memb[ds, edx + 0x25], bl);          /* mov [edx+0x25], bl */
            ii(0x1018_f98c, 3); mov(memb[ds, edx + 0x27], bh);          /* mov [edx+0x27], bh */
            ii(0x1018_f98f, 3); mov(al, memb[ds, esi + 0x7]);           /* mov al, [esi+0x7] */
            ii(0x1018_f992, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f995, 3); mov(memb[ds, edx + 0x2d], bl);          /* mov [edx+0x2d], bl */
            ii(0x1018_f998, 3); mov(memb[ds, edx + 0x2f], bh);          /* mov [edx+0x2f], bh */
            ii(0x1018_f99b, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_f99e, 3); mov(memb[ds, edx + 0x34], bl);          /* mov [edx+0x34], bl */
            ii(0x1018_f9a1, 3); mov(memb[ds, edx + 0x36], bh);          /* mov [edx+0x36], bh */
            ii(0x1018_f9a4, 3); mov(al, memb[ds, esi + 0xc]);           /* mov al, [esi+0xc] */
            ii(0x1018_f9a7, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f9aa, 3); mov(memb[ds, edx + 0x44], bl);          /* mov [edx+0x44], bl */
            ii(0x1018_f9ad, 3); mov(memb[ds, edx + 0x46], bh);          /* mov [edx+0x46], bh */
            ii(0x1018_f9b0, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_f9b3, 3); mov(memb[ds, edx + 0x4b], bl);          /* mov [edx+0x4b], bl */
            ii(0x1018_f9b6, 3); mov(memb[ds, edx + 0x4d], bh);          /* mov [edx+0x4d], bh */
            ii(0x1018_f9b9, 3); mov(al, memb[ds, esi + 0xd]);           /* mov al, [esi+0xd] */
            ii(0x1018_f9bc, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f9bf, 3); mov(memb[ds, edx + 0x53], bl);          /* mov [edx+0x53], bl */
            ii(0x1018_f9c2, 3); mov(memb[ds, edx + 0x55], bh);          /* mov [edx+0x55], bh */
            ii(0x1018_f9c5, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_f9c8, 3); mov(memb[ds, edx + 0x5a], bl);          /* mov [edx+0x5a], bl */
            ii(0x1018_f9cb, 3); mov(memb[ds, edx + 0x5c], bh);          /* mov [edx+0x5c], bh */
            ii(0x1018_f9ce, 3); mov(al, memb[ds, esi + 0xe]);           /* mov al, [esi+0xe] */
            ii(0x1018_f9d1, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f9d4, 3); mov(memb[ds, edx + 0x62], bl);          /* mov [edx+0x62], bl */
            ii(0x1018_f9d7, 3); mov(memb[ds, edx + 0x64], bh);          /* mov [edx+0x64], bh */
            ii(0x1018_f9da, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_f9dd, 3); mov(memb[ds, edx + 0x69], bl);          /* mov [edx+0x69], bl */
            ii(0x1018_f9e0, 3); mov(memb[ds, edx + 0x6b], bh);          /* mov [edx+0x6b], bh */
            ii(0x1018_f9e3, 3); mov(al, memb[ds, esi + 0xf]);           /* mov al, [esi+0xf] */
            ii(0x1018_f9e6, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_f9e9, 3); mov(memb[ds, edx + 0x71], bl);          /* mov [edx+0x71], bl */
            ii(0x1018_f9ec, 3); mov(memb[ds, edx + 0x73], bh);          /* mov [edx+0x73], bh */
            ii(0x1018_f9ef, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_f9f2, 3); mov(memb[ds, edx + 0x78], bl);          /* mov [edx+0x78], bl */
            ii(0x1018_f9f5, 3); mov(memb[ds, edx + 0x7a], bh);          /* mov [edx+0x7a], bh */
            ii(0x1018_f9f8, 6); lea(edx, memd[ds, edx + 0x91]);         /* lea edx, [edx+0x91] */
            ii(0x1018_f9fe, 3); mov(al, memb[ds, esi + 0x14]);          /* mov al, [esi+0x14] */
            ii(0x1018_fa01, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_fa04, 2); mov(memb[ds, edx], bl);                 /* mov [edx], bl */
            ii(0x1018_fa06, 3); mov(memb[ds, edx + 0x2], bh);           /* mov [edx+0x2], bh */
            ii(0x1018_fa09, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_fa0c, 3); mov(memb[ds, edx + 0x7], bl);           /* mov [edx+0x7], bl */
            ii(0x1018_fa0f, 3); mov(memb[ds, edx + 0x9], bh);           /* mov [edx+0x9], bh */
            ii(0x1018_fa12, 3); mov(al, memb[ds, esi + 0x15]);          /* mov al, [esi+0x15] */
            ii(0x1018_fa15, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_fa18, 3); mov(memb[ds, edx + 0xf], bl);           /* mov [edx+0xf], bl */
            ii(0x1018_fa1b, 3); mov(memb[ds, edx + 0x11], bh);          /* mov [edx+0x11], bh */
            ii(0x1018_fa1e, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_fa21, 3); mov(memb[ds, edx + 0x16], bl);          /* mov [edx+0x16], bl */
            ii(0x1018_fa24, 3); mov(memb[ds, edx + 0x18], bh);          /* mov [edx+0x18], bh */
            ii(0x1018_fa27, 3); mov(al, memb[ds, esi + 0x16]);          /* mov al, [esi+0x16] */
            ii(0x1018_fa2a, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_fa2d, 3); mov(memb[ds, edx + 0x1e], bl);          /* mov [edx+0x1e], bl */
            ii(0x1018_fa30, 3); mov(memb[ds, edx + 0x20], bh);          /* mov [edx+0x20], bh */
            ii(0x1018_fa33, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_fa36, 3); mov(memb[ds, edx + 0x25], bl);          /* mov [edx+0x25], bl */
            ii(0x1018_fa39, 3); mov(memb[ds, edx + 0x27], bh);          /* mov [edx+0x27], bh */
            ii(0x1018_fa3c, 3); mov(al, memb[ds, esi + 0x17]);          /* mov al, [esi+0x17] */
            ii(0x1018_fa3f, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_fa42, 3); mov(memb[ds, edx + 0x2d], bl);          /* mov [edx+0x2d], bl */
            ii(0x1018_fa45, 3); mov(memb[ds, edx + 0x2f], bh);          /* mov [edx+0x2f], bh */
            ii(0x1018_fa48, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_fa4b, 3); mov(memb[ds, edx + 0x34], bl);          /* mov [edx+0x34], bl */
            ii(0x1018_fa4e, 3); mov(memb[ds, edx + 0x36], bh);          /* mov [edx+0x36], bh */
            ii(0x1018_fa51, 3); mov(al, memb[ds, esi + 0x1c]);          /* mov al, [esi+0x1c] */
            ii(0x1018_fa54, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_fa57, 3); mov(memb[ds, edx + 0x44], bl);          /* mov [edx+0x44], bl */
            ii(0x1018_fa5a, 3); mov(memb[ds, edx + 0x46], bh);          /* mov [edx+0x46], bh */
            ii(0x1018_fa5d, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_fa60, 3); mov(memb[ds, edx + 0x4b], bl);          /* mov [edx+0x4b], bl */
            ii(0x1018_fa63, 3); mov(memb[ds, edx + 0x4d], bh);          /* mov [edx+0x4d], bh */
            ii(0x1018_fa66, 3); mov(al, memb[ds, esi + 0x1d]);          /* mov al, [esi+0x1d] */
            ii(0x1018_fa69, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_fa6c, 3); mov(memb[ds, edx + 0x53], bl);          /* mov [edx+0x53], bl */
            ii(0x1018_fa6f, 3); mov(memb[ds, edx + 0x55], bh);          /* mov [edx+0x55], bh */
            ii(0x1018_fa72, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_fa75, 3); mov(memb[ds, edx + 0x5a], bl);          /* mov [edx+0x5a], bl */
            ii(0x1018_fa78, 3); mov(memb[ds, edx + 0x5c], bh);          /* mov [edx+0x5c], bh */
            ii(0x1018_fa7b, 3); mov(al, memb[ds, esi + 0x1e]);          /* mov al, [esi+0x1e] */
            ii(0x1018_fa7e, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_fa81, 3); mov(memb[ds, edx + 0x62], bl);          /* mov [edx+0x62], bl */
            ii(0x1018_fa84, 3); mov(memb[ds, edx + 0x64], bh);          /* mov [edx+0x64], bh */
            ii(0x1018_fa87, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_fa8a, 3); mov(memb[ds, edx + 0x69], bl);          /* mov [edx+0x69], bl */
            ii(0x1018_fa8d, 3); mov(memb[ds, edx + 0x6b], bh);          /* mov [edx+0x6b], bh */
            ii(0x1018_fa90, 3); mov(al, memb[ds, esi + 0x1f]);          /* mov al, [esi+0x1f] */
            ii(0x1018_fa93, 3); mov(ebx, memd[ds, ecx + eax * 4]);      /* mov ebx, [ecx+eax*4] */
            ii(0x1018_fa96, 3); mov(memb[ds, edx + 0x71], bl);          /* mov [edx+0x71], bl */
            ii(0x1018_fa99, 3); mov(memb[ds, edx + 0x73], bh);          /* mov [edx+0x73], bh */
            ii(0x1018_fa9c, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_fa9f, 3); mov(memb[ds, edx + 0x78], bl);          /* mov [edx+0x78], bl */
            ii(0x1018_faa2, 3); mov(memb[ds, edx + 0x7a], bh);          /* mov [edx+0x7a], bh */
            ii(0x1018_faa5, 3); mov(bx, memw[ds, esi]);                 /* mov bx, [esi] */
            ii(0x1018_faa8, 4); mov(cx, memw[ds, esi + 0x2]);           /* mov cx, [esi+0x2] */
            ii(0x1018_faac, 6); mov(edx, memd[ds, 0x1020_9cd0]);        /* mov edx, [0x10209cd0] */
            ii(0x1018_fab2, 2); if(jmp_func(0x1018_fab4, 0)) return;    /* jmp 0x1018fab4 */
        }
    }
}
