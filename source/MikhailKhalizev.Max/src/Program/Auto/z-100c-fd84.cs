using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_fd84-ea1cd50e")]
        public void Method_100c_fd84()
        {
            ii(0x100c_fd84, 5); push(0x28);                             /* push 0x28 */
            ii(0x100c_fd89, 5); call(Definitions.sys_check_available_stack_size, 0x9_5fc4); /* call 0x10165d52 */
            ii(0x100c_fd8e, 1); push(ebx);                              /* push ebx */
            ii(0x100c_fd8f, 1); push(ecx);                              /* push ecx */
            ii(0x100c_fd90, 1); push(esi);                              /* push esi */
            ii(0x100c_fd91, 1); push(edi);                              /* push edi */
            ii(0x100c_fd92, 1); push(ebp);                              /* push ebp */
            ii(0x100c_fd93, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_fd95, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100c_fd9b, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_fd9e, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100c_fda1, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_fda4, 5); call(0x1009_caf8, -0x3_32b1);           /* call 0x1009caf8 */
        l_0x100c_fda9:
            ii(0x100c_fda9, 3); lea(ecx, ebp - 0xc);                    /* lea ecx, [ebp-0xc] */
            ii(0x100c_fdac, 5); mov(ebx, 0x101c_7140);                  /* mov ebx, 0x101c7140 */
            ii(0x100c_fdb1, 5); mov(edx, StringDefinitions.Unit);       /* mov edx, 0x101a146c */
            ii(0x100c_fdb6, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_fdb9, 5); call(0x1014_5eac, 0x7_60ee);            /* call 0x10145eac */
            ii(0x100c_fdbe, 2); test(al, al);                           /* test al, al */
            ii(0x100c_fdc0, 2); if(jz(0x100c_fdd5, 0x13)) goto l_0x100c_fdd5; /* jz 0x100cfdd5 */
            ii(0x100c_fdc2, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100c_fdc5, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_fdc8, 3); lea(edx, ebp - 0x10);                   /* lea edx, [ebp-0x10] */
            ii(0x100c_fdcb, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_fdce, 5); call(0x1008_b2a8, -0x4_4b2b);           /* call 0x1008b2a8 */
            ii(0x100c_fdd3, 2); jmp(0x100c_fda9, -0x2c); goto l_0x100c_fda9; /* jmp 0x100cfda9 */
        l_0x100c_fdd5:
            ii(0x100c_fdd5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_fdd7, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_fdd8, 1); pop(edi);                               /* pop edi */
            ii(0x100c_fdd9, 1); pop(esi);                               /* pop esi */
            ii(0x100c_fdda, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_fddb, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_fddc, 1); ret();                                  /* ret */
        }
    }
}
