using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_97cc-91df2d8e")]
        public void Method_1009_97cc()
        {
            ii(0x1009_97cc, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_97d1, 5); calld(Definitions.sys_check_available_stack_size, 0xc_c57c); /* call 0x10165d52 */
            ii(0x1009_97d6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_97d7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_97d8, 1); pushd(edx);                             /* push edx */
            ii(0x1009_97d9, 1); pushd(esi);                             /* push esi */
            ii(0x1009_97da, 1); pushd(edi);                             /* push edi */
            ii(0x1009_97db, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_97dc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_97de, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_97e4, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_97e7, 4); mov(memb_a32[ss, ebp - 0x8], 0xc);      /* mov byte [ebp-0x8], 0xc */
            ii(0x1009_97eb, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1009_97ee, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_97f0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_97f1, 1); popd(edi);                              /* pop edi */
            ii(0x1009_97f2, 1); popd(esi);                              /* pop esi */
            ii(0x1009_97f3, 1); popd(edx);                              /* pop edx */
            ii(0x1009_97f4, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_97f5, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_97f6, 1); retd();                                 /* ret */
        }
    }
}
