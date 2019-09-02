using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_44aa-aea83e04")]
        public void Method_100d_44aa()
        {
            ii(0x100d_44aa, 5); push(0x28);                             /* push 0x28 */
            ii(0x100d_44af, 5); call(Definitions.sys_check_available_stack_size, 0x9_189e); /* call 0x10165d52 */
            ii(0x100d_44b4, 1); push(ebx);                              /* push ebx */
            ii(0x100d_44b5, 1); push(ecx);                              /* push ecx */
            ii(0x100d_44b6, 1); push(edx);                              /* push edx */
            ii(0x100d_44b7, 1); push(esi);                              /* push esi */
            ii(0x100d_44b8, 1); push(edi);                              /* push edi */
            ii(0x100d_44b9, 1); push(ebp);                              /* push ebp */
            ii(0x100d_44ba, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_44bc, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100d_44c2, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100d_44c5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_44c8, 3); mov(eax, memd[ds, eax + 0x3e]);         /* mov eax, [eax+0x3e] */
            ii(0x100d_44cb, 5); call(0x100d_0149, -0x4387);             /* call 0x100d0149 */
            ii(0x100d_44d0, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100d_44d3, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x100d_44d7, 5); call(0x100c_dec2, -0x661a);             /* call 0x100cdec2 */
            ii(0x100d_44dc, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_44de, 2); if(jnz(0x100d_44ec, 0xc)) goto l_0x100d_44ec; /* jnz 0x100d44ec */
            ii(0x100d_44e0, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x100d_44e5, 5); call(0x100e_0e00, 0xc916);              /* call 0x100e0e00 */
            ii(0x100d_44ea, 2); jmp(0x100d_451a, 0x2e); goto l_0x100d_451a; /* jmp 0x100d451a */
        l_0x100d_44ec:
            ii(0x100d_44ec, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_44ef, 6); mov(eax, memd[ds, eax + 0x8d]);         /* mov eax, [eax+0x8d] */
            ii(0x100d_44f5, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100d_44f8, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_44fb, 3); mov(ecx, memd[ds, eax + 0x40]);         /* mov ecx, [eax+0x40] */
            ii(0x100d_44fe, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_4501, 6); mov(eax, memd[ds, eax + 0x8d]);         /* mov eax, [eax+0x8d] */
            ii(0x100d_4507, 5); call(0x100d_5018, 0xb0c);               /* call 0x100d5018 */
            ii(0x100d_450c, 1); inc(eax);                               /* inc eax */
            ii(0x100d_450d, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100d_4510, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x100d_4514, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_4517, 3); call_abs(memd[ds, ecx + 4]);            /* call dword [ecx+0x4] */
        l_0x100d_451a:
            ii(0x100d_451a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_451c, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_451d, 1); pop(edi);                               /* pop edi */
            ii(0x100d_451e, 1); pop(esi);                               /* pop esi */
            ii(0x100d_451f, 1); pop(edx);                               /* pop edx */
            ii(0x100d_4520, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_4521, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_4522, 1); ret();                                  /* ret */
        }
    }
}
