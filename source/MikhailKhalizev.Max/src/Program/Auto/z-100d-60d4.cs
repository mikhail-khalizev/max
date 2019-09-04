using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_60d4-36e95938")]
        public void Method_100d_60d4()
        {
            ii(0x100d_60d4, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100d_60d9, 5);  call(Definitions.sys_check_available_stack_size, 0x8_fc74);/* call 0x10165d52 */
            ii(0x100d_60de, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_60df, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_60e0, 1);  push(esi);                            /* push esi */
            ii(0x100d_60e1, 1);  push(edi);                            /* push edi */
            ii(0x100d_60e2, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_60e3, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_60e5, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100d_60eb, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_60ee, 3);  mov(memb[ss, ebp - 4], dl);           /* mov [ebp-0x4], dl */
            ii(0x100d_60f1, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x100d_60f4, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100d_60f7, 3);  mov(memb[ds, edx + 53], al);          /* mov [edx+0x35], al */
            ii(0x100d_60fa, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_60fc, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_60fd, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_60fe, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_60ff, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_6100, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_6101, 1);  ret();                                /* ret */
        }
    }
}
