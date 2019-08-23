using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_6cd0-4f47f449")]
        public void Method_1007_6cd0()
        {
            ii(0x1007_6cd0, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1007_6cd5, 5); calld(Definitions.sys_check_available_stack_size, 0xe_f078); /* call 0x10165d52 */
            ii(0x1007_6cda, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_6cdb, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_6cdc, 1); pushd(esi);                             /* push esi */
            ii(0x1007_6cdd, 1); pushd(edi);                             /* push edi */
            ii(0x1007_6cde, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_6cdf, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_6ce1, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1007_6ce7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_6cea, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_6ced, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_6cf0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_6cf3, 5); calld(0x1013_ac03, 0xc_3f0b);           /* call 0x1013ac03 */
            ii(0x1007_6cf8, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_6cfb, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1007_6cfe, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_6d01, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_6d04, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1007_6d07, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_6d0a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_6d0c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_6d0d, 1); popd(edi);                              /* pop edi */
            ii(0x1007_6d0e, 1); popd(esi);                              /* pop esi */
            ii(0x1007_6d0f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_6d10, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_6d11, 1); retd();                                 /* ret */
        }
    }
}
