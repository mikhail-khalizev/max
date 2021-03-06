using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_b434-3adf4d7a")]
        public void Method_100a_b434()
        {
            ii(0x100a_b434, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100a_b439, 5);  call(Definitions.sys_check_available_stack_size, 0xb_a914);/* call 0x10165d52 */
            ii(0x100a_b43e, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_b43f, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_b440, 1);  push(esi);                            /* push esi */
            ii(0x100a_b441, 1);  push(edi);                            /* push edi */
            ii(0x100a_b442, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_b443, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_b445, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x100a_b44b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_b44e, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_b451, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_b454, 3);  movsx(edx, memw[ds, eax]);            /* movsx edx, word [eax] */
            ii(0x100a_b457, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_b45a, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x100a_b45d, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x100a_b45f, 2);  if(jnz(0x100a_b475, 0x14)) goto l_0x100a_b475;/* jnz 0x100ab475 */
            ii(0x100a_b461, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_b464, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x100a_b466, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100a_b469, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_b46c, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100a_b46e, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100a_b471, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x100a_b473, 2);  if(jz(0x100a_b477, 2)) goto l_0x100a_b477;/* jz 0x100ab477 */
        l_0x100a_b475:
            ii(0x100a_b475, 2);  jmp(0x100a_b47d, 6); goto l_0x100a_b47d;/* jmp 0x100ab47d */
        l_0x100a_b477:
            ii(0x100a_b477, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x100a_b47b, 2);  jmp(0x100a_b481, 4); goto l_0x100a_b481;/* jmp 0x100ab481 */
        l_0x100a_b47d:
            ii(0x100a_b47d, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
        l_0x100a_b481:
            ii(0x100a_b481, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x100a_b484, 3);  mov(memb[ss, ebp - 16], al);          /* mov [ebp-0x10], al */
            ii(0x100a_b487, 3);  mov(al, memb[ss, ebp - 16]);          /* mov al, [ebp-0x10] */
            ii(0x100a_b48a, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_b48c, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_b48d, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_b48e, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_b48f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_b490, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_b491, 1);  ret();                                /* ret */
        }
    }
}
