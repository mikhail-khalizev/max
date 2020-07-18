using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_3671-2b240dd")]
        public void Method_100a_3671()
        {
            ii(0x100a_3671, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100a_3676, 5);  call(Definitions.sys_check_available_stack_size, 0xc_26d7);/* call 0x10165d52 */
            ii(0x100a_367b, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_367c, 1);  push(esi);                            /* push esi */
            ii(0x100a_367d, 1);  push(edi);                            /* push edi */
            ii(0x100a_367e, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_367f, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_3681, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x100a_3687, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100a_368a, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100a_368d, 3);  mov(memb[ss, ebp - 4], bl);           /* mov [ebp-0x4], bl */
            ii(0x100a_3690, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100a_3693, 4);  cmp(memb[ds, eax + 6], 0);            /* cmp byte [eax+0x6], 0x0 */
            ii(0x100a_3697, 2);  if(jz(0x100a_36ac, 0x13)) goto l_0x100a_36ac;/* jz 0x100a36ac */
            ii(0x100a_3699, 4);  movsx(ebx, memb[ss, ebp - 4]);        /* movsx ebx, byte [ebp-0x4] */
            ii(0x100a_369d, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100a_36a0, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100a_36a3, 5);  call(0x100a_346a, -0x23e);            /* call 0x100a346a */
            ii(0x100a_36a8, 2);  test(al, al);                         /* test al, al */
            ii(0x100a_36aa, 2);  if(jnz(0x100a_36ae, 2)) goto l_0x100a_36ae;/* jnz 0x100a36ae */
        l_0x100a_36ac:
            ii(0x100a_36ac, 2);  jmp(0x100a_36bb, 0xd); goto l_0x100a_36bb;/* jmp 0x100a36bb */
        l_0x100a_36ae:
            ii(0x100a_36ae, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100a_36b1, 4);  mov(memb[ds, eax + 6], 0);            /* mov byte [eax+0x6], 0x0 */
            ii(0x100a_36b5, 4);  mov(memb[ss, ebp - 16], 1);           /* mov byte [ebp-0x10], 0x1 */
            ii(0x100a_36b9, 2);  jmp(0x100a_36bf, 4); goto l_0x100a_36bf;/* jmp 0x100a36bf */
        l_0x100a_36bb:
            ii(0x100a_36bb, 4);  mov(memb[ss, ebp - 16], 0);           /* mov byte [ebp-0x10], 0x0 */
        l_0x100a_36bf:
            ii(0x100a_36bf, 3);  mov(al, memb[ss, ebp - 16]);          /* mov al, [ebp-0x10] */
            ii(0x100a_36c2, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_36c4, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_36c5, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_36c6, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_36c7, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_36c8, 1);  ret();                                /* ret */
        }
    }
}
