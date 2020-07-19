using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_86e9-e319e850")]
        public void Method_100a_86e9()
        {
            ii(0x100a_86e9, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100a_86ee, 5);  call(Definitions.sys_check_available_stack_size, 0xb_d65f);/* call 0x10165d52 */
            ii(0x100a_86f3, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_86f4, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_86f5, 1);  push(edx);                            /* push edx */
            ii(0x100a_86f6, 1);  push(esi);                            /* push esi */
            ii(0x100a_86f7, 1);  push(edi);                            /* push edi */
            ii(0x100a_86f8, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_86f9, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_86fb, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100a_8701, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_8704, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_8707, 3);  mov(eax, memd[ds, eax + 16]);         /* mov eax, [eax+0x10] */
            ii(0x100a_870a, 3);  sar(eax, 0x18);                       /* sar eax, 0x18 */
            ii(0x100a_870d, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100a_870f, 2);  if(jz(0x100a_871f, 0xe)) goto l_0x100a_871f;/* jz 0x100a871f */
            ii(0x100a_8711, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_8714, 3);  mov(eax, memd[ds, eax + 16]);         /* mov eax, [eax+0x10] */
            ii(0x100a_8717, 3);  sar(eax, 0x18);                       /* sar eax, 0x18 */
            ii(0x100a_871a, 3);  cmp(eax, 4);                          /* cmp eax, 0x4 */
            ii(0x100a_871d, 2);  if(jnz(0x100a_8721, 2)) goto l_0x100a_8721;/* jnz 0x100a8721 */
        l_0x100a_871f:
            ii(0x100a_871f, 2);  jmp(0x100a_8727, 6); goto l_0x100a_8727;/* jmp 0x100a8727 */
        l_0x100a_8721:
            ii(0x100a_8721, 4);  mov(memb[ss, ebp - 8], 1);            /* mov byte [ebp-0x8], 0x1 */
            ii(0x100a_8725, 2);  jmp(0x100a_872b, 4); goto l_0x100a_872b;/* jmp 0x100a872b */
        l_0x100a_8727:
            ii(0x100a_8727, 4);  mov(memb[ss, ebp - 8], 0);            /* mov byte [ebp-0x8], 0x0 */
        l_0x100a_872b:
            ii(0x100a_872b, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x100a_872e, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x100a_8731, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x100a_8734, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_8736, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_8737, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_8738, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_8739, 1);  pop(edx);                             /* pop edx */
            ii(0x100a_873a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_873b, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_873c, 1);  ret();                                /* ret */
        }
    }
}
