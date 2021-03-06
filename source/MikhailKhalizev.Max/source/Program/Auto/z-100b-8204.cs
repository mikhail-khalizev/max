using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_8204-4050d6fb")]
        public void Method_100b_8204()
        {
            ii(0x100b_8204, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100b_8209, 5);  call(Definitions.sys_check_available_stack_size, 0xa_db44);/* call 0x10165d52 */
            ii(0x100b_820e, 1);  push(ebx);                            /* push ebx */
            ii(0x100b_820f, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_8210, 1);  push(esi);                            /* push esi */
            ii(0x100b_8211, 1);  push(edi);                            /* push edi */
            ii(0x100b_8212, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_8213, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_8215, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100b_821b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_821e, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100b_8221, 5);  call(0x100b_8388, 0x162);             /* call 0x100b8388 */
            ii(0x100b_8226, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100b_8228, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x100b_822a, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100b_822d, 3);  add(edx, 0x18);                       /* add edx, 0x18 */
            ii(0x100b_8230, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_8233, 5);  call(0x100b_82f8, 0xc0);              /* call 0x100b82f8 */
            ii(0x100b_8238, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_823b, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_823d, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_823e, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_823f, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_8240, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_8241, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100b_8242, 1);  ret();                                /* ret */
        }
    }
}
