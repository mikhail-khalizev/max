using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_7330-1887b472")]
        public void Method_1014_7330()
        {
            ii(0x1014_7330, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1014_7335, 5);  call(Definitions.sys_check_available_stack_size, 0x1_ea18);/* call 0x10165d52 */
            ii(0x1014_733a, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_733b, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_733c, 1);  push(esi);                            /* push esi */
            ii(0x1014_733d, 1);  push(edi);                            /* push edi */
            ii(0x1014_733e, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_733f, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_7341, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1014_7347, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_734a, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_734d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_7350, 5);  call(0x1013_bfc1, -0xb394);           /* call 0x1013bfc1 */
            ii(0x1014_7355, 5);  mov(edx, StringDefinitions.Wt2);      /* mov edx, 0x101ad118 */
            ii(0x1014_735a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_735d, 5);  call(Definitions.sys_fopen, 0x2_b018);/* call 0x1017237a */
            ii(0x1014_7362, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1014_7364, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_7367, 2);  mov(memd[ds, eax], edx);              /* mov [eax], edx */
            ii(0x1014_7369, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_736c, 6);  mov(memw[ds, eax + 14], 0);           /* mov word [eax+0xe], 0x0 */
            ii(0x1014_7372, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_7375, 3);  cmp(memd[ds, eax], 0);                /* cmp dword [eax], 0x0 */
            ii(0x1014_7378, 2);  if(jz(0x1014_7380, 6)) goto l_0x1014_7380;/* jz 0x10147380 */
            ii(0x1014_737a, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x1014_737e, 2);  jmp(0x1014_7384, 4); goto l_0x1014_7384;/* jmp 0x10147384 */
        l_0x1014_7380:
            ii(0x1014_7380, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
        l_0x1014_7384:
            ii(0x1014_7384, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1014_7387, 3);  mov(memb[ss, ebp - 16], al);          /* mov [ebp-0x10], al */
            ii(0x1014_738a, 3);  mov(al, memb[ss, ebp - 16]);          /* mov al, [ebp-0x10] */
            ii(0x1014_738d, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_738f, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_7390, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_7391, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_7392, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_7393, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_7394, 1);  ret();                                /* ret */
        }
    }
}
