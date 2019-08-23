using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_ae78-d73f78ba")]
        public void Method_100e_ae78()
        {
            ii(0x100e_ae78, 5); push(0x28);                             /* push 0x28 */
            ii(0x100e_ae7d, 5); call(Definitions.sys_check_available_stack_size, 0x7_aed0); /* call 0x10165d52 */
            ii(0x100e_ae82, 1); push(ebx);                              /* push ebx */
            ii(0x100e_ae83, 1); push(ecx);                              /* push ecx */
            ii(0x100e_ae84, 1); push(esi);                              /* push esi */
            ii(0x100e_ae85, 1); push(edi);                              /* push edi */
            ii(0x100e_ae86, 1); push(ebp);                              /* push ebp */
            ii(0x100e_ae87, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_ae89, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100e_ae8f, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_ae92, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100e_ae95, 5); mov(ebx, 0x5);                          /* mov ebx, 0x5 */
            ii(0x100e_ae9a, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100e_ae9e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_aea1, 5); call(0x100c_d7e8, -0x1_d6be);           /* call 0x100cd7e8 */
            ii(0x100e_aea6, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_aea9, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100e_aeac, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100e_aeaf, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_aeb2, 7); mov(memd[ds, eax + 0xc], 0x101b_616c);  /* mov dword [eax+0xc], 0x101b616c */
            ii(0x100e_aeb9, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_aebc, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100e_aebf, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_aec2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_aec4, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_aec5, 1); pop(edi);                               /* pop edi */
            ii(0x100e_aec6, 1); pop(esi);                               /* pop esi */
            ii(0x100e_aec7, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_aec8, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_aec9, 1); ret();                                  /* ret */
        }
    }
}
