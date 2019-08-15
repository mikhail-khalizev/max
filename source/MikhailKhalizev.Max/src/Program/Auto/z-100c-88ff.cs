using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("24e28428-de28-4f83-99da-f36a99ea42f1")]
        public void Method_100c_88ff()
        {
            ii(0x100c_88ff, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100c_8904, 5); calld(Definitions.sys_check_available_stack_size, 0x9_d449); /* call 0x10165d52 */
            ii(0x100c_8909, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_890a, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_890b, 1); pushd(edx);                             /* push edx */
            ii(0x100c_890c, 1); pushd(esi);                             /* push esi */
            ii(0x100c_890d, 1); pushd(edi);                             /* push edi */
            ii(0x100c_890e, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_890f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_8911, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100c_8917, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_891a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_891c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_891f, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100c_8922, 5); calld(0x1008_afe4, -0x3_d943);          /* call 0x1008afe4 */
            ii(0x100c_8927, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100c_892a, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100c_892f, 5); calld(0x100a_5e27, -0x2_2b0d);          /* call 0x100a5e27 */
            ii(0x100c_8934, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_8936, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_8937, 1); popd(edi);                              /* pop edi */
            ii(0x100c_8938, 1); popd(esi);                              /* pop esi */
            ii(0x100c_8939, 1); popd(edx);                              /* pop edx */
            ii(0x100c_893a, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_893b, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_893c, 1); retd(); return;                         /* ret */
        }
    }
}
