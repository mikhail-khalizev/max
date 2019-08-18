using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_53c3-44b31f68")]
        public void Method_100b_53c3()
        {
            ii(0x100b_53c3, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_53c8, 5); calld(Definitions.sys_check_available_stack_size, 0xb_0985); /* call 0x10165d52 */
            ii(0x100b_53cd, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_53ce, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_53cf, 1); pushd(edx);                             /* push edx */
            ii(0x100b_53d0, 1); pushd(esi);                             /* push esi */
            ii(0x100b_53d1, 1); pushd(edi);                             /* push edi */
            ii(0x100b_53d2, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_53d3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_53d5, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_53db, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_53de, 4); mov(memb_a32[ss, ebp - 0x8], 0x18);     /* mov byte [ebp-0x8], 0x18 */
            ii(0x100b_53e2, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100b_53e5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_53e7, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_53e8, 1); popd(edi);                              /* pop edi */
            ii(0x100b_53e9, 1); popd(esi);                              /* pop esi */
            ii(0x100b_53ea, 1); popd(edx);                              /* pop edx */
            ii(0x100b_53eb, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_53ec, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_53ed, 1); retd(); return;                         /* ret */
        }
    }
}
