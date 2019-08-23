using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_36ac-828ce475")]
        public void Method_1012_36ac()
        {
            ii(0x1012_36ac, 5); push(0x1c);                             /* push 0x1c */
            ii(0x1012_36b1, 5); call(Definitions.sys_check_available_stack_size, 0x4_269c); /* call 0x10165d52 */
            ii(0x1012_36b6, 1); push(ebx);                              /* push ebx */
            ii(0x1012_36b7, 1); push(esi);                              /* push esi */
            ii(0x1012_36b8, 1); push(edi);                              /* push edi */
            ii(0x1012_36b9, 1); push(ebp);                              /* push ebp */
            ii(0x1012_36ba, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_36bc, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1012_36c2, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_36c5, 1); push(eax);                              /* push eax */
            ii(0x1012_36c6, 5); call(0x1012_361d, -0xae);               /* call 0x1012361d */
            ii(0x1012_36cb, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1012_36ce, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_36d0, 2); if(jz(0x1012_36e9, 0x17)) goto l_0x1012_36e9; /* jz 0x101236e9 */
            ii(0x1012_36d2, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_36d5, 6); mov(eax, memd[ds, eax + 0x84]);         /* mov eax, [eax+0x84] */
            ii(0x1012_36db, 5); call(Definitions.sys_free, 0x4_79e1);   /* call 0x1016b0c1 */
            ii(0x1012_36e0, 7); mov(memd[ss, ebp - 0x4], 0x1);          /* mov dword [ebp-0x4], 0x1 */
            ii(0x1012_36e7, 2); jmp(0x1012_36f0, 0x7); goto l_0x1012_36f0; /* jmp 0x101236f0 */
        l_0x1012_36e9:
            ii(0x1012_36e9, 7); mov(memd[ss, ebp - 0x4], 0);            /* mov dword [ebp-0x4], 0x0 */
        l_0x1012_36f0:
            ii(0x1012_36f0, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_36f3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_36f5, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_36f6, 1); pop(edi);                               /* pop edi */
            ii(0x1012_36f7, 1); pop(esi);                               /* pop esi */
            ii(0x1012_36f8, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_36f9, 1); ret();                                  /* ret */
        }
    }
}
