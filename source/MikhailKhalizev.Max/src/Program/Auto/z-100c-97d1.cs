using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8f0a2828-0a34-4a69-bc87-b4b166c0a96a")]
        public void Method_100c_97d1()
        {
            ii(0x100c_97d1, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_97d6, 5); calld(Definitions.sys_check_available_stack_size, 0x9_c577); /* call 0x10165d52 */
            ii(0x100c_97db, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_97dc, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_97dd, 1); pushd(edx);                             /* push edx */
            ii(0x100c_97de, 1); pushd(esi);                             /* push esi */
            ii(0x100c_97df, 1); pushd(edi);                             /* push edi */
            ii(0x100c_97e0, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_97e1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_97e3, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_97e9, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_97ec, 4); mov(memb_a32[ss, ebp - 0x8], 0x2e);     /* mov byte [ebp-0x8], 0x2e */
            ii(0x100c_97f0, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100c_97f3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_97f5, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_97f6, 1); popd(edi);                              /* pop edi */
            ii(0x100c_97f7, 1); popd(esi);                              /* pop esi */
            ii(0x100c_97f8, 1); popd(edx);                              /* pop edx */
            ii(0x100c_97f9, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_97fa, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_97fb, 1); retd(); return;                         /* ret */
        }
    }
}
