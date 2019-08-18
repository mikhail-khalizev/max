using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_9c01-e1701495")]
        public void Method_1011_9c01()
        {
            ii(0x1011_9c01, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1011_9c06, 5); calld(Definitions.sys_check_available_stack_size, 0x4_c147); /* call 0x10165d52 */
            ii(0x1011_9c0b, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_9c0c, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_9c0d, 1); pushd(esi);                             /* push esi */
            ii(0x1011_9c0e, 1); pushd(edi);                             /* push edi */
            ii(0x1011_9c0f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_9c10, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_9c12, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1011_9c18, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_9c1b, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1011_9c1e, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1011_9c21, 3); add(ebx, 0x16);                         /* add ebx, 0x16 */
            ii(0x1011_9c24, 5); mov(edx, StringDefinitions.Length);     /* mov edx, 0x101a7cba */
            ii(0x1011_9c29, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9c2c, 5); calld(0x1014_5c2e, 0x2_bffd);           /* call 0x10145c2e */
            ii(0x1011_9c31, 5); mov(edx, StringDefinitions.Angle);      /* mov edx, 0x101a7cc1 */
            ii(0x1011_9c36, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9c39, 5); calld(0x1014_60aa, 0x2_c46c);           /* call 0x101460aa */
            ii(0x1011_9c3e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_9c40, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_9c43, 3); mov(memb_a32[ds, eax + 0x18], dl);      /* mov [eax+0x18], dl */
            ii(0x1011_9c46, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1011_9c49, 3); add(ebx, 0x19);                         /* add ebx, 0x19 */
            ii(0x1011_9c4c, 5); mov(edx, StringDefinitions.PixelXStart); /* mov edx, 0x101a7cc7 */
            ii(0x1011_9c51, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9c54, 5); calld(0x1014_5c2e, 0x2_bfd5);           /* call 0x10145c2e */
            ii(0x1011_9c59, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1011_9c5c, 3); add(ebx, 0x1b);                         /* add ebx, 0x1b */
            ii(0x1011_9c5f, 5); mov(edx, StringDefinitions.PixelYStart); /* mov edx, 0x101a7cd5 */
            ii(0x1011_9c64, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9c67, 5); calld(0x1014_5c2e, 0x2_bfc2);           /* call 0x10145c2e */
            ii(0x1011_9c6c, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1011_9c6f, 3); add(ebx, 0x8);                          /* add ebx, 0x8 */
            ii(0x1011_9c72, 5); mov(edx, StringDefinitions.XEnd);       /* mov edx, 0x101a7ce3 */
            ii(0x1011_9c77, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9c7a, 5); calld(0x1014_5c2e, 0x2_bfaf);           /* call 0x10145c2e */
            ii(0x1011_9c7f, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1011_9c82, 3); add(ebx, 0xa);                          /* add ebx, 0xa */
            ii(0x1011_9c85, 5); mov(edx, StringDefinitions.YEnd);       /* mov edx, 0x101a7ce9 */
            ii(0x1011_9c8a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9c8d, 5); calld(0x1014_5c2e, 0x2_bf9c);           /* call 0x10145c2e */
            ii(0x1011_9c92, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1011_9c95, 3); add(ebx, 0x1d);                         /* add ebx, 0x1d */
            ii(0x1011_9c98, 5); mov(edx, StringDefinitions.XStep);      /* mov edx, 0x101a7cef */
            ii(0x1011_9c9d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9ca0, 5); calld(0x1014_5cbc, 0x2_c017);           /* call 0x10145cbc */
            ii(0x1011_9ca5, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1011_9ca8, 3); add(ebx, 0x21);                         /* add ebx, 0x21 */
            ii(0x1011_9cab, 5); mov(edx, StringDefinitions.YStep);      /* mov edx, 0x101a7cf6 */
            ii(0x1011_9cb0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9cb3, 5); calld(0x1014_5cbc, 0x2_c004);           /* call 0x10145cbc */
            ii(0x1011_9cb8, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1011_9cbb, 3); add(ebx, 0x25);                         /* add ebx, 0x25 */
            ii(0x1011_9cbe, 5); mov(edx, StringDefinitions.DeltaX);     /* mov edx, 0x101a7cfd */
            ii(0x1011_9cc3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9cc6, 5); calld(0x1014_5cbc, 0x2_bff1);           /* call 0x10145cbc */
            ii(0x1011_9ccb, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1011_9cce, 3); add(ebx, 0x29);                         /* add ebx, 0x29 */
            ii(0x1011_9cd1, 5); mov(edx, StringDefinitions.DeltaY);     /* mov edx, 0x101a7d05 */
            ii(0x1011_9cd6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9cd9, 5); calld(0x1014_5cbc, 0x2_bfde);           /* call 0x10145cbc */
            ii(0x1011_9cde, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_9ce0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_9ce1, 1); popd(edi);                              /* pop edi */
            ii(0x1011_9ce2, 1); popd(esi);                              /* pop esi */
            ii(0x1011_9ce3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_9ce4, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_9ce5, 1); retd(); return;                         /* ret */
        }
    }
}
