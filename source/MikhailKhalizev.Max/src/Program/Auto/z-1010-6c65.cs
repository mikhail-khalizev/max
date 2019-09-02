using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_6c65-ac5fb76b")]
        public void Method_1010_6c65()
        {
            ii(0x1010_6c65, 5); push(0x2c);                             /* push 0x2c */
            ii(0x1010_6c6a, 5); call(Definitions.sys_check_available_stack_size, 0x5_f0e3); /* call 0x10165d52 */
            ii(0x1010_6c6f, 1); push(ebx);                              /* push ebx */
            ii(0x1010_6c70, 1); push(ecx);                              /* push ecx */
            ii(0x1010_6c71, 1); push(edx);                              /* push edx */
            ii(0x1010_6c72, 1); push(esi);                              /* push esi */
            ii(0x1010_6c73, 1); push(edi);                              /* push edi */
            ii(0x1010_6c74, 1); push(ebp);                              /* push ebp */
            ii(0x1010_6c75, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_6c77, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x1010_6c7d, 5); call(0x1010_6bb0, -0xd2);               /* call 0x10106bb0 */
            ii(0x1010_6c82, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1010_6c85, 7); cmp(memd[ss, ebp - 4], 0x5b_8d80);      /* cmp dword [ebp-0x4], 0x5b8d80 */
            ii(0x1010_6c8c, 2); if(jge(0x1010_6caf, 0x21)) goto l_0x1010_6caf; /* jge 0x10106caf */
            ii(0x1010_6c8e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_6c91, 1); push(eax);                              /* push eax */
            ii(0x1010_6c92, 5); push(0x5b_8d80);                        /* push 0x5b8d80 */
            ii(0x1010_6c97, 5); mov(eax, StringDefinitions.NotEnoughExtendedMemoryAvailableToRunMAXAmountNeededIAmountFoundI); /* mov eax, 0x101a43d4 */
            ii(0x1010_6c9c, 1); push(eax);                              /* push eax */
            ii(0x1010_6c9d, 5); call(Definitions.sys_printf, 0x6_599a); /* call 0x1016c63c */
            ii(0x1010_6ca2, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1010_6ca5, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1010_6caa, 5); call(Definitions.sys_exit, 0x6_59b0);   /* call 0x1016c65f */
        l_0x1010_6caf:
            ii(0x1010_6caf, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_6cb1, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_6cb2, 1); pop(edi);                               /* pop edi */
            ii(0x1010_6cb3, 1); pop(esi);                               /* pop esi */
            ii(0x1010_6cb4, 1); pop(edx);                               /* pop edx */
            ii(0x1010_6cb5, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_6cb6, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_6cb7, 1); ret();                                  /* ret */
        }
    }
}
