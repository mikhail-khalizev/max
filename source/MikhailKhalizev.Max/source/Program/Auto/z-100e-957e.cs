using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_957e-362966df")]
        public void Method_100e_957e()
        {
            ii(0x100e_957e, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100e_9583, 5);  call(Definitions.sys_check_available_stack_size, 0x7_c7ca);/* call 0x10165d52 */
            ii(0x100e_9588, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_9589, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_958a, 1);  push(esi);                            /* push esi */
            ii(0x100e_958b, 1);  push(edi);                            /* push edi */
            ii(0x100e_958c, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_958d, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_958f, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100e_9595, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_9598, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100e_959b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_959e, 5);  call(0x100e_94f6, -0xad);             /* call 0x100e94f6 */
            ii(0x100e_95a3, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_95a6, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100e_95a9, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100e_95ac, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_95ae, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_95af, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_95b0, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_95b1, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_95b2, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_95b3, 1);  ret();                                /* ret */
        }
    }
}
