using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_4fbc-8dced36c")]
        public void Method_100d_4fbc()
        {
            ii(0x100d_4fbc, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100d_4fc1, 5);  call(Definitions.sys_check_available_stack_size, 0x9_0d8c);/* call 0x10165d52 */
            ii(0x100d_4fc6, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_4fc7, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_4fc8, 1);  push(edx);                            /* push edx */
            ii(0x100d_4fc9, 1);  push(esi);                            /* push esi */
            ii(0x100d_4fca, 1);  push(edi);                            /* push edi */
            ii(0x100d_4fcb, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_4fcc, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_4fce, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100d_4fd4, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100d_4fd7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_4fda, 3);  mov(eax, memd[ds, eax + 4]);          /* mov eax, [eax+0x4] */
            ii(0x100d_4fdd, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_4fe0, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_4fe3, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_4fe5, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_4fe6, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_4fe7, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_4fe8, 1);  pop(edx);                             /* pop edx */
            ii(0x100d_4fe9, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_4fea, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_4feb, 1);  ret();                                /* ret */
        }
    }
}