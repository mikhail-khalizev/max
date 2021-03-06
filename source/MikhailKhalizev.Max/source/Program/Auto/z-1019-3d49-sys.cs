using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_3d49-2d4622b8")]
        public void /* sys */ Method_1019_3d49()
        {
            ii(0x1019_3d49, 1);  push(ecx);                            /* push ecx */
            ii(0x1019_3d4a, 1);  push(esi);                            /* push esi */
            ii(0x1019_3d4b, 3);  mov(ecx, memd[ss, ebp + 24]);         /* mov ecx, [ebp+0x18] */
            ii(0x1019_3d4e, 1);  push(ebx);                            /* push ebx */
            ii(0x1019_3d4f, 1);  push(edx);                            /* push edx */
            ii(0x1019_3d50, 5);  mov(eax, memd[ds, Definitions.video_bytes_per_line]);/* mov eax, [0x10209c98] */
            ii(0x1019_3d55, 3);  mul(memd[ss, ebp + 36]);              /* mul dword [ebp+0x24] */
            ii(0x1019_3d58, 3);  add(eax, memd[ss, ebp + 32]);         /* add eax, [ebp+0x20] */
            ii(0x1019_3d5b, 5);  mov(edx, 0);                          /* mov edx, 0x0 */
            ii(0x1019_3d60, 6);  div(memd[ds, Definitions.video_win_granularity]);/* div dword [0x10209ca4] */
            ii(0x1019_3d66, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x1019_3d69, 2);  mov(edi, edx);                        /* mov edi, edx */
            ii(0x1019_3d6b, 6);  add(edi, memd[ds, Definitions.video_win_start]);/* add edi, [0x10209ca8] */
            ii(0x1019_3d71, 7);  cmp(memd[ds, 0x1020_9c90], 0);        /* cmp dword [0x10209c90], 0x0 */
            ii(0x1019_3d78, 2);  if(jz(0x1019_3d8b, 0x11)) goto l_0x1019_3d8b;/* jz 0x10193d8b */
            ii(0x1019_3d7a, 2);  mov(bh, 0);                           /* mov bh, 0x0 */
            ii(0x1019_3d7c, 6);  mov(bl, memb[ds, 0x1020_9cb0]);       /* mov bl, [0x10209cb0] */
            ii(0x1019_3d82, 3);  mov(edx, memd[ss, ebp - 40]);         /* mov edx, [ebp-0x28] */
            ii(0x1019_3d85, 6);  call_abs(memd[ds, 0x1020_9c90]);      /* call dword [0x10209c90] */
        l_0x1019_3d8b:
            ii(0x1019_3d8b, 1);  pop(edx);                             /* pop edx */
            ii(0x1019_3d8c, 1);  pop(ebx);                             /* pop ebx */
        }
    }
}
