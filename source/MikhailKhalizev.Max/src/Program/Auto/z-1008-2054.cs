using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_2054-3ccfb990")]
        public void Method_1008_2054()
        {
            ii(0x1008_2054, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1008_2059, 5); calld(Definitions.sys_check_available_stack_size, 0xe_3cf4); /* call 0x10165d52 */
            ii(0x1008_205e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_205f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_2060, 1); pushd(edx);                             /* push edx */
            ii(0x1008_2061, 1); pushd(esi);                             /* push esi */
            ii(0x1008_2062, 1); pushd(edi);                             /* push edi */
            ii(0x1008_2063, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_2064, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_2066, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1008_206c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_206f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_2072, 7); mov(memd_a32[ds, eax + 0x3a], 0x1c0);   /* mov dword [eax+0x3a], 0x1c0 */
            ii(0x1008_2079, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_207b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_207e, 3); add(eax, 0x16);                         /* add eax, 0x16 */
            ii(0x1008_2081, 5); calld(0x1008_9c68, 0x7be2);             /* call 0x10089c68 */
            ii(0x1008_2086, 5); mov(ebx, 0x101c_3180);                  /* mov ebx, 0x101c3180 */
            ii(0x1008_208b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_208d, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1008_208f, 5); calld(0x100a_4d50, 0x2_2cbc);           /* call 0x100a4d50 */
            ii(0x1008_2094, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1008_2097, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_2099, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_209c, 3); add(eax, 0x16);                         /* add eax, 0x16 */
            ii(0x1008_209f, 5); calld(0x1008_9c68, 0x7bc4);             /* call 0x10089c68 */
            ii(0x1008_20a4, 5); calld(0x1008_9f38, 0x7e8f);             /* call 0x10089f38 */
            ii(0x1008_20a9, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1008_20ab, 5); calld(0x100b_8e30, 0x3_6d80);           /* call 0x100b8e30 */
            ii(0x1008_20b0, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1008_20b5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_20b8, 5); calld(0x100a_2a04, 0x2_0947);           /* call 0x100a2a04 */
            ii(0x1008_20bd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_20bf, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_20c0, 1); popd(edi);                              /* pop edi */
            ii(0x1008_20c1, 1); popd(esi);                              /* pop esi */
            ii(0x1008_20c2, 1); popd(edx);                              /* pop edx */
            ii(0x1008_20c3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_20c4, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_20c5, 1); retd(); return;                         /* ret */
        }
    }
}
