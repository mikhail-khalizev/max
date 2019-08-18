using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d812a02b-3e70-4995-99b4-85c3badcbdc0")]
        public void /* sys */ Method_1019_3d49()
        {
            ii(0x1019_3d49, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_3d4a, 1); pushd(esi);                             /* push esi */
            ii(0x1019_3d4b, 3); mov(ecx, memd_a32[ss, ebp + 0x18]);     /* mov ecx, [ebp+0x18] */
            ii(0x1019_3d4e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_3d4f, 1); pushd(edx);                             /* push edx */
            ii(0x1019_3d50, 5); mov(eax, memd_a32[ds, Definitions.video_bytes_per_line]); /* mov eax, [0x10209c98] */
            ii(0x1019_3d55, 3); mul(memd_a32[ss, ebp + 0x24]);          /* mul dword [ebp+0x24] */
            ii(0x1019_3d58, 3); add(eax, memd_a32[ss, ebp + 0x20]);     /* add eax, [ebp+0x20] */
            ii(0x1019_3d5b, 5); mov(edx, 0);                            /* mov edx, 0x0 */
            ii(0x1019_3d60, 6); div(memd_a32[ds, Definitions.video_win_granularity]); /* div dword [0x10209ca4] */
            ii(0x1019_3d66, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1019_3d69, 2); mov(edi, edx);                          /* mov edi, edx */
            ii(0x1019_3d6b, 6); add(edi, memd_a32[ds, Definitions.video_win_start]); /* add edi, [0x10209ca8] */
            ii(0x1019_3d71, 7); cmp(memd_a32[ds, 0x1020_9c90], 0);      /* cmp dword [0x10209c90], 0x0 */
            ii(0x1019_3d78, 2); if(jzd(0x1019_3d8b, 0x11)) goto l_0x1019_3d8b; /* jz 0x10193d8b */
            ii(0x1019_3d7a, 2); mov(bh, 0);                             /* mov bh, 0x0 */
            ii(0x1019_3d7c, 6); mov(bl, memb_a32[ds, 0x1020_9cb0]);     /* mov bl, [0x10209cb0] */
            ii(0x1019_3d82, 3); mov(edx, memd_a32[ss, ebp - 0x28]);     /* mov edx, [ebp-0x28] */
            ii(0x1019_3d85, 6); calld_abs(memd_a32[ds, 0x1020_9c90]);   /* call dword [0x10209c90] */
        l_0x1019_3d8b:
            ii(0x1019_3d8b, 1); popd(edx);                              /* pop edx */
            ii(0x1019_3d8c, 1); popd(ebx);                              /* pop ebx */
        }
    }
}
