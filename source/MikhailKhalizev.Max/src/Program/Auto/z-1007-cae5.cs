using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_cae5-fef57c2e")]
        public void Method_1007_cae5()
        {
            ii(0x1007_cae5, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1007_caea, 5);  call(Definitions.sys_check_available_stack_size, 0xe_9263);/* call 0x10165d52 */
            ii(0x1007_caef, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_caf0, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_caf1, 1);  push(edx);                            /* push edx */
            ii(0x1007_caf2, 1);  push(esi);                            /* push esi */
            ii(0x1007_caf3, 1);  push(edi);                            /* push edi */
            ii(0x1007_caf4, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_caf5, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_caf7, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1007_cafd, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_cb00, 4);  mov(memb[ss, ebp - 8], 6);            /* mov byte [ebp-0x8], 0x6 */
            ii(0x1007_cb04, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x1007_cb07, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_cb09, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_cb0a, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_cb0b, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_cb0c, 1);  pop(edx);                             /* pop edx */
            ii(0x1007_cb0d, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_cb0e, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_cb0f, 1);  ret();                                /* ret */
        }
    }
}
