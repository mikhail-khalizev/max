using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_97c8-3416bd4f")]
        public void my_strobj_c_str_v2()
        {
            ii(0x1008_97c8, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1008_97cd, 5);  call(Definitions.sys_check_available_stack_size, 0xd_c580);/* call 0x10165d52 */
            ii(0x1008_97d2, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_97d3, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_97d4, 1);  push(edx);                            /* push edx */
            ii(0x1008_97d5, 1);  push(esi);                            /* push esi */
            ii(0x1008_97d6, 1);  push(edi);                            /* push edi */
            ii(0x1008_97d7, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_97d8, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_97da, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1008_97e0, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_97e3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_97e6, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1008_97e8, 5);  call(Definitions.my_strobj_c_str, 0xf);/* call 0x100897fc */
            ii(0x1008_97ed, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_97f0, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_97f3, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_97f5, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_97f6, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_97f7, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_97f8, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_97f9, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_97fa, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_97fb, 1);  ret();                                /* ret */
        }
    }
}
