using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_beeb-117e2e47")]
        public void Method_100a_beeb()
        {
            ii(0x100a_beeb, 5); push(0x30);                             /* push 0x30 */
            ii(0x100a_bef0, 5); call(Definitions.sys_check_available_stack_size, 0xb_9e5d); /* call 0x10165d52 */
            ii(0x100a_bef5, 1); push(esi);                              /* push esi */
            ii(0x100a_bef6, 1); push(edi);                              /* push edi */
            ii(0x100a_bef7, 1); push(ebp);                              /* push ebp */
            ii(0x100a_bef8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_befa, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x100a_bf00, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_bf03, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x100a_bf06, 3); mov(memb[ss, ebp - 4], bl);             /* mov [ebp-0x4], bl */
            ii(0x100a_bf09, 3); mov(memd[ss, ebp - 8], ecx);            /* mov [ebp-0x8], ecx */
            ii(0x100a_bf0c, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100a_bf0f, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_bf12, 5); call(0x1007_5e64, -0x3_60b3);           /* call 0x10075e64 */
            ii(0x100a_bf17, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100a_bf19, 4); movsx(ebx, memb[ss, ebp - 4]);          /* movsx ebx, byte [ebp-0x4] */
            ii(0x100a_bf1d, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100a_bf20, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_bf23, 5); call(0x1011_d0ea, 0x7_11c2);            /* call 0x1011d0ea */
            ii(0x100a_bf28, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_bf2b, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100a_bf2e, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100a_bf31, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_bf34, 3); add(eax, 0x1a);                         /* add eax, 0x1a */
            ii(0x100a_bf37, 5); call(0x100b_7ed8, 0xbf9c);              /* call 0x100b7ed8 */
            ii(0x100a_bf3c, 3); sub(eax, 0x1a);                         /* sub eax, 0x1a */
            ii(0x100a_bf3f, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_bf42, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100a_bf45, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100a_bf48, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_bf4b, 7); mov(memd[ds, eax + 2], 0x101b_5514);    /* mov dword [eax+0x2], 0x101b5514 */
            ii(0x100a_bf52, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_bf55, 4); mov(memb[ds, eax + 0x1e], 0);           /* mov byte [eax+0x1e], 0x0 */
            ii(0x100a_bf59, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_bf5c, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x100a_bf5f, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100a_bf62, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_bf64, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_bf65, 1); pop(edi);                               /* pop edi */
            ii(0x100a_bf66, 1); pop(esi);                               /* pop esi */
            ii(0x100a_bf67, 1); ret();                                  /* ret */
        }
    }
}
