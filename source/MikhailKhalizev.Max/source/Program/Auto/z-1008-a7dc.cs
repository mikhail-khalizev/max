using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_a7dc-5b0e8c")]
        public void Method_1008_a7dc()
        {
            ii(0x1008_a7dc, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1008_a7e1, 5);  call(Definitions.sys_check_available_stack_size, 0xd_b56c);/* call 0x10165d52 */
            ii(0x1008_a7e6, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_a7e7, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_a7e8, 1);  push(edx);                            /* push edx */
            ii(0x1008_a7e9, 1);  push(esi);                            /* push esi */
            ii(0x1008_a7ea, 1);  push(edi);                            /* push edi */
            ii(0x1008_a7eb, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_a7ec, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_a7ee, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1008_a7f4, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_a7f7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_a7fa, 3);  cmp(memd[ds, eax], 0);                /* cmp dword [eax], 0x0 */
            ii(0x1008_a7fd, 2);  if(jz(0x1008_a808, 9)) goto l_0x1008_a808;/* jz 0x1008a808 */
            ii(0x1008_a7ff, 7);  mov(memd[ss, ebp - 8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x1008_a806, 2);  jmp(0x1008_a821, 0x19); goto l_0x1008_a821;/* jmp 0x1008a821 */
        l_0x1008_a808:
            ii(0x1008_a808, 5);  mov(ecx, 0xae);                       /* mov ecx, 0xae */
            ii(0x1008_a80d, 5);  mov(ebx, StringDefinitions.SmartptrH15);/* mov ebx, 0x101a00bc */
            ii(0x1008_a812, 5);  mov(edx, StringDefinitions.PtrNotEqual017);/* mov edx, 0x101a00c7 */
            ii(0x1008_a817, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1008_a819, 5);  call(Definitions.sys_assert, 0xd_b574);/* call 0x10165d92 */
            ii(0x1008_a81e, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
        l_0x1008_a821:
            ii(0x1008_a821, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_a824, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1008_a826, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1008_a829, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1008_a82c, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_a82e, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_a82f, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_a830, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_a831, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_a832, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_a833, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_a834, 1);  ret();                                /* ret */
        }
    }
}
