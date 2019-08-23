using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_a514-d7f041bc")]
        public void Method_100a_a514()
        {
            ii(0x100a_a514, 5); push(0x24);                             /* push 0x24 */
            ii(0x100a_a519, 5); call(Definitions.sys_check_available_stack_size, 0xb_b834); /* call 0x10165d52 */
            ii(0x100a_a51e, 1); push(ebx);                              /* push ebx */
            ii(0x100a_a51f, 1); push(ecx);                              /* push ecx */
            ii(0x100a_a520, 1); push(esi);                              /* push esi */
            ii(0x100a_a521, 1); push(edi);                              /* push edi */
            ii(0x100a_a522, 1); push(ebp);                              /* push ebp */
            ii(0x100a_a523, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_a525, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_a52b, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_a52e, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_a531, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_a534, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_a537, 5); call(0x1007_5e64, -0x3_46d8);           /* call 0x10075e64 */
            ii(0x100a_a53c, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_a53f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_a542, 3); mov(edx, memd[ds, eax + 0x4]);          /* mov edx, [eax+0x4] */
            ii(0x100a_a545, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_a548, 3); mov(memd[ds, eax + 0x4], edx);          /* mov [eax+0x4], edx */
            ii(0x100a_a54b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_a54e, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_a551, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_a554, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_a556, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_a557, 1); pop(edi);                               /* pop edi */
            ii(0x100a_a558, 1); pop(esi);                               /* pop esi */
            ii(0x100a_a559, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_a55a, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_a55b, 1); ret();                                  /* ret */
        }
    }
}
