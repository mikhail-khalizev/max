using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_846d-71252d14")]
        public void my_dtor_d4()
        {
            ii(0x100d_846d, 5); push(0x34);                             /* push 0x34 */
            ii(0x100d_8472, 5); call(Definitions.sys_check_available_stack_size, 0x8_d8db); /* call 0x10165d52 */
            ii(0x100d_8477, 1); push(ebx);                              /* push ebx */
            ii(0x100d_8478, 1); push(ecx);                              /* push ecx */
            ii(0x100d_8479, 1); push(esi);                              /* push esi */
            ii(0x100d_847a, 1); push(edi);                              /* push edi */
            ii(0x100d_847b, 1); push(ebp);                              /* push ebp */
            ii(0x100d_847c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_847e, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100d_8484, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100d_8487, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100d_848a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_848d, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x100d_8490, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100d_8493, 4); cmp(memd[ss, ebp - 0x18], 0);           /* cmp dword [ebp-0x18], 0x0 */
            ii(0x100d_8497, 2); if(jz(0x100d_84ad, 0x14)) goto l_0x100d_84ad; /* jz 0x100d84ad */
            ii(0x100d_8499, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_849b, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100d_849e, 5); call(Definitions.my_dtor_d2, -0x9f6b);  /* call 0x100ce538 */
            ii(0x100d_84a3, 5); call(Definitions.sys_delete, 0x8_dabc); /* call 0x10165f64 */
            ii(0x100d_84a8, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100d_84ab, 2); jmp(0x100d_84b4, 7); goto l_0x100d_84b4; /* jmp 0x100d84b4 */
        l_0x100d_84ad:
            ii(0x100d_84ad, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
        l_0x100d_84b4:
            ii(0x100d_84b4, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_84b7, 3); mov(eax, memd[ds, eax + 0xa]);          /* mov eax, [eax+0xa] */
            ii(0x100d_84ba, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100d_84bd, 4); cmp(memd[ss, ebp - 0x14], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x100d_84c1, 2); if(jz(0x100d_84d7, 0x14)) goto l_0x100d_84d7; /* jz 0x100d84d7 */
            ii(0x100d_84c3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_84c5, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_84c8, 5); call(Definitions.my_dtor_d2, -0x9f95);  /* call 0x100ce538 */
            ii(0x100d_84cd, 5); call(Definitions.sys_delete, 0x8_da92); /* call 0x10165f64 */
            ii(0x100d_84d2, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100d_84d5, 2); jmp(0x100d_84de, 7); goto l_0x100d_84de; /* jmp 0x100d84de */
        l_0x100d_84d7:
            ii(0x100d_84d7, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
        l_0x100d_84de:
            ii(0x100d_84de, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_84e1, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100d_84e4, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100d_84e7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_84e9, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_84ea, 1); pop(edi);                               /* pop edi */
            ii(0x100d_84eb, 1); pop(esi);                               /* pop esi */
            ii(0x100d_84ec, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_84ed, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_84ee, 1); ret();                                  /* ret */
        }
    }
}
