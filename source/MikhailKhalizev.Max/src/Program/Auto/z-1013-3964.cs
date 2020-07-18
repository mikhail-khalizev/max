using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_3964-f04bdcdb")]
        public void Method_1013_3964()
        {
            ii(0x1013_3964, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1013_3969, 5);  call(Definitions.sys_check_available_stack_size, 0x3_23e4);/* call 0x10165d52 */
            ii(0x1013_396e, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_396f, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_3970, 1);  push(edx);                            /* push edx */
            ii(0x1013_3971, 1);  push(esi);                            /* push esi */
            ii(0x1013_3972, 1);  push(edi);                            /* push edi */
            ii(0x1013_3973, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_3974, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_3976, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1013_397c, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1013_397f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_3982, 4);  mov(ax, memw[ds, eax + 25]);          /* mov ax, [eax+0x19] */
            ii(0x1013_3986, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_3989, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_398c, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_398e, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_398f, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_3990, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_3991, 1);  pop(edx);                             /* pop edx */
            ii(0x1013_3992, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_3993, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_3994, 1);  ret();                                /* ret */
        }
    }
}
