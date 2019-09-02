using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_7ec8-9dd3289")]
        public void Method_100e_7ec8()
        {
            ii(0x100e_7ec8, 5); push(0x28);                             /* push 0x28 */
            ii(0x100e_7ecd, 5); call(Definitions.sys_check_available_stack_size, 0x7_de80); /* call 0x10165d52 */
            ii(0x100e_7ed2, 1); push(ebx);                              /* push ebx */
            ii(0x100e_7ed3, 1); push(ecx);                              /* push ecx */
            ii(0x100e_7ed4, 1); push(edx);                              /* push edx */
            ii(0x100e_7ed5, 1); push(esi);                              /* push esi */
            ii(0x100e_7ed6, 1); push(edi);                              /* push edi */
            ii(0x100e_7ed7, 1); push(ebp);                              /* push ebp */
            ii(0x100e_7ed8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_7eda, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_7ee0, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_7ee3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_7ee6, 3); cmp(memd[ds, eax], 0);                  /* cmp dword [eax], 0x0 */
            ii(0x100e_7ee9, 2); if(jz(0x100e_7f37, 0x4c)) goto l_0x100e_7f37; /* jz 0x100e7f37 */
            ii(0x100e_7eeb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_7eee, 4); mov(ax, memw[ds, eax + 0xc]);           /* mov ax, [eax+0xc] */
            ii(0x100e_7ef2, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100e_7ef5, 4); sub(ax, memw[ds, edx + 4]);             /* sub ax, [edx+0x4] */
            ii(0x100e_7ef9, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100e_7efc, 7); mov(memd[ss, ebp - 8], 0);              /* mov dword [ebp-0x8], 0x0 */
            ii(0x100e_7f03, 2); jmp(0x100e_7f0b, 6); goto l_0x100e_7f0b; /* jmp 0x100e7f0b */
        l_0x100e_7f05:
            ii(0x100e_7f05, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_7f08, 3); inc(memd[ss, ebp - 8]);                 /* inc dword [ebp-0x8] */
        l_0x100e_7f0b:
            ii(0x100e_7f0b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_7f0e, 4); cmp(ax, memw[ss, ebp - 0xc]);           /* cmp ax, [ebp-0xc] */
            ii(0x100e_7f12, 2); if(jge(0x100e_7f2d, 0x19)) goto l_0x100e_7f2d; /* jge 0x100e7f2d */
            ii(0x100e_7f14, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x100e_7f18, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100e_7f1b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_7f1d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_7f20, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100e_7f22, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100e_7f24, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100e_7f26, 5); call(Definitions.sys_delete, 0x7_e039); /* call 0x10165f64 */
            ii(0x100e_7f2b, 2); jmp(0x100e_7f05, -0x28); goto l_0x100e_7f05; /* jmp 0x100e7f05 */
        l_0x100e_7f2d:
            ii(0x100e_7f2d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_7f30, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100e_7f32, 5); call(Definitions.sys_delete, 0x7_e02d); /* call 0x10165f64 */
        l_0x100e_7f37:
            ii(0x100e_7f37, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_7f3a, 6); mov(memd[ds, eax], 0);                  /* mov dword [eax], 0x0 */
            ii(0x100e_7f40, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_7f42, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_7f43, 1); pop(edi);                               /* pop edi */
            ii(0x100e_7f44, 1); pop(esi);                               /* pop esi */
            ii(0x100e_7f45, 1); pop(edx);                               /* pop edx */
            ii(0x100e_7f46, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_7f47, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_7f48, 1); ret();                                  /* ret */
        }
    }
}
