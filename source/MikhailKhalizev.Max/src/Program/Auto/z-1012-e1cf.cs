using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_e1cf-998e1d91")]
        public void Method_1012_e1cf()
        {
            ii(0x1012_e1cf, 5); push(0x20);                             /* push 0x20 */
            ii(0x1012_e1d4, 5); call(Definitions.sys_check_available_stack_size, 0x3_7b79); /* call 0x10165d52 */
            ii(0x1012_e1d9, 1); push(ebx);                              /* push ebx */
            ii(0x1012_e1da, 1); push(ecx);                              /* push ecx */
            ii(0x1012_e1db, 1); push(esi);                              /* push esi */
            ii(0x1012_e1dc, 1); push(edi);                              /* push edi */
            ii(0x1012_e1dd, 1); push(ebp);                              /* push ebp */
            ii(0x1012_e1de, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_e1e0, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1012_e1e6, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_e1e9, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1012_e1ec, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1012_e1f0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_e1f2, 2); if(jl(0x1012_e205, 0x11)) goto l_0x1012_e205; /* jl 0x1012e205 */
            ii(0x1012_e1f4, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_e1f7, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1012_e1fa, 5); call(Definitions.my_1_get_count, -0x8_2d27); /* call 0x100ab4d8 */
            ii(0x1012_e1ff, 4); cmp(ax, memw[ss, ebp - 0x4]);           /* cmp ax, [ebp-0x4] */
            ii(0x1012_e203, 2); if(jg(0x1012_e20a, 0x5)) goto l_0x1012_e20a; /* jg 0x1012e20a */
        l_0x1012_e205:
            ii(0x1012_e205, 5); jmp(0x1012_e29f, 0x95); goto l_0x1012_e29f; /* jmp 0x1012e29f */
        l_0x1012_e20a:
            ii(0x1012_e20a, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1012_e20e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_e211, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1012_e214, 5); call(0x100e_8634, -0x4_5be5);           /* call 0x100e8634 */
            ii(0x1012_e219, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_e21b, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x1012_e220, 5); call(0x1007_6e00, -0xb_7425);           /* call 0x10076e00 */
            ii(0x1012_e225, 2); test(al, al);                           /* test al, al */
            ii(0x1012_e227, 2); if(jz(0x1012_e233, 0xa)) goto l_0x1012_e233; /* jz 0x1012e233 */
            ii(0x1012_e229, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_e22c, 7); mov(memb[ds, eax + 0x9d], 0x1);         /* mov byte [eax+0x9d], 0x1 */
        l_0x1012_e233:
            ii(0x1012_e233, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1012_e237, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_e23a, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1012_e23d, 5); call(0x100e_8634, -0x4_5c0e);           /* call 0x100e8634 */
            ii(0x1012_e242, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_e244, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x1012_e249, 5); call(0x1007_6630, -0xb_7c1e);           /* call 0x10076630 */
            ii(0x1012_e24e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_e251, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1012_e254, 4); cmp(ax, memw[ds, edx + 0x30]);          /* cmp ax, [edx+0x30] */
            ii(0x1012_e258, 2); if(jge(0x1012_e264, 0xa)) goto l_0x1012_e264; /* jge 0x1012e264 */
            ii(0x1012_e25a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_e25d, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1012_e260, 4); mov(memw[ds, edx + 0x30], ax);          /* mov [edx+0x30], ax */
        l_0x1012_e264:
            ii(0x1012_e264, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_e267, 3); mov(edx, memd[ds, eax + 0x2e]);         /* mov edx, [eax+0x2e] */
            ii(0x1012_e26a, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1012_e26d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_e270, 3); mov(eax, memd[ds, eax + 0x38]);         /* mov eax, [eax+0x38] */
            ii(0x1012_e273, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_e276, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_e278, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1012_e27c, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1012_e27e, 2); if(jl(0x1012_e292, 0x12)) goto l_0x1012_e292; /* jl 0x1012e292 */
            ii(0x1012_e280, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_e283, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1012_e286, 4); sub(dx, memw[ds, eax + 0x3a]);          /* sub dx, [eax+0x3a] */
            ii(0x1012_e28a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_e28d, 1); inc(edx);                               /* inc edx */
            ii(0x1012_e28e, 4); mov(memw[ds, eax + 0x30], dx);          /* mov [eax+0x30], dx */
        l_0x1012_e292:
            ii(0x1012_e292, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1012_e297, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_e29a, 5); call(0x1013_0c16, 0x2977);              /* call 0x10130c16 */
        l_0x1012_e29f:
            ii(0x1012_e29f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_e2a1, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_e2a2, 1); pop(edi);                               /* pop edi */
            ii(0x1012_e2a3, 1); pop(esi);                               /* pop esi */
            ii(0x1012_e2a4, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_e2a5, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_e2a6, 1); ret();                                  /* ret */
        }
    }
}
