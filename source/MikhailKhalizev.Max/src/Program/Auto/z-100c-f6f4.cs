using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_f6f4-1a2bcbc4")]
        public void Method_100c_f6f4()
        {
            ii(0x100c_f6f4, 5); push(0x50);                             /* push 0x50 */
            ii(0x100c_f6f9, 5); call(Definitions.sys_check_available_stack_size, 0x9_6654); /* call 0x10165d52 */
            ii(0x100c_f6fe, 1); push(ebx);                              /* push ebx */
            ii(0x100c_f6ff, 1); push(ecx);                              /* push ecx */
            ii(0x100c_f700, 1); push(esi);                              /* push esi */
            ii(0x100c_f701, 1); push(edi);                              /* push edi */
            ii(0x100c_f702, 1); push(ebp);                              /* push ebp */
            ii(0x100c_f703, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_f705, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x100c_f70b, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_f70e, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100c_f711, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f714, 4); cmp(memd[ds, eax + 0x18], 0);           /* cmp dword [eax+0x18], 0x0 */
            ii(0x100c_f718, 2); if(jz(0x100c_f744, 0x2a)) goto l_0x100c_f744; /* jz 0x100cf744 */
            ii(0x100c_f71a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f71d, 3); mov(eax, memd[ds, eax + 0x18]);         /* mov eax, [eax+0x18] */
            ii(0x100c_f720, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100c_f723, 4); cmp(memd[ss, ebp - 0x1c], 0);           /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x100c_f727, 2); if(jz(0x100c_f73d, 0x14)) goto l_0x100c_f73d; /* jz 0x100cf73d */
            ii(0x100c_f729, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_f72b, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100c_f72e, 5); call(Definitions.my_dtor_d3, 0x8600);   /* call 0x100d7d33 */
            ii(0x100c_f733, 5); call(Definitions.sys_delete, 0x9_682c); /* call 0x10165f64 */
            ii(0x100c_f738, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100c_f73b, 2); jmp(0x100c_f744, 0x7); goto l_0x100c_f744; /* jmp 0x100cf744 */
        l_0x100c_f73d:
            ii(0x100c_f73d, 7); mov(memd[ss, ebp - 0x18], 0);           /* mov dword [ebp-0x18], 0x0 */
        l_0x100c_f744:
            ii(0x100c_f744, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100c_f749, 5); call(Definitions.sys_new, 0x9_66b2);    /* call 0x10165e00 */
            ii(0x100c_f74e, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100c_f751, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100c_f754, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_f757, 4); cmp(memd[ss, ebp - 0x10], 0);           /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100c_f75b, 2); if(jz(0x100c_f795, 0x38)) goto l_0x100c_f795; /* jz 0x100cf795 */
            ii(0x100c_f75d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f760, 3); mov(eax, memd[ds, eax + 0x8]);          /* mov eax, [eax+0x8] */
            ii(0x100c_f763, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_f766, 1); push(eax);                              /* push eax */
            ii(0x100c_f767, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f76a, 3); mov(ecx, memd[ds, eax + 0x6]);          /* mov ecx, [eax+0x6] */
            ii(0x100c_f76d, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100c_f770, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f773, 3); mov(ebx, memd[ds, eax + 0x4]);          /* mov ebx, [eax+0x4] */
            ii(0x100c_f776, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100c_f779, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f77c, 3); mov(edx, memd[ds, eax + 0x2]);          /* mov edx, [eax+0x2] */
            ii(0x100c_f77f, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_f782, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100c_f785, 5); call(0x100d_7bdc, 0x8452);              /* call 0x100d7bdc */
            ii(0x100c_f78a, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100c_f78d, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_f790, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x100c_f793, 2); jmp(0x100c_f79b, 0x6); goto l_0x100c_f79b; /* jmp 0x100cf79b */
        l_0x100c_f795:
            ii(0x100c_f795, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_f798, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
        l_0x100c_f79b:
            ii(0x100c_f79b, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100c_f79e, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_f7a1, 3); mov(memd[ds, edx + 0x18], eax);         /* mov [edx+0x18], eax */
            ii(0x100c_f7a4, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f7a7, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x100c_f7aa, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_f7ad, 1); push(eax);                              /* push eax */
            ii(0x100c_f7ae, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f7b1, 3); mov(eax, memd[ds, eax + 0x18]);         /* mov eax, [eax+0x18] */
            ii(0x100c_f7b4, 5); call(0x100d_4e8c, 0x56d3);              /* call 0x100d4e8c */
            ii(0x100c_f7b9, 1); push(eax);                              /* push eax */
            ii(0x100c_f7ba, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f7bd, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x100c_f7c0, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_f7c3, 1); push(eax);                              /* push eax */
            ii(0x100c_f7c4, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f7c7, 3); mov(eax, memd[ds, eax + 0x8]);          /* mov eax, [eax+0x8] */
            ii(0x100c_f7ca, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_f7cd, 1); push(eax);                              /* push eax */
            ii(0x100c_f7ce, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f7d1, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x100c_f7d4, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_f7d7, 1); push(eax);                              /* push eax */
            ii(0x100c_f7d8, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_f7db, 1); push(eax);                              /* push eax */
            ii(0x100c_f7dc, 5); call(/* sys */ 0x1016_abbc, 0x9_b3db);  /* call 0x1016abbc */
            ii(0x100c_f7e1, 3); add(esp, 0x18);                         /* add esp, 0x18 */
            ii(0x100c_f7e4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_f7e6, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_f7e7, 1); pop(edi);                               /* pop edi */
            ii(0x100c_f7e8, 1); pop(esi);                               /* pop esi */
            ii(0x100c_f7e9, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_f7ea, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_f7eb, 1); ret();                                  /* ret */
        }
    }
}
