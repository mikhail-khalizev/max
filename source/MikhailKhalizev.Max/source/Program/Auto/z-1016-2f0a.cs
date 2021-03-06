using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_2f0a-973ae71b")]
        public void Method_1016_2f0a()
        {
            ii(0x1016_2f0a, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1016_2f0f, 5);  call(Definitions.sys_check_available_stack_size, 0x2e3e);/* call 0x10165d52 */
            ii(0x1016_2f14, 1);  push(ebx);                            /* push ebx */
            ii(0x1016_2f15, 1);  push(ecx);                            /* push ecx */
            ii(0x1016_2f16, 1);  push(esi);                            /* push esi */
            ii(0x1016_2f17, 1);  push(edi);                            /* push edi */
            ii(0x1016_2f18, 1);  push(ebp);                            /* push ebp */
            ii(0x1016_2f19, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1016_2f1b, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1016_2f21, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1016_2f24, 3);  mov(memb[ss, ebp - 4], dl);           /* mov [ebp-0x4], dl */
            ii(0x1016_2f27, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_2f2a, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1016_2f2c, 3);  mov(dl, memb[ds, eax + 38]);          /* mov dl, [eax+0x26] */
            ii(0x1016_2f2f, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1016_2f31, 5);  mov(al, memb[ds, 0x101c_37da]);       /* mov al, [0x101c37da] */
            ii(0x1016_2f36, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1016_2f38, 2);  if(jnz(0x1016_2f6d, 0x33)) goto l_0x1016_2f6d;/* jnz 0x10162f6d */
            ii(0x1016_2f3a, 5);  call(0x1010_2bf8, -0x6_0347);         /* call 0x10102bf8 */
            ii(0x1016_2f3f, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1016_2f44, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1016_2f47, 4);  cmp(memb[ss, ebp - 4], 0x20);         /* cmp byte [ebp-0x4], 0x20 */
            ii(0x1016_2f4b, 2);  if(jnz(0x1016_2f53, 6)) goto l_0x1016_2f53;/* jnz 0x10162f53 */
            ii(0x1016_2f4d, 4);  mov(memb[ss, ebp - 16], 0xa);         /* mov byte [ebp-0x10], 0xa */
            ii(0x1016_2f51, 2);  jmp(0x1016_2f57, 4); goto l_0x1016_2f57;/* jmp 0x10162f57 */
        l_0x1016_2f53:
            ii(0x1016_2f53, 4);  mov(memb[ss, ebp - 16], 9);           /* mov byte [ebp-0x10], 0x9 */
        l_0x1016_2f57:
            ii(0x1016_2f57, 3);  mov(ebx, memd[ss, ebp - 19]);         /* mov ebx, [ebp-0x13] */
            ii(0x1016_2f5a, 3);  sar(ebx, 0x18);                       /* sar ebx, 0x18 */
            ii(0x1016_2f5d, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1016_2f60, 5);  mov(eax, 0x101c_7278);                /* mov eax, 0x101c7278 */
            ii(0x1016_2f65, 3);  mov(ecx, memd[ss, ebp - 12]);         /* mov ecx, [ebp-0xc] */
            ii(0x1016_2f68, 5);  call(0x1013_d5c0, -0x2_59ad);         /* call 0x1013d5c0 */
        l_0x1016_2f6d:
            ii(0x1016_2f6d, 4);  movsx(ebx, memb[ss, ebp - 4]);        /* movsx ebx, byte [ebp-0x4] */
            ii(0x1016_2f71, 5);  mov(edx, 0x16);                       /* mov edx, 0x16 */
            ii(0x1016_2f76, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_2f79, 5);  call(0x1016_2f96, 0x18);              /* call 0x10162f96 */
            ii(0x1016_2f7e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_2f81, 5);  call(0x1014_9cd1, -0x1_92b5);         /* call 0x10149cd1 */
            ii(0x1016_2f86, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_2f89, 5);  call(0x1014_9fa8, -0x1_8fe6);         /* call 0x10149fa8 */
            ii(0x1016_2f8e, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1016_2f90, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1016_2f91, 1);  pop(edi);                             /* pop edi */
            ii(0x1016_2f92, 1);  pop(esi);                             /* pop esi */
            ii(0x1016_2f93, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1016_2f94, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1016_2f95, 1);  ret();                                /* ret */
        }
    }
}
