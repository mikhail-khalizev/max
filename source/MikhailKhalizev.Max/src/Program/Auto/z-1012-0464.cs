using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_0464-8e4c14cb")]
        public void Method_1012_0464()
        {
            ii(0x1012_0464, 5); push(0x24);                             /* push 0x24 */
            ii(0x1012_0469, 5); call(Definitions.sys_check_available_stack_size, 0x4_58e4); /* call 0x10165d52 */
            ii(0x1012_046e, 1); push(ebx);                              /* push ebx */
            ii(0x1012_046f, 1); push(ecx);                              /* push ecx */
            ii(0x1012_0470, 1); push(esi);                              /* push esi */
            ii(0x1012_0471, 1); push(edi);                              /* push edi */
            ii(0x1012_0472, 1); push(ebp);                              /* push ebp */
            ii(0x1012_0473, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_0475, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1012_047b, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_047e, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1012_0481, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1012_0486, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_0489, 5); call(0x1007_5e24, -0xa_a66a);           /* call 0x10075e24 */
            ii(0x1012_048e, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_0491, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_0494, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1012_0497, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1012_049a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_049c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_049d, 1); pop(edi);                               /* pop edi */
            ii(0x1012_049e, 1); pop(esi);                               /* pop esi */
            ii(0x1012_049f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_04a0, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_04a1, 1); ret();                                  /* ret */
        }
    }
}
