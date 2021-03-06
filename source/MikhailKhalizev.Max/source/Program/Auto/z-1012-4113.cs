using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_4113-8f61c4bc")]
        public void Method_1012_4113()
        {
            ii(0x1012_4113, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1012_4118, 5);  call(Definitions.sys_check_available_stack_size, 0x4_1c35);/* call 0x10165d52 */
            ii(0x1012_411d, 1);  push(ebx);                            /* push ebx */
            ii(0x1012_411e, 1);  push(esi);                            /* push esi */
            ii(0x1012_411f, 1);  push(edi);                            /* push edi */
            ii(0x1012_4120, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_4121, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_4123, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1012_4129, 3);  mov(eax, memd[ss, ebp + 24]);         /* mov eax, [ebp+0x18] */
            ii(0x1012_412c, 1);  push(eax);                            /* push eax */
            ii(0x1012_412d, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_4130, 1);  push(eax);                            /* push eax */
            ii(0x1012_4131, 5);  call(0x1012_3850, -0x8e6);            /* call 0x10123850 */
            ii(0x1012_4136, 3);  add(esp, 8);                          /* add esp, 0x8 */
            ii(0x1012_4139, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1012_413b, 2);  if(jnz(0x1012_4146, 9)) goto l_0x1012_4146;/* jnz 0x10124146 */
            ii(0x1012_413d, 7);  mov(memd[ss, ebp - 4], 0);            /* mov dword [ebp-0x4], 0x0 */
            ii(0x1012_4144, 2);  jmp(0x1012_416a, 0x24); goto l_0x1012_416a;/* jmp 0x1012416a */
        l_0x1012_4146:
            ii(0x1012_4146, 3);  mov(eax, memd[ss, ebp + 28]);         /* mov eax, [ebp+0x1c] */
            ii(0x1012_4149, 1);  push(eax);                            /* push eax */
            ii(0x1012_414a, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_414d, 1);  push(eax);                            /* push eax */
            ii(0x1012_414e, 5);  call(0x1012_3a00, -0x753);            /* call 0x10123a00 */
            ii(0x1012_4153, 3);  add(esp, 8);                          /* add esp, 0x8 */
            ii(0x1012_4156, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1012_4158, 2);  if(jnz(0x1012_4163, 9)) goto l_0x1012_4163;/* jnz 0x10124163 */
            ii(0x1012_415a, 7);  mov(memd[ss, ebp - 4], 0);            /* mov dword [ebp-0x4], 0x0 */
            ii(0x1012_4161, 2);  jmp(0x1012_416a, 7); goto l_0x1012_416a;/* jmp 0x1012416a */
        l_0x1012_4163:
            ii(0x1012_4163, 7);  mov(memd[ss, ebp - 4], 1);            /* mov dword [ebp-0x4], 0x1 */
        l_0x1012_416a:
            ii(0x1012_416a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_416d, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_416f, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_4170, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_4171, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_4172, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1012_4173, 1);  ret();                                /* ret */
        }
    }
}
