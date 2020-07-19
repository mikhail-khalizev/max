using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_b165-f41c18f9")]
        public void /* sys */ Method_1019_b165()
        {
            ii(0x1019_b165, 5);  mov(eax, StringDefinitions.Tz);       /* mov eax, 0x101b3744 */
            ii(0x1019_b16a, 5);  call(/* sys */ 0x1019_54bf, -0x5cb0); /* call 0x101954bf */
            ii(0x1019_b16f, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1019_b171, 2);  if(jz_func(0x1019_b14d, -0x26)) return;/* jz 0x1019b14d */
            ii(0x1019_b173, 1);  push(ebx);                            /* push ebx */
            ii(0x1019_b174, 1);  push(ecx);                            /* push ecx */
            ii(0x1019_b175, 1);  push(edx);                            /* push edx */
            ii(0x1019_b176, 1);  push(esi);                            /* push esi */
            ii(0x1019_b177, 1);  push(edi);                            /* push edi */
            ii(0x1019_b178, 1);  push(ebp);                            /* push ebp */
            ii(0x1019_b179, 3);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1019_b17c, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1019_b17e, 5);  mov(ebx, 0x101c_1ca0);                /* mov ebx, 0x101c1ca0 */
            ii(0x1019_b183, 6);  mov(memd[ds, 0x101c_1ca8], edx);      /* mov [0x101c1ca8], edx */
            ii(0x1019_b189, 5);  mov(edx, 0x101c_1cac);                /* mov edx, 0x101c1cac */
            ii(0x1019_b18e, 5);  call(/* sys */ 0x1019_b1ce, 0x3b);    /* call 0x1019b1ce */
            ii(0x1019_b193, 2);  mov(ecx, eax);                        /* mov ecx, eax */
            ii(0x1019_b195, 2);  mov(ah, memb[ds, eax]);               /* mov ah, [eax] */
            ii(0x1019_b197, 2);  test(ah, ah);                         /* test ah, ah */
            ii(0x1019_b199, 6);  if(jnz_func(0x1019_b3fb, 0x25c)) return;/* jnz 0x1019b3fb */
            ii(0x1019_b19f, 6);  mov(memb[ds, 0x101c_1ccb], ah);       /* mov [0x101c1ccb], ah */
            ii(0x1019_b1a5, 5);  jmp_func(0x1019_b4bf, 0x315);         /* jmp 0x1019b4bf */
        }
    }
}
