using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_aa04-fc343a9e")]
        public void Method_1008_aa04()
        {
            ii(0x1008_aa04, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1008_aa09, 5);  call(Definitions.sys_check_available_stack_size, 0xd_b344);/* call 0x10165d52 */
            ii(0x1008_aa0e, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_aa0f, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_aa10, 1);  push(edx);                            /* push edx */
            ii(0x1008_aa11, 1);  push(esi);                            /* push esi */
            ii(0x1008_aa12, 1);  push(edi);                            /* push edi */
            ii(0x1008_aa13, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_aa14, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_aa16, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1008_aa1c, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_aa1f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_aa22, 6);  mov(eax, memd[ds, eax + 161]);        /* mov eax, [eax+0xa1] */
            ii(0x1008_aa28, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1008_aa2b, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1008_aa2d, 2);  if(jle(0x1008_aa35, 6)) goto l_0x1008_aa35;/* jle 0x1008aa35 */
            ii(0x1008_aa2f, 4);  mov(memb[ss, ebp - 8], 1);            /* mov byte [ebp-0x8], 0x1 */
            ii(0x1008_aa33, 2);  jmp(0x1008_aa39, 4); goto l_0x1008_aa39;/* jmp 0x1008aa39 */
        l_0x1008_aa35:
            ii(0x1008_aa35, 4);  mov(memb[ss, ebp - 8], 0);            /* mov byte [ebp-0x8], 0x0 */
        l_0x1008_aa39:
            ii(0x1008_aa39, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x1008_aa3c, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x1008_aa3f, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1008_aa42, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_aa44, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_aa45, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_aa46, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_aa47, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_aa48, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_aa49, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_aa4a, 1);  ret();                                /* ret */
        }
    }
}
