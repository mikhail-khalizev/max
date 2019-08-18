using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("00435656-b582-4208-9884-a56de4f5dd53")]
        public void Method_1011_9ce6()
        {
            ii(0x1011_9ce6, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1011_9ceb, 5); calld(Definitions.sys_check_available_stack_size, 0x4_c062); /* call 0x10165d52 */
            ii(0x1011_9cf0, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_9cf1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_9cf2, 1); pushd(esi);                             /* push esi */
            ii(0x1011_9cf3, 1); pushd(edi);                             /* push edi */
            ii(0x1011_9cf4, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_9cf5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_9cf7, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1011_9cfd, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_9d00, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1011_9d03, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1011_9d06, 3); mov(ebx, memd_a32[ds, ebx + 0x14]);     /* mov ebx, [ebx+0x14] */
            ii(0x1011_9d09, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1011_9d0c, 5); mov(edx, StringDefinitions.Length2);    /* mov edx, 0x101a7d0d */
            ii(0x1011_9d11, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9d14, 5); calld(0x1014_74f5, 0x2_d7dc);           /* call 0x101474f5 */
            ii(0x1011_9d19, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1011_9d1c, 3); mov(bl, memb_a32[ds, ebx + 0x18]);      /* mov bl, [ebx+0x18] */
            ii(0x1011_9d1f, 6); and(ebx, 0xff);                         /* and ebx, 0xff */
            ii(0x1011_9d25, 5); mov(edx, StringDefinitions.Angle2);     /* mov edx, 0x101a7d14 */
            ii(0x1011_9d2a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9d2d, 5); calld(0x1014_74f5, 0x2_d7c3);           /* call 0x101474f5 */
            ii(0x1011_9d32, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1011_9d35, 3); mov(ebx, memd_a32[ds, ebx + 0x17]);     /* mov ebx, [ebx+0x17] */
            ii(0x1011_9d38, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1011_9d3b, 5); mov(edx, StringDefinitions.PixelXStart2); /* mov edx, 0x101a7d1a */
            ii(0x1011_9d40, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9d43, 5); calld(0x1014_74f5, 0x2_d7ad);           /* call 0x101474f5 */
            ii(0x1011_9d48, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1011_9d4b, 3); mov(ebx, memd_a32[ds, ebx + 0x19]);     /* mov ebx, [ebx+0x19] */
            ii(0x1011_9d4e, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1011_9d51, 5); mov(edx, StringDefinitions.PixelYStart2); /* mov edx, 0x101a7d28 */
            ii(0x1011_9d56, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9d59, 5); calld(0x1014_74f5, 0x2_d797);           /* call 0x101474f5 */
            ii(0x1011_9d5e, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1011_9d61, 3); mov(ebx, memd_a32[ds, ebx + 0x6]);      /* mov ebx, [ebx+0x6] */
            ii(0x1011_9d64, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1011_9d67, 5); mov(edx, StringDefinitions.XEnd2);      /* mov edx, 0x101a7d36 */
            ii(0x1011_9d6c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9d6f, 5); calld(0x1014_74f5, 0x2_d781);           /* call 0x101474f5 */
            ii(0x1011_9d74, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1011_9d77, 3); mov(ebx, memd_a32[ds, ebx + 0x8]);      /* mov ebx, [ebx+0x8] */
            ii(0x1011_9d7a, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1011_9d7d, 5); mov(edx, StringDefinitions.YEnd2);      /* mov edx, 0x101a7d3c */
            ii(0x1011_9d82, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9d85, 5); calld(0x1014_74f5, 0x2_d76b);           /* call 0x101474f5 */
            ii(0x1011_9d8a, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1011_9d8d, 3); mov(ebx, memd_a32[ds, ebx + 0x1d]);     /* mov ebx, [ebx+0x1d] */
            ii(0x1011_9d90, 5); mov(edx, StringDefinitions.XStep2);     /* mov edx, 0x101a7d42 */
            ii(0x1011_9d95, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9d98, 5); calld(0x1014_74f5, 0x2_d758);           /* call 0x101474f5 */
            ii(0x1011_9d9d, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1011_9da0, 3); mov(ebx, memd_a32[ds, ebx + 0x21]);     /* mov ebx, [ebx+0x21] */
            ii(0x1011_9da3, 5); mov(edx, StringDefinitions.YStep2);     /* mov edx, 0x101a7d49 */
            ii(0x1011_9da8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9dab, 5); calld(0x1014_74f5, 0x2_d745);           /* call 0x101474f5 */
            ii(0x1011_9db0, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1011_9db3, 3); mov(ebx, memd_a32[ds, ebx + 0x25]);     /* mov ebx, [ebx+0x25] */
            ii(0x1011_9db6, 5); mov(edx, StringDefinitions.DeltaX2);    /* mov edx, 0x101a7d50 */
            ii(0x1011_9dbb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9dbe, 5); calld(0x1014_74f5, 0x2_d732);           /* call 0x101474f5 */
            ii(0x1011_9dc3, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1011_9dc6, 3); mov(ebx, memd_a32[ds, ebx + 0x29]);     /* mov ebx, [ebx+0x29] */
            ii(0x1011_9dc9, 5); mov(edx, StringDefinitions.DeltaY2);    /* mov edx, 0x101a7d58 */
            ii(0x1011_9dce, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9dd1, 5); calld(0x1014_74f5, 0x2_d71f);           /* call 0x101474f5 */
            ii(0x1011_9dd6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_9dd8, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_9dd9, 1); popd(edi);                              /* pop edi */
            ii(0x1011_9dda, 1); popd(esi);                              /* pop esi */
            ii(0x1011_9ddb, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_9ddc, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_9ddd, 1); retd(); return;                         /* ret */
        }
    }
}
