using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4db71ae2-31f4-4f5a-9832-78f1e2a2aa8c")]
        public void Method_1013_9eb4()
        {
            ii(0x1013_9eb4, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1013_9eb9, 5); calld(Definitions.sys_check_available_stack_size, 0x2be94); /* call 0x10165d52 */
            ii(0x1013_9ebe, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_9ebf, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_9ec0, 1); pushd(esi);                             /* push esi */
            ii(0x1013_9ec1, 1); pushd(edi);                             /* push edi */
            ii(0x1013_9ec2, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_9ec3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_9ec5, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1013_9ecb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_9ece, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_9ed1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_9ed4, 5); calld(0x1013_aaa8, 0xbcf);              /* call 0x1013aaa8 */
            ii(0x1013_9ed9, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_9edc, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1013_9edf, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1013_9ee2, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1013_9ee5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_9ee8, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1013_9eeb, 5); calld(0x1013_abc3, 0xcd3);              /* call 0x1013abc3 */
            ii(0x1013_9ef0, 3); sub(eax, 0x6);                          /* sub eax, 0x6 */
            ii(0x1013_9ef3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_9ef6, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1013_9ef9, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1013_9efc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_9eff, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x1013_9f02, 5); calld(0x1007_6d58, -0xc31af);           /* call 0x10076d58 */
            ii(0x1013_9f07, 3); sub(eax, 0xa);                          /* sub eax, 0xa */
            ii(0x1013_9f0a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_9f0d, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1013_9f10, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1013_9f13, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_9f16, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1013_9f19, 5); calld(0x1007_6d58, -0xc31c6);           /* call 0x10076d58 */
            ii(0x1013_9f1e, 3); sub(eax, 0xe);                          /* sub eax, 0xe */
            ii(0x1013_9f21, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_9f24, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1013_9f27, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_9f2a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_9f2d, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_6eac); /* mov dword [eax+0x2], 0x101b6eac */
            ii(0x1013_9f34, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_9f37, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1013_9f3a, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1013_9f3d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_9f3f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_9f40, 1); popd(edi);                              /* pop edi */
            ii(0x1013_9f41, 1); popd(esi);                              /* pop esi */
            ii(0x1013_9f42, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_9f43, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_9f44, 1); retd(); return;                         /* ret */
        }
    }
}
