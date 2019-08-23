using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_9155-67a7356b")]
        public void Method_1012_9155()
        {
            ii(0x1012_9155, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1012_915a, 5); calld(Definitions.sys_check_available_stack_size, 0x3_cbf3); /* call 0x10165d52 */
            ii(0x1012_915f, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_9160, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_9161, 1); pushd(esi);                             /* push esi */
            ii(0x1012_9162, 1); pushd(edi);                             /* push edi */
            ii(0x1012_9163, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_9164, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_9166, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1012_916c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_916f, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1012_9172, 7); mov(memb_a32[ds, 0x101c_5c1c], 0x10);   /* mov byte [0x101c5c1c], 0x10 */
            ii(0x1012_9179, 9); mov(memw_a32[ds, 0x101c_5c1d], 0);      /* mov word [0x101c5c1d], 0x0 */
            ii(0x1012_9182, 9); mov(memw_a32[ds, 0x101c_5c1f], 0x3c);   /* mov word [0x101c5c1f], 0x3c */
            ii(0x1012_918b, 7); mov(memd_a32[ss, ebp - 0xc], 0x101c_5c21); /* mov dword [ebp-0xc], 0x101c5c21 */
            ii(0x1012_9192, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_9195, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_9198, 5); calld(Definitions.sys_strcpy, 0x3_cd32); /* call 0x10165ecf */
            ii(0x1012_919d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_91a0, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_91a3, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x1012_91a6, 5); calld(Definitions.sys_strcpy, 0x3_cd24); /* call 0x10165ecf */
            ii(0x1012_91ab, 5); mov(eax, 0x4);                          /* mov eax, 0x4 */
            ii(0x1012_91b0, 5); calld(0x1012_5be9, -0x35cc);            /* call 0x10125be9 */
            ii(0x1012_91b5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_91b7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_91b8, 1); popd(edi);                              /* pop edi */
            ii(0x1012_91b9, 1); popd(esi);                              /* pop esi */
            ii(0x1012_91ba, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_91bb, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_91bc, 1); retd();                                 /* ret */
        }
    }
}
