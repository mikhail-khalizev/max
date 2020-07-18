using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_aa4c-79aabe44")]
        public void Method_1008_aa4c()
        {
            ii(0x1008_aa4c, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1008_aa51, 5);  call(Definitions.sys_check_available_stack_size, 0xd_b2fc);/* call 0x10165d52 */
            ii(0x1008_aa56, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_aa57, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_aa58, 1);  push(edx);                            /* push edx */
            ii(0x1008_aa59, 1);  push(esi);                            /* push esi */
            ii(0x1008_aa5a, 1);  push(edi);                            /* push edi */
            ii(0x1008_aa5b, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_aa5c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_aa5e, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1008_aa64, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_aa67, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_aa6a, 6);  mov(al, memb[ds, eax + 166]);         /* mov al, [eax+0xa6] */
            ii(0x1008_aa70, 3);  mov(memb[ss, ebp - 8], al);           /* mov [ebp-0x8], al */
            ii(0x1008_aa73, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x1008_aa76, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_aa78, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_aa79, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_aa7a, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_aa7b, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_aa7c, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_aa7d, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_aa7e, 1);  ret();                                /* ret */
        }
    }
}
