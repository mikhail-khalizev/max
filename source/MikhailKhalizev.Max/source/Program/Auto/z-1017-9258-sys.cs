using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_9258-13098552")]
        public void /* sys */ Method_1017_9258()
        {
            ii(0x1017_9258, 1);  push(edi);                            /* push edi */
            ii(0x1017_9259, 1);  push(ecx);                            /* push ecx */
            ii(0x1017_925a, 1);  push(ebx);                            /* push ebx */
            ii(0x1017_925b, 2);  mov(edi, edx);                        /* mov edi, edx */
            ii(0x1017_925d, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1017_925f, 2);  mov(ah, 0x36);                        /* mov ah, 0x36 */
            ii(0x1017_9261, 2);  @int(0x21);                           /* int 0x21 */
            ii(0x1017_9263, 4);  cmp(ax, 0xffff);                      /* cmp ax, 0xffff */
            ii(0x1017_9267, 2);  if(jz(0x1017_927c, 0x13)) goto l_0x1017_927c;/* jz 0x1017927c */
            ii(0x1017_9269, 3);  mov(memw[ds, edi], dx);               /* mov [edi], dx */
            ii(0x1017_926c, 4);  mov(memw[ds, edi + 2], bx);           /* mov [edi+0x2], bx */
            ii(0x1017_9270, 4);  mov(memw[ds, edi + 4], ax);           /* mov [edi+0x4], ax */
            ii(0x1017_9274, 4);  mov(memw[ds, edi + 6], cx);           /* mov [edi+0x6], cx */
            ii(0x1017_9278, 2);  sub(eax, eax);                        /* sub eax, eax */
            ii(0x1017_927a, 2);  jmp(0x1017_9281, 5); goto l_0x1017_9281;/* jmp 0x10179281 */
        l_0x1017_927c:
            ii(0x1017_927c, 5);  call(/* sys */ 0x1018_d3d2, 0x1_4151);/* call 0x1018d3d2 */
        l_0x1017_9281:
            ii(0x1017_9281, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1017_9282, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1017_9283, 1);  pop(edi);                             /* pop edi */
            ii(0x1017_9284, 1);  ret();                                /* ret */
        }
    }
}
