using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_89b7-95b3da6")]
        public void Method_1009_89b7()
        {
            ii(0x1009_89b7, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1009_89bc, 5);  call(Definitions.sys_check_available_stack_size, 0xc_d391);/* call 0x10165d52 */
            ii(0x1009_89c1, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_89c2, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_89c3, 1);  push(edx);                            /* push edx */
            ii(0x1009_89c4, 1);  push(esi);                            /* push esi */
            ii(0x1009_89c5, 1);  push(edi);                            /* push edi */
            ii(0x1009_89c6, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_89c7, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_89c9, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1009_89cf, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_89d2, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_89d5, 3);  mov(eax, memd[ds, eax + 26]);         /* mov eax, [eax+0x1a] */
            ii(0x1009_89d8, 3);  sar(eax, 0x18);                       /* sar eax, 0x18 */
            ii(0x1009_89db, 3);  cmp(eax, 3);                          /* cmp eax, 0x3 */
            ii(0x1009_89de, 2);  if(jl(0x1009_89e6, 6)) goto l_0x1009_89e6;/* jl 0x100989e6 */
            ii(0x1009_89e0, 4);  mov(memb[ss, ebp - 8], 1);            /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_89e4, 2);  jmp(0x1009_89ea, 4); goto l_0x1009_89ea;/* jmp 0x100989ea */
        l_0x1009_89e6:
            ii(0x1009_89e6, 4);  mov(memb[ss, ebp - 8], 0);            /* mov byte [ebp-0x8], 0x0 */
        l_0x1009_89ea:
            ii(0x1009_89ea, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x1009_89ed, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x1009_89f0, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1009_89f3, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_89f5, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_89f6, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_89f7, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_89f8, 1);  pop(edx);                             /* pop edx */
            ii(0x1009_89f9, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_89fa, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_89fb, 1);  ret();                                /* ret */
        }
    }
}
