using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_8746-e952b186")]
        public void Method_100c_8746()
        {
            ii(0x100c_8746, 5); push(0x28);                             /* push 0x28 */
            ii(0x100c_874b, 5); call(Definitions.sys_check_available_stack_size, 0x9_d602); /* call 0x10165d52 */
            ii(0x100c_8750, 1); push(ebx);                              /* push ebx */
            ii(0x100c_8751, 1); push(ecx);                              /* push ecx */
            ii(0x100c_8752, 1); push(esi);                              /* push esi */
            ii(0x100c_8753, 1); push(edi);                              /* push edi */
            ii(0x100c_8754, 1); push(ebp);                              /* push ebp */
            ii(0x100c_8755, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_8757, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100c_875d, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_8760, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100c_8763, 5); mov(ecx, 0x1a00);                       /* mov ecx, 0x1a00 */
            ii(0x100c_8768, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_876a, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100c_876e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_8771, 5); call(0x100a_26d1, -0x2_60a5);           /* call 0x100a26d1 */
            ii(0x100c_8776, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_8779, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x100c_877c, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100c_877f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_8782, 7); mov(memd[ds, eax + 0x2], 0x101b_5878);  /* mov dword [eax+0x2], 0x101b5878 */
            ii(0x100c_8789, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_878c, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_878f, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_8792, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_8794, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_8795, 1); pop(edi);                               /* pop edi */
            ii(0x100c_8796, 1); pop(esi);                               /* pop esi */
            ii(0x100c_8797, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_8798, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_8799, 1); ret();                                  /* ret */
        }
    }
}
