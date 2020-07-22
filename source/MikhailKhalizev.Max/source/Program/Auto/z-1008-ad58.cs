using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_ad58-12f4e129")]
        public void Method_1008_ad58()
        {
            ii(0x1008_ad58, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1008_ad5d, 5);  call(Definitions.sys_check_available_stack_size, 0xd_aff0);/* call 0x10165d52 */
            ii(0x1008_ad62, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_ad63, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_ad64, 1);  push(edx);                            /* push edx */
            ii(0x1008_ad65, 1);  push(esi);                            /* push esi */
            ii(0x1008_ad66, 1);  push(edi);                            /* push edi */
            ii(0x1008_ad67, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_ad68, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_ad6a, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1008_ad70, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_ad73, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_ad76, 3);  add(eax, 0xf);                        /* add eax, 0xf */
            ii(0x1008_ad79, 5);  call(0x1008_afb4, 0x236);             /* call 0x1008afb4 */
            ii(0x1008_ad7e, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_ad81, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_ad84, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_ad86, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_ad87, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_ad88, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_ad89, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_ad8a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_ad8b, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_ad8c, 1);  ret();                                /* ret */
        }
    }
}
