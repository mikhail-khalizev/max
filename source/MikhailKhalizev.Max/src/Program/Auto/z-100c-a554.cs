using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_a554-3ecda7")]
        public void Method_100c_a554()
        {
            ii(0x100c_a554, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_a559, 5); calld(Definitions.sys_check_available_stack_size, 0x9_b7f4); /* call 0x10165d52 */
            ii(0x100c_a55e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_a55f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_a560, 1); pushd(esi);                             /* push esi */
            ii(0x100c_a561, 1); pushd(edi);                             /* push edi */
            ii(0x100c_a562, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_a563, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_a565, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_a56b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_a56e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_a571, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100c_a576, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_a579, 5); calld(0x1007_5e24, -0x5_475a);          /* call 0x10075e24 */
            ii(0x100c_a57e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_a581, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_a584, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_a587, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_a58a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_a58c, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_a58d, 1); popd(edi);                              /* pop edi */
            ii(0x100c_a58e, 1); popd(esi);                              /* pop esi */
            ii(0x100c_a58f, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_a590, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_a591, 1); retd();                                 /* ret */
        }
    }
}
