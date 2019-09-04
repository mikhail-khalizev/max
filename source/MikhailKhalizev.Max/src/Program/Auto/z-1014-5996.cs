using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_5996-285ef267")]
        public void Method_1014_5996()
        {
            ii(0x1014_5996, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1014_599b, 5);  call(Definitions.sys_check_available_stack_size, 0x2_03b2);/* call 0x10165d52 */
            ii(0x1014_59a0, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_59a1, 1);  push(esi);                            /* push esi */
            ii(0x1014_59a2, 1);  push(edi);                            /* push edi */
            ii(0x1014_59a3, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_59a4, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_59a6, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x1014_59ac, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1014_59af, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1014_59b2, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1014_59b5, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1014_59b8, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_59bb, 5);  call(0x1014_5725, -0x29b);            /* call 0x10145725 */
            ii(0x1014_59c0, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1014_59c3, 4);  cmp(memd[ss, ebp - 20], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1014_59c7, 2);  if(jnz(0x1014_59cf, 6)) goto l_0x1014_59cf;/* jnz 0x101459cf */
            ii(0x1014_59c9, 4);  mov(memb[ss, ebp - 16], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x1014_59cd, 2);  jmp(0x1014_59e3, 0x14); goto l_0x1014_59e3;/* jmp 0x101459e3 */
        l_0x1014_59cf:
            ii(0x1014_59cf, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1014_59d2, 5);  call(0x1014_7c10, 0x2239);            /* call 0x10147c10 */
            ii(0x1014_59d7, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1014_59d9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_59dc, 3);  mov(memw[ds, eax], dx);               /* mov [eax], dx */
            ii(0x1014_59df, 4);  mov(memb[ss, ebp - 16], 1);           /* mov byte [ebp-0x10], 0x1 */
        l_0x1014_59e3:
            ii(0x1014_59e3, 3);  mov(al, memb[ss, ebp - 16]);          /* mov al, [ebp-0x10] */
            ii(0x1014_59e6, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_59e8, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_59e9, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_59ea, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_59eb, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_59ec, 1);  ret();                                /* ret */
        }
    }
}
