using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_6074-e043241")]
        public void Method_1007_6074()
        {
            ii(0x1007_6074, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1007_6079, 5);  call(Definitions.sys_check_available_stack_size, 0xe_fcd4);/* call 0x10165d52 */
            ii(0x1007_607e, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_607f, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_6080, 1);  push(esi);                            /* push esi */
            ii(0x1007_6081, 1);  push(edi);                            /* push edi */
            ii(0x1007_6082, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_6083, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_6085, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1007_608b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_608e, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_6091, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1007_6095, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1007_6098, 6);  mov(al, memb[ds, eax + 171]);         /* mov al, [eax+0xab] */
            ii(0x1007_609e, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x1007_60a1, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1007_60a4, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_60a6, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_60a7, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_60a8, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_60a9, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_60aa, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_60ab, 1);  ret();                                /* ret */
        }
    }
}
