using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_88cc-2b6bd0f6")]
        public void Method_100a_88cc()
        {
            ii(0x100a_88cc, 5); push(0x24);                             /* push 0x24 */
            ii(0x100a_88d1, 5); call(Definitions.sys_check_available_stack_size, 0xb_d47c); /* call 0x10165d52 */
            ii(0x100a_88d6, 1); push(ebx);                              /* push ebx */
            ii(0x100a_88d7, 1); push(ecx);                              /* push ecx */
            ii(0x100a_88d8, 1); push(edx);                              /* push edx */
            ii(0x100a_88d9, 1); push(esi);                              /* push esi */
            ii(0x100a_88da, 1); push(edi);                              /* push edi */
            ii(0x100a_88db, 1); push(ebp);                              /* push ebp */
            ii(0x100a_88dc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_88de, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100a_88e4, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100a_88e7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_88ea, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_88ed, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_88f0, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x100a_88f3, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_88f6, 3); call_abs(memd[ds, edx + 0x3c]);         /* call dword [edx+0x3c] */
            ii(0x100a_88f9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_88fb, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_88fc, 1); pop(edi);                               /* pop edi */
            ii(0x100a_88fd, 1); pop(esi);                               /* pop esi */
            ii(0x100a_88fe, 1); pop(edx);                               /* pop edx */
            ii(0x100a_88ff, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_8900, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_8901, 1); ret();                                  /* ret */
        }
    }
}
