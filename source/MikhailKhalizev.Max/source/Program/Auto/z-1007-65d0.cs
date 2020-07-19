using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_65d0-98729621")]
        public void Method_1007_65d0()
        {
            ii(0x1007_65d0, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1007_65d5, 5);  call(Definitions.sys_check_available_stack_size, 0xe_f778);/* call 0x10165d52 */
            ii(0x1007_65da, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_65db, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_65dc, 1);  push(edx);                            /* push edx */
            ii(0x1007_65dd, 1);  push(esi);                            /* push esi */
            ii(0x1007_65de, 1);  push(edi);                            /* push edi */
            ii(0x1007_65df, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_65e0, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_65e2, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1007_65e8, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_65eb, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_65ee, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1007_65f0, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_65f3, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_65f6, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_65f8, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_65f9, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_65fa, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_65fb, 1);  pop(edx);                             /* pop edx */
            ii(0x1007_65fc, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_65fd, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_65fe, 1);  ret();                                /* ret */
        }
    }
}
