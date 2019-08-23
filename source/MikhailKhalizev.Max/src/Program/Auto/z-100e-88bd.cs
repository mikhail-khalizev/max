using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_88bd-6d0551ad")]
        public void Method_100e_88bd()
        {
            ii(0x100e_88bd, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100e_88c2, 5); calld(Definitions.sys_check_available_stack_size, 0x7_d48b); /* call 0x10165d52 */
            ii(0x100e_88c7, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_88c8, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_88c9, 1); pushd(edx);                             /* push edx */
            ii(0x100e_88ca, 1); pushd(esi);                             /* push esi */
            ii(0x100e_88cb, 1); pushd(edi);                             /* push edi */
            ii(0x100e_88cc, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_88cd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_88cf, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100e_88d5, 5); mov(eax, 0x64);                         /* mov eax, 0x64 */
            ii(0x100e_88da, 5); calld(0x100e_93d0, 0xaf1);              /* call 0x100e93d0 */
            ii(0x100e_88df, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_88e1, 5); calld(0x100e_883d, -0xa9);              /* call 0x100e883d */
            ii(0x100e_88e6, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_88e9, 5); mov(eax, memd_a32[ds, 0x101c_365c]);    /* mov eax, [0x101c365c] */
            ii(0x100e_88ee, 5); calld(Definitions.sys_display_apply_palette, 0x8_42c9); /* call 0x1016cbbc */
            ii(0x100e_88f3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_88f6, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100e_88f9, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100e_88fc, 4); imul(eax, memd_a32[ds, edx + 0xc]);     /* imul eax, [edx+0xc] */
            ii(0x100e_8900, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100e_8902, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_8904, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_8907, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x100e_890a, 5); calld(Definitions.sys_memset, 0x7_d4d1); /* call 0x10165de0 */
            ii(0x100e_890f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_8912, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x100e_8915, 5); calld(Definitions.sys_display_draw_0, 0x7_eb6a); /* call 0x10167484 */
            ii(0x100e_891a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_891c, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_891d, 1); popd(edi);                              /* pop edi */
            ii(0x100e_891e, 1); popd(esi);                              /* pop esi */
            ii(0x100e_891f, 1); popd(edx);                              /* pop edx */
            ii(0x100e_8920, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_8921, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_8922, 1); retd();                                 /* ret */
        }
    }
}
