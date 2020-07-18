using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_9970-6bdb8e41")]
        public void /* sys */ Method_1017_9970()
        {
            ii(0x1017_9970, 1);  push(ebp);                            /* push ebp */
            ii(0x1017_9971, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1017_9973, 1);  push(ebx);                            /* push ebx */
            ii(0x1017_9974, 1);  push(ecx);                            /* push ecx */
            ii(0x1017_9975, 1);  push(edx);                            /* push edx */
            ii(0x1017_9976, 1);  push(esi);                            /* push esi */
            ii(0x1017_9977, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1017_9979, 5);  mov(eax, 0x1020_9c60);                /* mov eax, 0x10209c60 */
            ii(0x1017_997e, 2);  mov(edx, ebx);                        /* mov edx, ebx */
            ii(0x1017_9980, 5);  call(/* sys */ 0x1017_95d0, -0x3b5);  /* call 0x101795d0 */
            ii(0x1017_9985, 2);  mov(esi, eax);                        /* mov esi, eax */
            ii(0x1017_9987, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1017_9989, 2);  if(jz(0x1017_99a3, 0x18)) goto l_0x1017_99a3;/* jz 0x101799a3 */
            ii(0x1017_998b, 1);  push(ebx);                            /* push ebx */
            ii(0x1017_998c, 1);  push(eax);                            /* push eax */
            ii(0x1017_998d, 6);  mov(edx, memd[ds, 0x1020_9db0]);      /* mov edx, [0x10209db0] */
            ii(0x1017_9993, 1);  push(edx);                            /* push edx */
            ii(0x1017_9994, 6);  call_abs(memd[ds, 0x1020_9db8]);      /* call dword [0x10209db8] */
            ii(0x1017_999a, 3);  add(esp, 0xc);                        /* add esp, 0xc */
            ii(0x1017_999d, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1017_999f, 2);  if(jnz(0x1017_99a3, 2)) goto l_0x1017_99a3;/* jnz 0x101799a3 */
            ii(0x1017_99a1, 2);  xor(esi, esi);                        /* xor esi, esi */
        l_0x1017_99a3:
            ii(0x1017_99a3, 2);  mov(eax, esi);                        /* mov eax, esi */
            ii(0x1017_99a5, 3);  lea(esp, memd[ss, ebp - 16]);         /* lea esp, [ebp-0x10] */
            ii(0x1017_99a8, 1);  pop(esi);                             /* pop esi */
            ii(0x1017_99a9, 1);  pop(edx);                             /* pop edx */
            ii(0x1017_99aa, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1017_99ab, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1017_99ac, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1017_99ad, 1);  ret();                                /* ret */
        }
    }
}
