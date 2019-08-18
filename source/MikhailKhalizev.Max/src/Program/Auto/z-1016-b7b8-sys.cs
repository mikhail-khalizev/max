using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_b7b8-c20a38ad")]
        public void /* sys */ Method_1016_b7b8()
        {
            ii(0x1016_b7b8, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_b7b9, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_b7ba, 1); pushd(edx);                             /* push edx */
            ii(0x1016_b7bb, 3); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1016_b7be, 7); cmp(memd_a32[ds, 0x101c_fb60], 0);      /* cmp dword [0x101cfb60], 0x0 */
            ii(0x1016_b7c5, 2); if(jzd(0x1016_b7e7, 0x20)) goto l_0x1016_b7e7; /* jz 0x1016b7e7 */
        l_0x1016_b7c7:
            ii(0x1016_b7c7, 5); calld(/* sys */ 0x1018_7105, 0x1_b939); /* call 0x10187105 */
            ii(0x1016_b7cc, 6); mov(ecx, memd_a32[ds, 0x101b_de18]);    /* mov ecx, [0x101bde18] */
            ii(0x1016_b7d2, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1016_b7d4, 2); cmp(eax, ecx);                          /* cmp eax, ecx */
            ii(0x1016_b7d6, 2); if(jaed(0x1016_b7df, 0x7)) goto l_0x1016_b7df; /* jae 0x1016b7df */
            ii(0x1016_b7d8, 3); lea(edx, ecx - 0x38);                   /* lea edx, [ecx-0x38] */
            ii(0x1016_b7db, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1016_b7dd, 2); if(jad(0x1016_b7c7, -0x18)) goto l_0x1016_b7c7; /* ja 0x1016b7c7 */
        l_0x1016_b7df:
            ii(0x1016_b7df, 6); mov(memd_a32[ds, 0x101b_de18], ebx);    /* mov [0x101bde18], ebx */
            ii(0x1016_b7e5, 2); jmpd(0x1016_b81c, 0x35); goto l_0x1016_b81c; /* jmp 0x1016b81c */
        l_0x1016_b7e7:
            ii(0x1016_b7e7, 2); mov(ebx, esp);                          /* mov ebx, esp */
            ii(0x1016_b7e9, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1016_b7eb, 2); mov(edx, esp);                          /* mov edx, esp */
            ii(0x1016_b7ed, 4); mov(memb_a32[ss, esp + 0x1], ah);       /* mov [esp+0x1], ah */
            ii(0x1016_b7f1, 5); mov(eax, 0x1a);                         /* mov eax, 0x1a */
            ii(0x1016_b7f6, 5); calld(/* sys */ 0x1016_c606, 0xe0b);    /* call 0x1016c606 */
            ii(0x1016_b7fb, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_b7fd, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_b7ff, 5); mov(bx, memw_a32[ss, esp + 0x8]);       /* mov bx, [esp+0x8] */
            ii(0x1016_b804, 5); mov(ax, memw_a32[ss, esp + 0xc]);       /* mov ax, [esp+0xc] */
            ii(0x1016_b809, 3); shl(ebx, 0x10);                         /* shl ebx, 0x10 */
            ii(0x1016_b80c, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1016_b80e, 7); lea(ebx, eax * 8 + 0);                  /* lea ebx, [eax*8] */
            ii(0x1016_b815, 2); sub(ebx, eax);                          /* sub ebx, eax */
            ii(0x1016_b817, 3); shl(ebx, 0x3);                          /* shl ebx, 0x3 */
            ii(0x1016_b81a, 2); sub(ebx, eax);                          /* sub ebx, eax */
        l_0x1016_b81c:
            ii(0x1016_b81c, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_b81e, 3); add(esp, 0x1c);                         /* add esp, 0x1c */
            ii(0x1016_b821, 1); popd(edx);                              /* pop edx */
            ii(0x1016_b822, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_b823, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_b824, 1); retd(); return;                         /* ret */
        }
    }
}
