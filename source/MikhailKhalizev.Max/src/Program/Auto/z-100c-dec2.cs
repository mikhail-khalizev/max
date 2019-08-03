using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3ef31588-d850-4fe2-b7cb-9d46937c41db")]
        public void Method_100c_dec2()
        {
            ii(0x100c_dec2, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_dec7, 5); calld(Definitions.sys_check_available_stack_size, 0x97e86); /* call 0x10165d52 */
            ii(0x100c_decc, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_decd, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_dece, 1); pushd(edx);                             /* push edx */
            ii(0x100c_decf, 1); pushd(esi);                             /* push esi */
            ii(0x100c_ded0, 1); pushd(edi);                             /* push edi */
            ii(0x100c_ded1, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_ded2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_ded4, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_deda, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_dedd, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100c_dee1, 5); calld(0x100c_de37, -0xaf);              /* call 0x100cde37 */
            ii(0x100c_dee6, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100c_deeb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_deee, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_def1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_def3, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_def4, 1); popd(edi);                              /* pop edi */
            ii(0x100c_def5, 1); popd(esi);                              /* pop esi */
            ii(0x100c_def6, 1); popd(edx);                              /* pop edx */
            ii(0x100c_def7, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_def8, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_def9, 1); retd(); return;                         /* ret */
        }
    }
}
