using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_8507-b0ff074d")]
        public void Method_1014_8507()
        {
            ii(0x1014_8507, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1014_850c, 5);  call(Definitions.sys_check_available_stack_size, 0x1_d841);/* call 0x10165d52 */
            ii(0x1014_8511, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_8512, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_8513, 1);  push(edx);                            /* push edx */
            ii(0x1014_8514, 1);  push(esi);                            /* push esi */
            ii(0x1014_8515, 1);  push(edi);                            /* push edi */
            ii(0x1014_8516, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_8517, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_8519, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1014_851f, 7);  cmp(memd[ds, 0x101c_8138], 0);        /* cmp dword [0x101c8138], 0x0 */
            ii(0x1014_8526, 2);  if(jnz(0x1014_8531, 9)) goto l_0x1014_8531;/* jnz 0x10148531 */
            ii(0x1014_8528, 7);  mov(memd[ss, ebp - 4], 0xffff_ffff);  /* mov dword [ebp-0x4], 0xffffffff */
            ii(0x1014_852f, 2);  jmp(0x1014_8568, 0x37); goto l_0x1014_8568;/* jmp 0x10148568 */
        l_0x1014_8531:
            ii(0x1014_8531, 7);  mov(bx, memw[ds, 0x101c_8128]);       /* mov bx, [0x101c8128] */
            ii(0x1014_8538, 5);  mov(eax, memd[ds, 0x101c_8124]);      /* mov eax, [0x101c8124] */
            ii(0x1014_853d, 5);  mov(edx, 8);                          /* mov edx, 0x8 */
            ii(0x1014_8542, 2);  mov(ecx, ebx);                        /* mov ecx, ebx */
            ii(0x1014_8544, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1014_8546, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1014_8548, 5);  call(/* sys */ 0x1017_92f0, 0x3_0da3);/* call 0x101792f0 */
            ii(0x1014_854d, 5);  mov(eax, 0x1_0000);                   /* mov eax, 0x10000 */
            ii(0x1014_8552, 5);  call(0x1014_8415, -0x142);            /* call 0x10148415 */
            ii(0x1014_8557, 10);  mov(memd[ds, 0x101c_8138], 0);       /* mov dword [0x101c8138], 0x0 */
            ii(0x1014_8561, 7);  mov(memd[ss, ebp - 4], 0);            /* mov dword [ebp-0x4], 0x0 */
        l_0x1014_8568:
            ii(0x1014_8568, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_856b, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_856d, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_856e, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_856f, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_8570, 1);  pop(edx);                             /* pop edx */
            ii(0x1014_8571, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_8572, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_8573, 1);  ret();                                /* ret */
        }
    }
}
