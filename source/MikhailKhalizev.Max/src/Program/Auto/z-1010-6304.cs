using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_6304-f2a37ad0")]
        public void Method_1010_6304()
        {
            ii(0x1010_6304, 5); push(0x4c);                             /* push 0x4c */
            ii(0x1010_6309, 5); call(Definitions.sys_check_available_stack_size, 0x5_fa44); /* call 0x10165d52 */
            ii(0x1010_630e, 1); push(ecx);                              /* push ecx */
            ii(0x1010_630f, 1); push(esi);                              /* push esi */
            ii(0x1010_6310, 1); push(edi);                              /* push edi */
            ii(0x1010_6311, 1); push(ebp);                              /* push ebp */
            ii(0x1010_6312, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_6314, 6); sub(esp, 0x38);                         /* sub esp, 0x38 */
            ii(0x1010_631a, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1010_631d, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1010_6320, 3); mov(memb[ss, ebp - 4], bl);             /* mov [ebp-0x4], bl */
            ii(0x1010_6323, 5); mov(eax, 0x4b);                         /* mov eax, 0x4b */
            ii(0x1010_6328, 5); call(0x1007_5fdc, -0x9_0351);           /* call 0x10075fdc */
            ii(0x1010_632d, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1010_6330, 5); mov(eax, 0x4a);                         /* mov eax, 0x4a */
            ii(0x1010_6335, 5); call(0x1007_5fdc, -0x9_035e);           /* call 0x10075fdc */
            ii(0x1010_633a, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1010_633d, 6); mov(edx, memd[ds, 0x101c_3966]);        /* mov edx, [0x101c3966] */
            ii(0x1010_6343, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_6346, 5); mov(eax, 0x4b);                         /* mov eax, 0x4b */
            ii(0x1010_634b, 5); call(0x100c_aafc, -0x3_b854);           /* call 0x100caafc */
            ii(0x1010_6350, 6); mov(edx, memd[ds, 0x101c_3964]);        /* mov edx, [0x101c3964] */
            ii(0x1010_6356, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_6359, 5); mov(eax, 0x4a);                         /* mov eax, 0x4a */
            ii(0x1010_635e, 5); call(0x100c_aafc, -0x3_b867);           /* call 0x100caafc */
        l_0x1010_6363:
            ii(0x1010_6363, 3); inc(memb[ss, ebp - 4]);                 /* inc byte [ebp-0x4] */
            ii(0x1010_6366, 4); movsx(eax, memb[ss, ebp - 4]);          /* movsx eax, byte [ebp-0x4] */
            ii(0x1010_636a, 3); lea(eax, memd[ds, eax + eax * 8]);      /* lea eax, [eax+eax*8] */
            ii(0x1010_636d, 7); test(memb[ds, eax + 0x101b_8b88], 1);   /* test byte [eax+0x101b8b88], 0x1 */
            ii(0x1010_6374, 2); if(jnz(0x1010_637c, 6)) goto l_0x1010_637c; /* jnz 0x1010637c */
            ii(0x1010_6376, 4); cmp(memb[ss, ebp - 4], 0x76);           /* cmp byte [ebp-0x4], 0x76 */
            ii(0x1010_637a, 2); if(jl(0x1010_637e, 2)) goto l_0x1010_637e; /* jl 0x1010637e */
        l_0x1010_637c:
            ii(0x1010_637c, 2); jmp(0x1010_63d0, 0x52); goto l_0x1010_63d0; /* jmp 0x101063d0 */
        l_0x1010_637e:
            ii(0x1010_637e, 4); movsx(eax, memb[ss, ebp - 4]);          /* movsx eax, byte [ebp-0x4] */
            ii(0x1010_6382, 3); lea(eax, memd[ds, eax + eax * 8]);      /* lea eax, [eax+eax*8] */
            ii(0x1010_6385, 7); test(memb[ds, eax + 0x101b_8b88], 2);   /* test byte [eax+0x101b8b88], 0x2 */
            ii(0x1010_638c, 2); if(jz(0x1010_63aa, 0x1c)) goto l_0x1010_63aa; /* jz 0x101063aa */
            ii(0x1010_638e, 4); movsx(edx, memb[ss, ebp - 4]);          /* movsx edx, byte [ebp-0x4] */
            ii(0x1010_6392, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1010_6395, 5); call(0x1010_61bb, -0x1df);              /* call 0x101061bb */
            ii(0x1010_639a, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1010_639d, 3); mov(edx, memd[ss, ebp - 0x18]);         /* mov edx, [ebp-0x18] */
            ii(0x1010_63a0, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_63a3, 5); call(0x1010_6a2c, 0x684);               /* call 0x10106a2c */
            ii(0x1010_63a8, 2); jmp(0x1010_63ce, 0x24); goto l_0x1010_63ce; /* jmp 0x101063ce */
        l_0x1010_63aa:
            ii(0x1010_63aa, 5); mov(ecx, 0x1e);                         /* mov ecx, 0x1e */
            ii(0x1010_63af, 3); lea(ebx, memd[ss, ebp - 0x38]);         /* lea ebx, [ebp-0x38] */
            ii(0x1010_63b2, 4); movsx(edx, memb[ss, ebp - 4]);          /* movsx edx, byte [ebp-0x4] */
            ii(0x1010_63b6, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1010_63b9, 5); call(0x1010_6281, -0x13d);              /* call 0x10106281 */
            ii(0x1010_63be, 5); mov(ebx, 0x1e);                         /* mov ebx, 0x1e */
            ii(0x1010_63c3, 3); lea(edx, memd[ss, ebp - 0x38]);         /* lea edx, [ebp-0x38] */
            ii(0x1010_63c6, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_63c9, 5); call(0x1013_c055, 0x3_5c87);            /* call 0x1013c055 */
        l_0x1010_63ce:
            ii(0x1010_63ce, 2); jmp(0x1010_6363, -0x6d); goto l_0x1010_6363; /* jmp 0x10106363 */
        l_0x1010_63d0:
            ii(0x1010_63d0, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1010_63d4, 5); mov(eax, 0x4b);                         /* mov eax, 0x4b */
            ii(0x1010_63d9, 5); call(0x100c_aafc, -0x3_b8e2);           /* call 0x100caafc */
            ii(0x1010_63de, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1010_63e2, 5); mov(eax, 0x4a);                         /* mov eax, 0x4a */
            ii(0x1010_63e7, 5); call(0x100c_aafc, -0x3_b8f0);           /* call 0x100caafc */
            ii(0x1010_63ec, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_63ee, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_63ef, 1); pop(edi);                               /* pop edi */
            ii(0x1010_63f0, 1); pop(esi);                               /* pop esi */
            ii(0x1010_63f1, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_63f2, 1); ret();                                  /* ret */
        }
    }
}
