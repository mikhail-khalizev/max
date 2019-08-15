using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("cd0ca3a4-f6c8-449d-83bf-a8ec486d64d5")]
        public void Method_100b_032f()
        {
            ii(0x100b_032f, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100b_0334, 5); calld(Definitions.sys_check_available_stack_size, 0xb_5a19); /* call 0x10165d52 */
            ii(0x100b_0339, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_033a, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_033b, 1); pushd(esi);                             /* push esi */
            ii(0x100b_033c, 1); pushd(edi);                             /* push edi */
            ii(0x100b_033d, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_033e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_0340, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_0346, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_0349, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_034c, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100b_034f, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x100b_0352, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_0355, 5); calld(0x1007_6d98, -0x3_95c2);          /* call 0x10076d98 */
            ii(0x100b_035a, 2); test(al, al);                           /* test al, al */
            ii(0x100b_035c, 2); if(jnzd(0x100b_0373, 0x15)) goto l_0x100b_0373; /* jnz 0x100b0373 */
            ii(0x100b_035e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_0361, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_0364, 5); calld(0x1008_a520, -0x2_5e49);          /* call 0x1008a520 */
            ii(0x100b_0369, 5); calld(0x100b_7d68, 0x79fa);             /* call 0x100b7d68 */
            ii(0x100b_036e, 3); cmp(eax, memd_a32[ss, ebp - 0x4]);      /* cmp eax, [ebp-0x4] */
            ii(0x100b_0371, 2); if(jnzd(0x100b_037b, 0x8)) goto l_0x100b_037b; /* jnz 0x100b037b */
        l_0x100b_0373:
            ii(0x100b_0373, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_0376, 5); calld(0x100b_06da, 0x35f);              /* call 0x100b06da */
        l_0x100b_037b:
            ii(0x100b_037b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_037d, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_037e, 1); popd(edi);                              /* pop edi */
            ii(0x100b_037f, 1); popd(esi);                              /* pop esi */
            ii(0x100b_0380, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_0381, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_0382, 1); retd(); return;                         /* ret */
        }
    }
}
