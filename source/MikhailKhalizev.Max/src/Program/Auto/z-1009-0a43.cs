using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_0a43-e6928f")]
        public void Method_1009_0a43()
        {
            ii(0x1009_0a43, 5); push(0x24);                             /* push 0x24 */
            ii(0x1009_0a48, 5); call(Definitions.sys_check_available_stack_size, 0xd_5305); /* call 0x10165d52 */
            ii(0x1009_0a4d, 1); push(esi);                              /* push esi */
            ii(0x1009_0a4e, 1); push(edi);                              /* push edi */
            ii(0x1009_0a4f, 1); push(ebp);                              /* push ebp */
            ii(0x1009_0a50, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_0a52, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1009_0a58, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1009_0a5b, 3); mov(memd[ss, ebp - 12], edx);           /* mov [ebp-0xc], edx */
            ii(0x1009_0a5e, 3); mov(memd[ss, ebp - 8], ebx);            /* mov [ebp-0x8], ebx */
            ii(0x1009_0a61, 3); mov(memd[ss, ebp - 4], ecx);            /* mov [ebp-0x4], ecx */
            ii(0x1009_0a64, 4); movsx(edx, memw[ss, ebp - 12]);         /* movsx edx, word [ebp-0xc] */
            ii(0x1009_0a68, 3); shl(edx, 2);                            /* shl edx, 0x2 */
            ii(0x1009_0a6b, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1009_0a6e, 3); mov(eax, memd[ds, eax + 39]);           /* mov eax, [eax+0x27] */
            ii(0x1009_0a71, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_0a73, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x1009_0a77, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1009_0a79, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1009_0a7b, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_0a7d, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1009_0a80, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_0a83, 3); sub(memd[ss, ebp - 4], eax);            /* sub [ebp-0x4], eax */
        l_0x1009_0a86:
            ii(0x1009_0a86, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_0a89, 3); dec(memd[ss, ebp - 4]);                 /* dec dword [ebp-0x4] */
            ii(0x1009_0a8c, 1); cwde();                                 /* cwde */
            ii(0x1009_0a8d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_0a8f, 2); if(jle(0x1009_0aa4, 0x13)) goto l_0x1009_0aa4; /* jle 0x10090aa4 */
            ii(0x1009_0a91, 3); mov(edx, memd[ss, ebp - 20]);           /* mov edx, [ebp-0x14] */
            ii(0x1009_0a94, 4); add(memd[ss, ebp - 20], 2);             /* add dword [ebp-0x14], 0x2 */
            ii(0x1009_0a98, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1009_0a9b, 4); mov(ax, memw[ds, eax + 43]);            /* mov ax, [eax+0x2b] */
            ii(0x1009_0a9f, 3); mov(memw[ds, edx], ax);                 /* mov [edx], ax */
            ii(0x1009_0aa2, 2); jmp(0x1009_0a86, -0x1e); goto l_0x1009_0a86; /* jmp 0x10090a86 */
        l_0x1009_0aa4:
            ii(0x1009_0aa4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_0aa6, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_0aa7, 1); pop(edi);                               /* pop edi */
            ii(0x1009_0aa8, 1); pop(esi);                               /* pop esi */
            ii(0x1009_0aa9, 1); ret();                                  /* ret */
        }
    }
}
