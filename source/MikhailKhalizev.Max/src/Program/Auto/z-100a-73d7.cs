using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_73d7-7ae6d973")]
        public void Method_100a_73d7()
        {
            ii(0x100a_73d7, 5); push(0x34);                             /* push 0x34 */
            ii(0x100a_73dc, 5); call(Definitions.sys_check_available_stack_size, 0xb_e971); /* call 0x10165d52 */
            ii(0x100a_73e1, 1); push(ecx);                              /* push ecx */
            ii(0x100a_73e2, 1); push(esi);                              /* push esi */
            ii(0x100a_73e3, 1); push(edi);                              /* push edi */
            ii(0x100a_73e4, 1); push(ebp);                              /* push ebp */
            ii(0x100a_73e5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_73e7, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x100a_73ed, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_73f0, 3); mov(memd[ss, ebp - 0x8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100a_73f3, 3); mov(memd[ss, ebp - 0x4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x100a_73f6, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_73f9, 5); call(0x1013_aaa8, 0x9_36aa);            /* call 0x1013aaa8 */
            ii(0x100a_73fe, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_7401, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100a_7404, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100a_7407, 5); call(0x100a_ab28, 0x371c);              /* call 0x100aab28 */
            ii(0x100a_740c, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100a_740f, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_7412, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100a_7415, 5); call(0x100a_aad4, 0x36ba);              /* call 0x100aaad4 */
            ii(0x100a_741a, 3); sub(eax, 0x6);                          /* sub eax, 0x6 */
            ii(0x100a_741d, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_7420, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100a_7423, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100a_7426, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_7429, 3); add(eax, 0x16);                         /* add eax, 0x16 */
            ii(0x100a_742c, 5); call(Definitions.my_ctor_0x101b_38f8, -0x3_0d41); /* call 0x100766f0 */
            ii(0x100a_7431, 3); sub(eax, 0x16);                         /* sub eax, 0x16 */
            ii(0x100a_7434, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_7437, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100a_743a, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100a_743d, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_7440, 3); add(eax, 0x1a);                         /* add eax, 0x1a */
            ii(0x100a_7443, 5); call(Definitions.my_ctor_0x101b_3b58, -0x1_c3a4); /* call 0x1008b0a4 */
            ii(0x100a_7448, 3); sub(eax, 0x1a);                         /* sub eax, 0x1a */
            ii(0x100a_744b, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_744e, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100a_7451, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_7454, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_7457, 7); mov(memd[ds, eax + 0x2], 0x101b_4e04);  /* mov dword [eax+0x2], 0x101b4e04 */
            ii(0x100a_745e, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100a_7461, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_7464, 3); add(eax, 0x16);                         /* add eax, 0x16 */
            ii(0x100a_7467, 5); call(0x1007_6630, -0x3_0e3c);           /* call 0x10076630 */
            ii(0x100a_746c, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_746f, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_7472, 3); add(eax, 0x1a);                         /* add eax, 0x1a */
            ii(0x100a_7475, 5); call(0x1008_afe4, -0x1_c496);           /* call 0x1008afe4 */
            ii(0x100a_747a, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_747d, 4); mov(memb[ds, eax + 0x1e], 0);           /* mov byte [eax+0x1e], 0x0 */
            ii(0x100a_7481, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_7484, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x100a_7487, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100a_748a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_748c, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_748d, 1); pop(edi);                               /* pop edi */
            ii(0x100a_748e, 1); pop(esi);                               /* pop esi */
            ii(0x100a_748f, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_7490, 1); ret();                                  /* ret */
        }
    }
}
