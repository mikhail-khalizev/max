using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_6188-12b9c9c8")]
        public void Method_1007_6188()
        {
            ii(0x1007_6188, 5); push(0x24);                             /* push 0x24 */
            ii(0x1007_618d, 5); call(Definitions.sys_check_available_stack_size, 0xe_fbc0); /* call 0x10165d52 */
            ii(0x1007_6192, 1); push(ebx);                              /* push ebx */
            ii(0x1007_6193, 1); push(ecx);                              /* push ecx */
            ii(0x1007_6194, 1); push(edx);                              /* push edx */
            ii(0x1007_6195, 1); push(esi);                              /* push esi */
            ii(0x1007_6196, 1); push(edi);                              /* push edi */
            ii(0x1007_6197, 1); push(ebp);                              /* push ebp */
            ii(0x1007_6198, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_619a, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1007_61a0, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1007_61a3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_61a6, 4); cmp(memd[ds, eax + 0x7e], 0);           /* cmp dword [eax+0x7e], 0x0 */
            ii(0x1007_61aa, 2); if(jz(0x1007_61c1, 0x15)) goto l_0x1007_61c1; /* jz 0x100761c1 */
            ii(0x1007_61ac, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_61af, 3); mov(eax, memd[ds, eax + 0x7e]);         /* mov eax, [eax+0x7e] */
            ii(0x1007_61b2, 5); call(0x1007_6338, 0x181);               /* call 0x10076338 */
            ii(0x1007_61b7, 5); call(0x1007_653c, 0x380);               /* call 0x1007653c */
            ii(0x1007_61bc, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1007_61bf, 2); jmp(0x1007_61c8, 7); goto l_0x1007_61c8; /* jmp 0x100761c8 */
        l_0x1007_61c1:
            ii(0x1007_61c1, 7); mov(memd[ss, ebp - 8], 0);              /* mov dword [ebp-0x8], 0x0 */
        l_0x1007_61c8:
            ii(0x1007_61c8, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_61cb, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_61cd, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_61ce, 1); pop(edi);                               /* pop edi */
            ii(0x1007_61cf, 1); pop(esi);                               /* pop esi */
            ii(0x1007_61d0, 1); pop(edx);                               /* pop edx */
            ii(0x1007_61d1, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_61d2, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_61d3, 1); ret();                                  /* ret */
        }
    }
}
