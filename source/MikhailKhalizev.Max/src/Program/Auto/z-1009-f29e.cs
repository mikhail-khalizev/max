using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_f29e-1d3afd69")]
        public void Method_1009_f29e()
        {
            ii(0x1009_f29e, 5); push(0x2c);                             /* push 0x2c */
            ii(0x1009_f2a3, 5); call(Definitions.sys_check_available_stack_size, 0xc_6aaa); /* call 0x10165d52 */
            ii(0x1009_f2a8, 1); push(ecx);                              /* push ecx */
            ii(0x1009_f2a9, 1); push(esi);                              /* push esi */
            ii(0x1009_f2aa, 1); push(edi);                              /* push edi */
            ii(0x1009_f2ab, 1); push(ebp);                              /* push ebp */
            ii(0x1009_f2ac, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_f2ae, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1009_f2b4, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_f2b7, 3); mov(memd[ss, ebp - 0x8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1009_f2ba, 3); mov(memd[ss, ebp - 0x4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1009_f2bd, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_f2c0, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1009_f2c3, 5); call(0x1007_5e64, -0x2_9464);           /* call 0x10075e64 */
            ii(0x1009_f2c8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_f2ca, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_f2cd, 3); mov(eax, memd[ds, eax + 0x7]);          /* mov eax, [eax+0x7] */
            ii(0x1009_f2d0, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_f2d3, 6); imul(ebx, eax, 0xc5);                   /* imul ebx, eax, 0xc5 */
            ii(0x1009_f2d9, 5); mov(eax, 0x101c_31c4);                  /* mov eax, 0x101c31c4 */
            ii(0x1009_f2de, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1009_f2e0, 5); call(0x100c_2b85, 0x2_38a0);            /* call 0x100c2b85 */
            ii(0x1009_f2e5, 1); cwde();                                 /* cwde */
            ii(0x1009_f2e6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_f2e8, 2); if(jg(0x1009_f2f0, 0x6)) goto l_0x1009_f2f0; /* jg 0x1009f2f0 */
            ii(0x1009_f2ea, 4); mov(memb[ss, ebp - 0x10], 0x1);         /* mov byte [ebp-0x10], 0x1 */
            ii(0x1009_f2ee, 2); jmp(0x1009_f2f4, 0x4); goto l_0x1009_f2f4; /* jmp 0x1009f2f4 */
        l_0x1009_f2f0:
            ii(0x1009_f2f0, 4); mov(memb[ss, ebp - 0x10], 0);           /* mov byte [ebp-0x10], 0x0 */
        l_0x1009_f2f4:
            ii(0x1009_f2f4, 3); mov(al, memb[ss, ebp - 0x10]);          /* mov al, [ebp-0x10] */
            ii(0x1009_f2f7, 3); mov(memb[ss, ebp - 0x14], al);          /* mov [ebp-0x14], al */
            ii(0x1009_f2fa, 3); mov(al, memb[ss, ebp - 0x14]);          /* mov al, [ebp-0x14] */
            ii(0x1009_f2fd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_f2ff, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_f300, 1); pop(edi);                               /* pop edi */
            ii(0x1009_f301, 1); pop(esi);                               /* pop esi */
            ii(0x1009_f302, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_f303, 1); ret();                                  /* ret */
        }
    }
}
