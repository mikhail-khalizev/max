using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7ca496ef-448e-4c31-b511-efacffccbb67")]
        public void /* sys */ Method_1017_a590()
        {
            ii(0x1017_a590, 1); pushd(ebp);                             /* push ebp */
            ii(0x1017_a591, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_a593, 1); pushd(edi);                             /* push edi */
            ii(0x1017_a594, 5); mov(memd_a32[ds, 0x1020_9cb4], eax);    /* mov [0x10209cb4], eax */
            ii(0x1017_a599, 6); mov(memd_a32[ds, 0x1020_9cbc], edx);    /* mov [0x10209cbc], edx */
            ii(0x1017_a59f, 6); mov(memd_a32[ds, 0x1020_9cb8], ebx);    /* mov [0x10209cb8], ebx */
            ii(0x1017_a5a5, 6); mov(memd_a32[ds, 0x1020_9cc0], ecx);    /* mov [0x10209cc0], ecx */
            ii(0x1017_a5ab, 6); mov(dl, memb_a32[ds, 0x101b_e200]);     /* mov dl, [0x101be200] */
            ii(0x1017_a5b1, 5); mov(memd_a32[ds, Definitions.video_bytes_per_line], eax); /* mov [0x10209c98], eax */
            ii(0x1017_a5b6, 3); test(dl, 0x4);                          /* test dl, 0x4 */
            ii(0x1017_a5b9, 2); if(jzd(0x1017_a5c2, 0x7)) goto l_0x1017_a5c2; /* jz 0x1017a5c2 */
            ii(0x1017_a5bb, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1017_a5bd, 5); mov(memd_a32[ds, Definitions.video_bytes_per_line], eax); /* mov [0x10209c98], eax */
        l_0x1017_a5c2:
            ii(0x1017_a5c2, 5); mov(ecx, 0x1_0000);                     /* mov ecx, 0x10000 */
            ii(0x1017_a5c7, 5); mov(eax, 0xa000_0000);                  /* mov eax, 0xa0000000 */
            ii(0x1017_a5cc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_a5ce, 5); mov(edi, 0x1);                          /* mov edi, 0x1 */
            ii(0x1017_a5d3, 6); mov(memd_a32[ds, 0x1020_9c90], edx);    /* mov [0x10209c90], edx */
            ii(0x1017_a5d9, 6); mov(memd_a32[ds, 0x101b_e448], edx);    /* mov [0x101be448], edx */
            ii(0x1017_a5df, 6); mov(memd_a32[ds, Definitions.video_win_len], ecx); /* mov [0x10209ca0], ecx */
            ii(0x1017_a5e5, 5); calld(/* sys */ 0x1019_43d0, 0x1_9de6); /* call 0x101943d0 */
            ii(0x1017_a5ea, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_a5ec, 5); mov(memd_a32[ds, Definitions.video_win_start], eax); /* mov [0x10209ca8], eax */
            ii(0x1017_a5f1, 6); mov(memd_a32[ds, Definitions.video_win_granularity], ecx); /* mov [0x10209ca4], ecx */
            ii(0x1017_a5f7, 5); mov(eax, memd_a32[ds, Definitions.video_win_len]); /* mov eax, [0x10209ca0] */
            ii(0x1017_a5fc, 6); mov(memd_a32[ds, Definitions.video_bank_count_in_win], edi); /* mov [0x10209c9c], edi */
            ii(0x1017_a602, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1017_a604, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_a606, 6); mov(memd_a32[ds, Definitions.video_win_end], edx); /* mov [0x10209cac], edx */
            ii(0x1017_a60c, 5); mov(memd_a32[ds, 0x1020_9c94], eax);    /* mov [0x10209c94], eax */
            ii(0x1017_a611, 3); lea(esp, ebp - 0x4);                    /* lea esp, [ebp-0x4] */
            ii(0x1017_a614, 1); popd(edi);                              /* pop edi */
            ii(0x1017_a615, 1); popd(ebp);                              /* pop ebp */
            ii(0x1017_a616, 1); retd(); return;                         /* ret */
        }
    }
}
