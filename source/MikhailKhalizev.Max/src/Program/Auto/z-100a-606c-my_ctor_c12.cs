using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_606c-8125e181")]
        public void my_ctor_c12()
        {
            ii(0x100a_606c, 5); push(0x30);                             /* push 0x30 */
            ii(0x100a_6071, 5); call(Definitions.sys_check_available_stack_size, 0xb_fcdc); /* call 0x10165d52 */
            ii(0x100a_6076, 1); push(ecx);                              /* push ecx */
            ii(0x100a_6077, 1); push(esi);                              /* push esi */
            ii(0x100a_6078, 1); push(edi);                              /* push edi */
            ii(0x100a_6079, 1); push(ebp);                              /* push ebp */
            ii(0x100a_607a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_607c, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100a_6082, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_6085, 3); mov(memd[ss, ebp - 0x8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100a_6088, 3); mov(memd[ss, ebp - 0x4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x100a_608b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_608e, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100a_6091, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100a_6094, 3); mov(edx, memd[ds, eax + 0x2]);          /* mov edx, [eax+0x2] */
            ii(0x100a_6097, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100a_609a, 3); call_abs(memd[ds, edx + 0x14]);         /* call dword [edx+0x14] */
            ii(0x100a_609d, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100a_60a0, 3); mov(ebx, memd[ss, ebp - 0x8]);          /* mov ebx, [ebp-0x8] */
            ii(0x100a_60a3, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_60a6, 5); call(0x1008_ad90, -0x1_b31b);           /* call 0x1008ad90 */
            ii(0x100a_60ab, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100a_60ae, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_60b1, 5); call(0x100a_26d1, -0x39e5);             /* call 0x100a26d1 */
            ii(0x100a_60b6, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_60b9, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100a_60bc, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100a_60bf, 5); call(0x1008_b3ec, -0x1_acd8);           /* call 0x1008b3ec */
            ii(0x100a_60c4, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100a_60c7, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_60ca, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_60cd, 5); call(0x1008_b1e4, -0x1_aeee);           /* call 0x1008b1e4 */
            ii(0x100a_60d2, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x100a_60d5, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_60d8, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100a_60db, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_60de, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_60e1, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100a_60e4, 5); call(Definitions.my_ctor_0x101b_4184, -0x2_f5f9); /* call 0x10076af0 */
            ii(0x100a_60e9, 3); sub(eax, 0x17);                         /* sub eax, 0x17 */
            ii(0x100a_60ec, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_60ef, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_60f2, 7); mov(memd[ds, eax + 0x2], 0x101b_4e84);  /* mov dword [eax+0x2], 0x101b4e84 */
            ii(0x100a_60f9, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_60fc, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_60ff, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100a_6102, 5); call(0x1008_8b44, -0x1_d5c3);           /* call 0x10088b44 */
            ii(0x100a_6107, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_610a, 4); mov(memb[ds, eax + 0x1b], 0x1);         /* mov byte [eax+0x1b], 0x1 */
            ii(0x100a_610e, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_6111, 4); mov(memb[ds, eax + 0x1c], 0x1);         /* mov byte [eax+0x1c], 0x1 */
            ii(0x100a_6115, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_6118, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100a_611b, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100a_611e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_6120, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_6121, 1); pop(edi);                               /* pop edi */
            ii(0x100a_6122, 1); pop(esi);                               /* pop esi */
            ii(0x100a_6123, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_6124, 1); ret();                                  /* ret */
        }
    }
}
