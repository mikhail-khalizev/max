using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_2b85-6811391")]
        public void Method_100c_2b85()
        {
            ii(0x100c_2b85, 5); push(0x24);                             /* push 0x24 */
            ii(0x100c_2b8a, 5); call(Definitions.sys_check_available_stack_size, 0xa_31c3); /* call 0x10165d52 */
            ii(0x100c_2b8f, 1); push(ebx);                              /* push ebx */
            ii(0x100c_2b90, 1); push(ecx);                              /* push ecx */
            ii(0x100c_2b91, 1); push(esi);                              /* push esi */
            ii(0x100c_2b92, 1); push(edi);                              /* push edi */
            ii(0x100c_2b93, 1); push(ebp);                              /* push ebp */
            ii(0x100c_2b94, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_2b96, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_2b9c, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_2b9f, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100c_2ba2, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_2ba5, 4); cmp(memd[ds, eax + 0x67], 0);           /* cmp dword [eax+0x67], 0x0 */
            ii(0x100c_2ba9, 2); if(jnz(0x100c_2bb4, 9)) goto l_0x100c_2bb4; /* jnz 0x100c2bb4 */
            ii(0x100c_2bab, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
            ii(0x100c_2bb2, 2); jmp(0x100c_2bda, 0x26); goto l_0x100c_2bda; /* jmp 0x100c2bda */
        l_0x100c_2bb4:
            ii(0x100c_2bb4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_2bb7, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100c_2bba, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100c_2bbd, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_2bbf, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_2bc2, 3); mov(edx, memd[ds, eax + 0x67]);         /* mov edx, [eax+0x67] */
            ii(0x100c_2bc5, 2); add(edx, ebx);                          /* add edx, ebx */
            ii(0x100c_2bc7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_2bca, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100c_2bcc, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_2bcf, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x100c_2bd1, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_2bd3, 4); movsx(ax, memb[ds, eax]);               /* movsx ax, byte [eax] */
            ii(0x100c_2bd7, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
        l_0x100c_2bda:
            ii(0x100c_2bda, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100c_2bdd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_2bdf, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_2be0, 1); pop(edi);                               /* pop edi */
            ii(0x100c_2be1, 1); pop(esi);                               /* pop esi */
            ii(0x100c_2be2, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_2be3, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_2be4, 1); ret();                                  /* ret */
        }
    }
}
