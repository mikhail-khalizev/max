using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_acec-cf92e1")]
        public void Method_100e_acec()
        {
            ii(0x100e_acec, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_acf1, 5); calld(Definitions.sys_check_available_stack_size, 0x7_b05c); /* call 0x10165d52 */
            ii(0x100e_acf6, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_acf7, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_acf8, 1); pushd(esi);                             /* push esi */
            ii(0x100e_acf9, 1); pushd(edi);                             /* push edi */
            ii(0x100e_acfa, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_acfb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_acfd, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_ad03, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_ad06, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_ad09, 3); mov(edi, memd_a32[ss, ebp - 0x8]);      /* mov edi, [ebp-0x8] */
            ii(0x100e_ad0c, 3); mov(esi, memd_a32[ss, ebp - 0x4]);      /* mov esi, [ebp-0x4] */
            ii(0x100e_ad0f, 1); movsd_a32();                            /* movsd */
            ii(0x100e_ad10, 1); movsb_a32();                            /* movsb */
            ii(0x100e_ad11, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_ad14, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_ad17, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_ad1a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_ad1c, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_ad1d, 1); popd(edi);                              /* pop edi */
            ii(0x100e_ad1e, 1); popd(esi);                              /* pop esi */
            ii(0x100e_ad1f, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_ad20, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_ad21, 1); retd();                                 /* ret */
        }
    }
}
