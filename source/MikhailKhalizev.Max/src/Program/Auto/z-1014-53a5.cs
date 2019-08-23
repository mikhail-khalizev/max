using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_53a5-11f508cf")]
        public void Method_1014_53a5()
        {
            ii(0x1014_53a5, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1014_53aa, 5); calld(Definitions.sys_check_available_stack_size, 0x2_09a3); /* call 0x10165d52 */
            ii(0x1014_53af, 1); pushd(esi);                             /* push esi */
            ii(0x1014_53b0, 1); pushd(edi);                             /* push edi */
            ii(0x1014_53b1, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_53b2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_53b4, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1014_53ba, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_53bd, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1014_53c0, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1014_53c3, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x1014_53c6, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1014_53c9, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1014_53cc, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_53cf, 5); calld(0x1014_4f3c, -0x498);             /* call 0x10144f3c */
            ii(0x1014_53d4, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_53d7, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1014_53da, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1014_53dd, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_53e0, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_7260); /* mov dword [eax+0x2], 0x101b7260 */
            ii(0x1014_53e7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_53ea, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1014_53ed, 3); mov(memd_a32[ds, edx + 0x14], eax);     /* mov [edx+0x14], eax */
            ii(0x1014_53f0, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_53f3, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1014_53f6, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1014_53f9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_53fb, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_53fc, 1); popd(edi);                              /* pop edi */
            ii(0x1014_53fd, 1); popd(esi);                              /* pop esi */
            ii(0x1014_53fe, 1); retd();                                 /* ret */
        }
    }
}
