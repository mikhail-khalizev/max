using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_9be4-e52d0143")]
        public void Method_1015_9be4()
        {
            ii(0x1015_9be4, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1015_9be9, 5);  call(Definitions.sys_check_available_stack_size, 0xc164);/* call 0x10165d52 */
            ii(0x1015_9bee, 1);  push(ebx);                            /* push ebx */
            ii(0x1015_9bef, 1);  push(ecx);                            /* push ecx */
            ii(0x1015_9bf0, 1);  push(esi);                            /* push esi */
            ii(0x1015_9bf1, 1);  push(edi);                            /* push edi */
            ii(0x1015_9bf2, 1);  push(ebp);                            /* push ebp */
            ii(0x1015_9bf3, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1015_9bf5, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1015_9bfb, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1015_9bfe, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1015_9c01, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_9c04, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1015_9c07, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1015_9c0c, 5);  call(0x100f_448c, -0x6_5785);         /* call 0x100f448c */
            ii(0x1015_9c11, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1015_9c14, 4);  cmp(memb[ds, eax + 61], 8);           /* cmp byte [eax+0x3d], 0x8 */
            ii(0x1015_9c18, 2);  if(jnz(0x1015_9c26, 0xc)) goto l_0x1015_9c26;/* jnz 0x10159c26 */
            ii(0x1015_9c1a, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_9c1d, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1015_9c1f, 5);  call(0x1015_9680, -0x5a4);            /* call 0x10159680 */
            ii(0x1015_9c24, 2);  jmp(0x1015_9c45, 0x1f); goto l_0x1015_9c45;/* jmp 0x10159c45 */
        l_0x1015_9c26:
            ii(0x1015_9c26, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1015_9c29, 4);  test(memb[ds, eax + 18], 0x40);       /* test byte [eax+0x12], 0x40 */
            ii(0x1015_9c2d, 2);  if(jz(0x1015_9c3b, 0xc)) goto l_0x1015_9c3b;/* jz 0x10159c3b */
            ii(0x1015_9c2f, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_9c32, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1015_9c34, 5);  call(0x1015_9b20, -0x119);            /* call 0x10159b20 */
            ii(0x1015_9c39, 2);  jmp(0x1015_9c45, 0xa); goto l_0x1015_9c45;/* jmp 0x10159c45 */
        l_0x1015_9c3b:
            ii(0x1015_9c3b, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_9c3e, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1015_9c40, 5);  call(0x1015_9b82, -0xc3);             /* call 0x10159b82 */
        l_0x1015_9c45:
            ii(0x1015_9c45, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1015_9c47, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1015_9c48, 1);  pop(edi);                             /* pop edi */
            ii(0x1015_9c49, 1);  pop(esi);                             /* pop esi */
            ii(0x1015_9c4a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1015_9c4b, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1015_9c4c, 1);  ret();                                /* ret */
        }
    }
}
