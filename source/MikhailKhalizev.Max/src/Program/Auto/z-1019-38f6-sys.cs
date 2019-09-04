using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_38f6-2d4622b8")]
        public void /* sys */ Method_1019_38f6()
        {
            ii(0x1019_38f6, 1);  push(ecx);                            /* push ecx */
            ii(0x1019_38f7, 1);  push(esi);                            /* push esi */
            ii(0x1019_38f8, 3);  mov(ecx, memd[ss, ebp + 24]);         /* mov ecx, [ebp+0x18] */
            ii(0x1019_38fb, 1);  push(ebx);                            /* push ebx */
            ii(0x1019_38fc, 1);  push(edx);                            /* push edx */
            ii(0x1019_38fd, 5);  mov(eax, memd[ds, Definitions.video_bytes_per_line]);/* mov eax, [0x10209c98] */
            ii(0x1019_3902, 3);  mul(memd[ss, ebp + 36]);              /* mul dword [ebp+0x24] */
            ii(0x1019_3905, 3);  add(eax, memd[ss, ebp + 32]);         /* add eax, [ebp+0x20] */
            ii(0x1019_3908, 5);  mov(edx, 0);                          /* mov edx, 0x0 */
            ii(0x1019_390d, 6);  div(memd[ds, Definitions.video_win_granularity]);/* div dword [0x10209ca4] */
            ii(0x1019_3913, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x1019_3916, 2);  mov(edi, edx);                        /* mov edi, edx */
            ii(0x1019_3918, 6);  add(edi, memd[ds, Definitions.video_win_start]);/* add edi, [0x10209ca8] */
            ii(0x1019_391e, 7);  cmp(memd[ds, 0x1020_9c90], 0);        /* cmp dword [0x10209c90], 0x0 */
            ii(0x1019_3925, 2);  if(jz(0x1019_3938, 0x11)) goto l_0x1019_3938;/* jz 0x10193938 */
            ii(0x1019_3927, 2);  mov(bh, 0);                           /* mov bh, 0x0 */
            ii(0x1019_3929, 6);  mov(bl, memb[ds, 0x1020_9cb0]);       /* mov bl, [0x10209cb0] */
            ii(0x1019_392f, 3);  mov(edx, memd[ss, ebp - 40]);         /* mov edx, [ebp-0x28] */
            ii(0x1019_3932, 6);  call_abs(memd[ds, 0x1020_9c90]);      /* call dword [0x10209c90] */
        l_0x1019_3938:
            ii(0x1019_3938, 1);  pop(edx);                             /* pop edx */
            ii(0x1019_3939, 1);  pop(ebx);                             /* pop ebx */
        }
    }
}
