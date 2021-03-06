using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_c9b8-54d9610a")]
        public void /* sys */ Method_1016_c9b8()
        {
            ii(0x1016_c9b8, 1);  push(eax);                            /* push eax */
            ii(0x1016_c9b9, 5);  mov(eax, 0);                          /* mov eax, 0x0 */
            ii(0x1016_c9be, 5);  mov(edx, 0xff);                       /* mov edx, 0xff */
            ii(0x1016_c9c3, 5);  call(/* sys */ 0x1018_7ebd, 0x1_b4f5);/* call 0x10187ebd */
            ii(0x1016_c9c8, 1);  pop(eax);                             /* pop eax */
            ii(0x1016_c9c9, 2);  mov(ah, 0x4c);                        /* mov ah, 0x4c */
            ii(0x1016_c9cb, 2);  @int(0x21);                           /* int 0x21 */
            ii(0x1016_c9cd, 3);  lea(eax, memd[ds, eax]);              /* lea eax, [eax] */
            ii(0x1016_c9d0, 8);  mov(ds, memw[cs, /* sys */ 0x1016_c9d9]);/* mov ds, [cs:0x1016c9d9] */
            ii(0x1016_c9d8, 1);  ret();                                /* ret */
        }
    }
}
