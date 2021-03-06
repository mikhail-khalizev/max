using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_48c0-9648f8f9")]
        public void Method_1010_48c0()
        {
            ii(0x1010_48c0, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1010_48c5, 5);  call(Definitions.sys_check_available_stack_size, 0x6_1488);/* call 0x10165d52 */
            ii(0x1010_48ca, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_48cb, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_48cc, 1);  push(edx);                            /* push edx */
            ii(0x1010_48cd, 1);  push(esi);                            /* push esi */
            ii(0x1010_48ce, 1);  push(edi);                            /* push edi */
            ii(0x1010_48cf, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_48d0, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_48d2, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1010_48d8, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_48db, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_48de, 3);  cmp(memd[ds, eax], 0);                /* cmp dword [eax], 0x0 */
            ii(0x1010_48e1, 2);  if(jz(0x1010_48ec, 9)) goto l_0x1010_48ec;/* jz 0x101048ec */
            ii(0x1010_48e3, 7);  mov(memd[ss, ebp - 8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x1010_48ea, 2);  jmp(0x1010_4905, 0x19); goto l_0x1010_4905;/* jmp 0x10104905 */
        l_0x1010_48ec:
            ii(0x1010_48ec, 5);  mov(ecx, 0x10a);                      /* mov ecx, 0x10a */
            ii(0x1010_48f1, 5);  mov(ebx, StringDefinitions.TextfileH);/* mov ebx, 0x101a3110 */
            ii(0x1010_48f6, 5);  mov(edx, StringDefinitions.PtrNotEqual015);/* mov edx, 0x101a311b */
            ii(0x1010_48fb, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1010_48fd, 5);  call(Definitions.sys_assert, 0x6_1490);/* call 0x10165d92 */
            ii(0x1010_4902, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
        l_0x1010_4905:
            ii(0x1010_4905, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_4908, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1010_490a, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1010_490d, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_4910, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_4912, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_4913, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_4914, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_4915, 1);  pop(edx);                             /* pop edx */
            ii(0x1010_4916, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_4917, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_4918, 1);  ret();                                /* ret */
        }
    }
}
