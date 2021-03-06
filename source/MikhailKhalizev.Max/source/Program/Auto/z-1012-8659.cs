using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_8659-b7d4dcf3")]
        public void Method_1012_8659()
        {
            ii(0x1012_8659, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1012_865e, 5);  call(Definitions.sys_check_available_stack_size, 0x3_d6ef);/* call 0x10165d52 */
            ii(0x1012_8663, 1);  push(ebx);                            /* push ebx */
            ii(0x1012_8664, 1);  push(ecx);                            /* push ecx */
            ii(0x1012_8665, 1);  push(edx);                            /* push edx */
            ii(0x1012_8666, 1);  push(esi);                            /* push esi */
            ii(0x1012_8667, 1);  push(edi);                            /* push edi */
            ii(0x1012_8668, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_8669, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_866b, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1012_8671, 7);  mov(memb[ds, 0x101c_5866], 0);        /* mov byte [0x101c5866], 0x0 */
            ii(0x1012_8678, 5);  call(0x1012_75ed, -0x1090);           /* call 0x101275ed */
            ii(0x1012_867d, 5);  call(0x1014_82f4, 0x1_fc72);          /* call 0x101482f4 */
            ii(0x1012_8682, 5);  mov(memd[ds, 0x101c_61a4], eax);      /* mov [0x101c61a4], eax */
            ii(0x1012_8687, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1012_8689, 5);  mov(al, memb[ds, 0x101c_5866]);       /* mov al, [0x101c5866] */
            ii(0x1012_868e, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1012_8691, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_8694, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_8696, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_8697, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_8698, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_8699, 1);  pop(edx);                             /* pop edx */
            ii(0x1012_869a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1012_869b, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1012_869c, 1);  ret();                                /* ret */
        }
    }
}
