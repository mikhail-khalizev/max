using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2c40fea6-64db-419c-b02f-7a18289464f1")]
        public void Method_100a_2cb7()
        {
            ii(0x100a_2cb7, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_2cbc, 5); calld(Definitions.sys_check_available_stack_size, 0xc_3091); /* call 0x10165d52 */
            ii(0x100a_2cc1, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_2cc2, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_2cc3, 1); pushd(edx);                             /* push edx */
            ii(0x100a_2cc4, 1); pushd(esi);                             /* push esi */
            ii(0x100a_2cc5, 1); pushd(edi);                             /* push edi */
            ii(0x100a_2cc6, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_2cc7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_2cc9, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_2ccf, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_2cd2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_2cd5, 4); mov(ax, memw_a32[ds, eax + 0xd]);       /* mov ax, [eax+0xd] */
            ii(0x100a_2cd9, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_2cdc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_2cdf, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_2ce1, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_2ce2, 1); popd(edi);                              /* pop edi */
            ii(0x100a_2ce3, 1); popd(esi);                              /* pop esi */
            ii(0x100a_2ce4, 1); popd(edx);                              /* pop edx */
            ii(0x100a_2ce5, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_2ce6, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_2ce7, 1); retd(); return;                         /* ret */
        }
    }
}
