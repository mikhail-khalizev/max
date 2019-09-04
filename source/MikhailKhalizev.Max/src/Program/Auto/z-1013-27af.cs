using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_27af-5b656d29")]
        public void Method_1013_27af()
        {
            ii(0x1013_27af, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1013_27b4, 5);  call(Definitions.sys_check_available_stack_size, 0x3_3599);/* call 0x10165d52 */
            ii(0x1013_27b9, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_27ba, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_27bb, 1);  push(esi);                            /* push esi */
            ii(0x1013_27bc, 1);  push(edi);                            /* push edi */
            ii(0x1013_27bd, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_27be, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_27c0, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1013_27c6, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_27c9, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_27cc, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_27cf, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_27d2, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_27d5, 4);  mov(ax, memw[ds, eax + 5]);           /* mov ax, [eax+0x5] */
            ii(0x1013_27d9, 1);  inc(eax);                             /* inc eax */
            ii(0x1013_27da, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1013_27dd, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_27e0, 5);  call(0x1013_2705, -0xe0);             /* call 0x10132705 */
            ii(0x1013_27e5, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_27e7, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_27e8, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_27e9, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_27ea, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_27eb, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_27ec, 1);  ret();                                /* ret */
        }
    }
}
