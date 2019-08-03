using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("26cd3a06-0db0-43ef-84ca-e16cd274c01b")]
        public void Method_100c_aafc()
        {
            ii(0x100c_aafc, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_ab01, 5); calld(Definitions.sys_check_available_stack_size, 0x9b24c); /* call 0x10165d52 */
            ii(0x100c_ab06, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_ab07, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_ab08, 1); pushd(esi);                             /* push esi */
            ii(0x100c_ab09, 1); pushd(edi);                             /* push edi */
            ii(0x100c_ab0a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_ab0b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_ab0d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_ab13, 3); mov(memb_a32[ss, ebp - 0x4], al);       /* mov [ebp-0x4], al */
            ii(0x100c_ab16, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100c_ab19, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x100c_ab1c, 4); movsx(edx, memb_a32[ss, ebp - 0x4]);    /* movsx edx, byte [ebp-0x4] */
            ii(0x100c_ab20, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x100c_ab25, 5); calld(0x1010_610a, 0x3b5e0);            /* call 0x1010610a */
            ii(0x100c_ab2a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_ab2d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_ab30, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_ab32, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_ab33, 1); popd(edi);                              /* pop edi */
            ii(0x100c_ab34, 1); popd(esi);                              /* pop esi */
            ii(0x100c_ab35, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_ab36, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_ab37, 1); retd(); return;                         /* ret */
        }
    }
}
