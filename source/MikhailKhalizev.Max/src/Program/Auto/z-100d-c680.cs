using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_c680-281c95a3")]
        public void Method_100d_c680()
        {
            ii(0x100d_c680, 5); pushd(0x48);                            /* push 0x48 */
            ii(0x100d_c685, 5); calld(Definitions.sys_check_available_stack_size, 0x8_96c8); /* call 0x10165d52 */
            ii(0x100d_c68a, 1); pushd(esi);                             /* push esi */
            ii(0x100d_c68b, 1); pushd(edi);                             /* push edi */
            ii(0x100d_c68c, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_c68d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_c68f, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x100d_c695, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100d_c698, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100d_c69b, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100d_c69e, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x100d_c6a1, 3); mov(eax, memd_a32[ss, ebp + 0x1c]);     /* mov eax, [ebp+0x1c] */
            ii(0x100d_c6a4, 1); pushd(eax);                             /* push eax */
            ii(0x100d_c6a5, 3); mov(eax, memd_a32[ss, ebp + 0x18]);     /* mov eax, [ebp+0x18] */
            ii(0x100d_c6a8, 1); pushd(eax);                             /* push eax */
            ii(0x100d_c6a9, 4); movsx(eax, memw_a32[ss, ebp + 0x14]);   /* movsx eax, word [ebp+0x14] */
            ii(0x100d_c6ad, 1); pushd(eax);                             /* push eax */
            ii(0x100d_c6ae, 4); movsx(eax, memw_a32[ss, ebp + 0x10]);   /* movsx eax, word [ebp+0x10] */
            ii(0x100d_c6b2, 1); pushd(eax);                             /* push eax */
            ii(0x100d_c6b3, 3); mov(ecx, memd_a32[ss, ebp - 0x4]);      /* mov ecx, [ebp-0x4] */
            ii(0x100d_c6b6, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x100d_c6b9, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100d_c6bc, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_c6bf, 5); calld(0x100c_fe4d, -0xc877);            /* call 0x100cfe4d */
            ii(0x100d_c6c4, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100d_c6c7, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100d_c6ca, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100d_c6cd, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_c6d0, 7); mov(memd_a32[ds, eax + 0x40], 0x101b_5f04); /* mov dword [eax+0x40], 0x101b5f04 */
            ii(0x100d_c6d7, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100d_c6dc, 5); calld(Definitions.sys_new, 0x8_971f);   /* call 0x10165e00 */
            ii(0x100d_c6e1, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100d_c6e4, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100d_c6e7, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100d_c6ea, 4); cmp(memd_a32[ss, ebp - 0x1c], 0);       /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x100d_c6ee, 2); if(jzd(0x100d_c719, 0x29)) goto l_0x100d_c719; /* jz 0x100dc719 */
            ii(0x100d_c6f0, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_c6f3, 4); mov(ax, memw_a32[ds, eax + 0x28]);      /* mov ax, [eax+0x28] */
            ii(0x100d_c6f7, 3); shl(eax, 0x5);                          /* shl eax, 0x5 */
            ii(0x100d_c6fa, 1); cwde();                                 /* cwde */
            ii(0x100d_c6fb, 1); pushd(eax);                             /* push eax */
            ii(0x100d_c6fc, 4); movsx(ecx, memw_a32[ss, ebp + 0x24]);   /* movsx ecx, word [ebp+0x24] */
            ii(0x100d_c700, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100d_c702, 4); movsx(edx, memw_a32[ss, ebp + 0x20]);   /* movsx edx, word [ebp+0x20] */
            ii(0x100d_c706, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100d_c709, 5); calld(0x100d_7bdc, -0x4b32);            /* call 0x100d7bdc */
            ii(0x100d_c70e, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100d_c711, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100d_c714, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100d_c717, 2); jmpd(0x100d_c71f, 0x6); goto l_0x100d_c71f; /* jmp 0x100dc71f */
        l_0x100d_c719:
            ii(0x100d_c719, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100d_c71c, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
        l_0x100d_c71f:
            ii(0x100d_c71f, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100d_c722, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100d_c725, 3); mov(memd_a32[ds, edx + 0x44], eax);     /* mov [edx+0x44], eax */
            ii(0x100d_c728, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_c72b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_c72e, 3); mov(eax, memd_a32[ds, eax + 0x44]);     /* mov eax, [eax+0x44] */
            ii(0x100d_c731, 5); calld(0x100d_7d74, -0x49c2);            /* call 0x100d7d74 */
            ii(0x100d_c736, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_c739, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100d_c73c, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100d_c73f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_c741, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_c742, 1); popd(edi);                              /* pop edi */
            ii(0x100d_c743, 1); popd(esi);                              /* pop esi */
            ii(0x100d_c744, 3); retd(0x18);                             /* ret 0x18 */
        }
    }
}
