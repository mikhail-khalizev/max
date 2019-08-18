using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e8d4e42c-9d33-4d99-909c-7b101fcfa0e9")]
        public void Method_100c_b000()
        {
            ii(0x100c_b000, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_b005, 5); calld(Definitions.sys_check_available_stack_size, 0x9_ad48); /* call 0x10165d52 */
            ii(0x100c_b00a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_b00b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_b00c, 1); pushd(edx);                             /* push edx */
            ii(0x100c_b00d, 1); pushd(esi);                             /* push esi */
            ii(0x100c_b00e, 1); pushd(edi);                             /* push edi */
            ii(0x100c_b00f, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_b010, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b012, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_b018, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_b01b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_b01e, 5); calld(0x1007_6b58, -0x5_44cb);          /* call 0x10076b58 */
            ii(0x100c_b023, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_b026, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_b029, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b02b, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_b02c, 1); popd(edi);                              /* pop edi */
            ii(0x100c_b02d, 1); popd(esi);                              /* pop esi */
            ii(0x100c_b02e, 1); popd(edx);                              /* pop edx */
            ii(0x100c_b02f, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_b030, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_b031, 1); retd(); return;                         /* ret */
        }
    }
}
