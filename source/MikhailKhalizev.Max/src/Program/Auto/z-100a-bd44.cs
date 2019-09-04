using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_bd44-98190142")]
        public void Method_100a_bd44()
        {
            ii(0x100a_bd44, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100a_bd49, 5);  call(Definitions.sys_check_available_stack_size, 0xb_a004);/* call 0x10165d52 */
            ii(0x100a_bd4e, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_bd4f, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_bd50, 1);  push(edx);                            /* push edx */
            ii(0x100a_bd51, 1);  push(esi);                            /* push esi */
            ii(0x100a_bd52, 1);  push(edi);                            /* push edi */
            ii(0x100a_bd53, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_bd54, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_bd56, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100a_bd5c, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_bd5f, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_bd61, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_bd64, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100a_bd67, 5);  call(0x1013_ad71, 0x8_f005);          /* call 0x1013ad71 */
            ii(0x100a_bd6c, 3);  mov(memb[ss, ebp - 8], al);           /* mov [ebp-0x8], al */
            ii(0x100a_bd6f, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x100a_bd72, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_bd74, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_bd75, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_bd76, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_bd77, 1);  pop(edx);                             /* pop edx */
            ii(0x100a_bd78, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_bd79, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_bd7a, 1);  ret();                                /* ret */
        }
    }
}
