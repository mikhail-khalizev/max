using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_c623-facbecc4")]
        public void /* sys */ Method_1016_c623()
        {
            ii(0x1016_c623, 1);  push(esi);                            /* push esi */
            ii(0x1016_c624, 1);  push(edi);                            /* push edi */
            ii(0x1016_c625, 1);  push(ebp);                            /* push ebp */
            ii(0x1016_c626, 2);  mov(edi, edx);                        /* mov edi, edx */
            ii(0x1016_c628, 2);  mov(ebp, ebx);                        /* mov ebp, ebx */
            ii(0x1016_c62a, 2);  mov(ebx, ecx);                        /* mov ebx, ecx */
            ii(0x1016_c62c, 2);  mov(edx, ebp);                        /* mov edx, ebp */
            ii(0x1016_c62e, 2);  mov(esi, eax);                        /* mov esi, eax */
            ii(0x1016_c630, 5);  call(/* sys */ 0x1018_79b4, 0x1_b37f);/* call 0x101879b4 */
            ii(0x1016_c635, 3);  mov(eax, memd[ss, ebp]);              /* mov eax, [ebp] */
            ii(0x1016_c638, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1016_c639, 1);  pop(edi);                             /* pop edi */
            ii(0x1016_c63a, 1);  pop(esi);                             /* pop esi */
            ii(0x1016_c63b, 1);  ret();                                /* ret */
        }
    }
}
