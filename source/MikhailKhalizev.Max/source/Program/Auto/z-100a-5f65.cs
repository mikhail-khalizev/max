using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_5f65-6a2d6ef6")]
        public void Method_100a_5f65()
        {
            ii(0x100a_5f65, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100a_5f6a, 5);  call(Definitions.sys_check_available_stack_size, 0xb_fde3);/* call 0x10165d52 */
            ii(0x100a_5f6f, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_5f70, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_5f71, 1);  push(esi);                            /* push esi */
            ii(0x100a_5f72, 1);  push(edi);                            /* push edi */
            ii(0x100a_5f73, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_5f74, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_5f76, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100a_5f7c, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_5f7f, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_5f82, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100a_5f86, 5);  call(/* sys */ 0x1016_5df8, 0xb_fe6d);/* call 0x10165df8 */
            ii(0x100a_5f8b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_5f8e, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100a_5f92, 5);  call(/* sys */ 0x1016_5df8, 0xb_fe61);/* call 0x10165df8 */
            ii(0x100a_5f97, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_5f9a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_5f9d, 4);  cmp(ax, memw[ss, ebp - 4]);           /* cmp ax, [ebp-0x4] */
            ii(0x100a_5fa1, 2);  if(jge(0x100a_5fb2, 0xf)) goto l_0x100a_5fb2;/* jge 0x100a5fb2 */
            ii(0x100a_5fa3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_5fa6, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x100a_5fa8, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100a_5fab, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x100a_5fad, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x100a_5fb0, 2);  jmp(0x100a_5fbf, 0xd); goto l_0x100a_5fbf;/* jmp 0x100a5fbf */
        l_0x100a_5fb2:
            ii(0x100a_5fb2, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_5fb5, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x100a_5fb7, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_5fba, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x100a_5fbc, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
        l_0x100a_5fbf:
            ii(0x100a_5fbf, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100a_5fc2, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_5fc4, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_5fc5, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_5fc6, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_5fc7, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_5fc8, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_5fc9, 1);  ret();                                /* ret */
        }
    }
}
