using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_2a6d-17b0cf87")]
        public void Method_100c_2a6d()
        {
            ii(0x100c_2a6d, 5); push(0x20);                             /* push 0x20 */
            ii(0x100c_2a72, 5); call(Definitions.sys_check_available_stack_size, 0xa_32db); /* call 0x10165d52 */
            ii(0x100c_2a77, 1); push(ebx);                              /* push ebx */
            ii(0x100c_2a78, 1); push(ecx);                              /* push ecx */
            ii(0x100c_2a79, 1); push(esi);                              /* push esi */
            ii(0x100c_2a7a, 1); push(edi);                              /* push edi */
            ii(0x100c_2a7b, 1); push(ebp);                              /* push ebp */
            ii(0x100c_2a7c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_2a7e, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100c_2a84, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_2a87, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100c_2a8a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_2a8d, 4); cmp(memd[ds, eax + 0x63], 0);           /* cmp dword [eax+0x63], 0x0 */
            ii(0x100c_2a91, 2); if(jz(0x100c_2ab5, 0x22)) goto l_0x100c_2ab5; /* jz 0x100c2ab5 */
            ii(0x100c_2a93, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_2a96, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100c_2a99, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100c_2a9c, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_2a9e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_2aa1, 3); mov(edx, memd[ds, eax + 0x63]);         /* mov edx, [eax+0x63] */
            ii(0x100c_2aa4, 2); add(edx, ebx);                          /* add edx, ebx */
            ii(0x100c_2aa6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_2aa9, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100c_2aab, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_2aae, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x100c_2ab0, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_2ab2, 3); or(memb[ds, eax], 1);                   /* or byte [eax], 0x1 */
        l_0x100c_2ab5:
            ii(0x100c_2ab5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_2ab7, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_2ab8, 1); pop(edi);                               /* pop edi */
            ii(0x100c_2ab9, 1); pop(esi);                               /* pop esi */
            ii(0x100c_2aba, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_2abb, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_2abc, 1); ret();                                  /* ret */
        }
    }
}
