using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_e79e-f2a2cedf")]
        public void Method_1007_e79e()
        {
            ii(0x1007_e79e, 5); push(0x24);                             /* push 0x24 */
            ii(0x1007_e7a3, 5); call(Definitions.sys_check_available_stack_size, 0xe_75aa); /* call 0x10165d52 */
            ii(0x1007_e7a8, 1); push(ebx);                              /* push ebx */
            ii(0x1007_e7a9, 1); push(ecx);                              /* push ecx */
            ii(0x1007_e7aa, 1); push(esi);                              /* push esi */
            ii(0x1007_e7ab, 1); push(edi);                              /* push edi */
            ii(0x1007_e7ac, 1); push(ebp);                              /* push ebp */
            ii(0x1007_e7ad, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_e7af, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_e7b5, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_e7b8, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_e7bb, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_e7be, 3); mov(al, memb[ds, eax + 0x4e]);          /* mov al, [eax+0x4e] */
            ii(0x1007_e7c1, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_e7c6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_e7c8, 2); if(jz(0x1007_e7d9, 0xf)) goto l_0x1007_e7d9; /* jz 0x1007e7d9 */
            ii(0x1007_e7ca, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1007_e7cd, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_e7d0, 5); call(0x1015_2a52, 0xd_427d);            /* call 0x10152a52 */
            ii(0x1007_e7d5, 2); test(al, al);                           /* test al, al */
            ii(0x1007_e7d7, 2); if(jnz(0x1007_e7df, 0x6)) goto l_0x1007_e7df; /* jnz 0x1007e7df */
        l_0x1007_e7d9:
            ii(0x1007_e7d9, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x1007_e7dd, 2); jmp(0x1007_e807, 0x28); goto l_0x1007_e807; /* jmp 0x1007e807 */
        l_0x1007_e7df:
            ii(0x1007_e7df, 5); mov(ebx, 0x1007_e73e);                  /* mov ebx, 0x1007e73e */
            ii(0x1007_e7e4, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1007_e7e7, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_e7ea, 5); call(0x1007_8d4a, -0x5aa5);             /* call 0x10078d4a */
            ii(0x1007_e7ef, 2); test(al, al);                           /* test al, al */
            ii(0x1007_e7f1, 2); if(jz(0x1007_e7f9, 0x6)) goto l_0x1007_e7f9; /* jz 0x1007e7f9 */
            ii(0x1007_e7f3, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
            ii(0x1007_e7f7, 2); jmp(0x1007_e807, 0xe); goto l_0x1007_e807; /* jmp 0x1007e807 */
        l_0x1007_e7f9:
            ii(0x1007_e7f9, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_e7fc, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_e7ff, 5); call(0x1007_e812, 0xe);                 /* call 0x1007e812 */
            ii(0x1007_e804, 3); mov(memb[ss, ebp - 0xc], al);           /* mov [ebp-0xc], al */
        l_0x1007_e807:
            ii(0x1007_e807, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1007_e80a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_e80c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_e80d, 1); pop(edi);                               /* pop edi */
            ii(0x1007_e80e, 1); pop(esi);                               /* pop esi */
            ii(0x1007_e80f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_e810, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_e811, 1); ret();                                  /* ret */
        }
    }
}
