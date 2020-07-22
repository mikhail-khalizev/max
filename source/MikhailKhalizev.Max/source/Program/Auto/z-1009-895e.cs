using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_895e-9e375ec6")]
        public void Method_1009_895e()
        {
            ii(0x1009_895e, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1009_8963, 5);  call(Definitions.sys_check_available_stack_size, 0xc_d3ea);/* call 0x10165d52 */
            ii(0x1009_8968, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_8969, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_896a, 1);  push(edx);                            /* push edx */
            ii(0x1009_896b, 1);  push(esi);                            /* push esi */
            ii(0x1009_896c, 1);  push(edi);                            /* push edi */
            ii(0x1009_896d, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_896e, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_8970, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1009_8976, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_8979, 7);  mov(memd[ss, ebp - 8], 4);            /* mov dword [ebp-0x8], 0x4 */
            ii(0x1009_8980, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_8983, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_8985, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_8986, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_8987, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_8988, 1);  pop(edx);                             /* pop edx */
            ii(0x1009_8989, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_898a, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_898b, 1);  ret();                                /* ret */
        }
    }
}
