using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_f2f4-43b29d04")]
        public void Method_100d_f2f4()
        {
            ii(0x100d_f2f4, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100d_f2f9, 5);  call(Definitions.sys_check_available_stack_size, 0x8_6a54);/* call 0x10165d52 */
            ii(0x100d_f2fe, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_f2ff, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_f300, 1);  push(esi);                            /* push esi */
            ii(0x100d_f301, 1);  push(edi);                            /* push edi */
            ii(0x100d_f302, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_f303, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_f305, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100d_f30b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_f30e, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100d_f311, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100d_f314, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_f317, 5);  add(eax, 0x2f0);                      /* add eax, 0x2f0 */
            ii(0x100d_f31c, 5);  call(0x100e_0c54, 0x1933);            /* call 0x100e0c54 */
            ii(0x100d_f321, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_f323, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_f324, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_f325, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_f326, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_f327, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_f328, 1);  ret();                                /* ret */
        }
    }
}
