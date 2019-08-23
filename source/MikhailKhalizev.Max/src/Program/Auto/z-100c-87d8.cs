using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_87d8-953897c6")]
        public void Method_100c_87d8()
        {
            ii(0x100c_87d8, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_87dd, 5); calld(Definitions.sys_check_available_stack_size, 0x9_d570); /* call 0x10165d52 */
            ii(0x100c_87e2, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_87e3, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_87e4, 1); pushd(esi);                             /* push esi */
            ii(0x100c_87e5, 1); pushd(edi);                             /* push edi */
            ii(0x100c_87e6, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_87e7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_87e9, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_87ef, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_87f2, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_87f5, 5); mov(edx, StringDefinitions.MinePlacingAssistant); /* mov edx, 0x101a1322 */
            ii(0x100c_87fa, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_87fd, 5); calld(Definitions.sys_strcpy, 0x9_d6cd); /* call 0x10165ecf */
            ii(0x100c_8802, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_8805, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_8808, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_880b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_880d, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_880e, 1); popd(edi);                              /* pop edi */
            ii(0x100c_880f, 1); popd(esi);                              /* pop esi */
            ii(0x100c_8810, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_8811, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_8812, 1); retd();                                 /* ret */
        }
    }
}
