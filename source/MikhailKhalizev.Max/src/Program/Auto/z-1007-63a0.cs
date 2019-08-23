using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_63a0-3d334bf9")]
        public void Method_1007_63a0()
        {
            ii(0x1007_63a0, 5); push(0x24);                             /* push 0x24 */
            ii(0x1007_63a5, 5); call(Definitions.sys_check_available_stack_size, 0xe_f9a8); /* call 0x10165d52 */
            ii(0x1007_63aa, 1); push(ebx);                              /* push ebx */
            ii(0x1007_63ab, 1); push(ecx);                              /* push ecx */
            ii(0x1007_63ac, 1); push(edx);                              /* push edx */
            ii(0x1007_63ad, 1); push(esi);                              /* push esi */
            ii(0x1007_63ae, 1); push(edi);                              /* push edi */
            ii(0x1007_63af, 1); push(ebp);                              /* push ebp */
            ii(0x1007_63b0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_63b2, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1007_63b8, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_63bb, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_63be, 5); call(0x1007_6c30, 0x86d);               /* call 0x10076c30 */
            ii(0x1007_63c3, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_63c6, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_63c9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_63cb, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_63cc, 1); pop(edi);                               /* pop edi */
            ii(0x1007_63cd, 1); pop(esi);                               /* pop esi */
            ii(0x1007_63ce, 1); pop(edx);                               /* pop edx */
            ii(0x1007_63cf, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_63d0, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_63d1, 1); ret();                                  /* ret */
        }
    }
}
