using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_7dd4-48d1d562")]
        public void Method_1011_7dd4()
        {
            ii(0x1011_7dd4, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1011_7dd9, 5);  call(Definitions.sys_check_available_stack_size, 0x4_df74);/* call 0x10165d52 */
            ii(0x1011_7dde, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_7ddf, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_7de0, 1);  push(edx);                            /* push edx */
            ii(0x1011_7de1, 1);  push(esi);                            /* push esi */
            ii(0x1011_7de2, 1);  push(edi);                            /* push edi */
            ii(0x1011_7de3, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_7de4, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_7de6, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1011_7dec, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1011_7def, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_7df2, 5);  call(0x1007_6d58, -0xa_109f);         /* call 0x10076d58 */
            ii(0x1011_7df7, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1011_7dfa, 3);  lea(eax, memd[ss, ebp - 4]);          /* lea eax, [ebp-0x4] */
            ii(0x1011_7dfd, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_7e00, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_7e03, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1011_7e06, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_7e09, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_7e0b, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_7e0c, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_7e0d, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_7e0e, 1);  pop(edx);                             /* pop edx */
            ii(0x1011_7e0f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_7e10, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_7e11, 1);  ret();                                /* ret */
        }
    }
}
