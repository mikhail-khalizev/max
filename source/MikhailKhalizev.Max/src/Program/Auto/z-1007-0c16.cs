using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_0c16-97865c4e")]
        public void Method_1007_0c16()
        {
            ii(0x1007_0c16, 5); push(0x24);                             /* push 0x24 */
            ii(0x1007_0c1b, 5); call(Definitions.sys_check_available_stack_size, 0xf_5132); /* call 0x10165d52 */
            ii(0x1007_0c20, 1); push(ebx);                              /* push ebx */
            ii(0x1007_0c21, 1); push(ecx);                              /* push ecx */
            ii(0x1007_0c22, 1); push(esi);                              /* push esi */
            ii(0x1007_0c23, 1); push(edi);                              /* push edi */
            ii(0x1007_0c24, 1); push(ebp);                              /* push ebp */
            ii(0x1007_0c25, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_0c27, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_0c2d, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1007_0c30, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1007_0c33, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1007_0c36, 4); imul(edx, memd[ss, ebp - 8]);           /* imul edx, [ebp-0x8] */
            ii(0x1007_0c3a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_0c3d, 4); imul(eax, memd[ss, ebp - 4]);           /* imul eax, [ebp-0x4] */
            ii(0x1007_0c41, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1007_0c43, 3); mov(memd[ss, ebp - 12], edx);           /* mov [ebp-0xc], edx */
            ii(0x1007_0c46, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1007_0c49, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_0c4b, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_0c4c, 1); pop(edi);                               /* pop edi */
            ii(0x1007_0c4d, 1); pop(esi);                               /* pop esi */
            ii(0x1007_0c4e, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_0c4f, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_0c50, 1); ret();                                  /* ret */
        }
    }
}
