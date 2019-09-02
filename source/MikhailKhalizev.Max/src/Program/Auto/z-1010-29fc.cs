using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_29fc-9debaa38")]
        public void Method_1010_29fc()
        {
            ii(0x1010_29fc, 5); push(0x24);                             /* push 0x24 */
            ii(0x1010_2a01, 5); call(Definitions.sys_check_available_stack_size, 0x6_334c); /* call 0x10165d52 */
            ii(0x1010_2a06, 1); push(ebx);                              /* push ebx */
            ii(0x1010_2a07, 1); push(ecx);                              /* push ecx */
            ii(0x1010_2a08, 1); push(esi);                              /* push esi */
            ii(0x1010_2a09, 1); push(edi);                              /* push edi */
            ii(0x1010_2a0a, 1); push(ebp);                              /* push ebp */
            ii(0x1010_2a0b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_2a0d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1010_2a13, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1010_2a16, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1010_2a19, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_2a1c, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1010_2a1e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_2a21, 2); mov(memd[ds, eax], edx);                /* mov [eax], edx */
            ii(0x1010_2a23, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_2a26, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1010_2a29, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1010_2a2c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_2a2e, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_2a2f, 1); pop(edi);                               /* pop edi */
            ii(0x1010_2a30, 1); pop(esi);                               /* pop esi */
            ii(0x1010_2a31, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_2a32, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_2a33, 1); ret();                                  /* ret */
        }
    }
}
