using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_5280-80ec4f88")]
        public void Method_1015_5280()
        {
            ii(0x1015_5280, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1015_5285, 5);  call(Definitions.sys_check_available_stack_size, 0x1_0ac8);/* call 0x10165d52 */
            ii(0x1015_528a, 1);  push(ebx);                            /* push ebx */
            ii(0x1015_528b, 1);  push(ecx);                            /* push ecx */
            ii(0x1015_528c, 1);  push(esi);                            /* push esi */
            ii(0x1015_528d, 1);  push(edi);                            /* push edi */
            ii(0x1015_528e, 1);  push(ebp);                            /* push ebp */
            ii(0x1015_528f, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1015_5291, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1015_5297, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1015_529a, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1015_529d, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_52a0, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_52a3, 5);  call(0x1013_acc5, -0x1_a5e3);         /* call 0x1013acc5 */
            ii(0x1015_52a8, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1015_52ab, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1015_52ae, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1015_52b0, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1015_52b1, 1);  pop(edi);                             /* pop edi */
            ii(0x1015_52b2, 1);  pop(esi);                             /* pop esi */
            ii(0x1015_52b3, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1015_52b4, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1015_52b5, 1);  ret();                                /* ret */
        }
    }
}
