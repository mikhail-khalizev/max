using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_9600-5bb1d8f2")]
        public void Method_1008_9600()
        {
            ii(0x1008_9600, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1008_9605, 5);  call(Definitions.sys_check_available_stack_size, 0xd_c748);/* call 0x10165d52 */
            ii(0x1008_960a, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_960b, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_960c, 1);  push(esi);                            /* push esi */
            ii(0x1008_960d, 1);  push(edi);                            /* push edi */
            ii(0x1008_960e, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_960f, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_9611, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1008_9617, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_961a, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1008_961d, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1008_9622, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_9625, 5);  call(Definitions.my_dtor_0x101b_6edc, 0xb_161b);/* call 0x1013ac45 */
            ii(0x1008_962a, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_962d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_9630, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1008_9633, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1008_9636, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_9638, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_9639, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_963a, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_963b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_963c, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_963d, 1);  ret();                                /* ret */
        }
    }
}
