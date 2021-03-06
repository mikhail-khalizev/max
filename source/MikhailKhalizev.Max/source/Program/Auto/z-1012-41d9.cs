using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_41d9-f0c54d64")]
        public void Method_1012_41d9()
        {
            ii(0x1012_41d9, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1012_41de, 5);  call(Definitions.sys_check_available_stack_size, 0x4_1b6f);/* call 0x10165d52 */
            ii(0x1012_41e3, 1);  push(ebx);                            /* push ebx */
            ii(0x1012_41e4, 1);  push(esi);                            /* push esi */
            ii(0x1012_41e5, 1);  push(edi);                            /* push edi */
            ii(0x1012_41e6, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_41e7, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_41e9, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1012_41ef, 3);  mov(eax, memd[ss, ebp + 24]);         /* mov eax, [ebp+0x18] */
            ii(0x1012_41f2, 1);  push(eax);                            /* push eax */
            ii(0x1012_41f3, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_41f6, 1);  push(eax);                            /* push eax */
            ii(0x1012_41f7, 5);  call(0x1012_3850, -0x9ac);            /* call 0x10123850 */
            ii(0x1012_41fc, 3);  add(esp, 8);                          /* add esp, 0x8 */
            ii(0x1012_41ff, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1012_4201, 2);  if(jnz(0x1012_420c, 9)) goto l_0x1012_420c;/* jnz 0x1012420c */
            ii(0x1012_4203, 7);  mov(memd[ss, ebp - 4], 0);            /* mov dword [ebp-0x4], 0x0 */
            ii(0x1012_420a, 2);  jmp(0x1012_4259, 0x4d); goto l_0x1012_4259;/* jmp 0x10124259 */
        l_0x1012_420c:
            ii(0x1012_420c, 4);  cmp(memd[ss, ebp + 28], 0);           /* cmp dword [ebp+0x1c], 0x0 */
            ii(0x1012_4210, 2);  if(jz(0x1012_4233, 0x21)) goto l_0x1012_4233;/* jz 0x10124233 */
            ii(0x1012_4212, 5);  mov(eax, StringDefinitions.Yes2);     /* mov eax, 0x101a811c */
            ii(0x1012_4217, 1);  push(eax);                            /* push eax */
            ii(0x1012_4218, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_421b, 1);  push(eax);                            /* push eax */
            ii(0x1012_421c, 5);  call(0x1012_3f33, -0x2ee);            /* call 0x10123f33 */
            ii(0x1012_4221, 3);  add(esp, 8);                          /* add esp, 0x8 */
            ii(0x1012_4224, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1012_4226, 2);  if(jnz(0x1012_4231, 9)) goto l_0x1012_4231;/* jnz 0x10124231 */
            ii(0x1012_4228, 7);  mov(memd[ss, ebp - 4], 0);            /* mov dword [ebp-0x4], 0x0 */
            ii(0x1012_422f, 2);  jmp(0x1012_4259, 0x28); goto l_0x1012_4259;/* jmp 0x10124259 */
        l_0x1012_4231:
            ii(0x1012_4231, 2);  jmp(0x1012_4252, 0x1f); goto l_0x1012_4252;/* jmp 0x10124252 */
        l_0x1012_4233:
            ii(0x1012_4233, 5);  mov(eax, StringDefinitions.No);       /* mov eax, 0x101a8120 */
            ii(0x1012_4238, 1);  push(eax);                            /* push eax */
            ii(0x1012_4239, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_423c, 1);  push(eax);                            /* push eax */
            ii(0x1012_423d, 5);  call(0x1012_3f33, -0x30f);            /* call 0x10123f33 */
            ii(0x1012_4242, 3);  add(esp, 8);                          /* add esp, 0x8 */
            ii(0x1012_4245, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1012_4247, 2);  if(jnz(0x1012_4252, 9)) goto l_0x1012_4252;/* jnz 0x10124252 */
            ii(0x1012_4249, 7);  mov(memd[ss, ebp - 4], 0);            /* mov dword [ebp-0x4], 0x0 */
            ii(0x1012_4250, 2);  jmp(0x1012_4259, 7); goto l_0x1012_4259;/* jmp 0x10124259 */
        l_0x1012_4252:
            ii(0x1012_4252, 7);  mov(memd[ss, ebp - 4], 1);            /* mov dword [ebp-0x4], 0x1 */
        l_0x1012_4259:
            ii(0x1012_4259, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_425c, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_425e, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_425f, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_4260, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_4261, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1012_4262, 1);  ret();                                /* ret */
        }
    }
}
