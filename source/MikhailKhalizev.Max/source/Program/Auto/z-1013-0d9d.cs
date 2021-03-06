using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_0d9d-44d844ee")]
        public void Method_1013_0d9d()
        {
            ii(0x1013_0d9d, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1013_0da2, 5);  call(Definitions.sys_check_available_stack_size, 0x3_4fab);/* call 0x10165d52 */
            ii(0x1013_0da7, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_0da8, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_0da9, 1);  push(esi);                            /* push esi */
            ii(0x1013_0daa, 1);  push(edi);                            /* push edi */
            ii(0x1013_0dab, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_0dac, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_0dae, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1013_0db4, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_0db7, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_0dba, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_0dbd, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_0dc0, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_0dc3, 4);  cmp(memb[ds, eax + 23], 3);           /* cmp byte [eax+0x17], 0x3 */
            ii(0x1013_0dc7, 2);  if(jz(0x1013_0ddd, 0x14)) goto l_0x1013_0ddd;/* jz 0x10130ddd */
            ii(0x1013_0dc9, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_0dcc, 4);  mov(memb[ds, eax + 23], 3);           /* mov byte [eax+0x17], 0x3 */
            ii(0x1013_0dd0, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1013_0dd5, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_0dd8, 5);  call(0x1013_0c16, -0x1c7);            /* call 0x10130c16 */
        l_0x1013_0ddd:
            ii(0x1013_0ddd, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_0ddf, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_0de0, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_0de1, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_0de2, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_0de3, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_0de4, 1);  ret();                                /* ret */
        }
    }
}
