using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_4d3b-dd4bb79c")]
        public void Method_100b_4d3b()
        {
            ii(0x100b_4d3b, 5); push(0x20);                             /* push 0x20 */
            ii(0x100b_4d40, 5); call(Definitions.sys_check_available_stack_size, 0xb_100d); /* call 0x10165d52 */
            ii(0x100b_4d45, 1); push(ebx);                              /* push ebx */
            ii(0x100b_4d46, 1); push(ecx);                              /* push ecx */
            ii(0x100b_4d47, 1); push(edx);                              /* push edx */
            ii(0x100b_4d48, 1); push(esi);                              /* push esi */
            ii(0x100b_4d49, 1); push(edi);                              /* push edi */
            ii(0x100b_4d4a, 1); push(ebp);                              /* push ebp */
            ii(0x100b_4d4b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_4d4d, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100b_4d53, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100b_4d56, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_4d58, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_4d5b, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_4d5e, 5); call(0x1007_6630, -0x3_e733);           /* call 0x10076630 */
            ii(0x100b_4d63, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_4d65, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_4d68, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_4d6b, 5); call(0x1007_6630, -0x3_e740);           /* call 0x10076630 */
            ii(0x100b_4d70, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_4d72, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_4d75, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100b_4d78, 5); call(0x1008_afe4, -0x2_9d99);           /* call 0x1008afe4 */
            ii(0x100b_4d7d, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100b_4d80, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_4d85, 5); call(0x100a_5e27, -0xef63);             /* call 0x100a5e27 */
            ii(0x100b_4d8a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_4d8c, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_4d8d, 1); pop(edi);                               /* pop edi */
            ii(0x100b_4d8e, 1); pop(esi);                               /* pop esi */
            ii(0x100b_4d8f, 1); pop(edx);                               /* pop edx */
            ii(0x100b_4d90, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_4d91, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_4d92, 1); ret();                                  /* ret */
        }
    }
}
