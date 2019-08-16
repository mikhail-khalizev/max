using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9811aada-20a4-4e13-a1ee-222f01c3fec6")]
        public void Method_100d_bced()
        {
            ii(0x100d_bced, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100d_bcf2, 5); calld(Definitions.sys_check_available_stack_size, 0x8_a05b); /* call 0x10165d52 */
            ii(0x100d_bcf7, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_bcf8, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_bcf9, 1); pushd(edx);                             /* push edx */
            ii(0x100d_bcfa, 1); pushd(esi);                             /* push esi */
            ii(0x100d_bcfb, 1); pushd(edi);                             /* push edi */
            ii(0x100d_bcfc, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_bcfd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_bcff, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100d_bd05, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100d_bd08, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_bd0b, 5); calld(0x100d_ac00, -0x1110);            /* call 0x100dac00 */
            ii(0x100d_bd10, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_bd13, 3); mov(edx, memd_a32[ds, eax + 0x4d]);     /* mov edx, [eax+0x4d] */
            ii(0x100d_bd16, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_bd19, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_bd1c, 3); mov(eax, memd_a32[ds, eax + 0x49]);     /* mov eax, [eax+0x49] */
            ii(0x100d_bd1f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_bd22, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100d_bd28, 6); mov(eax, memd_a32[ds, eax + 0x101c_a562]); /* mov eax, [eax+0x101ca562] */
            ii(0x100d_bd2e, 5); calld(0x100c_b60c, -0x1_0727);          /* call 0x100cb60c */
            ii(0x100d_bd33, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x100d_bd3a, 2); if(jzd(0x100d_bd4a, 0xe)) goto l_0x100d_bd4a; /* jz 0x100dbd4a */
            ii(0x100d_bd3c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_bd3f, 3); mov(eax, memd_a32[ds, eax + 0x49]);     /* mov eax, [eax+0x49] */
            ii(0x100d_bd42, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_bd45, 5); calld(0x1012_894c, 0x4_cc02);           /* call 0x1012894c */
        l_0x100d_bd4a:
            ii(0x100d_bd4a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_bd4c, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_bd4d, 1); popd(edi);                              /* pop edi */
            ii(0x100d_bd4e, 1); popd(esi);                              /* pop esi */
            ii(0x100d_bd4f, 1); popd(edx);                              /* pop edx */
            ii(0x100d_bd50, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_bd51, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_bd52, 1); retd(); return;                         /* ret */
        }
    }
}