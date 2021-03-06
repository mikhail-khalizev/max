using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_d2ee-ead348dc")]
        public void Method_1009_d2ee()
        {
            ii(0x1009_d2ee, 5);  push(0x30);                           /* push 0x30 */
            ii(0x1009_d2f3, 5);  call(Definitions.sys_check_available_stack_size, 0xc_8a5a);/* call 0x10165d52 */
            ii(0x1009_d2f8, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_d2f9, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_d2fa, 1);  push(esi);                            /* push esi */
            ii(0x1009_d2fb, 1);  push(edi);                            /* push edi */
            ii(0x1009_d2fc, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_d2fd, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_d2ff, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1009_d305, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_d308, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_d30b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_d30e, 3);  mov(eax, memd[ds, eax + 53]);         /* mov eax, [eax+0x35] */
            ii(0x1009_d311, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1009_d314, 1);  push(eax);                            /* push eax */
            ii(0x1009_d315, 5);  mov(eax, StringDefinitions.FindSearchSquareRadiusI);/* mov eax, 0x101a0778 */
            ii(0x1009_d31a, 1);  push(eax);                            /* push eax */
            ii(0x1009_d31b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_d31e, 1);  push(eax);                            /* push eax */
            ii(0x1009_d31f, 5);  call(Definitions.sys_sprintf, 0xc_8bdd);/* call 0x10165f01 */
            ii(0x1009_d324, 3);  add(esp, 0xc);                        /* add esp, 0xc */
            ii(0x1009_d327, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_d32a, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1009_d32d, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1009_d330, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_d332, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_d333, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_d334, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_d335, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_d336, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_d337, 1);  ret();                                /* ret */
        }
    }
}
