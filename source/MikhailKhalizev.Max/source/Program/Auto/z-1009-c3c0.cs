using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_c3c0-524911ac")]
        public void Method_1009_c3c0()
        {
            ii(0x1009_c3c0, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1009_c3c5, 5);  call(Definitions.sys_check_available_stack_size, 0xc_9988);/* call 0x10165d52 */
            ii(0x1009_c3ca, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_c3cb, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_c3cc, 1);  push(edx);                            /* push edx */
            ii(0x1009_c3cd, 1);  push(esi);                            /* push esi */
            ii(0x1009_c3ce, 1);  push(edi);                            /* push edi */
            ii(0x1009_c3cf, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_c3d0, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_c3d2, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1009_c3d8, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_c3db, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_c3de, 3);  cmp(memd[ds, eax], 0);                /* cmp dword [eax], 0x0 */
            ii(0x1009_c3e1, 2);  if(jz(0x1009_c3ec, 9)) goto l_0x1009_c3ec;/* jz 0x1009c3ec */
            ii(0x1009_c3e3, 7);  mov(memd[ss, ebp - 8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x1009_c3ea, 2);  jmp(0x1009_c405, 0x19); goto l_0x1009_c405;/* jmp 0x1009c405 */
        l_0x1009_c3ec:
            ii(0x1009_c3ec, 5);  mov(ecx, 0xae);                       /* mov ecx, 0xae */
            ii(0x1009_c3f1, 5);  mov(ebx, StringDefinitions.SmartptrH20);/* mov ebx, 0x101a0378 */
            ii(0x1009_c3f6, 5);  mov(edx, StringDefinitions.PtrNotEqual022);/* mov edx, 0x101a0383 */
            ii(0x1009_c3fb, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1009_c3fd, 5);  call(Definitions.sys_assert, 0xc_9990);/* call 0x10165d92 */
            ii(0x1009_c402, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
        l_0x1009_c405:
            ii(0x1009_c405, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_c408, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1009_c40a, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1009_c40d, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1009_c410, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_c412, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_c413, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_c414, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_c415, 1);  pop(edx);                             /* pop edx */
            ii(0x1009_c416, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_c417, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_c418, 1);  ret();                                /* ret */
        }
    }
}
