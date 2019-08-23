using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_7312-fcdc1546")]
        public void Method_100f_7312()
        {
            ii(0x100f_7312, 5); push(0x30);                             /* push 0x30 */
            ii(0x100f_7317, 5); call(Definitions.sys_check_available_stack_size, 0x6_ea36); /* call 0x10165d52 */
            ii(0x100f_731c, 1); push(esi);                              /* push esi */
            ii(0x100f_731d, 1); push(edi);                              /* push edi */
            ii(0x100f_731e, 1); push(ebp);                              /* push ebp */
            ii(0x100f_731f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_7321, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100f_7327, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100f_732a, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x100f_732d, 3); mov(memd[ss, ebp - 0x8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x100f_7330, 3); mov(memd[ss, ebp - 0x4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x100f_7333, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_7336, 5); call(0x1007_611c, -0x8_121f);           /* call 0x1007611c */
            ii(0x100f_733b, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100f_733e, 4); movsx(ebx, memw[ss, ebp - 0x8]);        /* movsx ebx, word [ebp-0x8] */
            ii(0x100f_7342, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x100f_7346, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100f_7349, 5); call(0x100f_1f41, -0x540d);             /* call 0x100f1f41 */
            ii(0x100f_734e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_7350, 6); if(jz(0x100f_73d8, 0x82)) goto l_0x100f_73d8; /* jz 0x100f73d8 */
            ii(0x100f_7356, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x100f_735b, 1); push(eax);                              /* push eax */
            ii(0x100f_735c, 4); movsx(ecx, memw[ss, ebp - 0x8]);        /* movsx ecx, word [ebp-0x8] */
            ii(0x100f_7360, 4); movsx(ebx, memw[ss, ebp - 0xc]);        /* movsx ebx, word [ebp-0xc] */
            ii(0x100f_7364, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_7366, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x100f_736b, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100f_736e, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_7371, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x100f_7374, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_7377, 5); call(0x1007_02b9, -0x8_70c3);           /* call 0x100702b9 */
            ii(0x100f_737c, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x100f_737f, 2); if(jz(0x100f_73d8, 0x57)) goto l_0x100f_73d8; /* jz 0x100f73d8 */
            ii(0x100f_7381, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_7384, 4); test(memb[ds, eax + 0x12], 0x40);       /* test byte [eax+0x12], 0x40 */
            ii(0x100f_7388, 2); if(jz(0x100f_7398, 0xe)) goto l_0x100f_7398; /* jz 0x100f7398 */
            ii(0x100f_738a, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100f_738d, 3); mov(eax, memd[ds, eax + 0x18]);         /* mov eax, [eax+0x18] */
            ii(0x100f_7390, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_7393, 3); cmp(eax, memd[ss, ebp - 0xc]);          /* cmp eax, [ebp-0xc] */
            ii(0x100f_7396, 2); if(jle(0x100f_739a, 0x2)) goto l_0x100f_739a; /* jle 0x100f739a */
        l_0x100f_7398:
            ii(0x100f_7398, 2); jmp(0x100f_73a9, 0xf); goto l_0x100f_73a9; /* jmp 0x100f73a9 */
        l_0x100f_739a:
            ii(0x100f_739a, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100f_739d, 3); mov(eax, memd[ds, eax + 0x18]);         /* mov eax, [eax+0x18] */
            ii(0x100f_73a0, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_73a3, 1); inc(eax);                               /* inc eax */
            ii(0x100f_73a4, 3); cmp(eax, memd[ss, ebp - 0xc]);          /* cmp eax, [ebp-0xc] */
            ii(0x100f_73a7, 2); if(jge(0x100f_73ab, 0x2)) goto l_0x100f_73ab; /* jge 0x100f73ab */
        l_0x100f_73a9:
            ii(0x100f_73a9, 2); jmp(0x100f_73b9, 0xe); goto l_0x100f_73b9; /* jmp 0x100f73b9 */
        l_0x100f_73ab:
            ii(0x100f_73ab, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100f_73ae, 3); mov(eax, memd[ds, eax + 0x1a]);         /* mov eax, [eax+0x1a] */
            ii(0x100f_73b1, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_73b4, 3); cmp(eax, memd[ss, ebp - 0x8]);          /* cmp eax, [ebp-0x8] */
            ii(0x100f_73b7, 2); if(jle(0x100f_73bb, 0x2)) goto l_0x100f_73bb; /* jle 0x100f73bb */
        l_0x100f_73b9:
            ii(0x100f_73b9, 2); jmp(0x100f_73ca, 0xf); goto l_0x100f_73ca; /* jmp 0x100f73ca */
        l_0x100f_73bb:
            ii(0x100f_73bb, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100f_73be, 3); mov(eax, memd[ds, eax + 0x1a]);         /* mov eax, [eax+0x1a] */
            ii(0x100f_73c1, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_73c4, 1); inc(eax);                               /* inc eax */
            ii(0x100f_73c5, 3); cmp(eax, memd[ss, ebp - 0x8]);          /* cmp eax, [ebp-0x8] */
            ii(0x100f_73c8, 2); if(jge(0x100f_73cc, 0x2)) goto l_0x100f_73cc; /* jge 0x100f73cc */
        l_0x100f_73ca:
            ii(0x100f_73ca, 2); jmp(0x100f_73d2, 0x6); goto l_0x100f_73d2; /* jmp 0x100f73d2 */
        l_0x100f_73cc:
            ii(0x100f_73cc, 4); mov(memb[ss, ebp - 0x14], 0x11);        /* mov byte [ebp-0x14], 0x11 */
            ii(0x100f_73d0, 2); jmp(0x100f_73ee, 0x1c); goto l_0x100f_73ee; /* jmp 0x100f73ee */
        l_0x100f_73d2:
            ii(0x100f_73d2, 4); mov(memb[ss, ebp - 0x14], 0x18);        /* mov byte [ebp-0x14], 0x18 */
            ii(0x100f_73d6, 2); jmp(0x100f_73ee, 0x16); goto l_0x100f_73ee; /* jmp 0x100f73ee */
        l_0x100f_73d8:
            ii(0x100f_73d8, 4); cmp(memd[ss, ebp - 0x4], 0);            /* cmp dword [ebp-0x4], 0x0 */
            ii(0x100f_73dc, 2); if(jz(0x100f_73e4, 0x6)) goto l_0x100f_73e4; /* jz 0x100f73e4 */
            ii(0x100f_73de, 4); mov(memb[ss, ebp - 0x1c], 0x11);        /* mov byte [ebp-0x1c], 0x11 */
            ii(0x100f_73e2, 2); jmp(0x100f_73e8, 0x4); goto l_0x100f_73e8; /* jmp 0x100f73e8 */
        l_0x100f_73e4:
            ii(0x100f_73e4, 4); mov(memb[ss, ebp - 0x1c], 0x15);        /* mov byte [ebp-0x1c], 0x15 */
        l_0x100f_73e8:
            ii(0x100f_73e8, 3); mov(al, memb[ss, ebp - 0x1c]);          /* mov al, [ebp-0x1c] */
            ii(0x100f_73eb, 3); mov(memb[ss, ebp - 0x14], al);          /* mov [ebp-0x14], al */
        l_0x100f_73ee:
            ii(0x100f_73ee, 3); mov(al, memb[ss, ebp - 0x14]);          /* mov al, [ebp-0x14] */
            ii(0x100f_73f1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_73f3, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_73f4, 1); pop(edi);                               /* pop edi */
            ii(0x100f_73f5, 1); pop(esi);                               /* pop esi */
            ii(0x100f_73f6, 1); ret();                                  /* ret */
        }
    }
}
