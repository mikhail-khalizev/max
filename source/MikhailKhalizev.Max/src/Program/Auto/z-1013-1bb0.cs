using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_1bb0-8a458fdc")]
        public void Method_1013_1bb0()
        {
            ii(0x1013_1bb0, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1013_1bb5, 5);  call(Definitions.sys_check_available_stack_size, 0x3_4198);/* call 0x10165d52 */
            ii(0x1013_1bba, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_1bbb, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_1bbc, 1);  push(edx);                            /* push edx */
            ii(0x1013_1bbd, 1);  push(esi);                            /* push esi */
            ii(0x1013_1bbe, 1);  push(edi);                            /* push edi */
            ii(0x1013_1bbf, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_1bc0, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_1bc2, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1013_1bc8, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1013_1bcb, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_1bce, 3);  cmp(memd[ds, eax], 0);                /* cmp dword [eax], 0x0 */
            ii(0x1013_1bd1, 2);  if(jz(0x1013_1bdc, 9)) goto l_0x1013_1bdc;/* jz 0x10131bdc */
            ii(0x1013_1bd3, 7);  mov(memd[ss, ebp - 8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x1013_1bda, 2);  jmp(0x1013_1bf5, 0x19); goto l_0x1013_1bf5;/* jmp 0x10131bf5 */
        l_0x1013_1bdc:
            ii(0x1013_1bdc, 5);  mov(ecx, 0xae);                       /* mov ecx, 0xae */
            ii(0x1013_1be1, 5);  mov(ebx, StringDefinitions.SmartptrH12);/* mov ebx, 0x101a86c0 */
            ii(0x1013_1be6, 5);  mov(edx, StringDefinitions.PtrNotEqual012);/* mov edx, 0x101a86cb */
            ii(0x1013_1beb, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1013_1bed, 5);  call(Definitions.sys_assert, 0x3_41a0);/* call 0x10165d92 */
            ii(0x1013_1bf2, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
        l_0x1013_1bf5:
            ii(0x1013_1bf5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_1bf8, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1013_1bfa, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_1bfd, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_1c00, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_1c02, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_1c03, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_1c04, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_1c05, 1);  pop(edx);                             /* pop edx */
            ii(0x1013_1c06, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_1c07, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_1c08, 1);  ret();                                /* ret */
        }
    }
}
