using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_e1e8-2fa46b80")]
        public void /* sys */ Method_1016_e1e8()
        {
            ii(0x1016_e1e8, 1);  push(ebx);                            /* push ebx */
            ii(0x1016_e1e9, 1);  push(edx);                            /* push edx */
            ii(0x1016_e1ea, 6);  mov(edx, memd[ds, 0x101b_dea4]);      /* mov edx, [0x101bdea4] */
            ii(0x1016_e1f0, 2);  test(edx, edx);                       /* test edx, edx */
            ii(0x1016_e1f2, 2);  if(jz(0x1016_e1fc, 8)) goto l_0x1016_e1fc;/* jz 0x1016e1fc */
            ii(0x1016_e1f4, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1016_e1f9, 1);  pop(edx);                             /* pop edx */
            ii(0x1016_e1fa, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1016_e1fb, 1);  ret(); return;                        /* ret */
        l_0x1016_e1fc:
            ii(0x1016_e1fc, 5);  push(0x3ff0_0000);                    /* push 0x3ff00000 */
            ii(0x1016_e201, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x1016_e206, 1);  push(edx);                            /* push edx */
            ii(0x1016_e207, 6);  mov(memd[ds, 0x101b_dea4], ebx);      /* mov [0x101bdea4], ebx */
            ii(0x1016_e20d, 5);  call(/* sys */ 0x1016_d67c, -0xb96);  /* call 0x1016d67c */
            ii(0x1016_e212, 5);  mov(eax, StringDefinitions.ColorPal); /* mov eax, 0x101b2ec4 */
            ii(0x1016_e217, 5);  call(/* sys */ 0x1016_d0f4, -0x1128); /* call 0x1016d0f4 */
            ii(0x1016_e21c, 2);  cmp(eax, ebx);                        /* cmp eax, ebx */
            ii(0x1016_e21e, 2);  if(jnz(0x1016_e22f, 0xf)) goto l_0x1016_e22f;/* jnz 0x1016e22f */
            ii(0x1016_e220, 5);  mov(eax, 0x101b_dec0);                /* mov eax, 0x101bdec0 */
            ii(0x1016_e225, 5);  call(Definitions.sys_display_apply_palette, -0x166e);/* call 0x1016cbbc */
            ii(0x1016_e22a, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1016_e22c, 1);  pop(edx);                             /* pop edx */
            ii(0x1016_e22d, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1016_e22e, 1);  ret(); return;                        /* ret */
        l_0x1016_e22f:
            ii(0x1016_e22f, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1016_e231, 1);  pop(edx);                             /* pop edx */
            ii(0x1016_e232, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1016_e233, 1);  ret();                                /* ret */
        }
    }
}
