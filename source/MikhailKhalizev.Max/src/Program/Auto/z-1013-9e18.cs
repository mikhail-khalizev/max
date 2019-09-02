using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_9e18-19dd12fc")]
        public void Method_1013_9e18()
        {
            ii(0x1013_9e18, 5); push(0x24);                             /* push 0x24 */
            ii(0x1013_9e1d, 5); call(Definitions.sys_check_available_stack_size, 0x2_bf30); /* call 0x10165d52 */
            ii(0x1013_9e22, 1); push(ebx);                              /* push ebx */
            ii(0x1013_9e23, 1); push(ecx);                              /* push ecx */
            ii(0x1013_9e24, 1); push(esi);                              /* push esi */
            ii(0x1013_9e25, 1); push(edi);                              /* push edi */
            ii(0x1013_9e26, 1); push(ebp);                              /* push ebp */
            ii(0x1013_9e27, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_9e29, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_9e2f, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_9e32, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1013_9e35, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_9e37, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_9e3a, 3); add(eax, 0x12);                         /* add eax, 0x12 */
            ii(0x1013_9e3d, 5); call(0x1013_9d0c, -0x136);              /* call 0x10139d0c */
            ii(0x1013_9e42, 3); sub(eax, 0x12);                         /* sub eax, 0x12 */
            ii(0x1013_9e45, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_9e48, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_9e4a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_9e4d, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1013_9e50, 5); call(0x100e_03fc, -0x5_9a59);           /* call 0x100e03fc */
            ii(0x1013_9e55, 3); sub(eax, 0xe);                          /* sub eax, 0xe */
            ii(0x1013_9e58, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_9e5b, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1013_9e60, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_9e63, 5); call(0x1013_b997, 0x1b2f);              /* call 0x1013b997 */
            ii(0x1013_9e68, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_9e6b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_9e6e, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1013_9e71, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_9e74, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_9e76, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_9e77, 1); pop(edi);                               /* pop edi */
            ii(0x1013_9e78, 1); pop(esi);                               /* pop esi */
            ii(0x1013_9e79, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_9e7a, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_9e7b, 1); ret();                                  /* ret */
        }
    }
}
