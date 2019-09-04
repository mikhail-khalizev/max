using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_ce23-62c9673d")]
        public void Method_1008_ce23()
        {
            ii(0x1008_ce23, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1008_ce28, 5);  call(Definitions.sys_check_available_stack_size, 0xd_8f25);/* call 0x10165d52 */
            ii(0x1008_ce2d, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_ce2e, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_ce2f, 1);  push(edx);                            /* push edx */
            ii(0x1008_ce30, 1);  push(esi);                            /* push esi */
            ii(0x1008_ce31, 1);  push(edi);                            /* push edi */
            ii(0x1008_ce32, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_ce33, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_ce35, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1008_ce3b, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_ce3e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_ce41, 3);  mov(eax, memd[ds, eax + 34]);         /* mov eax, [eax+0x22] */
            ii(0x1008_ce44, 3);  sar(eax, 0x18);                       /* sar eax, 0x18 */
            ii(0x1008_ce47, 3);  cmp(eax, 9);                          /* cmp eax, 0x9 */
            ii(0x1008_ce4a, 2);  if(jl(0x1008_ce52, 6)) goto l_0x1008_ce52;/* jl 0x1008ce52 */
            ii(0x1008_ce4c, 4);  mov(memb[ss, ebp - 8], 1);            /* mov byte [ebp-0x8], 0x1 */
            ii(0x1008_ce50, 2);  jmp(0x1008_ce56, 4); goto l_0x1008_ce56;/* jmp 0x1008ce56 */
        l_0x1008_ce52:
            ii(0x1008_ce52, 4);  mov(memb[ss, ebp - 8], 0);            /* mov byte [ebp-0x8], 0x0 */
        l_0x1008_ce56:
            ii(0x1008_ce56, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x1008_ce59, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x1008_ce5c, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1008_ce5f, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_ce61, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_ce62, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_ce63, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_ce64, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_ce65, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_ce66, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_ce67, 1);  ret();                                /* ret */
        }
    }
}
