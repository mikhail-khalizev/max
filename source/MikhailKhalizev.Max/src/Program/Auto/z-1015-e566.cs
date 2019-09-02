using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_e566-23d5aeba")]
        public void Method_1015_e566()
        {
            ii(0x1015_e566, 5); push(0x20);                             /* push 0x20 */
            ii(0x1015_e56b, 5); call(Definitions.sys_check_available_stack_size, 0x77e2); /* call 0x10165d52 */
            ii(0x1015_e570, 1); push(ebx);                              /* push ebx */
            ii(0x1015_e571, 1); push(ecx);                              /* push ecx */
            ii(0x1015_e572, 1); push(edx);                              /* push edx */
            ii(0x1015_e573, 1); push(esi);                              /* push esi */
            ii(0x1015_e574, 1); push(edi);                              /* push edi */
            ii(0x1015_e575, 1); push(ebp);                              /* push ebp */
            ii(0x1015_e576, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_e578, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x1015_e57e, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1015_e581, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_e584, 5); call(0x1015_410e, -0xa47b);             /* call 0x1015410e */
            ii(0x1015_e589, 2); test(al, al);                           /* test al, al */
            ii(0x1015_e58b, 6); if(jz(0x1015_e608, 0x77)) goto l_0x1015_e608; /* jz 0x1015e608 */
            ii(0x1015_e591, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_e594, 5); call(0x1007_611c, -0xe_847d);           /* call 0x1007611c */
            ii(0x1015_e599, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_e59b, 2); if(jz(0x1015_e5ba, 0x1d)) goto l_0x1015_e5ba; /* jz 0x1015e5ba */
            ii(0x1015_e59d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_e5a0, 4); mov(memb[ds, eax + 0x3d], 0x10);        /* mov byte [eax+0x3d], 0x10 */
            ii(0x1015_e5a4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_e5a7, 4); mov(memb[ds, eax + 0x3e], 3);           /* mov byte [eax+0x3e], 0x3 */
            ii(0x1015_e5ab, 5); mov(edx, 0x21);                         /* mov edx, 0x21 */
            ii(0x1015_e5b0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_e5b3, 5); call(0x1016_2f0a, 0x4952);              /* call 0x10162f0a */
            ii(0x1015_e5b8, 2); jmp(0x1015_e5e1, 0x27); goto l_0x1015_e5e1; /* jmp 0x1015e5e1 */
        l_0x1015_e5ba:
            ii(0x1015_e5ba, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_e5bd, 5); call(0x1016_1621, 0x305f);              /* call 0x10161621 */
            ii(0x1015_e5c2, 5); call(0x1015_50bc, -0x950b);             /* call 0x101550bc */
            ii(0x1015_e5c7, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1015_e5ca, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_e5cc, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1015_e5ce, 5); call(0x1014_a205, -0x1_43ce);           /* call 0x1014a205 */
            ii(0x1015_e5d3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_e5d6, 4); mov(memb[ds, eax + 0x3d], 0);           /* mov byte [eax+0x3d], 0x0 */
            ii(0x1015_e5da, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_e5dd, 4); mov(memb[ds, eax + 0x3e], 1);           /* mov byte [eax+0x3e], 0x1 */
        l_0x1015_e5e1:
            ii(0x1015_e5e1, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_e5e3, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x1015_e5e8, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_e5eb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_e5ee, 5); call(0x1007_6074, -0xe_857f);           /* call 0x10076074 */
            ii(0x1015_e5f3, 2); test(al, al);                           /* test al, al */
            ii(0x1015_e5f5, 2); if(jnz(0x1015_e600, 9)) goto l_0x1015_e600; /* jnz 0x1015e600 */
            ii(0x1015_e5f7, 7); cmp(memb[ds, 0x101c_3980], 0);          /* cmp byte [0x101c3980], 0x0 */
            ii(0x1015_e5fe, 2); if(jz(0x1015_e608, 8)) goto l_0x1015_e608; /* jz 0x1015e608 */
        l_0x1015_e600:
            ii(0x1015_e600, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_e603, 5); call(0x1014_9fa8, -0x1_4660);           /* call 0x10149fa8 */
        l_0x1015_e608:
            ii(0x1015_e608, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_e60a, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_e60b, 1); pop(edi);                               /* pop edi */
            ii(0x1015_e60c, 1); pop(esi);                               /* pop esi */
            ii(0x1015_e60d, 1); pop(edx);                               /* pop edx */
            ii(0x1015_e60e, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_e60f, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_e610, 1); ret();                                  /* ret */
        }
    }
}
