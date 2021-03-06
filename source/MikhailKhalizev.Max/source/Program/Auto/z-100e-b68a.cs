using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_b68a-a314283e")]
        public void Method_100e_b68a()
        {
            ii(0x100e_b68a, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100e_b68f, 5);  call(Definitions.sys_check_available_stack_size, 0x7_a6be);/* call 0x10165d52 */
            ii(0x100e_b694, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_b695, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_b696, 1);  push(edx);                            /* push edx */
            ii(0x100e_b697, 1);  push(esi);                            /* push esi */
            ii(0x100e_b698, 1);  push(edi);                            /* push edi */
            ii(0x100e_b699, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_b69a, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_b69c, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x100e_b6a2, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100e_b6a5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_b6a8, 3);  mov(edx, memd[ds, eax + 35]);         /* mov edx, [eax+0x23] */
            ii(0x100e_b6ab, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_b6ae, 3);  mov(eax, memd[ds, eax + 31]);         /* mov eax, [eax+0x1f] */
            ii(0x100e_b6b1, 5);  call(Definitions.sys_strcpy, 0x7_a819);/* call 0x10165ecf */
            ii(0x100e_b6b6, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_b6b8, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_b6b9, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_b6ba, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_b6bb, 1);  pop(edx);                             /* pop edx */
            ii(0x100e_b6bc, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_b6bd, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_b6be, 1);  ret();                                /* ret */
        }
    }
}
