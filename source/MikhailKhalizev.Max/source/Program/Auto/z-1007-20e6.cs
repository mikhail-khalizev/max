using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_20e6-8df88080")]
        public void Method_1007_20e6()
        {
            ii(0x1007_20e6, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1007_20eb, 5);  call(Definitions.sys_check_available_stack_size, 0xf_3c62);/* call 0x10165d52 */
            ii(0x1007_20f0, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_20f1, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_20f2, 1);  push(edx);                            /* push edx */
            ii(0x1007_20f3, 1);  push(esi);                            /* push esi */
            ii(0x1007_20f4, 1);  push(edi);                            /* push edi */
            ii(0x1007_20f5, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_20f6, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_20f8, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1007_20fe, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_2101, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_2104, 5);  mov(memw[ds, eax], 0);                /* mov word [eax], 0x0 */
            ii(0x1007_2109, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_210c, 6);  mov(memw[ds, eax + 2], 0);            /* mov word [eax+0x2], 0x0 */
            ii(0x1007_2112, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_2115, 6);  mov(memw[ds, eax + 4], 0);            /* mov word [eax+0x4], 0x0 */
            ii(0x1007_211b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_211e, 6);  mov(memw[ds, eax + 6], 0);            /* mov word [eax+0x6], 0x0 */
            ii(0x1007_2124, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_2127, 6);  mov(memw[ds, eax + 8], 0);            /* mov word [eax+0x8], 0x0 */
            ii(0x1007_212d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_2130, 6);  mov(memw[ds, eax + 10], 0);           /* mov word [eax+0xa], 0x0 */
            ii(0x1007_2136, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_2138, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_2139, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_213a, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_213b, 1);  pop(edx);                             /* pop edx */
            ii(0x1007_213c, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_213d, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_213e, 1);  ret();                                /* ret */
        }
    }
}
