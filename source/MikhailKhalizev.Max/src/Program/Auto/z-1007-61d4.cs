using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_61d4-b7fa4fbf")]
        public void Method_1007_61d4()
        {
            ii(0x1007_61d4, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1007_61d9, 5);  call(Definitions.sys_check_available_stack_size, 0xe_fb74);/* call 0x10165d52 */
            ii(0x1007_61de, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_61df, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_61e0, 1);  push(edx);                            /* push edx */
            ii(0x1007_61e1, 1);  push(esi);                            /* push esi */
            ii(0x1007_61e2, 1);  push(edi);                            /* push edi */
            ii(0x1007_61e3, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_61e4, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_61e6, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1007_61ec, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_61ef, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_61f2, 3);  mov(eax, memd[ds, eax + 126]);        /* mov eax, [eax+0x7e] */
            ii(0x1007_61f5, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_61f8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_61fb, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_61fd, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_61fe, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_61ff, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_6200, 1);  pop(edx);                             /* pop edx */
            ii(0x1007_6201, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_6202, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_6203, 1);  ret();                                /* ret */
        }
    }
}
