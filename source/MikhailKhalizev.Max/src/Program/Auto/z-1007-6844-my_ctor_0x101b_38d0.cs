using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_6844-812796ce")]
        public void my_ctor_0x101b_38d0()
        {
            ii(0x1007_6844, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1007_6849, 5); calld(Definitions.sys_check_available_stack_size, 0xe_f504); /* call 0x10165d52 */
            ii(0x1007_684e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_684f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_6850, 1); pushd(edx);                             /* push edx */
            ii(0x1007_6851, 1); pushd(esi);                             /* push esi */
            ii(0x1007_6852, 1); pushd(edi);                             /* push edi */
            ii(0x1007_6853, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_6854, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_6856, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_685c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_685f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_6862, 5); calld(Definitions.my_ctor_0x101b_6edc, 0x5dd); /* call 0x10076e44 */
            ii(0x1007_6867, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_686a, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1007_686d, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_6870, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_6873, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_6876, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_6879, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_687b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_687c, 1); popd(edi);                              /* pop edi */
            ii(0x1007_687d, 1); popd(esi);                              /* pop esi */
            ii(0x1007_687e, 1); popd(edx);                              /* pop edx */
            ii(0x1007_687f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_6880, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_6881, 1); retd();                                 /* ret */
        }
    }
}
