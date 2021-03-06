using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_ad28-698aa9f4")]
        public void Method_1008_ad28()
        {
            ii(0x1008_ad28, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1008_ad2d, 5);  call(Definitions.sys_check_available_stack_size, 0xd_b020);/* call 0x10165d52 */
            ii(0x1008_ad32, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_ad33, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_ad34, 1);  push(edx);                            /* push edx */
            ii(0x1008_ad35, 1);  push(esi);                            /* push esi */
            ii(0x1008_ad36, 1);  push(edi);                            /* push edi */
            ii(0x1008_ad37, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_ad38, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_ad3a, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1008_ad40, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_ad43, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_ad46, 3);  mov(al, memb[ds, eax + 8]);           /* mov al, [eax+0x8] */
            ii(0x1008_ad49, 3);  mov(memb[ss, ebp - 8], al);           /* mov [ebp-0x8], al */
            ii(0x1008_ad4c, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x1008_ad4f, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_ad51, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_ad52, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_ad53, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_ad54, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_ad55, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_ad56, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_ad57, 1);  ret();                                /* ret */
        }
    }
}
