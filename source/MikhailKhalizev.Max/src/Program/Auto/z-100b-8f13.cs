using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_8f13-9cfc4238")]
        public void Method_100b_8f13()
        {
            ii(0x100b_8f13, 5); push(0x20);                             /* push 0x20 */
            ii(0x100b_8f18, 5); call(Definitions.sys_check_available_stack_size, 0xa_ce35); /* call 0x10165d52 */
            ii(0x100b_8f1d, 1); push(ebx);                              /* push ebx */
            ii(0x100b_8f1e, 1); push(ecx);                              /* push ecx */
            ii(0x100b_8f1f, 1); push(edx);                              /* push edx */
            ii(0x100b_8f20, 1); push(esi);                              /* push esi */
            ii(0x100b_8f21, 1); push(edi);                              /* push edi */
            ii(0x100b_8f22, 1); push(ebp);                              /* push ebp */
            ii(0x100b_8f23, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_8f25, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100b_8f2b, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100b_8f2e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_8f31, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100b_8f34, 5); call(0x1007_6574, -0x4_29c5);           /* call 0x10076574 */
            ii(0x100b_8f39, 4); mov(dx, memw[ds, eax + 0x1a]);          /* mov dx, [eax+0x1a] */
            ii(0x100b_8f3d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_8f40, 4); mov(memw[ds, eax + 0x10], dx);          /* mov [eax+0x10], dx */
            ii(0x100b_8f44, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_8f47, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100b_8f4a, 5); call(0x1007_6574, -0x4_29db);           /* call 0x10076574 */
            ii(0x100b_8f4f, 4); mov(dx, memw[ds, eax + 0x1c]);          /* mov dx, [eax+0x1c] */
            ii(0x100b_8f53, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_8f56, 4); mov(memw[ds, eax + 0x12], dx);          /* mov [eax+0x12], dx */
            ii(0x100b_8f5a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_8f5c, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_8f5d, 1); pop(edi);                               /* pop edi */
            ii(0x100b_8f5e, 1); pop(esi);                               /* pop esi */
            ii(0x100b_8f5f, 1); pop(edx);                               /* pop edx */
            ii(0x100b_8f60, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_8f61, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_8f62, 1); ret();                                  /* ret */
        }
    }
}
