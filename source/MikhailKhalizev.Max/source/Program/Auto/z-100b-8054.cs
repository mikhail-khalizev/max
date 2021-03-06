using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_8054-6680b163")]
        public void Method_100b_8054()
        {
            ii(0x100b_8054, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100b_8059, 5);  call(Definitions.sys_check_available_stack_size, 0xa_dcf4);/* call 0x10165d52 */
            ii(0x100b_805e, 1);  push(ebx);                            /* push ebx */
            ii(0x100b_805f, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_8060, 1);  push(edx);                            /* push edx */
            ii(0x100b_8061, 1);  push(esi);                            /* push esi */
            ii(0x100b_8062, 1);  push(edi);                            /* push edi */
            ii(0x100b_8063, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_8064, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_8066, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100b_806c, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100b_806f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_8072, 3);  add(eax, 0x16);                       /* add eax, 0x16 */
            ii(0x100b_8075, 5);  call(0x1007_65d0, -0x4_1aaa);         /* call 0x100765d0 */
            ii(0x100b_807a, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_807d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_8080, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_8082, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_8083, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_8084, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_8085, 1);  pop(edx);                             /* pop edx */
            ii(0x100b_8086, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_8087, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100b_8088, 1);  ret();                                /* ret */
        }
    }
}
