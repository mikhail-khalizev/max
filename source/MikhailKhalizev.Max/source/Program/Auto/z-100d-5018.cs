using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_5018-dba8eeb4")]
        public void Method_100d_5018()
        {
            ii(0x100d_5018, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100d_501d, 5);  call(Definitions.sys_check_available_stack_size, 0x9_0d30);/* call 0x10165d52 */
            ii(0x100d_5022, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_5023, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_5024, 1);  push(edx);                            /* push edx */
            ii(0x100d_5025, 1);  push(esi);                            /* push esi */
            ii(0x100d_5026, 1);  push(edi);                            /* push edi */
            ii(0x100d_5027, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_5028, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_502a, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100d_5030, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100d_5033, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_5036, 4);  mov(ax, memw[ds, eax + 38]);          /* mov ax, [eax+0x26] */
            ii(0x100d_503a, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_503d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_5040, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_5042, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_5043, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_5044, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_5045, 1);  pop(edx);                             /* pop edx */
            ii(0x100d_5046, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_5047, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_5048, 1);  ret();                                /* ret */
        }
    }
}
