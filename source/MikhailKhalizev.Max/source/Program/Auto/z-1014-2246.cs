using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_2246-d4d0fd2c")]
        public void Method_1014_2246()
        {
            ii(0x1014_2246, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1014_224b, 5);  call(Definitions.sys_check_available_stack_size, 0x2_3b02);/* call 0x10165d52 */
            ii(0x1014_2250, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_2251, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_2252, 1);  push(esi);                            /* push esi */
            ii(0x1014_2253, 1);  push(edi);                            /* push edi */
            ii(0x1014_2254, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_2255, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_2257, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1014_225d, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_2260, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_2263, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_2266, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1014_2268, 5);  call(Definitions.my_string_add_ref, 0x1f7);/* call 0x10142464 */
            ii(0x1014_226d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_2270, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1014_2272, 5);  call(Definitions.my_string_release, 0x1a5);/* call 0x1014241c */
            ii(0x1014_2277, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_227a, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x1014_227c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_227f, 2);  mov(memd[ds, eax], edx);              /* mov [eax], edx */
            ii(0x1014_2281, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_2284, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1014_2287, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_228a, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_228c, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_228d, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_228e, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_228f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_2290, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_2291, 1);  ret();                                /* ret */
        }
    }
}
