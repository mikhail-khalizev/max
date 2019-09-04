using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_5ebb-7cabf7bd")]
        public void Method_1012_5ebb()
        {
            ii(0x1012_5ebb, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1012_5ec0, 5);  call(Definitions.sys_check_available_stack_size, 0x3_fe8d);/* call 0x10165d52 */
            ii(0x1012_5ec5, 1);  push(ebx);                            /* push ebx */
            ii(0x1012_5ec6, 1);  push(ecx);                            /* push ecx */
            ii(0x1012_5ec7, 1);  push(esi);                            /* push esi */
            ii(0x1012_5ec8, 1);  push(edi);                            /* push edi */
            ii(0x1012_5ec9, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_5eca, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_5ecc, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1012_5ed2, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_5ed5, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1012_5ed8, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_5edb, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1012_5ede, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1012_5ee1, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_5ee4, 5);  call(0x1012_5dd6, -0x113);            /* call 0x10125dd6 */
            ii(0x1012_5ee9, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_5eec, 3);  mov(eax, memd[ds, eax + 3]);          /* mov eax, [eax+0x3] */
            ii(0x1012_5eef, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1012_5ef2, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1012_5ef4, 2);  if(jnz(0x1012_5f02, 0xc)) goto l_0x1012_5f02;/* jnz 0x10125f02 */
            ii(0x1012_5ef6, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1012_5ef8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_5efb, 5);  call(0x1008_a998, -0x9_b568);         /* call 0x1008a998 */
            ii(0x1012_5f00, 2);  jmp(0x1012_5f1f, 0x1d); goto l_0x1012_5f1f;/* jmp 0x10125f1f */
        l_0x1012_5f02:
            ii(0x1012_5f02, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_5f05, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1012_5f07, 4);  mov(dx, memw[ds, eax + 5]);           /* mov dx, [eax+0x5] */
            ii(0x1012_5f0b, 5);  mov(eax, 0x101c_39c0);                /* mov eax, 0x101c39c0 */
            ii(0x1012_5f10, 5);  call(0x1010_3eba, -0x2_205b);         /* call 0x10103eba */
            ii(0x1012_5f15, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1012_5f17, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_5f1a, 5);  call(0x1008_a998, -0x9_b587);         /* call 0x1008a998 */
        l_0x1012_5f1f:
            ii(0x1012_5f1f, 7);  mov(memd[ss, ebp - 12], 7);           /* mov dword [ebp-0xc], 0x7 */
            ii(0x1012_5f26, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_5f29, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_5f2b, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_5f2c, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_5f2d, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_5f2e, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1012_5f2f, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1012_5f30, 1);  ret();                                /* ret */
        }
    }
}
