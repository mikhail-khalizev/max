using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_8b42-c48a8b8e")]
        public void Method_100b_8b42()
        {
            ii(0x100b_8b42, 5); push(0x28);                             /* push 0x28 */
            ii(0x100b_8b47, 5); call(Definitions.sys_check_available_stack_size, 0xa_d206); /* call 0x10165d52 */
            ii(0x100b_8b4c, 1); push(ecx);                              /* push ecx */
            ii(0x100b_8b4d, 1); push(esi);                              /* push esi */
            ii(0x100b_8b4e, 1); push(edi);                              /* push edi */
            ii(0x100b_8b4f, 1); push(ebp);                              /* push ebp */
            ii(0x100b_8b50, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_8b52, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100b_8b58, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100b_8b5b, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x100b_8b5e, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x100b_8b61, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x100b_8b64, 3); add(edx, 0xd);                          /* add edx, 0xd */
            ii(0x100b_8b67, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x100b_8b6a, 5); call(0x1007_5e64, -0x4_2d0b);           /* call 0x10075e64 */
            ii(0x100b_8b6f, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100b_8b71, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100b_8b74, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x100b_8b77, 5); call(0x1007_5e64, -0x4_2d18);           /* call 0x10075e64 */
            ii(0x100b_8b7c, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100b_8b7e, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100b_8b81, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100b_8b84, 5); call(0x100b_89ad, -0x1dc);              /* call 0x100b89ad */
            ii(0x100b_8b89, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_8b8c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_8b8e, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_8b8f, 1); pop(edi);                               /* pop edi */
            ii(0x100b_8b90, 1); pop(esi);                               /* pop esi */
            ii(0x100b_8b91, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_8b92, 1); ret();                                  /* ret */
        }
    }
}
