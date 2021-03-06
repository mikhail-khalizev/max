using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_daa2-513f5484")]
        public void Method_0017_daa2()
        {
            ii(0x17_daa2, 3);  mov(cx, memw[ss, bp + 10]);             /* mov cx, [bp+0xa] */
            ii(0x17_daa5, 2);  or(cx, cx);                             /* or cx, cx */
            ii(0x17_daa7, 2);  if(jnz(0x17_daae, 5)) goto l_0x17_daae; /* jnz 0xdaae */
            ii(0x17_daa9, 2);  mov(ax, cx);                            /* mov ax, cx */
            ii(0x17_daab, 3);  if(jmp_func(0x17_d8bb, -0x1f3)) return; /* jmp 0xd8bb */
        l_0x17_daae:
            ii(0x17_daae, 3);  mov(dx, memw[ss, bp + 8]);              /* mov dx, [bp+0x8] */
            ii(0x17_dab1, 2);  mov(ah, 0x40);                          /* mov ah, 0x40 */
            ii(0x17_dab3, 2);  @int(0x21);                             /* int 0x21 */
            ii(0x17_dab5, 2);  if(jae(0x17_dabb, 4)) goto l_0x17_dabb; /* jae 0xdabb */
            ii(0x17_dab7, 2);  mov(ah, 9);                             /* mov ah, 0x9 */
            ii(0x17_dab9, 2);  if(jmp_func(0x17_da9f, -0x1c)) return;  /* jmp 0xda9f */
        l_0x17_dabb:
            ii(0x17_dabb, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x17_dabd, 2);  if(jnz_func(0x17_da9f, -0x20)) return;  /* jnz 0xda9f */
            ii(0x17_dabf, 5);  test(memb[ds, bx + 0x1c5d], 0x40);      /* test byte [bx+0x1c5d], 0x40 */
            ii(0x17_dac4, 2);  if(jz(0x17_dad0, 0xa)) goto l_0x17_dad0;/* jz 0xdad0 */
            ii(0x17_dac6, 2);  mov(bx, dx);                            /* mov bx, dx */
            ii(0x17_dac8, 3);  cmp(memb[ds, bx], 0x1a);                /* cmp byte [bx], 0x1a */
            ii(0x17_dacb, 2);  if(jnz(0x17_dad0, 3)) goto l_0x17_dad0; /* jnz 0xdad0 */
            ii(0x17_dacd, 1);  clc();                                  /* clc */
            ii(0x17_dace, 2);  if(jmp_func(0x17_da9f, -0x31)) return;  /* jmp 0xda9f */
        l_0x17_dad0:
            ii(0x17_dad0, 1);  stc();                                  /* stc */
            ii(0x17_dad1, 3);  mov(ax, 0x1c00);                        /* mov ax, 0x1c00 */
            ii(0x17_dad4, 2);  jmp_func(0x17_da9f, -0x37);             /* jmp 0xda9f */
        }
    }
}
