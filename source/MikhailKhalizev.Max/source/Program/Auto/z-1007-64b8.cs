using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_64b8-a3b6500d")]
        public void Method_1007_64b8()
        {
            ii(0x1007_64b8, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1007_64bd, 5);  call(Definitions.sys_check_available_stack_size, 0xe_f890);/* call 0x10165d52 */
            ii(0x1007_64c2, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_64c3, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_64c4, 1);  push(esi);                            /* push esi */
            ii(0x1007_64c5, 1);  push(edi);                            /* push edi */
            ii(0x1007_64c6, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_64c7, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_64c9, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1007_64cf, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_64d2, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_64d5, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_64d8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_64db, 5);  call(0x1007_6d14, 0x834);             /* call 0x10076d14 */
            ii(0x1007_64e0, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_64e3, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1007_64e6, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1007_64e9, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_64ec, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_64ef, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_64f2, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_64f4, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_64f5, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_64f6, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_64f7, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_64f8, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_64f9, 1);  ret();                                /* ret */
        }
    }
}
