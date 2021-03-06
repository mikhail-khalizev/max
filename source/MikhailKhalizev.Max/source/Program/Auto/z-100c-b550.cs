using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_b550-2b3f84ef")]
        public void Method_100c_b550()
        {
            ii(0x100c_b550, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100c_b555, 5);  call(Definitions.sys_check_available_stack_size, 0x9_a7f8);/* call 0x10165d52 */
            ii(0x100c_b55a, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_b55b, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_b55c, 1);  push(esi);                            /* push esi */
            ii(0x100c_b55d, 1);  push(edi);                            /* push edi */
            ii(0x100c_b55e, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_b55f, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_b561, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100c_b567, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_b56a, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100c_b56d, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100c_b570, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_b573, 5);  call(0x1013_ac7d, 0x6_f705);          /* call 0x1013ac7d */
            ii(0x100c_b578, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100c_b57b, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_b57e, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_b580, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_b581, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_b582, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_b583, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_b584, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_b585, 1);  ret();                                /* ret */
        }
    }
}
