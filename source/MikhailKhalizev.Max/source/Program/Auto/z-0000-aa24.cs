using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xaa24-65823507")]
        public void Method_0000_aa24()
        {
            ii(0xaa24, 3);  call(0xaa14, -0x13);                       /* call 0xaa14 */
            ii(0xaa27, 2);  or(ax, ax);                                /* or ax, ax */
            ii(0xaa29, 2);  if(jnz(0xaa2c, 1)) goto l_0xaa2c;          /* jnz 0xaa2c */
            ii(0xaa2b, 1);  ret(); return;                             /* ret */
        l_0xaa2c:
            ii(0xaa2c, 3);  mov(ax, 0x4310);                           /* mov ax, 0x4310 */
            ii(0xaa2f, 2);  @int(0x2f);                                /* int 0x2f */
            ii(0xaa31, 4);  mov(memw[ds, 0xaec], bx);                  /* mov [0xaec], bx */
            ii(0xaa35, 4);  mov(memw[ds, 0xaee], es);                  /* mov [0xaee], es */
            ii(0xaa39, 2);  xor(ah, ah);                               /* xor ah, ah */
            ii(0xaa3b, 4);  call_far_ind(memw[ds, 0xaec]);             /* call far word [0xaec] */
            ii(0xaa3f, 2);  dec(ah);                                   /* dec ah */
            ii(0xaa41, 2);  if(jle_func(0xaa0a, -0x39)) return;        /* jle 0xaa0a */
            ii(0xaa43, 4);  cmp(bx, 0x204);                            /* cmp bx, 0x204 */
            ii(0xaa47, 2);  if(jae(0xaa50, 7)) goto l_0xaa50;          /* jae 0xaa50 */
            ii(0xaa49, 7);  mov(memw[cs, 0x1df5], 0x40);               /* mov word [cs:0x1df5], 0x40 */
        l_0xaa50:
            ii(0xaa50, 2);  mov(ah, 8);                                /* mov ah, 0x8 */
            ii(0xaa52, 4);  call_far_ind(memw[ds, 0xaec]);             /* call far word [0xaec] */
            ii(0xaa56, 5);  sub(ax, memw[cs, 0x1df5]);                 /* sub ax, [cs:0x1df5] */
            ii(0xaa5b, 2);  if(jae_func(0xaa5f, 2)) return;            /* jae 0xaa5f */
            ii(0xaa5d, 2);  xor(ax, ax);                               /* xor ax, ax */
        }
    }
}
