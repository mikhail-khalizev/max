using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_d6b2-3d4b608c")]
        public void /* sys */ Method_1018_d6b2()
        {
            ii(0x1018_d6b2, 1);  push(ebx);                            /* push ebx */
            ii(0x1018_d6b3, 1);  push(ecx);                            /* push ecx */
            ii(0x1018_d6b4, 1);  push(edx);                            /* push edx */
            ii(0x1018_d6b5, 2);  mov(ecx, eax);                        /* mov ecx, eax */
            ii(0x1018_d6b7, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1018_d6b9, 2);  mov(ah, 0x3e);                        /* mov ah, 0x3e */
            ii(0x1018_d6bb, 2);  @int(0x21);                           /* int 0x21 */
            ii(0x1018_d6bd, 2);  rcl(eax, 1);                          /* rcl eax, 1 */
            ii(0x1018_d6bf, 2);  ror(eax, 1);                          /* ror eax, 1 */
            ii(0x1018_d6c1, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1018_d6c3, 2);  if(jl(0x1018_d6d4, 0xf)) goto l_0x1018_d6d4;/* jl 0x1018d6d4 */
            ii(0x1018_d6c5, 2);  mov(eax, ecx);                        /* mov eax, ecx */
            ii(0x1018_d6c7, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1018_d6c9, 5);  call(/* sys */ 0x1019_46fa, 0x702c);  /* call 0x101946fa */
            ii(0x1018_d6ce, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1018_d6d0, 1);  pop(edx);                             /* pop edx */
            ii(0x1018_d6d1, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1018_d6d2, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1018_d6d3, 1);  ret(); return;                        /* ret */
        l_0x1018_d6d4:
            ii(0x1018_d6d4, 5);  mov(eax, 4);                          /* mov eax, 0x4 */
            ii(0x1018_d6d9, 5);  call(/* sys */ 0x1018_d3bf, -0x31f);  /* call 0x1018d3bf */
            ii(0x1018_d6de, 5);  mov(eax, 0xffff_ffff);                /* mov eax, 0xffffffff */
            ii(0x1018_d6e3, 1);  pop(edx);                             /* pop edx */
            ii(0x1018_d6e4, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1018_d6e5, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1018_d6e6, 1);  ret();                                /* ret */
        }
    }
}
