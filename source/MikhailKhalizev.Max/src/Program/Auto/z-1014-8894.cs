using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_8894-7f977827")]
        public void Method_1014_8894()
        {
            ii(0x1014_8894, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1014_8899, 5); calld(Definitions.sys_check_available_stack_size, 0x1_d4b4); /* call 0x10165d52 */
            ii(0x1014_889e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_889f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_88a0, 1); pushd(edx);                             /* push edx */
            ii(0x1014_88a1, 1); pushd(esi);                             /* push esi */
            ii(0x1014_88a2, 1); pushd(edi);                             /* push edi */
            ii(0x1014_88a3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_88a4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_88a6, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_88ac, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_88af, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_88b2, 5); calld(0x1013_a0af, -0xe808);            /* call 0x1013a0af */
            ii(0x1014_88b7, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_88ba, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1014_88bd, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_88c0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_88c3, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_88c6, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_88c9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_88cb, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_88cc, 1); popd(edi);                              /* pop edi */
            ii(0x1014_88cd, 1); popd(esi);                              /* pop esi */
            ii(0x1014_88ce, 1); popd(edx);                              /* pop edx */
            ii(0x1014_88cf, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_88d0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_88d1, 1); retd();                                 /* ret */
        }
    }
}
