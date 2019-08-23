using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_7c6e-fa8566c")]
        public void Method_100c_7c6e()
        {
            ii(0x100c_7c6e, 5); push(0x28);                             /* push 0x28 */
            ii(0x100c_7c73, 5); call(Definitions.sys_check_available_stack_size, 0x9_e0da); /* call 0x10165d52 */
            ii(0x100c_7c78, 1); push(ecx);                              /* push ecx */
            ii(0x100c_7c79, 1); push(esi);                              /* push esi */
            ii(0x100c_7c7a, 1); push(edi);                              /* push edi */
            ii(0x100c_7c7b, 1); push(ebp);                              /* push ebp */
            ii(0x100c_7c7c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_7c7e, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100c_7c84, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100c_7c87, 3); mov(memd[ss, ebp - 0x8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100c_7c8a, 3); mov(memd[ss, ebp - 0x4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x100c_7c8d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_7c90, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x100c_7c93, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x100c_7c96, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100c_7c99, 3); mov(eax, memd[ds, eax + 0x27]);         /* mov eax, [eax+0x27] */
            ii(0x100c_7c9c, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100c_7c9e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_7ca1, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100c_7ca3, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_7ca6, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x100c_7ca8, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100c_7caa, 3); mov(memd[ss, ebp - 0x10], edx);         /* mov [ebp-0x10], edx */
        l_0x100c_7cad:
            ii(0x100c_7cad, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_7cb0, 4); mov(ax, memw[ds, eax + 0x2]);           /* mov ax, [eax+0x2] */
            ii(0x100c_7cb4, 4); cmp(ax, memw[ss, ebp - 0x4]);           /* cmp ax, [ebp-0x4] */
            ii(0x100c_7cb8, 2); if(jge(0x100c_7cc9, 0xf)) goto l_0x100c_7cc9; /* jge 0x100c7cc9 */
            ii(0x100c_7cba, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_7cbd, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x100c_7cbf, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100c_7cc4, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100c_7cc7, 2); if(jz(0x100c_7ccb, 0x2)) goto l_0x100c_7ccb; /* jz 0x100c7ccb */
        l_0x100c_7cc9:
            ii(0x100c_7cc9, 2); jmp(0x100c_7cda, 0xf); goto l_0x100c_7cda; /* jmp 0x100c7cda */
        l_0x100c_7ccb:
            ii(0x100c_7ccb, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_7cce, 3); inc(memd[ss, ebp - 0x10]);              /* inc dword [ebp-0x10] */
            ii(0x100c_7cd1, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_7cd4, 4); inc(memw[ds, eax + 0x2]);               /* inc word [eax+0x2] */
            ii(0x100c_7cd8, 2); jmp(0x100c_7cad, -0x2d); goto l_0x100c_7cad; /* jmp 0x100c7cad */
        l_0x100c_7cda:
            ii(0x100c_7cda, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_7cdd, 4); mov(ax, memw[ds, eax + 0x2]);           /* mov ax, [eax+0x2] */
            ii(0x100c_7ce1, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100c_7ce4, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_7ce7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_7ce9, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_7cea, 1); pop(edi);                               /* pop edi */
            ii(0x100c_7ceb, 1); pop(esi);                               /* pop esi */
            ii(0x100c_7cec, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_7ced, 1); ret();                                  /* ret */
        }
    }
}
