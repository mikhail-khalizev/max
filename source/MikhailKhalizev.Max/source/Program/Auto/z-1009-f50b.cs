using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_f50b-834f9843")]
        public void Method_1009_f50b()
        {
            ii(0x1009_f50b, 5);  push(0x30);                           /* push 0x30 */
            ii(0x1009_f510, 5);  call(Definitions.sys_check_available_stack_size, 0xc_683d);/* call 0x10165d52 */
            ii(0x1009_f515, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_f516, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_f517, 1);  push(esi);                            /* push esi */
            ii(0x1009_f518, 1);  push(edi);                            /* push edi */
            ii(0x1009_f519, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_f51a, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_f51c, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1009_f522, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_f525, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_f528, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_f52b, 3);  mov(eax, memd[ds, eax + 25]);         /* mov eax, [eax+0x19] */
            ii(0x1009_f52e, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1009_f531, 1);  push(eax);                            /* push eax */
            ii(0x1009_f532, 5);  mov(eax, StringDefinitions.AutoSurveyRadiusI);/* mov eax, 0x101a07d1 */
            ii(0x1009_f537, 1);  push(eax);                            /* push eax */
            ii(0x1009_f538, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_f53b, 1);  push(eax);                            /* push eax */
            ii(0x1009_f53c, 5);  call(Definitions.sys_sprintf, 0xc_69c0);/* call 0x10165f01 */
            ii(0x1009_f541, 3);  add(esp, 0xc);                        /* add esp, 0xc */
            ii(0x1009_f544, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_f547, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1009_f54a, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1009_f54d, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_f54f, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_f550, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_f551, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_f552, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_f553, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_f554, 1);  ret();                                /* ret */
        }
    }
}
