using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_1dea-792774c")]
        public void my_string_append_char()
        {
            ii(0x1014_1dea, 5); push(0x28);                             /* push 0x28 */
            ii(0x1014_1def, 5); call(Definitions.sys_check_available_stack_size, 0x2_3f5e); /* call 0x10165d52 */
            ii(0x1014_1df4, 1); push(ebx);                              /* push ebx */
            ii(0x1014_1df5, 1); push(ecx);                              /* push ecx */
            ii(0x1014_1df6, 1); push(esi);                              /* push esi */
            ii(0x1014_1df7, 1); push(edi);                              /* push edi */
            ii(0x1014_1df8, 1); push(ebp);                              /* push ebp */
            ii(0x1014_1df9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_1dfb, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1014_1e01, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_1e04, 3); mov(memb[ss, ebp - 4], dl);             /* mov [ebp-0x4], dl */
            ii(0x1014_1e07, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_1e0a, 5); call(Definitions.my_string_make_single_ref, 0x54d); /* call 0x1014235c */
            ii(0x1014_1e0f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_1e12, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1014_1e14, 5); call(Definitions.my_strobj_get_len, -0x5_6ef5); /* call 0x100eaf24 */
            ii(0x1014_1e19, 1); inc(eax);                               /* inc eax */
            ii(0x1014_1e1a, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1014_1e1d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_1e20, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1014_1e22, 5); call(Definitions.my_strobj_get_size, 0x735); /* call 0x1014255c */
            ii(0x1014_1e27, 4); cmp(ax, memw[ss, ebp - 12]);            /* cmp ax, [ebp-0xc] */
            ii(0x1014_1e2b, 2); if(jge(0x1014_1e4a, 0x1d)) goto l_0x1014_1e4a; /* jge 0x10141e4a */
            ii(0x1014_1e2d, 5); call(Definitions.my_set_al_1, 0x69a);   /* call 0x101424cc */
            ii(0x1014_1e32, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_1e34, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1014_1e36, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x1014_1e3a, 5); call(Definitions.my_string_compute_capacity_from_length, 0x599); /* call 0x101423d8 */
            ii(0x1014_1e3f, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1014_1e42, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_1e45, 5); call(Definitions.my_string_reserve, -0x2e8); /* call 0x10141b62 */
        l_0x1014_1e4a:
            ii(0x1014_1e4a, 4); movsx(edx, memw[ss, ebp - 12]);         /* movsx edx, word [ebp-0xc] */
            ii(0x1014_1e4e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_1e51, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1014_1e53, 5); call(Definitions.my_strobj_c_str, -0xb_865c); /* call 0x100897fc */
            ii(0x1014_1e58, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1014_1e5a, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x1014_1e5d, 3); mov(memb[ds, edx - 1], al);             /* mov [edx-0x1], al */
            ii(0x1014_1e60, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_1e63, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1014_1e65, 5); call(Definitions.my_strobj_c_str, -0xb_866e); /* call 0x100897fc */
            ii(0x1014_1e6a, 4); movsx(edx, memw[ss, ebp - 12]);         /* movsx edx, word [ebp-0xc] */
            ii(0x1014_1e6e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1014_1e70, 3); mov(memb[ds, eax], 0);                  /* mov byte [eax], 0x0 */
            ii(0x1014_1e73, 4); movsx(edx, memw[ss, ebp - 12]);         /* movsx edx, word [ebp-0xc] */
            ii(0x1014_1e77, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_1e7a, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1014_1e7c, 5); call(Definitions.my_strobj_set_len, 0x66b); /* call 0x101424ec */
            ii(0x1014_1e81, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_1e84, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1014_1e87, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1014_1e8a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_1e8c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_1e8d, 1); pop(edi);                               /* pop edi */
            ii(0x1014_1e8e, 1); pop(esi);                               /* pop esi */
            ii(0x1014_1e8f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_1e90, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_1e91, 1); ret();                                  /* ret */
        }
    }
}
