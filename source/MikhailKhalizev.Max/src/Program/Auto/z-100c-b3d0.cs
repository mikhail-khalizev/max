using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_b3d0-5f218927")]
        public void Method_100c_b3d0()
        {
            ii(0x100c_b3d0, 5); push(0x28);                             /* push 0x28 */
            ii(0x100c_b3d5, 5); call(Definitions.sys_check_available_stack_size, 0x9_a978); /* call 0x10165d52 */
            ii(0x100c_b3da, 1); push(ecx);                              /* push ecx */
            ii(0x100c_b3db, 1); push(esi);                              /* push esi */
            ii(0x100c_b3dc, 1); push(edi);                              /* push edi */
            ii(0x100c_b3dd, 1); push(ebp);                              /* push ebp */
            ii(0x100c_b3de, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b3e0, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100c_b3e6, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100c_b3e9, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x100c_b3ec, 3); mov(memb[ss, ebp - 4], bl);             /* mov [ebp-0x4], bl */
            ii(0x100c_b3ef, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_b3f1, 3); mov(bl, memb[ss, ebp - 4]);             /* mov bl, [ebp-0x4] */
            ii(0x100c_b3f4, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100c_b3f7, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100c_b3fa, 5); call(0x1013_afb8, 0x6_fbb9);            /* call 0x1013afb8 */
            ii(0x100c_b3ff, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100c_b402, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100c_b405, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_b408, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100c_b40b, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100c_b40e, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_b411, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b413, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_b414, 1); pop(edi);                               /* pop edi */
            ii(0x100c_b415, 1); pop(esi);                               /* pop esi */
            ii(0x100c_b416, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_b417, 1); ret();                                  /* ret */
        }
    }
}
