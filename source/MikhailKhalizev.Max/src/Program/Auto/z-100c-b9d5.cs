using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("adddd1dc-f6fa-41c9-86b9-64092bf8be0b")]
        public void Method_100c_b9d5()
        {
            ii(0x100c_b9d5, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_b9da, 5); calld(Definitions.sys_check_available_stack_size, 0x9_a373); /* call 0x10165d52 */
            ii(0x100c_b9df, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_b9e0, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_b9e1, 1); pushd(esi);                             /* push esi */
            ii(0x100c_b9e2, 1); pushd(edi);                             /* push edi */
            ii(0x100c_b9e3, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_b9e4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b9e6, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_b9ec, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_b9ef, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_b9f2, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100c_b9f5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_b9f8, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_b9fb, 5); calld(0x1007_6574, -0x5_548c);          /* call 0x10076574 */
            ii(0x100c_ba00, 5); calld(0x1015_2532, 0x8_6b2d);           /* call 0x10152532 */
            ii(0x100c_ba05, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_ba08, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_ba0b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_ba0e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_ba10, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_ba11, 1); popd(edi);                              /* pop edi */
            ii(0x100c_ba12, 1); popd(esi);                              /* pop esi */
            ii(0x100c_ba13, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_ba14, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_ba15, 1); retd(); return;                         /* ret */
        }
    }
}
