using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_f211-d61429e6")]
        public void Method_100c_f211()
        {
            ii(0x100c_f211, 5); push(0x38);                             /* push 0x38 */
            ii(0x100c_f216, 5); call(Definitions.sys_check_available_stack_size, 0x9_6b37); /* call 0x10165d52 */
            ii(0x100c_f21b, 1); push(ebx);                              /* push ebx */
            ii(0x100c_f21c, 1); push(ecx);                              /* push ecx */
            ii(0x100c_f21d, 1); push(esi);                              /* push esi */
            ii(0x100c_f21e, 1); push(edi);                              /* push edi */
            ii(0x100c_f21f, 1); push(ebp);                              /* push ebp */
            ii(0x100c_f220, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_f222, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x100c_f228, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_f22b, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100c_f22e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_f231, 4); cmp(memd[ds, eax + 0x10], 0);           /* cmp dword [eax+0x10], 0x0 */
            ii(0x100c_f235, 2); if(jz(0x100c_f261, 0x2a)) goto l_0x100c_f261; /* jz 0x100cf261 */
            ii(0x100c_f237, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_f23a, 3); mov(eax, memd[ds, eax + 0x10]);         /* mov eax, [eax+0x10] */
            ii(0x100c_f23d, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100c_f240, 4); cmp(memd[ss, ebp - 0xc], 0);            /* cmp dword [ebp-0xc], 0x0 */
            ii(0x100c_f244, 2); if(jz(0x100c_f25a, 0x14)) goto l_0x100c_f25a; /* jz 0x100cf25a */
            ii(0x100c_f246, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_f248, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100c_f24b, 5); call(Definitions.my_dtor_d3, 0x8ae3);   /* call 0x100d7d33 */
            ii(0x100c_f250, 5); call(Definitions.sys_delete, 0x9_6d0f); /* call 0x10165f64 */
            ii(0x100c_f255, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_f258, 2); jmp(0x100c_f261, 7); goto l_0x100c_f261; /* jmp 0x100cf261 */
        l_0x100c_f25a:
            ii(0x100c_f25a, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
        l_0x100c_f261:
            ii(0x100c_f261, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100c_f266, 5); call(Definitions.sys_new, 0x9_6b95);    /* call 0x10165e00 */
            ii(0x100c_f26b, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100c_f26e, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_f271, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100c_f274, 4); cmp(memd[ss, ebp - 0x18], 0);           /* cmp dword [ebp-0x18], 0x0 */
            ii(0x100c_f278, 2); if(jz(0x100c_f2a3, 0x29)) goto l_0x100c_f2a3; /* jz 0x100cf2a3 */
            ii(0x100c_f27a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_f27d, 3); mov(ecx, memd[ds, eax + 4]);            /* mov ecx, [eax+0x4] */
            ii(0x100c_f280, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100c_f283, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_f286, 3); mov(ebx, memd[ds, eax + 2]);            /* mov ebx, [eax+0x2] */
            ii(0x100c_f289, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100c_f28c, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x100c_f290, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_f293, 5); call(Definitions.my_ctor_c19, 0x89c6);  /* call 0x100d7c5e */
            ii(0x100c_f298, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100c_f29b, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100c_f29e, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x100c_f2a1, 2); jmp(0x100c_f2a9, 6); goto l_0x100c_f2a9; /* jmp 0x100cf2a9 */
        l_0x100c_f2a3:
            ii(0x100c_f2a3, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100c_f2a6, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
        l_0x100c_f2a9:
            ii(0x100c_f2a9, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100c_f2ac, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100c_f2af, 3); mov(memd[ds, edx + 0x10], eax);         /* mov [edx+0x10], eax */
            ii(0x100c_f2b2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_f2b4, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_f2b5, 1); pop(edi);                               /* pop edi */
            ii(0x100c_f2b6, 1); pop(esi);                               /* pop esi */
            ii(0x100c_f2b7, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_f2b8, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_f2b9, 1); ret();                                  /* ret */
        }
    }
}
