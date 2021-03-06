using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_02a0-6e3405ed")]
        public void Method_100b_02a0()
        {
            ii(0x100b_02a0, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100b_02a5, 5);  call(Definitions.sys_check_available_stack_size, 0xb_5aa8);/* call 0x10165d52 */
            ii(0x100b_02aa, 1);  push(ebx);                            /* push ebx */
            ii(0x100b_02ab, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_02ac, 1);  push(edx);                            /* push edx */
            ii(0x100b_02ad, 1);  push(esi);                            /* push esi */
            ii(0x100b_02ae, 1);  push(edi);                            /* push edi */
            ii(0x100b_02af, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_02b0, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_02b2, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x100b_02b8, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100b_02bb, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100b_02be, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_02c1, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x100b_02c4, 5);  call(0x1007_6574, -0x3_9d55);         /* call 0x10076574 */
            ii(0x100b_02c9, 5);  call(0x1015_27ed, 0xa_251f);          /* call 0x101527ed */
            ii(0x100b_02ce, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_02d1, 6);  mov(memw[ds, eax + 27], 2);           /* mov word [eax+0x1b], 0x2 */
            ii(0x100b_02d7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_02da, 6);  mov(memw[ds, eax + 29], 0);           /* mov word [eax+0x1d], 0x0 */
            ii(0x100b_02e0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_02e3, 6);  mov(memw[ds, eax + 31], 2);           /* mov word [eax+0x1f], 0x2 */
            ii(0x100b_02e9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_02ec, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x100b_02ef, 5);  call(0x1007_6574, -0x3_9d80);         /* call 0x10076574 */
            ii(0x100b_02f4, 4);  mov(ax, memw[ds, eax + 26]);          /* mov ax, [eax+0x1a] */
            ii(0x100b_02f8, 1);  dec(eax);                             /* dec eax */
            ii(0x100b_02f9, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100b_02fc, 4);  mov(memw[ds, edx + 33], ax);          /* mov [edx+0x21], ax */
            ii(0x100b_0300, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_0303, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x100b_0306, 5);  call(0x1007_6574, -0x3_9d97);         /* call 0x10076574 */
            ii(0x100b_030b, 4);  mov(ax, memw[ds, eax + 28]);          /* mov ax, [eax+0x1c] */
            ii(0x100b_030f, 1);  inc(eax);                             /* inc eax */
            ii(0x100b_0310, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100b_0313, 4);  mov(memw[ds, edx + 35], ax);          /* mov [edx+0x23], ax */
            ii(0x100b_0317, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_031a, 4);  mov(memb[ds, eax + 37], 0);           /* mov byte [eax+0x25], 0x0 */
            ii(0x100b_031e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_0321, 5);  call(0x100b_0383, 0x5d);              /* call 0x100b0383 */
            ii(0x100b_0326, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_0328, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_0329, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_032a, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_032b, 1);  pop(edx);                             /* pop edx */
            ii(0x100b_032c, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_032d, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100b_032e, 1);  ret();                                /* ret */
        }
    }
}
