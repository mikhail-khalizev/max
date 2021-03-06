using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_8dbf-58803f89")]
        public void Method_1010_8dbf()
        {
            ii(0x1010_8dbf, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1010_8dc4, 5);  call(Definitions.sys_check_available_stack_size, 0x5_cf89);/* call 0x10165d52 */
            ii(0x1010_8dc9, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_8dca, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_8dcb, 1);  push(edx);                            /* push edx */
            ii(0x1010_8dcc, 1);  push(esi);                            /* push esi */
            ii(0x1010_8dcd, 1);  push(edi);                            /* push edi */
            ii(0x1010_8dce, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_8dcf, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_8dd1, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1010_8dd7, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_8dda, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_8ddd, 4);  mov(ax, memw[ds, eax + 13]);          /* mov ax, [eax+0xd] */
            ii(0x1010_8de1, 1);  inc(eax);                             /* inc eax */
            ii(0x1010_8de2, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1010_8de5, 4);  mov(memw[ds, edx + 11], ax);          /* mov [edx+0xb], ax */
            ii(0x1010_8de9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_8dec, 5);  call(0x1010_8b99, -0x258);            /* call 0x10108b99 */
            ii(0x1010_8df1, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_8df3, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_8df4, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_8df5, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_8df6, 1);  pop(edx);                             /* pop edx */
            ii(0x1010_8df7, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_8df8, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_8df9, 1);  ret();                                /* ret */
        }
    }
}
