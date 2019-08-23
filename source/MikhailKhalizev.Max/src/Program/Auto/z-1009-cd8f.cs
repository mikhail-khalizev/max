using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_cd8f-639b7daf")]
        public void Method_1009_cd8f()
        {
            ii(0x1009_cd8f, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_cd94, 5); calld(Definitions.sys_check_available_stack_size, 0xc_8fb9); /* call 0x10165d52 */
            ii(0x1009_cd99, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_cd9a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_cd9b, 1); pushd(edx);                             /* push edx */
            ii(0x1009_cd9c, 1); pushd(esi);                             /* push esi */
            ii(0x1009_cd9d, 1); pushd(edi);                             /* push edi */
            ii(0x1009_cd9e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_cd9f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_cda1, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_cda7, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_cdaa, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_cdad, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_cdb0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_cdb3, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1009_cdb6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_cdb9, 3); calld_abs(memd_a32[ds, edx + 0x3c]);    /* call dword [edx+0x3c] */
            ii(0x1009_cdbc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_cdbe, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_cdbf, 1); popd(edi);                              /* pop edi */
            ii(0x1009_cdc0, 1); popd(esi);                              /* pop esi */
            ii(0x1009_cdc1, 1); popd(edx);                              /* pop edx */
            ii(0x1009_cdc2, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_cdc3, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_cdc4, 1); retd();                                 /* ret */
        }
    }
}
