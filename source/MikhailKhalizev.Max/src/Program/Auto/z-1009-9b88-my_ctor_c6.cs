using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_9b88-42a5f3b8")]
        public void my_ctor_c6()
        {
            ii(0x1009_9b88, 5); push(0x30);                             /* push 0x30 */
            ii(0x1009_9b8d, 5); call(Definitions.sys_check_available_stack_size, 0xc_c1c0); /* call 0x10165d52 */
            ii(0x1009_9b92, 1); push(ebx);                              /* push ebx */
            ii(0x1009_9b93, 1); push(ecx);                              /* push ecx */
            ii(0x1009_9b94, 1); push(esi);                              /* push esi */
            ii(0x1009_9b95, 1); push(edi);                              /* push edi */
            ii(0x1009_9b96, 1); push(ebp);                              /* push ebp */
            ii(0x1009_9b97, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_9b99, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1009_9b9f, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_9ba2, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_9ba5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_9ba8, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_9bab, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_9bae, 3); mov(edx, memd[ds, eax + 0x2]);          /* mov edx, [eax+0x2] */
            ii(0x1009_9bb1, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_9bb4, 3); call_abs(memd[ds, edx + 0x14]);         /* call dword [edx+0x14] */
            ii(0x1009_9bb7, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1009_9bba, 3); mov(ebx, memd[ss, ebp - 0x4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1009_9bbd, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_9bc0, 5); call(0x1008_ad90, -0xee35);             /* call 0x1008ad90 */
            ii(0x1009_9bc5, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1009_9bc8, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_9bcb, 5); call(0x100a_26d1, 0x8b01);              /* call 0x100a26d1 */
            ii(0x1009_9bd0, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_9bd3, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1009_9bd6, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1009_9bd9, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_9bdc, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_9bdf, 5); call(0x1009_c484, 0x28a0);              /* call 0x1009c484 */
            ii(0x1009_9be4, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x1009_9be7, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_9bea, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1009_9bed, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_9bf0, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_9bf3, 7); mov(memd[ds, eax + 0x2], 0x101b_4420);  /* mov dword [eax+0x2], 0x101b4420 */
            ii(0x1009_9bfa, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_9bfd, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_9c00, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_9c03, 5); call(0x1009_c44c, 0x2844);              /* call 0x1009c44c */
            ii(0x1009_9c08, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_9c0b, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1009_9c0e, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1009_9c11, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_9c13, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_9c14, 1); pop(edi);                               /* pop edi */
            ii(0x1009_9c15, 1); pop(esi);                               /* pop esi */
            ii(0x1009_9c16, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_9c17, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_9c18, 1); ret();                                  /* ret */
        }
    }
}
