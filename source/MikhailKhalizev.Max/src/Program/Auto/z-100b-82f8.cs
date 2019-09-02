using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_82f8-2a29964e")]
        public void Method_100b_82f8()
        {
            ii(0x100b_82f8, 5); push(0x28);                             /* push 0x28 */
            ii(0x100b_82fd, 5); call(Definitions.sys_check_available_stack_size, 0xa_da50); /* call 0x10165d52 */
            ii(0x100b_8302, 1); push(ecx);                              /* push ecx */
            ii(0x100b_8303, 1); push(esi);                              /* push esi */
            ii(0x100b_8304, 1); push(edi);                              /* push edi */
            ii(0x100b_8305, 1); push(ebp);                              /* push ebp */
            ii(0x100b_8306, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_8308, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100b_830e, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100b_8311, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x100b_8314, 3); mov(memb[ss, ebp - 4], bl);             /* mov [ebp-0x4], bl */
            ii(0x100b_8317, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_8319, 3); mov(bl, memb[ss, ebp - 4]);             /* mov bl, [ebp-0x4] */
            ii(0x100b_831c, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100b_831f, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_8322, 5); call(0x1013_afb8, 0x8_2c91);            /* call 0x1013afb8 */
            ii(0x100b_8327, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100b_832a, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100b_832d, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100b_8330, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_8333, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100b_8336, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100b_8339, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_833b, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_833c, 1); pop(edi);                               /* pop edi */
            ii(0x100b_833d, 1); pop(esi);                               /* pop esi */
            ii(0x100b_833e, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_833f, 1); ret();                                  /* ret */
        }
    }
}
