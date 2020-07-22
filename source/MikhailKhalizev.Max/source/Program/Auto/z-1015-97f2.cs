using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_97f2-59a0399")]
        public void Method_1015_97f2()
        {
            ii(0x1015_97f2, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1015_97f7, 5);  call(Definitions.sys_check_available_stack_size, 0xc556);/* call 0x10165d52 */
            ii(0x1015_97fc, 1);  push(ebx);                            /* push ebx */
            ii(0x1015_97fd, 1);  push(ecx);                            /* push ecx */
            ii(0x1015_97fe, 1);  push(esi);                            /* push esi */
            ii(0x1015_97ff, 1);  push(edi);                            /* push edi */
            ii(0x1015_9800, 1);  push(ebp);                            /* push ebp */
            ii(0x1015_9801, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1015_9803, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1015_9809, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1015_980c, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1015_980f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_9812, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1015_9815, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1015_981a, 5);  call(0x100f_448c, -0x6_5393);         /* call 0x100f448c */
            ii(0x1015_981f, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1015_9822, 4);  cmp(memb[ds, eax + 87], 9);           /* cmp byte [eax+0x57], 0x9 */
            ii(0x1015_9826, 2);  if(jnz(0x1015_9831, 9)) goto l_0x1015_9831;/* jnz 0x10159831 */
            ii(0x1015_9828, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1015_982b, 4);  mov(memb[ds, eax + 87], 0);           /* mov byte [eax+0x57], 0x0 */
            ii(0x1015_982f, 2);  jmp(0x1015_9838, 7); goto l_0x1015_9838;/* jmp 0x10159838 */
        l_0x1015_9831:
            ii(0x1015_9831, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1015_9834, 4);  mov(memb[ds, eax + 87], 9);           /* mov byte [eax+0x57], 0x9 */
        l_0x1015_9838:
            ii(0x1015_9838, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1015_983a, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1015_983b, 1);  pop(edi);                             /* pop edi */
            ii(0x1015_983c, 1);  pop(esi);                             /* pop esi */
            ii(0x1015_983d, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1015_983e, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1015_983f, 1);  ret();                                /* ret */
        }
    }
}
