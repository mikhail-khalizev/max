using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_3172-d1c0a525")]
        public void Method_100b_3172()
        {
            ii(0x100b_3172, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100b_3177, 5);  call(Definitions.sys_check_available_stack_size, 0xb_2bd6);/* call 0x10165d52 */
            ii(0x100b_317c, 1);  push(ebx);                            /* push ebx */
            ii(0x100b_317d, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_317e, 1);  push(edx);                            /* push edx */
            ii(0x100b_317f, 1);  push(esi);                            /* push esi */
            ii(0x100b_3180, 1);  push(edi);                            /* push edi */
            ii(0x100b_3181, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_3182, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_3184, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100b_318a, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100b_318d, 7);  mov(memd[ss, ebp - 8], 4);            /* mov dword [ebp-0x8], 0x4 */
            ii(0x100b_3194, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_3197, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_3199, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_319a, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_319b, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_319c, 1);  pop(edx);                             /* pop edx */
            ii(0x100b_319d, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_319e, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100b_319f, 1);  ret();                                /* ret */
        }
    }
}
