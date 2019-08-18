using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_a620-f7f943ac")]
        public void /* sys */ Method_1017_a620()
        {
            ii(0x1017_a620, 1); pushd(ebp);                             /* push ebp */
            ii(0x1017_a621, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_a623, 3); mov(ecx, memd_a32[ss, ebp + 0x8]);      /* mov ecx, [ebp+0x8] */
            ii(0x1017_a626, 3); mov(edx, memd_a32[ss, ebp + 0xc]);      /* mov edx, [ebp+0xc] */
            ii(0x1017_a629, 3); mov(eax, memd_a32[ss, ebp + 0x1c]);     /* mov eax, [ebp+0x1c] */
            ii(0x1017_a62c, 3); mov(ebx, memd_a32[ss, ebp + 0x20]);     /* mov ebx, [ebp+0x20] */
            ii(0x1017_a62f, 6); mov(memd_a32[ds, 0x1020_9cb4], ecx);    /* mov [0x10209cb4], ecx */
            ii(0x1017_a635, 6); mov(memd_a32[ds, 0x1020_9cbc], edx);    /* mov [0x10209cbc], edx */
            ii(0x1017_a63b, 6); mov(memd_a32[ds, 0x1020_9cb8], ecx);    /* mov [0x10209cb8], ecx */
            ii(0x1017_a641, 6); mov(memd_a32[ds, 0x1020_9cc0], edx);    /* mov [0x10209cc0], edx */
            ii(0x1017_a647, 6); mov(dl, memb_a32[ds, 0x101b_e200]);     /* mov dl, [0x101be200] */
            ii(0x1017_a64d, 3); mov(ecx, memd_a32[ss, ebp + 0x10]);     /* mov ecx, [ebp+0x10] */
            ii(0x1017_a650, 3); test(dl, 0x4);                          /* test dl, 0x4 */
            ii(0x1017_a653, 2); if(jzd(0x1017_a657, 0x2)) goto l_0x1017_a657; /* jz 0x1017a657 */
            ii(0x1017_a655, 2); add(ecx, ecx);                          /* add ecx, ecx */
        l_0x1017_a657:
            ii(0x1017_a657, 3); mov(edx, memd_a32[ss, ebp + 0x14]);     /* mov edx, [ebp+0x14] */
            ii(0x1017_a65a, 6); mov(memd_a32[ds, 0x1020_9cb0], edx);    /* mov [0x10209cb0], edx */
            ii(0x1017_a660, 3); mov(edx, memd_a32[ss, ebp + 0x18]);     /* mov edx, [ebp+0x18] */
            ii(0x1017_a663, 6); mov(memd_a32[ds, Definitions.video_win_start], edx); /* mov [0x10209ca8], edx */
            ii(0x1017_a669, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1017_a66b, 5); mov(memd_a32[ds, Definitions.video_win_len], eax); /* mov [0x10209ca0], eax */
            ii(0x1017_a670, 6); mov(memd_a32[ds, Definitions.video_win_end], edx); /* mov [0x10209cac], edx */
            ii(0x1017_a676, 3); mov(edx, memd_a32[ss, ebp + 0x24]);     /* mov edx, [ebp+0x24] */
            ii(0x1017_a679, 6); mov(memd_a32[ds, Definitions.video_win_granularity], ebx); /* mov [0x10209ca4], ebx */
            ii(0x1017_a67f, 6); mov(memd_a32[ds, 0x1020_9c90], edx);    /* mov [0x10209c90], edx */
            ii(0x1017_a685, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1017_a687, 2); if(jzd(0x1017_a691, 0x8)) goto l_0x1017_a691; /* jz 0x1017a691 */
            ii(0x1017_a689, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_a68b, 2); div(ebx);                               /* div ebx */
            ii(0x1017_a68d, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_a68f, 2); jmpd(0x1017_a696, 0x5); goto l_0x1017_a696; /* jmp 0x1017a696 */
        l_0x1017_a691:
            ii(0x1017_a691, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
        l_0x1017_a696:
            ii(0x1017_a696, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_a698, 3); mov(eax, memd_a32[ss, ebp + 0x28]);     /* mov eax, [ebp+0x28] */
            ii(0x1017_a69b, 6); mov(memd_a32[ds, 0x101b_e448], edx);    /* mov [0x101be448], edx */
            ii(0x1017_a6a1, 5); mov(memd_a32[ds, 0x1020_9c94], eax);    /* mov [0x10209c94], eax */
            ii(0x1017_a6a6, 6); mov(memd_a32[ds, Definitions.video_bytes_per_line], ecx); /* mov [0x10209c98], ecx */
            ii(0x1017_a6ac, 6); mov(memd_a32[ds, Definitions.video_bank_count_in_win], ebx); /* mov [0x10209c9c], ebx */
            ii(0x1017_a6b2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1017_a6b4, 1); popd(ebp);                              /* pop ebp */
            ii(0x1017_a6b5, 1); retd(); return;                         /* ret */
        }
    }
}
