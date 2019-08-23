using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_b7e4-8fb7cbab")]
        public void Method_100c_b7e4()
        {
            ii(0x100c_b7e4, 5); push(0x20);                             /* push 0x20 */
            ii(0x100c_b7e9, 5); call(Definitions.sys_check_available_stack_size, 0x9_a564); /* call 0x10165d52 */
            ii(0x100c_b7ee, 1); push(ebx);                              /* push ebx */
            ii(0x100c_b7ef, 1); push(ecx);                              /* push ecx */
            ii(0x100c_b7f0, 1); push(edx);                              /* push edx */
            ii(0x100c_b7f1, 1); push(esi);                              /* push esi */
            ii(0x100c_b7f2, 1); push(edi);                              /* push edi */
            ii(0x100c_b7f3, 1); push(ebp);                              /* push ebp */
            ii(0x100c_b7f4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b7f6, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100c_b7fc, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100c_b7ff, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_b802, 4); cmp(memb[ds, eax + 0x23], 0);           /* cmp byte [eax+0x23], 0x0 */
            ii(0x100c_b806, 2); if(jz(0x100c_b80f, 0x7)) goto l_0x100c_b80f; /* jz 0x100cb80f */
            ii(0x100c_b808, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_b80b, 4); inc(memw[ds, eax + 0x21]);              /* inc word [eax+0x21] */
        l_0x100c_b80f:
            ii(0x100c_b80f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b811, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_b812, 1); pop(edi);                               /* pop edi */
            ii(0x100c_b813, 1); pop(esi);                               /* pop esi */
            ii(0x100c_b814, 1); pop(edx);                               /* pop edx */
            ii(0x100c_b815, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_b816, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_b817, 1); ret();                                  /* ret */
        }
    }
}
