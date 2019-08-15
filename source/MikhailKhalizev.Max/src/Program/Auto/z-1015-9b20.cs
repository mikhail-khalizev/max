using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b50b5daf-bcc9-403d-86bc-498936ea852b")]
        public void Method_1015_9b20()
        {
            ii(0x1015_9b20, 5); pushd(0x98);                            /* push 0x98 */
            ii(0x1015_9b25, 5); calld(Definitions.sys_check_available_stack_size, 0xc228); /* call 0x10165d52 */
            ii(0x1015_9b2a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_9b2b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_9b2c, 1); pushd(esi);                             /* push esi */
            ii(0x1015_9b2d, 1); pushd(edi);                             /* push edi */
            ii(0x1015_9b2e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_9b2f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_9b31, 6); sub(esp, 0x80);                         /* sub esp, 0x80 */
            ii(0x1015_9b37, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_9b3a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1015_9b3d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_9b40, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1015_9b43, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_9b48, 5); calld(0x100f_448c, -0x6_56c1);          /* call 0x100f448c */
            ii(0x1015_9b4d, 5); calld(0x100f_fc13, -0x5_9f3f);          /* call 0x100ffc13 */
            ii(0x1015_9b52, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x1015_9b56, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x1015_9b59, 3); lea(eax, ebp - 0x80);                   /* lea eax, [ebp-0x80] */
            ii(0x1015_9b5c, 5); calld(0x100e_1f02, -0x7_7c5f);          /* call 0x100e1f02 */
            ii(0x1015_9b61, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1015_9b64, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x1015_9b68, 3); lea(eax, ebp - 0x80);                   /* lea eax, [ebp-0x80] */
            ii(0x1015_9b6b, 5); calld(0x100e_2dc1, -0x7_6daf);          /* call 0x100e2dc1 */
            ii(0x1015_9b70, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_9b72, 3); lea(eax, ebp - 0x80);                   /* lea eax, [ebp-0x80] */
            ii(0x1015_9b75, 5); calld(0x100e_2d1d, -0x7_6e5d);          /* call 0x100e2d1d */
            ii(0x1015_9b7a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_9b7c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_9b7d, 1); popd(edi);                              /* pop edi */
            ii(0x1015_9b7e, 1); popd(esi);                              /* pop esi */
            ii(0x1015_9b7f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_9b80, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_9b81, 1); retd(); return;                         /* ret */
        }
    }
}
