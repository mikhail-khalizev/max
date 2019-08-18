using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_a411-e0bd117b")]
        public void Method_1009_a411()
        {
            ii(0x1009_a411, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_a416, 5); calld(Definitions.sys_check_available_stack_size, 0xc_b937); /* call 0x10165d52 */
            ii(0x1009_a41b, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_a41c, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_a41d, 1); pushd(edx);                             /* push edx */
            ii(0x1009_a41e, 1); pushd(esi);                             /* push esi */
            ii(0x1009_a41f, 1); pushd(edi);                             /* push edi */
            ii(0x1009_a420, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_a421, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_a423, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_a429, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_a42c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_a42e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_a431, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_a434, 5); calld(0x1013_ad11, 0xa_08d8);           /* call 0x1013ad11 */
            ii(0x1009_a439, 2); test(al, al);                           /* test al, al */
            ii(0x1009_a43b, 2); if(jnzd(0x1009_a46d, 0x30)) goto l_0x1009_a46d; /* jnz 0x1009a46d */
            ii(0x1009_a43d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_a43f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_a442, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_a445, 5); calld(0x1013_ad71, 0xa_0927);           /* call 0x1013ad71 */
            ii(0x1009_a44a, 2); test(al, al);                           /* test al, al */
            ii(0x1009_a44c, 2); if(jzd(0x1009_a46d, 0x1f)) goto l_0x1009_a46d; /* jz 0x1009a46d */
            ii(0x1009_a44e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_a451, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_a454, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_a457, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1009_a45a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_a45d, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_a460, 5); calld(0x1007_65d0, -0x2_3e95);          /* call 0x100765d0 */
            ii(0x1009_a465, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_a467, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_a46a, 3); calld_abs(memd_a32[ds, ebx + 0x44]);    /* call dword [ebx+0x44] */
        l_0x1009_a46d:
            ii(0x1009_a46d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_a46f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_a470, 1); popd(edi);                              /* pop edi */
            ii(0x1009_a471, 1); popd(esi);                              /* pop esi */
            ii(0x1009_a472, 1); popd(edx);                              /* pop edx */
            ii(0x1009_a473, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_a474, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_a475, 1); retd(); return;                         /* ret */
        }
    }
}
