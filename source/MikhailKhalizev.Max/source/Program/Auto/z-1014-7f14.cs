using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_7f14-6dcef96b")]
        public void Method_1014_7f14()
        {
            ii(0x1014_7f14, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1014_7f19, 5);  call(Definitions.sys_check_available_stack_size, 0x1_de34);/* call 0x10165d52 */
            ii(0x1014_7f1e, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_7f1f, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_7f20, 1);  push(edx);                            /* push edx */
            ii(0x1014_7f21, 1);  push(esi);                            /* push esi */
            ii(0x1014_7f22, 1);  push(edi);                            /* push edi */
            ii(0x1014_7f23, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_7f24, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_7f26, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1014_7f2c, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1014_7f2f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_7f32, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1014_7f34, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_7f37, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_7f3a, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_7f3c, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_7f3d, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_7f3e, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_7f3f, 1);  pop(edx);                             /* pop edx */
            ii(0x1014_7f40, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_7f41, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_7f42, 1);  ret();                                /* ret */
        }
    }
}
