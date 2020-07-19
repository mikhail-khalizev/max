using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_6154-245ff19b")]
        public void Method_1007_6154()
        {
            ii(0x1007_6154, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1007_6159, 5);  call(Definitions.sys_check_available_stack_size, 0xe_fbf4);/* call 0x10165d52 */
            ii(0x1007_615e, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_615f, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_6160, 1);  push(edx);                            /* push edx */
            ii(0x1007_6161, 1);  push(esi);                            /* push esi */
            ii(0x1007_6162, 1);  push(edi);                            /* push edi */
            ii(0x1007_6163, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_6164, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_6166, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1007_616c, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_616f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_6172, 4);  mov(ax, memw[ds, eax + 124]);         /* mov ax, [eax+0x7c] */
            ii(0x1007_6176, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_6179, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_617c, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_617e, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_617f, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_6180, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_6181, 1);  pop(edx);                             /* pop edx */
            ii(0x1007_6182, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_6183, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_6184, 1);  ret();                                /* ret */
        }
    }
}
