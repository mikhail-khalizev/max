using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_7294-d5b4cc31")]
        public void Method_100b_7294()
        {
            ii(0x100b_7294, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100b_7299, 5);  call(Definitions.sys_check_available_stack_size, 0xa_eab4);/* call 0x10165d52 */
            ii(0x100b_729e, 1);  push(ebx);                            /* push ebx */
            ii(0x100b_729f, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_72a0, 1);  push(esi);                            /* push esi */
            ii(0x100b_72a1, 1);  push(edi);                            /* push edi */
            ii(0x100b_72a2, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_72a3, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_72a5, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100b_72ab, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_72ae, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100b_72b1, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x100b_72b6, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_72b9, 5);  call(0x1008_8a84, -0x2_e83a);         /* call 0x10088a84 */
            ii(0x100b_72be, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_72c1, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_72c4, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100b_72c7, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100b_72ca, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_72cc, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_72cd, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_72ce, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_72cf, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_72d0, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100b_72d1, 1);  ret();                                /* ret */
        }
    }
}
