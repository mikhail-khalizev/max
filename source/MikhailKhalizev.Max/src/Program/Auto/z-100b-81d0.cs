using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_81d0-2c2dab99")]
        public void Method_100b_81d0()
        {
            ii(0x100b_81d0, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100b_81d5, 5);  call(Definitions.sys_check_available_stack_size, 0xa_db78);/* call 0x10165d52 */
            ii(0x100b_81da, 1);  push(ebx);                            /* push ebx */
            ii(0x100b_81db, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_81dc, 1);  push(edx);                            /* push edx */
            ii(0x100b_81dd, 1);  push(esi);                            /* push esi */
            ii(0x100b_81de, 1);  push(edi);                            /* push edi */
            ii(0x100b_81df, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_81e0, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_81e2, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100b_81e8, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100b_81eb, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_81ee, 5);  call(0x1007_6c30, -0x4_15c3);         /* call 0x10076c30 */
            ii(0x100b_81f3, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_81f6, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_81f9, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_81fb, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_81fc, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_81fd, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_81fe, 1);  pop(edx);                             /* pop edx */
            ii(0x100b_81ff, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_8200, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100b_8201, 1);  ret();                                /* ret */
        }
    }
}
