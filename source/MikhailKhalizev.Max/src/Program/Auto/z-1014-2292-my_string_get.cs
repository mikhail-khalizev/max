using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_2292-6c3b33e8")]
        public void my_string_get()
        {
            ii(0x1014_2292, 5); push(0x28);                             /* push 0x28 */
            ii(0x1014_2297, 5); call(Definitions.sys_check_available_stack_size, 0x2_3ab6); /* call 0x10165d52 */
            ii(0x1014_229c, 1); push(ebx);                              /* push ebx */
            ii(0x1014_229d, 1); push(ecx);                              /* push ecx */
            ii(0x1014_229e, 1); push(esi);                              /* push esi */
            ii(0x1014_229f, 1); push(edi);                              /* push edi */
            ii(0x1014_22a0, 1); push(ebp);                              /* push ebp */
            ii(0x1014_22a1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_22a3, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1014_22a9, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_22ac, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_22af, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_22b2, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1014_22b4, 5); call(Definitions.my_strobj_get_size, 0x2a3); /* call 0x1014255c */
            ii(0x1014_22b9, 4); cmp(ax, memw[ss, ebp - 0x4]);           /* cmp ax, [ebp-0x4] */
            ii(0x1014_22bd, 2); if(jle(0x1014_22c8, 0x9)) goto l_0x1014_22c8; /* jle 0x101422c8 */
            ii(0x1014_22bf, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
            ii(0x1014_22c6, 2); jmp(0x1014_22e1, 0x19); goto l_0x1014_22e1; /* jmp 0x101422e1 */
        l_0x1014_22c8:
            ii(0x1014_22c8, 5); mov(ecx, 0x115);                        /* mov ecx, 0x115 */
            ii(0x1014_22cd, 5); mov(ebx, StringDefinitions.StrobjCpp2); /* mov ebx, 0x101aceae */
            ii(0x1014_22d2, 5); mov(edx, StringDefinitions.PosLessPtrGetsize); /* mov edx, 0x101aceb9 */
            ii(0x1014_22d7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_22d9, 5); call(Definitions.sys_assert, 0x2_3ab4); /* call 0x10165d92 */
            ii(0x1014_22de, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
        l_0x1014_22e1:
            ii(0x1014_22e1, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_22e4, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1014_22e6, 5); call(Definitions.my_strobj_c_str, -0xb_8aef); /* call 0x100897fc */
            ii(0x1014_22eb, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1014_22ef, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1014_22f1, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_22f4, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_22f7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_22f9, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_22fa, 1); pop(edi);                               /* pop edi */
            ii(0x1014_22fb, 1); pop(esi);                               /* pop esi */
            ii(0x1014_22fc, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_22fd, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_22fe, 1); ret();                                  /* ret */
        }
    }
}
