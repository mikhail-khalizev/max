using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_8eb9-cba61bda")]
        public void Method_1015_8eb9()
        {
            ii(0x1015_8eb9, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1015_8ebe, 5);  call(Definitions.sys_check_available_stack_size, 0xce8f);/* call 0x10165d52 */
            ii(0x1015_8ec3, 1);  push(ebx);                            /* push ebx */
            ii(0x1015_8ec4, 1);  push(ecx);                            /* push ecx */
            ii(0x1015_8ec5, 1);  push(esi);                            /* push esi */
            ii(0x1015_8ec6, 1);  push(edi);                            /* push edi */
            ii(0x1015_8ec7, 1);  push(ebp);                            /* push ebp */
            ii(0x1015_8ec8, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1015_8eca, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1015_8ed0, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1015_8ed3, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1015_8ed6, 5);  mov(eax, 0x1015_8e5a);                /* mov eax, 0x10158e5a */
            ii(0x1015_8edb, 1);  push(eax);                            /* push eax */
            ii(0x1015_8edc, 5);  mov(ecx, 0x33);                       /* mov ecx, 0x33 */
            ii(0x1015_8ee1, 5);  mov(ebx, StringDefinitions.Attack2);  /* mov ebx, 0x101b2504 */
            ii(0x1015_8ee6, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_8ee9, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1015_8eeb, 3);  mov(dl, memb[ds, eax + 85]);          /* mov dl, [eax+0x55] */
            ii(0x1015_8eee, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_8ef1, 5);  call(0x1015_7ccf, -0x1227);           /* call 0x10157ccf */
            ii(0x1015_8ef6, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_8ef9, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_8efc, 5);  call(0x1015_8bbb, -0x346);            /* call 0x10158bbb */
            ii(0x1015_8f01, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1015_8f03, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1015_8f04, 1);  pop(edi);                             /* pop edi */
            ii(0x1015_8f05, 1);  pop(esi);                             /* pop esi */
            ii(0x1015_8f06, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1015_8f07, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1015_8f08, 1);  ret();                                /* ret */
        }
    }
}
